/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/29/2013
 * Time: 6:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmBudgetActualReport
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
			this.grdTemp2 = new System.Windows.Forms.DataGridView();
			this.grdTemp1 = new System.Windows.Forms.DataGridView();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.grdUtilization = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbName3 = new System.Windows.Forms.ComboBox();
			this.cmbSIC = new System.Windows.Forms.ComboBox();
			this.cmbSM_MIC = new System.Windows.Forms.ComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.btnExport3 = new System.Windows.Forms.Button();
			this.cmbYear2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSubmit3 = new System.Windows.Forms.Button();
			this.btnReset3 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbYear1 = new System.Windows.Forms.ComboBox();
			this.btnExport2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSubmit2 = new System.Windows.Forms.Button();
			this.btnClear2 = new System.Windows.Forms.Button();
			this.cmbName2 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUtilization)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdTemp2);
			this.mainPanel.Controls.Add(this.grdTemp1);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.grdUtilization);
			this.mainPanel.Controls.Add(this.groupBox3);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// grdTemp2
			// 
			this.grdTemp2.AllowUserToAddRows = false;
			this.grdTemp2.AllowUserToDeleteRows = false;
			this.grdTemp2.AllowUserToOrderColumns = true;
			this.grdTemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp2.Location = new System.Drawing.Point(780, 373);
			this.grdTemp2.MultiSelect = false;
			this.grdTemp2.Name = "grdTemp2";
			this.grdTemp2.ReadOnly = true;
			this.grdTemp2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp2.Size = new System.Drawing.Size(324, 115);
			this.grdTemp2.TabIndex = 21;
			this.grdTemp2.Visible = false;
			// 
			// grdTemp1
			// 
			this.grdTemp1.AllowUserToAddRows = false;
			this.grdTemp1.AllowUserToDeleteRows = false;
			this.grdTemp1.AllowUserToOrderColumns = true;
			this.grdTemp1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp1.Location = new System.Drawing.Point(780, 507);
			this.grdTemp1.MultiSelect = false;
			this.grdTemp1.Name = "grdTemp1";
			this.grdTemp1.ReadOnly = true;
			this.grdTemp1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp1.Size = new System.Drawing.Size(324, 142);
			this.grdTemp1.TabIndex = 20;
			this.grdTemp1.Visible = false;
			// 
			// grdTemp
			// 
			this.grdTemp.AllowUserToAddRows = false;
			this.grdTemp.AllowUserToDeleteRows = false;
			this.grdTemp.AllowUserToOrderColumns = true;
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(780, 209);
			this.grdTemp.MultiSelect = false;
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.ReadOnly = true;
			this.grdTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp.Size = new System.Drawing.Size(324, 142);
			this.grdTemp.TabIndex = 19;
			this.grdTemp.Visible = false;
			// 
			// grdUtilization
			// 
			this.grdUtilization.AllowUserToAddRows = false;
			this.grdUtilization.AllowUserToDeleteRows = false;
			this.grdUtilization.AllowUserToOrderColumns = true;
			this.grdUtilization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdUtilization.Location = new System.Drawing.Point(42, 197);
			this.grdUtilization.MultiSelect = false;
			this.grdUtilization.Name = "grdUtilization";
			this.grdUtilization.ReadOnly = true;
			this.grdUtilization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdUtilization.Size = new System.Drawing.Size(1127, 583);
			this.grdUtilization.TabIndex = 18;
			this.grdUtilization.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUtilizationCellDoubleClick);
			this.grdUtilization.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdUtilizationColumnAdded);
			this.grdUtilization.DoubleClick += new System.EventHandler(this.GrdUtilizationDoubleClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbName3);
			this.groupBox3.Controls.Add(this.cmbSIC);
			this.groupBox3.Controls.Add(this.cmbSM_MIC);
			this.groupBox3.Controls.Add(this.label32);
			this.groupBox3.Controls.Add(this.label31);
			this.groupBox3.Controls.Add(this.btnExport3);
			this.groupBox3.Controls.Add(this.cmbYear2);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.btnSubmit3);
			this.groupBox3.Controls.Add(this.btnReset3);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new System.Drawing.Point(648, 11);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(521, 180);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Budget - Actual Report Per Engagement";
			// 
			// cmbName3
			// 
			this.cmbName3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName3.FormattingEnabled = true;
			this.cmbName3.Location = new System.Drawing.Point(115, 22);
			this.cmbName3.Name = "cmbName3";
			this.cmbName3.Size = new System.Drawing.Size(368, 21);
			this.cmbName3.TabIndex = 17;
			this.cmbName3.SelectedIndexChanged += new System.EventHandler(this.CmbName3SelectedIndexChanged);
			// 
			// cmbSIC
			// 
			this.cmbSIC.FormattingEnabled = true;
			this.cmbSIC.Location = new System.Drawing.Point(344, 93);
			this.cmbSIC.Name = "cmbSIC";
			this.cmbSIC.Size = new System.Drawing.Size(139, 21);
			this.cmbSIC.TabIndex = 9;
			// 
			// cmbSM_MIC
			// 
			this.cmbSM_MIC.FormattingEnabled = true;
			this.cmbSM_MIC.Location = new System.Drawing.Point(109, 93);
			this.cmbSM_MIC.Name = "cmbSM_MIC";
			this.cmbSM_MIC.Size = new System.Drawing.Size(138, 21);
			this.cmbSM_MIC.TabIndex = 8;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(279, 96);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(62, 23);
			this.label32.TabIndex = 74;
			this.label32.Text = "ITRA SIC:";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(8, 96);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(101, 23);
			this.label31.TabIndex = 73;
			this.label31.Text = "ITRA SM/MIC:";
			// 
			// btnExport3
			// 
			this.btnExport3.Location = new System.Drawing.Point(310, 136);
			this.btnExport3.Name = "btnExport3";
			this.btnExport3.Size = new System.Drawing.Size(85, 34);
			this.btnExport3.TabIndex = 12;
			this.btnExport3.Text = "Export to Excel";
			this.btnExport3.UseVisualStyleBackColor = true;
			this.btnExport3.Click += new System.EventHandler(this.BtnExport3Click);
			// 
			// cmbYear2
			// 
			this.cmbYear2.FormattingEnabled = true;
			this.cmbYear2.Items.AddRange(new object[] {
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
			this.cmbYear2.Location = new System.Drawing.Point(109, 59);
			this.cmbYear2.Name = "cmbYear2";
			this.cmbYear2.Size = new System.Drawing.Size(138, 21);
			this.cmbYear2.TabIndex = 7;
			this.cmbYear2.SelectedIndexChanged += new System.EventHandler(this.CmbYear2SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 20);
			this.label6.TabIndex = 18;
			this.label6.Text = "EY Fiscal Year:";
			// 
			// btnSubmit3
			// 
			this.btnSubmit3.Location = new System.Drawing.Point(200, 136);
			this.btnSubmit3.Name = "btnSubmit3";
			this.btnSubmit3.Size = new System.Drawing.Size(85, 34);
			this.btnSubmit3.TabIndex = 11;
			this.btnSubmit3.Text = "Submit";
			this.btnSubmit3.UseVisualStyleBackColor = true;
			this.btnSubmit3.Click += new System.EventHandler(this.BtnSubmit3Click);
			// 
			// btnReset3
			// 
			this.btnReset3.Location = new System.Drawing.Point(90, 136);
			this.btnReset3.Name = "btnReset3";
			this.btnReset3.Size = new System.Drawing.Size(85, 34);
			this.btnReset3.TabIndex = 10;
			this.btnReset3.Text = "Clear";
			this.btnReset3.UseVisualStyleBackColor = true;
			this.btnReset3.Click += new System.EventHandler(this.BtnReset3Click);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(7, 25);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(113, 23);
			this.label10.TabIndex = 7;
			this.label10.Text = "Engagement Name:";
			this.label10.Click += new System.EventHandler(this.Label10Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbYear1);
			this.groupBox2.Controls.Add(this.btnExport2);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.btnSubmit2);
			this.groupBox2.Controls.Add(this.btnClear2);
			this.groupBox2.Controls.Add(this.cmbName2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(42, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(438, 179);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Budget - Actual Report Per Employee";
			// 
			// cmbYear1
			// 
			this.cmbYear1.FormattingEnabled = true;
			this.cmbYear1.Items.AddRange(new object[] {
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
			this.cmbYear1.Location = new System.Drawing.Point(107, 58);
			this.cmbYear1.Name = "cmbYear1";
			this.cmbYear1.Size = new System.Drawing.Size(121, 21);
			this.cmbYear1.TabIndex = 2;
			this.cmbYear1.SelectedIndexChanged += new System.EventHandler(this.CmbYear1SelectedIndexChanged);
			// 
			// btnExport2
			// 
			this.btnExport2.Location = new System.Drawing.Point(279, 135);
			this.btnExport2.Name = "btnExport2";
			this.btnExport2.Size = new System.Drawing.Size(85, 34);
			this.btnExport2.TabIndex = 5;
			this.btnExport2.Text = "Export to Excel";
			this.btnExport2.UseVisualStyleBackColor = true;
			this.btnExport2.Click += new System.EventHandler(this.BtnExport2Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "EY Fiscal Year:";
			// 
			// btnSubmit2
			// 
			this.btnSubmit2.Location = new System.Drawing.Point(174, 135);
			this.btnSubmit2.Name = "btnSubmit2";
			this.btnSubmit2.Size = new System.Drawing.Size(85, 34);
			this.btnSubmit2.TabIndex = 4;
			this.btnSubmit2.Text = "Submit";
			this.btnSubmit2.UseVisualStyleBackColor = true;
			this.btnSubmit2.Click += new System.EventHandler(this.BtnSubmit2Click);
			// 
			// btnClear2
			// 
			this.btnClear2.Location = new System.Drawing.Point(69, 135);
			this.btnClear2.Name = "btnClear2";
			this.btnClear2.Size = new System.Drawing.Size(85, 34);
			this.btnClear2.TabIndex = 3;
			this.btnClear2.Text = "Clear";
			this.btnClear2.UseVisualStyleBackColor = true;
			this.btnClear2.Click += new System.EventHandler(this.BtnClear2Click);
			// 
			// cmbName2
			// 
			this.cmbName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName2.FormattingEnabled = true;
			this.cmbName2.Location = new System.Drawing.Point(107, 24);
			this.cmbName2.Name = "cmbName2";
			this.cmbName2.Size = new System.Drawing.Size(302, 21);
			this.cmbName2.TabIndex = 1;
			this.cmbName2.SelectedIndexChanged += new System.EventHandler(this.CmbName2SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Employee Name:";
			// 
			// frmBudgetActualReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmBudgetActualReport";
			this.Text = "Budget - Actual Report";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTemp2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUtilization)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.ComboBox cmbSM_MIC;
		private System.Windows.Forms.ComboBox cmbSIC;
		private System.Windows.Forms.DataGridView grdTemp2;
		private System.Windows.Forms.DataGridView grdTemp1;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.Button btnExport2;
		private System.Windows.Forms.Button btnExport3;
		private System.Windows.Forms.DataGridView grdUtilization;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbName2;
		private System.Windows.Forms.Button btnClear2;
		private System.Windows.Forms.Button btnSubmit2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbYear1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbName3;
		private System.Windows.Forms.Button btnReset3;
		private System.Windows.Forms.Button btnSubmit3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbYear2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel mainPanel;
		
		
	}
}
