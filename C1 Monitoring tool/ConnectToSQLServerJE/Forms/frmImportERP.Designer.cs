/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 7/18/2013
 * Time: 2:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmImportERP
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
			this.grdTempERP = new System.Windows.Forms.DataGridView();
			this.grdTempST = new System.Windows.Forms.DataGridView();
			this.grbImportST = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnDelST = new System.Windows.Forms.Button();
			this.btnSubmitST = new System.Windows.Forms.Button();
			this.cmbYearST = new System.Windows.Forms.ComboBox();
			this.btnClearST = new System.Windows.Forms.Button();
			this.cmbEngagementST = new System.Windows.Forms.ComboBox();
			this.btnBrowseST = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbMonthST = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.grdST = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.grdPreviewST = new System.Windows.Forms.DataGridView();
			this.grbImportERP = new System.Windows.Forms.GroupBox();
			this.btnDelERP = new System.Windows.Forms.Button();
			this.btnSubmitERP = new System.Windows.Forms.Button();
			this.cmbYearERP = new System.Windows.Forms.ComboBox();
			this.btnClearERP = new System.Windows.Forms.Button();
			this.cmbEngagementERP = new System.Windows.Forms.ComboBox();
			this.btnBrowseERP = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbMonthERP = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grdERP = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.grdPreviewERP = new System.Windows.Forms.DataGridView();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTempERP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTempST)).BeginInit();
			this.grbImportST.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPreviewST)).BeginInit();
			this.grbImportERP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdERP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPreviewERP)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdTempERP);
			this.mainPanel.Controls.Add(this.grdTempST);
			this.mainPanel.Controls.Add(this.grbImportST);
			this.mainPanel.Controls.Add(this.grbImportERP);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 1;
			// 
			// grdTempERP
			// 
			this.grdTempERP.AllowUserToAddRows = false;
			this.grdTempERP.AllowUserToDeleteRows = false;
			this.grdTempERP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTempERP.Location = new System.Drawing.Point(7, 13);
			this.grdTempERP.Name = "grdTempERP";
			this.grdTempERP.ReadOnly = true;
			this.grdTempERP.Size = new System.Drawing.Size(39, 36);
			this.grdTempERP.TabIndex = 4;
			this.grdTempERP.Visible = false;
			// 
			// grdTempST
			// 
			this.grdTempST.AllowUserToAddRows = false;
			this.grdTempST.AllowUserToDeleteRows = false;
			this.grdTempST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTempST.Location = new System.Drawing.Point(1139, 12);
			this.grdTempST.Name = "grdTempST";
			this.grdTempST.ReadOnly = true;
			this.grdTempST.Size = new System.Drawing.Size(41, 36);
			this.grdTempST.TabIndex = 5;
			this.grdTempST.Visible = false;
			// 
			// grbImportST
			// 
			this.grbImportST.Controls.Add(this.dataGridView1);
			this.grbImportST.Controls.Add(this.btnDelST);
			this.grbImportST.Controls.Add(this.btnSubmitST);
			this.grbImportST.Controls.Add(this.cmbYearST);
			this.grbImportST.Controls.Add(this.btnClearST);
			this.grbImportST.Controls.Add(this.cmbEngagementST);
			this.grbImportST.Controls.Add(this.btnBrowseST);
			this.grbImportST.Controls.Add(this.label5);
			this.grbImportST.Controls.Add(this.cmbMonthST);
			this.grbImportST.Controls.Add(this.label6);
			this.grbImportST.Controls.Add(this.label7);
			this.grbImportST.Controls.Add(this.grdST);
			this.grbImportST.Controls.Add(this.label8);
			this.grbImportST.Controls.Add(this.grdPreviewST);
			this.grbImportST.Location = new System.Drawing.Point(602, 35);
			this.grbImportST.Name = "grbImportST";
			this.grbImportST.Size = new System.Drawing.Size(536, 722);
			this.grbImportST.TabIndex = 4;
			this.grbImportST.TabStop = false;
			this.grbImportST.Text = "Import Actual Sold Time";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-59, -23);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(39, 36);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.Visible = false;
			// 
			// btnDelST
			// 
			this.btnDelST.Location = new System.Drawing.Point(220, 373);
			this.btnDelST.Name = "btnDelST";
			this.btnDelST.Size = new System.Drawing.Size(102, 36);
			this.btnDelST.TabIndex = 13;
			this.btnDelST.Text = "Delete";
			this.btnDelST.UseVisualStyleBackColor = true;
			this.btnDelST.Click += new System.EventHandler(this.BtnDelSTClick);
			// 
			// btnSubmitST
			// 
			this.btnSubmitST.Location = new System.Drawing.Point(216, 667);
			this.btnSubmitST.Name = "btnSubmitST";
			this.btnSubmitST.Size = new System.Drawing.Size(102, 36);
			this.btnSubmitST.TabIndex = 12;
			this.btnSubmitST.Text = "Submit";
			this.btnSubmitST.UseVisualStyleBackColor = true;
			this.btnSubmitST.Click += new System.EventHandler(this.BtnSubmitSTClick);
			// 
			// cmbYearST
			// 
			this.cmbYearST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbYearST.FormattingEnabled = true;
			this.cmbYearST.Items.AddRange(new object[] {
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
			this.cmbYearST.Location = new System.Drawing.Point(166, 33);
			this.cmbYearST.Name = "cmbYearST";
			this.cmbYearST.Size = new System.Drawing.Size(121, 21);
			this.cmbYearST.TabIndex = 11;
			this.cmbYearST.SelectedIndexChanged += new System.EventHandler(this.CmbYearSTSelectedIndexChanged);
			// 
			// btnClearST
			// 
			this.btnClearST.Location = new System.Drawing.Point(76, 373);
			this.btnClearST.Name = "btnClearST";
			this.btnClearST.Size = new System.Drawing.Size(102, 36);
			this.btnClearST.TabIndex = 10;
			this.btnClearST.Text = "Clear";
			this.btnClearST.UseVisualStyleBackColor = true;
			this.btnClearST.Click += new System.EventHandler(this.BtnClearSTClick);
			// 
			// cmbEngagementST
			// 
			this.cmbEngagementST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngagementST.FormattingEnabled = true;
			this.cmbEngagementST.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10",
									"11",
									"12"});
			this.cmbEngagementST.Location = new System.Drawing.Point(166, 108);
			this.cmbEngagementST.Name = "cmbEngagementST";
			this.cmbEngagementST.Size = new System.Drawing.Size(266, 21);
			this.cmbEngagementST.TabIndex = 9;
			this.cmbEngagementST.SelectedIndexChanged += new System.EventHandler(this.CmbEngagementSTSelectedIndexChanged);
			// 
			// btnBrowseST
			// 
			this.btnBrowseST.Location = new System.Drawing.Point(365, 373);
			this.btnBrowseST.Name = "btnBrowseST";
			this.btnBrowseST.Size = new System.Drawing.Size(102, 36);
			this.btnBrowseST.TabIndex = 0;
			this.btnBrowseST.Text = "Browse file to import";
			this.btnBrowseST.UseVisualStyleBackColor = true;
			this.btnBrowseST.Click += new System.EventHandler(this.BtnBrowseSTClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(83, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 22);
			this.label5.TabIndex = 8;
			this.label5.Text = "Engagement:";
			// 
			// cmbMonthST
			// 
			this.cmbMonthST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMonthST.FormattingEnabled = true;
			this.cmbMonthST.Items.AddRange(new object[] {
									"01",
									"02",
									"03",
									"04",
									"05",
									"06",
									"07",
									"08",
									"09",
									"10",
									"11",
									"12"});
			this.cmbMonthST.Location = new System.Drawing.Point(166, 71);
			this.cmbMonthST.Name = "cmbMonthST";
			this.cmbMonthST.Size = new System.Drawing.Size(121, 21);
			this.cmbMonthST.TabIndex = 7;
			this.cmbMonthST.SelectedIndexChanged += new System.EventHandler(this.CmbMonthSTSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(83, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "Year:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(83, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 22);
			this.label7.TabIndex = 4;
			this.label7.Text = "Month:";
			// 
			// grdST
			// 
			this.grdST.AllowUserToAddRows = false;
			this.grdST.AllowUserToDeleteRows = false;
			this.grdST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdST.Location = new System.Drawing.Point(46, 149);
			this.grdST.Name = "grdST";
			this.grdST.ReadOnly = true;
			this.grdST.Size = new System.Drawing.Size(451, 208);
			this.grdST.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(46, 430);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(127, 22);
			this.label8.TabIndex = 2;
			this.label8.Text = "Preview before Submit:";
			// 
			// grdPreviewST
			// 
			this.grdPreviewST.AllowUserToAddRows = false;
			this.grdPreviewST.AllowUserToDeleteRows = false;
			this.grdPreviewST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPreviewST.Location = new System.Drawing.Point(46, 454);
			this.grdPreviewST.Name = "grdPreviewST";
			this.grdPreviewST.ReadOnly = true;
			this.grdPreviewST.Size = new System.Drawing.Size(451, 203);
			this.grdPreviewST.TabIndex = 1;
			// 
			// grbImportERP
			// 
			this.grbImportERP.Controls.Add(this.btnDelERP);
			this.grbImportERP.Controls.Add(this.btnSubmitERP);
			this.grbImportERP.Controls.Add(this.cmbYearERP);
			this.grbImportERP.Controls.Add(this.btnClearERP);
			this.grbImportERP.Controls.Add(this.cmbEngagementERP);
			this.grbImportERP.Controls.Add(this.btnBrowseERP);
			this.grbImportERP.Controls.Add(this.label4);
			this.grbImportERP.Controls.Add(this.cmbMonthERP);
			this.grbImportERP.Controls.Add(this.label3);
			this.grbImportERP.Controls.Add(this.label2);
			this.grbImportERP.Controls.Add(this.grdERP);
			this.grbImportERP.Controls.Add(this.label1);
			this.grbImportERP.Controls.Add(this.grdPreviewERP);
			this.grbImportERP.Location = new System.Drawing.Point(52, 35);
			this.grbImportERP.Name = "grbImportERP";
			this.grbImportERP.Size = new System.Drawing.Size(536, 722);
			this.grbImportERP.TabIndex = 3;
			this.grbImportERP.TabStop = false;
			this.grbImportERP.Text = "Import Actual ERP";
			// 
			// btnDelERP
			// 
			this.btnDelERP.Location = new System.Drawing.Point(220, 373);
			this.btnDelERP.Name = "btnDelERP";
			this.btnDelERP.Size = new System.Drawing.Size(102, 36);
			this.btnDelERP.TabIndex = 13;
			this.btnDelERP.Text = "Delete";
			this.btnDelERP.UseVisualStyleBackColor = true;
			this.btnDelERP.Click += new System.EventHandler(this.BtnDelERPClick);
			// 
			// btnSubmitERP
			// 
			this.btnSubmitERP.Location = new System.Drawing.Point(216, 667);
			this.btnSubmitERP.Name = "btnSubmitERP";
			this.btnSubmitERP.Size = new System.Drawing.Size(102, 36);
			this.btnSubmitERP.TabIndex = 12;
			this.btnSubmitERP.Text = "Submit";
			this.btnSubmitERP.UseVisualStyleBackColor = true;
			this.btnSubmitERP.Click += new System.EventHandler(this.BtnSubmitERPClick);
			// 
			// cmbYearERP
			// 
			this.cmbYearERP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbYearERP.FormattingEnabled = true;
			this.cmbYearERP.Items.AddRange(new object[] {
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
			this.cmbYearERP.Location = new System.Drawing.Point(166, 33);
			this.cmbYearERP.Name = "cmbYearERP";
			this.cmbYearERP.Size = new System.Drawing.Size(121, 21);
			this.cmbYearERP.TabIndex = 11;
			this.cmbYearERP.SelectedIndexChanged += new System.EventHandler(this.CmbYearERPSelectedIndexChanged);
			// 
			// btnClearERP
			// 
			this.btnClearERP.Location = new System.Drawing.Point(76, 373);
			this.btnClearERP.Name = "btnClearERP";
			this.btnClearERP.Size = new System.Drawing.Size(102, 36);
			this.btnClearERP.TabIndex = 10;
			this.btnClearERP.Text = "Clear";
			this.btnClearERP.UseVisualStyleBackColor = true;
			this.btnClearERP.Click += new System.EventHandler(this.BtnClearERPClick);
			// 
			// cmbEngagementERP
			// 
			this.cmbEngagementERP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngagementERP.FormattingEnabled = true;
			this.cmbEngagementERP.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10",
									"11",
									"12"});
			this.cmbEngagementERP.Location = new System.Drawing.Point(166, 108);
			this.cmbEngagementERP.Name = "cmbEngagementERP";
			this.cmbEngagementERP.Size = new System.Drawing.Size(266, 21);
			this.cmbEngagementERP.TabIndex = 9;
			this.cmbEngagementERP.SelectedIndexChanged += new System.EventHandler(this.CmbEngagementERPSelectedIndexChanged);
			// 
			// btnBrowseERP
			// 
			this.btnBrowseERP.Location = new System.Drawing.Point(365, 373);
			this.btnBrowseERP.Name = "btnBrowseERP";
			this.btnBrowseERP.Size = new System.Drawing.Size(102, 36);
			this.btnBrowseERP.TabIndex = 0;
			this.btnBrowseERP.Text = "Browse file to import";
			this.btnBrowseERP.UseVisualStyleBackColor = true;
			this.btnBrowseERP.Click += new System.EventHandler(this.btnBrowseERPClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(83, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 22);
			this.label4.TabIndex = 8;
			this.label4.Text = "Engagement:";
			// 
			// cmbMonthERP
			// 
			this.cmbMonthERP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMonthERP.FormattingEnabled = true;
			this.cmbMonthERP.Items.AddRange(new object[] {
									"01",
									"02",
									"03",
									"04",
									"05",
									"06",
									"07",
									"08",
									"09",
									"10",
									"11",
									"12"});
			this.cmbMonthERP.Location = new System.Drawing.Point(166, 71);
			this.cmbMonthERP.Name = "cmbMonthERP";
			this.cmbMonthERP.Size = new System.Drawing.Size(121, 21);
			this.cmbMonthERP.TabIndex = 7;
			this.cmbMonthERP.SelectedIndexChanged += new System.EventHandler(this.CmbMonthERPSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(83, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Year:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(83, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Month:";
			// 
			// grdERP
			// 
			this.grdERP.AllowUserToAddRows = false;
			this.grdERP.AllowUserToDeleteRows = false;
			this.grdERP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdERP.Location = new System.Drawing.Point(46, 149);
			this.grdERP.Name = "grdERP";
			this.grdERP.ReadOnly = true;
			this.grdERP.Size = new System.Drawing.Size(451, 208);
			this.grdERP.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(46, 430);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Preview before Submit:";
			// 
			// grdPreviewERP
			// 
			this.grdPreviewERP.AllowUserToAddRows = false;
			this.grdPreviewERP.AllowUserToDeleteRows = false;
			this.grdPreviewERP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPreviewERP.Location = new System.Drawing.Point(46, 454);
			this.grdPreviewERP.Name = "grdPreviewERP";
			this.grdPreviewERP.ReadOnly = true;
			this.grdPreviewERP.Size = new System.Drawing.Size(451, 203);
			this.grdPreviewERP.TabIndex = 1;
			// 
			// frmImportERP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmImportERP";
			this.Text = "Import Actual ERP - Sold Time";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTempERP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTempST)).EndInit();
			this.grbImportST.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPreviewST)).EndInit();
			this.grbImportERP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdERP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPreviewERP)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView grdTempST;
		private System.Windows.Forms.DataGridView grdPreviewST;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView grdST;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbMonthST;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnBrowseST;
		private System.Windows.Forms.ComboBox cmbEngagementST;
		private System.Windows.Forms.Button btnClearST;
		private System.Windows.Forms.ComboBox cmbYearST;
		private System.Windows.Forms.Button btnSubmitST;
		private System.Windows.Forms.Button btnDelST;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox grbImportST;
		private System.Windows.Forms.Button btnDelERP;
		private System.Windows.Forms.Button btnSubmitERP;
		private System.Windows.Forms.DataGridView grdTempERP;
		private System.Windows.Forms.Button btnClearERP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbEngagementERP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbYearERP;
		private System.Windows.Forms.ComboBox cmbMonthERP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView grdERP;
		private System.Windows.Forms.GroupBox grbImportERP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView grdPreviewERP;
		private System.Windows.Forms.Button btnBrowseERP;
		private System.Windows.Forms.Panel mainPanel;
		

	}
}
