/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 5/20/2013
 * Time: 2:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.ComponentModel;

namespace C1Monitoring
{
	/// <summary>
	/// Description of MyTabPage.
	/// </summary>

	public class MyFormPage : Form
	{
		public Panel pnl;
	}
	
	public class MyPanel : Panel
	{
		private Form frm;
		public MyPanel(MyFormPage frm_contenido)
		{
			this.Dock = DockStyle.Fill;
			this.frm = frm_contenido;
			this.Controls.Add(frm_contenido.pnl);
			this.Text = frm_contenido.Text;
			//this.BackColor = System.Drawing.Color.RoyalBlue;
			//this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.jpg")));
		}
	}
}
