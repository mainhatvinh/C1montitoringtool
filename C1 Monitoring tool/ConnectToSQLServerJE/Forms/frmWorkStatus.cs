/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 9:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of Work_status.
	/// </summary>
	public partial class frmWorkStatus : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		DataTable dt_WorkStatus = new DataTable();
		DataTable dtEngagement_SOW = new DataTable();
		bool flagStart = false;
		
		public frmWorkStatus(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			
			//myBindingSource	= dcEngagement.GetAllC1();
			Reset();
			DisplayDefaultCmb();
			//cmbYear.Text = System.DateTime.Today.Year.ToString();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				btnSubmit.Enabled = false;
			}
			else
			{
				btnSubmit.Enabled = true;
			}
		}
		
		
		//VALIDATION
		bool isValidated()
		{
			if (cmbEngCode.Text == "" && cmbEngName.Text == "")
			{
				MessageBox.Show("Please choose an engagement.");
				return false;
			}
			
			return true;
		}
		
		
		//COMBOBOX				
		void CmbYearSelectedIndexChanged(object sender, EventArgs e)
		{
			//myBindingSource.Clear();
			
			BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
			temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "'";
			cmbEngName.DataSource = temp1;
			
			BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
			temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "'";
			cmbEngCode.DataSource = temp2;
			
			
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.SelectedIndex =-1;
			DisableAllCmbDtp();
			
		}
		
		public void DisplayDefaultCmb()
		{	
			myBindingSource = dcEngagement.GetAllC1();
			
			cmbEngName.DataSource = myBindingSource;
			cmbEngName.DisplayMember = "Engagement_Name";
			cmbEngName.ValueMember = "ID_Engagement";
			cmbEngName.SelectedIndex = -1;
			
			cmbEngCode.DataSource = myBindingSource;
			cmbEngCode.DisplayMember = "Engagement_Code";
			cmbEngCode.ValueMember = "ID_Engagement";
			cmbEngCode.SelectedIndex = -1;
			
			cmbYear.SelectedIndex = -1;
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
			
			//Display all cmbs of activities
			DataTable tempAllAct = (DataTable)dcActivity.GetAll().DataSource;
			DataTable tempOneAct = new DataTable();
			
			//cmbGamxStatus
			tempOneAct = tempAllAct;
			cmbGamxStatus.DataSource = tempOneAct.Select("Activity = 'GAMx Status'").CopyToDataTable();
			cmbGamxStatus.DisplayMember = "Status";
			cmbGamxStatus.Text = "Please update";
				
			//cmbFASmeeting
			tempOneAct = tempAllAct;
			cmbFASmeeting.DataSource = tempOneAct.Select("Activity = 'Planning meeting with FAS'").CopyToDataTable();
			cmbFASmeeting.DisplayMember = "Status";
			cmbFASmeeting.Text = "Please update";
			
			//cmbScope
			tempOneAct = tempAllAct;
			cmbScope.DataSource = tempOneAct.Select("Activity = 'Scoping agreed?'").CopyToDataTable();
			cmbScope.DisplayMember = "Status";
			cmbScope.Text = "Please update";
			
			//cmbPlanningMemo
			tempOneAct = tempAllAct;
			cmbPlanningMemo.DataSource = tempOneAct.Select("Activity = 'IT Planning Memo and Budget'").CopyToDataTable();
			cmbPlanningMemo.DisplayMember = "Status";
			cmbPlanningMemo.Text = "Please update";
			
			//cmbAddendum
			tempOneAct = tempAllAct;
			cmbAddendum.DataSource = tempOneAct.Select("Activity = 'IT Planning Memo & Budget Addendum (if any)'").CopyToDataTable();
			cmbAddendum.DisplayMember = "Status";
			cmbAddendum.Text = "Please update";
			
			//cmbYEupdate
			tempOneAct = tempAllAct;
			cmbYEupdate.DataSource = tempOneAct.Select("Activity = 'Year-end update'").CopyToDataTable();
			cmbYEupdate.DisplayMember = "Status";
			cmbYEupdate.Text = "Please update";
				
			//cmbFASresult
			tempOneAct = tempAllAct;
			cmbFASresult.DataSource = tempOneAct.Select("Activity = 'Results discussed with FAS'").CopyToDataTable();
			cmbFASresult.DisplayMember = "Status";
			cmbFASresult.Text = "Please update";
				
			//cmbGamxDoc
			tempOneAct = tempAllAct;
			cmbGamxDoc.DataSource = tempOneAct.Select("Activity = 'GAMx Document'").CopyToDataTable();
			cmbGamxDoc.DisplayMember = "Status";
			cmbGamxDoc.Text = "Please update";
				
			//cmbArchive
			tempOneAct = tempAllAct;
			cmbArchive.DataSource = tempOneAct.Select("Activity = 'Ready for Archiving and informed FAS?'").CopyToDataTable();
			cmbArchive.DisplayMember = "Status";
			cmbArchive.Text = "Please update";
				
			//cmbComplexity
			tempOneAct = tempAllAct;
			cmbComplexity.DataSource = 
			tempOneAct.Select("Activity = 'IT Complexity Assessment'").CopyToDataTable();
			cmbComplexity.DisplayMember = "Status";
			cmbComplexity.Text = "Please update";
			
			//cmbMLFollowUp
			tempOneAct = tempAllAct;
			cmbMLFollowUp.DataSource = 
			tempOneAct.Select("Activity = 'ML Follow Up'").CopyToDataTable();
			cmbMLFollowUp.DisplayMember = "Status";
			cmbMLFollowUp.Text = "Please update";
			
			//cmbIGTC
			tempOneAct = tempAllAct;
			cmbIGTC.DataSource = tempOneAct.Select("Activity = 'ITGCs'").CopyToDataTable();
			cmbIGTC.DisplayMember = "Status";
			cmbIGTC.Text = "Please update";
				
			//cmbBPR
			tempOneAct = tempAllAct;
			cmbBPR.DataSource = tempOneAct.Select("Activity = 'BPR'").CopyToDataTable();
			cmbBPR.DisplayMember = "Status";
			cmbBPR.Text = "Please update";
				
			//cmbAppControl
			tempOneAct = tempAllAct;
			cmbAppControl.DataSource = tempOneAct.Select("Activity = 'Application Controls Testing'").CopyToDataTable();
			cmbAppControl.DisplayMember = "Status";
			cmbAppControl.Text = "Please update";
				
			//cmbEAE
			tempOneAct = tempAllAct;
			cmbEAE.DataSource = tempOneAct.Select("Activity = 'EAE Report Testing'").CopyToDataTable();
			cmbEAE.DisplayMember = "Status";
			cmbEAE.Text = "Please update";
				
			//cmbJE
			tempOneAct = tempAllAct;
			cmbJE.DataSource = tempOneAct.Select("Activity = 'JE Testing'").CopyToDataTable();
			cmbJE.DisplayMember = "Status";
			cmbJE.Text = "Please update";
				
			//cmbDataMigration
			tempOneAct = tempAllAct;
			cmbDataMigration.DataSource = tempOneAct.Select("Activity = 'Data Migration'").CopyToDataTable();
			cmbDataMigration.DisplayMember = "Status";
			cmbDataMigration.Text = "Please update";
				
			//cmbSOX
			tempOneAct = tempAllAct;
			cmbSOX.DataSource = tempOneAct.Select("Activity = 'SOX'").CopyToDataTable();
			cmbSOX.DisplayMember = "Status";
			cmbSOX.Text = "Please update";
				
			//cmbSRM
			tempOneAct = tempAllAct;
			cmbSRM.DataSource = tempOneAct.Select("Activity = 'SRM'").CopyToDataTable();
			cmbSRM.DisplayMember = "Status";
			cmbSRM.Text = "Please update";
				
			//cmbML
			tempOneAct = tempAllAct;
			cmbML.DataSource = tempOneAct.Select("Activity = 'Management Letter'").CopyToDataTable();
			cmbML.DisplayMember = "Status";
			cmbML.Text = "Please update";
			
			dtpITCom.Text  = "1/1/2000";
			dtpMLFollowUp.Text = "1/1/2000";
			dtpITGC.Text  = "1/1/2000";
			dtpBPR.Text  = "1/1/2000";
			dtpAppCon.Text  = "1/1/2000";;
			dtpEAE.Text  = "1/1/2000";
			dtpJE.Text  = "1/1/2000";
			dtpDataMigration.Text  = "1/1/2000";
			dtpSOX.Text  = "1/1/2000";
			dtpSRM.Text  = "1/1/2000";
			dtpML.Text  = "1/1/2000";
					
			DisableAllCmbDtp();
		}
		
		void CmbEngNameSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbEngName.SelectedIndex >= 0)
				cmbEngCode.SelectedIndex = cmbEngName.SelectedIndex;
				txtEngCode.Text = cmbEngCode.Text;
				//cmbEngCode.Text = cmbEngCode.Items[cmbEngName.SelectedIndex].ToString();
		}
		
		void CmbEngCodeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbEngCode.SelectedIndex >= 0)
				cmbEngName.SelectedIndex = cmbEngCode.SelectedIndex;
				
			
			if (flagStart == true)
				SelectOne();
		}
		
		void SelectOne()
		{
			if (cmbEngCode.SelectedIndex == -1)
				return;
			
			dt_WorkStatus = (DataTable)dcWorkStatus.GetDataByKey(cmbEngCode.SelectedValue.ToString()).DataSource;
			dtEngagement_SOW = (DataTable)dcSOW.GetDataByKey(cmbEngCode.SelectedValue.ToString()).DataSource;
			
			if(dtEngagement_SOW.Rows.Count == 0)
			{
				DisableAllCmbDtp();
			}
			else
			{
				cmbGamxStatus.Enabled = true;
				cmbFASmeeting.Enabled = true;
				cmbScope.Enabled = true;
				cmbPlanningMemo.Enabled = true;
				cmbAddendum.Enabled = true;
				cmbYEupdate.Enabled = true;
				cmbFASresult.Enabled = true;
				cmbGamxDoc.Enabled = true;
				cmbArchive.Enabled = true;
				
				//Show content of cmbs
				if(dt_WorkStatus.Rows.Count == 0)
				{
					cmbGamxStatus.Text = "Please update";
					cmbFASmeeting.Text = "Please update";
					cmbScope.Text  = "Please update";
					cmbPlanningMemo.Text  = "Please update";
					cmbAddendum.Text  = "Please update";
					cmbYEupdate.Text  = "Please update";
					cmbFASresult.Text  = "Please update";
					cmbGamxDoc.Text  = "Please update";
					cmbArchive.Text  = "Please update";					
					cmbComplexity.Text  = "Please update";
					//dtpITCom.Text  = "Please update";
					cmbMLFollowUp.Text = "Please update";
					//dtpMLFollowUp.Text  = "Please update";
					cmbIGTC.Text = "Please update";
					//dtpITGC.Text  = "Please update";
					cmbBPR.Text  = "Please update";
					//dtpBPR.Text  = "Please update";
					cmbAppControl.Text  = "Please update";
					//dtpAppCon.Text  = dt_WorkStatus.Rows[0]["Application_Control_testing_Review"].ToString();
					cmbEAE.Text  = "Please update";
					//dtpEAE.Text  = dt_WorkStatus.Rows[0]["EAE_Report_Testing_Review"].ToString();
					cmbJE.Text  = "Please update";
					//dtpJE.Text  = dt_WorkStatus.Rows[0]["JE_Testing_Review"].ToString();
					cmbDataMigration.Text  = "Please update";
					//dtpDataMigration.Text  = dt_WorkStatus.Rows[0]["Data_Migration_Review"].ToString();
					cmbSOX.Text= "Please update";
					//dtpSOX.Text  = dt_WorkStatus.Rows[0]["SOX_Review"].ToString();
					cmbSRM.Text  = "Please update";
					//dtpSRM.Text  = "Please update";
					cmbML.Text  = "Please update";
					//dtpML.Text  = dt_WorkStatus.Rows[0]["ML_Review"].ToString();
				}
				else
				{
					cmbGamxStatus.Text = dt_WorkStatus.Rows[0]["Gamx_status"].ToString();
					cmbFASmeeting.Text = dt_WorkStatus.Rows[0]["Planning_Meeting_With_FAS"].ToString();
					cmbScope.Text  = dt_WorkStatus.Rows[0]["Scoping_Argee"].ToString();
					cmbPlanningMemo.Text  = dt_WorkStatus.Rows[0]["IT_Planning_Memo_and_Budget"].ToString();
					cmbAddendum.Text  = dt_WorkStatus.Rows[0]["IT_Planning_Memo_and_Budget_Addendum"].ToString();
					cmbYEupdate.Text  = dt_WorkStatus.Rows[0]["YearEnd_Updated"].ToString();
					cmbFASresult.Text  = dt_WorkStatus.Rows[0]["Resulted_Disscuss_With_FAS"].ToString();
					cmbGamxDoc.Text  = dt_WorkStatus.Rows[0]["Gamx_Documentation"].ToString();
					cmbArchive.Text  = dt_WorkStatus.Rows[0]["Ready_for_Archiving_and_Inform_FAS"].ToString();
					cmbComplexity.Text  = dt_WorkStatus.Rows[0]["IT_Complexity_Assessment"].ToString();
					dtpITCom.Text  = dt_WorkStatus.Rows[0]["IT_Complexity_Assessment_Review"].ToString();
					cmbMLFollowUp.Text = dt_WorkStatus.Rows[0]["ML_Follow_Up"].ToString();
					dtpMLFollowUp.Text  = dt_WorkStatus.Rows[0]["ML_Follow_Up_Review"].ToString();
					cmbIGTC.Text = dt_WorkStatus.Rows[0]["ITGCs"].ToString();
					dtpITGC.Text  = dt_WorkStatus.Rows[0]["ITGCs_Review"].ToString();
					cmbBPR.Text  = dt_WorkStatus.Rows[0]["BPR"].ToString();
					dtpBPR.Text  = dt_WorkStatus.Rows[0]["BPR_Review"].ToString();
					cmbAppControl.Text  = dt_WorkStatus.Rows[0]["Application_Control_testing"].ToString();
					dtpAppCon.Text  = dt_WorkStatus.Rows[0]["Application_Control_testing_Review"].ToString();
					cmbEAE.Text  = dt_WorkStatus.Rows[0]["EAE_Report_Testing"].ToString();
					dtpEAE.Text  = dt_WorkStatus.Rows[0]["EAE_Report_Testing_Review"].ToString();
					cmbJE.Text  = dt_WorkStatus.Rows[0]["JE_Testing"].ToString();
					dtpJE.Text  = dt_WorkStatus.Rows[0]["JE_Testing_Review"].ToString();
					cmbDataMigration.Text  = dt_WorkStatus.Rows[0]["Data_Migration"].ToString();
					dtpDataMigration.Text  = dt_WorkStatus.Rows[0]["Data_Migration_Review"].ToString();
					cmbSOX.Text= dt_WorkStatus.Rows[0]["SOX"].ToString();
					dtpSOX.Text  = dt_WorkStatus.Rows[0]["SOX_Review"].ToString();
					cmbSRM.Text  = dt_WorkStatus.Rows[0]["SRM"].ToString();
					dtpSRM.Text  = dt_WorkStatus.Rows[0]["SRM_Review"].ToString();
					cmbML.Text  = dt_WorkStatus.Rows[0]["ML"].ToString();
					dtpML.Text  = dt_WorkStatus.Rows[0]["ML_Review"].ToString();
				}
				
				//Enable / disable cmbs
				if (dtEngagement_SOW.Rows[0]["IT_Complexity_Assessment"].ToString() == "True")
				{
					cmbComplexity.Enabled = true;
					dtpITCom.Enabled = true;
				}
				else
				{
					cmbComplexity.Enabled = false;
					cmbComplexity.SelectedIndex = -1;
					dtpITCom.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["ML_Follow_Up"].ToString() == "True")
				{
					cmbMLFollowUp.Enabled = true;
					dtpMLFollowUp.Enabled = true;
				}
				else
				{
					cmbMLFollowUp.Enabled = false;
					cmbMLFollowUp.SelectedIndex = -1;
					dtpMLFollowUp.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["ITGCs"].ToString() == "True")
				{
					cmbIGTC.Enabled = true;
					dtpITGC.Enabled = true;
				}
				else
				{
					cmbIGTC.Enabled = false;
					cmbIGTC.SelectedIndex = -1;
					dtpITGC.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["BPR"].ToString() == "True")
				{
					cmbBPR.Enabled = true;
					dtpBPR.Enabled = true;
				}
				else
				{
					cmbBPR.Enabled = false;
					cmbBPR.SelectedIndex = -1;
					dtpBPR.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["Application_Control_testing"].ToString() == "True")
				{
					cmbAppControl.Enabled = true;
					dtpAppCon.Enabled = true;
				}
				else
				{
					cmbAppControl.Enabled = false;
					cmbAppControl.SelectedIndex = -1;
					dtpAppCon.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["EAE_Report_Testing"].ToString() == "True")
				{
					cmbEAE.Enabled = true;
					dtpEAE.Enabled = true;
				}
				else
				{
					cmbEAE.Enabled = false;
					cmbEAE.SelectedIndex = -1;
					
					dtpEAE.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["JE_Testing"].ToString() == "True")
				{
					cmbJE.Enabled = true;
					dtpJE.Enabled = true;
				}
				else
				{
					cmbJE.Enabled = false;
					cmbJE.SelectedIndex = -1;
					dtpJE.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["Data_Migration"].ToString() == "True")
				{
					cmbDataMigration.Enabled = true;
					dtpDataMigration.Enabled = true;
				}
				else
				{
					cmbDataMigration.Enabled = false;
					cmbDataMigration.SelectedIndex = -1;
					dtpDataMigration.Enabled = false;
				}
				
				if (dtEngagement_SOW.Rows[0]["SOX"].ToString() == "True")
				{
					cmbSOX.Enabled = true;
					dtpSOX.Enabled = true;
				}
				else
				{
					cmbSOX.Enabled = false;
					cmbSOX.SelectedIndex = -1;
					dtpSOX.Enabled = false;
				}
				
				cmbSRM.Enabled = true;
				dtpSRM.Enabled = true;
				cmbML.Enabled = true;
				dtpML.Enabled = true;
			}
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (isValidated() == true)
			{
				try 
				{
					dcWorkStatus.AddNewOrUpdate(
						cmbEngCode.SelectedValue.ToString(),
						cmbGamxStatus.Text,
						cmbFASmeeting.Text,
						cmbScope.Text,
						cmbPlanningMemo.Text,
						cmbAddendum.Text,
						cmbYEupdate.Text,
						cmbFASresult.Text,
						cmbGamxDoc.Text,
						cmbArchive.Text,
						cmbMLFollowUp.Text,
						dtpMLFollowUp.Text,
						cmbComplexity.Text,
						dtpITCom.Text,
						cmbIGTC.Text,
						dtpITGC.Text,
						cmbBPR.Text,
						dtpBPR.Text,
						cmbAppControl.Text,
						dtpAppCon.Text,
						cmbEAE.Text,
						dtpEAE.Text,
						cmbJE.Text,
						dtpJE.Text,
						cmbDataMigration.Text,
						dtpDataMigration.Text,
						cmbSOX.Text,
						dtpSOX.Text,
						cmbSRM.Text,
						dtpSRM.Text,
						cmbML.Text,
						dtpML.Text);
					
					flagStart = false;
					Reset();
					
					MessageBox.Show("Submitted successfully.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Submitted unsuccessfully.\nError: " + ex.ToString());
				}
			}
		}
		
		//OTHERS
		void Reset()
		{
			DisplayDefaultCmb();
		}
		
		void DisableAllCmbDtp()
		{
			cmbGamxStatus.Enabled = false;
			cmbFASmeeting.Enabled = false;
			cmbScope.Enabled = false;
			cmbPlanningMemo.Enabled = false;
			cmbAddendum.Enabled = false;
			cmbYEupdate.Enabled = false;
			cmbFASresult.Enabled = false;
			cmbGamxDoc.Enabled = false;
			cmbArchive.Enabled = false;
			cmbMLFollowUp.Enabled = false;
			dtpMLFollowUp.Enabled = false;
			cmbComplexity.Enabled = false;
			dtpITCom.Enabled = false;
			cmbIGTC.Enabled = false;
			dtpITGC.Enabled = false;
			cmbBPR.Enabled = false;
			dtpBPR.Enabled = false;
			cmbAppControl.Enabled = false;
			dtpAppCon.Enabled = false;
			cmbEAE.Enabled = false;
			dtpEAE.Enabled = false;
			cmbJE.Enabled = false;
			dtpJE.Enabled = false;
			cmbDataMigration.Enabled = false;
			dtpDataMigration.Enabled = false;
			cmbSOX.Enabled = false;
			dtpSOX.Enabled = false;
			cmbSRM.Enabled = false;
			dtpSRM.Enabled = false;
			cmbML.Enabled = false;
			dtpML.Enabled = false;
		}
		
		void CmbEngNameClick(object sender, EventArgs e)
		{
			flagStart = true;
		}
		
		void CmbEngCodeClick(object sender, EventArgs e)
		{
			flagStart = true;
		}
	}
}
