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
	/// Description of dcPeakSeasonTarget.
	/// </summary>
	public class dcPeakSeasonTarget
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcPeakSeasonTarget()
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
			    	myCommand.CommandText = "usp_Peak_Season_Target";
			    	
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
		public static void SubmitOne(bool IsInsert, string EY_FY, string Jan, string Feb, string Mar, string Apr,
	                             								string May, string Jun, string Jul, string Aug,
	                             								string Sep, string Oct, string Nov, string Dec, string Staff_targeted_charged_hrs, string Senior_targeted_charged_hrs)
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
			    	myCommand.CommandText = "usp_Peak_Season_Target";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EY_FY", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Jan", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Feb", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Mar", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Apr", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@May", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Jun", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Jul", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Aug", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Sep", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Oct", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Nov", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Dec", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Staff_targeted_charged_hrs", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Senior_targeted_charged_hrs", OleDbType.Double).Direction = ParameterDirection.Input;
			    			    			    	
			    				    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	myCommand.Parameters["@EY_FY"].Value = EY_FY;
			    	myCommand.Parameters["@Jan"].Value = Jan;
			    	myCommand.Parameters["@Feb"].Value = Feb;
			    	myCommand.Parameters["@Mar"].Value = Mar;
			    	myCommand.Parameters["@Apr"].Value = Apr;
			    	myCommand.Parameters["@May"].Value = May;
			    	myCommand.Parameters["@Jun"].Value = Jun;
			    	myCommand.Parameters["@Jul"].Value = Jul;
			    	myCommand.Parameters["@Aug"].Value = Aug;
			    	myCommand.Parameters["@Sep"].Value = Sep;
			    	myCommand.Parameters["@Oct"].Value = Oct;
			    	myCommand.Parameters["@Nov"].Value = Nov;
			    	myCommand.Parameters["@Dec"].Value = Dec;
			    	myCommand.Parameters["@Staff_targeted_charged_hrs"].Value = Staff_targeted_charged_hrs;
			    	myCommand.Parameters["@Senior_targeted_charged_hrs"].Value = Senior_targeted_charged_hrs;
			    				    	
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
		
		public static void DeleteOne(string EY_FY)
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
			    	myCommand.CommandText = "usp_Peak_Season_Target";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EY_FY", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    				    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@EY_FY"].Value = EY_FY;
			    	
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
		
		public static BindingSource GetData_ByFY(string Fiscal_Year)
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
			    	myCommand.CommandText = "usp_Peak_Season_Target";
			    	
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
			    	
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
	}
}
