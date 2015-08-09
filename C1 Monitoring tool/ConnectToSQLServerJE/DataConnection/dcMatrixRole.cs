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
	/// Description of dcMatrixrole.
	/// </summary>
	public class dcMatrixrole
	{
		static OleDbConnection conn = MainForm.myConnection;
		
		public dcMatrixrole()
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
			    	myCommand.CommandText = "usp_Matrix_Role";
			    	
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
				                   	
//		public static void SubmitOne(bool IsInsert, string Client_Code, string Client_name, string Country, string Address,
//				                   	string ContactPerson1, string ContactPosition1, string Contactphone1, string ContactEmail1,
//				                   	string ContactPerson2, string ContactPosition2, string Contactphone2, string ContactEmail2,
//				                    string ContactPerson3, string ContactPosition3, string Contactphone3, string ContactEmail3, string Remarks)
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
//			    	myCommand.CommandText = "usp_Client";
// 	
//			    	
//			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Client_name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Address", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Country", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactPerson1", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactPosition1", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactEmail1", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Contactphone1", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactPerson2", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactPosition2", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactEmail2", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Contactphone2", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactPerson3", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactPosition3", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@ContactEmail3", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Contactphone3", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Remarks", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
//			    				    				    	
//			    	if(IsInsert == true)
//			    		myCommand.Parameters["@Action"].Value = "AddNew";
//			    	else
//			    		myCommand.Parameters["@Action"].Value = "Update";
//			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
//			    	myCommand.Parameters["@Client_name"].Value = Client_name;
//			    	myCommand.Parameters["@Address"].Value = Address;
//			    	myCommand.Parameters["@Country"].Value = Country;
//			    	myCommand.Parameters["@ContactPerson1"].Value = ContactPerson1;
//			    	myCommand.Parameters["@ContactPosition1"].Value = ContactPosition1;
//			    	myCommand.Parameters["@ContactEmail1"].Value = ContactEmail1;
//			    	myCommand.Parameters["@Contactphone1"].Value = Contactphone1;
//			    	myCommand.Parameters["@ContactPerson2"].Value = ContactPerson2;
//			    	myCommand.Parameters["@ContactPosition2"].Value = ContactPosition2;
//			    	myCommand.Parameters["@ContactEmail2"].Value = ContactEmail2;
//			    	myCommand.Parameters["@Contactphone2"].Value = Contactphone2;
//			    	myCommand.Parameters["@ContactPerson3"].Value = ContactPerson3;
//			    	myCommand.Parameters["@ContactPosition3"].Value = ContactPosition3;
//			    	myCommand.Parameters["@ContactEmail3"].Value = ContactEmail3;
//			    	myCommand.Parameters["@Contactphone3"].Value = Contactphone3;
//			    	myCommand.Parameters["@Remarks"].Value = Remarks;
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
//		public static void DeleteOne(string ID_Member)
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
//			    	myCommand.CommandText = "usp_Client";
// 	
//			    	
//			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
//			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
//	
//			    	myCommand.Parameters["@Action"].Value = "Delete";
//			    	myCommand.Parameters["@Client_Code"].Value = ID_Member;
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

		public static BindingSource GetDataByITRAMemberName(string ITRAMemberName)
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
			    	myCommand.CommandText = "usp_Matrix_Role";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@ITRAMemberName", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetData_by_ITRAMemberName";
			    	myCommand.Parameters["@ITRAMemberName"].Value = ITRAMemberName;
			    	
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
