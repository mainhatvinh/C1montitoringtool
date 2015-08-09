/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/31/2013
 * Time: 6:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmRevenueWeeklyReport
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
			this.grdRevenue = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label24 = new System.Windows.Forms.Label();
			this.cmbCaculate = new System.Windows.Forms.Button();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExport1 = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdRevenue);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.btnReset);
			this.mainPanel.Controls.Add(this.comboBox1);
			this.mainPanel.Controls.Add(this.dtpDate);
			this.mainPanel.Controls.Add(this.label2);
			this.mainPanel.Controls.Add(this.label3);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// grdRevenue
			// 
			this.grdRevenue.AllowUserToAddRows = false;
			this.grdRevenue.AllowUserToDeleteRows = false;
			this.grdRevenue.AllowUserToOrderColumns = true;
			this.grdRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRevenue.Location = new System.Drawing.Point(12, 146);
			this.grdRevenue.MultiSelect = false;
			this.grdRevenue.Name = "grdRevenue";
			this.grdRevenue.ReadOnly = true;
			this.grdRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdRevenue.Size = new System.Drawing.Size(1168, 658);
			this.grdRevenue.TabIndex = 6;
			this.grdRevenue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdRevenueCellDoubleClick);
			this.grdRevenue.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdRevenueColumnAdded);
			this.grdRevenue.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdRevenueColumnSortModeChanged);
			this.grdRevenue.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdRevenueDataBindingComplete);
			this.grdRevenue.Sorted += new System.EventHandler(this.GrdRevenueSorted);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.cmbCaculate);
			this.groupBox1.Controls.Add(this.dtpToDate);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.cmbYear);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnExport1);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1168, 128);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Revenue Report";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(683, 51);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(223, 23);
			this.label24.TabIndex = 62;
			this.label24.Text = "*Set \"To Date\" to Friday date before running";
			// 
			// cmbCaculate
			// 
			this.cmbCaculate.Location = new System.Drawing.Point(913, 18);
			this.cmbCaculate.Name = "cmbCaculate";
			this.cmbCaculate.Size = new System.Drawing.Size(77, 29);
			this.cmbCaculate.TabIndex = 35;
			this.cmbCaculate.Text = "Caculate";
			this.cmbCaculate.UseVisualStyleBackColor = true;
			this.cmbCaculate.Click += new System.EventHandler(this.CmbCaculateClick);
			// 
			// dtpToDate
			// 
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpToDate.Location = new System.Drawing.Point(454, 51);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(223, 20);
			this.dtpToDate.TabIndex = 33;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(383, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 34;
			this.label6.Text = "To Date:";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(741, 53);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 27;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Detail";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Visible = false;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(642, 53);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 26;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Summary";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Visible = false;
			// 
			// cmbYear
			// 
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Items.AddRange(new object[] {
									"2015",
									"2016",
									"2017",
									"2018",
									"2019",
									"2020"});
			this.cmbYear.Location = new System.Drawing.Point(454, 18);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(78, 21);
			this.cmbYear.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(383, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "Fiscal_Year";
			// 
			// btnExport1
			// 
			this.btnExport1.Location = new System.Drawing.Point(690, 83);
			this.btnExport1.Name = "btnExport1";
			this.btnExport1.Size = new System.Drawing.Size(70, 29);
			this.btnExport1.TabIndex = 3;
			this.btnExport1.Text = "Export";
			this.btnExport1.UseVisualStyleBackColor = true;
			this.btnExport1.Click += new System.EventHandler(this.BtnExport1Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(446, 85);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(77, 29);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(1081, 87);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(77, 39);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.Enabled = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(951, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(204, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Visible = false;
			// 
			// dtpDate
			// 
			this.dtpDate.Enabled = false;
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(951, 43);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 2;
			this.dtpDate.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(807, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Engagement Name:";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(807, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date:";
			this.label3.Visible = false;
			// 
			// frmRevenueWeeklyReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmRevenueWeeklyReport";
			this.Text = "Revenue Report";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button cmbCaculate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnExport1;
		private System.Windows.Forms.DataGridView grdRevenue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel mainPanel;
	}
}
