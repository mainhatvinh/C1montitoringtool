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
	partial class frmRetainReport
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
			this.grdRetain = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.cmbMonth = new System.Windows.Forms.ComboBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbSIC = new System.Windows.Forms.ComboBox();
			this.cmbSM_MIC = new System.Windows.Forms.ComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbEngCode = new System.Windows.Forms.ComboBox();
			this.cmbEngName = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.radDetail = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbName = new System.Windows.Forms.ComboBox();
			this.radGeneral = new System.Windows.Forms.RadioButton();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdRetain)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdTemp1);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.grdRetain);
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
			// grdRetain
			// 
			this.grdRetain.AllowUserToAddRows = false;
			this.grdRetain.AllowUserToDeleteRows = false;
			this.grdRetain.AllowUserToOrderColumns = true;
			this.grdRetain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRetain.Location = new System.Drawing.Point(12, 222);
			this.grdRetain.Name = "grdRetain";
			this.grdRetain.ReadOnly = true;
			this.grdRetain.Size = new System.Drawing.Size(1168, 552);
			this.grdRetain.TabIndex = 9;
			this.grdRetain.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdRetainColumnAdded);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.btnExport);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.cmbMonth);
			this.groupBox1.Controls.Add(this.cmbYear);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1168, 207);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Retain report";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(17, 40);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(76, 24);
			this.radioButton1.TabIndex = 11;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Employee";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(590, 168);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(85, 35);
			this.btnExport.TabIndex = 9;
			this.btnExport.Text = "Export to Excel";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(460, 168);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 35);
			this.btnSubmit.TabIndex = 8;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(333, 168);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 35);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "Clear";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// cmbMonth
			// 
			this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMonth.FormattingEnabled = true;
			this.cmbMonth.Items.AddRange(new object[] {
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
			this.cmbMonth.Location = new System.Drawing.Point(592, 13);
			this.cmbMonth.Name = "cmbMonth";
			this.cmbMonth.Size = new System.Drawing.Size(121, 21);
			this.cmbMonth.TabIndex = 2;
			this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbMonthSelectedIndexChanged);
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
			this.cmbYear.Location = new System.Drawing.Point(367, 13);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 21);
			this.cmbYear.TabIndex = 1;
			this.cmbYear.SelectedValueChanged += new System.EventHandler(this.CmbYearSelectedValueChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(507, 41);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(87, 24);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Engagement";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(319, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Year:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(516, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "From month:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbSIC);
			this.groupBox3.Controls.Add(this.cmbSM_MIC);
			this.groupBox3.Controls.Add(this.label32);
			this.groupBox3.Controls.Add(this.label31);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.cmbEngCode);
			this.groupBox3.Controls.Add(this.cmbEngName);
			this.groupBox3.Location = new System.Drawing.Point(502, 48);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(488, 114);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			// 
			// cmbSIC
			// 
			this.cmbSIC.FormattingEnabled = true;
			this.cmbSIC.Location = new System.Drawing.Point(343, 31);
			this.cmbSIC.Name = "cmbSIC";
			this.cmbSIC.Size = new System.Drawing.Size(139, 21);
			this.cmbSIC.TabIndex = 76;
			// 
			// cmbSM_MIC
			// 
			this.cmbSM_MIC.FormattingEnabled = true;
			this.cmbSM_MIC.Location = new System.Drawing.Point(108, 31);
			this.cmbSM_MIC.Name = "cmbSM_MIC";
			this.cmbSM_MIC.Size = new System.Drawing.Size(138, 21);
			this.cmbSM_MIC.TabIndex = 75;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(278, 34);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(62, 23);
			this.label32.TabIndex = 78;
			this.label32.Text = "ITRA SIC:";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(7, 34);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(101, 23);
			this.label31.TabIndex = 77;
			this.label31.Text = "ITRA SM/MIC:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Engagment Code:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 23);
			this.label7.TabIndex = 5;
			this.label7.Text = "Engagement Name:";
			// 
			// cmbEngCode
			// 
			this.cmbEngCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngCode.FormattingEnabled = true;
			this.cmbEngCode.Location = new System.Drawing.Point(127, 88);
			this.cmbEngCode.Name = "cmbEngCode";
			this.cmbEngCode.Size = new System.Drawing.Size(223, 21);
			this.cmbEngCode.TabIndex = 7;
			this.cmbEngCode.SelectedIndexChanged += new System.EventHandler(this.CmbEngCodeSelectedIndexChanged);
			// 
			// cmbEngName
			// 
			this.cmbEngName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngName.FormattingEnabled = true;
			this.cmbEngName.Location = new System.Drawing.Point(127, 62);
			this.cmbEngName.Name = "cmbEngName";
			this.cmbEngName.Size = new System.Drawing.Size(342, 21);
			this.cmbEngName.TabIndex = 6;
			this.cmbEngName.SelectedIndexChanged += new System.EventHandler(this.CmbEngNameSelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.radDetail);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.cmbName);
			this.groupBox2.Controls.Add(this.radGeneral);
			this.groupBox2.Location = new System.Drawing.Point(11, 47);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(477, 115);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Employee Name:";
			// 
			// radDetail
			// 
			this.radDetail.Checked = true;
			this.radDetail.Location = new System.Drawing.Point(203, 47);
			this.radDetail.Name = "radDetail";
			this.radDetail.Size = new System.Drawing.Size(104, 24);
			this.radDetail.TabIndex = 5;
			this.radDetail.TabStop = true;
			this.radDetail.Text = "Detail";
			this.radDetail.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 22);
			this.label5.TabIndex = 7;
			this.label5.Text = "Type of Report:";
			// 
			// cmbName
			// 
			this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName.FormattingEnabled = true;
			this.cmbName.Location = new System.Drawing.Point(127, 19);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(223, 21);
			this.cmbName.TabIndex = 3;
			// 
			// radGeneral
			// 
			this.radGeneral.Location = new System.Drawing.Point(127, 47);
			this.radGeneral.Name = "radGeneral";
			this.radGeneral.Size = new System.Drawing.Size(104, 24);
			this.radGeneral.TabIndex = 4;
			this.radGeneral.Text = "General";
			this.radGeneral.UseVisualStyleBackColor = true;
			// 
			// frmRetainReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmRetainReport";
			this.Text = "frmRetainReport";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdRetain)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.ComboBox cmbSM_MIC;
		private System.Windows.Forms.ComboBox cmbSIC;
		private System.Windows.Forms.ComboBox cmbEngCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbEngName;
		private System.Windows.Forms.Label label7;
		
		private System.Windows.Forms.GroupBox groupBox3;
		
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.DataGridView grdTemp1;
		private System.Windows.Forms.DataGridView grdRetain;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radGeneral;
		private System.Windows.Forms.RadioButton radDetail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.ComboBox cmbMonth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbName;
		private System.Windows.Forms.Panel mainPanel;
		
		
		
		
	}
}
