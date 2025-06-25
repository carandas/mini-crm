using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MiniBiz
{
	public partial class ClientForm : Form
	{
		public List<string> names = new List<string>();
		public List<string> whatsApps = new List<string>();
		public List<string> telegrams = new List<string>();
		public List<string> emails = new List<string>();
		public List<string> tags = new List<string>();
		public List<string> notes = new List<string>();
		public List<string> dates = new List<string>();

		public Dictionary<string, string> data = new Dictionary<string, string>();

		DataBaseReturner returner = new DataBaseReturner();

		private Functions func = new Functions();

		AppDBContext db = new AppDBContext();

		public ClientForm()
		{
			InitializeComponent();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

		}

		private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView1.Rows[e.RowIndex].IsNewRow == false)
			{
				var createdAt = dataGridView1.Rows[e.RowIndex].Cells["CreatedAt"];

				if (createdAt.Value.ToString() == null || createdAt.Value.ToString() == string.Empty)
				{
					createdAt.Value = DateTime.Now.ToShortDateString();
				}
			}
		
		}

		private void SaveToDbButton_Click(object sender, EventArgs e)
		{
			
			db.SaveChanges();
			Config.logList.Add(db.ChangeTracker.DebugView.LongView);
		}

		private void ClientForm_Load(object sender, EventArgs e)
		{
			//returner.SqlReturnData("select * from clients", dataGridView1);

			db.clients.Load();

			dataGridView1.DataSource = db.clients.Local.ToBindingList();
			
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				row.Cells[0].ReadOnly = true;
			}
		}

		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			func.AddLineCounter(dataGridView1, e);
		}

		private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			db.SaveChanges();
			Config.logList.Add(db.ChangeTracker.DebugView.LongView);
		}

		private void ButtonSaveToCsv_Click(object sender, EventArgs e)
		{

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				returner.DataToCsv(dataGridView1, saveFileDialog1.FileName);
			}

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (!row.IsNewRow)
					{
						string value = cell.Value.ToString();

						if (value == SearchTextBox.Text)
						{
							MessageBox.Show($"данные найдены в строке: {row.Index + 1}", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
							row.Selected = true;
						}
					}
				}
			}
		}

		//private void Filter()
		//{
			
		//	if (dataGridView1.DataSource as DataTable != null)
		//	{
		//		(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = FilterTextBox.Text;
		//	}
		//	else
		//	{
		//		MessageBox.Show("Null");
		//	}
		//}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	Filter();
		//}
	}
}
