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
	partial class frmNews
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
			this.grdNews = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNews_ID = new System.Windows.Forms.TextBox();
			this.txtITRA_Title = new System.Windows.Forms.TextBox();
			this.btnDel2 = new System.Windows.Forms.Button();
			this.txtITRA_Content = new System.Windows.Forms.TextBox();
			this.btnSubmit2 = new System.Windows.Forms.Button();
			this.btnReset2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdNews)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdNews);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 4;
			// 
			// grdNews
			// 
			this.grdNews.AllowUserToAddRows = false;
			this.grdNews.AllowUserToDeleteRows = false;
			this.grdNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdNews.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
			this.grdNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdNews.Location = new System.Drawing.Point(42, 445);
			this.grdNews.MultiSelect = false;
			this.grdNews.Name = "grdNews";
			this.grdNews.ReadOnly = true;
			this.grdNews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdNews.Size = new System.Drawing.Size(847, 246);
			this.grdNews.TabIndex = 6;
			this.grdNews.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOSCellClick);
			this.grdNews.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdOSDataBindingComplete);
			this.grdNews.SelectionChanged += new System.EventHandler(this.GrdOSSelectionChanged);
			this.grdNews.Sorted += new System.EventHandler(this.GrdOSSorted);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtNews_ID);
			this.groupBox2.Controls.Add(this.txtITRA_Title);
			this.groupBox2.Controls.Add(this.btnDel2);
			this.groupBox2.Controls.Add(this.txtITRA_Content);
			this.groupBox2.Controls.Add(this.btnSubmit2);
			this.groupBox2.Controls.Add(this.btnReset2);
			this.groupBox2.Location = new System.Drawing.Point(42, 29);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(847, 410);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			// 
			// txtNews_ID
			// 
			this.txtNews_ID.Location = new System.Drawing.Point(117, 46);
			this.txtNews_ID.Name = "txtNews_ID";
			this.txtNews_ID.ReadOnly = true;
			this.txtNews_ID.Size = new System.Drawing.Size(131, 20);
			this.txtNews_ID.TabIndex = 15;
			this.txtNews_ID.Visible = false;
			// 
			// txtITRA_Title
			// 
			this.txtITRA_Title.Location = new System.Drawing.Point(117, 46);
			this.txtITRA_Title.Name = "txtITRA_Title";
			this.txtITRA_Title.Size = new System.Drawing.Size(547, 20);
			this.txtITRA_Title.TabIndex = 1;
			// 
			// btnDel2
			// 
			this.btnDel2.Location = new System.Drawing.Point(491, 352);
			this.btnDel2.Name = "btnDel2";
			this.btnDel2.Size = new System.Drawing.Size(85, 52);
			this.btnDel2.TabIndex = 5;
			this.btnDel2.Text = "Delete";
			this.btnDel2.UseVisualStyleBackColor = true;
			this.btnDel2.Click += new System.EventHandler(this.BtnDel2Click);
			// 
			// txtITRA_Content
			// 
			this.txtITRA_Content.Location = new System.Drawing.Point(117, 72);
			this.txtITRA_Content.Multiline = true;
			this.txtITRA_Content.Name = "txtITRA_Content";
			this.txtITRA_Content.Size = new System.Drawing.Size(708, 268);
			this.txtITRA_Content.TabIndex = 2;
			// 
			// btnSubmit2
			// 
			this.btnSubmit2.Location = new System.Drawing.Point(390, 352);
			this.btnSubmit2.Name = "btnSubmit2";
			this.btnSubmit2.Size = new System.Drawing.Size(85, 52);
			this.btnSubmit2.TabIndex = 4;
			this.btnSubmit2.Text = "Submit";
			this.btnSubmit2.UseVisualStyleBackColor = true;
			this.btnSubmit2.Click += new System.EventHandler(this.BtnSubmit2Click);
			// 
			// btnReset2
			// 
			this.btnReset2.Location = new System.Drawing.Point(289, 352);
			this.btnReset2.Name = "btnReset2";
			this.btnReset2.Size = new System.Drawing.Size(85, 52);
			this.btnReset2.TabIndex = 3;
			this.btnReset2.Text = "Clear Form";
			this.btnReset2.UseVisualStyleBackColor = true;
			this.btnReset2.Click += new System.EventHandler(this.BtnReset2Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(25, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 19);
			this.label2.TabIndex = 16;
			this.label2.Text = "Content:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(25, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 19);
			this.label1.TabIndex = 17;
			this.label1.Text = "Title:";
			// 
			// frmNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmNews";
			this.Text = "Information";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdNews)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNews_ID;
		private System.Windows.Forms.TextBox txtITRA_Title;
		private System.Windows.Forms.Button btnReset2;
		private System.Windows.Forms.Button btnSubmit2;
		private System.Windows.Forms.TextBox txtITRA_Content;
		private System.Windows.Forms.DataGridView grdNews;
		private System.Windows.Forms.Button btnDel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel mainPanel;
	}
}
