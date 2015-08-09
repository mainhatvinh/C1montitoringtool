/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 9/9/2013
 * Time: 9:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmWebbrowser.
	/// </summary>
	public partial class frmWebbrowser : Form
	{
		public frmWebbrowser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmWebbrowserLoad(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(UrlTextBox.Text) || UrlTextBox.Text.Equals("about:blank"))
		    {
		        MessageBox.Show("Enter a valid URL.");
		        UrlTextBox.Focus();
		        return;
		    }
		    OpenURLInBrowser(UrlTextBox.Text);   
		}
		private void OpenURLInBrowser(string url)
		{        
		    if (!url.StartsWith("http://") && !url.StartsWith("https://"))
		    {
		        url = "http://" + url;
		    }
		    try
		    {
		        webBrowser1.Navigate(new Uri(url));
		    }
		    catch (System.UriFormatException)
		    {
		        return;
		    }
		}
		
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			//webBrowser1.Document.GetElementById("ctl00_contentPH_btnSave").Click();
			
			
			HtmlElement htme = webBrowser1.Document.GetElementById("ctl00_contentPH_btnSave");
			
			htme.InvokeMember("click");
			
			//webBrowser1.Document.GetElementById("ctl00_contentPH_btnSubmit").InvokeMember("click");
		}
	}
}
