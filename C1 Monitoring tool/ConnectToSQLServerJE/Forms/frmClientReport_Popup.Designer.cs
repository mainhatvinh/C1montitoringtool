/*
 * Created by SharpDevelop.
 * User: luan.khanh.ha
 * Date: 6/3/2013
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmClientReport_Popup
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtClientCode = new System.Windows.Forms.TextBox();
			this.txtClientName = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Client code:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Client name:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fiscal_Year:";
			// 
			// txtClientCode
			// 
			this.txtClientCode.Location = new System.Drawing.Point(124, 20);
			this.txtClientCode.Name = "txtClientCode";
			this.txtClientCode.ReadOnly = true;
			this.txtClientCode.Size = new System.Drawing.Size(110, 20);
			this.txtClientCode.TabIndex = 3;
			// 
			// txtClientName
			// 
			this.txtClientName.Location = new System.Drawing.Point(124, 52);
			this.txtClientName.Name = "txtClientName";
			this.txtClientName.ReadOnly = true;
			this.txtClientName.Size = new System.Drawing.Size(343, 20);
			this.txtClientName.TabIndex = 4;
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(124, 85);
			this.txtYear.Name = "txtYear";
			this.txtYear.ReadOnly = true;
			this.txtYear.Size = new System.Drawing.Size(110, 20);
			this.txtYear.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(25, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Remark:";
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(124, 119);
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(343, 88);
			this.txtRemark.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(302, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 33);
			this.button1.TabIndex = 8;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(34, 237);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(64, 27);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(392, 231);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 33);
			this.button2.TabIndex = 10;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// frmClientReport_Popup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 302);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtRemark);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtClientName);
			this.Controls.Add(this.txtClientCode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "frmClientReport_Popup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Details";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRetain_PopupFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.TextBox txtClientName;
		private System.Windows.Forms.TextBox txtClientCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
