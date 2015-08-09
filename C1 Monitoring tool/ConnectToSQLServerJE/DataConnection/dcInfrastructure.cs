/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/2/2013
 * Time: 12:45 PM
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
	/// Description of dcInfrastructure.
	/// </summary>
	public class dcInfrastructure
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcInfrastructure()
		{
		}
		public static BindingSource GetDataByKey(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_Infrastructure";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;		
					myCommand.Parameters.Add("@Infrastructure_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByKey";
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	
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
		
		public static void SubmitOne(bool IsInsert, string Infrastructure_ID, string ID_Engagement, string APP_ID,
		                            	string OS_ID, string DB_ID,
		                            	string Vendor, string Remark,string APP_ID_New, string OS_DBID, string No_DB_ID, string No_OS_APP_ID, string No_OS_ID)
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
			    	myCommand.CommandText = "usp_Infrastructure";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Infrastructure_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@OS_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@DB_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Vendor", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Remark", OleDbType.LongVarChar).Direction = ParameterDirection.Input;			    	
					myCommand.Parameters.Add("@APP_ID_New", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@OS_DB_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@No_OS_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@No_DB_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@No_OS_APP_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    	{
			    		myCommand.Parameters["@Action"].Value = "UpdateAdd";
			    		myCommand.Parameters["@Infrastructure_ID"].Value = FormatConverter.standardizeInt(Infrastructure_ID);
			    	}
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	myCommand.Parameters["@APP_ID"].Value = FormatConverter.standardizeInt(APP_ID);
			    	if (OS_ID !="")
			    		myCommand.Parameters["@OS_ID"].Value = OS_ID;
			    	if (DB_ID !="")
			    		myCommand.Parameters["@DB_ID"].Value = DB_ID;
			    	myCommand.Parameters["@Vendor"].Value = Vendor;
			    	myCommand.Parameters["@Remark"].Value = Remark;
			    	myCommand.Parameters["@APP_ID_New"].Value = FormatConverter.standardizeInt(APP_ID_New);
			    	if (OS_DBID !="")
			    		myCommand.Parameters["@OS_DB_ID"].Value = OS_DBID;
			    	myCommand.Parameters["@No_DB_ID"].Value = FormatConverter.standardizeInt(No_DB_ID);
			    	myCommand.Parameters["@No_OS_APP_ID"].Value = FormatConverter.standardizeInt(No_OS_APP_ID);
			    	myCommand.Parameters["@No_OS_ID"].Value = FormatConverter.standardizeInt(No_OS_ID);
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
		
		public static void DeleteOne(string Infrastructure_ID)
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
			    	myCommand.CommandText = "usp_Infrastructure";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Infrastructure_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@APP_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@Infrastructure_ID"].Value = FormatConverter.standardizeInt(Infrastructure_ID);
//			    	myCommand.Parameters["@APP_ID"].Value = FormatConverter.standardizeInt(APP_ID);
			    	
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
		
		
		public static void DeleteByEng(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_Infrastructure";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete_byEng";
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	
			    	
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

		public static void DeleteByApp(string APP_ID)
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
			    	myCommand.CommandText = "usp_Infrastructure";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_ID", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete_byApp";
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
		
		public static void UpdateEng(bool IsOS, string ID_Engagement,
		                            	string OS_ID, string DB_ID)
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
			    	myCommand.CommandText = "usp_Infrastructure";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@APP_ID", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@OS_ID", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@DB_ID", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					
			    	
			    	if (IsOS)
			    		myCommand.Parameters["@Action"].Value = "UpdateOS";
			    	else	
			    		myCommand.Parameters["@Action"].Value = "UpdateDB";
			    	
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);			    	
			    	myCommand.Parameters["@OS_ID"].Value = FormatConverter.standardizeInt(OS_ID);
			    	myCommand.Parameters["@DB_ID"].Value = FormatConverter.standardizeInt(DB_ID);
			    				    	
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
		
		public static BindingSource GetOSDBData()
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
			    	myCommand.CommandText = "usp_Infrastructure";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	
			    	
			    		myCommand.Parameters["@Action"].Value = "GetOSData";
			    	
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
		
		public static BindingSource GetDBData()
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
			    	myCommand.CommandText = "usp_Infrastructure";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	
			    		myCommand.Parameters["@Action"].Value = "GetDBData";
			    	
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
