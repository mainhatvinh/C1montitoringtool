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
	/// Description of dcActivity.
	/// </summary>
	public class dcActivity
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcActivity()
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
			    	myCommand.CommandText = "usp_Activity";
			    	
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
		
//		public static void SubmitOne(bool IsInsert, string APP_Name, string APP_Type)
//		{
//			//DataTable myDataTable = new DataTable();
//			OleDbCommand myCommand = new OleDbCommand();
//			//BindingSource myBuidingSource = new BindingSource();
//			
//			try
//			{
//			    if (conn.State == ConnectionState.Open)
//			    {
//			    	myCommand.Connection = conn;
//			    	myCommand.CommandType = CommandType.StoredProcedure;
//			    	myCommand.CommandText = "usp_Application";
// 	
//			    	
//			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@APP_Name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@APP_Type", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    				    			    	
//			    				    	
//			    	if(IsInsert == true)
//			    		myCommand.Parameters["@Action"].Value = "AddNew";
//			    	else
//			    		myCommand.Parameters["@Action"].Value = "Update";
//			    	myCommand.Parameters["@APP_Name"].Value = APP_Name;
//			    	myCommand.Parameters["@APP_Type"].Value = APP_Type;	    		    	
//			    				    	
//			    	myCommand.ExecuteNonQuery();
//			    }
//			    else
//			    	MessageBox.Show("Connection failed!");
//			}
//			catch(Exception ex)
//			{
//			    MessageBox.Show(ex.ToString());
//			}
//		}
//		
//		public static void DeleteOne(string APP_Name)
//		{
//			//DataTable myDataTable = new DataTable();
//			OleDbCommand myCommand = new OleDbCommand();
//			//BindingSource myBuidingSource = new BindingSource();
//			
//			try
//			{
//			    if (conn.State == ConnectionState.Open)
//			    {
//			    	myCommand.Connection = conn;
//			    	myCommand.CommandType = CommandType.StoredProcedure;
//			    	myCommand.CommandText = "usp_Application";
// 	
//			    	
//			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@APP_Name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	
//			    				    	
//			    	myCommand.Parameters["@Action"].Value = "Delete";
//			    	myCommand.Parameters["@APP_Name"].Value = APP_Name;
//			    	
//			    	myCommand.ExecuteNonQuery();
//			    }
//			    else
//			    	MessageBox.Show("Connection failed!");
//			}
//			catch(Exception ex)
//			{
//			    MessageBox.Show(ex.ToString());
//			}
//		}
	}
}
