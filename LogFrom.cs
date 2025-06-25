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
	public partial class LogFrom : Form
	{
		public LogFrom()
		{
			InitializeComponent();
		}

		public void LogFrom_Load(object sender, EventArgs e)
		{
			string text = "";
			foreach(var item in Config.logList)
			{
				text += item;
			}

			LogLabel.Text = text;
		}
	}

	
}
