﻿/*
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
	public partial class frmRetain_Popup1 : Form
	{
		BindingSource myBindingSource = new BindingSource(); 
		
		public frmRetain_Popup1(string ID_Engagement)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			myBindingSource = dcRetain.GetBudgetRetain(ID_Engagement);
			grdRetain.DataSource = myBindingSource;
			grdRetain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
