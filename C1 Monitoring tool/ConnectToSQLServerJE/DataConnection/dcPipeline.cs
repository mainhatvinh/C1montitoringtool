/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 7/25/2014
 * Time: 4:38 PM
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
	/// Description of Class1.
	/// </summary>
	public class dcPipeline
	{
		public dcPipeline()
		{
		}
		static OleDbConnection conn = MainForm.myConnection;
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
			    	myCommand.CommandText = "usp_RT_Pipeline";
			    	
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
		
		public static BindingSource GetAllReport()
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
			    	myCommand.CommandText = "rpt_C2Pipeline";
			    	
			    	//myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	//myCommand.Parameters["@Action"].Value = "GetListData";
			    	
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
		
		public static void SubmitOne(bool IsInsert, string  pipeline_ID, string PIC, string MIC, string SIC,
				                   	string Client_Code, string Office, string Service_Type, string Engagement_Description,
				                    string Status, string Information_Update,
				                    string Action_Plan, string Decision, string Fee_USD, string EYFYearFrom, string EYFYearTo, string FYearFrom, string FYearTo)
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
			    	myCommand.CommandText = "usp_RT_Pipeline";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@pipeline_ID", OleDbType.Numeric,18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@PIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@MIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Office", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Service_Type", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Description", OleDbType.LongVarChar, 255).Direction = ParameterDirection.Input;
			    	//myCommand.Parameters.Add("@FYear", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	//myCommand.Parameters.Add("@EYFYear", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Status", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Information_Update", OleDbType.LongVarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Action_Plan", OleDbType.LongVarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Decision", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fee_USD", OleDbType.Numeric,18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EYFYearFrom", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@EYFYearTo", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@FYearFrom", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@FYearTo", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    		myCommand.Parameters["@Action"].Value = "Update";
			    	myCommand.Parameters["@pipeline_ID"].Value = FormatConverter.standardizeInt(pipeline_ID);
			    	myCommand.Parameters["@PIC"].Value = PIC;
			    	myCommand.Parameters["@MIC"].Value = MIC;
			    	myCommand.Parameters["@SIC"].Value = SIC;
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
			    	myCommand.Parameters["@Office"].Value = Office;
			    	myCommand.Parameters["@Service_Type"].Value = Service_Type;
			    	myCommand.Parameters["@Engagement_Description"].Value = Engagement_Description;
			    	//myCommand.Parameters["@FYear"].Value = FYear;
			    	//myCommand.Parameters["@EYFYear"].Value = EYFYear;
			    	myCommand.Parameters["@Status"].Value = Status;
			    	myCommand.Parameters["@Information_Update"].Value = Information_Update;
			    	myCommand.Parameters["@Action_Plan"].Value = Action_Plan;
			    	myCommand.Parameters["@Decision"].Value = Decision;
			    	myCommand.Parameters["@Fee_USD"].Value = FormatConverter.standardizeDouble(Fee_USD);
			    	//myCommand.Parameters["@Creator"].Value = Environment.UserName.ToLower();
			    	myCommand.Parameters["@EYFYearFrom"].Value = EYFYearFrom;
			    	myCommand.Parameters["@EYFYearTo"].Value = EYFYearTo;
			    	myCommand.Parameters["@FYearFrom"].Value = FYearFrom;
			    	myCommand.Parameters["@FYearTo"].Value = FYearTo;
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
		
		public static void DeleteOne(string pipeline_ID)
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
			    	myCommand.CommandText = "usp_RT_Pipeline";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@pipeline_ID", OleDbType.Numeric,18).Direction = ParameterDirection.Input;
	
			    	myCommand.Parameters["@Action"].Value = "Delete_byKey";
			    	myCommand.Parameters["@pipeline_ID"].Value = FormatConverter.standardizeInt(pipeline_ID);
			    	
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
