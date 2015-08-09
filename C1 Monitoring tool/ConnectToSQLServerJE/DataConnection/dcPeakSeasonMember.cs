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
	/// Description of dcPeakSeasonMember.
	/// </summary>
	public class dcPeakSeasonMember
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcPeakSeasonMember()
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
			    	myCommand.CommandText = "usp_Peak_Season_Member";
			    	
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

		public static BindingSource GetDataByFY(string EY_FY)
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
			    	myCommand.CommandText = "usp_Peak_Season_Member";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@EY_FY", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByFY";
			    	myCommand.Parameters["@EY_FY"].Value = EY_FY;
			    	
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
		
		public static void SubmitOne(bool IsInsert, string EY_FY, string Fullname)
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
			    	myCommand.CommandText = "usp_Peak_Season_Member";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EY_FY", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fullname", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    			    			    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	myCommand.Parameters["@EY_FY"].Value = EY_FY;
			    	myCommand.Parameters["@Fullname"].Value = Fullname;
			    				    	
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
		
		public static void DeleteOne(string EY_FY, string Fullname)
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
			    	myCommand.CommandText = "usp_Peak_Season_Member";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EY_FY", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fullname", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    				    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@EY_FY"].Value = EY_FY;
			    	myCommand.Parameters["@Fullname"].Value = Fullname;
			    	
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
		
		
		public static BindingSource GetData_ByFY(string EY_FY)
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
			    	myCommand.CommandText = "usp_Peak_Season";
			    	
			    	//myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@EY_FY", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	
			    	//myCommand.Parameters["@Action"].Value = "GetData_ByFY";
			    	myCommand.Parameters["@EY_FY"].Value = EY_FY;
			    	
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
		public static void SubmitData(string EY_FY, string ID_Member, string Fullname, string Member_Level,
		                             	string Jul, string Aug, string Sep, string Oct, string Nov, string Dec
		                             	,string Jan, string Feb, string Mar, string Apr, string May, string Jun)
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
			    	myCommand.CommandText = "usp_Peak_Season_Member";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EY_FY", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Member", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fullname", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Jul", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Aug", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Sep", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Oct", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Nov", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Dec", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Jan", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Feb", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Mar", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Apr", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@May", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Jun", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					
					

			    		myCommand.Parameters["@Action"].Value = "AddorInsert";

			    	myCommand.Parameters["@EY_FY"].Value = EY_FY;
			    	myCommand.Parameters["@ID_Member"].Value = ID_Member;
			    	myCommand.Parameters["@Fullname"].Value = Fullname;
			    	myCommand.Parameters["@Member_Level"].Value = Member_Level;
			    	myCommand.Parameters["@Jul"].Value = FormatConverter.standardizeDouble(Jul);
			    	myCommand.Parameters["@Aug"].Value = FormatConverter.standardizeDouble(Aug);
			    	myCommand.Parameters["@Sep"].Value = FormatConverter.standardizeDouble(Sep);
			    	myCommand.Parameters["@Oct"].Value = FormatConverter.standardizeDouble(Oct);
			    	myCommand.Parameters["@Nov"].Value = FormatConverter.standardizeDouble(Nov);
			    	myCommand.Parameters["@Dec"].Value = FormatConverter.standardizeDouble(Dec);
			    	myCommand.Parameters["@Jan"].Value = FormatConverter.standardizeDouble(Jan);
			    	myCommand.Parameters["@Feb"].Value = FormatConverter.standardizeDouble(Feb);
			    	myCommand.Parameters["@Mar"].Value = FormatConverter.standardizeDouble(Mar);
			    	myCommand.Parameters["@Apr"].Value = FormatConverter.standardizeDouble(Apr);
			    	myCommand.Parameters["@May"].Value = FormatConverter.standardizeDouble(May);
			    	myCommand.Parameters["@Jun"].Value = FormatConverter.standardizeDouble(Jun);
			    				    	
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
