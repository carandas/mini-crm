using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace MiniBiz
{
	public partial class GraphForm : Form
	{
		AppDBContext db = new AppDBContext();
		List<double> profitsInCurrentMounths = new List<double>();
		List<double> profitsInLastMounths = new List<double>();

		List<double> lossesInCurrentMounths = new List<double>();
		List<double> lossesInLastMounth = new List<double>();
		public GraphForm()
		{
			InitializeComponent();



		}

		private void GraphForm_Load(object sender, EventArgs e)
		{
			ProfitCreateGraph();
			foreach (var item in db.orders.ToList())
			{
				if (item.status == "выполнен")
				{
					var dateTime = DateTime.Parse(item.CreatedAt);

					if (dateTime.Month == DateTime.Today.Month)
					{
						profitsInCurrentMounths.Add(item.OrderAmount);
					}

					if (dateTime.Month != DateTime.Today.Month)
					{
						profitsInLastMounths.Add(item.OrderAmount);
					}
				}

				if (item.status == "отменён")
				{
					var dateTime = DateTime.Parse(item.CreatedAt);

					if (dateTime.Month == DateTime.Today.Month)
					{
						lossesInCurrentMounths.Add(item.OrderAmount);
					}

					if (dateTime.Month != DateTime.Today.Month)
					{
						lossesInLastMounth.Add(item.OrderAmount);
					}
				}

			}
		}

		private void ShowProfitGraphButton_Click(object sender, EventArgs e)
		{
			ProfitCreateGraph();
		}


		private void ProfitCreateGraph()
		{
			
			cartesianChart1.Series = new ISeries[]
			{
				new LineSeries<double>
				{
					Values = profitsInCurrentMounths,
					Fill = null,
					Name = "Текущий месяц"
				},

				new LineSeries<double>
				{
					Values = profitsInLastMounths,
					Fill = null,
					Name = "Прошлые месяца"
				}
			};
		}

		private void ShowLossesGraphButton_Click(object sender, EventArgs e)
		{
			lossesInLastMounth.Sort();
			lossesInCurrentMounths.Sort();
			cartesianChart1.Series = new ISeries[]
			{
				new LineSeries<double>
				{
					Values = lossesInCurrentMounths,
					Fill = null,
					Name = "Текущий месяц"
				},

				new LineSeries<double>
				{
					Values = lossesInLastMounth,
					Fill = null,
					Name = "Прошлые месяца"
				}
			};
		}
	}
}
