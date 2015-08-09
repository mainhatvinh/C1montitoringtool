/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/2/2013
 * Time: 2:44 PM
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
	/// Description of dcBudgetStaffing.
	/// </summary>
	public class dcBudgetStaffing
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcBudgetStaffing()
		{
		}
		
		public static BindingSource GetDataMemberByKey(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_Budget";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetDataMember_ByKey";
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
		
		public static BindingSource GetDataMemberByKey1(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_Budget";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetDataMember_ByKey1";
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
		
		public static BindingSource GetDataEngMem_ByKey(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_Budget";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetDataEngMem_ByKey";
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
		
		public static BindingSource GetData_ByKey(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_Budget";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
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
		
		public static void SubmitOne(bool IsInsert, string ID_Engagement, string ID_Member,
		                            	string Hours, string Amend_Hours_1,
		                            	string Amend_Hours_2, string Amend_Hours_3,
		                            	string Amend_Hours_4, string Amend_Hours_5, string Member_Level,string OldLevel, string Creator, string Position)
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
			    	myCommand.CommandText = "usp_Budget";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Hours", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_1", OleDbType.Double).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Amend_Hours_2", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_3", OleDbType.Double).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Amend_Hours_4", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_5", OleDbType.Double).Direction = ParameterDirection.Input;			    			    	
			    	myCommand.Parameters.Add("@ID_Member_New", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;		
			    	myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@OldLevel", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Position", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	
			    	if (IsInsert)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    	{
			    		myCommand.Parameters["@Action"].Value = "Update";
			    		
			    	}
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@Hours"].Value = FormatConverter.standardizeDouble(Hours);
			    	myCommand.Parameters["@Amend_Hours_1"].Value = FormatConverter.standardizeDouble(Amend_Hours_1);
			    	myCommand.Parameters["@Amend_Hours_2"].Value = FormatConverter.standardizeDouble(Amend_Hours_2);
			    	myCommand.Parameters["@Amend_Hours_3"].Value = FormatConverter.standardizeDouble(Amend_Hours_3);
			    	myCommand.Parameters["@Amend_Hours_4"].Value = FormatConverter.standardizeDouble(Amend_Hours_4);
			    	myCommand.Parameters["@Amend_Hours_5"].Value = FormatConverter.standardizeDouble(Amend_Hours_5);
			    	myCommand.Parameters["@Member_Level"].Value = Member_Level;
			    	myCommand.Parameters["@OldLevel"].Value = OldLevel;
			    	myCommand.Parameters["@Creator"].Value = Environment.UserName.ToLower();
			    	myCommand.Parameters["@Position"].Value = FormatConverter.standardizeInt(Position);
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
		
		public static void UpdateMember(string ID_Engagement, string ID_Member,string ID_Member_New  )
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
			    	myCommand.CommandText = "usp_Budget";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Hours", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_1", OleDbType.Double).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Amend_Hours_2", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_3", OleDbType.Double).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Amend_Hours_4", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_5", OleDbType.Double).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@ID_Member_New", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
					myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "UpdateMember";
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@ID_Member_New"].Value = ID_Member_New;
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
		
		public static void DeleteOne(string ID_Engagement, string ID_Member)
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
			    	myCommand.CommandText = "usp_Budget";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Hours", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_1", OleDbType.Double).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Amend_Hours_2", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_3", OleDbType.Double).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Amend_Hours_4", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Amend_Hours_5", OleDbType.Double).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@ID_Member_New", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    	
					myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
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
			    	myCommand.CommandText = "usp_Budget";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					
					
			    	myCommand.Parameters["@Action"].Value = "Delete_ByEng";
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
	}
}
