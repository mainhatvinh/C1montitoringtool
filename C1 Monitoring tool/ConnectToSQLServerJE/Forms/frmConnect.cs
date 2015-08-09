/*
 * Created by SharpDevelop.
 * User: luan.khanh.ha
 * Date: 6/3/2013
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmRetain_Popup.
	/// </summary>
	public partial class frmConnect : Form
	{
		BindingSource myBindingSource = new BindingSource(); 
		
		public frmConnect()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//comboBox1.Text = "ODBC";
			
			//string[] month = new string[12]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmRetain_PopupFormClosing(object sender, FormClosingEventArgs e)
		{
			//Close();
		}

		void Button2Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "")
				return;
			string connectionstr = "";
			if (comboBox1.Text == "ODBC")
				connectionstr = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Data_C1MonitoringTool;Data Source=HOADV0011278D2";
			if (comboBox1.Text == "SQL")
				connectionstr =@"Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Data_C1MonitoringTool;Data Source=HOADV0011278D2";
			DataConnect.ConnectData(connectionstr);
			Close();
		}
	}
}
