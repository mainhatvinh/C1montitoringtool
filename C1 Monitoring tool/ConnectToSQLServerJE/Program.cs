/*
 * Created by SharpDevelop.
 * User: an.c.thien.nguyen
 * Date: 5/16/2013
 * Time: 6:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new NewMainForm());
//			Application.Run(new frmmainform(1));
//			Application.Run(new frmWebbrowser());
		}
		
	}
}
