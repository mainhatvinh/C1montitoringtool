/*
 * Created by SharpDevelop.
 * User: luan.khanh.ha
 * Date: 6/3/2013
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmC2Engagementreport
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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.btnExport1 = new System.Windows.Forms.Button();
			this.grdCRM = new System.Windows.Forms.DataGridView();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdCRM)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.btnExport1);
			this.mainPanel.Controls.Add(this.grdCRM);
			this.mainPanel.Location = new System.Drawing.Point(12, 3);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1168, 763);
			this.mainPanel.TabIndex = 0;
			// 
			// btnExport1
			// 
			this.btnExport1.Location = new System.Drawing.Point(1077, 668);
			this.btnExport1.Name = "btnExport1";
			this.btnExport1.Size = new System.Drawing.Size(70, 29);
			this.btnExport1.TabIndex = 6;
			this.btnExport1.Text = "Export";
			this.btnExport1.UseVisualStyleBackColor = true;
			this.btnExport1.Click += new System.EventHandler(this.BtnExport1Click);
			// 
			// grdCRM
			// 
			this.grdCRM.AllowUserToAddRows = false;
			this.grdCRM.AllowUserToDeleteRows = false;
			this.grdCRM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.grdCRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdCRM.Location = new System.Drawing.Point(3, 40);
			this.grdCRM.Name = "grdCRM";
			this.grdCRM.ReadOnly = true;
			this.grdCRM.Size = new System.Drawing.Size(1162, 610);
			this.grdCRM.TabIndex = 2;
			this.grdCRM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCRMCellDoubleClick);
			this.grdCRM.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdCRMDataBindingComplete);
			// 
			// frmC2Engagementreport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 778);
			this.Controls.Add(this.mainPanel);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "frmC2Engagementreport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Details";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRetain_PopupFormClosing);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdCRM)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnExport1;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.DataGridView grdCRM;
	}
}
