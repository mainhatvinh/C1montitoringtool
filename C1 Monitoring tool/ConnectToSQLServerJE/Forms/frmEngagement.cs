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
	public partial class frmEngagement : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSource1 = new BindingSource();
		BindingSource myBindingSourceEng = new BindingSource();
		DataTable dtEngagement_Industry = new DataTable();
		DataTable dtEngagement_SOW = new DataTable();
		bool flagStart = false;
		
		
		public frmEngagement(int Role_type)
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
			this.txtAuditHours.KeyPress += Validation.txtDouble;
			this.txtITRAFee.KeyPress += Validation.txtDouble;
			this.txtPrevActualERP.KeyPress += Validation.txtDouble;
			this.txtPlannedERP.KeyPress += Validation.txtDouble;
			
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
			if (txtEngName.Text == "" || cmbRevenueSource.Text == "" || cmbYear.Text == "" || cmbEngType.Text == "" || (cmbClientName.Text == "" && (cmbEngType.Text == "Channel 1" ||cmbEngType.Text == "Channel 2")))
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
			
			if (Validation.isYear(cmbYear.Text) == false)
			{
				MessageBox.Show("Fiscal year is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtITRAFee.Text)) == false)
			{
				MessageBox.Show("Amount of ITRA Agreed Fee is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(FormatConverter.skipComma(txtAuditHours.Text)) == false)
			{
				MessageBox.Show("Amount of audit hours is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(txtPlannedERP.Text) == false)
			{
				MessageBox.Show("Planned ERP is not correct.");
				return false;
			}
			
			if (Validation.IsDouble(txtPrevActualERP.Text) == false)
			{
				MessageBox.Show("Previous actual ERP is not correct.");
				return false;
			}	
			if (cmbEngType.Text == "Channel 1")
			{
				bool ClientYE = true;
				if ((dtpClientYE.Value.Month != 3 && dtpClientYE.Value.Month != 6 
					&& dtpClientYE.Value.Month != 9 && dtpClientYE.Value.Month != 12))
				{
					ClientYE = false;
				} 
				else
				{
					if (dtpClientYE.Value.Month == 3 && dtpClientYE.Value.Day != 31 ) ClientYE = false;
					if (dtpClientYE.Value.Month == 6 && dtpClientYE.Value.Day != 30 ) ClientYE = false;
					if (dtpClientYE.Value.Month == 9 && dtpClientYE.Value.Day != 30 ) ClientYE = false;
					if (dtpClientYE.Value.Month == 12 && dtpClientYE.Value.Day != 31 ) ClientYE = false; 
				}
				
				if (DateTime.Today.Year != dtpClientYE.Value.Year + 1
				   && DateTime.Today.Year != dtpClientYE.Value.Year - 1
				   && DateTime.Today.Year != dtpClientYE.Value.Year)
					ClientYE = false;				
				if (!ClientYE) {
					MessageBox.Show("Client Year End is not correct.");
					return false;
				} 
	
			}
			
			
//			if (datML.Value < datFieldwork.Value)
//			{
//				MessageBox.Show("IT ML targeted released date is prior to ITRA Fieldwork starting date");
//				return false;
//			}
			
//			if (datFSDate.Value < datFieldwork.Value)
//			{
//				MessageBox.Show("FS targeted released date is prior to ITRA Fieldwork starting date");
//				return false;
//			}
			
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
			EngTypechanged();
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
			
			cmbEngType.SelectedIndex = -1;
			cmbEagle.SelectedIndex = -1;
			cmbAQR.SelectedIndex = -1;
			cmbRevenueSource.SelectedIndex = -1;
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
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
					
			for(int i = 0; i< chlSOW.Items.Count; i++)
			{
				chlSOW.SetItemChecked(i, false);
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
			if (grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString() == "Channel 1" )
			{
				txtEngID.Text = grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString();
				cmbYear.Text = grdEngagement.CurrentRow.Cells["Fiscal_Year"].Value.ToString();
				txtEngCode.Text = grdEngagement.CurrentRow.Cells["Engagement_Code"].Value.ToString();
				txtEngName.Text = grdEngagement.CurrentRow.Cells["Engagement_Name"].Value.ToString();
				txtPlannedERP.Text = grdEngagement.CurrentRow.Cells["ERP_Planned"].Value.ToString();
				txtFASSIC.Text = grdEngagement.CurrentRow.Cells["FAS_SIC"].Value.ToString();
				txtAuditHours.Text = FormatConverter.addComma(false, grdEngagement.CurrentRow.Cells["Audit_Hours"].Value.ToString());
				txtITRAFee.Text = FormatConverter.addComma(false, grdEngagement.CurrentRow.Cells["ITRA_Fee"].Value.ToString());
				datFieldwork.Text = grdEngagement.CurrentRow.Cells["FieldWorkDate"].Value.ToString();
				txtLocation.Text = grdEngagement.CurrentRow.Cells["FieldWork_Location"].Value.ToString();
				txtFeedback.Text = grdEngagement.CurrentRow.Cells["Feedback_EY_Eagle"].Value.ToString();
				dtpML.Text = grdEngagement.CurrentRow.Cells["IT_ML_Release_Date"].Value.ToString();
				dtpFSDate.Text = grdEngagement.CurrentRow.Cells["FS_Release_date"].Value.ToString();
				txtRemark.Text = grdEngagement.CurrentRow.Cells["Remark"].Value.ToString();
				cmbEngType.Text = grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString();
				cmbEagle.Text = grdEngagement.CurrentRow.Cells["Eagle_status"].Value.ToString();
				cmbAQR.Text = grdEngagement.CurrentRow.Cells["AQR"].Value.ToString();
				if (grdEngagement.CurrentRow.Cells["Revenue_Source"].Value.ToString() == "")
					cmbRevenueSource.SelectedIndex = -1;
				else
					cmbRevenueSource.Text = grdEngagement.CurrentRow.Cells["Revenue_Source"].Value.ToString();
				cmbClientName.Text = grdEngagement.CurrentRow.Cells["Client_Name"].Value.ToString();
				if (grdEngagement.CurrentRow.Cells["ITRA_SIC"].Value.ToString() == "")
					cmbSIC.Text = "";
				else
					cmbSIC.Text = grdEngagement.CurrentRow.Cells["ITRA_SIC"].Value.ToString();
				if (grdEngagement.CurrentRow.Cells["ITRA_MIC"].Value.ToString() == "")
					cmbSM_MIC.Text = "";
				else	
					cmbSM_MIC.Text = grdEngagement.CurrentRow.Cells["ITRA_MIC"].Value.ToString();
				txtPrevActualERP.Text = grdEngagement.CurrentRow.Cells["ERP_PrevActual"].Value.ToString();
				dtpClientYE.Text = grdEngagement.CurrentRow.Cells["ClientYE"].Value.ToString();
				txtFASMIC.Text = grdEngagement.CurrentRow.Cells["FAS_MIC"].Value.ToString();
			}
			else if (grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString() == "Channel 2")
			{
				txtEngID.Text = grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString();
				cmbYear.Text = grdEngagement.CurrentRow.Cells["Fiscal_Year"].Value.ToString();
				txtEngCode.Text = grdEngagement.CurrentRow.Cells["Engagement_Code"].Value.ToString();
				txtEngName.Text = grdEngagement.CurrentRow.Cells["Engagement_Name"].Value.ToString();
				txtRemark.Text = grdEngagement.CurrentRow.Cells["Remark"].Value.ToString();
				cmbEngType.Text = grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString();
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
			}
			else if (grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString() == "Authorized Project" || grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString() == "Non-chargeable")
			{
				txtEngID.Text = grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString();
				cmbYear.Text = grdEngagement.CurrentRow.Cells["Fiscal_Year"].Value.ToString();
				txtEngCode.Text = grdEngagement.CurrentRow.Cells["Engagement_Code"].Value.ToString();
				txtEngName.Text = grdEngagement.CurrentRow.Cells["Engagement_Name"].Value.ToString();
				txtRemark.Text = grdEngagement.CurrentRow.Cells["Remark"].Value.ToString();
				cmbEngType.Text = grdEngagement.CurrentRow.Cells["Engagement_Type"].Value.ToString();
			}
			
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
					if(dtEngagement_SOW.Rows[0]["IT_Complexity_Assessment"].ToString() == "True")
						chlSOW.SetItemCheckState(0,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(0,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["ML_Follow_Up"].ToString() == "True")
						chlSOW.SetItemCheckState(1,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(1,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["JE_Testing"].ToString() == "True")
						chlSOW.SetItemCheckState(2,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(2,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["ITGCs"].ToString() == "True")
						chlSOW.SetItemCheckState(3,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(3,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["Application_Control_testing"].ToString() == "True")
						chlSOW.SetItemCheckState(4,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(4,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["EAE_Report_Testing"].ToString() == "True")
						chlSOW.SetItemCheckState(5,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(5,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["Data_Migration"].ToString() == "True")
						chlSOW.SetItemCheckState(6,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(6,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["BPR"].ToString() == "True")
						chlSOW.SetItemCheckState(7,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(7,CheckState.Unchecked);
					
					if(dtEngagement_SOW.Rows[0]["SOX"].ToString() == "True")
						chlSOW.SetItemCheckState(8,CheckState.Checked);
					else
						chlSOW.SetItemCheckState(8,CheckState.Unchecked);
					
				}
				else
				{
					for(int i = 0; i<chlSOW.Items.Count; i++)
					{
						chlSOW.SetItemCheckState(i,CheckState.Unchecked);	
					}
				}
			}
			
			EngTypechanged();
				
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
			
			
			myBindingSourceEng = dcEngagement.GetAll_WithStatus();
			grdEngagement.DataSource = myBindingSourceEng;
			grdEngagement.Columns["Status_Non_Budget"].Visible = false;
			grdEngagement.Columns["Audit_Hours"].Visible = false;
			grdEngagement.Columns["Feedback_EY_Eagle"].Visible = false;
			grdEngagement.Columns["AQR"].Visible = false;
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
						dcEngagement.SubmitOne(true, txtEngID.Text, cmbYear.Text, txtEngCode.Text, txtEngName.Text, cmbClientName.GetItemText(cmbClientName.SelectedValue),
												txtPlannedERP.Text, txtFASSIC.Text, txtAuditHours.Text, txtITRAFee.Text, 
												datFieldwork.Text, txtLocation.Text, txtFeedback.Text, dtpML.Text,
												dtpFSDate.Text, txtRemark.Text, cmbEngType.Text, cmbEagle.Text,
												cmbAQR.Text, cmbRevenueSource.Text,
												cmbSIC.Text, cmbSM_MIC.Text, txtPrevActualERP.Text, dtpClientYE.Text, txtFASMIC.Text);
						dcClientReport.DeleteOne(cmbClientName.GetItemText(cmbClientName.SelectedValue),cmbYear.Text);
					}
					else
						dcEngagement.SubmitOne(false, txtEngID.Text, cmbYear.Text, txtEngCode.Text, txtEngName.Text, cmbClientName.GetItemText(cmbClientName.SelectedValue),
												txtPlannedERP.Text, txtFASSIC.Text, txtAuditHours.Text, txtITRAFee.Text, 
												datFieldwork.Text, txtLocation.Text, txtFeedback.Text, dtpML.Text,
												dtpFSDate.Text, txtRemark.Text, cmbEngType.Text, cmbEagle.Text,
												cmbAQR.Text, cmbRevenueSource.Text,
												cmbSIC.Text, cmbSM_MIC.Text, txtPrevActualERP.Text, dtpClientYE.Text, txtFASMIC.Text);
		
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
					
					if (cmbEngType.Text == "Channel 1")
					{
						// handle chlSOW
						if (grdEngagement.RowCount == 0 || txtEngID.Text != grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString())
						{
							dcSOW.SubmitOne(true, "", chlSOW.GetItemChecked(8),
							                chlSOW.GetItemChecked(0), chlSOW.GetItemChecked(1),
							                chlSOW.GetItemChecked(2), chlSOW.GetItemChecked(3),
							                chlSOW.GetItemChecked(4), chlSOW.GetItemChecked(5),
							                chlSOW.GetItemChecked(6), chlSOW.GetItemChecked(7));
						}
						else
						{
							dcSOW.SubmitOne(false, txtEngID.Text, chlSOW.GetItemChecked(8),
							                chlSOW.GetItemChecked(0), chlSOW.GetItemChecked(1),
							                chlSOW.GetItemChecked(2), chlSOW.GetItemChecked(3),
							                chlSOW.GetItemChecked(4), chlSOW.GetItemChecked(5),
							                chlSOW.GetItemChecked(6), chlSOW.GetItemChecked(7));
						}
						
						
						// handle workstatus
						if (grdEngagement.RowCount == 0 || txtEngID.Text != grdEngagement.CurrentRow.Cells["ID_Engagement"].Value.ToString())
						{
							dcWorkStatus.AddNewOrUpdate("0", 
														"Please update",
														"Please update",
														"Please update",
														"Please update",
														"Please update",
														"Please update",
														"Please update",
														"Please update",
														"Please update",
														(chlSOW.GetItemChecked(8) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(5) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(0) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(1) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(2) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(4) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(3) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(7) == true) ? "Please update" : "",
														"1/1/2000",
														(chlSOW.GetItemChecked(6) == true) ? "Please update" : "",
														"1/1/2000",
														"Please update",
														"1/1/2000",
														"Please update",
														"1/1/2000");						                            
						}
						else //Modification
						{
							myBindingSource = dcWorkStatus.GetDataByKey(txtEngID.Text);
							grdWorkStatus.DataSource = myBindingSource;
							
							dcWorkStatus.AddNewOrUpdate(txtEngID.Text,
														grdWorkStatus.Rows[0].Cells["Gamx_status"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["Planning_Meeting_With_FAS"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["Scoping_Argee"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["IT_Planning_Memo_and_Budget"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["IT_Planning_Memo_and_Budget_Addendum"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["YearEnd_Updated"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["Resulted_Disscuss_With_FAS"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["Gamx_Documentation"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["Ready_for_Archiving_and_Inform_FAS"].Value.ToString(),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["ML_Follow_Up"].Value.ToString(),"",chlSOW.GetItemChecked(8),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["ML_Follow_Up"].Value.ToString(), grdWorkStatus.Rows[0].Cells["ML_Follow_Up_Review"].Value.ToString(),chlSOW.GetItemChecked(8),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["IT_Complexity_Assessment"].Value.ToString(),"",chlSOW.GetItemChecked(5),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["IT_Complexity_Assessment"].Value.ToString(), grdWorkStatus.Rows[0].Cells["IT_Complexity_Assessment_Review"].Value.ToString(),chlSOW.GetItemChecked(5),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["ITGCs"].Value.ToString(),"",chlSOW.GetItemChecked(0),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["ITGCs"].Value.ToString(), grdWorkStatus.Rows[0].Cells["ITGCs_Review"].Value.ToString(),chlSOW.GetItemChecked(0),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["BPR"].Value.ToString(),"",chlSOW.GetItemChecked(1),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["BPR"].Value.ToString(), grdWorkStatus.Rows[0].Cells["BPR_Review"].Value.ToString(),chlSOW.GetItemChecked(1),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["Application_Control_testing"].Value.ToString(),"",chlSOW.GetItemChecked(2),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["Application_Control_testing"].Value.ToString(), grdWorkStatus.Rows[0].Cells["Application_Control_testing_Review"].Value.ToString(),chlSOW.GetItemChecked(2),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["EAE_Report_Testing"].Value.ToString(),"",chlSOW.GetItemChecked(4),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["EAE_Report_Testing"].Value.ToString(), grdWorkStatus.Rows[0].Cells["EAE_Report_Testing_Review"].Value.ToString(),chlSOW.GetItemChecked(4),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["JE_Testing"].Value.ToString(),"",chlSOW.GetItemChecked(3),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["JE_Testing"].Value.ToString(), grdWorkStatus.Rows[0].Cells["JE_Testing_Review"].Value.ToString(),chlSOW.GetItemChecked(3),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["Data_Migration"].Value.ToString(),"",chlSOW.GetItemChecked(7),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["Data_Migration"].Value.ToString(), grdWorkStatus.Rows[0].Cells["Data_Migration_Review"].Value.ToString(),chlSOW.GetItemChecked(7),true),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["SOX"].Value.ToString(),"",chlSOW.GetItemChecked(6),false),
														ChangeWorkStatus(grdWorkStatus.Rows[0].Cells["SOX"].Value.ToString(), grdWorkStatus.Rows[0].Cells["SOX_Review"].Value.ToString(),chlSOW.GetItemChecked(6),true),
														grdWorkStatus.Rows[0].Cells["SRM"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["SRM_Review"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["ML"].Value.ToString(),
														grdWorkStatus.Rows[0].Cells["ML_Review"].Value.ToString());						                            
						}
					}
					
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
			cmbYear.Text = "";
			txtEngID.Text = "";
			txtEngCode.Text = "";
			txtEngName.Text = "";
			txtPlannedERP.Text = "";
			txtFASSIC.Text = "";
			txtAuditHours.Text = "";
			txtITRAFee.Text = "";
			txtLocation.Text = "";
			txtFeedback.Text = "";
			txtRemark.Text = "";
			datFieldwork.Text = "1/1/2000";
			dtpML.Text = "1/1/2000";
			dtpFSDate.Text = "1/1/2000";
			cmbSIC.SelectedIndex = -1;
			cmbSM_MIC.SelectedIndex = -1;
			txtPrevActualERP.Text = "";
			dtpClientYE.Text = DateTime.Today.ToShortDateString();
			txtFASMIC.Text = "";
			
			txtSearch.Text = "";
			
			DeselectGrd();
			
			DisplayDefaultCmb();
			DisplayDefaultChl();
		}
		
		//SEARCH
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			
			BindingSource tempEng = (BindingSource)grdEngagement.DataSource;
			tempEng.Filter = getFieldName(cmbSearch.Text) +" LIKE '%" + txtSearch.Text + "%'";
			grdEngagement.DataSource = tempEng;
		}
		
		void EngTypechanged()
		{
			if (cmbEngType.Text == "Channel 1")
			{
				cmbYear.Enabled = true;
				txtEngCode.Enabled = true;
				txtEngName.Enabled = true;
				txtPlannedERP.Enabled = true;
				txtFASSIC.Enabled = true;
				txtAuditHours.Enabled = true;
				txtITRAFee.Enabled = true;
				txtLocation.Enabled = true;
				txtFeedback.Enabled = true;
				txtRemark.Enabled = true;
				cmbSIC.Enabled = true;
				cmbSM_MIC.Enabled = true;
				txtPrevActualERP.Enabled = true;
				dtpClientYE.Enabled = true;
				txtFASMIC.Enabled = true;
				datFieldwork.Enabled = true;
				dtpML.Enabled = true;
				dtpFSDate.Enabled = true;
				cmbAQR.Enabled = true;
				cmbClientName.Enabled = true;
				cmbEagle.Enabled = true;
				cmbRevenueSource.Enabled = true;
				
				chlSOW.Enabled = true;
				chlIndustry.Enabled = true;
			}  
			else if (cmbEngType.Text == "Channel 2")
			{
				cmbYear.Enabled = true;
				txtEngCode.Enabled = true;
				txtEngName.Enabled = true;
				txtPlannedERP.Enabled = false;
				txtPlannedERP.Text = "";
				txtFASSIC.Enabled = false;
				txtFASSIC.Text = "";
				txtAuditHours.Enabled = false;
				txtAuditHours.Text = "";
				txtITRAFee.Enabled = false;
				txtITRAFee.Text = "";
				txtLocation.Enabled = true;
				txtFeedback.Enabled = false;
				txtFeedback.Text = "";
				txtRemark.Enabled = true;
				cmbSIC.Enabled = true;
				cmbSM_MIC.Enabled = true;
				txtPrevActualERP.Enabled = false;
				txtPrevActualERP.Text = "";
				dtpClientYE.Enabled = false;
				dtpClientYE.Text = "1/1/2000";
				txtFASMIC.Enabled = false;
				txtFASMIC.Text = "";
				datFieldwork.Enabled = false;
				datFieldwork.Text = "1/1/2000";
				dtpML.Enabled = false;
				dtpML.Text = "1/1/2000";
				dtpFSDate.Enabled = false;
				dtpFSDate.Text = "1/1/2000";
				cmbAQR.Enabled = false;
				cmbAQR.SelectedIndex = -1;
				cmbClientName.Enabled = true;
				cmbEagle.Enabled = false;
				cmbEagle.SelectedIndex = -1;
				cmbRevenueSource.Enabled = true;
				
				chlSOW.Enabled = false;
				for(int i = 0; i< chlSOW.Items.Count; i++)
				{
					chlSOW.SetItemChecked(i, false);
				}
				chlIndustry.Enabled = true;
			}
			else if (cmbEngType.Text == "Authorized Project" || cmbEngType.Text == "Non-chargeable")
			{
				if (cmbEngType.Text == "Authorized Project")
					cmbYear.Enabled = true;
				else if (cmbEngType.Text == "Non-chargeable")
				{
					cmbYear.Enabled = false;
					cmbYear.Text = System.DateTime.Today.Year.ToString();
				}
				txtEngCode.Enabled = true;
				txtEngName.Enabled = true;
				txtPlannedERP.Enabled = false;
				txtPlannedERP.Text = "";
				txtFASSIC.Enabled = false;
				txtFASSIC.Text = "";
				txtAuditHours.Enabled = false;
				txtAuditHours.Text = "";
				txtITRAFee.Enabled = false;
				txtITRAFee.Text = "";
				txtLocation.Enabled = false;
				txtLocation.Text = "";
				txtFeedback.Enabled = false;
				txtFeedback.Text = "";
				txtRemark.Enabled = true;
				cmbSIC.Enabled = false;
				cmbSIC.SelectedIndex = -1;
				cmbSM_MIC.Enabled = false;
				cmbSM_MIC.SelectedIndex = -1;
				txtPrevActualERP.Enabled = false;
				txtPrevActualERP.Text = "";
				dtpClientYE.Enabled = false;
				dtpClientYE.Text = "1/1/2000";
				txtFASMIC.Enabled = false;
				txtFASMIC.Text = "";
				datFieldwork.Enabled = false;
				datFieldwork.Text = "1/1/2000";
				dtpML.Enabled = false;
				dtpML.Text = "1/1/2000";
				dtpFSDate.Enabled = false;
				dtpFSDate.Text = "1/1/2000";
				cmbAQR.Enabled = false;
				cmbAQR.SelectedIndex = -1;
				cmbClientName.Enabled = false;
				cmbClientName.SelectedIndex = -1;
				cmbEagle.Enabled = false;
				cmbEagle.SelectedIndex = -1;
				cmbRevenueSource.Enabled = true;
				cmbRevenueSource.SelectedIndex = -1;
								
				chlSOW.Enabled = false;
				chlIndustry.Enabled = false;
				DisplayDefaultChl();
			}
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

			if (grdEngagement.Rows[e.RowIndex].Cells["Status_Non_Budget"].Value.ToString() == "1")
				grdEngagement.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
			
		}
	}
}