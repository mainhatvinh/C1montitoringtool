/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 7/18/2013
 * Time: 11:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmConfiguration
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
			this.grdWeekRev = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.grdTempStd = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbEYFY = new System.Windows.Forms.ComboBox();
			this.grdStdHour = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbEY_FY = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbLevel = new System.Windows.Forms.ComboBox();
			this.grdPeakSeason = new System.Windows.Forms.DataGridView();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.txtStaffTargetedHrs = new System.Windows.Forms.TextBox();
			this.txtSeniorTargetedHrs = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.grdPeakSeasonMember = new System.Windows.Forms.DataGridView();
			this.grdPeakSeasonTarget = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chlITRAMember = new System.Windows.Forms.CheckedListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chbDec = new System.Windows.Forms.CheckBox();
			this.chbNov = new System.Windows.Forms.CheckBox();
			this.chbOct = new System.Windows.Forms.CheckBox();
			this.chbSep = new System.Windows.Forms.CheckBox();
			this.chbAug = new System.Windows.Forms.CheckBox();
			this.chbJul = new System.Windows.Forms.CheckBox();
			this.chbJun = new System.Windows.Forms.CheckBox();
			this.chbMay = new System.Windows.Forms.CheckBox();
			this.chbApr = new System.Windows.Forms.CheckBox();
			this.chbMar = new System.Windows.Forms.CheckBox();
			this.chbFeb = new System.Windows.Forms.CheckBox();
			this.chbJan = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWeekRev)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTempStd)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdStdHour)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPeakSeason)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPeakSeasonMember)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPeakSeasonTarget)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdWeekRev);
			this.mainPanel.Controls.Add(this.groupBox4);
			this.mainPanel.Controls.Add(this.grdTempStd);
			this.mainPanel.Controls.Add(this.groupBox3);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.txtStaffTargetedHrs);
			this.mainPanel.Controls.Add(this.txtSeniorTargetedHrs);
			this.mainPanel.Controls.Add(this.dataGridView1);
			this.mainPanel.Controls.Add(this.grdPeakSeasonMember);
			this.mainPanel.Controls.Add(this.grdPeakSeasonTarget);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// grdWeekRev
			// 
			this.grdWeekRev.AllowUserToAddRows = false;
			this.grdWeekRev.AllowUserToDeleteRows = false;
			this.grdWeekRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWeekRev.Location = new System.Drawing.Point(474, 577);
			this.grdWeekRev.Name = "grdWeekRev";
			this.grdWeekRev.ReadOnly = true;
			this.grdWeekRev.Size = new System.Drawing.Size(60, 49);
			this.grdWeekRev.TabIndex = 39;
			this.grdWeekRev.Visible = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button2);
			this.groupBox4.Controls.Add(this.textBox2);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Location = new System.Drawing.Point(136, 577);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(281, 170);
			this.groupBox4.TabIndex = 38;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Year - Revenue";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(114, 123);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 31);
			this.button2.TabIndex = 33;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(114, 84);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(114, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label8.Location = new System.Drawing.Point(15, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 19);
			this.label8.TabIndex = 3;
			this.label8.Text = "Revenue (%) (*):";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label6.Location = new System.Drawing.Point(15, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 19);
			this.label6.TabIndex = 2;
			this.label6.Text = "Week Number (*): ";
			// 
			// grdTempStd
			// 
			this.grdTempStd.AllowUserToAddRows = false;
			this.grdTempStd.AllowUserToDeleteRows = false;
			this.grdTempStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTempStd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdTempStd.Location = new System.Drawing.Point(136, 771);
			this.grdTempStd.MultiSelect = false;
			this.grdTempStd.Name = "grdTempStd";
			this.grdTempStd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTempStd.Size = new System.Drawing.Size(428, 22);
			this.grdTempStd.TabIndex = 37;
			this.grdTempStd.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.cmbEYFY);
			this.groupBox3.Controls.Add(this.grdStdHour);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Location = new System.Drawing.Point(131, 300);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(990, 244);
			this.groupBox3.TabIndex = 36;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Standard Hours";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(20, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "EY Fiscal Year (*):";
			// 
			// cmbEYFY
			// 
			this.cmbEYFY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEYFY.FormattingEnabled = true;
			this.cmbEYFY.Items.AddRange(new object[] {
									"2012",
									"2013",
									"2014",
									"2015",
									"2016",
									"2017",
									"2018",
									"2019",
									"2020"});
			this.cmbEYFY.Location = new System.Drawing.Point(119, 23);
			this.cmbEYFY.Name = "cmbEYFY";
			this.cmbEYFY.Size = new System.Drawing.Size(92, 21);
			this.cmbEYFY.TabIndex = 4;
			this.cmbEYFY.SelectedIndexChanged += new System.EventHandler(this.CmbEYFYSelectedIndexChanged);
			// 
			// grdStdHour
			// 
			this.grdStdHour.AllowUserToAddRows = false;
			this.grdStdHour.AllowUserToDeleteRows = false;
			this.grdStdHour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdStdHour.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdStdHour.Location = new System.Drawing.Point(242, 23);
			this.grdStdHour.MultiSelect = false;
			this.grdStdHour.Name = "grdStdHour";
			this.grdStdHour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdStdHour.Size = new System.Drawing.Size(725, 207);
			this.grdStdHour.TabIndex = 32;
			this.grdStdHour.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdStdHourCellValueChanged);
			this.grdStdHour.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdStdHourColumnAdded);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(119, 124);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 31);
			this.button1.TabIndex = 5;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.cmbEY_FY);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cmbLevel);
			this.groupBox2.Controls.Add(this.grdPeakSeason);
			this.groupBox2.Controls.Add(this.btnSubmit);
			this.groupBox2.Location = new System.Drawing.Point(131, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(990, 245);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Peak season";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(20, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Fiscal Year (*):";
			// 
			// cmbEY_FY
			// 
			this.cmbEY_FY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEY_FY.FormattingEnabled = true;
			this.cmbEY_FY.Items.AddRange(new object[] {
									"2012",
									"2013",
									"2014",
									"2015",
									"2016",
									"2017",
									"2018",
									"2019",
									"2020"});
			this.cmbEY_FY.Location = new System.Drawing.Point(119, 23);
			this.cmbEY_FY.Name = "cmbEY_FY";
			this.cmbEY_FY.Size = new System.Drawing.Size(92, 21);
			this.cmbEY_FY.TabIndex = 1;
			this.cmbEY_FY.SelectedIndexChanged += new System.EventHandler(this.CmbEY_FYSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(20, 66);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 23);
			this.label7.TabIndex = 31;
			this.label7.Text = "Level (*):";
			// 
			// cmbLevel
			// 
			this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLevel.FormattingEnabled = true;
			this.cmbLevel.Items.AddRange(new object[] {
									"Manager",
									"Senior",
									"Staff"});
			this.cmbLevel.Location = new System.Drawing.Point(119, 63);
			this.cmbLevel.Name = "cmbLevel";
			this.cmbLevel.Size = new System.Drawing.Size(92, 21);
			this.cmbLevel.TabIndex = 2;
			this.cmbLevel.SelectedIndexChanged += new System.EventHandler(this.CmbLevelSelectedIndexChanged);
			// 
			// grdPeakSeason
			// 
			this.grdPeakSeason.AllowUserToAddRows = false;
			this.grdPeakSeason.AllowUserToDeleteRows = false;
			this.grdPeakSeason.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPeakSeason.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdPeakSeason.Location = new System.Drawing.Point(242, 23);
			this.grdPeakSeason.MultiSelect = false;
			this.grdPeakSeason.Name = "grdPeakSeason";
			this.grdPeakSeason.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPeakSeason.Size = new System.Drawing.Size(725, 209);
			this.grdPeakSeason.TabIndex = 32;
			this.grdPeakSeason.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPeakSeasonCellValueChanged);
			this.grdPeakSeason.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdPeakSeasonColumnAdded);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(119, 142);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(92, 31);
			this.btnSubmit.TabIndex = 3;
			this.btnSubmit.Text = "Save";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// grdTemp
			// 
			this.grdTemp.AllowUserToAddRows = false;
			this.grdTemp.AllowUserToDeleteRows = false;
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdTemp.Location = new System.Drawing.Point(42, 328);
			this.grdTemp.MultiSelect = false;
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp.Size = new System.Drawing.Size(33, 99);
			this.grdTemp.TabIndex = 34;
			this.grdTemp.Visible = false;
			// 
			// txtStaffTargetedHrs
			// 
			this.txtStaffTargetedHrs.Location = new System.Drawing.Point(12, 244);
			this.txtStaffTargetedHrs.Name = "txtStaffTargetedHrs";
			this.txtStaffTargetedHrs.Size = new System.Drawing.Size(48, 20);
			this.txtStaffTargetedHrs.TabIndex = 24;
			this.txtStaffTargetedHrs.Visible = false;
			// 
			// txtSeniorTargetedHrs
			// 
			this.txtSeniorTargetedHrs.Location = new System.Drawing.Point(12, 286);
			this.txtSeniorTargetedHrs.Name = "txtSeniorTargetedHrs";
			this.txtSeniorTargetedHrs.Size = new System.Drawing.Size(48, 20);
			this.txtSeniorTargetedHrs.TabIndex = 22;
			this.txtSeniorTargetedHrs.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridView1.Location = new System.Drawing.Point(12, 328);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(24, 99);
			this.dataGridView1.TabIndex = 33;
			this.dataGridView1.Visible = false;
			// 
			// grdPeakSeasonMember
			// 
			this.grdPeakSeasonMember.AllowUserToAddRows = false;
			this.grdPeakSeasonMember.AllowUserToDeleteRows = false;
			this.grdPeakSeasonMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPeakSeasonMember.Location = new System.Drawing.Point(3, 98);
			this.grdPeakSeasonMember.Name = "grdPeakSeasonMember";
			this.grdPeakSeasonMember.ReadOnly = true;
			this.grdPeakSeasonMember.Size = new System.Drawing.Size(60, 49);
			this.grdPeakSeasonMember.TabIndex = 29;
			this.grdPeakSeasonMember.Visible = false;
			// 
			// grdPeakSeasonTarget
			// 
			this.grdPeakSeasonTarget.AllowUserToAddRows = false;
			this.grdPeakSeasonTarget.AllowUserToDeleteRows = false;
			this.grdPeakSeasonTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPeakSeasonTarget.Location = new System.Drawing.Point(12, 22);
			this.grdPeakSeasonTarget.Name = "grdPeakSeasonTarget";
			this.grdPeakSeasonTarget.ReadOnly = true;
			this.grdPeakSeasonTarget.Size = new System.Drawing.Size(60, 46);
			this.grdPeakSeasonTarget.TabIndex = 28;
			this.grdPeakSeasonTarget.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chlITRAMember);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.chbDec);
			this.groupBox1.Controls.Add(this.chbNov);
			this.groupBox1.Controls.Add(this.chbOct);
			this.groupBox1.Controls.Add(this.chbSep);
			this.groupBox1.Controls.Add(this.chbAug);
			this.groupBox1.Controls.Add(this.chbJul);
			this.groupBox1.Controls.Add(this.chbJun);
			this.groupBox1.Controls.Add(this.chbMay);
			this.groupBox1.Controls.Add(this.chbApr);
			this.groupBox1.Controls.Add(this.chbMar);
			this.groupBox1.Controls.Add(this.chbFeb);
			this.groupBox1.Controls.Add(this.chbJan);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(30, 489);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(42, 192);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Peak season target";
			this.groupBox1.Visible = false;
			// 
			// chlITRAMember
			// 
			this.chlITRAMember.CheckOnClick = true;
			this.chlITRAMember.FormattingEnabled = true;
			this.chlITRAMember.Location = new System.Drawing.Point(52, 247);
			this.chlITRAMember.Name = "chlITRAMember";
			this.chlITRAMember.Size = new System.Drawing.Size(335, 274);
			this.chlITRAMember.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label5.Location = new System.Drawing.Point(52, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 19);
			this.label5.TabIndex = 23;
			this.label5.Text = "Staff targeted charged hours (*):";
			// 
			// chbDec
			// 
			this.chbDec.Location = new System.Drawing.Point(243, 98);
			this.chbDec.Name = "chbDec";
			this.chbDec.Size = new System.Drawing.Size(48, 24);
			this.chbDec.TabIndex = 21;
			this.chbDec.Text = "Dec";
			this.chbDec.UseVisualStyleBackColor = true;
			// 
			// chbNov
			// 
			this.chbNov.Location = new System.Drawing.Point(193, 98);
			this.chbNov.Name = "chbNov";
			this.chbNov.Size = new System.Drawing.Size(52, 24);
			this.chbNov.TabIndex = 20;
			this.chbNov.Text = "Nov";
			this.chbNov.UseVisualStyleBackColor = true;
			// 
			// chbOct
			// 
			this.chbOct.Location = new System.Drawing.Point(343, 75);
			this.chbOct.Name = "chbOct";
			this.chbOct.Size = new System.Drawing.Size(44, 24);
			this.chbOct.TabIndex = 19;
			this.chbOct.Text = "Oct";
			this.chbOct.UseVisualStyleBackColor = true;
			// 
			// chbSep
			// 
			this.chbSep.Location = new System.Drawing.Point(293, 75);
			this.chbSep.Name = "chbSep";
			this.chbSep.Size = new System.Drawing.Size(53, 24);
			this.chbSep.TabIndex = 18;
			this.chbSep.Text = "Sep";
			this.chbSep.UseVisualStyleBackColor = true;
			// 
			// chbAug
			// 
			this.chbAug.Location = new System.Drawing.Point(243, 75);
			this.chbAug.Name = "chbAug";
			this.chbAug.Size = new System.Drawing.Size(57, 24);
			this.chbAug.TabIndex = 17;
			this.chbAug.Text = "Aug";
			this.chbAug.UseVisualStyleBackColor = true;
			// 
			// chbJul
			// 
			this.chbJul.Location = new System.Drawing.Point(193, 75);
			this.chbJul.Name = "chbJul";
			this.chbJul.Size = new System.Drawing.Size(44, 24);
			this.chbJul.TabIndex = 16;
			this.chbJul.Text = "Jul";
			this.chbJul.UseVisualStyleBackColor = true;
			// 
			// chbJun
			// 
			this.chbJun.Location = new System.Drawing.Point(343, 121);
			this.chbJun.Name = "chbJun";
			this.chbJun.Size = new System.Drawing.Size(44, 24);
			this.chbJun.TabIndex = 15;
			this.chbJun.Text = "Jun";
			this.chbJun.UseVisualStyleBackColor = true;
			// 
			// chbMay
			// 
			this.chbMay.Location = new System.Drawing.Point(293, 121);
			this.chbMay.Name = "chbMay";
			this.chbMay.Size = new System.Drawing.Size(53, 24);
			this.chbMay.TabIndex = 14;
			this.chbMay.Text = "May";
			this.chbMay.UseVisualStyleBackColor = true;
			// 
			// chbApr
			// 
			this.chbApr.Location = new System.Drawing.Point(243, 121);
			this.chbApr.Name = "chbApr";
			this.chbApr.Size = new System.Drawing.Size(44, 24);
			this.chbApr.TabIndex = 13;
			this.chbApr.Text = "Apr";
			this.chbApr.UseVisualStyleBackColor = true;
			// 
			// chbMar
			// 
			this.chbMar.Location = new System.Drawing.Point(193, 121);
			this.chbMar.Name = "chbMar";
			this.chbMar.Size = new System.Drawing.Size(44, 24);
			this.chbMar.TabIndex = 12;
			this.chbMar.Text = "Mar";
			this.chbMar.UseVisualStyleBackColor = true;
			// 
			// chbFeb
			// 
			this.chbFeb.Location = new System.Drawing.Point(343, 98);
			this.chbFeb.Name = "chbFeb";
			this.chbFeb.Size = new System.Drawing.Size(44, 24);
			this.chbFeb.TabIndex = 11;
			this.chbFeb.Text = "Feb";
			this.chbFeb.UseVisualStyleBackColor = true;
			// 
			// chbJan
			// 
			this.chbJan.Location = new System.Drawing.Point(293, 98);
			this.chbJan.Name = "chbJan";
			this.chbJan.Size = new System.Drawing.Size(44, 24);
			this.chbJan.TabIndex = 10;
			this.chbJan.Text = "Jan";
			this.chbJan.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label4.Location = new System.Drawing.Point(52, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 19);
			this.label4.TabIndex = 9;
			this.label4.Text = "Senior targeted charged hours (*):";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label3.Location = new System.Drawing.Point(52, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "Month (*):";
			// 
			// frmConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmConfiguration";
			this.Text = "Configuration";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWeekRev)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTempStd)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdStdHour)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdPeakSeason)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPeakSeasonMember)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdPeakSeasonTarget)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView grdWeekRev;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView grdTempStd;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView grdStdHour;
		private System.Windows.Forms.ComboBox cmbEYFY;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbLevel;
		private System.Windows.Forms.DataGridView grdPeakSeason;
		private System.Windows.Forms.DataGridView grdPeakSeasonMember;
		private System.Windows.Forms.CheckedListBox chlITRAMember;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtStaffTargetedHrs;
		private System.Windows.Forms.DataGridView grdPeakSeasonTarget;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chbJan;
		private System.Windows.Forms.CheckBox chbFeb;
		private System.Windows.Forms.CheckBox chbMar;
		private System.Windows.Forms.CheckBox chbApr;
		private System.Windows.Forms.CheckBox chbMay;
		private System.Windows.Forms.CheckBox chbJun;
		private System.Windows.Forms.CheckBox chbJul;
		private System.Windows.Forms.CheckBox chbAug;
		private System.Windows.Forms.CheckBox chbSep;
		private System.Windows.Forms.CheckBox chbOct;
		private System.Windows.Forms.CheckBox chbNov;
		private System.Windows.Forms.CheckBox chbDec;
		private System.Windows.Forms.TextBox txtSeniorTargetedHrs;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbEY_FY;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel mainPanel;
	}
}
