/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 5/31/2013
 * Time: 1:49 PM
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
	/// Description of dcRate.
	/// </summary>
	public class dcImportSoldTime
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcImportSoldTime()
		{
		}
		
		public static BindingSource GetAll()
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
			    	myCommand.CommandText = "usp_ImportSoldTime";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListData";
			    	
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

		public static BindingSource GetAllEngCode()
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
			    	myCommand.CommandText = "usp_ImportSoldTime";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetAllEngagementCode";
			    	
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
		
		public static void SubmitOne(bool IsInsert, string Engagement_Code, string Months, string FYear, string Net_Fee)
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
			    	myCommand.CommandText = "usp_ImportSoldTime";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_code", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Months", OleDbType.VarWChar, 2).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FYear", OleDbType.VarWChar, 4).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Net_Fee", OleDbType.Double).Direction = ParameterDirection.Input;
			    			    	
			    				    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	myCommand.Parameters["@Engagement_code"].Value = Engagement_Code;
			    	myCommand.Parameters["@Months"].Value = Months;
			    	myCommand.Parameters["@FYear"].Value = FYear;
			    	myCommand.Parameters["@Net_Fee"].Value = FormatConverter.standardizeDouble(Net_Fee);
			    	
			    				    	
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
		
		public static void DeleteOne(string Engagement_Code, string Months, string FYear)
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
			    	myCommand.CommandText = "usp_ImportSoldTime";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_code", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Months", OleDbType.VarWChar, 2).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FYear", OleDbType.VarWChar, 4).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@Engagement_Code"].Value = Engagement_Code;
			    	myCommand.Parameters["@Months"].Value = Months;
			    	myCommand.Parameters["@FYear"].Value = FYear;
			    	
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
