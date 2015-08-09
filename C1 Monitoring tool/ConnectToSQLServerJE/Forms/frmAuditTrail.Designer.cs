/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 7/19/2013
 * Time: 2:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmAuditTrail
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.grdAuditTrail = new System.Windows.Forms.DataGridView();
			this.mainPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdAuditTrail)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.grdAuditTrail);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnExport);
			this.groupBox1.Location = new System.Drawing.Point(12, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1168, 126);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Audit Trail";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(431, 61);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 44);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Save";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
			this.btnSubmit.Location = new System.Drawing.Point(303, 61);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 44);
			this.btnSubmit.TabIndex = 1;
			this.btnSubmit.Text = "Check";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(555, 61);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(85, 44);
			this.btnExport.TabIndex = 3;
			this.btnExport.Text = "Export to Excel";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
			// 
			// grdAuditTrail
			// 
			this.grdAuditTrail.AllowUserToAddRows = false;
			this.grdAuditTrail.AllowUserToDeleteRows = false;
			this.grdAuditTrail.AllowUserToOrderColumns = true;
			this.grdAuditTrail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdAuditTrail.Location = new System.Drawing.Point(12, 208);
			this.grdAuditTrail.MultiSelect = false;
			this.grdAuditTrail.Name = "grdAuditTrail";
			this.grdAuditTrail.ReadOnly = true;
			this.grdAuditTrail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdAuditTrail.Size = new System.Drawing.Size(1168, 356);
			this.grdAuditTrail.TabIndex = 4;
			// 
			// frmAuditTrail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmAuditTrail";
			this.Text = "frmAuditTrail";
			this.mainPanel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdAuditTrail)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grdAuditTrail;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Panel mainPanel;
	}
}
