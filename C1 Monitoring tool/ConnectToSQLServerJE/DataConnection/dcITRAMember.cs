/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 5/22/2013
 * Time: 5:03 PM
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
	/// Description of dcITRAMember.
	/// </summary>
	public class dcITRAMember
	{
		static OleDbConnection conn = MainForm.myConnection;
		
		public dcITRAMember()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
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
		
		public static BindingSource GetListDataActive()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListDataActive";
			    	
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
		
		public static BindingSource GetAllSeniors()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetData_BySenior";
			    	
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
		
		public static BindingSource GetAllSeniors1()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetData_BySenior1";
			    	
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
		
		public static BindingSource GetAllManagers()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByManager";
			    	
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
		
		public static BindingSource GetAllManagers1()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByManager1";
			    	
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
		
		public static void SubmitOne(bool IsInsert, string ID_Member, string FullName, string Member_Level,
		                                string Phone, string Sex, string StartDate, string EndDate, string Status, string Email, string Role, string WorkingLocation, string Group, string Counsellor)
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
			    	myCommand.CommandText = "usp_ITRAMembers";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FullName", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Member_Level", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Phone", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Sex", OleDbType.VarWChar, 10).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@StartDate", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EndDate", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Status", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Email", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Role", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@WorkingLocation", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Counsellor", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    			    			    	
					myCommand.Parameters.Add("@Group", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
				    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@FullName"].Value = FullName;
			    	myCommand.Parameters["@Member_Level"].Value = Member_Level;
			    	myCommand.Parameters["@Phone"].Value = Phone;
			    	myCommand.Parameters["@Sex"].Value = Sex;
			    	myCommand.Parameters["@StartDate"].Value = FormatConverter.standardizeDate(StartDate);
			    	myCommand.Parameters["@EndDate"].Value = FormatConverter.standardizeDate(EndDate);
			    	myCommand.Parameters["@Status"].Value = Status;
			    	myCommand.Parameters["@Email"].Value = Email;
			    	myCommand.Parameters["@Role"].Value = Role;
			    	myCommand.Parameters["@WorkingLocation"].Value = WorkingLocation;
			    	myCommand.Parameters["@Counsellor"].Value = Counsellor;
			    	myCommand.Parameters["@Creator"].Value = Environment.UserName.ToLower();
			    	myCommand.Parameters["@Group"].Value = Group;
			    	
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
		
		public static void DeleteOne(string ID_Member)
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
			    	myCommand.CommandText = "usp_ITRAMembers";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
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
		
		public static BindingSource GetData_ByKeyLevel(string Member_Level)
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FullName", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByKeyLevel";
			    	myCommand.Parameters["@Member_Level"].Value = Member_Level;
			    	
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
		
		public static BindingSource GetManagerUp()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByManagerUp";
			    	
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
		
		public static BindingSource GetPartner()
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
			    	myCommand.CommandText = "usp_ITRAMembers";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByPartner";
			    	
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
