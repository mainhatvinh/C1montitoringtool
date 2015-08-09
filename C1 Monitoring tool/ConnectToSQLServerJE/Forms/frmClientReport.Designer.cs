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
	partial class frmClientReport
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnExport1 = new System.Windows.Forms.Button();
			this.grdClient = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.dataGridView1);
			this.mainPanel.Controls.Add(this.btnExport1);
			this.mainPanel.Controls.Add(this.grdClient);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(906, 180);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(241, 361);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.Visible = false;
			// 
			// btnExport1
			// 
			this.btnExport1.Location = new System.Drawing.Point(998, 716);
			this.btnExport1.Name = "btnExport1";
			this.btnExport1.Size = new System.Drawing.Size(77, 39);
			this.btnExport1.TabIndex = 6;
			this.btnExport1.Text = "Export";
			this.btnExport1.UseVisualStyleBackColor = true;
			this.btnExport1.Click += new System.EventHandler(this.BtnExport1Click);
			// 
			// grdClient
			// 
			this.grdClient.AllowUserToAddRows = false;
			this.grdClient.AllowUserToDeleteRows = false;
			this.grdClient.AllowUserToOrderColumns = true;
			this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClient.Location = new System.Drawing.Point(125, 180);
			this.grdClient.MultiSelect = false;
			this.grdClient.Name = "grdClient";
			this.grdClient.ReadOnly = true;
			this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdClient.Size = new System.Drawing.Size(950, 530);
			this.grdClient.TabIndex = 7;
			this.grdClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientCellDoubleClick);
			this.grdClient.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GrdWorkStatusColumnAdded);
			this.grdClient.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GrdClientRowPostPaint);
			this.grdClient.Sorted += new System.EventHandler(this.GrdClientSorted);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbYear);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(125, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 131);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Client Report";
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
			this.cmbYear.Location = new System.Drawing.Point(404, 19);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(100, 21);
			this.cmbYear.TabIndex = 1;
			this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYearSelectedIndexChanged);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(363, 60);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(77, 39);
			this.btnSubmit.TabIndex = 5;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(291, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "EY Fiscal Year:";
			// 
			// frmClientReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmClientReport";
			this.Text = "Client Report";
			this.Activated += new System.EventHandler(this.FrmClientReportActivated);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView grdClient;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnExport1;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel mainPanel;
	}
}
