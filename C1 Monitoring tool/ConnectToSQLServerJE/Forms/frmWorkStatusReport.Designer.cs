/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/31/2013
 * Time: 6:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmWorkStatusReport
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
			this.grdWorkStatus = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExport1 = new System.Windows.Forms.Button();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.cmbName = new System.Windows.Forms.ComboBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWorkStatus)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdWorkStatus);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// grdWorkStatus
			// 
			this.grdWorkStatus.AllowUserToAddRows = false;
			this.grdWorkStatus.AllowUserToDeleteRows = false;
			this.grdWorkStatus.AllowUserToOrderColumns = true;
			this.grdWorkStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWorkStatus.Location = new System.Drawing.Point(125, 149);
			this.grdWorkStatus.MultiSelect = false;
			this.grdWorkStatus.Name = "grdWorkStatus";
			this.grdWorkStatus.ReadOnly = true;
			this.grdWorkStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdWorkStatus.Size = new System.Drawing.Size(950, 561);
			this.grdWorkStatus.TabIndex = 7;
			this.grdWorkStatus.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdWorkStatusColumnAdded);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnExport1);
			this.groupBox1.Controls.Add(this.cmbYear);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.cmbName);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(125, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 133);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Work Status Report";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(560, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(284, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(449, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 29);
			this.label4.TabIndex = 6;
			this.label4.Text = "Employee Name:";
			this.label4.Visible = false;
			// 
			// btnExport1
			// 
			this.btnExport1.Location = new System.Drawing.Point(513, 84);
			this.btnExport1.Name = "btnExport1";
			this.btnExport1.Size = new System.Drawing.Size(77, 34);
			this.btnExport1.TabIndex = 6;
			this.btnExport1.Text = "Export to Excel";
			this.btnExport1.UseVisualStyleBackColor = true;
			this.btnExport1.Click += new System.EventHandler(this.BtnExport1Click);
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
			this.cmbYear.Location = new System.Drawing.Point(306, 12);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(100, 21);
			this.cmbYear.TabIndex = 1;
			this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYearSelectedIndexChanged);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(408, 84);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(77, 34);
			this.btnSubmit.TabIndex = 5;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// cmbName
			// 
			this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName.FormattingEnabled = true;
			this.cmbName.Location = new System.Drawing.Point(306, 46);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(423, 21);
			this.cmbName.TabIndex = 3;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(306, 84);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(77, 34);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Clear ";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(195, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "Fiscal Year";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(195, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Engagement Name:";
			// 
			// frmWorkStatusReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmWorkStatusReport";
			this.Text = "Work Status Report";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdWorkStatus)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView grdWorkStatus;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnExport1;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel mainPanel;
	}
}
