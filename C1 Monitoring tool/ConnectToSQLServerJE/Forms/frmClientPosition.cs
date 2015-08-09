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
	public partial class frmClientPosition : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSourceClient = new BindingSource();
		BindingSource myBindingSourceClient1 = new BindingSource();
		BindingSource myBindingSourceApplication = new BindingSource();
		BindingSource myBindingSourceApplication1 = new BindingSource();
		BindingSource myBindingSource3 = new BindingSource();
		bool flagStart = false;
		
		public frmClientPosition(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			DisplayGridview();
			DisplayDefaultCmbInf();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//Validation
			//this.txtUSD.KeyPress += Validation.txtDouble;
			//this.txtVND.KeyPress += Validation.txtDouble;
			
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
		public void DisplayDefaultCmbInf()
		{
			myBindingSourceClient = dcClient.GetAll();
			cmbClient.DataSource = myBindingSourceClient;
			cmbClient.DisplayMember = "Client_name";
			cmbClient.ValueMember = "Client_Code";
			
			cmbClient.SelectedIndex = -1;
			
			myBindingSourceApplication = dcApp.GetAll();
			cmbApplication.DataSource = myBindingSourceApplication;
			cmbApplication.DisplayMember = "APP_Name";
			cmbApplication.ValueMember = "APP_ID";
			
			cmbApplication.SelectedIndex = -1;
		}
		
		void ResetClientApp()
		{
			cmbClient.SelectedIndex = -1;
			cmbApplication.SelectedIndex = -1;
			
		}
		
		void BtnReset1Click(object sender, EventArgs e)
		{
			ResetClientApp();
			ResetClientApp();
			DisplayDefaultCmbInf();
			DeSelectGrdView();
		}
			
		//VALIDATION
		bool isValidated()
		{
			if (txtPosition.Text == "" || txtPosition.Text == "")
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
			
//			if (Validation.IsDouble(FormatConverter.skipComma(txtVND.Text)) == false)
//			{
//				MessageBox.Show("Amount in VND is not correct.");
//				return false;
//			}
//			
//			if (Validation.IsDouble(FormatConverter.skipComma(txtUSD.Text)) == false)
//			{
//				MessageBox.Show("Amount in USD is not correct.");
//				return false;
//			}
//			
//			if (Validation.IsDouble(txtLeave.Text) == false)
//			{
//				MessageBox.Show("Leave hours is not correct.");
//				return false;
//			}
			
			return true;
		}
		
		
		public void DisplayGridview()
		{
			myBindingSource = dcPosition.GetAll();
			grdPosition.DataSource = myBindingSource;
			grdPosition.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			//grdRate.Columns["Target_Utilization"].DefaultCellStyle.Format = "P";
			//grdPosition.Columns["PositionName"].DefaultCellStyle.Format ="P";
			//grdRate.Rows[1].InheritedStyle.BackColor =   System.Drawing.Color.LightBlue;
			grdPosition.Columns["ID_Position"].Visible = false;
			//grdRate.Columns["CreateDate"].Visible = false;
			
			//grdRate.Rows[1].Cells[1].Style.BackColor = System.Drawing.Color.LightBlue;
			DisplayGridviewClientApp();
		}
		
		void GrdRateDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdPosition.SelectedRows.Count;i++)
			{
				grdPosition.SelectedRows[i].Selected = false;
			}
		}
		
		// Reset
		void Reset()
		{
			txtPosition.Text = "";
			txtID_Position.Text = "";
//			txtUSD.Text = "";
//			txtVND.Text = "";
		//	txtTarget.Text = "";
//			txtLeave.Text = "";
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
			txtID_Position.Text = grdPosition.CurrentRow.Cells["ID_Position"].Value.ToString();
			txtPosition.Text = grdPosition.CurrentRow.Cells["PositionName"].Value.ToString();
			//double vnd = FormatConverter.standardizeDouble(grdRate.CurrentRow.Cells["Amount_VND"].Value.ToString());
			//double usd = FormatConverter.standardizeDouble(grdRate.CurrentRow.Cells["Amount_USD"].Value.ToString());
			//txtVND.Text = FormatConverter.addComma(false,grdRate.CurrentRow.Cells["Amount_VND"].Value.ToString());
			//txtVND.Text = vnd.ToString("#,##0");
			//txtUSD.Text = FormatConverter.addComma(true,grdRate.CurrentRow.Cells["Amount_USD"].Value.ToString());
			//txtUSD.Text = usd.ToString("#,##0.00");
			
			//txtTarget.Text = FormatConverter.addPercent(grdRate.CurrentRow.Cells["Target_Utilization"].Value.ToString());
			//txtLeave.Text = grdRate.CurrentRow.Cells["Leave_Hour"].Value.ToString();
			flagStart = true;			
		}
		
		void GrdPositionCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
				ClickOneRow();
		}
		
		
		
		// Submit Click
				
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if(isValidated() == true)
			{
				//double vnd = FormatConverter.standardizeDouble(FormatConverter.skipComma(txtVND.Text));
				//double usd = FormatConverter.standardizeDouble(FormatConverter.skipComma(txtUSD.Text));
				//double target = FormatConverter.standardizeDouble(FormatConverter.skipPercent(txtTarget.Text))/100;
				//double leave = FormatConverter.standardizeDouble(txtLeave.Text);
				if (txtID_Position.Text != grdPosition.CurrentRow.Cells["ID_Position"].Value.ToString())
					dcPosition.SubmitOne(true, txtID_Position.Text, txtPosition.Text);
				else
					dcPosition.SubmitOne(false, txtID_Position.Text, txtPosition.Text);
				DisplayGridview();
				//SelectRowByID(txtID.Text);
				Reset();
				
				MessageBox.Show("Submitted successfully.");
			}
		}
		
		
		// Delete
		void BtnDelClick(object sender, EventArgs e)
		{
			if (grdPosition.SelectedRows.Count == 0)
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcPosition.DeleteOne(grdPosition.CurrentRow.Cells["ID_Position"].Value.ToString());
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
			if (flagStart == true && grdPosition.RowCount >0)
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
		
		public void DisplayGridviewClientApp()
		{
			myBindingSource3 = dcPosition.GetAll1();
			grdClientApp.DataSource = myBindingSource3;
			grdClientApp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			//grdClientApp.Columns[0].Visible = false;
			//grdDB.Columns["Creator"].Visible = false;
			//grdDB.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdClientApp);
		}
		
		void ClickOneRowApp()
		{
//			myBindingSourceClient1 = dcClient.GetData_ByKey(grdClientApp.CurrentRow.Cells["Client_Code"].Value.ToString());
//			cmbClient.DataSource = myBindingSourceClient1;
			cmbClient.DisplayMember = "Client_name";
			
			cmbClient.Text = grdClientApp.CurrentRow.Cells["ClientName"].Value.ToString();
			cmbApplication.Text = grdClientApp.CurrentRow.Cells["AppName"].Value.ToString();
			
			
			
			
			flagStart = true;
		}
		
		
		
		void BtbSubmit1Click(object sender, EventArgs e)
		{
			if (cmbClient.Text == "" && cmbApplication.Text =="")
				return;
			if (cmbClient.Text =="")
			{
				MessageBox.Show("Please choose the client name");
				return;
			}
			if (cmbApplication.Text =="")
			{
				MessageBox.Show("Please choose the application name");
				return;
			}
			if (grdClientApp.SelectedRows.Count == 0)
			{
				
						string Clientid = cmbClient.Text == ""? "":cmbClient.GetItemText(cmbClient.SelectedValue);
						string Applicationid = cmbApplication.Text == ""? "":cmbApplication.GetItemText(cmbApplication.SelectedValue);
						dcPosition.SubmitOne1(true,"", cmbClient.GetItemText(cmbClient.SelectedValue), cmbApplication.GetItemText(cmbApplication.SelectedValue));
						
						DisplayGridviewClientApp();
						
						ResetClientApp();
						MessageBox.Show("Submitted successfully.");
						return;
					
			}
			
			else 				
			{
				string Clientid = cmbClient.Text == ""? "":cmbClient.GetItemText(cmbClient.SelectedValue);
				
						string Applicationid = cmbApplication.Text == ""? "":cmbApplication.GetItemText(cmbApplication.SelectedValue);
						dcPosition.SubmitOne1(false,grdClientApp.CurrentRow.Cells["ID_Client_App"].Value.ToString(), cmbClient.GetItemText(cmbClient.SelectedValue), cmbApplication.GetItemText(cmbApplication.SelectedValue));
						
						DisplayGridviewClientApp();
						
						ResetClientApp();
						MessageBox.Show("Submitted successfully.");
					
			}
		}
		
		void GrdClientAppCellClick(object sender, DataGridViewCellEventArgs e)
		{
				if (e.RowIndex>=0 )
				ClickOneRowApp();
							
		}
		
		void DeSelectGrdView()
		{
			for (int i = 1; i <= grdClientApp.SelectedRows.Count; i++)
				grdClientApp.SelectedRows[i-1].Selected = false;
		}
		
		void GrdClientAppSelectionChanged(object sender, EventArgs e)
		{
				if (flagStart == true && grdClientApp.RowCount>0)
				ClickOneRowApp();
				
		}
		
		void GrdClientAppDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeSelectGrdView();
		}
	}
}
