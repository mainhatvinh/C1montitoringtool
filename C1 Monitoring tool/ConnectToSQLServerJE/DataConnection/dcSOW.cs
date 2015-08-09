/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 5/24/2013
 * Time: 4:42 PM
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
	/// Description of dcSOW.
	/// </summary>
	public class dcSOW
	{
		static OleDbConnection conn = MainForm.myConnection;
		
		public dcSOW()
		{
		}
		
//		public static BindingSource GetAll()
//		{						
//			DataTable myDataTable = new DataTable();
//			OleDbCommand myCommand = new OleDbCommand();
//			BindingSource myBuidingSource = new BindingSource();
//			
//			try
//			{			    
//			    if (conn.State == ConnectionState.Open)
//			    {
//			    	myCommand.Connection = conn;
//			    	myCommand.CommandType = CommandType.StoredProcedure;
//			    	myCommand.CommandText = "usp_Workstatus";
//			    	
//			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
//			    	myCommand.Parameters["@Action"].Value = "GetListData";
//			    	
//			    	OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
//			    	myAdapter.Fill(myDataTable);
//			    	myBuidingSource.DataSource = myDataTable;	    	
//			    }
//			    else
//			    	MessageBox.Show("Connection failed!");
//			}
//			catch(Exception ex)
//			{
//			    MessageBox.Show(ex.ToString());
//			}
//			
//			return myBuidingSource;
//		}
		
//		public static BindingSource GetListEng()
//		{						
//			DataTable myDataTable = new DataTable();
//			OleDbCommand myCommand = new OleDbCommand();
//			BindingSource myBuidingSource = new BindingSource();
//			
//			try
//			{			    
//			    if (conn.State == ConnectionState.Open)
//			    {
//			    	myCommand.Connection = conn;
//			    	myCommand.CommandType = CommandType.StoredProcedure;
//			    	myCommand.CommandText = "usp_Workstatus";
//			    	
//			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
//			    	myCommand.Parameters["@Action"].Value = "GetListEng";
//			    	
//			    	OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
//			    	myAdapter.Fill(myDataTable);
//			    	myBuidingSource.DataSource = myDataTable;	    	
//			    }
//			    else
//			    	MessageBox.Show("Connection failed!");
//			}
//			catch(Exception ex)
//			{
//			    MessageBox.Show(ex.ToString());
//			}
//			
//			return myBuidingSource;
//		}
		
		public static void SubmitOne(bool isInsert, string Engagement_ID, bool SOX,
		                          bool IT_Complexity_Assessment, bool ML_Follow_Up,
		                          bool JE_Testing, bool ITGCs,
								  bool Application_Control_testing, bool EAE_Report_Testing,
								  bool Data_Migration, bool BPR)
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
			    	myCommand.CommandText = "usp_Engagement_SOW";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_ID", OleDbType.Integer).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@ML_Follow_Up", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITGCs", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BPR", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Application_Control_testing", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@JE_Testing", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EAE_Report_Testing", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_Complexity_Assessment", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SOX", OleDbType.Boolean).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Data_Migration", OleDbType.Boolean).Direction = ParameterDirection.Input;

			    	if (isInsert == true)
				    	myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    	{
			    		myCommand.Parameters["@Action"].Value = "Update";
			    		myCommand.Parameters["@Engagement_ID"].Value = int.Parse(Engagement_ID);
			    	}
			    	myCommand.Parameters["@ML_Follow_Up"].Value = ML_Follow_Up;
			      	myCommand.Parameters["@ITGCs"].Value = ITGCs;
			    	myCommand.Parameters["@BPR"].Value = BPR;
			    	myCommand.Parameters["@Application_Control_testing"].Value = Application_Control_testing;
			    	myCommand.Parameters["@JE_Testing"].Value = JE_Testing;
			    	myCommand.Parameters["@EAE_Report_Testing"].Value = EAE_Report_Testing;
			    	myCommand.Parameters["@IT_Complexity_Assessment"].Value = IT_Complexity_Assessment;;
			    	myCommand.Parameters["@SOX"].Value = SOX;
			    	myCommand.Parameters["@Data_Migration"].Value = Data_Migration;
			    	
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
				
		public static void DeleteOne(string Engagement_ID)
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
			    	myCommand.CommandText = "usp_Engagement_SOW";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_ID", OleDbType.Integer).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@Engagement_ID"].Value = Engagement_ID;
			    	
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
		
		public static BindingSource GetDataByKey(string Engagement_ID)
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
			    	myCommand.CommandText = "usp_Engagement_SOW";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters.Add("@Engagement_ID", OleDbType.Integer).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Action"].Value = "GetData_ByKey";
			    	myCommand.Parameters["@Engagement_ID"].Value = Engagement_ID;
			    	
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
