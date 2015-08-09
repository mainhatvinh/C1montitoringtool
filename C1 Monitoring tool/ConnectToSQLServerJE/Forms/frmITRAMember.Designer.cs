/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/17/2013
 * Time: 4:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmITRAMember
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
			this.label5 = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.cmbLevel = new System.Windows.Forms.ComboBox();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.label24 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbGroup = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.cmbClor = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.cmbWorkingLocation = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.grdMembers = new System.Windows.Forms.DataGridView();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(103, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee name (*):";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(103, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee ID (*):";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(103, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Level (*):";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(511, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Contact Number (*):";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
									"Working",
									"Resigned"});
			this.cmbStatus.Location = new System.Drawing.Point(651, 131);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(189, 21);
			this.cmbStatus.TabIndex = 10;
			this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatusSelectedIndexChanged);
			// 
			// cmbLevel
			// 
			this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLevel.FormattingEnabled = true;
			this.cmbLevel.Location = new System.Drawing.Point(241, 134);
			this.cmbLevel.Name = "cmbLevel";
			this.cmbLevel.Size = new System.Drawing.Size(188, 21);
			this.cmbLevel.TabIndex = 3;
			// 
			// cmbGender
			// 
			this.cmbGender.CausesValidation = false;
			this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
									"Male",
									"Female"});
			this.cmbGender.Location = new System.Drawing.Point(241, 174);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(188, 21);
			this.cmbGender.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(510, 260);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 16;
			this.label10.Text = "End Date:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(510, 218);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 14;
			this.label9.Text = "Start Date (*):";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(511, 137);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "Status (*)";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(103, 177);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Gender (*):";
			// 
			// txtContactNo
			// 
			this.txtContactNo.Location = new System.Drawing.Point(651, 90);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(189, 20);
			this.txtContactNo.TabIndex = 9;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(241, 93);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(188, 20);
			this.txtID.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(241, 18);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(188, 20);
			this.txtName.TabIndex = 1;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnReset.Location = new System.Drawing.Point(280, 301);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 46);
			this.btnReset.TabIndex = 14;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSubmit.Location = new System.Drawing.Point(424, 301);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 46);
			this.btnSubmit.TabIndex = 15;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDel.Location = new System.Drawing.Point(567, 301);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 46);
			this.btnDel.TabIndex = 16;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(125, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(561, 51);
			this.label6.TabIndex = 9;
			this.label6.Text = "Please fill in the following form to create a new member or update an existing me" +
			"mber:";
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.label24);
			this.mainPanel.Controls.Add(this.txtSearch);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.label11);
			this.mainPanel.Controls.Add(this.grdMembers);
			this.mainPanel.Controls.Add(this.label6);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 13;
			// 
			// grdTemp
			// 
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(1147, 0);
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.Size = new System.Drawing.Size(45, 30);
			this.grdTemp.TabIndex = 67;
			this.grdTemp.Visible = false;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(800, 58);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(47, 23);
			this.label24.TabIndex = 66;
			this.label24.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSearch.Location = new System.Drawing.Point(877, 58);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(185, 20);
			this.txtSearch.TabIndex = 65;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbGroup);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.cmbClor);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.cmbWorkingLocation);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.cmbRole);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.dtpEndDate);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.dtpStartDate);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.cmbStatus);
			this.groupBox1.Controls.Add(this.cmbLevel);
			this.groupBox1.Controls.Add(this.cmbGender);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtContactNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(125, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(960, 362);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Employee";
			// 
			// cmbGroup
			// 
			this.cmbGroup.CausesValidation = false;
			this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGroup.FormattingEnabled = true;
			this.cmbGroup.Items.AddRange(new object[] {
									"A",
									"B"});
			this.cmbGroup.Location = new System.Drawing.Point(241, 256);
			this.cmbGroup.Name = "cmbGroup";
			this.cmbGroup.Size = new System.Drawing.Size(188, 21);
			this.cmbGroup.TabIndex = 6;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(103, 260);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 28;
			this.label18.Text = "Group (*):";
			// 
			// cmbClor
			// 
			this.cmbClor.CausesValidation = false;
			this.cmbClor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClor.FormattingEnabled = true;
			this.cmbClor.Items.AddRange(new object[] {
									"Normal",
									"Admin",
									"Secretary"});
			this.cmbClor.Location = new System.Drawing.Point(651, 17);
			this.cmbClor.Name = "cmbClor";
			this.cmbClor.Size = new System.Drawing.Size(188, 21);
			this.cmbClor.TabIndex = 7;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(510, 18);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 27;
			this.label17.Text = "Counsellor:";
			// 
			// cmbWorkingLocation
			// 
			this.cmbWorkingLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWorkingLocation.FormattingEnabled = true;
			this.cmbWorkingLocation.Items.AddRange(new object[] {
									"Hanoi",
									"HCM"});
			this.cmbWorkingLocation.Location = new System.Drawing.Point(651, 171);
			this.cmbWorkingLocation.Name = "cmbWorkingLocation";
			this.cmbWorkingLocation.Size = new System.Drawing.Size(189, 21);
			this.cmbWorkingLocation.TabIndex = 11;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(511, 174);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(132, 23);
			this.label16.TabIndex = 25;
			this.label16.Text = "Working Location (*)";
			// 
			// cmbRole
			// 
			this.cmbRole.CausesValidation = false;
			this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Items.AddRange(new object[] {
									"Normal",
									"Admin",
									"Secretary"});
			this.cmbRole.Location = new System.Drawing.Point(241, 216);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(188, 21);
			this.cmbRole.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(103, 219);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "Role (*):";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(510, 274);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 23;
			this.label15.Text = "(mm/dd/yyyy)";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(510, 237);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 22;
			this.label14.Text = "(mm/dd/yyyy)";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(103, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(326, 30);
			this.label13.TabIndex = 21;
			this.label13.Text = "Employee names must follow the EY format.( i.e Nguyen Van An should be inserted a" +
			"s An.Van.Nguyen) ";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(651, 58);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(188, 20);
			this.txtEmail.TabIndex = 8;
			this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmailTextChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(511, 61);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 19;
			this.label12.Text = "Email (*):";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Enabled = false;
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndDate.Location = new System.Drawing.Point(651, 260);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(189, 20);
			this.dtpEndDate.TabIndex = 13;
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartDate.Location = new System.Drawing.Point(651, 216);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(189, 20);
			this.dtpStartDate.TabIndex = 12;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(125, 50);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(198, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "*: Fields with * are mandatory";
			// 
			// grdMembers
			// 
			this.grdMembers.AllowUserToAddRows = false;
			this.grdMembers.AllowUserToDeleteRows = false;
			this.grdMembers.AllowUserToOrderColumns = true;
			this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMembers.Location = new System.Drawing.Point(125, 466);
			this.grdMembers.MultiSelect = false;
			this.grdMembers.Name = "grdMembers";
			this.grdMembers.ReadOnly = true;
			this.grdMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdMembers.Size = new System.Drawing.Size(950, 283);
			this.grdMembers.TabIndex = 14;
			this.grdMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMembersCellClick);
			this.grdMembers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdMembersDataBindingComplete);
			this.grdMembers.SelectionChanged += new System.EventHandler(this.GrdMembersSelectionChanged);
			this.grdMembers.Sorted += new System.EventHandler(this.GrdMembersSorted);
			// 
			// frmITRAMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmITRAMember";
			this.Text = "Risk Members ";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cmbGroup;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cmbClor;
		private System.Windows.Forms.ComboBox cmbWorkingLocation;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbRole;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.ComboBox cmbLevel;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.DataGridView grdMembers;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtContactNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		void TxtEmailTextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void Label5Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
