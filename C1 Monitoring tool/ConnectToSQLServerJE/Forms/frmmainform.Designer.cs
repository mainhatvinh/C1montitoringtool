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
	partial class frmmainform
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.grdNews = new System.Windows.Forms.DataGridView();
			this.btnDel2 = new System.Windows.Forms.Button();
			this.txtOSID = new System.Windows.Forms.TextBox();
			this.grdOS = new System.Windows.Forms.DataGridView();
			this.btnSubmit2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grdWeekRev = new System.Windows.Forms.DataGridView();
			this.txtInformation = new System.Windows.Forms.TextBox();
			this.btnReset2 = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdNews)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWeekRev)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Controls.Add(this.grdNews);
			this.mainPanel.Controls.Add(this.btnDel2);
			this.mainPanel.Controls.Add(this.txtOSID);
			this.mainPanel.Controls.Add(this.grdOS);
			this.mainPanel.Controls.Add(this.btnSubmit2);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Controls.Add(this.btnReset2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.progressBar3);
			this.groupBox1.Controls.Add(this.progressBar2);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Location = new System.Drawing.Point(99, 297);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1138, 114);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Week - Revenue";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(874, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 14);
			this.label5.TabIndex = 7;
			this.label5.Text = "label5";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(440, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(440, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Revenue:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Week Number:";
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(796, 79);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(306, 23);
			this.progressBar3.TabIndex = 2;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(163, 79);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(627, 23);
			this.progressBar2.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(163, 33);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(627, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// grdNews
			// 
			this.grdNews.AllowUserToAddRows = false;
			this.grdNews.AllowUserToDeleteRows = false;
			this.grdNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdNews.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
			this.grdNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdNews.Location = new System.Drawing.Point(100, 429);
			this.grdNews.MultiSelect = false;
			this.grdNews.Name = "grdNews";
			this.grdNews.ReadOnly = true;
			this.grdNews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdNews.Size = new System.Drawing.Size(1138, 317);
			this.grdNews.TabIndex = 15;
			this.grdNews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdNewsCellDoubleClick);
			this.grdNews.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdNewsDataBindingComplete);
			// 
			// btnDel2
			// 
			this.btnDel2.Location = new System.Drawing.Point(1103, 38);
			this.btnDel2.Name = "btnDel2";
			this.btnDel2.Size = new System.Drawing.Size(85, 52);
			this.btnDel2.TabIndex = 10;
			this.btnDel2.Text = "Delete";
			this.btnDel2.UseVisualStyleBackColor = true;
			this.btnDel2.Visible = false;
			this.btnDel2.Click += new System.EventHandler(this.BtnDel2Click);
			// 
			// txtOSID
			// 
			this.txtOSID.Location = new System.Drawing.Point(1006, 12);
			this.txtOSID.Name = "txtOSID";
			this.txtOSID.Size = new System.Drawing.Size(136, 20);
			this.txtOSID.TabIndex = 14;
			this.txtOSID.Visible = false;
			// 
			// grdOS
			// 
			this.grdOS.AllowUserToAddRows = false;
			this.grdOS.AllowUserToDeleteRows = false;
			this.grdOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
			this.grdOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdOS.Location = new System.Drawing.Point(1019, 403);
			this.grdOS.MultiSelect = false;
			this.grdOS.Name = "grdOS";
			this.grdOS.ReadOnly = true;
			this.grdOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdOS.Size = new System.Drawing.Size(161, 30);
			this.grdOS.TabIndex = 11;
			this.grdOS.Visible = false;
			this.grdOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOSCellClick);
			this.grdOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdOSDataBindingComplete);
			this.grdOS.SelectionChanged += new System.EventHandler(this.GrdOSSelectionChanged);
			this.grdOS.Sorted += new System.EventHandler(this.GrdOSSorted);
			// 
			// btnSubmit2
			// 
			this.btnSubmit2.Location = new System.Drawing.Point(1012, 38);
			this.btnSubmit2.Name = "btnSubmit2";
			this.btnSubmit2.Size = new System.Drawing.Size(85, 52);
			this.btnSubmit2.TabIndex = 9;
			this.btnSubmit2.Text = "Submit";
			this.btnSubmit2.UseVisualStyleBackColor = true;
			this.btnSubmit2.Visible = false;
			this.btnSubmit2.Click += new System.EventHandler(this.BtnSubmit2Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.grdWeekRev);
			this.groupBox2.Controls.Add(this.txtInformation);
			this.groupBox2.Location = new System.Drawing.Point(100, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1138, 278);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			// 
			// grdWeekRev
			// 
			this.grdWeekRev.AllowUserToAddRows = false;
			this.grdWeekRev.AllowUserToDeleteRows = false;
			this.grdWeekRev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdWeekRev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
			this.grdWeekRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWeekRev.Location = new System.Drawing.Point(821, 252);
			this.grdWeekRev.MultiSelect = false;
			this.grdWeekRev.Name = "grdWeekRev";
			this.grdWeekRev.ReadOnly = true;
			this.grdWeekRev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdWeekRev.Size = new System.Drawing.Size(53, 27);
			this.grdWeekRev.TabIndex = 17;
			this.grdWeekRev.Visible = false;
			// 
			// txtInformation
			// 
			this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInformation.Location = new System.Drawing.Point(21, 19);
			this.txtInformation.Multiline = true;
			this.txtInformation.Name = "txtInformation";
			this.txtInformation.ReadOnly = true;
			this.txtInformation.Size = new System.Drawing.Size(1096, 246);
			this.txtInformation.TabIndex = 7;
			// 
			// btnReset2
			// 
			this.btnReset2.Location = new System.Drawing.Point(921, 38);
			this.btnReset2.Name = "btnReset2";
			this.btnReset2.Size = new System.Drawing.Size(85, 52);
			this.btnReset2.TabIndex = 8;
			this.btnReset2.Text = "Clear Form";
			this.btnReset2.UseVisualStyleBackColor = true;
			this.btnReset2.Click += new System.EventHandler(this.BtnReset2Click);
			// 
			// frmmainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmmainform";
			this.Text = "Hello World";
			this.Load += new System.EventHandler(this.FrmmainformLoad);
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdNews)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdOS)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWeekRev)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView grdWeekRev;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grdNews;
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
