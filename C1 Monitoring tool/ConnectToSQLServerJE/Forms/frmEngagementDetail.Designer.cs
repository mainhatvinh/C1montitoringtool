/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/29/2013
 * Time: 6:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmEngagementDetail
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
			this.grdTemp1 = new System.Windows.Forms.DataGridView();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.grdEngagement = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radStaff = new System.Windows.Forms.RadioButton();
			this.radDetail = new System.Windows.Forms.RadioButton();
			this.radMIC = new System.Windows.Forms.RadioButton();
			this.radSIC = new System.Windows.Forms.RadioButton();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.cmbRevenue = new System.Windows.Forms.ComboBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdEngagement)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdTemp1);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.grdEngagement);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// grdTemp1
			// 
			this.grdTemp1.AllowUserToAddRows = false;
			this.grdTemp1.AllowUserToDeleteRows = false;
			this.grdTemp1.AllowUserToOrderColumns = true;
			this.grdTemp1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp1.Location = new System.Drawing.Point(730, 612);
			this.grdTemp1.Name = "grdTemp1";
			this.grdTemp1.ReadOnly = true;
			this.grdTemp1.Size = new System.Drawing.Size(364, 135);
			this.grdTemp1.TabIndex = 12;
			this.grdTemp1.Visible = false;
			// 
			// grdTemp
			// 
			this.grdTemp.AllowUserToAddRows = false;
			this.grdTemp.AllowUserToDeleteRows = false;
			this.grdTemp.AllowUserToOrderColumns = true;
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(730, 468);
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.ReadOnly = true;
			this.grdTemp.Size = new System.Drawing.Size(364, 135);
			this.grdTemp.TabIndex = 11;
			this.grdTemp.Visible = false;
			// 
			// grdEngagement
			// 
			this.grdEngagement.AllowUserToAddRows = false;
			this.grdEngagement.AllowUserToDeleteRows = false;
			this.grdEngagement.AllowUserToOrderColumns = true;
			this.grdEngagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdEngagement.Location = new System.Drawing.Point(125, 177);
			this.grdEngagement.MultiSelect = false;
			this.grdEngagement.Name = "grdEngagement";
			this.grdEngagement.ReadOnly = true;
			this.grdEngagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdEngagement.ShowRowErrors = false;
			this.grdEngagement.Size = new System.Drawing.Size(950, 558);
			this.grdEngagement.TabIndex = 10;
			this.grdEngagement.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdEngagementCellMouseDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radStaff);
			this.groupBox1.Controls.Add(this.radDetail);
			this.groupBox1.Controls.Add(this.radMIC);
			this.groupBox1.Controls.Add(this.radSIC);
			this.groupBox1.Controls.Add(this.btnExport);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.cmbRevenue);
			this.groupBox1.Controls.Add(this.cmbYear);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(125, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 161);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Retain report";
			// 
			// radStaff
			// 
			this.radStaff.Location = new System.Drawing.Point(241, 83);
			this.radStaff.Name = "radStaff";
			this.radStaff.Size = new System.Drawing.Size(125, 24);
			this.radStaff.TabIndex = 3;
			this.radStaff.TabStop = true;
			this.radStaff.Text = "Non MIC/SIC Role";
			this.radStaff.UseVisualStyleBackColor = true;
			// 
			// radDetail
			// 
			this.radDetail.Location = new System.Drawing.Point(566, 83);
			this.radDetail.Name = "radDetail";
			this.radDetail.Size = new System.Drawing.Size(127, 24);
			this.radDetail.TabIndex = 6;
			this.radDetail.TabStop = true;
			this.radDetail.Text = "Engagement Details";
			this.radDetail.UseVisualStyleBackColor = true;
			this.radDetail.CheckedChanged += new System.EventHandler(this.RadDetailCheckedChanged);
			// 
			// radMIC
			// 
			this.radMIC.Location = new System.Drawing.Point(469, 83);
			this.radMIC.Name = "radMIC";
			this.radMIC.Size = new System.Drawing.Size(83, 24);
			this.radMIC.TabIndex = 5;
			this.radMIC.TabStop = true;
			this.radMIC.Text = "MIC Role";
			this.radMIC.UseVisualStyleBackColor = true;
			// 
			// radSIC
			// 
			this.radSIC.Location = new System.Drawing.Point(378, 83);
			this.radSIC.Name = "radSIC";
			this.radSIC.Size = new System.Drawing.Size(100, 24);
			this.radSIC.TabIndex = 4;
			this.radSIC.TabStop = true;
			this.radSIC.Text = "SIC Role";
			this.radSIC.UseVisualStyleBackColor = true;
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(534, 115);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(85, 34);
			this.btnExport.TabIndex = 9;
			this.btnExport.Text = "Export to Excel";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(417, 115);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 34);
			this.btnSubmit.TabIndex = 8;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(300, 115);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 34);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "Clear";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// cmbRevenue
			// 
			this.cmbRevenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRevenue.FormattingEnabled = true;
			this.cmbRevenue.Items.AddRange(new object[] {
									"HCM",
									"Hanoi",
									"Laos",
									"Cambodia"});
			this.cmbRevenue.Location = new System.Drawing.Point(431, 13);
			this.cmbRevenue.Name = "cmbRevenue";
			this.cmbRevenue.Size = new System.Drawing.Size(121, 21);
			this.cmbRevenue.TabIndex = 1;
			// 
			// cmbYear
			// 
			this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Items.AddRange(new object[] {
									"2010",
									"2011",
									"2012",
									"2013",
									"2014",
									"2015",
									"2016",
									"2017",
									"2018",
									"2019",
									"2020"});
			this.cmbYear.Location = new System.Drawing.Point(431, 46);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 21);
			this.cmbYear.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(298, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "EY Fiscal Year:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(298, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Working Location:";
			// 
			// frmEngagementDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmEngagementDetail";
			this.Text = "frmRetainReport";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEngagementDetailFormClosing);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdEngagement)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton radStaff;
		private System.Windows.Forms.RadioButton radDetail;
		private System.Windows.Forms.RadioButton radSIC;
		private System.Windows.Forms.RadioButton radMIC;
		
		
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.DataGridView grdTemp1;
		private System.Windows.Forms.DataGridView grdEngagement;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.ComboBox cmbRevenue;
		private System.Windows.Forms.Panel mainPanel;
		
		
		
		
	}
}
