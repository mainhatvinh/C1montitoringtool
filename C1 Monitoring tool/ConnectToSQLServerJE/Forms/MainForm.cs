/*
 * Created by SharpDevelop.
 * User: an.c.thien.nguyen
 * Date: 5/16/2013
 * Time: 6:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using ButtonTree1;


namespace C1Monitoring
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 

	public partial class MainForm : Form
	{
		public static OleDbConnection myConnection = new OleDbConnection();
		//static DataGridView grdMatrix_role = new DataGridView();
		BindingSource myBindingSource = new BindingSource();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			/// <summary>
			/// Neu anh muon khong hien cai popup chon loai connection thi anh comment lai phan 
			/// Form frmpopup = new frmConnect();
			///
			///frmpopup.ShowDialog();
			/// Va Mo comment cho dong DataConnect.ConnectData();
			/// </summary>
			/// <param name="tabname"></param>
			//DataConnect.ConnectData();
			//Form frmpopup = new frmConnect();
			
			//frmpopup.ShowDialog();
			
			DataConnect.ConnectData();
			myBindingSource = dcMatrixrole.GetDataByITRAMemberName(Environment.UserName);
//			myBindingSource = dcMatrixrole.GetDataByITRAMemberName("dung.kim.pham");
//			myBindingSource = dcMatrixrole.GetDataByITRAMemberName("henry.hoang");
			//myBindingSource = dcMatrixrole.GetDataByITRAMemberName("dung.nguyen.bui");
			//myBindingSource = dcMatrixrole.GetDataByITRAMemberName("khoa.tan.duong");
			//myBindingSource = dcMatrixrole.GetDataByITRAMemberName("mai.kim.ngo");
			
			grdMatrix_Role.DataSource = myBindingSource;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}		
		
		//ADD TABS
   		void addNewtab(string tabname)
   		{
   			if(pictureBox1.Visible == true)
   			{
   				pictureBox1.Visible = false;
   				tclMain.Visible = true;
   				tclMain.Focus();
   			}
   			
			if(checkExistedTabPage(tclMain, tabname) == false)
			{
	   			TabPage newTabPage = new TabPage();
				tclMain.Controls.Add(newTabPage);
				newTabPage.Name = tabname;
			 	newTabPage.Text = tabname + "     x";
				newTabPage.Location = new System.Drawing.Point(4, 22);
				newTabPage.Padding = new System.Windows.Forms.Padding(3);
				newTabPage.Size = new System.Drawing.Size(508, 298);
				//newTabPage.TabIndex = tabControl1.Controls.Count - 1;
				newTabPage.UseVisualStyleBackColor = true;
				
				tclMain.SelectedTab = newTabPage;
				
				if (tabname == "Client")
					newTabPage.Controls.Add(new MyPanel(new frmClient(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Client"].Value.ToString()))));
				else if (tabname == "Risk Member")
		         	newTabPage.Controls.Add(new MyPanel(new frmITRAMember(int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ITRA_Member"].Value.ToString()))));
				else if (tabname == "Engagement")
		         	newTabPage.Controls.Add(new MyPanel(new frmEngagement(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Engagement"].Value.ToString()))));
				else if (tabname == "Budget - Staffing")
		         	newTabPage.Controls.Add(new MyPanel(new frmBudgetStaffing(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Budget_Staffing"].Value.ToString()))));
				else if (tabname == "Booking")
		         	newTabPage.Controls.Add(new MyPanel(new frmBooking(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Booking"].Value.ToString()))));
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
				else if (tabname == "Budget - Actual report")
		         	newTabPage.Controls.Add(new MyPanel(new frmBudgetActualReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Budget_Actual"].Value.ToString()))));
				else if (tabname == "Import ERP - Sold Time")
		         	newTabPage.Controls.Add(new MyPanel(new frmImportERP(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Import_ERP"].Value.ToString()))));
				else if (tabname == "Booking Leave")
		         	newTabPage.Controls.Add(new MyPanel(new frmBookingN(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Booking_Leave"].Value.ToString()))));
				else if (tabname == "Rate Change")
		         	newTabPage.Controls.Add(new MyPanel(new frmRateChange(int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Rate_Change"].Value.ToString()))));
				else if (tabname == "Audit Trail")
		         	newTabPage.Controls.Add(new MyPanel(new frmAuditTrail(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_AuditTrail"].Value.ToString()))));			
				else if (tabname == "Engagement List")
		         	newTabPage.Controls.Add(new MyPanel(new frmEngagementDetail(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Engagement_Detail"].Value.ToString()))));
				else if (tabname == "Configuration")
		         	newTabPage.Controls.Add(new MyPanel(new frmConfiguration(int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Configuration"].Value.ToString()))));
				else if (tabname == "Client Report")
		         	newTabPage.Controls.Add(new MyPanel(new frmClientReport(int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Client_Report"].Value.ToString()))));
			}
			else
				tclMain.SelectedTab = tclMain.TabPages[tabname];
   		}
		
   		void BtnITRAMemberTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Risk Member");
   		}
   		
   		void BtnClientTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Client");
   		}
   		
   		void BtnEngagementTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Engagement");
   		}
   		
   		void BtnBudgetStaffingTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Budget - Staffing");
   		}
   		
   		void BtnBookingTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Booking");
   		}
   		
   		void BtnWorkStatusTabClick(object sender, EventArgs e)
   		{
   			addNewtab("Work status");
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
   			addNewtab("Rate Change");
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
		
		
		//TREEVIEW BUTTONS
		void MenuLoad_Btn()
		{
			btn_MasterData = new ButtonNode();
			btn_MasterData.NodeButton.Text = "Master Data";
			btn_MasterData.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			//btn_MasterData.NodeButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_ITRA_Member"].Value.ToString()) != 3)
			{
				btn_Member = new ButtonNode();
				btn_Member.NodeButton.Text = "Risk Member";
				btn_MasterData.AddChild(btn_Member);
				btn_Member.NodeButton.Click += new EventHandler(BtnITRAMemberTabClick);
				btn_Member.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Client"].Value.ToString()) != 3)
			{
				btn_Client = new ButtonTree1.ButtonNode();
				btn_Client.NodeButton.Text = "Client";
				btn_MasterData.AddChild(btn_Client);
				btn_Client.NodeButton.Click += new EventHandler(BtnClientTabClick);
				btn_Client.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Industry"].Value.ToString()) != 3)
			{
				btn_Industry = new ButtonNode();
				btn_Industry.NodeButton.Text = "Industry";
				btn_MasterData.AddChild(btn_Industry);
				btn_Industry.NodeButton.Click += new EventHandler(BtnIndustryTabClick);
				btn_Industry.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Rate"].Value.ToString()) != 3)
			{
				btn_Rate = new ButtonNode();
				btn_Rate.NodeButton.Text = "Rate";
				btn_MasterData.AddChild(btn_Rate);
				btn_Rate.NodeButton.Click += new EventHandler(BtnRateTabClick);
				btn_Rate.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["MT_Application_OS_DB"].Value.ToString()) != 3)
			{
				btn_AppOSDB = new ButtonNode();
				btn_AppOSDB.NodeButton.Text = "Application - OS - DB";
				btn_MasterData.AddChild(btn_AppOSDB);
				btn_AppOSDB.NodeButton.Click += new EventHandler(BtnAppOSDBTabClick);
				btn_AppOSDB.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			TreeViewPanel2.Add(btn_MasterData);
			
			// Engagement Monitoring
			btn_EngMonitoring = new ButtonNode();
			btn_EngMonitoring.NodeButton.Text = "Engagement Monitoring";
			btn_EngMonitoring.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Engagement"].Value.ToString()) != 3)
			{
				btn_Engagement = new ButtonNode();
				btn_Engagement.NodeButton.Text = "Engagement";
				btn_EngMonitoring.AddChild(btn_Engagement);
				btn_Engagement.NodeButton.Click += new EventHandler(BtnEngagementTabClick);
				btn_Engagement.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Budget_Staffing"].Value.ToString()) != 3)
			{
				btn_BudgetStaffing = new ButtonTree1.ButtonNode();			
				btn_BudgetStaffing.NodeButton.Text = "Budget - Staffing";
				btn_EngMonitoring.AddChild(btn_BudgetStaffing);
				btn_BudgetStaffing.NodeButton.Click += new EventHandler(BtnBudgetStaffingTabClick);
				btn_BudgetStaffing.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Booking"].Value.ToString()) != 3)
			{
				btn_Booking = new ButtonTree1.ButtonNode();			
				btn_Booking.NodeButton.Text = "Booking";
				btn_EngMonitoring.AddChild(btn_Booking);
				btn_Booking.NodeButton.Click += new EventHandler(BtnBookingTabClick);
				btn_Booking.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Work_Status"].Value.ToString()) != 3)
			{
				btn_WorkStatus = new ButtonTree1.ButtonNode();			
				btn_WorkStatus.NodeButton.Text = "Work Status";
				btn_EngMonitoring.AddChild(btn_WorkStatus);
				btn_WorkStatus.NodeButton.Click += new EventHandler(BtnWorkStatusTabClick);
				btn_WorkStatus.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Infrastructure"].Value.ToString()) != 3)
			{
				btn_Infrastructure = new ButtonTree1.ButtonNode();			
				btn_Infrastructure.NodeButton.Text = "Infrastructure";
				btn_EngMonitoring.AddChild(btn_Infrastructure);
				btn_Infrastructure.NodeButton.Click += new EventHandler(BtnInfrastructureTabClick);
				btn_Infrastructure.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			}
			
			TreeViewPanel2.Add(btn_EngMonitoring);
			
			// Report
			btn_Report = new ButtonNode();
			btn_Report.NodeButton.Text = "Report";
			btn_Report.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Retain"].Value.ToString()) != 3)
			{
				btn_Retain = new ButtonTree1.ButtonNode();			
				btn_Retain.NodeButton.Text = "Retain";
				btn_Report.AddChild(btn_Retain);
				btn_Retain.NodeButton.Click += new EventHandler(BtnRetainReportTabClick);
				btn_Retain.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Budget_Actual"].Value.ToString()) != 3)
			{
				btn_BudgetActual = new ButtonTree1.ButtonNode();			
				btn_BudgetActual.NodeButton.Text = "Budget && Actual";
				btn_Report.AddChild(btn_BudgetActual);
				btn_BudgetActual.NodeButton.Click += new EventHandler(BtnBudgetActualTabClick);
				btn_BudgetActual.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Utilization"].Value.ToString()) != 3)
			{
				btn_Utilization = new ButtonTree1.ButtonNode();			
				btn_Utilization.NodeButton.Text = "Utilization";
				btn_Report.AddChild(btn_Utilization);
				btn_Utilization.NodeButton.Click += new EventHandler(BtnUtilizationReportTabClick);
				btn_Utilization.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Engagement_Detail"].Value.ToString()) != 3)
			{
				btn_EngDetail = new ButtonTree1.ButtonNode();			
				btn_EngDetail.NodeButton.Text = "Engagement Report";
				btn_Report.AddChild(btn_EngDetail);
				btn_EngDetail.NodeButton.Click += new EventHandler(BtnEngDetailTabClick);
				btn_EngDetail.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Client_Report"].Value.ToString()) != 3)
			{
				btn_ClientReport = new ButtonTree1.ButtonNode();			
				btn_ClientReport.NodeButton.Text = "Client Report";
				btn_Report.AddChild(btn_ClientReport);
				btn_ClientReport.NodeButton.Click += new EventHandler(BtnClientReportTabClick);
				btn_ClientReport.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");		
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Work_Status"].Value.ToString()) != 3)
			{
				btn_WSReport = new ButtonTree1.ButtonNode();			
				btn_WSReport.NodeButton.Text = "Work status";
				btn_Report.AddChild(btn_WSReport);
				btn_WSReport.NodeButton.Click += new EventHandler(BtnWSReportTabClick);
				btn_WSReport.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["RT_Revenue"].Value.ToString()) != 3)
			{
				btn_Revenue = new ButtonTree1.ButtonNode();			
				btn_Revenue.NodeButton.Text = "Revenue";
				btn_Report.AddChild(btn_Revenue);
				btn_Revenue.NodeButton.Click += new EventHandler(BtnRevenueReportTabClick);
				btn_Revenue.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			}
			
			TreeViewPanel2.Add(btn_Report);
			
			// Timesheet
			btn_Other = new ButtonTree1.ButtonNode();
			btn_Other.NodeButton.Text = "Other";
			btn_Other.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_TimeSheet"].Value.ToString()) != 3)
			{
				btn_Timesheet = new ButtonTree1.ButtonNode();			
				btn_Timesheet.NodeButton.Text = "Timesheet";
				btn_Other.AddChild(btn_Timesheet);
				btn_Timesheet.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
				btn_Timesheet.NodeButton.Click += new EventHandler(BtnTimesheetTabClick);
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Import_ERP"].Value.ToString()) != 3)
			{
				//btn_Other.NodeButton.Font.Bold = true;
				btn_ERP = new ButtonTree1.ButtonNode();			
				btn_ERP.NodeButton.Text = "Import ERP - Sold Time";
				btn_Other.AddChild(btn_ERP);
				btn_ERP.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
				btn_ERP.NodeButton.Click += new EventHandler(BtnImportERPTabClick);
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Booking_Leave"].Value.ToString()) != 3)
			{
				//btn_Other.NodeButton.Font.Bold = true;
				btn_BookingN = new ButtonTree1.ButtonNode();			
				btn_BookingN.NodeButton.Text = "Booking Leave";
				btn_Other.AddChild(btn_BookingN);
				btn_BookingN.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
				btn_BookingN.NodeButton.Click += new EventHandler(btn_BookingNTabClick);
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["EM_Rate_Change"].Value.ToString()) != 3)
			{
				//btn_Other.NodeButton.Font.Bold = true;
				btn_RateChange = new ButtonTree1.ButtonNode();			
				btn_RateChange.NodeButton.Text = "Rate Change";
				btn_Other.AddChild(btn_RateChange);
				btn_RateChange.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
				btn_RateChange.NodeButton.Click += new EventHandler(btn_RateChangeTabClick);
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_AuditTrail"].Value.ToString()) != 3)
			{
				//btn_Other.NodeButton.Font.Bold = true;
				btn_AuditTrail = new ButtonTree1.ButtonNode();			
				btn_AuditTrail.NodeButton.Text = "Audit Trail";
				btn_Other.AddChild(btn_AuditTrail);
				btn_AuditTrail.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
				btn_AuditTrail.NodeButton.Click += new EventHandler(btn_AuditTrailTabClick);
			}
			
			if (int.Parse(grdMatrix_Role.Rows[0].Cells["OT_Configuration"].Value.ToString()) != 3)
			{
				//btn_Other.NodeButton.Font.Bold = true;
				btn_Configuration = new ButtonTree1.ButtonNode();			
				btn_Configuration.NodeButton.Text = "Configuration";
				btn_Other.AddChild(btn_Configuration);
				btn_Configuration.NodeButton.BackgroundImage =  System.Drawing.Image.FromFile(@"Data\Icon\btn3.jpg");
				btn_Configuration.NodeButton.Click += new EventHandler(btn_ConfigurationTabClick);
			}
			
			TreeViewPanel2.Add(btn_Other);
			
//			btn_Other.Expand();
//			btn_MasterData.Expand();
//			btn_EngMonitoring.Expand();
//			btn_Report.Expand();
			//TreeViewPanel2.No
			
			//ButtonTree.
			//TreeViewPanel2.ButtonNodes.NodeButtonSize = new Size(150,25);
		}
	
		
		//EVENTS
		void TclMainMouseUp(object sender, MouseEventArgs e)
		{
			for (int i = 0; i < this.tclMain.TabPages.Count; i++)
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
			            	pictureBox1.Visible = true;
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
			        if (MessageBox.Show("Are you sure you want to close this tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			        {
			        	this.tclMain.TabPages.Remove(tclMain.SelectedTab);
			            
			        	//this.tclMain.SelectedTab = this.tclMain.TabPages
			        	
			        	if (tclMain.TabCount == 0)	
			            {
			            	tclMain.Visible = true;
			            	pictureBox1.Visible = true;
			            }
			        }
				}
				else if (tclMain.TabCount == 0)	
	            {
	            	tclMain.Visible = true;
	            	pictureBox1.Visible = true;
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
		
		void MenuLoad_OutLook()
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//MenuLoad_Btn();
		}
		
	
		void NotifyIcon1DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
			
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			
			DialogResult result = MessageBox.Show("Do you want to move application to System Tray?","Confirm",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
			
			switch (result)
			{
			    case DialogResult.Yes:
			        // User pressed Yes button 
			        // ... 
			        Hide();
			        e.Cancel = true;
			        break;
			    case DialogResult.No:
			        // User pressed No button 
			        // ... 
			        notifyIcon1.Dispose();
			       // e.Cancel = true;
			        break;
			    case DialogResult.Cancel:
			        // User pressed Cancel button 
			        // ... 
			        e.Cancel = true;
			        break;
			}
			base.OnClosing(e);
		}
		
		void MainFormKeyUp(object sender, KeyEventArgs e)
		{
			
		}
	}
}
