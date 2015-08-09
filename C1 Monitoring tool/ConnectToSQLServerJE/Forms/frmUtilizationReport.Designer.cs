/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/29/2013
 * Time: 6:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmUtilizationReport
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
			this.grdTemp2 = new System.Windows.Forms.DataGridView();
			this.grdTemp1 = new System.Windows.Forms.DataGridView();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.grdUtilization = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExport1 = new System.Windows.Forms.Button();
			this.label24 = new System.Windows.Forms.Label();
			this.radTargetH = new System.Windows.Forms.RadioButton();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset1 = new System.Windows.Forms.Button();
			this.radWTD = new System.Windows.Forms.RadioButton();
			this.radYear = new System.Windows.Forms.RadioButton();
			this.radMonth = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbName1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUtilization)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdTemp2);
			this.mainPanel.Controls.Add(this.grdTemp1);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.grdUtilization);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// grdTemp2
			// 
			this.grdTemp2.AllowUserToAddRows = false;
			this.grdTemp2.AllowUserToDeleteRows = false;
			this.grdTemp2.AllowUserToOrderColumns = true;
			this.grdTemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp2.Location = new System.Drawing.Point(700, 689);
			this.grdTemp2.MultiSelect = false;
			this.grdTemp2.Name = "grdTemp2";
			this.grdTemp2.ReadOnly = true;
			this.grdTemp2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp2.Size = new System.Drawing.Size(437, 115);
			this.grdTemp2.TabIndex = 21;
			this.grdTemp2.Visible = false;
			// 
			// grdTemp1
			// 
			this.grdTemp1.AllowUserToAddRows = false;
			this.grdTemp1.AllowUserToDeleteRows = false;
			this.grdTemp1.AllowUserToOrderColumns = true;
			this.grdTemp1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp1.Location = new System.Drawing.Point(700, 538);
			this.grdTemp1.MultiSelect = false;
			this.grdTemp1.Name = "grdTemp1";
			this.grdTemp1.ReadOnly = true;
			this.grdTemp1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp1.Size = new System.Drawing.Size(469, 142);
			this.grdTemp1.TabIndex = 20;
			this.grdTemp1.Visible = false;
			// 
			// grdTemp
			// 
			this.grdTemp.AllowUserToAddRows = false;
			this.grdTemp.AllowUserToDeleteRows = false;
			this.grdTemp.AllowUserToOrderColumns = true;
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(700, 381);
			this.grdTemp.MultiSelect = false;
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.ReadOnly = true;
			this.grdTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdTemp.Size = new System.Drawing.Size(469, 142);
			this.grdTemp.TabIndex = 19;
			this.grdTemp.Visible = false;
			// 
			// grdUtilization
			// 
			this.grdUtilization.AllowUserToAddRows = false;
			this.grdUtilization.AllowUserToDeleteRows = false;
			this.grdUtilization.AllowUserToOrderColumns = true;
			this.grdUtilization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdUtilization.Location = new System.Drawing.Point(29, 218);
			this.grdUtilization.MultiSelect = false;
			this.grdUtilization.Name = "grdUtilization";
			this.grdUtilization.ReadOnly = true;
			this.grdUtilization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdUtilization.Size = new System.Drawing.Size(1115, 543);
			this.grdUtilization.TabIndex = 18;
			this.grdUtilization.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUtilizationCellDoubleClick);
			this.grdUtilization.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdUtilizationColumnAdded);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExport1);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.radTargetH);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnReset1);
			this.groupBox1.Controls.Add(this.radWTD);
			this.groupBox1.Controls.Add(this.radYear);
			this.groupBox1.Controls.Add(this.radMonth);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtpToDate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbName1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(29, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1115, 184);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "To-Date Utilization Report";
			// 
			// btnExport1
			// 
			this.btnExport1.Location = new System.Drawing.Point(552, 133);
			this.btnExport1.Name = "btnExport1";
			this.btnExport1.Size = new System.Drawing.Size(85, 35);
			this.btnExport1.TabIndex = 7;
			this.btnExport1.Text = "Export to Excel";
			this.btnExport1.UseVisualStyleBackColor = true;
			this.btnExport1.Click += new System.EventHandler(this.BtnExport1Click);
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(682, 110);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(219, 23);
			this.label24.TabIndex = 61;
			this.label24.Text = "*Set \"To Date\" to Friday date before running";
			// 
			// radTargetH
			// 
			this.radTargetH.Location = new System.Drawing.Point(548, 88);
			this.radTargetH.Name = "radTargetH";
			this.radTargetH.Size = new System.Drawing.Size(116, 31);
			this.radTargetH.TabIndex = 12;
			this.radTargetH.Text = "Target Hours for Next Week";
			this.radTargetH.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
			this.btnSubmit.Location = new System.Drawing.Point(422, 133);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 35);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset1
			// 
			this.btnReset1.Location = new System.Drawing.Point(295, 133);
			this.btnReset1.Name = "btnReset1";
			this.btnReset1.Size = new System.Drawing.Size(85, 35);
			this.btnReset1.TabIndex = 5;
			this.btnReset1.Text = "Clear ";
			this.btnReset1.UseVisualStyleBackColor = true;
			this.btnReset1.Click += new System.EventHandler(this.BtnReset1Click);
			// 
			// radWTD
			// 
			this.radWTD.Location = new System.Drawing.Point(670, 91);
			this.radWTD.Name = "radWTD";
			this.radWTD.Size = new System.Drawing.Size(104, 24);
			this.radWTD.TabIndex = 11;
			this.radWTD.Text = "Week To Date";
			this.radWTD.UseVisualStyleBackColor = true;
			this.radWTD.CheckedChanged += new System.EventHandler(this.RadWTDCheckedChanged);
			// 
			// radYear
			// 
			this.radYear.Location = new System.Drawing.Point(418, 91);
			this.radYear.Name = "radYear";
			this.radYear.Size = new System.Drawing.Size(104, 24);
			this.radYear.TabIndex = 4;
			this.radYear.Text = "Year To Date";
			this.radYear.UseVisualStyleBackColor = true;
			// 
			// radMonth
			// 
			this.radMonth.Checked = true;
			this.radMonth.Location = new System.Drawing.Point(20, 52);
			this.radMonth.Name = "radMonth";
			this.radMonth.Size = new System.Drawing.Size(104, 24);
			this.radMonth.TabIndex = 3;
			this.radMonth.TabStop = true;
			this.radMonth.Text = "Month To Date";
			this.radMonth.UseVisualStyleBackColor = true;
			this.radMonth.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(295, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 25);
			this.label3.TabIndex = 10;
			this.label3.Text = "Type:";
			// 
			// dtpToDate
			// 
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpToDate.Location = new System.Drawing.Point(418, 56);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(223, 20);
			this.dtpToDate.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(295, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "To Date:";
			// 
			// cmbName1
			// 
			this.cmbName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName1.FormattingEnabled = true;
			this.cmbName1.Location = new System.Drawing.Point(418, 15);
			this.cmbName1.Name = "cmbName1";
			this.cmbName1.Size = new System.Drawing.Size(223, 21);
			this.cmbName1.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(295, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Employee Name:";
			// 
			// frmUtilizationReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmUtilizationReport";
			this.Text = "To-Date Utilization Report";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTemp2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUtilization)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.RadioButton radTargetH;
		private System.Windows.Forms.RadioButton radWTD;
		private System.Windows.Forms.DataGridView grdTemp2;
		private System.Windows.Forms.DataGridView grdTemp1;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.DataGridView grdUtilization;
		private System.Windows.Forms.Button btnReset1;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnExport1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radMonth;
		private System.Windows.Forms.RadioButton radYear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbName1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel mainPanel;
		
		
	}
}
