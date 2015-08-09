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
	/// Description of dcApp.
	/// </summary>
	public class dcApp
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcApp()
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
			    	myCommand.CommandText = "usp_Application";
			    	
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
		public static void SubmitOne(bool IsInsert, string APP_ID, string APP_Name, string APP_Type, string App_Std_Hours)
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
			    	myCommand.CommandText = "usp_Application";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_Name", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_Type", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    			    	
			    	myCommand.Parameters.Add("@App_Std_Hours", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	myCommand.Parameters["@APP_ID"].Value = FormatConverter.standardizeInt(APP_ID);
			    	myCommand.Parameters["@APP_Name"].Value = APP_Name;
			    	myCommand.Parameters["@APP_Type"].Value = APP_Type;	    		    	
			    	myCommand.Parameters["@Creator"].Value = Environment.UserName.ToLower();
			    	myCommand.Parameters["@APP_Type"].Value = APP_Type;
			    	myCommand.Parameters["@App_Std_Hours"].Value = App_Std_Hours;			    	
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
		
		public static BindingSource GetData_ByKey(string APP_ID)
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
			    	myCommand.CommandText = "usp_Application";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_ID", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "GetData_ByKey";
			    	myCommand.Parameters["@APP_ID"].Value = APP_ID;
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
		
		public static BindingSource GetApp_ByClient(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_MT_Client_Application";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Client_App", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_ID", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Creator", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "GetApplication_ByEngID";
			    	myCommand.Parameters["@ID_Engagement"].Value = ID_Engagement;
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
		
		public static void DeleteOne(string APP_ID)
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
			    	myCommand.CommandText = "usp_Application";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    				    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@APP_ID"].Value = FormatConverter.standardizeInt(APP_ID);
			    	
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
