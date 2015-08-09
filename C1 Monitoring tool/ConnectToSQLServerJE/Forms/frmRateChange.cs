/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 7/18/2013
 * Time: 11:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmRateChange.
	/// </summary>
	public partial class frmRateChange : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		bool flagStart = false;
		
		public frmRateChange(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			DisplayGridview();
			Reset();			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = false;
				btnReset.Enabled = false;
			}
			else if (Role_type == 1)
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
			else if (Role_type == 4)
			{
				btnDel.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
		}
		
		
		//VALIDATION
		bool isValidated()
		{
			if (cmbEmpName.Text == "" || cmbNewLevel.Text == "" || dtpFromDate.Value.ToString() == "" || dtpToDate.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
			
			//Check duplicate
			for (int i = 0; i < grdRateChange.Rows.Count; i++)
			{
				if(cmbEmpName.Text == grdRateChange.Rows[i].Cells["FullName"].Value.ToString() 
				   & dtpFromDate.Value.ToString() == grdRateChange.Rows[i].Cells["FromDate"].Value.ToString()
				   & dtpToDate.Text == grdRateChange.Rows[i].Cells["ToDate"].Value.ToString())
					return false;
			}
			
			return true;
		}
		
		
		//COMBOBOX
		public void DisplayDefaultChl()
		{
			myBindingSource = dcITRAMember.GetListDataActive();
			cmbEmpName.DataSource = myBindingSource;
			cmbEmpName.DisplayMember = "FullName";
			cmbEmpName.ValueMember = "ID_Member";
			cmbEmpName.SelectedIndex = -1;
		
			myBindingSource = dcRate.GetAll();
			cmbNewLevel.DataSource = myBindingSource;
			cmbNewLevel.DisplayMember = "Level";
			cmbNewLevel.ValueMember = "Level";
			cmbNewLevel.SelectedIndex = -1;
			
			dtpFromDate.Text = System.DateTime.Today.ToString();
		}
		
		
		//GRIDVIEW
		void GrdRateChangeSelectionChanged(object sender, EventArgs e)
		{
			if (flagStart == true  && grdRateChange.SelectedRows.Count > 0)
				ClickOneRow();
		}
		
		void GrdRateChangeCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
				ClickOneRow();
		}
		
		void GrdRateChangeDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdRateChange.SelectedRows.Count;i++)
			{
				grdRateChange.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void ClickOneRow()
		{
			cmbEmpName.SelectedValue = grdRateChange.CurrentRow.Cells["ID_Member"].Value.ToString();
			cmbNewLevel.Text = grdRateChange.CurrentRow.Cells["Member_Level"].Value.ToString();
			dtpFromDate.Text = grdRateChange.CurrentRow.Cells["FromDate"].Value.ToString();
			dtpToDate.Text = grdRateChange.CurrentRow.Cells["ToDate"].Value.ToString();
			txtRateChange_ID.Text = grdRateChange.CurrentRow.Cells["RateChange_ID"].Value.ToString();
			
			flagStart  = true;
		}
		
		public void DisplayGridview()
		{
			myBindingSource = dcRateChange.GetAll();
			grdRateChange.DataSource = myBindingSource;
			
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdRateChange);
		}
		
		
		//BUTTONS
		void BtnResetClick(object sender, EventArgs e)
		{
			flagStart = false;
			Reset();
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (isValidated() == true)
			{
				try
				{
					if (grdRateChange.SelectedRows.Count == 0)
						dcRateChange.SubmitOne(true, "", cmbEmpName.GetItemText(cmbEmpName.SelectedValue), cmbEmpName.Text, cmbNewLevel.Text, dtpFromDate.Value.ToString(), dtpToDate.Text);
					else
						dcRateChange.SubmitOne(false, txtRateChange_ID.Text, cmbEmpName.GetItemText(cmbEmpName.SelectedValue), cmbEmpName.Text, cmbNewLevel.Text, dtpFromDate.Value.ToString(), dtpToDate.Text);
					
					DisplayGridview();
					
					Reset();
					
					flagStart = false;
					
					MessageBox.Show("Submitted successfully.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Submitted unsuccessfully.\nError: " + ex.ToString());
				}
			}
		}

		void BtnDelClick(object sender, EventArgs e)
		{
			if (grdRateChange.SelectedRows.Count == 0)
				return;
	        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
	        {
	            dcRateChange.DeleteOne(grdRateChange.CurrentRow.Cells["RateChange_ID"].Value.ToString());
	            
				DisplayGridview();
				Reset();
	        }			
		}
		
		
		//OTHERS		
		void Reset()
		{
			txtRateChange_ID.Text = "";
			
			DisplayDefaultChl();
			
			DeselectGrd();
		}
	}
}
