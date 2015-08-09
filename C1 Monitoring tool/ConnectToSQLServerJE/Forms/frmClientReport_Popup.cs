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


using ExcelCOM = Microsoft.Office.Interop.Excel;
namespace C1Monitoring
{
	/// <summary>
	/// Description of frmRetain_Popup.
	/// </summary>
	public partial class frmClientReport_Popup : Form
	{
		BindingSource myBindingSource = new BindingSource(); 
		string Revenue;
		string FY;
		string PIC;
		
		public frmClientReport_Popup(int role_type, string ClientCode,string ClientName, string Fiscal_Year)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			//MessageBox.Show(SorM.ToString() + " - " + Revenure_Source + " - " + Fiscal_Year + " - " + Person);
			InitializeComponent();
			txtClientCode.Text = ClientCode;
			txtClientName.Text = ClientName;
			txtYear.Text = Fiscal_Year;
			dataGridView1.DataSource = dcClientReport.GetData_ByKey(ClientCode,Fiscal_Year);
			//MessageBox.Show(dataGridView1.RowCount.ToString());
			
			//MessageBox.Show(dataGridView1.Rows[0].Cells[2].Value.ToString());
			if (dataGridView1.RowCount > 1)
				txtRemark.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
			
			
			if (role_type == 2)
			{
				txtRemark.ReadOnly = true;
				button1.Enabled = false;
			}
			else
			{
				txtRemark.ReadOnly = false;
				button1.Enabled = true;
			}	
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmRetain_PopupFormClosing(object sender, FormClosingEventArgs e)
		{
			//Close();
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
				if (txtRemark.Text == "")
				{
					MessageBox.Show("Please add your comments for this client");
					return;
				}
				dcClientReport.SubmitOne(txtClientCode.Text,txtYear.Text,txtRemark.Text);
				MessageBox.Show("Submitted successfully");
				Close();
				
			} catch (Exception) {
				
				throw ;
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
