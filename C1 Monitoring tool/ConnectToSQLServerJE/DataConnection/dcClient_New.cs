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
	public class dcClient_New
	{
		static OleDbConnection conn = MainForm.myConnection;
		
		public dcClient_New()
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
			    	myCommand.CommandText = "usp_Client_New";
			    	
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
		
		public static BindingSource GetData_ByKey_ClientContact(string ID_ClientContact, string Client_Code)
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
			    	myCommand.CommandText = "usp_Client_Contact";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_ClientContact", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "GetData_ByKey";
			    	myCommand.Parameters["@ID_ClientContact"].Value = FormatConverter.standardizeInt(ID_ClientContact);
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
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

	public static BindingSource GetData_ByKey(string Client_Code)
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
			    	myCommand.CommandText = "usp_Client_New";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "GetData_ByKey";
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
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

	public static BindingSource GetRemark(string Client_Code)
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
			    	myCommand.CommandText = "usp_Client_New";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters["@Action"].Value = "GetRemarks";
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
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
	
	public static BindingSource GetApplication_ByKey(string ID_Client_App, string Client_Code)
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
			    	myCommand.Parameters["@Action"].Value = "GetApplication_ByKey";
			    	myCommand.Parameters["@ID_Client_App"].Value = FormatConverter.standardizeInt(ID_Client_App);
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
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
	
	
public static void DeleteClientContactOne(string ID_ClientContact)
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
			    	myCommand.CommandText = "usp_Client_Contact";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_ClientContact", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@ID_ClientContact"].Value = ID_ClientContact;
			    	
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
		
		
		public static void SubmitOne(bool IsInsert, string Client_Code, string Client_name, string Country, string Address,
				                   	 string Remarks, string DummyCode, string ITRA_Client)
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
			    	myCommand.CommandText = "usp_Client_New";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Address", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Country", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Remarks", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@DummyCode", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Creator", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    				    				    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
			    	myCommand.Parameters["@Client_name"].Value = Client_name;
			    	myCommand.Parameters["@Address"].Value = Address;
			    	myCommand.Parameters["@Country"].Value = Country;
			    	myCommand.Parameters["@Remarks"].Value = Remarks;
			    	myCommand.Parameters["@DummyCode"].Value = DummyCode;
			    	myCommand.Parameters["@Creator"].Value = Environment.UserName.ToLower();
			    	myCommand.Parameters["@ITRA_Client"].Value = ITRA_Client;
			    	
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
		
	public static void SubmitOne1(bool IsInsert, string ID_ClientContact, string ClientCode, string Contact_Position, string Contact_Name, string Contact_Email, string Contact_Phone)
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
			    	myCommand.CommandText = "usp_Client_Contact";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_ClientContact", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Contact_Position", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Contact_Name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Contact_Email", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Contact_Phone", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	
			    	myCommand.Parameters["@ID_ClientContact"].Value = FormatConverter.standardizeInt(ID_ClientContact);
			    	myCommand.Parameters["@Client_Code"].Value = ClientCode;
			    	myCommand.Parameters["@Contact_Position"].Value = Contact_Position;
			    	myCommand.Parameters["@Contact_Name"].Value = Contact_Name;
			    	myCommand.Parameters["@Contact_Email"].Value = Contact_Email;
			    	myCommand.Parameters["@Contact_Phone"].Value = Contact_Phone;
			    	
			    	
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
			    	myCommand.CommandText = "usp_Client_New";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@Client_Code"].Value = ID_Member;
			    	
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
		
		public static void UpdateClient(string Client_Code, string Client_Code_New)
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
			    	myCommand.CommandText = "usp_Client_New";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Address", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Country", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Remarks", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@DummyCode", OleDbType.VarChar, 1).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Creator", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code_New", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	
			    	myCommand.Parameters["@Action"].Value = "UpdateClient";
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
			    	myCommand.Parameters["@Client_Code_New"].Value = Client_Code_New;

			    	
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
