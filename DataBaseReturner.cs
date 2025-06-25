using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MiniBiz
{
	public class DataBaseReturner
	{
		public void DataToCsv(DataGridView dataGrid, string fileName)
		{
			
			using(StreamWriter sw = new StreamWriter(fileName))
			{
				for (int i = 0; i < dataGrid.RowCount; i++)
				{
					for (int j = 0; j < dataGrid.ColumnCount; j++)
					{
						if (!dataGrid.Rows[i].IsNewRow)
						{
							sw.Write(dataGrid.Rows[i].Cells[i].Value.ToString());
							if (j < dataGrid.ColumnCount - 1) sw.Write(" ");
						}
						
					}
					sw.WriteLine();
				}

				
			}
		}
	}
}
