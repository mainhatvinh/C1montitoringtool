/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 12:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmC2Booking
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
			this.label5 = new System.Windows.Forms.Label();
			this.cmbEngName = new System.Windows.Forms.ComboBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.grdBooking = new System.Windows.Forms.DataGridView();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbEngCode = new System.Windows.Forms.ComboBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.txtEngCode = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grd4 = new System.Windows.Forms.DataGridView();
			this.grd3 = new System.Windows.Forms.DataGridView();
			this.grd2 = new System.Windows.Forms.DataGridView();
			this.grd1 = new System.Windows.Forms.DataGridView();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.cmbEngID = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdBooking)).BeginInit();
			this.mainPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grd3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(125, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 23);
			this.label5.TabIndex = 25;
			this.label5.Text = "*: Fields with * are mandatory";
			// 
			// cmbEngName
			// 
			this.cmbEngName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngName.FormattingEnabled = true;
			this.cmbEngName.Location = new System.Drawing.Point(429, 152);
			this.cmbEngName.Name = "cmbEngName";
			this.cmbEngName.Size = new System.Drawing.Size(456, 21);
			this.cmbEngName.TabIndex = 1;
			this.cmbEngName.SelectedIndexChanged += new System.EventHandler(this.CmbEngNameSelectedIndexChanged);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(440, 375);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 51);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// grdBooking
			// 
			this.grdBooking.AllowUserToAddRows = false;
			this.grdBooking.AllowUserToDeleteRows = false;
			this.grdBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBooking.Location = new System.Drawing.Point(31, 41);
			this.grdBooking.MultiSelect = false;
			this.grdBooking.Name = "grdBooking";
			this.grdBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdBooking.Size = new System.Drawing.Size(884, 310);
			this.grdBooking.TabIndex = 5;
			this.grdBooking.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdBookingCellMouseDoubleClick);
			this.grdBooking.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdBookingCellValueChanged);
			this.grdBooking.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdBookingColumnAdded);
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFromDate.Location = new System.Drawing.Point(429, 217);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(210, 20);
			this.dtpFromDate.TabIndex = 3;
			this.dtpFromDate.Value = new System.DateTime(2014, 7, 8, 0, 0, 0, 0);
			this.dtpFromDate.ValueChanged += new System.EventHandler(this.DtpDateValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(306, 221);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "From Date (*):";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(306, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Engagement Code:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(306, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Engagement Name:";
			// 
			// cmbEngCode
			// 
			this.cmbEngCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngCode.FormattingEnabled = true;
			this.cmbEngCode.Location = new System.Drawing.Point(714, 185);
			this.cmbEngCode.Name = "cmbEngCode";
			this.cmbEngCode.Size = new System.Drawing.Size(219, 21);
			this.cmbEngCode.TabIndex = 2;
			this.cmbEngCode.Visible = false;
			this.cmbEngCode.SelectedIndexChanged += new System.EventHandler(this.CmbEngCodeSelectedIndexChanged);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.txtEngCode);
			this.mainPanel.Controls.Add(this.button1);
			this.mainPanel.Controls.Add(this.label7);
			this.mainPanel.Controls.Add(this.comboBox1);
			this.mainPanel.Controls.Add(this.cmbYear);
			this.mainPanel.Controls.Add(this.label4);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.grd4);
			this.mainPanel.Controls.Add(this.label2);
			this.mainPanel.Controls.Add(this.dtpFromDate);
			this.mainPanel.Controls.Add(this.grd3);
			this.mainPanel.Controls.Add(this.grd2);
			this.mainPanel.Controls.Add(this.grd1);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.cmbEngID);
			this.mainPanel.Controls.Add(this.label13);
			this.mainPanel.Controls.Add(this.label5);
			this.mainPanel.Controls.Add(this.cmbEngCode);
			this.mainPanel.Controls.Add(this.cmbEngName);
			this.mainPanel.Controls.Add(this.label3);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 1;
			// 
			// txtEngCode
			// 
			this.txtEngCode.Location = new System.Drawing.Point(429, 185);
			this.txtEngCode.Name = "txtEngCode";
			this.txtEngCode.ReadOnly = true;
			this.txtEngCode.Size = new System.Drawing.Size(153, 20);
			this.txtEngCode.TabIndex = 39;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(905, 151);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(47, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "View";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(306, 87);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 24);
			this.label7.TabIndex = 38;
			this.label7.Text = "Engagement Type:";
			this.label7.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Channel 2"});
			this.comboBox1.Location = new System.Drawing.Point(429, 84);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.Visible = false;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
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
			this.cmbYear.Location = new System.Drawing.Point(429, 119);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 21);
			this.cmbYear.TabIndex = 8;
			this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYearSelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(306, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 23);
			this.label4.TabIndex = 33;
			this.label4.Text = "Fiscal year:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grdBooking);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Location = new System.Drawing.Point(125, 249);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 451);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Booking";
			// 
			// grd4
			// 
			this.grd4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd4.Location = new System.Drawing.Point(971, 71);
			this.grd4.MultiSelect = false;
			this.grd4.Name = "grd4";
			this.grd4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd4.Size = new System.Drawing.Size(209, 83);
			this.grd4.TabIndex = 31;
			this.grd4.Visible = false;
			// 
			// grd3
			// 
			this.grd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd3.Location = new System.Drawing.Point(574, 12);
			this.grd3.MultiSelect = false;
			this.grd3.Name = "grd3";
			this.grd3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd3.Size = new System.Drawing.Size(152, 80);
			this.grd3.TabIndex = 30;
			this.grd3.Visible = false;
			// 
			// grd2
			// 
			this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd2.Location = new System.Drawing.Point(971, 160);
			this.grd2.MultiSelect = false;
			this.grd2.Name = "grd2";
			this.grd2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd2.Size = new System.Drawing.Size(209, 82);
			this.grd2.TabIndex = 29;
			this.grd2.Visible = false;
			// 
			// grd1
			// 
			this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd1.Location = new System.Drawing.Point(745, 12);
			this.grd1.MultiSelect = false;
			this.grd1.Name = "grd1";
			this.grd1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd1.Size = new System.Drawing.Size(207, 80);
			this.grd1.TabIndex = 28;
			this.grd1.Visible = false;
			// 
			// grdTemp
			// 
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(980, 12);
			this.grdTemp.MultiSelect = false;
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdTemp.Size = new System.Drawing.Size(209, 53);
			this.grdTemp.TabIndex = 8;
			this.grdTemp.Visible = false;
			// 
			// cmbEngID
			// 
			this.cmbEngID.FormattingEnabled = true;
			this.cmbEngID.Location = new System.Drawing.Point(983, 3);
			this.cmbEngID.Name = "cmbEngID";
			this.cmbEngID.Size = new System.Drawing.Size(206, 21);
			this.cmbEngID.TabIndex = 27;
			this.cmbEngID.Visible = false;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label13.Location = new System.Drawing.Point(125, 30);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(651, 23);
			this.label13.TabIndex = 26;
			this.label13.Text = "Please fill in the following form to perform booking:";
			// 
			// frmC2Booking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmC2Booking";
			this.Text = "Booking";
			((System.ComponentModel.ISupportInitialize)(this.grdBooking)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtEngCode;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grd1;
		private System.Windows.Forms.DataGridView grd2;
		private System.Windows.Forms.DataGridView grd3;
		private System.Windows.Forms.DataGridView grd4;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.ComboBox cmbEngID;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.ComboBox cmbEngCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView grdBooking;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.ComboBox cmbEngName;
		private System.Windows.Forms.Label label5;
	}
}
