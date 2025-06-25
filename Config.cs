using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBiz
{
	public class Config
	{
		public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ProjectBlender\VS\MiniBiz\DataBase\DataBase.mdf;Integrated Security=True";

		public static List<string> logList = new List<string>();
	}
}
