/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/21/2013
 * Time: 3:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace C1Monitoring
{
	/// <summary>
	/// Description of Rate.
	/// </summary>
	public partial class frmRate : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		bool flagStart = false;
		
		public frmRate(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			DisplayGridview();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//Validation
			this.txtUSD.KeyPress += Validation.txtDouble;
			this.txtVND.KeyPress += Validation.txtDouble;
			
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
			if (txtLevel.Text == "" || txtVND.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
			
//			if (Validation.IsDouble(FormatConverter.skipPercent(txtTarget.Text)))
//			{
//				double target = FormatConverter.standardizeDouble(FormatConverter.skipPercent(txtTarget.Text));
//				if (target > 100)
//				{
//					MessageBox.Show("Percentage must be below 100%.");
//					return false;
//				}
//					
//			}
//			else
//			{
//				MessageBox.Show("Percentage is not correct.");
//				return false;
//			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtVND.Text)) == false)
			{
				MessageBox.Show("Amount in VND is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtUSD.Text)) == false)
			{
				MessageBox.Show("Amount in USD is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(txtLeave.Text) == false)
			{
				MessageBox.Show("Leave hours is not correct.");
				return false;
			}
			
			return true;
		}
		
		
		public void DisplayGridview()
		{
			myBindingSource = dcRate.GetAll();
			grdRate.DataSource = myBindingSource;
			grdRate.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			//grdRate.Columns["Target_Utilization"].DefaultCellStyle.Format = "P";
			grdRate.Columns["Amount_VND"].DefaultCellStyle.Format ="#,##0.##";
			//grdRate.Rows[1].InheritedStyle.BackColor =   System.Drawing.Color.LightBlue;
			//grdRate.Columns["Creator"].Visible = false;
			//grdRate.Columns["CreateDate"].Visible = false;
			
			//grdRate.Rows[1].Cells[1].Style.BackColor = System.Drawing.Color.LightBlue;
			
		}
		
		void GrdRateDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdRate.SelectedRows.Count;i++)
			{
				grdRate.SelectedRows[i].Selected = false;
			}
		}
		
		// Reset
		void Reset()
		{
			txtLevel.Text = "";
			txtUSD.Text = "";
			txtVND.Text = "";
		//	txtTarget.Text = "";
			txtLeave.Text = "";
			flagStart = false;
			DeselectGrd();
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			Reset();
			
		}
		
		//Cell Click
		void ClickOneRow()
		{
			txtLevel.Text = grdRate.CurrentRow.Cells["Level"].Value.ToString();
			//double vnd = FormatConverter.standardizeDouble(grdRate.CurrentRow.Cells["Amount_VND"].Value.ToString());
			//double usd = FormatConverter.standardizeDouble(grdRate.CurrentRow.Cells["Amount_USD"].Value.ToString());
			txtVND.Text = FormatConverter.addComma(false,grdRate.CurrentRow.Cells["Amount_VND"].Value.ToString());
			//txtVND.Text = vnd.ToString("#,##0");
			txtUSD.Text = FormatConverter.addComma(true,grdRate.CurrentRow.Cells["Amount_USD"].Value.ToString());
			//txtUSD.Text = usd.ToString("#,##0.00");
			
			//txtTarget.Text = FormatConverter.addPercent(grdRate.CurrentRow.Cells["Target_Utilization"].Value.ToString());
			txtLeave.Text = grdRate.CurrentRow.Cells["Leave_Hour"].Value.ToString();
			flagStart = true;			
		}
		
		void GrdRateCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
				ClickOneRow();
		}
		
		
		
		// Submit Click
				
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if(isValidated() == true)
			{
				double vnd = FormatConverter.standardizeDouble(FormatConverter.skipComma(txtVND.Text));
				double usd = FormatConverter.standardizeDouble(FormatConverter.skipComma(txtUSD.Text));
				//double target = FormatConverter.standardizeDouble(FormatConverter.skipPercent(txtTarget.Text))/100;
				double leave = FormatConverter.standardizeDouble(txtLeave.Text);
				if (txtLevel.Text != grdRate.CurrentRow.Cells["Level"].Value.ToString())
					dcRate.SubmitOne(true, txtLevel.Text, vnd.ToString(), usd.ToString(), leave.ToString());
				else
					dcRate.SubmitOne(false, txtLevel.Text,vnd.ToString(), usd.ToString(), leave.ToString());
				DisplayGridview();
				//SelectRowByID(txtID.Text);
				Reset();
				
				MessageBox.Show("Submitted successfully.");
			}
		}
		
		
		// Delete
		void BtnDelClick(object sender, EventArgs e)
		{
			if (grdRate.SelectedRows.Count == 0)
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcRate.DeleteOne(grdRate.CurrentRow.Cells["Level"].Value.ToString());
					DisplayGridview();
					Reset();
		        }	
		}
		
		void GrdRateSorted(object sender, EventArgs e)
		{
			Reset();
			DeselectGrd();
		}
		
		void GrdRateSelectionChanged(object sender, EventArgs e)
		{
			if (flagStart == true && grdRate.RowCount >0)
				ClickOneRow();
		}
		
		void Button1Click(object sender, EventArgs e)
		{

		}
		
		void TxtTargetTextChanged(object sender, EventArgs e)
		{
//			if (Validation.IsDouble(FormatConverter.skipPercent(txtTarget.Text)))
//			{
//				txtTarget.Text = FormatConverter.addPercent(FormatConverter.skipPercent(txtTarget.Text));
//			}
		}
		
		void GrdRateRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			//	grdRate.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
		}
	}
}
