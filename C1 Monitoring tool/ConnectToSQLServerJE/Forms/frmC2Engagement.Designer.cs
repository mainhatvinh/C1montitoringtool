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
	partial class frmC2Engagement
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtEngCode = new System.Windows.Forms.TextBox();
			this.txtFee = new System.Windows.Forms.TextBox();
			this.txtPlannedERP = new System.Windows.Forms.TextBox();
			this.txtEngName = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpClientYE = new System.Windows.Forms.DateTimePicker();
			this.chlC2SOW = new System.Windows.Forms.CheckedListBox();
			this.label37 = new System.Windows.Forms.Label();
			this.txtCollection = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.txtBilling = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.dtpCloseDate = new System.Windows.Forms.DateTimePicker();
			this.txtWorkComplete = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDetailSOW = new System.Windows.Forms.TextBox();
			this.cmbSIC = new System.Windows.Forms.ComboBox();
			this.cmbSM_MIC = new System.Windows.Forms.ComboBox();
			this.txtPIC = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label30 = new System.Windows.Forms.Label();
			this.cmbFYYear = new System.Windows.Forms.ComboBox();
			this.cmbClientName = new System.Windows.Forms.ComboBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.cmbRevenueSource = new System.Windows.Forms.ComboBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.chlIndustry = new System.Windows.Forms.CheckedListBox();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
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
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(550, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "EY Fiscal Year (*):";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(550, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Engagement Code:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 32);
			this.label4.TabIndex = 5;
			this.label4.Text = "Engagement Name (*):";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Client Name (*):";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(550, 170);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "Details SOW:";
			this.label10.Click += new System.EventHandler(this.Label10Click);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(810, 132);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(157, 23);
			this.label11.TabIndex = 12;
			this.label11.Text = "Contract Fee w/o VAT:";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(550, 133);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(99, 23);
			this.label12.TabIndex = 13;
			this.label12.Text = "Planned ERP (%): ";
			// 
			// txtEngCode
			// 
			this.txtEngCode.Location = new System.Drawing.Point(662, 60);
			this.txtEngCode.Name = "txtEngCode";
			this.txtEngCode.Size = new System.Drawing.Size(136, 20);
			this.txtEngCode.TabIndex = 5;
			// 
			// txtFee
			// 
			this.txtFee.Location = new System.Drawing.Point(931, 129);
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(139, 20);
			this.txtFee.TabIndex = 14;
			// 
			// txtPlannedERP
			// 
			this.txtPlannedERP.Location = new System.Drawing.Point(662, 129);
			this.txtPlannedERP.Name = "txtPlannedERP";
			this.txtPlannedERP.Size = new System.Drawing.Size(136, 20);
			this.txtPlannedERP.TabIndex = 13;
			// 
			// txtEngName
			// 
			this.txtEngName.Location = new System.Drawing.Point(118, 60);
			this.txtEngName.Multiline = true;
			this.txtEngName.Name = "txtEngName";
			this.txtEngName.Size = new System.Drawing.Size(406, 20);
			this.txtEngName.TabIndex = 4;
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
			this.label26.Location = new System.Drawing.Point(10, 303);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(102, 23);
			this.label26.TabIndex = 53;
			this.label26.Text = "Fieldwork Location:";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(118, 300);
			this.txtLocation.Multiline = true;
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(406, 43);
			this.txtLocation.TabIndex = 20;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpClientYE);
			this.groupBox1.Controls.Add(this.chlC2SOW);
			this.groupBox1.Controls.Add(this.label37);
			this.groupBox1.Controls.Add(this.txtCollection);
			this.groupBox1.Controls.Add(this.label36);
			this.groupBox1.Controls.Add(this.label35);
			this.groupBox1.Controls.Add(this.txtBilling);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Controls.Add(this.dtpCloseDate);
			this.groupBox1.Controls.Add(this.txtWorkComplete);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtDetailSOW);
			this.groupBox1.Controls.Add(this.cmbSIC);
			this.groupBox1.Controls.Add(this.cmbSM_MIC);
			this.groupBox1.Controls.Add(this.txtPIC);
			this.groupBox1.Controls.Add(this.label33);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.cmbStatus);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.cmbFYYear);
			this.groupBox1.Controls.Add(this.cmbClientName);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.cmbRevenueSource);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.chlIndustry);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtLocation);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.txtEngName);
			this.groupBox1.Controls.Add(this.txtPlannedERP);
			this.groupBox1.Controls.Add(this.txtFee);
			this.groupBox1.Controls.Add(this.txtEngCode);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(61, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1083, 413);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "C2 Engagement";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// dtpClientYE
			// 
			this.dtpClientYE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpClientYE.Location = new System.Drawing.Point(933, 22);
			this.dtpClientYE.Name = "dtpClientYE";
			this.dtpClientYE.Size = new System.Drawing.Size(137, 20);
			this.dtpClientYE.TabIndex = 3;
			// 
			// chlC2SOW
			// 
			this.chlC2SOW.CheckOnClick = true;
			this.chlC2SOW.FormattingEnabled = true;
			this.chlC2SOW.Location = new System.Drawing.Point(368, 129);
			this.chlC2SOW.Name = "chlC2SOW";
			this.chlC2SOW.Size = new System.Drawing.Size(156, 109);
			this.chlC2SOW.TabIndex = 12;
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(861, 63);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(53, 23);
			this.label37.TabIndex = 83;
			this.label37.Text = "Status:";
			// 
			// txtCollection
			// 
			this.txtCollection.Location = new System.Drawing.Point(662, 260);
			this.txtCollection.Name = "txtCollection";
			this.txtCollection.Size = new System.Drawing.Size(136, 20);
			this.txtCollection.TabIndex = 18;
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(550, 265);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(77, 15);
			this.label36.TabIndex = 81;
			this.label36.Text = "Collected:";
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(844, 264);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(65, 16);
			this.label35.TabIndex = 80;
			this.label35.Text = "Close Date:";
			// 
			// txtBilling
			// 
			this.txtBilling.Location = new System.Drawing.Point(368, 261);
			this.txtBilling.Name = "txtBilling";
			this.txtBilling.Size = new System.Drawing.Size(156, 20);
			this.txtBilling.TabIndex = 17;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(289, 265);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(65, 16);
			this.label34.TabIndex = 78;
			this.label34.Text = "Billed:";
			// 
			// dtpCloseDate
			// 
			this.dtpCloseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCloseDate.Location = new System.Drawing.Point(931, 261);
			this.dtpCloseDate.Name = "dtpCloseDate";
			this.dtpCloseDate.Size = new System.Drawing.Size(138, 20);
			this.dtpCloseDate.TabIndex = 19;
			// 
			// txtWorkComplete
			// 
			this.txtWorkComplete.Location = new System.Drawing.Point(118, 261);
			this.txtWorkComplete.Name = "txtWorkComplete";
			this.txtWorkComplete.Size = new System.Drawing.Size(147, 20);
			this.txtWorkComplete.TabIndex = 16;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(10, 264);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(112, 17);
			this.label18.TabIndex = 76;
			this.label18.Text = "WIP:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(290, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 38);
			this.label6.TabIndex = 73;
			this.label6.Text = "Scope of Work:";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// txtDetailSOW
			// 
			this.txtDetailSOW.Location = new System.Drawing.Point(662, 167);
			this.txtDetailSOW.Multiline = true;
			this.txtDetailSOW.Name = "txtDetailSOW";
			this.txtDetailSOW.Size = new System.Drawing.Size(408, 72);
			this.txtDetailSOW.TabIndex = 15;
			// 
			// cmbSIC
			// 
			this.cmbSIC.FormattingEnabled = true;
			this.cmbSIC.Location = new System.Drawing.Point(865, 94);
			this.cmbSIC.Name = "cmbSIC";
			this.cmbSIC.Size = new System.Drawing.Size(205, 21);
			this.cmbSIC.TabIndex = 9;
			// 
			// cmbSM_MIC
			// 
			this.cmbSM_MIC.FormattingEnabled = true;
			this.cmbSM_MIC.Location = new System.Drawing.Point(521, 94);
			this.cmbSM_MIC.Name = "cmbSM_MIC";
			this.cmbSM_MIC.Size = new System.Drawing.Size(185, 21);
			this.cmbSM_MIC.TabIndex = 8;
			// 
			// txtPIC
			// 
			this.txtPIC.Location = new System.Drawing.Point(118, 95);
			this.txtPIC.Name = "txtPIC";
			this.txtPIC.Size = new System.Drawing.Size(208, 20);
			this.txtPIC.TabIndex = 7;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(10, 98);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(100, 23);
			this.label33.TabIndex = 71;
			this.label33.Text = "PIC:";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(778, 98);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(62, 23);
			this.label32.TabIndex = 70;
			this.label32.Text = "ITRA SIC:";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(400, 98);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(100, 23);
			this.label31.TabIndex = 68;
			this.label31.Text = "ITRA SM/MIC:";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
									"Open",
									"On-going",
									"Close",
									"N/A"});
			this.cmbStatus.Location = new System.Drawing.Point(933, 60);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(137, 21);
			this.cmbStatus.TabIndex = 6;
			this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbEngTypeSelectedIndexChanged);
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(861, 25);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(65, 16);
			this.label30.TabIndex = 66;
			this.label30.Text = "Start Date:";
			// 
			// cmbFYYear
			// 
			this.cmbFYYear.FormattingEnabled = true;
			this.cmbFYYear.Items.AddRange(new object[] {
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
			this.cmbFYYear.Location = new System.Drawing.Point(662, 22);
			this.cmbFYYear.Name = "cmbFYYear";
			this.cmbFYYear.Size = new System.Drawing.Size(136, 21);
			this.cmbFYYear.TabIndex = 2;
			// 
			// cmbClientName
			// 
			this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClientName.FormattingEnabled = true;
			this.cmbClientName.Location = new System.Drawing.Point(118, 22);
			this.cmbClientName.Name = "cmbClientName";
			this.cmbClientName.Size = new System.Drawing.Size(406, 21);
			this.cmbClientName.TabIndex = 1;
			this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.CmbClientNameSelectedIndexChanged);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDel.Location = new System.Drawing.Point(621, 365);
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
			this.cmbRevenueSource.Location = new System.Drawing.Point(118, 129);
			this.cmbRevenueSource.Name = "cmbRevenueSource";
			this.cmbRevenueSource.Size = new System.Drawing.Size(147, 21);
			this.cmbRevenueSource.TabIndex = 10;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSubmit.Location = new System.Drawing.Point(487, 365);
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
			this.btnReset.Location = new System.Drawing.Point(349, 365);
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
			this.chlIndustry.Location = new System.Drawing.Point(118, 161);
			this.chlIndustry.Name = "chlIndustry";
			this.chlIndustry.Size = new System.Drawing.Size(147, 79);
			this.chlIndustry.TabIndex = 11;
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(662, 303);
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(408, 40);
			this.txtRemark.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(550, 303);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(115, 23);
			this.label13.TabIndex = 58;
			this.label13.Text = "Remark:";
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
			// frmC2Engagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 778);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmC2Engagement";
			this.Text = "Engagement";
			this.Load += new System.EventHandler(this.FrmC2EngagementLoad);
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
		private System.Windows.Forms.CheckedListBox chlC2SOW;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtWorkComplete;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox txtBilling;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.TextBox txtCollection;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDetailSOW;
		private System.Windows.Forms.DateTimePicker dtpCloseDate;
		private System.Windows.Forms.DataGridView grdITRAMembers;
		private System.Windows.Forms.DataGridView grdWorkStatus;
		private System.Windows.Forms.ComboBox cmbSM_MIC;
		private System.Windows.Forms.ComboBox cmbSIC;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox txtPIC;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.ComboBox cmbSearch;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.ComboBox cmbFYYear;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ComboBox cmbClientName;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbRevenueSource;
		private System.Windows.Forms.CheckedListBox chlIndustry;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtEngID;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.DataGridView grdEngagement;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.TextBox txtEngCode;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.TextBox txtPlannedERP;
		private System.Windows.Forms.TextBox txtEngName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		
		void Label10Click(object sender, System.EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, System.EventArgs e)
		{
			
		}
		
		void GroupBox1Enter(object sender, System.EventArgs e)
		{
			
		}
	}
}
