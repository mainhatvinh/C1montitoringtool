/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/6/2014
 * Time: 4:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace C1Monitoring
{
	partial class NewMainForm
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
			this.tclMain = new System.Windows.Forms.TabControl();
			this.grdMatrix_Role = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grdMatrix_Role)).BeginInit();
			this.SuspendLayout();
			// 
			// tclMain
			// 
			this.tclMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tclMain.Location = new System.Drawing.Point(150, 0);
			this.tclMain.Name = "tclMain";
			this.tclMain.SelectedIndex = 0;
			this.tclMain.Size = new System.Drawing.Size(642, 617);
			this.tclMain.TabIndex = 3;
			this.tclMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TclMainKeyUp);
			this.tclMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TclMainMouseUp);
			// 
			// grdMatrix_Role
			// 
			this.grdMatrix_Role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMatrix_Role.Location = new System.Drawing.Point(1, 279);
			this.grdMatrix_Role.Name = "grdMatrix_Role";
			this.grdMatrix_Role.Size = new System.Drawing.Size(10, 10);
			this.grdMatrix_Role.TabIndex = 4;
			this.grdMatrix_Role.Visible = false;
			// 
			// NewMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 617);
			this.Controls.Add(this.grdMatrix_Role);
			this.Controls.Add(this.tclMain);
			this.Name = "NewMainForm";
			this.Text = "Channels Development & Management Application";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.grdMatrix_Role)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView grdMatrix_Role;
		OutlookBar outlookBar;
		private System.Windows.Forms.TabControl tclMain;
		private void PanelSizeChange(object sender, EventArgs e)
		{
			this.tclMain.Size=new Size(Size.Width, ((Control)sender).ClientRectangle.Size.Height);

		}
	}
}
