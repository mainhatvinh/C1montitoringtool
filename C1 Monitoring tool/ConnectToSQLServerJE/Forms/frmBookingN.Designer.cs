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
	partial class frmBookingN
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
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbEngCode = new System.Windows.Forms.ComboBox();
			this.mainPanel = new System.Windows.Forms.Panel();
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
			this.cmbEngName.Location = new System.Drawing.Point(429, 93);
			this.cmbEngName.Name = "cmbEngName";
			this.cmbEngName.Size = new System.Drawing.Size(456, 21);
			this.cmbEngName.TabIndex = 1;
			this.cmbEngName.SelectedIndexChanged += new System.EventHandler(this.CmbEngNameSelectedIndexChanged);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(440, 404);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 51);
			this.btnSubmit.TabIndex = 4;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// grdBooking
			// 
			this.grdBooking.AllowUserToAddRows = false;
			this.grdBooking.AllowUserToDeleteRows = false;
			this.grdBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBooking.Location = new System.Drawing.Point(31, 68);
			this.grdBooking.MultiSelect = false;
			this.grdBooking.Name = "grdBooking";
			this.grdBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdBooking.Size = new System.Drawing.Size(884, 310);
			this.grdBooking.TabIndex = 5;
			this.grdBooking.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdBookingCellMouseDoubleClick);
			this.grdBooking.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdBookingCellValueChanged);
			this.grdBooking.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdBookingColumnAdded);
			// 
			// dtpDate
			// 
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(429, 158);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(210, 20);
			this.dtpDate.TabIndex = 3;
			this.dtpDate.Value = new System.DateTime(2013, 6, 19, 0, 0, 0, 0);
			this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDateValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(306, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "From Date (*):";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(306, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Engagement Code:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(306, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Engagement Name:";
			// 
			// cmbEngCode
			// 
			this.cmbEngCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEngCode.FormattingEnabled = true;
			this.cmbEngCode.Location = new System.Drawing.Point(429, 126);
			this.cmbEngCode.Name = "cmbEngCode";
			this.cmbEngCode.Size = new System.Drawing.Size(456, 21);
			this.cmbEngCode.TabIndex = 2;
			this.cmbEngCode.SelectedIndexChanged += new System.EventHandler(this.CmbEngCodeSelectedIndexChanged);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.grd4);
			this.mainPanel.Controls.Add(this.label2);
			this.mainPanel.Controls.Add(this.dtpDate);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grdBooking);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Location = new System.Drawing.Point(125, 207);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 493);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Booking";
			// 
			// grd4
			// 
			this.grd4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd4.Location = new System.Drawing.Point(891, 124);
			this.grd4.MultiSelect = false;
			this.grd4.Name = "grd4";
			this.grd4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd4.Size = new System.Drawing.Size(176, 80);
			this.grd4.TabIndex = 31;
			this.grd4.Visible = false;
			// 
			// grd3
			// 
			this.grd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd3.Location = new System.Drawing.Point(660, 0);
			this.grd3.MultiSelect = false;
			this.grd3.Name = "grd3";
			this.grd3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd3.Size = new System.Drawing.Size(72, 80);
			this.grd3.TabIndex = 30;
			this.grd3.Visible = false;
			// 
			// grd2
			// 
			this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd2.Location = new System.Drawing.Point(1031, 17);
			this.grd2.MultiSelect = false;
			this.grd2.Name = "grd2";
			this.grd2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd2.Size = new System.Drawing.Size(155, 80);
			this.grd2.TabIndex = 29;
			this.grd2.Visible = false;
			// 
			// grd1
			// 
			this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd1.Location = new System.Drawing.Point(738, 0);
			this.grd1.MultiSelect = false;
			this.grd1.Name = "grd1";
			this.grd1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grd1.Size = new System.Drawing.Size(116, 80);
			this.grd1.TabIndex = 28;
			this.grd1.Visible = false;
			// 
			// grdTemp
			// 
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(891, 3);
			this.grdTemp.MultiSelect = false;
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdTemp.Size = new System.Drawing.Size(134, 94);
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
			// frmBookingN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmBookingN";
			this.Text = "Booking";
			((System.ComponentModel.ISupportInitialize)(this.grdBooking)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grd1;
		private System.Windows.Forms.DataGridView grd2;
		private System.Windows.Forms.DataGridView grd3;
		private System.Windows.Forms.DataGridView grd4;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.ComboBox cmbEngID;
		private System.Windows.Forms.DateTimePicker dtpDate;
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
