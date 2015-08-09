/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace C1Monitoring
{
	/// <summary>
	/// Description of Application.
	/// </summary>
	public partial class frmInformation : MyFormPage
	{
		BindingSource myBindingSource1 = new BindingSource();
		BindingSource myBindingSource2 = new BindingSource();
		BindingSource myBindingSource3 = new BindingSource();
		
		bool flagStartOS = false;
		
		
		public frmInformation(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			
			
			DisplayGridviewOS();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				
				btnDel2.Enabled = false;
				btnSubmit2.Enabled = false;
				
				btnReset2.Enabled = false;
				
			}
			else if (Role_type == 1)
			{
				
				btnDel2.Enabled = false;
				
				btnSubmit2.Enabled = true;
				
				btnReset2.Enabled = true;
				
			}
			else if (Role_type == 4)
			{
				
				btnDel2.Enabled = true;
				
				btnSubmit2.Enabled = true;
				
				btnReset2.Enabled = true;
				
			}				
		}
			
		//OS
		
		public void DisplayGridviewOS()
		{
			myBindingSource2 = dcMainboard.GetAll();
			grdOS.DataSource = myBindingSource2;
			grdOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdOS.Columns[0].Visible = false;
			grdOS.Columns["Creator"].Visible = false;
			grdOS.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdOS);
			
		}
		void ResetOS()
		{
			
			txtInformation.Text = "";
			flagStartOS = false;
			//txtOS_Std_Hours.Text = "";			
			if (grdOS.Rows.Count >0)
				grdOS.CurrentCell = grdOS.Rows[0].Cells[1];
		}
		void ClickOneRowOS()
		{
			
			txtInformation.Text = grdOS.CurrentRow.Cells["ITRA_Information"].Value.ToString();
			txtOSID.Text = grdOS.CurrentRow.Cells["No_of_Information"].Value.ToString();
			flagStartOS	 = true;		 
		}
		
		
		void BtnReset2Click(object sender, EventArgs e)
		{
			ResetOS();
			grdOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdOS.CurrentRow.Selected = false;
		}
		
		bool IsValidateOS()
		{
			for (int i =0; i<= grdOS.RowCount -1; i++)
				if (txtInformation.Text.ToLower() == grdOS.Rows[i].Cells["ITRA_Information"].Value.ToString().ToLower())
					return false;
			return true;
		}
		
		void BtnSubmit2Click(object sender, EventArgs e)
		{			
			
			if (txtInformation.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return;
			}
		
			if (txtOSID.Text == "")
			{
				if (IsValidateOS() == true)
				{
				    dcMainboard.SubmitOne(false, txtOSID.Text, txtInformation.Text);
				    DisplayGridviewOS();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
				}
				
			}
			else if (txtInformation.Text != grdOS.CurrentRow.Cells["ITRA_Information"].Value.ToString())
			{
				if (txtInformation.Text != grdOS.CurrentRow.Cells["ITRA_Information"].Value.ToString())
				{				
				if (IsValidateOS() == true)
				{
				    dcMainboard.SubmitOne(false, txtOSID.Text, txtInformation.Text);
				    DisplayGridviewOS();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
				}
				
				}
				
			}
		}
		
		void BtnDel2Click(object sender, EventArgs e)
		{
			if (txtOSID.Text == "")
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcMainboard.DeleteOne(grdOS.CurrentRow.Cells["No_of_Information"].Value.ToString());
					DisplayGridviewOS();
					ResetOS();
		        }	
		}
		
		void GrdOSCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0 && e.ColumnIndex>=0)
				ClickOneRowOS();
		}	
		
		void DeSelectGrdView(int grd)
		{
			
		}
		
		
		
		void GrdOSDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeSelectGrdView(2);
			grdOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		
		
		void GrdOSSorted(object sender, EventArgs e)
		{
			ResetOS();
			DeSelectGrdView(2);
		}
		
		
		
		void GrdOSSelectionChanged(object sender, EventArgs e)
		{
			if (flagStartOS == true && grdOS.RowCount >0)
				ClickOneRowOS();
		}
		
		
	}
}
