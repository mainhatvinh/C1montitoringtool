/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 5/29/2013
 * Time: 4:36 PM
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
	public class dcTimesheet
	{
		public dcTimesheet()
		{
		}
		
		static OleDbConnection conn = MainForm.myConnection;
		
		public static void SubmitOne(string Engagement_code, string fullname, string weekending, float hours, string Engagement_Type, string Fiscal_Year)
		{
			//DataTable myDataTable = new DataTable();
			OleDbCommand myCommand = new OleDbCommand();
			//BindingSource myBuidingSource = new BindingSource();
			
			try
			{
			    if (conn.State == ConnectionState.Open)
			    {
			    	myCommand.Connection = conn;
			    	myCommand.CommandType = CommandType.StoredProcedure;
			    	myCommand.CommandText = "usp_timesheet1";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FullName", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Engagement_Code", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Week_Ending", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Charged_Hours", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Type", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    
					myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    	
			    	
			    	myCommand.Parameters["@Action"].Value = "AddNew";
					myCommand.Parameters["@FullName"].Value = fullname;			    	
			    	myCommand.Parameters["@Engagement_Code"].Value = Engagement_code;			    	
			    	myCommand.Parameters["@Week_Ending"].Value = weekending;
			    	myCommand.Parameters["@Charged_Hours"].Value = hours;
			    	myCommand.Parameters["@Engagement_Type"].Value = Engagement_Type;
			    	myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
			    	
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
		
		public static void DeleteOne(string fullname, string Fiscal_Year)
		{
			//DataTable myDataTable = new DataTable();
			OleDbCommand myCommand = new OleDbCommand();
			//BindingSource myBuidingSource = new BindingSource();
			
			try
			{
			    if (conn.State == ConnectionState.Open)
			    {
			    	myCommand.Connection = conn;
			    	myCommand.CommandType = CommandType.StoredProcedure;
			    	myCommand.CommandText = "usp_timesheet1";	    		    	
 			
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@FullName", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Engagement_Code", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Week_Ending", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Charged_Hours", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Type", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	
			    	myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
			    	
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
		
		public static void DeleteOnePerWeek(string fullname, string Week_Ending)
		{
			//DataTable myDataTable = new DataTable();
			OleDbCommand myCommand = new OleDbCommand();
			//BindingSource myBuidingSource = new BindingSource();
			
			try
			{
			    if (conn.State == ConnectionState.Open)
			    {
			    	myCommand.Connection = conn;
			    	myCommand.CommandType = CommandType.StoredProcedure;
			    	myCommand.CommandText = "usp_timesheet1";	    		    	
 			
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@FullName", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Engagement_Code", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Week_Ending", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	
			    	myCommand.Parameters["@Action"].Value = "DeletePerWeek";
			    	myCommand.Parameters["@FullName"].Value = fullname;
			    	myCommand.Parameters["@Week_Ending"].Value = Week_Ending;
			    	
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
