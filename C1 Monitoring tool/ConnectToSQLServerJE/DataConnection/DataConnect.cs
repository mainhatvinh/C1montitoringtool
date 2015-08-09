/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 5/21/2013
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
//using System.Data.SqlClient;


namespace C1Monitoring
{
	/// <summary>
	/// Description of DataConnect.
	/// </summary>
	public class DataConnect
	{			
		public DataConnect()
		{
		}
		
		//testing
		public static void ConnectData()
		{
			//MainForm.myConnection = new OleDbConnection(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Data_C1MonitoringTool;Data Source=VN83001551W7\itrajeserver");
//			MainForm.myConnection = new OleDbConnection(@"Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;User ID='';Initial Catalog=Data_CMT;Data Source=VN83001551W6\sqlexpress;Initial File Name='';Server SPN=''");
			MainForm.myConnection = new OleDbConnection(@"Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;User ID='';Initial Catalog=Data_ChannelMonitoringTool;Data Source=10.202.156.117\itrajeserver;Initial File Name='';Server SPN=''");
			//MainForm.myConnection = new OleDbConnection(@"Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=Data_C1MonitoringTool_2014;Data Source=VN83001551W7\itrajeserver;Initial File Name="";Server SPN=""");
			try
			{
			    MainForm.myConnection.Open();
			    
			    if ( MainForm.myConnection.State == ConnectionState.Open)
			    {
			    	MessageBox.Show("Connection succeeded! Hello " + Environment.UserName);
			    }
			    else
			    	MessageBox.Show("Connection failed!");
			}
			catch(Exception ex)
			{
			    MessageBox.Show(ex.ToString());
			}
		}
		
		public static void ConnectData(string Connection_String)
		{
			MainForm.myConnection = new OleDbConnection(Connection_String);
			
			try
			{
			    MainForm.myConnection.Open();
			    
			    if ( MainForm.myConnection.State == ConnectionState.Open)
			    {
			    	MessageBox.Show("Connection succeeded! Hello " + Environment.UserName);
			    }
			    else
			    	MessageBox.Show("Connection failed!");
			}
			catch(Exception ex)
			{
			    MessageBox.Show(ex.ToString());
			}
		}
		
		public static void ReConnectData()
		{
			//MainForm.myConnection = new OleDbConnection(@"Provider=SQLNCLI.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=C1_Monitoring;Data Source=HOADV0011278D2");
			
			try
			{
				MainForm.myConnection.ResetState();
				
				//MainForm.myConnection.Open();
				if ( MainForm.myConnection.State != ConnectionState.Open)
					MainForm.myConnection.Open();
			    
			    if ( MainForm.myConnection.State == ConnectionState.Open)
			    {
			    	MessageBox.Show("Connection succeeded! Hello " + Environment.UserName);
			    }
			    else
			    	MessageBox.Show("Connection failed!");
			}
			catch(Exception ex)
			{
			    MessageBox.Show(ex.ToString());
			}
		}
	}
}
