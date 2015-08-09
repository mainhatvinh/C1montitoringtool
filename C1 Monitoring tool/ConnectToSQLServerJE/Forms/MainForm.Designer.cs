/*
 * Created by SharpDevelop.
 * User: an.c.thien.nguyen
 * Date: 5/16/2013
 * Time: 6:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 using System.Data.SqlClient;
 
namespace C1Monitoring
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tclMain = new System.Windows.Forms.TabControl();
			this.TreeViewPanel2 = new ButtonTree1.ButtonTree();
			this.grdMatrix_Role = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.TreeViewPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMatrix_Role)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tclMain
			// 
			this.tclMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tclMain.Location = new System.Drawing.Point(238, 3);
			this.tclMain.Name = "tclMain";
			this.tclMain.SelectedIndex = 0;
			this.tclMain.Size = new System.Drawing.Size(1230, 877);
			this.tclMain.TabIndex = 3;
			this.tclMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TclMainKeyUp);
			this.tclMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TclMainMouseUp);
			// 
			// TreeViewPanel2
			// 
			this.TreeViewPanel2.AutoScroll = true;
			this.TreeViewPanel2.ButtonNodeSize = new System.Drawing.Size(150, 27);
			this.TreeViewPanel2.Controls.Add(this.grdMatrix_Role);
			this.TreeViewPanel2.IndicatorButtonSeparator = 5;
			this.TreeViewPanel2.IndicatorButtonSize = new System.Drawing.Size(15, 15);
			this.TreeViewPanel2.IndicatorOffImage = ((System.Drawing.Image)(resources.GetObject("TreeViewPanel2.IndicatorOffImage")));
			this.TreeViewPanel2.IndicatorOnImage = ((System.Drawing.Image)(resources.GetObject("TreeViewPanel2.IndicatorOnImage")));
			this.TreeViewPanel2.Location = new System.Drawing.Point(26, 32);
			this.TreeViewPanel2.MyImage = null;
			this.TreeViewPanel2.Name = "TreeViewPanel2";
			this.TreeViewPanel2.Size = new System.Drawing.Size(22, 29);
			this.TreeViewPanel2.TabIndex = 4;
			// 
			// grdMatrix_Role
			// 
			this.grdMatrix_Role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMatrix_Role.Location = new System.Drawing.Point(0, -2);
			this.grdMatrix_Role.Name = "grdMatrix_Role";
			this.grdMatrix_Role.Size = new System.Drawing.Size(10, 10);
			this.grdMatrix_Role.TabIndex = 0;
			this.grdMatrix_Role.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(238, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1200, 867);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "C1 Monitoring Tool v2.1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1DoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(1432, 866);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tclMain);
			this.Controls.Add(this.TreeViewPanel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1 Monitoring Tool v3.9";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
			this.TreeViewPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdMatrix_Role)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView grdMatrix_Role;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private ButtonTree1.ButtonTree TreeViewPanel2;
		private System.Windows.Forms.TabControl tclMain;
		
		//Menu Tree View
		//private ButtonTree1.ButtonTree TreeViewPanel2;
		private ButtonTree1.ButtonNode btn_MasterData;
		private ButtonTree1.ButtonNode btn_EngMonitoring;
		private ButtonTree1.ButtonNode btn_Report;
		private ButtonTree1.ButtonNode btn_Client;
		private ButtonTree1.ButtonNode btn_Member;
		private ButtonTree1.ButtonNode btn_Engagement;
		private ButtonTree1.ButtonNode btn_AppOSDB;
		private ButtonTree1.ButtonNode btn_Industry;
		private ButtonTree1.ButtonNode btn_Rate;
		private ButtonTree1.ButtonNode btn_Booking;
		private ButtonTree1.ButtonNode btn_BudgetStaffing;
		private ButtonTree1.ButtonNode btn_WorkStatus;
		private ButtonTree1.ButtonNode btn_Infrastructure;
		private ButtonTree1.ButtonNode btn_Retain;
		private ButtonTree1.ButtonNode btn_Utilization;
		private ButtonTree1.ButtonNode btn_WSReport;
		private ButtonTree1.ButtonNode btn_Revenue;
		private ButtonTree1.ButtonNode btn_Timesheet;
		private ButtonTree1.ButtonNode btn_Other;
		private ButtonTree1.ButtonNode btn_ERP;
		private ButtonTree1.ButtonNode btn_BudgetActual;
		private ButtonTree1.ButtonNode btn_BookingN;
		private ButtonTree1.ButtonNode btn_RateChange;
		private ButtonTree1.ButtonNode btn_AuditTrail;
		private ButtonTree1.ButtonNode btn_EngDetail;
		private ButtonTree1.ButtonNode btn_Configuration;
		private ButtonTree1.ButtonNode btn_ClientReport;
		
		void TreeViewPanel2Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
