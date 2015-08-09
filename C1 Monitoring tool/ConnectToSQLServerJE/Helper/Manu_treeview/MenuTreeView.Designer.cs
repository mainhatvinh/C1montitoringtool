/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 5/23/2013
 * Time: 9:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ButtonTreeUserControl
{
	partial class MenuTreeView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTreeView));
			this.TreeViewPanel2 = new ButtonTree1.ButtonTree();
			this.SuspendLayout();
			// 
			// TreeViewPanel2
			// 
			this.TreeViewPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TreeViewPanel2.ButtonNodeSize = new System.Drawing.Size(150, 22);
			this.TreeViewPanel2.IndicatorButtonSeparator = 5;
			this.TreeViewPanel2.IndicatorButtonSize = new System.Drawing.Size(18, 18);						
			this.TreeViewPanel2.Location = new System.Drawing.Point(24, 12);
			this.TreeViewPanel2.MyImage = null;
			this.TreeViewPanel2.Name = "TreeViewPanel2";
			this.TreeViewPanel2.Size = new System.Drawing.Size(240, 840);
			this.TreeViewPanel2.TabIndex = 0;
			// 
			// MenuTreeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1432, 866);
			this.Controls.Add(this.TreeViewPanel2);
			this.Name = "MenuTreeView";
			this.Text = "MenuTreeView";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MenuTreeViewLoad);
			this.ResumeLayout(false);
		}
		private ButtonTree1.ButtonTree TreeViewPanel2;
		private ButtonTree1.ButtonNode btn_MasterData;
		private ButtonTree1.ButtonNode btn_EngMonitoring;
		private ButtonTree1.ButtonNode btn_Report;
		private ButtonTree1.ButtonNode btn_Client;
		private ButtonTree1.ButtonNode btn_Member;
		private ButtonTree1.ButtonNode btn_Engagement;
		private ButtonTree1.ButtonNode btn_Application;
		private ButtonTree1.ButtonNode btn_Industry;
		private ButtonTree1.ButtonNode btn_Rate;
		private ButtonTree1.ButtonNode btn_Booking;
		private ButtonTree1.ButtonNode btn_BudgetStaffing;
		private ButtonTree1.ButtonNode btn_WorkStatus;
		private ButtonTree1.ButtonNode btn_Retain;
		private ButtonTree1.ButtonNode btn_RetainGeneral;
		private ButtonTree1.ButtonNode btn_RetainDetailed;
		private ButtonTree1.ButtonNode btn_Utilization;
		private ButtonTree1.ButtonNode btn_UtiToDate;
		private ButtonTree1.ButtonNode btn_ChargedHours;
		private ButtonTree1.ButtonNode btn_EngManagement;
		private ButtonTree1.ButtonNode btn_WSReport;
		private ButtonTree1.ButtonNode btn_Revenue;
	}
}
