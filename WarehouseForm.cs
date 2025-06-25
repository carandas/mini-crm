using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBiz
{
	public partial class WarehouseForm : Form
	{
		private AppDBContext db = new AppDBContext();
		private Functions func = new Functions();
		private DataBaseReturner returner = new DataBaseReturner();
		public WarehouseForm()
		{
			InitializeComponent();
		}

		private void WarehouseForm_Load(object sender, EventArgs e)
		{
			db.products.Load();
			dataGridView1.DataSource = db.products.Local.ToBindingList();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			func.AddLineCounter(dataGridView1, e);
		}

		private void SaveToDbButton_Click(object sender, EventArgs e)
		{
			db.SaveChanges();
			Config.logList.Add(db.ChangeTracker.DebugView.LongView);
		}

		private void WarehouseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			db.SaveChanges();
			Config.logList.Add(db.ChangeTracker.DebugView.LongView);
		}

		private void ButtonSaveToCsv_Click(object sender, EventArgs e)
		{
			returner.DataToCsv(dataGridView1, saveFileDialog1.FileName);
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			func.Search(dataGridView1, SearchTextBox.Text);
		}
	}
}
