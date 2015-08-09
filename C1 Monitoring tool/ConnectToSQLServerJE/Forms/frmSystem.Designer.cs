/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmSystem
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
			this.txtAppName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnReset1 = new System.Windows.Forms.Button();
			this.btnSubmit1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDB_Std_Hours = new System.Windows.Forms.TextBox();
			this.txtDBID = new System.Windows.Forms.TextBox();
			this.btnDel3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDBName = new System.Windows.Forms.TextBox();
			this.btnSubmit3 = new System.Windows.Forms.Button();
			this.btnReset3 = new System.Windows.Forms.Button();
			this.grdDB = new System.Windows.Forms.DataGridView();
			this.grdOS = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtOS_Std_Hours = new System.Windows.Forms.TextBox();
			this.txtOSID = new System.Windows.Forms.TextBox();
			this.btnDel2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtOSName = new System.Windows.Forms.TextBox();
			this.btnSubmit2 = new System.Windows.Forms.Button();
			this.btnReset2 = new System.Windows.Forms.Button();
			this.grdApp = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApp_Std_Hours = new System.Windows.Forms.TextBox();
			this.txtAppID = new System.Windows.Forms.TextBox();
			this.cmbAppType = new System.Windows.Forms.ComboBox();
			this.btnDel1 = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdApp)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtAppName
			// 
			this.txtAppName.Location = new System.Drawing.Point(127, 41);
			this.txtAppName.Name = "txtAppName";
			this.txtAppName.Size = new System.Drawing.Size(171, 20);
			this.txtAppName.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(19, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Type (*):";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Application Name (*):";
			// 
			// btnReset1
			// 
			this.btnReset1.Location = new System.Drawing.Point(14, 170);
			this.btnReset1.Name = "btnReset1";
			this.btnReset1.Size = new System.Drawing.Size(85, 52);
			this.btnReset1.TabIndex = 4;
			this.btnReset1.Text = "Clear Form";
			this.btnReset1.UseVisualStyleBackColor = true;
			this.btnReset1.Click += new System.EventHandler(this.BtnReset1Click);
			// 
			// btnSubmit1
			// 
			this.btnSubmit1.Location = new System.Drawing.Point(117, 170);
			this.btnSubmit1.Name = "btnSubmit1";
			this.btnSubmit1.Size = new System.Drawing.Size(85, 52);
			this.btnSubmit1.TabIndex = 5;
			this.btnSubmit1.Text = "Submit";
			this.btnSubmit1.UseVisualStyleBackColor = true;
			this.btnSubmit1.Click += new System.EventHandler(this.BtnSubmit1Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(65, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(614, 26);
			this.label6.TabIndex = 3;
			this.label6.Text = "Please fill the following forms to create a new app/OS/DB or update an existing a" +
			"pp/OS/DB:";
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.label11);
			this.mainPanel.Controls.Add(this.groupBox3);
			this.mainPanel.Controls.Add(this.grdDB);
			this.mainPanel.Controls.Add(this.grdOS);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Controls.Add(this.grdApp);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.label6);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(65, 50);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(198, 23);
			this.label11.TabIndex = 26;
			this.label11.Text = "*: Fields with * are mandatory";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txtDB_Std_Hours);
			this.groupBox3.Controls.Add(this.txtDBID);
			this.groupBox3.Controls.Add(this.btnDel3);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txtDBName);
			this.groupBox3.Controls.Add(this.btnSubmit3);
			this.groupBox3.Controls.Add(this.btnReset3);
			this.groupBox3.Location = new System.Drawing.Point(758, 90);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(319, 240);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Database";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(21, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "Std Hours:";
			this.label8.Visible = false;
			// 
			// txtDB_Std_Hours
			// 
			this.txtDB_Std_Hours.Location = new System.Drawing.Point(127, 120);
			this.txtDB_Std_Hours.Name = "txtDB_Std_Hours";
			this.txtDB_Std_Hours.Size = new System.Drawing.Size(171, 20);
			this.txtDB_Std_Hours.TabIndex = 13;
			this.txtDB_Std_Hours.Visible = false;
			// 
			// txtDBID
			// 
			this.txtDBID.Location = new System.Drawing.Point(116, 29);
			this.txtDBID.Name = "txtDBID";
			this.txtDBID.Size = new System.Drawing.Size(171, 20);
			this.txtDBID.TabIndex = 17;
			this.txtDBID.Visible = false;
			// 
			// btnDel3
			// 
			this.btnDel3.Location = new System.Drawing.Point(217, 170);
			this.btnDel3.Name = "btnDel3";
			this.btnDel3.Size = new System.Drawing.Size(85, 52);
			this.btnDel3.TabIndex = 16;
			this.btnDel3.Text = "Delete";
			this.btnDel3.UseVisualStyleBackColor = true;
			this.btnDel3.Click += new System.EventHandler(this.BtnDel3Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "DB Name (*):";
			// 
			// txtDBName
			// 
			this.txtDBName.Location = new System.Drawing.Point(127, 41);
			this.txtDBName.Name = "txtDBName";
			this.txtDBName.Size = new System.Drawing.Size(171, 20);
			this.txtDBName.TabIndex = 12;
			// 
			// btnSubmit3
			// 
			this.btnSubmit3.Location = new System.Drawing.Point(117, 170);
			this.btnSubmit3.Name = "btnSubmit3";
			this.btnSubmit3.Size = new System.Drawing.Size(85, 52);
			this.btnSubmit3.TabIndex = 15;
			this.btnSubmit3.Text = "Submit";
			this.btnSubmit3.UseVisualStyleBackColor = true;
			this.btnSubmit3.Click += new System.EventHandler(this.BtnSubmit3Click);
			// 
			// btnReset3
			// 
			this.btnReset3.Location = new System.Drawing.Point(17, 170);
			this.btnReset3.Name = "btnReset3";
			this.btnReset3.Size = new System.Drawing.Size(85, 52);
			this.btnReset3.TabIndex = 14;
			this.btnReset3.Text = "Clear Form";
			this.btnReset3.UseVisualStyleBackColor = true;
			this.btnReset3.Click += new System.EventHandler(this.BtnReset3Click);
			// 
			// grdDB
			// 
			this.grdDB.AllowUserToAddRows = false;
			this.grdDB.AllowUserToDeleteRows = false;
			this.grdDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDB.Location = new System.Drawing.Point(758, 348);
			this.grdDB.MultiSelect = false;
			this.grdDB.Name = "grdDB";
			this.grdDB.ReadOnly = true;
			this.grdDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDB.Size = new System.Drawing.Size(319, 343);
			this.grdDB.TabIndex = 19;
			this.grdDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDBCellClick);
			this.grdDB.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdDBDataBindingComplete);
			this.grdDB.SelectionChanged += new System.EventHandler(this.GrdDBSelectionChanged);
			this.grdDB.Sorted += new System.EventHandler(this.GrdDBSorted);
			// 
			// grdOS
			// 
			this.grdOS.AllowUserToAddRows = false;
			this.grdOS.AllowUserToDeleteRows = false;
			this.grdOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdOS.Location = new System.Drawing.Point(412, 348);
			this.grdOS.MultiSelect = false;
			this.grdOS.Name = "grdOS";
			this.grdOS.ReadOnly = true;
			this.grdOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdOS.Size = new System.Drawing.Size(319, 343);
			this.grdOS.TabIndex = 18;
			this.grdOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOSCellClick);
			this.grdOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdOSDataBindingComplete);
			this.grdOS.SelectionChanged += new System.EventHandler(this.GrdOSSelectionChanged);
			this.grdOS.Sorted += new System.EventHandler(this.GrdOSSorted);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtOS_Std_Hours);
			this.groupBox2.Controls.Add(this.txtOSID);
			this.groupBox2.Controls.Add(this.btnDel2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtOSName);
			this.groupBox2.Controls.Add(this.btnSubmit2);
			this.groupBox2.Controls.Add(this.btnReset2);
			this.groupBox2.Location = new System.Drawing.Point(412, 90);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(319, 240);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Operating System";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Std Hours:";
			this.label7.Visible = false;
			// 
			// txtOS_Std_Hours
			// 
			this.txtOS_Std_Hours.Location = new System.Drawing.Point(127, 123);
			this.txtOS_Std_Hours.Name = "txtOS_Std_Hours";
			this.txtOS_Std_Hours.Size = new System.Drawing.Size(171, 20);
			this.txtOS_Std_Hours.TabIndex = 8;
			this.txtOS_Std_Hours.Visible = false;
			// 
			// txtOSID
			// 
			this.txtOSID.Location = new System.Drawing.Point(116, 29);
			this.txtOSID.Name = "txtOSID";
			this.txtOSID.Size = new System.Drawing.Size(171, 20);
			this.txtOSID.TabIndex = 12;
			this.txtOSID.Visible = false;
			// 
			// btnDel2
			// 
			this.btnDel2.Location = new System.Drawing.Point(218, 170);
			this.btnDel2.Name = "btnDel2";
			this.btnDel2.Size = new System.Drawing.Size(85, 52);
			this.btnDel2.TabIndex = 11;
			this.btnDel2.Text = "Delete";
			this.btnDel2.UseVisualStyleBackColor = true;
			this.btnDel2.Click += new System.EventHandler(this.BtnDel2Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "OS Name (*):";
			// 
			// txtOSName
			// 
			this.txtOSName.Location = new System.Drawing.Point(127, 41);
			this.txtOSName.Name = "txtOSName";
			this.txtOSName.Size = new System.Drawing.Size(171, 20);
			this.txtOSName.TabIndex = 7;
			// 
			// btnSubmit2
			// 
			this.btnSubmit2.Location = new System.Drawing.Point(117, 170);
			this.btnSubmit2.Name = "btnSubmit2";
			this.btnSubmit2.Size = new System.Drawing.Size(85, 52);
			this.btnSubmit2.TabIndex = 10;
			this.btnSubmit2.Text = "Submit";
			this.btnSubmit2.UseVisualStyleBackColor = true;
			this.btnSubmit2.Click += new System.EventHandler(this.BtnSubmit2Click);
			// 
			// btnReset2
			// 
			this.btnReset2.Location = new System.Drawing.Point(16, 170);
			this.btnReset2.Name = "btnReset2";
			this.btnReset2.Size = new System.Drawing.Size(85, 52);
			this.btnReset2.TabIndex = 9;
			this.btnReset2.Text = "Clear Form";
			this.btnReset2.UseVisualStyleBackColor = true;
			this.btnReset2.Click += new System.EventHandler(this.BtnReset2Click);
			// 
			// grdApp
			// 
			this.grdApp.AllowUserToAddRows = false;
			this.grdApp.AllowUserToDeleteRows = false;
			this.grdApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdApp.Location = new System.Drawing.Point(65, 348);
			this.grdApp.MultiSelect = false;
			this.grdApp.Name = "grdApp";
			this.grdApp.ReadOnly = true;
			this.grdApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdApp.Size = new System.Drawing.Size(319, 343);
			this.grdApp.TabIndex = 17;
			this.grdApp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdAppCellClick);
			this.grdApp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdAppDataBindingComplete);
			this.grdApp.SelectionChanged += new System.EventHandler(this.GrdAppSelectionChanged);
			this.grdApp.Sorted += new System.EventHandler(this.GrdAppSorted);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtApp_Std_Hours);
			this.groupBox1.Controls.Add(this.txtAppName);
			this.groupBox1.Controls.Add(this.txtAppID);
			this.groupBox1.Controls.Add(this.cmbAppType);
			this.groupBox1.Controls.Add(this.btnDel1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnSubmit1);
			this.groupBox1.Controls.Add(this.btnReset1);
			this.groupBox1.Location = new System.Drawing.Point(65, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(319, 240);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Application";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Std Hours:";
			this.label2.Visible = false;
			// 
			// txtApp_Std_Hours
			// 
			this.txtApp_Std_Hours.Location = new System.Drawing.Point(128, 126);
			this.txtApp_Std_Hours.Name = "txtApp_Std_Hours";
			this.txtApp_Std_Hours.Size = new System.Drawing.Size(171, 20);
			this.txtApp_Std_Hours.TabIndex = 3;
			this.txtApp_Std_Hours.Visible = false;
			// 
			// txtAppID
			// 
			this.txtAppID.Location = new System.Drawing.Point(116, 29);
			this.txtAppID.Name = "txtAppID";
			this.txtAppID.Size = new System.Drawing.Size(171, 20);
			this.txtAppID.TabIndex = 7;
			this.txtAppID.Visible = false;
			// 
			// cmbAppType
			// 
			this.cmbAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAppType.FormattingEnabled = true;
			this.cmbAppType.Items.AddRange(new object[] {
									"ERP",
									"Core Banking",
									"Accounting",
									"Supply Chain Management",
									"Customer Relationship Management",
									"Supplier Relationship Management",
									"HR - Payroll",
									"Securities application",
									"Others"});
			this.cmbAppType.Location = new System.Drawing.Point(128, 87);
			this.cmbAppType.Name = "cmbAppType";
			this.cmbAppType.Size = new System.Drawing.Size(171, 21);
			this.cmbAppType.TabIndex = 2;
			// 
			// btnDel1
			// 
			this.btnDel1.Location = new System.Drawing.Point(219, 170);
			this.btnDel1.Name = "btnDel1";
			this.btnDel1.Size = new System.Drawing.Size(85, 52);
			this.btnDel1.TabIndex = 6;
			this.btnDel1.Text = "Delete";
			this.btnDel1.UseVisualStyleBackColor = true;
			this.btnDel1.Click += new System.EventHandler(this.BtnDel1Click);
			// 
			// frmSystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmSystem";
			this.Text = "System";
			this.mainPanel.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdApp)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtDB_Std_Hours;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtOS_Std_Hours;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtApp_Std_Hours;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtAppID;
		private System.Windows.Forms.TextBox txtOSID;
		private System.Windows.Forms.TextBox txtDBID;
		private System.Windows.Forms.ComboBox cmbAppType;
		private System.Windows.Forms.Button btnReset2;
		private System.Windows.Forms.Button btnSubmit2;
		private System.Windows.Forms.TextBox txtOSName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView grdOS;
		private System.Windows.Forms.Button btnDel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnReset3;
		private System.Windows.Forms.Button btnSubmit3;
		private System.Windows.Forms.TextBox txtDBName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView grdDB;
		private System.Windows.Forms.Button btnDel3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView grdApp;
		private System.Windows.Forms.Button btnDel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtAppName;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSubmit1;
		private System.Windows.Forms.Button btnReset1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}
