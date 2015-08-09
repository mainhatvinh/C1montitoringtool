/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/6/2014
 * Time: 4:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.OleDb;

namespace C1Monitoring
{
	/// <summary>
	/// Description of NewMainForm.
	/// </summary>
	public partial class NewMainForm : Form
	{
		public static OleDbConnection myConnection = new OleDbConnection();
		//static DataGridView grdMatrix_role = new DataGridView();
		BindingSource myBindingSource = new BindingSource();
		public NewMainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// Connect Database
			DataConnect.ConnectData();
			
			// Lay phan quyen
			myBindingSource = dcMatrixrole.GetDataByITRAMemberName(Environment.UserName);
			grdMatrix_Role.DataSource = myBindingSource;
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			// Load menu
			LoadMenu();
			addNewtab("Main form");
		}
		
		void LoadMenu()
		{
			outlookBar=new OutlookBar();
			outlookBar.Location=new Point(0, 0);
			//MessageBox.Show(this.ClientSize.Height.ToString());
			outlookBar.Size=new Size(150, this.ClientSize.Height-100);
			outlookBar.BorderStyle=BorderStyle.FixedSingle;
			Controls.Add(outlookBar);
			outlookBar.Initialize();
			IconPanel iconMasterData =new IconPanel();
			IconPanel iconEngMonitor=new IconPanel();
			IconPanel iconChannel2 =new IconPanel();
			IconPanel iconReport=new IconPanel();
			IconPanel iconOther=new IconPanel();
			
			
			// 4 nut lon
			outlookBar.AddBand("Master Data", iconMasterData);
			outlookBar.AddBand("Channel 1 and Others", iconEngMonitor);
			outlookBar.AddBand("Channel 2", iconChannel2);
			outlookBar.AddBand("Report", iconReport);
			outlookBar.AddBand("Other", iconOther);
			
			// Master Data
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Mainform"].Value.ToString()) != 3)
				iconMasterData.AddIcon("Main Form", Image.FromFile(@"Data\Icon\main form_2.png"), new EventHandler(BtnMainformTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ITRA_Member"].Value.ToString()) != 3)
				iconMasterData.AddIcon("Risk Member", Image.FromFile(@"Data\Icon\Risk member2.png"), new EventHandler(BtnITRAMemberTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Client"].Value.ToString()) != 3)
				iconMasterData.AddIcon("Client", Image.FromFile(@"Data\Icon\clients.png"), new EventHandler(BtnClientTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Industry"].Value.ToString()) != 3)
				iconMasterData.AddIcon("Industry", Image.FromFile(@"Data\Icon\Industry2.png"), new EventHandler(BtnIndustryTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Rate"].Value.ToString()) != 3)
				iconMasterData.AddIcon("Rate", Image.FromFile(@"Data\Icon\yellow-chart-icon.png"), new EventHandler(BtnRateTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Application_OS_DB"].Value.ToString()) != 3)
				iconMasterData.AddIcon("App-OS-DB", Image.FromFile(@"Data\Icon\App-OS-DB_1.png"), new EventHandler(BtnAppOSDBTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ClientPosition"].Value.ToString()) != 3)
				iconMasterData.AddIcon("Client-Position", Image.FromFile(@"Data\Icon\Client-Position_1.png"), new EventHandler(BtnClientPositionClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ClientApplication"].Value.ToString()) != 3)
				iconMasterData.AddIcon("Client-Application", Image.FromFile(@"Data\Icon\system.png"), new EventHandler(BtnClientApplicationClick));
			
			// Channel 1
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Engagement"].Value.ToString()) != 3)
				iconEngMonitor.AddIcon("Engagement", Image.FromFile(@"Data\Icon\Engagement.png"), new EventHandler(BtnEngagementTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Budget_Staffing"].Value.ToString()) != 3)
			iconEngMonitor.AddIcon("Budget - Staffing", Image.FromFile(@"Data\Icon\budgeting.png"), new EventHandler(BtnBudgetStaffingTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_booking"].Value.ToString()) != 3)
			iconEngMonitor.AddIcon("Booking", Image.FromFile(@"Data\Icon\Calendar-icon.png"), new EventHandler(BtnBookingTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Work_status"].Value.ToString()) != 3)
			iconEngMonitor.AddIcon("Workstatus", Image.FromFile(@"Data\Icon\workstatus.png"), new EventHandler(BtnWorkStatusTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Infrastructure"].Value.ToString()) != 3)
			iconEngMonitor.AddIcon("Infrastructure", Image.FromFile(@"Data\Icon\infrastructure.png"), new EventHandler(BtnInfrastructureTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Engagement_Detail"].Value.ToString()) != 3)
			iconEngMonitor.AddIcon("Engagement Report", Image.FromFile(@"Data\Icon\C1Eng.png"), new EventHandler(BtnEngDetailTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Client_Report"].Value.ToString()) != 3)
			iconEngMonitor.AddIcon("Client Report", Image.FromFile(@"Data\Icon\client1.png"), new EventHandler(BtnClientReportTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Work_Status"].Value.ToString()) != 3)
			iconEngMonitor.AddIcon("Workstatus", Image.FromFile(@"Data\Icon\work status.png"), new EventHandler(BtnWSReportTabClick));
			// Channel 2
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_C2Engagement"].Value.ToString()) != 3)
			iconChannel2.AddIcon("C2Engagement", Image.FromFile(@"Data\Icon\Engagement.png"), new EventHandler(BtnC2EngagementTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_C2Budget_Staffing"].Value.ToString()) != 3)
			iconChannel2.AddIcon("C2 Budget - Staffing", Image.FromFile(@"Data\Icon\budgeting.png"), new EventHandler(BtnC2BudgetStaffingTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_C2booking"].Value.ToString()) != 3)
			iconChannel2.AddIcon("C2 Booking", Image.FromFile(@"Data\Icon\Calendar-icon.png"), new EventHandler(BtnC2BookingTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Pipeline"].Value.ToString()) != 3)
			iconChannel2.AddIcon("Pipeline", Image.FromFile(@"Data\Icon\PIPELINE4.png"), new EventHandler(BtnPipelineTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_CRM"].Value.ToString()) != 3)
			iconChannel2.AddIcon("CRM", Image.FromFile(@"Data\Icon\CRM.png"), new EventHandler(BtnCRMTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Pipelinereport"].Value.ToString()) != 3)
			iconChannel2.AddIcon("Pipeline Report", Image.FromFile(@"Data\Icon\Pipeline report.png"), new EventHandler(BtnPipelineReportTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_C2Engagement"].Value.ToString()) != 3)
			iconChannel2.AddIcon("C2Engagement Report", Image.FromFile(@"Data\Icon\C2Engagement report.png"), new EventHandler(BtnC2EngagementreportTabClick));
			// Report
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Retain"].Value.ToString()) != 3)
			iconReport.AddIcon("Retain", Image.FromFile(@"Data\Icon\retain.png"), new EventHandler(BtnRetainReportTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Budget_Actual"].Value.ToString()) != 3)
			iconReport.AddIcon("Budget - Actual", Image.FromFile(@"Data\Icon\Budget-Actual.png"), new EventHandler(BtnBudgetActualTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Utilization"].Value.ToString()) != 3)
			iconReport.AddIcon("Utilization", Image.FromFile(@"Data\Icon\ultilization_2.png"), new EventHandler(BtnUtilizationReportTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Revenue"].Value.ToString()) != 3)
			iconReport.AddIcon("Revenue", Image.FromFile(@"Data\Icon\revenue.png"), new EventHandler(BtnRevenueReportTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Revenue_Weekly"].Value.ToString()) != 3)
			iconReport.AddIcon("Revenue Weekly", Image.FromFile(@"Data\Icon\revenue.png"), new EventHandler(BtnRevenueWeeklyReportTabClick));
			
			// Other
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_TimeSheet"].Value.ToString()) != 3)
			iconOther.AddIcon("Timesheet", Image.FromFile(@"Data\Icon\Recent-Documents-icon.png"), new EventHandler(BtnTimesheetTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_AuditTrail"].Value.ToString()) != 3)
			iconOther.AddIcon("Audit Trail", Image.FromFile(@"Data\Icon\Audit trail_1.png"), new EventHandler(btn_AuditTrailTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Booking_Leave"].Value.ToString()) != 3)
			iconOther.AddIcon("Booking Leave", Image.FromFile(@"Data\Icon\Business-Leave-icon.png"), new EventHandler(btn_BookingNTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Configuration"].Value.ToString()) != 3)
			iconOther.AddIcon("Configuration", Image.FromFile(@"Data\Icon\configuration.png"), new EventHandler(btn_ConfigurationTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Rate_Change"].Value.ToString()) != 3)
			iconOther.AddIcon("Level Change", Image.FromFile(@"Data\Icon\level change.png"), new EventHandler(btn_RateChangeTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Mainboard"].Value.ToString()) != 3)
			iconOther.AddIcon("Information", Image.FromFile(@"Data\Icon\Information_1.png"), new EventHandler(btn_InformationTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_News"].Value.ToString()) != 3)
			iconOther.AddIcon("News", Image.FromFile(@"Data\Icon\News.png"), new EventHandler(btn_NewsTabClick));
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Import_ERP"].Value.ToString()) != 3)
			iconOther.AddIcon("Import ERP-Sold Time", Image.FromFile(@"Data\Icon\import.png"), new EventHandler(BtnImportERPTabClick));
			
			outlookBar.SelectBand(0);
		}
		
		public void PanelEvent(object sender, EventArgs e)
		{
			Control ctrl=(Control)sender;
			PanelIcon panelIcon=ctrl.Tag as PanelIcon;
			MessageBox.Show("#"+panelIcon.Index.ToString(), "Panel Event");
		}
		
		void BtnMainformTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Main form");
   		}
		
		void BtnITRAMemberTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Risk Member");
   		}
   		
   		void BtnClientTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Client");
   		}
   		
   		void BtnAppOSDBTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Application - OS - DB");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void BtnIndustryTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Industry");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		   		
   		void BtnRateTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Rate");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		 		
   		void BtnEngagementTabClick(object sender, EventArgs e)
   		{
   			addNewtab("C1Engagement & Others");
   		}
   		
   		void BtnC2EngagementTabClick(object sender, EventArgs e)
   		{
   			addNewtab("C2Engagement");
   		}
   		
   		void BtnC2EngagementreportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("C2Engagement Report");
   		}
   		
   		void BtnBudgetStaffingTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Budget - Staffing");
   		}
   		
   		void BtnBookingTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Booking");
   		}
   		
   		void BtnC2BudgetStaffingTabClick(object sender, EventArgs e)
   		{
   			addNewtab("C2 Budget - Staffing");
   		}
   		
   		void BtnC2BookingTabClick(object sender, EventArgs e)
   		{
   			addNewtab("C2 Booking");
   		}
   		
   		void BtnWorkStatusTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Work status");
   		}
   		void BtnTimesheetTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Timesheet");
   		}
   		
   		void BtnInfrastructureTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Infrastructure");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void BtnRetainReportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Retain report");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void BtnWSReportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Work status report");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void BtnUtilizationReportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Utilization report");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		void BtnBudgetActualTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Budget - Actual report");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void BtnRevenueReportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Revenue report");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void BtnRevenueWeeklyReportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Revenue Weekly report");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void BtnImportERPTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Import ERP - Sold Time");
   			//MessageBox.Show("This function is under maintenance.");
   		}
   		
   		void btn_BookingNTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Booking Leave");
   			//MessageBox.Show("This function is under maintenance.");
   		}

		void btn_RateChangeTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Level Change");
   			//MessageBox.Show("This function is under maintenance.");
   		} 

		void btn_InformationTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Information");
   			//MessageBox.Show("This function is under maintenance.");
   		}		
   		
		void btn_AuditTrailTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Audit Trail");
   		}
		
		void btn_ConfigurationTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Configuration");
   		}
		
		void BtnEngDetailTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Engagement List");
   		} 
		void BtnClientReportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Client Report");
   		} 

		void btn_NewsTabClick(object sender, EventArgs e)
   		{
   			addNewtab("News");
   		} 
   		void BtnPipelineTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Pipeline");
   		} 
   		
   		void BtnPipelineReportTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Pipeline Report");
   		} 
   		
   		void BtnClientPositionClick(object sender, EventArgs e)
   		{
   			addNewtab("Client-Position");
   		} 
   		
   		void BtnClientApplicationClick(object sender, EventArgs e)
   		{
   			addNewtab("Client-Application");
   		} 
   		
   		void BtnCRMTabClick(object sender, EventArgs e)
   		{
   			addNewtab("CRM");
   		} 
   		// Check tab da co chua
   		private bool checkExistedTabPage(TabControl tabCtrl, string name)
		{
			for (int i = 0; i < tabCtrl.TabPages.Count; i++)
			{
				if (tabCtrl.TabPages[i].Name == name)
				{
					return true;
				} 
			}
			return false;
		}
   		
   		// Ham tao tao moi
   		void addNewtab(string tabname)
   		{   			 			
			if(checkExistedTabPage(tclMain, tabname) == false)
			{
	   			TabPage newTabPage = new TabPage();
				tclMain.Controls.Add(newTabPage);
				newTabPage.Name = tabname;
			 	if (tabname == "Main form")
					newTabPage.Text = tabname;
				else 
					newTabPage.Text = tabname + " x"; 

				newTabPage.Location = new System.Drawing.Point(4, 22);
				newTabPage.Padding = new System.Windows.Forms.Padding(3);
				newTabPage.Size = new System.Drawing.Size(508, 298);
				//newTabPage.TabIndex = tabControl1.Controls.Count - 1;
				newTabPage.UseVisualStyleBackColor = true;
				tclMain.SelectedTab = newTabPage;
				if (tabname == "Client")
					newTabPage.Controls.Add(new MyPanel(new frmClient(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Client"].Value.ToString()))));
				else if (tabname == "Main form")
		         	newTabPage.Controls.Add(new MyPanel(new frmmainform(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Mainform"].Value.ToString()))));
				else if (tabname == "Risk Member")
		         	newTabPage.Controls.Add(new MyPanel(new frmITRAMember(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ITRA_Member"].Value.ToString()))));
				else if (tabname == "C1Engagement & Others")
		         	newTabPage.Controls.Add(new MyPanel(new frmEngagement(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Engagement"].Value.ToString()))));
				else if (tabname == "Budget - Staffing")
		         	newTabPage.Controls.Add(new MyPanel(new frmBudgetStaffing(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Budget_Staffing"].Value.ToString()))));
				else if (tabname == "Booking")
		         	newTabPage.Controls.Add(new MyPanel(new frmBooking(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Booking"].Value.ToString()))));
				else if (tabname == "C2 Budget - Staffing")
		         	newTabPage.Controls.Add(new MyPanel(new frmC2BudgetStaffing(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_C2Budget_Staffing"].Value.ToString()))));
				else if (tabname == "C2 Booking")
		         	newTabPage.Controls.Add(new MyPanel(new frmC2Booking(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_C2Booking"].Value.ToString()))));
				else if (tabname == "Work status")
		         	newTabPage.Controls.Add(new MyPanel(new frmWorkStatus(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Work_Status"].Value.ToString()))));
				else if (tabname == "Timesheet")
		         	newTabPage.Controls.Add(new MyPanel(new frmTimesheet1(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_TimeSheet"].Value.ToString()))));
				else if (tabname == "Application - OS - DB")
		         	newTabPage.Controls.Add(new MyPanel(new frmSystem(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Application_OS_DB"].Value.ToString()))));
				else if (tabname == "Infrastructure")
		         	newTabPage.Controls.Add(new MyPanel(new frmInfrastructure(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Infrastructure"].Value.ToString()))));
				else if (tabname == "Rate")
		         	newTabPage.Controls.Add(new MyPanel(new frmRate(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Rate"].Value.ToString()))));
				else if (tabname == "Industry")
		         	newTabPage.Controls.Add(new MyPanel(new frmIndustry(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Industry"].Value.ToString()))));
				else if (tabname == "Retain report")
		         	newTabPage.Controls.Add(new MyPanel(new frmRetainReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Retain"].Value.ToString()))));
				else if (tabname == "Work status report")
		         	newTabPage.Controls.Add(new MyPanel(new frmWorkStatusReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Work_Status"].Value.ToString()))));
				else if (tabname == "Utilization report")
		         	newTabPage.Controls.Add(new MyPanel(new frmUtilizationReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Utilization"].Value.ToString()))));
				else if (tabname == "Revenue report")
		         	newTabPage.Controls.Add(new MyPanel(new frmRevenueReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Revenue"].Value.ToString()))));
				else if (tabname == "Revenue Weekly report")
		         	newTabPage.Controls.Add(new MyPanel(new frmRevenueWeeklyReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Revenue_Weekly"].Value.ToString()))));
				else if (tabname == "Budget - Actual report")
		         	newTabPage.Controls.Add(new MyPanel(new frmBudgetActualReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Budget_Actual"].Value.ToString()))));
				else if (tabname == "Import ERP - Sold Time")
		         	newTabPage.Controls.Add(new MyPanel(new frmImportERP(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Import_ERP"].Value.ToString()))));
				else if (tabname == "Booking Leave")
		         	newTabPage.Controls.Add(new MyPanel(new frmBookingN(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Booking_Leave"].Value.ToString()))));
				else if (tabname == "Level Change")
		         	newTabPage.Controls.Add(new MyPanel(new frmRateChange(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Rate_Change"].Value.ToString()))));
				else if (tabname == "Audit Trail")
		         	newTabPage.Controls.Add(new MyPanel(new frmAuditTrail(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_AuditTrail"].Value.ToString()))));			
				else if (tabname == "Engagement List")
		         	newTabPage.Controls.Add(new MyPanel(new frmEngagementDetail(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Engagement_Detail"].Value.ToString()))));
				else if (tabname == "Configuration")
		         	newTabPage.Controls.Add(new MyPanel(new frmConfiguration(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Configuration"].Value.ToString()))));
				else if (tabname == "Client Report")
		         	newTabPage.Controls.Add(new MyPanel(new frmClientReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Client_Report"].Value.ToString()))));	
				else if (tabname == "Pipeline")
		         	newTabPage.Controls.Add(new MyPanel(new frmC2Pineline(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Pipeline"].Value.ToString()))));
				else if (tabname == "Pipeline Report")
		         	newTabPage.Controls.Add(new MyPanel(new frmC2Pipelinereport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Pipelinereport"].Value.ToString()))));					
				else if (tabname == "Client-Position")
		         	newTabPage.Controls.Add(new MyPanel(new frmClientPosition(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ClientPosition"].Value.ToString()))));
				else if (tabname == "Client-Application")
		         	newTabPage.Controls.Add(new MyPanel(new frmClientApplication(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ClientApplication"].Value.ToString()))));
				else if (tabname == "CRM")
		         	newTabPage.Controls.Add(new MyPanel(new frmCRM(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_CRM"].Value.ToString()))));
				else if (tabname == "Information")
		         	newTabPage.Controls.Add(new MyPanel(new frmInformation(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Mainboard"].Value.ToString()))));
				else if (tabname == "News")
		         	newTabPage.Controls.Add(new MyPanel(new frmNews(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_News"].Value.ToString()))));
				else if (tabname == "C2Engagement")
		         	newTabPage.Controls.Add(new MyPanel(new frmC2Engagement(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_C2Engagement"].Value.ToString()))));
				else if (tabname == "C2Engagement Report")
		         	newTabPage.Controls.Add(new MyPanel(new frmC2Engagementreport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_C2Engagement"].Value.ToString()))));
				
			}
			else
				tclMain.SelectedTab = tclMain.TabPages[tabname];
   		}
   		
		
		void TclMainMouseUp(object sender, MouseEventArgs e)
		{
			for (int i = 0; i < this.tclMain.TabPages.Count; i++)
				if (this.tclMain.TabPages[i].Name == "Main Form") 
			{
			    Rectangle r = tclMain.GetTabRect(i);
			   //Getting the position of the "x" mark.
			    Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 3, 9, 12);
			    if (closeButton.Contains(e.Location))
			    {
			        if (MessageBox.Show("Are you sure you want to close this tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			        {
			            this.tclMain.TabPages.RemoveAt(i);
			            
			            if (tclMain.TabCount ==0)
			            {
			            	tclMain.Visible = true;
			            	//pictureBox1.Visible = true;
			            }
			            break;
			        }
			    }
			}
		}
		
		void TclMainKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
			{
				if (tclMain.TabCount > 0)
				{
					if (tclMain.SelectedTab.Name == "Main form")
						return; 

			        if (MessageBox.Show("Are you sure you want to close this tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			        {
			        	this.tclMain.TabPages.Remove(tclMain.SelectedTab);
			            
			        	//this.tclMain.SelectedTab = this.tclMain.TabPages
			        	
			        	if (tclMain.TabCount == 0)	
			            {
			            	tclMain.Visible = true;
			            	//pictureBox1.Visible = true;
			            }
			        }
				}
				else if (tclMain.TabCount == 0)	
	            {
	            	tclMain.Visible = true;
	            	//pictureBox1.Visible = true;
	            }
			}
			else if (e.KeyData == Keys.F5)
			{
				if (tclMain.TabPages.Count > 0)
				{
					string tabname = tclMain.SelectedTab.Name;
					
					tclMain.TabPages.Remove(tclMain.SelectedTab);
					
					addNewtab(tabname);
				}
				else 
				{
					DataConnect.ReConnectData();
				}
			}
		}
	}
}
