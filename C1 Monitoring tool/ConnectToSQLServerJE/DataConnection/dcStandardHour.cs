/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 9/6/2013
 * Time: 10:29 AM
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
	/// Description of dcStandardHour.
	/// </summary>
	public class dcStandardHour
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcStandardHour()
		{
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
			    	myCommand.CommandText = "[usp_RT_Member_Utilization]";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FYear", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByFYear";
			    	myCommand.Parameters["@FYear"].Value = EY_FY;
			    	
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
		
		public static void SubmitOne(string Member_Level, string FYear,
		                             string July, string August, string September, string October, string November, string December
		                            ,string January, string February, string March, string April, string May, string June)
		{
			OleDbCommand myCommand = new OleDbCommand();
			
			try
			{
			    if (conn.State == ConnectionState.Open)
			    {
			    	myCommand.Connection = conn;
			    	myCommand.CommandType = CommandType.StoredProcedure;
			    	myCommand.CommandText = "usp_RT_Member_Utilization";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Member_Level", OleDbType.VarChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FYear", OleDbType.VarChar, 4).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@July", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@August", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@September", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@October", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@November", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@December", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@January", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@February", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@March", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@April", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@May", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@June", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "AddNew";
			    	myCommand.Parameters["@Member_Level"].Value = Member_Level;
			    	myCommand.Parameters["@FYear"].Value = FYear;
			    	myCommand.Parameters["@July"].Value = July;
			    	myCommand.Parameters["@August"].Value = August;
			    	myCommand.Parameters["@September"].Value = September;
			    	myCommand.Parameters["@October"].Value = October;
			    	myCommand.Parameters["@November"].Value = November;
			    	myCommand.Parameters["@December"].Value = December;
			    	myCommand.Parameters["@January"].Value = January;
			    	myCommand.Parameters["@February"].Value = February;
			    	myCommand.Parameters["@March"].Value = March;
			    	myCommand.Parameters["@April"].Value = April;
			    	myCommand.Parameters["@May"].Value = May;
			    	myCommand.Parameters["@June"].Value = June;
			    	
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
