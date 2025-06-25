using Microsoft.Data.Sqlite;
using Microsoft.Win32;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.Arm;

namespace MiniBiz
{
	public partial class HomeWindow : Form
	{
		private string serialNumber = "";
		public HomeWindow()
		{
			InitializeComponent();
		}



		public void OpenCilentsFormButton_Click(object sender, EventArgs e)
		{

			ClientForm clientForm = new ClientForm();
			clientForm.Show();
		}

		private void OpenCellsFormButton_Click(object sender, EventArgs e)
		{
			OrdersForm form = new OrdersForm();
			form.Show();
		}

		private void OpenFinanceFormButton_Click(object sender, EventArgs e)
		{
			LogFrom logFrom = new LogFrom();
			logFrom.Show();
		}

		private void WarehouseButton_Click(object sender, EventArgs e)
		{
			WarehouseForm warehouseForm = new WarehouseForm();
			warehouseForm.Show();
		}

		private void GrphFromOpenButton_Click(object sender, EventArgs e)
		{
			GraphForm graphForm = new GraphForm();
			graphForm.Show();
		}

		private void HomeWindow_Load(object sender, EventArgs e)
		{

			//RegistryKey localMachine  = Registry.LocalMachine;

			//if(Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\encryptedMiniBiz", " -MatPlatID", null) == null)
			//{
			//	RegistryKey programmKey = localMachine.CreateSubKey("encryptedMiniBiz");

			//	programmKey.SetValue("MatPlatID", "");

			//	programmKey.Close();
			//}

			
		
		}

		//private void Encrypter()
		//{
		//	var ni = NetworkInterface.GetAllNetworkInterfaces()[0];

		//	var mac = ni.GetPhysicalAddress().ToString();
		//	using ()
		//	{

		//	}
		//}
	}
}
