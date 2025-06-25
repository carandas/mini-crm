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
	public partial class OrdersForm : Form
	{
		//comboBox1.Items.AddRange(new object[] { "sad", "adadafr", "asda" });
		private DataBaseReturner returner = new DataBaseReturner();
		private Functions func = new Functions();

		AppDBContext db = new AppDBContext();

		public object[] status = new object[] { "выполнен", "в разработке", "отменён", "ожидает оплаты" };

		private List<string> names = new List<string>();
		private List<int> productsIds = new List<int>();

		private int price;

		private int sum = 0;
		public OrdersForm()
		{
			InitializeComponent();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void OrdersAndCellsForm_Load(object sender, EventArgs e)
		{

			db.orders.Load();

			dataGridView1.DataSource = db.orders.Local.ToBindingList();

			SetupComboBox();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				row.Cells[0].ReadOnly = true;
			}



			UpdateTotalProfit(true);




		}

		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			func.AddLineCounter(dataGridView1, e);

		}

		private async void SaveToDbButton_Click(object sender, EventArgs e)
		{
			db.SaveChanges();
			await Task.Delay(250);
			UpdateTotalProfit(true);
		}


		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

			if (dataGridView1.Rows[e.RowIndex].IsNewRow == false)
			{
				var createdAt = dataGridView1.Rows[e.RowIndex].Cells["CreatedAt"];
				if (createdAt.Value.ToString() == null || createdAt.Value.ToString() == string.Empty)
				{
					createdAt.Value = DateTime.Now.ToShortDateString();
				}
				

				var status = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

				var orderName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

				var priceCell = dataGridView1.Rows[e.RowIndex].Cells[3];

				var setPrice = db.products.ToList().Find(x => x.Name == orderName);

				if (priceCell != null && setPrice != null)
				{
					priceCell.Value = setPrice.Price;
				}


				if (status == "отменён")
				{
					dataGridView1.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.Red;
					//UpdateTotalProfit(false, e);

				}

				if (status == "выполнен")
				{
					dataGridView1.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.Green;
					//UpdateTotalProfit(false, e);
				}

				if (status == "в разработке")
				{
					dataGridView1.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.DarkOrange;
				}


			}




			//if (dataGridView1.Columns[e.ColumnIndex].Name == "OrderName")
			//{
			//	var row = dataGridView1.Rows[e.RowIndex];
			//	var selectedProductName = row.Cells["OrderName"].Value?.ToString();

			//	if (!string.IsNullOrEmpty(selectedProductName))
			//	{
			//		// Находим товар по имени
			//		var product = db.products.FirstOrDefault(p => p.Name == selectedProductName);
			//		if (product != null)
			//		{
			//			row.Cells["OrderAmount"].Value = product.Price; // подставляем цену
			//		}
			//	}
			//}

		}

		private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			db.SaveChanges();
			Config.logList.Add(db.ChangeTracker.DebugView.LongView);
		}



		private void SetupComboBox()
		{
			GetDataFromProduct();
			int lastIndex = 4;
			int lastIndexName = 2;

			string lastColumnName = dataGridView1.Columns[4].DataPropertyName;
			string lastColumnNameName = dataGridView1.Columns[lastIndexName].DataPropertyName;

			dataGridView1.Columns.RemoveAt(lastIndex);
			dataGridView1.Columns.RemoveAt(lastIndexName);

			DataGridViewComboBoxColumn columnProgress = new DataGridViewComboBoxColumn();
			DataGridViewComboBoxColumn columnName = new DataGridViewComboBoxColumn();

			columnProgress.HeaderText = "Status";
			columnProgress.Name = lastColumnName;
			columnProgress.DataPropertyName = lastColumnName;
			columnProgress.DataSource = status;
			columnProgress.FlatStyle = FlatStyle.Flat;

			columnName.HeaderText = "OrderName";
			columnName.Name = lastColumnNameName;
			columnName.DataPropertyName = lastColumnNameName;
			columnName.DataSource = names;
			columnName.FlatStyle = FlatStyle.Flat;


			dataGridView1.Columns.Insert(lastIndex, columnProgress);
			dataGridView1.Columns.Insert(lastIndexName, columnName);


		}

		private void GetDataFromProduct()
		{
			var products = db.products.ToList();

			foreach (var product in products)
			{
				string a = $"{product.Name}";
				names.Add(a);

			}


		}

		private void ButtonSaveToCsv_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				returner.DataToCsv(dataGridView1, saveFileDialog1.FileName);
			}
		}

		private void UpdateTotalProfit(bool getFromDB, DataGridViewCellEventArgs e = null)
		{

			var completedSum = db.orders
				.Where(o => o.status == "выполнен")
				.Sum(o => o.OrderAmount);

			var canceledSum = db.orders
				.Where(o => o.status == "отменён")
				.Sum(o => o.OrderAmount);

			// Если вычитание отменённых нужно:
			var profit = completedSum;

			// Если прибыль не может быть меньше 0
			if (profit < 0)
			{
				profit = 0;
			}

			TotalProfitLabel.Text = $"Прибыль: {profit}";


		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			func.Search(dataGridView1, SearchTextBox.Text);
		}
	}



}
