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
	partial class frmInformation
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
			this.grdOS = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtOSID = new System.Windows.Forms.TextBox();
			this.btnDel2 = new System.Windows.Forms.Button();
			this.txtInformation = new System.Windows.Forms.TextBox();
			this.btnSubmit2 = new System.Windows.Forms.Button();
			this.btnReset2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdOS);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 4;
			// 
			// grdOS
			// 
			this.grdOS.AllowUserToAddRows = false;
			this.grdOS.AllowUserToDeleteRows = false;
			this.grdOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
			this.grdOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdOS.Location = new System.Drawing.Point(42, 439);
			this.grdOS.MultiSelect = false;
			this.grdOS.Name = "grdOS";
			this.grdOS.ReadOnly = true;
			this.grdOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdOS.Size = new System.Drawing.Size(847, 246);
			this.grdOS.TabIndex = 5;
			this.grdOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOSCellClick);
			this.grdOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdOSDataBindingComplete);
			this.grdOS.SelectionChanged += new System.EventHandler(this.GrdOSSelectionChanged);
			this.grdOS.Sorted += new System.EventHandler(this.GrdOSSorted);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtOSID);
			this.groupBox2.Controls.Add(this.btnDel2);
			this.groupBox2.Controls.Add(this.txtInformation);
			this.groupBox2.Controls.Add(this.btnSubmit2);
			this.groupBox2.Controls.Add(this.btnReset2);
			this.groupBox2.Location = new System.Drawing.Point(42, 29);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(847, 410);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			// 
			// txtOSID
			// 
			this.txtOSID.Location = new System.Drawing.Point(117, 15);
			this.txtOSID.Name = "txtOSID";
			this.txtOSID.Size = new System.Drawing.Size(136, 20);
			this.txtOSID.TabIndex = 14;
			this.txtOSID.Visible = false;
			// 
			// btnDel2
			// 
			this.btnDel2.Location = new System.Drawing.Point(491, 352);
			this.btnDel2.Name = "btnDel2";
			this.btnDel2.Size = new System.Drawing.Size(85, 52);
			this.btnDel2.TabIndex = 4;
			this.btnDel2.Text = "Delete";
			this.btnDel2.UseVisualStyleBackColor = true;
			this.btnDel2.Click += new System.EventHandler(this.BtnDel2Click);
			// 
			// txtInformation
			// 
			this.txtInformation.Location = new System.Drawing.Point(117, 41);
			this.txtInformation.Multiline = true;
			this.txtInformation.Name = "txtInformation";
			this.txtInformation.Size = new System.Drawing.Size(708, 299);
			this.txtInformation.TabIndex = 1;
			// 
			// btnSubmit2
			// 
			this.btnSubmit2.Location = new System.Drawing.Point(390, 352);
			this.btnSubmit2.Name = "btnSubmit2";
			this.btnSubmit2.Size = new System.Drawing.Size(85, 52);
			this.btnSubmit2.TabIndex = 3;
			this.btnSubmit2.Text = "Submit";
			this.btnSubmit2.UseVisualStyleBackColor = true;
			this.btnSubmit2.Click += new System.EventHandler(this.BtnSubmit2Click);
			// 
			// btnReset2
			// 
			this.btnReset2.Location = new System.Drawing.Point(289, 352);
			this.btnReset2.Name = "btnReset2";
			this.btnReset2.Size = new System.Drawing.Size(85, 52);
			this.btnReset2.TabIndex = 2;
			this.btnReset2.Text = "Clear Form";
			this.btnReset2.UseVisualStyleBackColor = true;
			this.btnReset2.Click += new System.EventHandler(this.BtnReset2Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(21, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 19);
			this.label2.TabIndex = 15;
			this.label2.Text = "Content:";
			// 
			// frmInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmInformation";
			this.Text = "Information";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOSID;
		private System.Windows.Forms.Button btnReset2;
		private System.Windows.Forms.Button btnSubmit2;
		private System.Windows.Forms.TextBox txtInformation;
		private System.Windows.Forms.DataGridView grdOS;
		private System.Windows.Forms.Button btnDel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel mainPanel;
	}
}
