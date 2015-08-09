/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 7/18/2013
 * Time: 11:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmRateChange
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
			this.txtRateChange_ID = new System.Windows.Forms.TextBox();
			this.grdRateChange = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.cmbEmpName = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbNewLevel = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdRateChange)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.txtRateChange_ID);
			this.mainPanel.Controls.Add(this.grdRateChange);
			this.mainPanel.Controls.Add(this.label6);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// txtRateChange_ID
			// 
			this.txtRateChange_ID.Location = new System.Drawing.Point(1080, 29);
			this.txtRateChange_ID.Name = "txtRateChange_ID";
			this.txtRateChange_ID.Size = new System.Drawing.Size(100, 20);
			this.txtRateChange_ID.TabIndex = 28;
			this.txtRateChange_ID.Visible = false;
			// 
			// grdRateChange
			// 
			this.grdRateChange.AllowUserToAddRows = false;
			this.grdRateChange.AllowUserToDeleteRows = false;
			this.grdRateChange.AllowUserToOrderColumns = true;
			this.grdRateChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRateChange.Location = new System.Drawing.Point(125, 419);
			this.grdRateChange.MultiSelect = false;
			this.grdRateChange.Name = "grdRateChange";
			this.grdRateChange.ReadOnly = true;
			this.grdRateChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdRateChange.Size = new System.Drawing.Size(950, 291);
			this.grdRateChange.TabIndex = 8;
			this.grdRateChange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdRateChangeCellClick);
			this.grdRateChange.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdRateChangeDataBindingComplete);
			this.grdRateChange.SelectionChanged += new System.EventHandler(this.GrdRateChangeSelectionChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(125, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(198, 23);
			this.label6.TabIndex = 27;
			this.label6.Text = "*: Fields with * are mandatory";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpToDate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dtpFromDate);
			this.groupBox1.Controls.Add(this.cmbEmpName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbNewLevel);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(125, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 296);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rate Change";
			// 
			// dtpToDate
			// 
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpToDate.Location = new System.Drawing.Point(433, 165);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(94, 20);
			this.dtpToDate.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label3.Location = new System.Drawing.Point(292, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 19);
			this.label3.TabIndex = 9;
			this.label3.Text = "To Date (*):";
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(567, 216);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 49);
			this.btnDel.TabIndex = 7;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(424, 216);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 49);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(280, 216);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 49);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Clear";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(292, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee Name (*):";
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFromDate.Location = new System.Drawing.Point(433, 128);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(94, 20);
			this.dtpFromDate.TabIndex = 3;
			// 
			// cmbEmpName
			// 
			this.cmbEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEmpName.FormattingEnabled = true;
			this.cmbEmpName.Location = new System.Drawing.Point(433, 48);
			this.cmbEmpName.Name = "cmbEmpName";
			this.cmbEmpName.Size = new System.Drawing.Size(197, 21);
			this.cmbEmpName.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label5.Location = new System.Drawing.Point(292, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(135, 19);
			this.label5.TabIndex = 7;
			this.label5.Text = "From Date (*):";
			// 
			// cmbNewLevel
			// 
			this.cmbNewLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNewLevel.FormattingEnabled = true;
			this.cmbNewLevel.Location = new System.Drawing.Point(433, 89);
			this.cmbNewLevel.Name = "cmbNewLevel";
			this.cmbNewLevel.Size = new System.Drawing.Size(197, 21);
			this.cmbNewLevel.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label4.Location = new System.Drawing.Point(292, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 19);
			this.label4.TabIndex = 5;
			this.label4.Text = "New Level (*):";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(431, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select a member and update the new rate for this member:";
			// 
			// frmRateChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmRateChange";
			this.Text = "frmRateChange";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdRateChange)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.TextBox txtRateChange_ID;
		private System.Windows.Forms.DataGridView grdRateChange;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbEmpName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbNewLevel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel mainPanel;
	}
}
