/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 5/31/2013
 * Time: 4:00 PM
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
	/// Description of dcRateChange.
	/// </summary>
	public class dcRateChange
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcRateChange()
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
			    	myCommand.CommandText = "usp_Rate_Change";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
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
		public static void SubmitOne(bool IsInsert, string RateChange_ID, string ID_Member, string FullName, string Member_Level, string FromDate, string ToDate)
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
			    	myCommand.CommandText = "usp_Rate_Change";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@RateChange_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FullName", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FromDate", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ToDate", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    			    	
			    				    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    	{
			    		myCommand.Parameters["@Action"].Value = "Update";
			    		myCommand.Parameters["@RateChange_ID"].Value = RateChange_ID;
			    	}
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@FullName"].Value = FullName;
			    	myCommand.Parameters["@Member_Level"].Value = Member_Level;
			    	myCommand.Parameters["@FromDate"].Value = FormatConverter.standardizeDate(FromDate);
			    	myCommand.Parameters["@ToDate"].Value = FormatConverter.standardizeDate(ToDate);
			    	myCommand.Parameters["@Creator"].Value = Environment.UserName.ToLower();			    	
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
		
		public static void DeleteOne(string RateChange_ID)
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
			    	myCommand.CommandText = "usp_Rate_Change";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@RateChange_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    				    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@RateChange_ID"].Value = RateChange_ID;
			    	
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
