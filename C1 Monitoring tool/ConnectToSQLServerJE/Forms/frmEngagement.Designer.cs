/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/17/2013
 * Time: 2:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmEngagement
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.txtFeedback = new System.Windows.Forms.TextBox();
			this.cmbEagle = new System.Windows.Forms.ComboBox();
			this.cmbAQR = new System.Windows.Forms.ComboBox();
			this.txtEngCode = new System.Windows.Forms.TextBox();
			this.txtITRAFee = new System.Windows.Forms.TextBox();
			this.txtPlannedERP = new System.Windows.Forms.TextBox();
			this.txtEngName = new System.Windows.Forms.TextBox();
			this.txtAuditHours = new System.Windows.Forms.TextBox();
			this.txtFASSIC = new System.Windows.Forms.TextBox();
			this.chlSOW = new System.Windows.Forms.CheckedListBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpClientYE = new System.Windows.Forms.DateTimePicker();
			this.cmbSIC = new System.Windows.Forms.ComboBox();
			this.cmbSM_MIC = new System.Windows.Forms.ComboBox();
			this.txtFASMIC = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.txtPrevActualERP = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.cmbClientName = new System.Windows.Forms.ComboBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.cmbRevenueSource = new System.Windows.Forms.ComboBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.chlIndustry = new System.Windows.Forms.CheckedListBox();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbEngType = new System.Windows.Forms.ComboBox();
			this.dtpML = new System.Windows.Forms.DateTimePicker();
			this.dtpFSDate = new System.Windows.Forms.DateTimePicker();
			this.datFieldwork = new System.Windows.Forms.DateTimePicker();
			this.txtEngID = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.grdEngagement = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.grdITRAMembers = new System.Windows.Forms.DataGridView();
			this.grdWorkStatus = new System.Windows.Forms.DataGridView();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.label28 = new System.Windows.Forms.Label();
			this.cmbSearch = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdEngagement)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdITRAMembers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdWorkStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type (*):";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(315, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "EY Fiscal Year (*):";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(829, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Engagement Code:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(564, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Engagement Name (*):";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Client Name (*):";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(314, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "FAS SIC:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(84, 595);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 23);
			this.label7.TabIndex = 99;
			this.label7.Text = "Audit hours:";
			this.label7.Visible = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(564, 205);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 16);
			this.label9.TabIndex = 10;
			this.label9.Text = "FS targeted released date:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(313, 133);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "Scope Of Work:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(781, 132);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(143, 23);
			this.label11.TabIndex = 12;
			this.label11.Text = "ITRA Agreed Fee (in VND):";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(564, 168);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(99, 23);
			this.label12.TabIndex = 13;
			this.label12.Text = "Planned ERP (%): ";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(87, 642);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 99;
			this.label14.Text = " Selected for AQR?";
			this.label14.Visible = false;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(83, 534);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(171, 17);
			this.label15.TabIndex = 99;
			this.label15.Text = "ITRA Fieldwork starting date:";
			this.label15.Visible = false;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(829, 204);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(173, 17);
			this.label20.TabIndex = 21;
			this.label20.Text = "IT ML targeted released date:";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(564, 133);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(122, 23);
			this.label21.TabIndex = 22;
			this.label21.Text = "Selected for EY Eagle?";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(85, 686);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(115, 23);
			this.label22.TabIndex = 99;
			this.label22.Text = "Feedback for Eagle:";
			this.label22.Visible = false;
			// 
			// txtFeedback
			// 
			this.txtFeedback.Location = new System.Drawing.Point(206, 682);
			this.txtFeedback.Multiline = true;
			this.txtFeedback.Name = "txtFeedback";
			this.txtFeedback.Size = new System.Drawing.Size(181, 61);
			this.txtFeedback.TabIndex = 99;
			this.txtFeedback.Visible = false;
			// 
			// cmbEagle
			// 
			this.cmbEagle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEagle.FormattingEnabled = true;
			this.cmbEagle.Items.AddRange(new object[] {
									"N/A",
									"Yes",
									"No"});
			this.cmbEagle.Location = new System.Drawing.Point(701, 129);
			this.cmbEagle.Name = "cmbEagle";
			this.cmbEagle.Size = new System.Drawing.Size(46, 21);
			this.cmbEagle.TabIndex = 14;
			// 
			// cmbAQR
			// 
			this.cmbAQR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAQR.FormattingEnabled = true;
			this.cmbAQR.Items.AddRange(new object[] {
									"N/A",
									"Yes",
									"No"});
			this.cmbAQR.Location = new System.Drawing.Point(227, 639);
			this.cmbAQR.Name = "cmbAQR";
			this.cmbAQR.Size = new System.Drawing.Size(46, 21);
			this.cmbAQR.TabIndex = 99;
			this.cmbAQR.Visible = false;
			// 
			// txtEngCode
			// 
			this.txtEngCode.Location = new System.Drawing.Point(928, 21);
			this.txtEngCode.Name = "txtEngCode";
			this.txtEngCode.Size = new System.Drawing.Size(140, 20);
			this.txtEngCode.TabIndex = 4;
			// 
			// txtITRAFee
			// 
			this.txtITRAFee.Location = new System.Drawing.Point(926, 129);
			this.txtITRAFee.Name = "txtITRAFee";
			this.txtITRAFee.Size = new System.Drawing.Size(139, 20);
			this.txtITRAFee.TabIndex = 15;
			// 
			// txtPlannedERP
			// 
			this.txtPlannedERP.Location = new System.Drawing.Point(701, 164);
			this.txtPlannedERP.Name = "txtPlannedERP";
			this.txtPlannedERP.Size = new System.Drawing.Size(92, 20);
			this.txtPlannedERP.TabIndex = 16;
			// 
			// txtEngName
			// 
			this.txtEngName.Location = new System.Drawing.Point(701, 54);
			this.txtEngName.Multiline = true;
			this.txtEngName.Name = "txtEngName";
			this.txtEngName.Size = new System.Drawing.Size(366, 23);
			this.txtEngName.TabIndex = 6;
			// 
			// txtAuditHours
			// 
			this.txtAuditHours.Location = new System.Drawing.Point(189, 590);
			this.txtAuditHours.Name = "txtAuditHours";
			this.txtAuditHours.Size = new System.Drawing.Size(129, 20);
			this.txtAuditHours.TabIndex = 99;
			this.txtAuditHours.Visible = false;
			// 
			// txtFASSIC
			// 
			this.txtFASSIC.Location = new System.Drawing.Point(418, 95);
			this.txtFASSIC.Name = "txtFASSIC";
			this.txtFASSIC.Size = new System.Drawing.Size(129, 20);
			this.txtFASSIC.TabIndex = 8;
			// 
			// chlSOW
			// 
			this.chlSOW.CheckOnClick = true;
			this.chlSOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chlSOW.FormattingEnabled = true;
			this.chlSOW.Items.AddRange(new object[] {
									"IT Complexity",
									"ML Follow Up",
									"JE Testing",
									"ITGCs",
									"Application Controls",
									"EAE",
									"Data Migration",
									"BPR",
									"SOX"});
			this.chlSOW.Location = new System.Drawing.Point(402, 132);
			this.chlSOW.Name = "chlSOW";
			this.chlSOW.Size = new System.Drawing.Size(145, 108);
			this.chlSOW.TabIndex = 13;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(10, 167);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(115, 23);
			this.label25.TabIndex = 51;
			this.label25.Text = "Business Industry:";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(10, 256);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(102, 23);
			this.label26.TabIndex = 53;
			this.label26.Text = "Fieldwork Location:";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(154, 256);
			this.txtLocation.Multiline = true;
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(393, 72);
			this.txtLocation.TabIndex = 20;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpClientYE);
			this.groupBox1.Controls.Add(this.cmbSIC);
			this.groupBox1.Controls.Add(this.cmbSM_MIC);
			this.groupBox1.Controls.Add(this.txtFASMIC);
			this.groupBox1.Controls.Add(this.label33);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.txtPrevActualERP);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.cmbYear);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.cmbClientName);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.cmbRevenueSource);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.chlIndustry);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.cmbEngType);
			this.groupBox1.Controls.Add(this.dtpML);
			this.groupBox1.Controls.Add(this.chlSOW);
			this.groupBox1.Controls.Add(this.dtpFSDate);
			this.groupBox1.Controls.Add(this.txtLocation);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.txtFASSIC);
			this.groupBox1.Controls.Add(this.txtEngName);
			this.groupBox1.Controls.Add(this.txtPlannedERP);
			this.groupBox1.Controls.Add(this.txtITRAFee);
			this.groupBox1.Controls.Add(this.txtEngCode);
			this.groupBox1.Controls.Add(this.cmbEagle);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(61, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1083, 413);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Engagement";
			// 
			// dtpClientYE
			// 
			this.dtpClientYE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpClientYE.Location = new System.Drawing.Point(701, 20);
			this.dtpClientYE.Name = "dtpClientYE";
			this.dtpClientYE.Size = new System.Drawing.Size(92, 20);
			this.dtpClientYE.TabIndex = 3;
			// 
			// cmbSIC
			// 
			this.cmbSIC.FormattingEnabled = true;
			this.cmbSIC.Location = new System.Drawing.Point(926, 94);
			this.cmbSIC.Name = "cmbSIC";
			this.cmbSIC.Size = new System.Drawing.Size(139, 21);
			this.cmbSIC.TabIndex = 10;
			// 
			// cmbSM_MIC
			// 
			this.cmbSM_MIC.FormattingEnabled = true;
			this.cmbSM_MIC.Location = new System.Drawing.Point(701, 94);
			this.cmbSM_MIC.Name = "cmbSM_MIC";
			this.cmbSM_MIC.Size = new System.Drawing.Size(138, 21);
			this.cmbSM_MIC.TabIndex = 9;
			// 
			// txtFASMIC
			// 
			this.txtFASMIC.Location = new System.Drawing.Point(154, 95);
			this.txtFASMIC.Name = "txtFASMIC";
			this.txtFASMIC.Size = new System.Drawing.Size(147, 20);
			this.txtFASMIC.TabIndex = 7;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(10, 98);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(100, 23);
			this.label33.TabIndex = 71;
			this.label33.Text = "FAS MIC:";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(861, 98);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(62, 23);
			this.label32.TabIndex = 70;
			this.label32.Text = "ITRA SIC:";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(564, 98);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(101, 23);
			this.label31.TabIndex = 68;
			this.label31.Text = "ITRA SM/MIC:";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(564, 24);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(136, 16);
			this.label30.TabIndex = 66;
			this.label30.Text = "Client\'s Financial YE (*):";
			// 
			// txtPrevActualERP
			// 
			this.txtPrevActualERP.Location = new System.Drawing.Point(966, 163);
			this.txtPrevActualERP.Name = "txtPrevActualERP";
			this.txtPrevActualERP.Size = new System.Drawing.Size(99, 20);
			this.txtPrevActualERP.TabIndex = 17;
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(829, 167);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(135, 23);
			this.label29.TabIndex = 65;
			this.label29.Text = "Previous Actual ERP (%):";
			// 
			// cmbYear
			// 
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
			this.cmbYear.Location = new System.Drawing.Point(418, 21);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(129, 21);
			this.cmbYear.TabIndex = 2;
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(564, 228);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(100, 16);
			this.label23.TabIndex = 63;
			this.label23.Text = "(mm/dd/yyyy)";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(829, 227);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 17);
			this.label19.TabIndex = 62;
			this.label19.Text = "(mm/dd/yyyy)";
			// 
			// cmbClientName
			// 
			this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClientName.FormattingEnabled = true;
			this.cmbClientName.Location = new System.Drawing.Point(154, 56);
			this.cmbClientName.Name = "cmbClientName";
			this.cmbClientName.Size = new System.Drawing.Size(393, 21);
			this.cmbClientName.TabIndex = 5;
			this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.CmbClientNameSelectedIndexChanged);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDel.Location = new System.Drawing.Point(621, 351);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 35);
			this.btnDel.TabIndex = 24;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// cmbRevenueSource
			// 
			this.cmbRevenueSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRevenueSource.FormattingEnabled = true;
			this.cmbRevenueSource.Items.AddRange(new object[] {
									"Hanoi",
									"HCM",
									"Laos",
									"Cambodia",
									"Others"});
			this.cmbRevenueSource.Location = new System.Drawing.Point(154, 129);
			this.cmbRevenueSource.Name = "cmbRevenueSource";
			this.cmbRevenueSource.Size = new System.Drawing.Size(147, 21);
			this.cmbRevenueSource.TabIndex = 11;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSubmit.Location = new System.Drawing.Point(487, 351);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 35);
			this.btnSubmit.TabIndex = 23;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(10, 132);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(102, 23);
			this.label16.TabIndex = 61;
			this.label16.Text = "Revenue Source (*)";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnReset.Location = new System.Drawing.Point(349, 351);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 35);
			this.btnReset.TabIndex = 22;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// chlIndustry
			// 
			this.chlIndustry.CheckOnClick = true;
			this.chlIndustry.FormattingEnabled = true;
			this.chlIndustry.Location = new System.Drawing.Point(154, 159);
			this.chlIndustry.Name = "chlIndustry";
			this.chlIndustry.Size = new System.Drawing.Size(147, 79);
			this.chlIndustry.TabIndex = 12;
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(701, 256);
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(364, 72);
			this.txtRemark.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(564, 260);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(115, 23);
			this.label13.TabIndex = 58;
			this.label13.Text = "Remark:";
			// 
			// cmbEngType
			// 
			this.cmbEngType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngType.FormattingEnabled = true;
			this.cmbEngType.Items.AddRange(new object[] {
									"Channel 1",
									"Authorized Project",
									"Non-chargeable"});
			this.cmbEngType.Location = new System.Drawing.Point(154, 22);
			this.cmbEngType.Name = "cmbEngType";
			this.cmbEngType.Size = new System.Drawing.Size(147, 21);
			this.cmbEngType.TabIndex = 1;
			this.cmbEngType.SelectedIndexChanged += new System.EventHandler(this.CmbEngTypeSelectedIndexChanged);
			// 
			// dtpML
			// 
			this.dtpML.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpML.Location = new System.Drawing.Point(973, 201);
			this.dtpML.Name = "dtpML";
			this.dtpML.Size = new System.Drawing.Size(92, 20);
			this.dtpML.TabIndex = 19;
			// 
			// dtpFSDate
			// 
			this.dtpFSDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFSDate.Location = new System.Drawing.Point(701, 201);
			this.dtpFSDate.Name = "dtpFSDate";
			this.dtpFSDate.Size = new System.Drawing.Size(92, 20);
			this.dtpFSDate.TabIndex = 18;
			// 
			// datFieldwork
			// 
			this.datFieldwork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datFieldwork.Location = new System.Drawing.Point(227, 529);
			this.datFieldwork.Name = "datFieldwork";
			this.datFieldwork.Size = new System.Drawing.Size(102, 20);
			this.datFieldwork.TabIndex = 99;
			this.datFieldwork.Visible = false;
			// 
			// txtEngID
			// 
			this.txtEngID.Location = new System.Drawing.Point(1027, 9);
			this.txtEngID.Name = "txtEngID";
			this.txtEngID.ReadOnly = true;
			this.txtEngID.Size = new System.Drawing.Size(100, 20);
			this.txtEngID.TabIndex = 55;
			this.txtEngID.Visible = false;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(902, 12);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(94, 23);
			this.label27.TabIndex = 54;
			this.label27.Text = "Engagement ID:";
			this.label27.Visible = false;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(61, 45);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(198, 23);
			this.label24.TabIndex = 60;
			this.label24.Text = "*: Fields with * are mandatory";
			// 
			// grdEngagement
			// 
			this.grdEngagement.AllowUserToAddRows = false;
			this.grdEngagement.AllowUserToDeleteRows = false;
			this.grdEngagement.AllowUserToOrderColumns = true;
			this.grdEngagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdEngagement.Location = new System.Drawing.Point(61, 488);
			this.grdEngagement.MultiSelect = false;
			this.grdEngagement.Name = "grdEngagement";
			this.grdEngagement.ReadOnly = true;
			this.grdEngagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdEngagement.Size = new System.Drawing.Size(1083, 269);
			this.grdEngagement.TabIndex = 25;
			this.grdEngagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientCellClick);
			this.grdEngagement.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdEngagementDataBindingComplete);
			this.grdEngagement.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GrdEngagementRowPostPaint);
			this.grdEngagement.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GrdEngagementRowsAdded);
			this.grdEngagement.SelectionChanged += new System.EventHandler(this.GrdEngagementSelectionChanged);
			this.grdEngagement.Sorted += new System.EventHandler(this.GrdEngagementSorted);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(61, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(659, 23);
			this.label8.TabIndex = 58;
			this.label8.Text = "Please fill in the following form to create a new engagement or update an existin" +
			"g engagement:";
			// 
			// mainPanel
			// 
			this.mainPanel.AutoScroll = true;
			this.mainPanel.Controls.Add(this.grdITRAMembers);
			this.mainPanel.Controls.Add(this.grdWorkStatus);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.label28);
			this.mainPanel.Controls.Add(this.cmbSearch);
			this.mainPanel.Controls.Add(this.label17);
			this.mainPanel.Controls.Add(this.txtSearch);
			this.mainPanel.Controls.Add(this.label24);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.label8);
			this.mainPanel.Controls.Add(this.label27);
			this.mainPanel.Controls.Add(this.txtEngID);
			this.mainPanel.Controls.Add(this.label22);
			this.mainPanel.Controls.Add(this.label7);
			this.mainPanel.Controls.Add(this.label14);
			this.mainPanel.Controls.Add(this.label15);
			this.mainPanel.Controls.Add(this.txtFeedback);
			this.mainPanel.Controls.Add(this.cmbAQR);
			this.mainPanel.Controls.Add(this.txtAuditHours);
			this.mainPanel.Controls.Add(this.datFieldwork);
			this.mainPanel.Controls.Add(this.grdEngagement);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 778);
			this.mainPanel.TabIndex = 1;
			// 
			// grdITRAMembers
			// 
			this.grdITRAMembers.AllowUserToAddRows = false;
			this.grdITRAMembers.AllowUserToDeleteRows = false;
			this.grdITRAMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdITRAMembers.Location = new System.Drawing.Point(498, 3);
			this.grdITRAMembers.Name = "grdITRAMembers";
			this.grdITRAMembers.ReadOnly = true;
			this.grdITRAMembers.Size = new System.Drawing.Size(30, 14);
			this.grdITRAMembers.TabIndex = 67;
			this.grdITRAMembers.Visible = false;
			// 
			// grdWorkStatus
			// 
			this.grdWorkStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWorkStatus.Location = new System.Drawing.Point(445, 3);
			this.grdWorkStatus.Name = "grdWorkStatus";
			this.grdWorkStatus.Size = new System.Drawing.Size(27, 14);
			this.grdWorkStatus.TabIndex = 66;
			this.grdWorkStatus.Visible = false;
			// 
			// grdTemp
			// 
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(396, 3);
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.Size = new System.Drawing.Size(19, 14);
			this.grdTemp.TabIndex = 65;
			this.grdTemp.Visible = false;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(965, 43);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(24, 23);
			this.label28.TabIndex = 64;
			this.label28.Text = "in";
			// 
			// cmbSearch
			// 
			this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearch.FormattingEnabled = true;
			this.cmbSearch.Items.AddRange(new object[] {
									"Engagement name",
									"Engagement code",
									"Engagement type",
									"Fiscal year",
									"Client name",
									"Revenue source",
									"SIC",
									"MIC"});
			this.cmbSearch.Location = new System.Drawing.Point(989, 40);
			this.cmbSearch.Name = "cmbSearch";
			this.cmbSearch.Size = new System.Drawing.Size(139, 21);
			this.cmbSearch.TabIndex = 63;
			this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearchSelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(708, 43);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 23);
			this.label17.TabIndex = 62;
			this.label17.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSearch.Location = new System.Drawing.Point(762, 41);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(194, 20);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// frmEngagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 778);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmEngagement";
			this.Text = "Engagement";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdEngagement)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdITRAMembers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdWorkStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DateTimePicker dtpClientYE;
		private System.Windows.Forms.DataGridView grdITRAMembers;
		private System.Windows.Forms.DataGridView grdWorkStatus;
		private System.Windows.Forms.ComboBox cmbSM_MIC;
		private System.Windows.Forms.ComboBox cmbSIC;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox txtFASMIC;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox txtPrevActualERP;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.ComboBox cmbSearch;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ComboBox cmbClientName;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbRevenueSource;
		private System.Windows.Forms.CheckedListBox chlIndustry;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.ComboBox cmbEngType;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtEngID;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.DataGridView grdEngagement;
		private System.Windows.Forms.DateTimePicker datFieldwork;
		private System.Windows.Forms.DateTimePicker dtpFSDate;
		private System.Windows.Forms.DateTimePicker dtpML;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.CheckedListBox chlSOW;
		private System.Windows.Forms.TextBox txtEngCode;
		private System.Windows.Forms.TextBox txtITRAFee;
		private System.Windows.Forms.TextBox txtPlannedERP;
		private System.Windows.Forms.TextBox txtEngName;
		private System.Windows.Forms.TextBox txtAuditHours;
		private System.Windows.Forms.TextBox txtFASSIC;
		private System.Windows.Forms.TextBox txtFeedback;
		private System.Windows.Forms.ComboBox cmbEagle;
		private System.Windows.Forms.ComboBox cmbAQR;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
