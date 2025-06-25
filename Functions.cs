using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBiz
{
	public class Functions
	{
		public void AddLineCounter(DataGridView grid, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = grid.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				grid.Rows[index].HeaderCell.Value = indexStr;
		}


		public void Search(DataGridView dataGridView, string searchText)
		{
			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (!row.IsNewRow)
					{
						string value = cell.Value.ToString();

						if (value == searchText)
						{
							MessageBox.Show($"данные найдены в строке: {row.Index + 1}", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
							row.Selected = true;
						}
					}
				}
			}
		}
	}
}
