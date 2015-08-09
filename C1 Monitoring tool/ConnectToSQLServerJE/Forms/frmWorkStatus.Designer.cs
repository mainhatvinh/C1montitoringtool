/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 9:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmWorkStatus
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
			this.btnSubmit = new System.Windows.Forms.Button();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.txtEngCode = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpMLFollowUp = new System.Windows.Forms.DateTimePicker();
			this.label36 = new System.Windows.Forms.Label();
			this.cmbMLFollowUp = new System.Windows.Forms.ComboBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.dtpML = new System.Windows.Forms.DateTimePicker();
			this.label33 = new System.Windows.Forms.Label();
			this.dtpSRM = new System.Windows.Forms.DateTimePicker();
			this.label34 = new System.Windows.Forms.Label();
			this.dtpSOX = new System.Windows.Forms.DateTimePicker();
			this.label32 = new System.Windows.Forms.Label();
			this.dtpDataMigration = new System.Windows.Forms.DateTimePicker();
			this.label31 = new System.Windows.Forms.Label();
			this.dtpJE = new System.Windows.Forms.DateTimePicker();
			this.label30 = new System.Windows.Forms.Label();
			this.dtpEAE = new System.Windows.Forms.DateTimePicker();
			this.label29 = new System.Windows.Forms.Label();
			this.dtpAppCon = new System.Windows.Forms.DateTimePicker();
			this.label28 = new System.Windows.Forms.Label();
			this.dtpBPR = new System.Windows.Forms.DateTimePicker();
			this.label27 = new System.Windows.Forms.Label();
			this.dtpITGC = new System.Windows.Forms.DateTimePicker();
			this.label26 = new System.Windows.Forms.Label();
			this.dtpITCom = new System.Windows.Forms.DateTimePicker();
			this.label25 = new System.Windows.Forms.Label();
			this.cmbSOX = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.cmbComplexity = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbEAE = new System.Windows.Forms.ComboBox();
			this.cmbAppControl = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbBPR = new System.Windows.Forms.ComboBox();
			this.cmbAddendum = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbArchive = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbGamxDoc = new System.Windows.Forms.ComboBox();
			this.cmbDataMigration = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbYEupdate = new System.Windows.Forms.ComboBox();
			this.cmbJE = new System.Windows.Forms.ComboBox();
			this.cmbFASresult = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbSRM = new System.Windows.Forms.ComboBox();
			this.cmbIGTC = new System.Windows.Forms.ComboBox();
			this.cmbML = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbPlanningMemo = new System.Windows.Forms.ComboBox();
			this.cmbScope = new System.Windows.Forms.ComboBox();
			this.cmbFASmeeting = new System.Windows.Forms.ComboBox();
			this.cmbGamxStatus = new System.Windows.Forms.ComboBox();
			this.cmbEngName = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.cmbEngCode = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(435, 369);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 51);
			this.btnSubmit.TabIndex = 33;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.txtEngCode);
			this.mainPanel.Controls.Add(this.label35);
			this.mainPanel.Controls.Add(this.cmbYear);
			this.mainPanel.Controls.Add(this.label23);
			this.mainPanel.Controls.Add(this.label22);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.cmbEngName);
			this.mainPanel.Controls.Add(this.label21);
			this.mainPanel.Controls.Add(this.cmbEngCode);
			this.mainPanel.Controls.Add(this.label19);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 6;
			// 
			// txtEngCode
			// 
			this.txtEngCode.Location = new System.Drawing.Point(427, 147);
			this.txtEngCode.Name = "txtEngCode";
			this.txtEngCode.ReadOnly = true;
			this.txtEngCode.Size = new System.Drawing.Size(153, 20);
			this.txtEngCode.TabIndex = 48;
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(306, 79);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(110, 23);
			this.label35.TabIndex = 47;
			this.label35.Text = "EY Fiscal year:";
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
			this.cmbYear.Location = new System.Drawing.Point(427, 79);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 21);
			this.cmbYear.TabIndex = 46;
			this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYearSelectedIndexChanged);
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(125, 50);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(198, 23);
			this.label23.TabIndex = 45;
			this.label23.Text = "*: Fields with * are mandatory";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(125, 30);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(581, 24);
			this.label22.TabIndex = 44;
			this.label22.Text = "Please fill in the following form to update the specific engagement\'s work status" +
			":";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpMLFollowUp);
			this.groupBox1.Controls.Add(this.label36);
			this.groupBox1.Controls.Add(this.cmbMLFollowUp);
			this.groupBox1.Controls.Add(this.label37);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.dtpML);
			this.groupBox1.Controls.Add(this.label33);
			this.groupBox1.Controls.Add(this.dtpSRM);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.dtpSOX);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.dtpDataMigration);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.dtpJE);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.dtpEAE);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.dtpAppCon);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Controls.Add(this.dtpBPR);
			this.groupBox1.Controls.Add(this.label27);
			this.groupBox1.Controls.Add(this.dtpITGC);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.dtpITCom);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.cmbSOX);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.cmbComplexity);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbEAE);
			this.groupBox1.Controls.Add(this.cmbAppControl);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.cmbBPR);
			this.groupBox1.Controls.Add(this.cmbAddendum);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbArchive);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.cmbGamxDoc);
			this.groupBox1.Controls.Add(this.cmbDataMigration);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.cmbYEupdate);
			this.groupBox1.Controls.Add(this.cmbJE);
			this.groupBox1.Controls.Add(this.cmbFASresult);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cmbSRM);
			this.groupBox1.Controls.Add(this.cmbIGTC);
			this.groupBox1.Controls.Add(this.cmbML);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.cmbPlanningMemo);
			this.groupBox1.Controls.Add(this.cmbScope);
			this.groupBox1.Controls.Add(this.cmbFASmeeting);
			this.groupBox1.Controls.Add(this.cmbGamxStatus);
			this.groupBox1.Location = new System.Drawing.Point(125, 207);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 438);
			this.groupBox1.TabIndex = 43;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Work Status";
			// 
			// dtpMLFollowUp
			// 
			this.dtpMLFollowUp.Enabled = false;
			this.dtpMLFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpMLFollowUp.Location = new System.Drawing.Point(816, 51);
			this.dtpMLFollowUp.Name = "dtpMLFollowUp";
			this.dtpMLFollowUp.Size = new System.Drawing.Size(97, 20);
			this.dtpMLFollowUp.TabIndex = 61;
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(723, 51);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(100, 23);
			this.label36.TabIndex = 63;
			this.label36.Text = "Manager Review";
			// 
			// cmbMLFollowUp
			// 
			this.cmbMLFollowUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMLFollowUp.Enabled = false;
			this.cmbMLFollowUp.FormattingEnabled = true;
			this.cmbMLFollowUp.Location = new System.Drawing.Point(587, 49);
			this.cmbMLFollowUp.Name = "cmbMLFollowUp";
			this.cmbMLFollowUp.Size = new System.Drawing.Size(121, 21);
			this.cmbMLFollowUp.TabIndex = 60;
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(435, 51);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(146, 26);
			this.label37.TabIndex = 62;
			this.label37.Text = "ML Follow Up";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(723, 37);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(87, 13);
			this.label24.TabIndex = 23;
			this.label24.Text = "(mm/dd/yyyy)";
			// 
			// dtpML
			// 
			this.dtpML.Enabled = false;
			this.dtpML.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpML.Location = new System.Drawing.Point(816, 336);
			this.dtpML.Name = "dtpML";
			this.dtpML.Size = new System.Drawing.Size(97, 20);
			this.dtpML.TabIndex = 31;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(723, 339);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(100, 23);
			this.label33.TabIndex = 59;
			this.label33.Text = "Manager Review";
			// 
			// dtpSRM
			// 
			this.dtpSRM.Enabled = false;
			this.dtpSRM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpSRM.Location = new System.Drawing.Point(816, 301);
			this.dtpSRM.Name = "dtpSRM";
			this.dtpSRM.Size = new System.Drawing.Size(97, 20);
			this.dtpSRM.TabIndex = 29;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(723, 305);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(100, 23);
			this.label34.TabIndex = 58;
			this.label34.Text = "Manager Review";
			// 
			// dtpSOX
			// 
			this.dtpSOX.Enabled = false;
			this.dtpSOX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpSOX.Location = new System.Drawing.Point(816, 269);
			this.dtpSOX.Name = "dtpSOX";
			this.dtpSOX.Size = new System.Drawing.Size(97, 20);
			this.dtpSOX.TabIndex = 27;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(723, 273);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(100, 23);
			this.label32.TabIndex = 55;
			this.label32.Text = "Manager Review";
			// 
			// dtpDataMigration
			// 
			this.dtpDataMigration.Enabled = false;
			this.dtpDataMigration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataMigration.Location = new System.Drawing.Point(816, 233);
			this.dtpDataMigration.Name = "dtpDataMigration";
			this.dtpDataMigration.Size = new System.Drawing.Size(97, 20);
			this.dtpDataMigration.TabIndex = 25;
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(723, 239);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(100, 23);
			this.label31.TabIndex = 53;
			this.label31.Text = "Manager Review";
			// 
			// dtpJE
			// 
			this.dtpJE.Enabled = false;
			this.dtpJE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpJE.Location = new System.Drawing.Point(816, 202);
			this.dtpJE.Name = "dtpJE";
			this.dtpJE.Size = new System.Drawing.Size(97, 20);
			this.dtpJE.TabIndex = 23;
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(723, 207);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(100, 23);
			this.label30.TabIndex = 51;
			this.label30.Text = "Manager Review";
			// 
			// dtpEAE
			// 
			this.dtpEAE.Enabled = false;
			this.dtpEAE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEAE.Location = new System.Drawing.Point(816, 170);
			this.dtpEAE.Name = "dtpEAE";
			this.dtpEAE.Size = new System.Drawing.Size(97, 20);
			this.dtpEAE.TabIndex = 21;
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(723, 168);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(100, 23);
			this.label29.TabIndex = 49;
			this.label29.Text = "Manager Review";
			// 
			// dtpAppCon
			// 
			this.dtpAppCon.Enabled = false;
			this.dtpAppCon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpAppCon.Location = new System.Drawing.Point(816, 136);
			this.dtpAppCon.Name = "dtpAppCon";
			this.dtpAppCon.Size = new System.Drawing.Size(97, 20);
			this.dtpAppCon.TabIndex = 19;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(723, 138);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(100, 23);
			this.label28.TabIndex = 47;
			this.label28.Text = "Manager Review";
			// 
			// dtpBPR
			// 
			this.dtpBPR.Enabled = false;
			this.dtpBPR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBPR.Location = new System.Drawing.Point(816, 108);
			this.dtpBPR.Name = "dtpBPR";
			this.dtpBPR.Size = new System.Drawing.Size(97, 20);
			this.dtpBPR.TabIndex = 17;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(723, 110);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(100, 23);
			this.label27.TabIndex = 45;
			this.label27.Text = "Manager Review";
			// 
			// dtpITGC
			// 
			this.dtpITGC.Enabled = false;
			this.dtpITGC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpITGC.Location = new System.Drawing.Point(816, 78);
			this.dtpITGC.Name = "dtpITGC";
			this.dtpITGC.Size = new System.Drawing.Size(97, 20);
			this.dtpITGC.TabIndex = 15;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(723, 79);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 23);
			this.label26.TabIndex = 43;
			this.label26.Text = "Manager Review";
			// 
			// dtpITCom
			// 
			this.dtpITCom.Enabled = false;
			this.dtpITCom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpITCom.Location = new System.Drawing.Point(816, 23);
			this.dtpITCom.Name = "dtpITCom";
			this.dtpITCom.Size = new System.Drawing.Size(97, 20);
			this.dtpITCom.TabIndex = 13;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(723, 23);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(100, 23);
			this.label25.TabIndex = 41;
			this.label25.Text = "Manager Review";
			// 
			// cmbSOX
			// 
			this.cmbSOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSOX.Enabled = false;
			this.cmbSOX.FormattingEnabled = true;
			this.cmbSOX.Location = new System.Drawing.Point(587, 268);
			this.cmbSOX.Name = "cmbSOX";
			this.cmbSOX.Size = new System.Drawing.Size(121, 21);
			this.cmbSOX.TabIndex = 26;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(436, 271);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(43, 22);
			this.label20.TabIndex = 39;
			this.label20.Text = "SOX:";
			// 
			// cmbComplexity
			// 
			this.cmbComplexity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbComplexity.Enabled = false;
			this.cmbComplexity.FormattingEnabled = true;
			this.cmbComplexity.Location = new System.Drawing.Point(587, 19);
			this.cmbComplexity.Name = "cmbComplexity";
			this.cmbComplexity.Size = new System.Drawing.Size(121, 21);
			this.cmbComplexity.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(435, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 26);
			this.label1.TabIndex = 37;
			this.label1.Text = "IT Complexity Assessment:";
			// 
			// cmbEAE
			// 
			this.cmbEAE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEAE.Enabled = false;
			this.cmbEAE.FormattingEnabled = true;
			this.cmbEAE.Location = new System.Drawing.Point(587, 170);
			this.cmbEAE.Name = "cmbEAE";
			this.cmbEAE.Size = new System.Drawing.Size(121, 21);
			this.cmbEAE.TabIndex = 20;
			// 
			// cmbAppControl
			// 
			this.cmbAppControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAppControl.Enabled = false;
			this.cmbAppControl.FormattingEnabled = true;
			this.cmbAppControl.Location = new System.Drawing.Point(587, 140);
			this.cmbAppControl.Name = "cmbAppControl";
			this.cmbAppControl.Size = new System.Drawing.Size(121, 21);
			this.cmbAppControl.TabIndex = 18;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(435, 173);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(146, 24);
			this.label10.TabIndex = 8;
			this.label10.Text = "EAE Report Testing:";
			// 
			// cmbBPR
			// 
			this.cmbBPR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBPR.Enabled = false;
			this.cmbBPR.FormattingEnabled = true;
			this.cmbBPR.Location = new System.Drawing.Point(587, 110);
			this.cmbBPR.Name = "cmbBPR";
			this.cmbBPR.Size = new System.Drawing.Size(121, 21);
			this.cmbBPR.TabIndex = 16;
			// 
			// cmbAddendum
			// 
			this.cmbAddendum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAddendum.Enabled = false;
			this.cmbAddendum.FormattingEnabled = true;
			this.cmbAddendum.Location = new System.Drawing.Point(285, 146);
			this.cmbAddendum.Name = "cmbAddendum";
			this.cmbAddendum.Size = new System.Drawing.Size(121, 21);
			this.cmbAddendum.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Gamx Status:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Planning meeting with FAS:";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(30, 178);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(110, 24);
			this.label13.TabIndex = 11;
			this.label13.Text = "Year-end Update:";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(30, 244);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(143, 24);
			this.label17.TabIndex = 15;
			this.label17.Text = "Gamx Documentation:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(30, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Scoping agreed?:";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(30, 277);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(210, 44);
			this.label18.TabIndex = 16;
			this.label18.Text = "Ready for Archiving and informed FAS?: ";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(30, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(178, 24);
			this.label5.TabIndex = 3;
			this.label5.Text = "IT Planning Memo and Budget:";
			// 
			// cmbArchive
			// 
			this.cmbArchive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbArchive.Enabled = false;
			this.cmbArchive.FormattingEnabled = true;
			this.cmbArchive.Location = new System.Drawing.Point(285, 278);
			this.cmbArchive.Name = "cmbArchive";
			this.cmbArchive.Size = new System.Drawing.Size(121, 21);
			this.cmbArchive.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(30, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(257, 24);
			this.label6.TabIndex = 4;
			this.label6.Text = "IT Planning Memo and Budget Addendum (if any):";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(30, 213);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(156, 24);
			this.label16.TabIndex = 14;
			this.label16.Text = "Results discussed with FAS:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(435, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 24);
			this.label7.TabIndex = 5;
			this.label7.Text = "ITGCs:";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(435, 337);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110, 24);
			this.label15.TabIndex = 13;
			this.label15.Text = "ML:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(435, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 24);
			this.label8.TabIndex = 6;
			this.label8.Text = "BPR:";
			// 
			// cmbGamxDoc
			// 
			this.cmbGamxDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGamxDoc.Enabled = false;
			this.cmbGamxDoc.FormattingEnabled = true;
			this.cmbGamxDoc.Location = new System.Drawing.Point(285, 244);
			this.cmbGamxDoc.Name = "cmbGamxDoc";
			this.cmbGamxDoc.Size = new System.Drawing.Size(121, 21);
			this.cmbGamxDoc.TabIndex = 10;
			// 
			// cmbDataMigration
			// 
			this.cmbDataMigration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDataMigration.Enabled = false;
			this.cmbDataMigration.FormattingEnabled = true;
			this.cmbDataMigration.Location = new System.Drawing.Point(587, 237);
			this.cmbDataMigration.Name = "cmbDataMigration";
			this.cmbDataMigration.Size = new System.Drawing.Size(121, 21);
			this.cmbDataMigration.TabIndex = 24;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(435, 304);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(110, 24);
			this.label14.TabIndex = 12;
			this.label14.Text = "SRM:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(435, 239);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 24);
			this.label9.TabIndex = 7;
			this.label9.Text = "Data Migration:";
			// 
			// cmbYEupdate
			// 
			this.cmbYEupdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbYEupdate.Enabled = false;
			this.cmbYEupdate.FormattingEnabled = true;
			this.cmbYEupdate.Location = new System.Drawing.Point(285, 178);
			this.cmbYEupdate.Name = "cmbYEupdate";
			this.cmbYEupdate.Size = new System.Drawing.Size(121, 21);
			this.cmbYEupdate.TabIndex = 8;
			// 
			// cmbJE
			// 
			this.cmbJE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbJE.Enabled = false;
			this.cmbJE.FormattingEnabled = true;
			this.cmbJE.Location = new System.Drawing.Point(587, 205);
			this.cmbJE.Name = "cmbJE";
			this.cmbJE.Size = new System.Drawing.Size(121, 21);
			this.cmbJE.TabIndex = 22;
			// 
			// cmbFASresult
			// 
			this.cmbFASresult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFASresult.Enabled = false;
			this.cmbFASresult.FormattingEnabled = true;
			this.cmbFASresult.Location = new System.Drawing.Point(285, 210);
			this.cmbFASresult.Name = "cmbFASresult";
			this.cmbFASresult.Size = new System.Drawing.Size(121, 21);
			this.cmbFASresult.TabIndex = 9;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(435, 143);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(146, 24);
			this.label11.TabIndex = 9;
			this.label11.Text = "Application Controls Testing:";
			// 
			// cmbSRM
			// 
			this.cmbSRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSRM.Enabled = false;
			this.cmbSRM.FormattingEnabled = true;
			this.cmbSRM.Location = new System.Drawing.Point(587, 302);
			this.cmbSRM.Name = "cmbSRM";
			this.cmbSRM.Size = new System.Drawing.Size(121, 21);
			this.cmbSRM.TabIndex = 28;
			// 
			// cmbIGTC
			// 
			this.cmbIGTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbIGTC.Enabled = false;
			this.cmbIGTC.FormattingEnabled = true;
			this.cmbIGTC.Location = new System.Drawing.Point(587, 80);
			this.cmbIGTC.Name = "cmbIGTC";
			this.cmbIGTC.Size = new System.Drawing.Size(121, 21);
			this.cmbIGTC.TabIndex = 14;
			// 
			// cmbML
			// 
			this.cmbML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbML.Enabled = false;
			this.cmbML.FormattingEnabled = true;
			this.cmbML.Location = new System.Drawing.Point(587, 337);
			this.cmbML.Name = "cmbML";
			this.cmbML.Size = new System.Drawing.Size(121, 21);
			this.cmbML.TabIndex = 30;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(435, 206);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(110, 24);
			this.label12.TabIndex = 10;
			this.label12.Text = "JE Testing:";
			// 
			// cmbPlanningMemo
			// 
			this.cmbPlanningMemo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPlanningMemo.Enabled = false;
			this.cmbPlanningMemo.FormattingEnabled = true;
			this.cmbPlanningMemo.Location = new System.Drawing.Point(285, 113);
			this.cmbPlanningMemo.Name = "cmbPlanningMemo";
			this.cmbPlanningMemo.Size = new System.Drawing.Size(121, 21);
			this.cmbPlanningMemo.TabIndex = 6;
			// 
			// cmbScope
			// 
			this.cmbScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbScope.Enabled = false;
			this.cmbScope.FormattingEnabled = true;
			this.cmbScope.Location = new System.Drawing.Point(285, 81);
			this.cmbScope.Name = "cmbScope";
			this.cmbScope.Size = new System.Drawing.Size(121, 21);
			this.cmbScope.TabIndex = 5;
			// 
			// cmbFASmeeting
			// 
			this.cmbFASmeeting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFASmeeting.Enabled = false;
			this.cmbFASmeeting.FormattingEnabled = true;
			this.cmbFASmeeting.Location = new System.Drawing.Point(285, 50);
			this.cmbFASmeeting.Name = "cmbFASmeeting";
			this.cmbFASmeeting.Size = new System.Drawing.Size(121, 21);
			this.cmbFASmeeting.TabIndex = 4;
			// 
			// cmbGamxStatus
			// 
			this.cmbGamxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGamxStatus.Enabled = false;
			this.cmbGamxStatus.FormattingEnabled = true;
			this.cmbGamxStatus.Location = new System.Drawing.Point(285, 20);
			this.cmbGamxStatus.Name = "cmbGamxStatus";
			this.cmbGamxStatus.Size = new System.Drawing.Size(121, 21);
			this.cmbGamxStatus.TabIndex = 3;
			// 
			// cmbEngName
			// 
			this.cmbEngName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngName.FormattingEnabled = true;
			this.cmbEngName.Location = new System.Drawing.Point(427, 115);
			this.cmbEngName.Name = "cmbEngName";
			this.cmbEngName.Size = new System.Drawing.Size(456, 21);
			this.cmbEngName.TabIndex = 1;
			this.cmbEngName.SelectedIndexChanged += new System.EventHandler(this.CmbEngNameSelectedIndexChanged);
			this.cmbEngName.Click += new System.EventHandler(this.CmbEngNameClick);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(306, 150);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(110, 23);
			this.label21.TabIndex = 41;
			this.label21.Text = "Engagement Code:";
			// 
			// cmbEngCode
			// 
			this.cmbEngCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngCode.FormattingEnabled = true;
			this.cmbEngCode.Location = new System.Drawing.Point(761, 150);
			this.cmbEngCode.Name = "cmbEngCode";
			this.cmbEngCode.Size = new System.Drawing.Size(122, 21);
			this.cmbEngCode.TabIndex = 2;
			this.cmbEngCode.Visible = false;
			this.cmbEngCode.SelectedIndexChanged += new System.EventHandler(this.CmbEngCodeSelectedIndexChanged);
			this.cmbEngCode.Click += new System.EventHandler(this.CmbEngCodeClick);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(306, 115);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(110, 23);
			this.label19.TabIndex = 3;
			this.label19.Text = "Engagement Name:";
			// 
			// frmWorkStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmWorkStatus";
			this.Text = "Work_status";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtEngCode;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.ComboBox cmbMLFollowUp;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.DateTimePicker dtpMLFollowUp;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.DateTimePicker dtpSRM;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.DateTimePicker dtpML;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.DateTimePicker dtpDataMigration;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.DateTimePicker dtpSOX;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.DateTimePicker dtpITCom;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.DateTimePicker dtpITGC;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.DateTimePicker dtpBPR;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.DateTimePicker dtpAppCon;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.DateTimePicker dtpEAE;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.DateTimePicker dtpJE;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox cmbEngName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbComplexity;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox cmbSOX;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox cmbEngCode;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cmbGamxStatus;
		private System.Windows.Forms.ComboBox cmbFASmeeting;
		private System.Windows.Forms.ComboBox cmbAddendum;
		private System.Windows.Forms.ComboBox cmbScope;
		private System.Windows.Forms.ComboBox cmbPlanningMemo;
		private System.Windows.Forms.ComboBox cmbIGTC;
		private System.Windows.Forms.ComboBox cmbJE;
		private System.Windows.Forms.ComboBox cmbEAE;
		private System.Windows.Forms.ComboBox cmbDataMigration;
		private System.Windows.Forms.ComboBox cmbBPR;
		private System.Windows.Forms.ComboBox cmbAppControl;
		private System.Windows.Forms.ComboBox cmbYEupdate;
		private System.Windows.Forms.ComboBox cmbSRM;
		private System.Windows.Forms.ComboBox cmbML;
		private System.Windows.Forms.ComboBox cmbFASresult;
		private System.Windows.Forms.ComboBox cmbGamxDoc;
		private System.Windows.Forms.ComboBox cmbArchive;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}