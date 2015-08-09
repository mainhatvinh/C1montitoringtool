/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmBudgetStaffing
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
			this.label13 = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.txtEngCode = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.cmbEngID = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbxBooking = new System.Windows.Forms.GroupBox();
			this.cmbMemLvl = new System.Windows.Forms.ComboBox();
			this.grdStaffing = new System.Windows.Forms.DataGridView();
			this.cmbLevel = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbName = new System.Windows.Forms.ComboBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbEngName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbEngCode = new System.Windows.Forms.ComboBox();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			this.gbxBooking.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdStaffing)).BeginInit();
			this.SuspendLayout();
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label13.Location = new System.Drawing.Point(125, 30);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(651, 23);
			this.label13.TabIndex = 1;
			this.label13.Text = "Please fill in the following form to perform engagement staffing and budget plann" +
			"ing:";
			// 
			// mainPanel
			// 
			this.mainPanel.AutoScroll = true;
			this.mainPanel.Controls.Add(this.txtEngCode);
			this.mainPanel.Controls.Add(this.label7);
			this.mainPanel.Controls.Add(this.comboBox1);
			this.mainPanel.Controls.Add(this.label5);
			this.mainPanel.Controls.Add(this.cmbYear);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.cmbEngID);
			this.mainPanel.Controls.Add(this.label4);
			this.mainPanel.Controls.Add(this.gbxBooking);
			this.mainPanel.Controls.Add(this.label2);
			this.mainPanel.Controls.Add(this.cmbEngName);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.cmbEngCode);
			this.mainPanel.Controls.Add(this.label13);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 3;
			// 
			// txtEngCode
			// 
			this.txtEngCode.Location = new System.Drawing.Point(429, 197);
			this.txtEngCode.Name = "txtEngCode";
			this.txtEngCode.ReadOnly = true;
			this.txtEngCode.Size = new System.Drawing.Size(153, 20);
			this.txtEngCode.TabIndex = 37;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(306, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 24);
			this.label7.TabIndex = 36;
			this.label7.Text = "Type:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Channel 1",
									"Authorized Project",
									"Non-chargeable"});
			this.comboBox1.Location = new System.Drawing.Point(429, 84);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(306, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 24);
			this.label5.TabIndex = 34;
			this.label5.Text = "Fiscal year:";
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
			this.cmbYear.Location = new System.Drawing.Point(429, 123);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 21);
			this.cmbYear.TabIndex = 10;
			this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYearSelectedIndexChanged);
			// 
			// grdTemp
			// 
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(897, 62);
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.Size = new System.Drawing.Size(274, 85);
			this.grdTemp.TabIndex = 32;
			this.grdTemp.Visible = false;
			// 
			// cmbEngID
			// 
			this.cmbEngID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngID.FormattingEnabled = true;
			this.cmbEngID.Location = new System.Drawing.Point(897, 32);
			this.cmbEngID.Name = "cmbEngID";
			this.cmbEngID.Size = new System.Drawing.Size(210, 21);
			this.cmbEngID.TabIndex = 31;
			this.cmbEngID.Visible = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(125, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "*: Fields with * are mandatory";
			// 
			// gbxBooking
			// 
			this.gbxBooking.Controls.Add(this.cmbMemLvl);
			this.gbxBooking.Controls.Add(this.grdStaffing);
			this.gbxBooking.Controls.Add(this.cmbLevel);
			this.gbxBooking.Controls.Add(this.label6);
			this.gbxBooking.Controls.Add(this.label3);
			this.gbxBooking.Controls.Add(this.cmbName);
			this.gbxBooking.Controls.Add(this.btnReset);
			this.gbxBooking.Controls.Add(this.btnDel);
			this.gbxBooking.Controls.Add(this.btnSubmit);
			this.gbxBooking.Location = new System.Drawing.Point(125, 233);
			this.gbxBooking.Name = "gbxBooking";
			this.gbxBooking.Size = new System.Drawing.Size(950, 445);
			this.gbxBooking.TabIndex = 30;
			this.gbxBooking.TabStop = false;
			// 
			// cmbMemLvl
			// 
			this.cmbMemLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMemLvl.FormattingEnabled = true;
			this.cmbMemLvl.Location = new System.Drawing.Point(629, 82);
			this.cmbMemLvl.Name = "cmbMemLvl";
			this.cmbMemLvl.Size = new System.Drawing.Size(141, 21);
			this.cmbMemLvl.TabIndex = 5;
			this.cmbMemLvl.Visible = false;
			// 
			// grdStaffing
			// 
			this.grdStaffing.AllowUserToAddRows = false;
			this.grdStaffing.AllowUserToDeleteRows = false;
			this.grdStaffing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdStaffing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdStaffing.Location = new System.Drawing.Point(22, 199);
			this.grdStaffing.MultiSelect = false;
			this.grdStaffing.Name = "grdStaffing";
			this.grdStaffing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdStaffing.Size = new System.Drawing.Size(907, 207);
			this.grdStaffing.TabIndex = 11;
			this.grdStaffing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdStaffingCellClick);
			this.grdStaffing.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdStaffingCellValueChanged);
			this.grdStaffing.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdStaffingDataBindingComplete);
			this.grdStaffing.SelectionChanged += new System.EventHandler(this.GrdStaffingSelectionChanged);
			this.grdStaffing.Paint += new System.Windows.Forms.PaintEventHandler(this.GrdStaffingPaint);
			// 
			// cmbLevel
			// 
			this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLevel.FormattingEnabled = true;
			this.cmbLevel.Items.AddRange(new object[] {
									"Partner",
									"Senior Manager",
									"Manager",
									"Senior",
									"Staff"});
			this.cmbLevel.Location = new System.Drawing.Point(390, 38);
			this.cmbLevel.Name = "cmbLevel";
			this.cmbLevel.Size = new System.Drawing.Size(210, 21);
			this.cmbLevel.TabIndex = 3;
			this.cmbLevel.SelectedIndexChanged += new System.EventHandler(this.CmbLevelSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(266, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Level (*):";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(266, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "Team members (*):";
			// 
			// cmbName
			// 
			this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName.FormattingEnabled = true;
			this.cmbName.Location = new System.Drawing.Point(390, 83);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(210, 21);
			this.cmbName.TabIndex = 4;
			this.cmbName.SelectedIndexChanged += new System.EventHandler(this.CmbNameSelectedIndexChanged);
			this.cmbName.SelectedValueChanged += new System.EventHandler(this.CmbNameSelectedValueChanged);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnReset.Location = new System.Drawing.Point(294, 138);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 41);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Clear";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnDel.Location = new System.Drawing.Point(581, 138);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 41);
			this.btnDel.TabIndex = 8;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnSubmit.Location = new System.Drawing.Point(438, 138);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 41);
			this.btnSubmit.TabIndex = 7;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(306, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "Engagement Name:";
			// 
			// cmbEngName
			// 
			this.cmbEngName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngName.FormattingEnabled = true;
			this.cmbEngName.Location = new System.Drawing.Point(429, 159);
			this.cmbEngName.Name = "cmbEngName";
			this.cmbEngName.Size = new System.Drawing.Size(456, 21);
			this.cmbEngName.TabIndex = 1;
			this.cmbEngName.SelectedIndexChanged += new System.EventHandler(this.CmbEngNameSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(306, 197);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Engagement Code:";
			// 
			// cmbEngCode
			// 
			this.cmbEngCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngCode.FormattingEnabled = true;
			this.cmbEngCode.Location = new System.Drawing.Point(739, 194);
			this.cmbEngCode.Name = "cmbEngCode";
			this.cmbEngCode.Size = new System.Drawing.Size(146, 21);
			this.cmbEngCode.TabIndex = 2;
			this.cmbEngCode.Visible = false;
			this.cmbEngCode.SelectedIndexChanged += new System.EventHandler(this.CmbEngCodeSelectedIndexChanged);
			// 
			// frmBudgetStaffing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmBudgetStaffing";
			this.Text = "Budget_Staffing";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.gbxBooking.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdStaffing)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtEngCode;
		private System.Windows.Forms.ComboBox cmbMemLvl;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.ComboBox cmbEngID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbLevel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gbxBooking;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.DataGridView grdStaffing;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbName;
		private System.Windows.Forms.ComboBox cmbEngCode;
		private System.Windows.Forms.ComboBox cmbEngName;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}
