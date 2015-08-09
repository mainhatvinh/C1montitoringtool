/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 7/19/2013
 * Time: 3:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
namespace C1Monitoring
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class dcAuditTrail
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcAuditTrail()
		{
		}
		public static BindingSource GetData_ByDate()
		{						
			DataTable myDataTable = new DataTable();
			OleDbCommand myCommand = new OleDbCommand();
			BindingSource myBuidingSource = new BindingSource();
			
			try
			{			    
			    if (conn.State == ConnectionState.Open)
			    {
			    	myCommand.Connection = conn;
			    	myCommand.CommandType = CommandType.StoredProcedure;
			    	myCommand.CommandText = "[rpt_AuditTrail_Retain_PerWeek]";
			    	
			    	//myCommand.Parameters.Add("@Date", OleDbType.Date, 50).Direction = ParameterDirection.Input;			    				    	
			    	//myCommand.Parameters["@Date"].Value = date;
			    	
			    	OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
			    	myAdapter.Fill(myDataTable);
			    	myBuidingSource.DataSource = myDataTable;	    	
			    }
			    else
			    	MessageBox.Show("Connection failed!");
			}
			catch(Exception ex)
			{
			    MessageBox.Show(ex.ToString());
			}
			
			return myBuidingSource;
		}
		
		public static void UpdateInfo()
		{						
			DataTable myDataTable = new DataTable();
			OleDbCommand myCommand = new OleDbCommand();
			BindingSource myBuidingSource = new BindingSource();
			
			try
			{			    
			    if (conn.State == ConnectionState.Open)
			    {
			    	myCommand.Connection = conn;
			    	myCommand.CommandType = CommandType.StoredProcedure;
			    	myCommand.CommandText = "[usp_Insert_AuditTrail_Retain_PerWeek]";
			    	
			    	//myCommand.Parameters.Add("@Date", OleDbType.Date, 50).Direction = ParameterDirection.Input;			    				    	
			    	//myCommand.Parameters["@Date"].Value = date;
			    	
			    	myCommand.ExecuteNonQuery();	    	
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
