/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/17/2013
 * Time: 2:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmEngagement.
	/// </summary>
	public partial class frmC2Engagement : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSource1 = new BindingSource();
		BindingSource myBindingSourceEng = new BindingSource();
		DataTable dtEngagement_Industry = new DataTable();
		DataTable dtEngagement_SOW = new DataTable();
		bool flagStart = false;
		
		
		public frmC2Engagement(int Role_type)
		{			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			
			DisplayGridview();
			SetFieldName();
			Reset();
			cmbSearch.SelectedIndex = 0;				
			
			//Validation
			this.txtEngCode.KeyPress += Validation.txtIntegerOnly;
			
			this.txtFee.KeyPress += Validation.txtDouble;
			
			this.txtPlannedERP.KeyPress += Validation.txtDouble;
			this.txtBilling.KeyPress += Validation.txtDouble;
			this.txtCollection.KeyPress += Validation.txtDouble;
			this.txtWorkComplete.KeyPress += Validation.txtDouble;
			
			//User authorization
			if (Role_type == 2)
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = false;
				btnReset.Enabled = false;
				cmbSIC.Enabled = false;
				cmbSM_MIC.Enabled = false;
			}
			else if (Role_type == 1)
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
				cmbSIC.Enabled = false;
				cmbSM_MIC.Enabled = false;
			}
			else if (Role_type == 4)
			{
				
				btnDel.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
				cmbSIC.Enabled = true;
				cmbSM_MIC.Enabled = true;
			}
		}
		
		
		//VALIDATION
		bool isValidated()
		{
			if (txtEngName.Text == "" || cmbRevenueSource.Text == "" || cmbFYYear.Text == ""  || cmbClientName.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
			
			if (Validation.isYear(cmbFYYear.Text) == false)
			{
				MessageBox.Show("Fiscal year is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtFee.Text)) == false)
			{
				MessageBox.Show("Amount of Fee is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtBilling.Text)) == false)
			{
				MessageBox.Show("Amount of Billed is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtCollection.Text)) == false)
			{
				MessageBox.Show("Amount of Collected is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtWorkComplete.Text)) == false)
			{
				MessageBox.Show("Amount of WIP is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(txtPlannedERP.Text) == false)
			{
				MessageBox.Show("Planned ERP is not correct.");
				return false;
			}
			
			
			if (txtEngCode.Text != "")
			{
				
				myBindingSource = dcEngagement.GetAll();
				grdTemp.DataSource = myBindingSource;
				
				
				for (int i = 0; i < grdTemp.Rows.Count; i++)
				{
					if (grdTemp.Rows[i].Cells["Engagement_Code"].Value != null)
				    {
						// Check if the EngCode + EY FY are duplicated.
						if ((txtEngID.Text == "" || txtEngID.Text != grdTemp.Rows[i].Cells["ID_Engagement"].Value.ToString()) && txtEngCode.Text == grdTemp.Rows[i].Cells["Engagement_Code"].Value.ToString())
						{
							MessageBox.Show("This engagement code existed already");
							return false;
						}
				    }
				}
			}
			
			if (cmbSIC.Text != "")
			{
				myBindingSource = dcITRAMember.GetAllSeniors();
				grdITRAMembers.DataSource = myBindingSource;
				
				bool isExisted = false;
				for (int i = 0; i < grdITRAMembers.Rows.Count;i ++)
				{
					if (cmbSIC.Text == grdITRAMembers.Rows[i].Cells["Fullname"].Value.ToString())
				    {
				    	isExisted = true;
				    	break;
				    }
				}
				
				if (isExisted == false)
				{
					MessageBox.Show("This senior in charge is not available now");
					return false;
				}
			}
			
			if (cmbSM_MIC.Text != "")
			{
				myBindingSource = dcITRAMember.GetAllManagers();
				grdITRAMembers.DataSource = myBindingSource;
				
				bool isExisted = false;
				for (int i = 0; i < grdITRAMembers.Rows.Count;i ++)
				{
					if (cmbSM_MIC.Text == grdITRAMembers.Rows[i].Cells["Fullname"].Value.ToString())
				    {
				    	isExisted = true;
				    	break;
				    }
				}
				
				if (isExisted == false)
				{
					MessageBox.Show("This manager / senior manager in charge is not available now");
					return false;
				}
			}
			
			return true;
		}
		

		//COMBOBOX + CHECKLISTBOX
		void CmbClientNameSelectedIndexChanged(object sender, EventArgs e)
		{
			//chlIndustry
			myBindingSource = dcClient_Industry.GetByClientCode(cmbClientName.GetItemText(cmbClientName.SelectedValue));
			chlIndustry.DataSource = myBindingSource;
			chlIndustry.DisplayMember = "IndustryBusiness";
			chlIndustry.ValueMember = "Industry_ID";
		
			for(int i = 0; i< chlIndustry.Items.Count; i++)
			{
				chlIndustry.SetItemCheckState(i, CheckState.Unchecked);
			}
		}
				
		void CmbEngTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		public void DisplayDefaultCmb()
		{
			myBindingSource = dcClient.GetAll();
			cmbClientName.DataSource = myBindingSource;
			cmbClientName.DisplayMember = "Client_name";
			cmbClientName.ValueMember = "Client_Code";
			cmbClientName.SelectedIndex = -1;
			
			myBindingSource = dcITRAMember.GetAllSeniors();
			cmbSIC.DataSource = myBindingSource;
			cmbSIC.DisplayMember = "FullName";
			//cmbSIC.ValueMember = "Client_Code";
			cmbSIC.SelectedIndex = -1;
			
			myBindingSource = dcITRAMember.GetAllManagers();
			cmbSM_MIC.DataSource = myBindingSource;
			cmbSM_MIC.DisplayMember = "FullName";
			//cmbSM_MIC.ValueMember = "Client_Code";
			cmbSM_MIC.SelectedIndex = -1;
			
			cmbStatus.SelectedIndex = -1;
			
			
			cmbRevenueSource.SelectedIndex = -1;
			cmbFYYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
		}
		
		public void DisplayDefaultChl()
		{	
			//chlIndustry
			myBindingSource = dcClient_Industry.GetByClientCode(cmbClientName.GetItemText(cmbClientName.SelectedValue));
			chlIndustry.DataSource = myBindingSource;
			chlIndustry.DisplayMember = "IndustryBusiness";
			chlIndustry.ValueMember = "Industry_ID";
		
			for(int i = 0; i< chlIndustry.Items.Count; i++)
			{
				chlIndustry.SetItemCheckState(i, CheckState.Unchecked);
			}			
					
		}		
		
		bool IsExistedItem(DataTable dt, string fieldname, string item)
		{
			if (dt != null)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if(dt.Rows[i][fieldname].ToString() == item)
					   return true;
				}
			}
			
			return false;
		}
		
		
		//GRIDVIEW
		void GrdEngagementSelectionChanged(object sender, System.EventArgs e)
		{
			if (flagStart == true && grdEngagement.SelectedRows.Count > 0)
				ClickOneRow();
		}
		
		void GrdClientCellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0 )
				ClickOneRow();
		}
		
		void GrdEngagementDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdEngagement.SelectedRows.Count;i++)
			{
				grdEngagement.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void ClickOneRow()
		{	
			//Reset1();
				txtEngID.Text = grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString();
				cmbFYYear.Text = grdEngagement.CurrentRow.Cells["Fiscal_Year"].Value.ToString();
				txtEngCode.Text = grdEngagement.CurrentRow.Cells["Engagement_Code"].Value.ToString();
				txtEngName.Text = grdEngagement.CurrentRow.Cells["Engagement_Name"].Value.ToString();
				txtPlannedERP.Text = grdEngagement.CurrentRow.Cells["ERP_Planned"].Value.ToString();
				txtFee.Text = FormatConverter.addComma(false,grdEngagement.CurrentRow.Cells["ITRA_Fee"].Value.ToString());
				txtRemark.Text = grdEngagement.CurrentRow.Cells["Remark"].Value.ToString();
				cmbStatus.Text = grdEngagement.CurrentRow.Cells["C2_Status"].Value.ToString();
				dtpClientYE.Text = grdEngagement.CurrentRow.Cells["Start_Date"].Value.ToString();
				txtBilling.Text = FormatConverter.addComma(false,grdEngagement.CurrentRow.Cells["C2_Billing"].Value.ToString());
				txtCollection.Text = FormatConverter.addComma(false,grdEngagement.CurrentRow.Cells["C2_Collection"].Value.ToString());
				txtWorkComplete.Text = FormatConverter.addComma(false,grdEngagement.CurrentRow.Cells["C2_Work_Completion"].Value.ToString());
				txtDetailSOW.Text = grdEngagement.CurrentRow.Cells["C2_DetailSOW"].Value.ToString();
				txtPIC.Text = grdEngagement.CurrentRow.Cells["C2_PIC"].Value.ToString();
				cmbStatus.Text = grdEngagement.CurrentRow.Cells["C2_Status"].Value.ToString();
				dtpCloseDate.Text = grdEngagement.CurrentRow.Cells["C2_CloseDate"].Value.ToString();
				txtLocation.Text = grdEngagement.CurrentRow.Cells["FieldWork_Location"].Value.ToString();
				if (grdEngagement.CurrentRow.Cells["Revenue_Source"].Value.ToString() == "")
					cmbRevenueSource.SelectedIndex = -1;
				else
					cmbRevenueSource.Text = grdEngagement.CurrentRow.Cells["Revenue_Source"].Value.ToString();
				cmbClientName.Text = grdEngagement.CurrentRow.Cells["Client_Name"].Value.ToString();
				if (grdEngagement.CurrentRow.Cells["ITRA_SIC"].Value.ToString() == "")
					cmbSIC.SelectedIndex = -1;
				else
					cmbSIC.Text = grdEngagement.CurrentRow.Cells["ITRA_SIC"].Value.ToString();
				if (grdEngagement.CurrentRow.Cells["ITRA_MIC"].Value.ToString() == "")
					cmbSM_MIC.SelectedIndex = -1;
				else	
					cmbSM_MIC.Text = grdEngagement.CurrentRow.Cells["ITRA_MIC"].Value.ToString();
			
			
			DisplayDefaultChl();
			
			if (grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString() == "Channel 1" || grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString() == "Channel 2")
			{
				// handle chlIndustry
			
				dtEngagement_Industry = (DataTable)dcEngagement_Industry.GetByEngID(txtEngID.Text).DataSource;
				
				for(int i = 0 ; i < chlIndustry.Items.Count; i++)
				{
					if (IsExistedItem(dtEngagement_Industry, "IndustryBusiness", chlIndustry.GetItemText(chlIndustry.Items[i]).ToString()) == true)
						chlIndustry.SetItemCheckState(i, CheckState.Checked);
				}
					
				// handle chlSOW
				dtEngagement_SOW = (DataTable)dcSOW.GetDataByKey(txtEngID.Text).DataSource;
				if (dtEngagement_SOW.Rows.Count == 1)
				{
//					if(dtEngagement_SOW.Rows[0]["ITGCs"].ToString() == "True")
//						chlSOW.SetItemCheckState(3,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(3,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["BPR"].ToString() == "True")
//						chlSOW.SetItemCheckState(7,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(7,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["Application_Control_testing"].ToString() == "True")
//						chlSOW.SetItemCheckState(4,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(4,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["JE_Testing"].ToString() == "True")
//						chlSOW.SetItemCheckState(2,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(2,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["EAE_Report_Testing"].ToString() == "True")
//						chlSOW.SetItemCheckState(5,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(5,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["IT_Complexity_Assessment"].ToString() == "True")
//						chlSOW.SetItemCheckState(0,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(0,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["SOX"].ToString() == "True")
//						chlSOW.SetItemCheckState(8,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(8,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["Data_Migration"].ToString() == "True")
//						chlSOW.SetItemCheckState(6,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(6,CheckState.Unchecked);
//					
//					if(dtEngagement_SOW.Rows[0]["ML_Follow_Up"].ToString() == "True")
//						chlSOW.SetItemCheckState(1,CheckState.Checked);
//					else
//						chlSOW.SetItemCheckState(1,CheckState.Unchecked);
				}
				else
				{
//					for(int i = 0; i<chlSOW.Items.Count; i++)
//					{
//						chlSOW.SetItemCheckState(i,CheckState.Unchecked);	
//					}
				}
			}
			
			
				
			flagStart = true;
		}
		
		public void SetFieldName()
		{
			//grdEngagement.Columns["@ID_Engagement"].HeaderText = "Engegement ID";
		}
		
		public void DisplayGridview()
		{
			
			//myBindingSource1 = dcEngagement.GetListEngNotBudget();
			//grdCheckNotBudget.DataSource = myBindingSource1;
			
			
			myBindingSourceEng = dcEngagement.GetAll_C2Engagement();
			grdEngagement.DataSource = myBindingSourceEng;
			grdEngagement.Columns["Status_Non_Budget"].Visible = false;
			grdEngagement.Columns["C2_Billing"].DefaultCellStyle.Format ="#,##0.##";
			grdEngagement.Columns["C2_Collection"].DefaultCellStyle.Format ="#,##0.##";
			grdEngagement.Columns["C2_Work_Completion"].DefaultCellStyle.Format ="#,##0.##";
			grdEngagement.Columns["ITRA_Fee"].DefaultCellStyle.Format ="#,##0.##";
//			grdEngagement.Columns["Audit_Hours"].Visible = false;
//			grdEngagement.Columns["Feedback_EY_Eagle"].Visible = false;
//			grdEngagement.Columns["AQR"].Visible = false;
			//for(int i = 0; i < grdEngagement.RowCount; i++)
			//	grdEngagement.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
			
			
			
		
//			for(int i = 0; i < grdEngagement.RowCount; i++)
//			{
//				for(int j = 0; j < grdCheckNotBudget.RowCount; j++)
//				{
//					if(grdEngagement.Rows[i].Cells["ID_Engagement"].Value.ToString() == grdCheckNotBudget.Rows[j].Cells["ID_Engagement"].Value.ToString())
//					{
//						//MessageBox.Show(i.ToString());
//						grdEngagement.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
////						grdEngagement.Rows[i].Cells[0].Style.BackColor = Color.LightBlue;
//					}
//					
//				}
//				
//			}
				DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdEngagement);
			//grdEngagement.Columns[2].Frozen = true;
			//grdEngagement.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		public void SelectRowByID(string id)
		{
			for(int i = 0; i < grdEngagement.RowCount;i++)
			{
				if(grdEngagement.Rows[i].Cells["ID_Member"].Value.ToString() == id)
				{
					grdEngagement.CurrentCell = grdEngagement.Rows[i].Cells[0];
					break;
				}
			}			
		}
		
		
		//BUTTONS
		void BtnResetClick(object sender, EventArgs e)
		{
			flagStart = false;
			
			Reset();
			//DisplayGridview();
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (isValidated() == true)
			{
				try
				{
					if ((grdEngagement.RowCount == 0) || (txtEngID.Text != grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString()))
					{
						dcEngagement.C2SubmitOne(true, txtEngID.Text, cmbFYYear.Text, txtEngCode.Text, txtEngName.Text, cmbClientName.GetItemText(cmbClientName.SelectedValue),
												txtPlannedERP.Text, txtFee.Text, txtLocation.Text, txtRemark.Text, cmbStatus.Text, cmbRevenueSource.Text,
												cmbSIC.Text, cmbSM_MIC.Text, dtpCloseDate.Text, txtPIC.Text, dtpClientYE.Text, txtWorkComplete.Text, txtBilling.Text, txtCollection.Text, txtDetailSOW.Text);
						dcClientReport.DeleteOne(cmbClientName.GetItemText(cmbClientName.SelectedValue),cmbFYYear.Text);
					}
					else
						dcEngagement.C2SubmitOne(false, txtEngID.Text, cmbFYYear.Text, txtEngCode.Text, txtEngName.Text, cmbClientName.GetItemText(cmbClientName.SelectedValue),
												txtPlannedERP.Text, txtFee.Text, txtLocation.Text, txtRemark.Text, cmbStatus.Text, cmbRevenueSource.Text,
												cmbSIC.Text, cmbSM_MIC.Text, dtpCloseDate.Text, txtPIC.Text, dtpClientYE.Text, txtWorkComplete.Text, txtBilling.Text, txtCollection.Text, txtDetailSOW.Text);
		
					// handle chlIndustry
					for(int i = 0 ; i < chlIndustry.Items.Count; i++)
					{
						if (chlIndustry.GetItemCheckState(i) == CheckState.Checked)
						{
							if (IsExistedItem(dtEngagement_Industry, "IndustryBusiness", chlIndustry.GetItemText(chlIndustry.Items[i]).ToString()) == false)
							{
								chlIndustry.SetSelected(i, true);
								if (txtEngID.Text == "")
									dcEngagement_Industry.SubmitOne(true, txtEngID.Text, chlIndustry.SelectedValue.ToString());
								else
									dcEngagement_Industry.SubmitOne(false, txtEngID.Text, chlIndustry.SelectedValue.ToString());
							}
						}
						else
						{
							if (IsExistedItem(dtEngagement_Industry, "IndustryBusiness", chlIndustry.GetItemText(chlIndustry.Items[i]).ToString()) == true)
						    {
						    	chlIndustry.SetSelected(i, true);
						    	if (txtEngID.Text != "")
						    		dcEngagement_Industry.DeleteOne(txtEngID.Text, chlIndustry.SelectedValue.ToString());
						    }
						}
					}
//					
////						
//					}
//					
					DisplayGridview();
					//SelectRowByID(txtEngID.Text);
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
			if (txtEngID.Text == "")
				return;
	        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcEngagement.DeleteOne(grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString());
		            
		            // handle relating tables
		            dcEngagement_Industry.DeleteByEngID(grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString());
		            dcSOW.DeleteOne(grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString());
		            dcWorkStatus.DeleteOne(grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString());
		            dcBudgetStaffing.DeleteByEng(grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString());
		            dcRetain.DeleteByEng(grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString());
		            dcInfrastructure.DeleteByEng(grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString());
		            
					DisplayGridview();
					Reset();
		        }			
		}
				
		
		//OTHERS	
		void Reset()
		{
			cmbFYYear.Text = "";
			txtEngID.Text = "";
			txtEngCode.Text = "";
			txtEngName.Text = "";
			txtPlannedERP.Text = "";	
			txtFee.Text = "";
			txtLocation.Text = "";
			txtRemark.Text = "";
			cmbSIC.SelectedIndex = -1;
			cmbSM_MIC.SelectedIndex = -1;
			dtpCloseDate.Text = "1/1/2000";
			txtPIC.Text = "";
			txtSearch.Text = "";
			txtDetailSOW.Text = "";
			txtBilling.Text = "";
			txtCollection.Text = "";
			txtWorkComplete.Text = "";
			DeselectGrd();
			
			DisplayDefaultCmb();
			DisplayDefaultChl();
		}
		
		void Reset1()
		{
			cmbFYYear.Text = "";
			txtEngID.Text = "";
			txtEngCode.Text = "";
			txtEngName.Text = "";
			txtPlannedERP.Text = "";	
			txtFee.Text = "";
			txtLocation.Text = "";
			txtRemark.Text = "";
			cmbClientName.SelectedIndex = -1;
			cmbSIC.SelectedIndex = -1;
			cmbSM_MIC.SelectedIndex = -1;
			dtpCloseDate.Text = "1/1/2000";
			txtPIC.Text = "";
			txtSearch.Text = "";
			txtDetailSOW.Text = "";
			txtBilling.Text = "";
			txtCollection.Text = "";
			txtWorkComplete.Text = "";
		
		}
		//SEARCH
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			BindingSource tempEng = (BindingSource)grdEngagement.DataSource;
			tempEng.Filter = getFieldName(cmbSearch.Text) +" LIKE '%" + txtSearch.Text + "%'";
			grdEngagement.DataSource = tempEng;
		}
		
		
		
		void GrdEngagementSorted(object sender, EventArgs e)
		{
			Reset();
			DeselectGrd();
		}
		
		string getFieldName(string field)
		{
			switch (field)
			{
				case "Engagement name": return "Engagement_Name";
				case "Engagement code": return "Engagement_Code";
				case "Engagement type": return "Engagement_Type";
				case "Fiscal year": return "Fiscal_Year";
				case "Client name": return "Client_Name";
				case "Revenue source": return "Revenue_Source";
				case "SIC": return "ITRA_SIC";
				case "MIC": return "ITRA_MIC";
			}
			return "";			
		}
		
		void CmbSearchSelectedIndexChanged(object sender, EventArgs e)
		{
			txtSearch.Text = "";
		}
		
		string ChangeWorkStatus(string PreviousValue, string PreviousDateValue, bool isCheckedNow, bool isDate)
		{
			if (isCheckedNow == false)
			{
				if (isDate == true)
					return "1/1/2000";
				else
					return "";
			}
			else
			{
				if (PreviousValue == "" && isCheckedNow == true)
				{
					if (isDate == true)
						return "1/1/2000";
					else
						return "Please update";
				}
				
				if (PreviousValue != "" && isCheckedNow == true)
				{
					if (isDate == true)
						return PreviousDateValue;
					else
						return PreviousValue;
				}
			}
			
			return "";
		}
		
		void GrdEngagementRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
//			MessageBox.Show(grdEngagement.Rows[e.RowIndex].Cells["ID_Engagement"].Value.ToString());
//			//grdEngagement.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
//				for(int j = 0; j < grdCheckNotBudget.RowCount; j++)
//				{
//					if(grdEngagement.Rows[e.RowIndex].Cells["ID_Engagement"].Value.ToString() == grdCheckNotBudget.Rows[j].Cells["ID_Engagement"].Value.ToString())
//					{
//						//MessageBox.Show(e.RowIndex.ToString());
//						grdEngagement.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
//
//					}
//					
//				}
		}
		
		void GrdEngagementRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{

//			if (grdEngagement.Rows[e.RowIndex].Cells["Status_Non_Budget"].Value.ToString() == "1")
//				grdEngagement.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
			
		}
		
		
		void FrmC2EngagementLoad(object sender, EventArgs e)
		{
			
		}
		
		
	}
}