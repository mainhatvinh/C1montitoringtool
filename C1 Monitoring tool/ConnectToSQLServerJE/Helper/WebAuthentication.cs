/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 5/10/2013
 * Time: 4:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class WebAuthentication
	{
		string user;
		string pwd;
		
		public WebAuthentication(string Username, string Password)
		{
			user = Username;
			pwd = Password;
			
		}
		public virtual string AuthenticateWeb(string weburl)
		{
			try
			{
				CredentialCache myCredentialCache = new CredentialCache();
				WebRequest myWebRequest = WebRequest.Create(weburl);
				myWebRequest.Method = "POST";
				myWebRequest.ContentLength = 0;
				if (user == "" && pwd =="")
				{
					myWebRequest.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
					myWebRequest.Credentials = CredentialCache.DefaultNetworkCredentials;
				}
				else
				{
					myWebRequest.Proxy.Credentials = new NetworkCredential(user,pwd);
					myWebRequest.Credentials = new NetworkCredential(user,pwd);
				}
		
				WebResponse myWebResponse = myWebRequest.GetResponse(); 
				Stream dataStream = myWebResponse.GetResponseStream();
				StreamReader reader = new StreamReader(dataStream);
				string responsestring = reader.ReadToEnd();
				return responsestring;
			}
			catch (Exception e)
			{
				MessageBox.Show("C1 Monitoring Tool cannot connect to GT&E. Please check your username/password or network");
				return "FALSE";
			}
		}
	}
}
