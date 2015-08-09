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
	public partial class frmmainform_popup : Form
	{
		BindingSource myBindingSource = new BindingSource(); 
		
		public frmmainform_popup(string News_ID)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//string[] month = new string[12]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
			myBindingSource = dcNews.GetData_ByKey(News_ID);
			grdRevenue.DataSource = myBindingSource;
			//DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdRevenue);
			//grdRevenue.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			txtITRA_Content.Text = grdRevenue.Rows[0].Cells[0].Value.ToString();
			//grdRevenue.Columns["Engagement_Code"].Visible = false;
			//grdRevenue.Columns["Engagement_name"].Visible = false;
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
			Close();
		}
	}
}
