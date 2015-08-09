/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/31/2013
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmInfrastructure
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
			this.components = new System.ComponentModel.Container();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.txtEngCode = new System.Windows.Forms.TextBox();
			this.grdDB = new System.Windows.Forms.DataGridView();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.grdOS_DB = new System.Windows.Forms.DataGridView();
			this.grdOS = new System.Windows.Forms.DataGridView();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.cmbEngID = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNo_DB_ID = new System.Windows.Forms.TextBox();
			this.txtNo_OS_ID = new System.Windows.Forms.TextBox();
			this.txtNo_OS_APP_ID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbOS_DB = new System.Windows.Forms.ComboBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtVendor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbDB = new System.Windows.Forms.ComboBox();
			this.cmbOS = new System.Windows.Forms.ComboBox();
			this.cmbAppName = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cmbEngName = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.cmbEngCode = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grdInfrastructure = new System.Windows.Forms.DataGridView();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS_DB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdInfrastructure)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.txtEngCode);
			this.mainPanel.Controls.Add(this.grdDB);
			this.mainPanel.Controls.Add(this.cmbYear);
			this.mainPanel.Controls.Add(this.label11);
			this.mainPanel.Controls.Add(this.label7);
			this.mainPanel.Controls.Add(this.grdOS_DB);
			this.mainPanel.Controls.Add(this.grdOS);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.cmbEngID);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.cmbEngName);
			this.mainPanel.Controls.Add(this.label21);
			this.mainPanel.Controls.Add(this.cmbEngCode);
			this.mainPanel.Controls.Add(this.label19);
			this.mainPanel.Controls.Add(this.label23);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.grdInfrastructure);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// txtEngCode
			// 
			this.txtEngCode.Location = new System.Drawing.Point(427, 147);
			this.txtEngCode.Name = "txtEngCode";
			this.txtEngCode.ReadOnly = true;
			this.txtEngCode.Size = new System.Drawing.Size(153, 20);
			this.txtEngCode.TabIndex = 60;
			// 
			// grdDB
			// 
			this.grdDB.AllowUserToAddRows = false;
			this.grdDB.AllowUserToDeleteRows = false;
			this.grdDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDB.Location = new System.Drawing.Point(996, 150);
			this.grdDB.MultiSelect = false;
			this.grdDB.Name = "grdDB";
			this.grdDB.ReadOnly = true;
			this.grdDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDB.Size = new System.Drawing.Size(151, 60);
			this.grdDB.TabIndex = 59;
			this.grdDB.Visible = false;
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
			this.cmbYear.TabIndex = 16;
			this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(1136, 241);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(38, 20);
			this.label11.TabIndex = 18;
			this.label11.Text = "OSs";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(306, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 23);
			this.label7.TabIndex = 56;
			this.label7.Text = "Fiscal year:";
			// 
			// grdOS_DB
			// 
			this.grdOS_DB.AllowUserToAddRows = false;
			this.grdOS_DB.AllowUserToDeleteRows = false;
			this.grdOS_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdOS_DB.Location = new System.Drawing.Point(665, 13);
			this.grdOS_DB.MultiSelect = false;
			this.grdOS_DB.Name = "grdOS_DB";
			this.grdOS_DB.ReadOnly = true;
			this.grdOS_DB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdOS_DB.Size = new System.Drawing.Size(151, 60);
			this.grdOS_DB.TabIndex = 55;
			this.grdOS_DB.Visible = false;
			// 
			// grdOS
			// 
			this.grdOS.AllowUserToAddRows = false;
			this.grdOS.AllowUserToDeleteRows = false;
			this.grdOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdOS.Location = new System.Drawing.Point(825, 12);
			this.grdOS.MultiSelect = false;
			this.grdOS.Name = "grdOS";
			this.grdOS.ReadOnly = true;
			this.grdOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdOS.Size = new System.Drawing.Size(151, 61);
			this.grdOS.TabIndex = 54;
			this.grdOS.Visible = false;
			// 
			// grdTemp
			// 
			this.grdTemp.AllowUserToAddRows = false;
			this.grdTemp.AllowUserToDeleteRows = false;
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(996, 13);
			this.grdTemp.MultiSelect = false;
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.ReadOnly = true;
			this.grdTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp.Size = new System.Drawing.Size(169, 134);
			this.grdTemp.TabIndex = 53;
			this.grdTemp.Visible = false;
			// 
			// cmbEngID
			// 
			this.cmbEngID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngID.FormattingEnabled = true;
			this.cmbEngID.Location = new System.Drawing.Point(382, 3);
			this.cmbEngID.Name = "cmbEngID";
			this.cmbEngID.Size = new System.Drawing.Size(210, 21);
			this.cmbEngID.TabIndex = 52;
			this.cmbEngID.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtNo_DB_ID);
			this.groupBox1.Controls.Add(this.txtNo_OS_ID);
			this.groupBox1.Controls.Add(this.txtNo_OS_APP_ID);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.cmbOS_DB);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtVendor);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbDB);
			this.groupBox1.Controls.Add(this.cmbOS);
			this.groupBox1.Controls.Add(this.cmbAppName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Location = new System.Drawing.Point(125, 207);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1055, 267);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Infrastructure";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(1010, 100);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 20);
			this.label10.TabIndex = 59;
			this.label10.Text = "OSs";
			this.label10.Click += new System.EventHandler(this.Label10Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(1010, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 20);
			this.label9.TabIndex = 58;
			this.label9.Text = "DBs";
			// 
			// txtNo_DB_ID
			// 
			this.txtNo_DB_ID.Location = new System.Drawing.Point(963, 62);
			this.txtNo_DB_ID.Name = "txtNo_DB_ID";
			this.txtNo_DB_ID.Size = new System.Drawing.Size(41, 20);
			this.txtNo_DB_ID.TabIndex = 8;
			// 
			// txtNo_OS_ID
			// 
			this.txtNo_OS_ID.Location = new System.Drawing.Point(963, 96);
			this.txtNo_OS_ID.Name = "txtNo_OS_ID";
			this.txtNo_OS_ID.Size = new System.Drawing.Size(41, 20);
			this.txtNo_OS_ID.TabIndex = 10;
			// 
			// txtNo_OS_APP_ID
			// 
			this.txtNo_OS_APP_ID.Location = new System.Drawing.Point(963, 29);
			this.txtNo_OS_APP_ID.Name = "txtNo_OS_APP_ID";
			this.txtNo_OS_APP_ID.Size = new System.Drawing.Size(41, 20);
			this.txtNo_OS_APP_ID.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(495, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(137, 19);
			this.label8.TabIndex = 11;
			this.label8.Text = "Operating System (DB):";
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// cmbOS_DB
			// 
			this.cmbOS_DB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOS_DB.FormattingEnabled = true;
			this.cmbOS_DB.Location = new System.Drawing.Point(646, 95);
			this.cmbOS_DB.Name = "cmbOS_DB";
			this.cmbOS_DB.Size = new System.Drawing.Size(282, 21);
			this.cmbOS_DB.TabIndex = 9;
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(576, 210);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 51);
			this.btnDel.TabIndex = 14;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(433, 210);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 51);
			this.btnSubmit.TabIndex = 13;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(289, 210);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 51);
			this.btnReset.TabIndex = 12;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(207, 140);
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(696, 51);
			this.txtRemark.TabIndex = 11;
			this.txtRemark.TextChanged += new System.EventHandler(this.TxtRemarkTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(56, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 22);
			this.label6.TabIndex = 10;
			this.label6.Text = "Remark:";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// txtVendor
			// 
			this.txtVendor.Location = new System.Drawing.Point(207, 62);
			this.txtVendor.Name = "txtVendor";
			this.txtVendor.Size = new System.Drawing.Size(210, 20);
			this.txtVendor.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(56, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Vendor:";
			// 
			// cmbDB
			// 
			this.cmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDB.FormattingEnabled = true;
			this.cmbDB.Location = new System.Drawing.Point(646, 61);
			this.cmbDB.Name = "cmbDB";
			this.cmbDB.Size = new System.Drawing.Size(282, 21);
			this.cmbDB.TabIndex = 7;
			this.cmbDB.SelectedIndexChanged += new System.EventHandler(this.CmbDBSelectedIndexChanged);
			// 
			// cmbOS
			// 
			this.cmbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOS.FormattingEnabled = true;
			this.cmbOS.Location = new System.Drawing.Point(646, 29);
			this.cmbOS.Name = "cmbOS";
			this.cmbOS.Size = new System.Drawing.Size(282, 21);
			this.cmbOS.TabIndex = 5;
			// 
			// cmbAppName
			// 
			this.cmbAppName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAppName.FormattingEnabled = true;
			this.cmbAppName.Location = new System.Drawing.Point(207, 30);
			this.cmbAppName.Name = "cmbAppName";
			this.cmbAppName.Size = new System.Drawing.Size(210, 21);
			this.cmbAppName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(495, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Database:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(495, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Operating System (App):";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Application Name (*):";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(940, 29);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 20);
			this.label12.TabIndex = 60;
			this.label12.Text = "x";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(940, 62);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 20);
			this.label13.TabIndex = 61;
			this.label13.Text = "x";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(940, 97);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(38, 20);
			this.label14.TabIndex = 62;
			this.label14.Text = "x";
			// 
			// cmbEngName
			// 
			this.cmbEngName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngName.FormattingEnabled = true;
			this.cmbEngName.Location = new System.Drawing.Point(427, 115);
			this.cmbEngName.Name = "cmbEngName";
			this.cmbEngName.Size = new System.Drawing.Size(456, 21);
			this.cmbEngName.TabIndex = 1;
			this.cmbEngName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CmbEngNameDrawItem);
			this.cmbEngName.SelectedIndexChanged += new System.EventHandler(this.CmbEngNameSelectedIndexChanged);
			this.cmbEngName.MouseHover += new System.EventHandler(this.CmbEngNameMouseHover);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(306, 150);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(110, 23);
			this.label21.TabIndex = 50;
			this.label21.Text = "Engagement Code:";
			// 
			// cmbEngCode
			// 
			this.cmbEngCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngCode.FormattingEnabled = true;
			this.cmbEngCode.Location = new System.Drawing.Point(689, 150);
			this.cmbEngCode.Name = "cmbEngCode";
			this.cmbEngCode.Size = new System.Drawing.Size(194, 21);
			this.cmbEngCode.TabIndex = 2;
			this.cmbEngCode.Visible = false;
			this.cmbEngCode.SelectedIndexChanged += new System.EventHandler(this.CmbEngCodeSelectedIndexChanged);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(306, 115);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(110, 23);
			this.label19.TabIndex = 49;
			this.label19.Text = "Engagement Name:";
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(125, 50);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(198, 23);
			this.label23.TabIndex = 46;
			this.label23.Text = "*: Fields with * are mandatory";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(553, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please fill in the following form to update the specific engagement\'s insfrastruc" +
			"ture:";
			// 
			// grdInfrastructure
			// 
			this.grdInfrastructure.AllowUserToAddRows = false;
			this.grdInfrastructure.AllowUserToDeleteRows = false;
			this.grdInfrastructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdInfrastructure.Location = new System.Drawing.Point(125, 492);
			this.grdInfrastructure.MultiSelect = false;
			this.grdInfrastructure.Name = "grdInfrastructure";
			this.grdInfrastructure.ReadOnly = true;
			this.grdInfrastructure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdInfrastructure.Size = new System.Drawing.Size(1055, 240);
			this.grdInfrastructure.TabIndex = 15;
			this.grdInfrastructure.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdInfrastructureCellClick);
			this.grdInfrastructure.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdInfrastructureCellContentClick);
			this.grdInfrastructure.SelectionChanged += new System.EventHandler(this.GrdInfrastructureSelectionChanged);
			// 
			// frmInfrastructure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmInfrastructure";
			this.Text = "frmInfrastructure";
			this.Load += new System.EventHandler(this.FrmInfrastructureLoad);
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS_DB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdInfrastructure)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtEngCode;
		private System.Windows.Forms.DataGridView grdDB;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtNo_DB_ID;
		private System.Windows.Forms.TextBox txtNo_OS_ID;
		private System.Windows.Forms.TextBox txtNo_OS_APP_ID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbOS_DB;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView grdOS;
		private System.Windows.Forms.DataGridView grdOS_DB;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.ComboBox cmbEngID;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbAppName;
		private System.Windows.Forms.ComboBox cmbOS;
		private System.Windows.Forms.ComboBox cmbDB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtVendor;
		private System.Windows.Forms.DataGridView grdInfrastructure;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox cmbEngCode;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox cmbEngName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel mainPanel;
		
		
		
		void CmbDBSelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void GrdInfrastructureCellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
		}
	}
}
