/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/2/2013
 * Time: 3:30 PM
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
	/// Description of dcRetain.
	/// </summary>
	public class dcRetain
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcRetain()
		{
		}
		public static BindingSource GetData_ByKey(string ID_Engagement, string BookingDate)
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
			    	myCommand.CommandText = "usp_Retain";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BookingDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "GetData_ByKey";
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	 myCommand.Parameters["@BookingDate"].Value = FormatConverter.standardizeDate(BookingDate);
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
		
		public static BindingSource Sum_ByDate(string ID_Member, string BookingDate)
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
			    	myCommand.CommandText = "usp_Retain";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BookingDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "SUMBYDATE";
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	 myCommand.Parameters["@BookingDate"].Value = FormatConverter.standardizeDate(BookingDate);
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
		public static void SubmitOne(int ActionS, string ID_Engagement, string ID_Member,
		                            	string BookingDate, string Hour, string FullName)
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
			    	myCommand.CommandText = "usp_Retain";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BookingDate", OleDbType.Date).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Hour", OleDbType.Double).Direction = ParameterDirection.Input;			    				    
			    	myCommand.Parameters.Add("@ID_Member_New", OleDbType.VarChar,50).Direction = ParameterDirection.Input;			    				    
			    	myCommand.Parameters.Add("@FullName", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	
			    	if(ActionS == 1)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	if(ActionS == 2)
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	if(ActionS == 3)
			    		myCommand.Parameters["@Action"].Value = "Delete_ByKey";
			    	//MessageBox.Show(FullName);
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@BookingDate"].Value = FormatConverter.standardizeDate(BookingDate);
			    	myCommand.Parameters["@Hour"].Value = FormatConverter.standardizeDouble(Hour);
			    	myCommand.Parameters["@FullName"].Value = FullName;
			    	
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
		
		public static BindingSource GetListData_by_MemberID(string ID_Member, string BookingDate)
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
			    	myCommand.CommandText = "usp_Retain";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BookingDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "GetListData_by_MemberID";
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@BookingDate"].Value = FormatConverter.standardizeDate(BookingDate);
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
		
		public static void UpdateMember(string ID_Engagement, string ID_Member,
		                            	string ID_Member_New)
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
			    	myCommand.CommandText = "usp_Retain";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BookingDate", OleDbType.Date).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters.Add("@Hour", OleDbType.Double).Direction = ParameterDirection.Input;			    				    
			    	myCommand.Parameters.Add("@ID_Member_New", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "UpdateMember";
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@ID_Member_New"].Value = ID_Member_New;
			    	
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
			    	myCommand.CommandText = "usp_Retain";
 	
			    	
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
		
		public static void DeleteMem_byKey(string ID_Engagement, string ID_Member)
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
			    	myCommand.CommandText = "usp_Retain";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "DeleteMem_byKey";
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	
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
		
		public static BindingSource GetBudgetRetain(string ID_Engagement)
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
			    	myCommand.CommandText = "[usp_Budget_Retain]";
			    	
			    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
			    	
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
		
		
		
	}
}
