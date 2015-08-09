/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 5/23/2013
 * Time: 9:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ButtonTree1;

namespace ButtonTreeUserControl
{
	/// <summary>
	/// Description of MenuTreeView.
	/// </summary>
	public partial class MenuTreeView : Form
	{
		public MenuTreeView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MenuLoad()
		{
			btn_MasterData = new ButtonNode();
			btn_MasterData.NodeButton.Text = "Master Data";
			btn_Client = new ButtonTree1.ButtonNode();			
			btn_Client.NodeButton.Text = "Client";
			btn_MasterData.AddChild(btn_Client);
			
			btn_Member = new ButtonNode();
			btn_Member.NodeButton.Text = "ITRA VN Member";
			btn_MasterData.AddChild(btn_Member);
			
			btn_Application = new ButtonNode();
			btn_Application.NodeButton.Text = "Application";
			btn_MasterData.AddChild(btn_Application);
			
			btn_Engagement = new ButtonNode();
			btn_Engagement.NodeButton.Text = "Engagement";
			btn_MasterData.AddChild(btn_Engagement);
			
			btn_Industry = new ButtonNode();
			btn_Industry.NodeButton.Text = "Industry";
			btn_MasterData.AddChild(btn_Industry);
			
			btn_Rate = new ButtonNode();
			btn_Rate.NodeButton.Text = "Rate";
			btn_MasterData.AddChild(btn_Rate);
			
			TreeViewPanel2.Add(btn_MasterData);
			// Engagement Monitoring
			btn_EngMonitoring = new ButtonNode();
			btn_EngMonitoring.NodeButton.Text = "Engagement Monitoring";
			
			btn_BudgetStaffing = new ButtonTree1.ButtonNode();			
			btn_BudgetStaffing.NodeButton.Text = "Booking - Budget";
			btn_EngMonitoring.AddChild(btn_BudgetStaffing);
			
			btn_Booking = new ButtonTree1.ButtonNode();			
			btn_Booking.NodeButton.Text = "Booking";
			btn_EngMonitoring.AddChild(btn_Booking);
			
			btn_WorkStatus = new ButtonTree1.ButtonNode();			
			btn_WorkStatus.NodeButton.Text = "Work Status";
			btn_EngMonitoring.AddChild(btn_WorkStatus);
			
			TreeViewPanel2.Add(btn_EngMonitoring);
			
			// Report
			btn_Report = new ButtonNode();
			btn_Report.NodeButton.Text = "Report";
			
			btn_Retain = new ButtonTree1.ButtonNode();			
			btn_Retain.NodeButton.Text = "Retain report";
			btn_Report.AddChild(btn_Retain);

			btn_RetainGeneral = new ButtonTree1.ButtonNode();			
			btn_RetainGeneral.NodeButton.Text = "General report";
			btn_Retain.AddChild(btn_RetainGeneral);

			btn_RetainDetailed = new ButtonTree1.ButtonNode();			
			btn_RetainDetailed.NodeButton.Text = "Detailed report";
			btn_Retain.AddChild(btn_RetainDetailed);
			
			btn_Utilization = new ButtonTree1.ButtonNode();			
			btn_Utilization.NodeButton.Text = "Utilization report";
			btn_Report.AddChild(btn_Utilization);
			
			btn_UtiToDate= new ButtonTree1.ButtonNode();			
			btn_UtiToDate.NodeButton.Text = "Utilization report to date";
			btn_Utilization.AddChild(btn_UtiToDate);
			
			btn_ChargedHours= new ButtonTree1.ButtonNode();			
			btn_ChargedHours.NodeButton.Text = "Charged hours management";
			btn_Utilization.AddChild(btn_ChargedHours);
			
			btn_EngManagement= new ButtonTree1.ButtonNode();			
			btn_EngManagement.NodeButton.Text = "Engagement management";
			btn_Utilization.AddChild(btn_EngManagement);
			
			btn_WSReport = new ButtonTree1.ButtonNode();			
			btn_WSReport.NodeButton.Text = "Work Status report";
			btn_Report.AddChild(btn_WSReport);
			
			btn_Revenue = new ButtonTree1.ButtonNode();			
			btn_Revenue.NodeButton.Text = "Revenue report";
			btn_Report.AddChild(btn_Revenue);
			
			TreeViewPanel2.Add(btn_Report);
		}
		
		void MenuTreeViewLoad(object sender, EventArgs e)
		{
			MenuLoad();
		}
	}
}

