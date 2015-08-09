/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/21/2013
 * Time: 3:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmRate
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
			this.label5 = new System.Windows.Forms.Label();
			this.grdRate = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLeave = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtUSD = new System.Windows.Forms.TextBox();
			this.txtVND = new System.Windows.Forms.TextBox();
			this.txtLevel = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdRate)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.label5);
			this.mainPanel.Controls.Add(this.grdRate);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(125, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "*: Fields with * are mandatory";
			// 
			// grdRate
			// 
			this.grdRate.AllowUserToAddRows = false;
			this.grdRate.AllowUserToDeleteRows = false;
			this.grdRate.AllowUserToOrderColumns = true;
			this.grdRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRate.Location = new System.Drawing.Point(125, 356);
			this.grdRate.MultiSelect = false;
			this.grdRate.Name = "grdRate";
			this.grdRate.ReadOnly = true;
			this.grdRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdRate.Size = new System.Drawing.Size(950, 391);
			this.grdRate.TabIndex = 6;
			this.grdRate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdRateCellClick);
			this.grdRate.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdRateDataBindingComplete);
			this.grdRate.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GrdRateRowsAdded);
			this.grdRate.SelectionChanged += new System.EventHandler(this.GrdRateSelectionChanged);
			this.grdRate.Sorted += new System.EventHandler(this.GrdRateSorted);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(567, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please fill in the following form to create a new rate or update an existing rate" +
			":";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLeave);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.txtUSD);
			this.groupBox1.Controls.Add(this.txtVND);
			this.groupBox1.Controls.Add(this.txtLevel);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(125, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 260);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rate";
			// 
			// txtLeave
			// 
			this.txtLeave.Location = new System.Drawing.Point(452, 136);
			this.txtLeave.Name = "txtLeave";
			this.txtLeave.Size = new System.Drawing.Size(187, 20);
			this.txtLeave.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(280, 139);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Leave hours:";
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(564, 189);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 48);
			this.btnDel.TabIndex = 7;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(424, 189);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 48);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(280, 189);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 48);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// txtUSD
			// 
			this.txtUSD.Location = new System.Drawing.Point(452, 106);
			this.txtUSD.Name = "txtUSD";
			this.txtUSD.Size = new System.Drawing.Size(187, 20);
			this.txtUSD.TabIndex = 3;
			// 
			// txtVND
			// 
			this.txtVND.Location = new System.Drawing.Point(452, 77);
			this.txtVND.Name = "txtVND";
			this.txtVND.Size = new System.Drawing.Size(187, 20);
			this.txtVND.TabIndex = 2;
			// 
			// txtLevel
			// 
			this.txtLevel.Location = new System.Drawing.Point(452, 47);
			this.txtLevel.Name = "txtLevel";
			this.txtLevel.Size = new System.Drawing.Size(187, 20);
			this.txtLevel.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(281, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Amount in USD:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(281, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Amount in VND (*):";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(281, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Level (*):";
			// 
			// frmRate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmRate";
			this.Text = "Rate";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdRate)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtLeave;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView grdRate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLevel;
		private System.Windows.Forms.TextBox txtVND;
		private System.Windows.Forms.TextBox txtUSD;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Panel mainPanel;
	}
}
