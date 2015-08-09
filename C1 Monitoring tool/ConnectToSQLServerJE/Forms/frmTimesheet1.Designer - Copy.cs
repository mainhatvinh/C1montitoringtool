/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/21/2013
 * Time: 3:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmTimesheet1
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
			this.label1 = new System.Windows.Forms.Label();
			this.chkLogin = new System.Windows.Forms.CheckBox();
			this.pgb1 = new System.Windows.Forms.ProgressBar();
			this.grdWeekEnd = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbY2D = new System.Windows.Forms.RadioButton();
			this.rdb13Ws = new System.Windows.Forms.RadioButton();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.grdTimesheet = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWeekEnd)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTimesheet)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.chkLogin);
			this.mainPanel.Controls.Add(this.pgb1);
			this.mainPanel.Controls.Add(this.grdWeekEnd);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Controls.Add(this.btnSubmit);
			this.mainPanel.Controls.Add(this.btnReset);
			this.mainPanel.Controls.Add(this.grdTimesheet);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(494, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Please select an option to import Timesheet from Global Time and Expense:";
			// 
			// chkLogin
			// 
			this.chkLogin.Location = new System.Drawing.Point(249, 206);
			this.chkLogin.Name = "chkLogin";
			this.chkLogin.Size = new System.Drawing.Size(92, 24);
			this.chkLogin.TabIndex = 14;
			this.chkLogin.Text = "Manual Login";
			this.chkLogin.UseVisualStyleBackColor = true;
			this.chkLogin.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// pgb1
			// 
			this.pgb1.Location = new System.Drawing.Point(125, 431);
			this.pgb1.Name = "pgb1";
			this.pgb1.Size = new System.Drawing.Size(680, 28);
			this.pgb1.TabIndex = 13;
			this.pgb1.Visible = false;
			// 
			// grdWeekEnd
			// 
			this.grdWeekEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWeekEnd.Location = new System.Drawing.Point(874, 117);
			this.grdWeekEnd.MultiSelect = false;
			this.grdWeekEnd.Name = "grdWeekEnd";
			this.grdWeekEnd.ReadOnly = true;
			this.grdWeekEnd.Size = new System.Drawing.Size(229, 493);
			this.grdWeekEnd.TabIndex = 12;
			this.grdWeekEnd.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbY2D);
			this.groupBox2.Controls.Add(this.rdb13Ws);
			this.groupBox2.Location = new System.Drawing.Point(243, 117);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(400, 70);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Option";
			// 
			// rdbY2D
			// 
			this.rdbY2D.Location = new System.Drawing.Point(248, 33);
			this.rdbY2D.Name = "rdbY2D";
			this.rdbY2D.Size = new System.Drawing.Size(104, 24);
			this.rdbY2D.TabIndex = 10;
			this.rdbY2D.Text = "Year to Date";
			this.rdbY2D.UseVisualStyleBackColor = true;
			// 
			// rdb13Ws
			// 
			this.rdb13Ws.Checked = true;
			this.rdb13Ws.Location = new System.Drawing.Point(63, 33);
			this.rdb13Ws.Name = "rdb13Ws";
			this.rdb13Ws.Size = new System.Drawing.Size(104, 24);
			this.rdb13Ws.TabIndex = 9;
			this.rdb13Ws.TabStop = true;
			this.rdb13Ws.Text = "13 Weeks";
			this.rdb13Ws.UseVisualStyleBackColor = true;
			this.rdb13Ws.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(470, 358);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(89, 46);
			this.btnSubmit.TabIndex = 7;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(312, 358);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(89, 46);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Clear";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// grdTimesheet
			// 
			this.grdTimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTimesheet.Location = new System.Drawing.Point(125, 431);
			this.grdTimesheet.MultiSelect = false;
			this.grdTimesheet.Name = "grdTimesheet";
			this.grdTimesheet.ReadOnly = true;
			this.grdTimesheet.Size = new System.Drawing.Size(680, 285);
			this.grdTimesheet.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPwd);
			this.groupBox1.Controls.Add(this.txtUser);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(243, 212);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 131);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(185, 91);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(138, 20);
			this.txtPwd.TabIndex = 4;
			this.txtPwd.UseSystemPasswordChar = true;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(185, 36);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(138, 20);
			this.txtUser.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(65, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(65, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "User name:";
			// 
			// frmTimesheet1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmTimesheet1";
			this.Text = "Timesheet";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdWeekEnd)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTimesheet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkLogin;
		private System.Windows.Forms.ProgressBar pgb1;
		private System.Windows.Forms.DataGridView grdWeekEnd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdb13Ws;
		private System.Windows.Forms.RadioButton rdbY2D;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.DataGridView grdTimesheet;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Panel mainPanel;
	}
}
