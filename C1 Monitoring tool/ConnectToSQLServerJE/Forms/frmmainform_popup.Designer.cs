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
	partial class frmmainform_popup
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtITRA_Content = new System.Windows.Forms.TextBox();
			this.grdRevenue = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(875, 374);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtITRA_Content
			// 
			this.txtITRA_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtITRA_Content.Location = new System.Drawing.Point(12, 12);
			this.txtITRA_Content.Multiline = true;
			this.txtITRA_Content.Name = "txtITRA_Content";
			this.txtITRA_Content.ReadOnly = true;
			this.txtITRA_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtITRA_Content.Size = new System.Drawing.Size(938, 336);
			this.txtITRA_Content.TabIndex = 8;
			// 
			// grdRevenue
			// 
			this.grdRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRevenue.Location = new System.Drawing.Point(159, 99);
			this.grdRevenue.Name = "grdRevenue";
			this.grdRevenue.Size = new System.Drawing.Size(427, 142);
			this.grdRevenue.TabIndex = 66;
			this.grdRevenue.Visible = false;
			// 
			// frmmainform_popup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 409);
			this.Controls.Add(this.grdRevenue);
			this.Controls.Add(this.txtITRA_Content);
			this.Controls.Add(this.button1);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "frmmainform_popup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Details";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRetain_PopupFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView grdRevenue;
		private System.Windows.Forms.TextBox txtITRA_Content;
		private System.Windows.Forms.Button button1;
	}
}
