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
	/// Description of dcWorkStatus.
	/// </summary>
	public class dcWorkStatus
	{
		static OleDbConnection conn = MainForm.myConnection;
		
		public dcWorkStatus()
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
			    	myCommand.CommandText = "usp_Workstatus";
			    	
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
		
		public static void AddNewOrUpdate(string Engagement_ID, 
			                             string Gamx_status, string Planning_Meeting_With_FAS,
			                             string Scoping_Argee, string IT_Planning_Memo_and_Budget,
			                             string IT_Planning_Memo_and_Budget_Addendum, string YearEnd_Updated,
			                             string Resulted_Disscuss_With_FAS, string Gamx_Documentation,
			                             string Ready_for_Archiving_and_Inform_FAS,
			                             string ML_Follow_Up, string ML_Follow_Up_Review,
			                             string IT_Complexity_Assessment, string IT_Complexity_Assessment_Review,
			                             string ITGCs, string ITGCs_Review,
			                             string BPR, string BPR_Review,
			                             string Application_Control_testing, string Application_Control_testing_Review,
					                     string EAE_Report_Testing, string EAE_Report_Testing_Review,
					                     string JE_Testing, string JE_Testing_Review,
					                     string Data_Migration, string Data_Migration_Review,
					                     string SOX, string SOX_Review,
					                     string SRM, string SRM_Review,
					                     string ML, string ML_Review)
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
			    	myCommand.CommandText = "usp_Workstatus";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_ID", OleDbType.Integer).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Gamx_status", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Planning_Meeting_With_FAS", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Scoping_Argee", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_Planning_Memo_and_Budget", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_Planning_Memo_and_Budget_Addendum", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@YearEnd_Updated", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Resulted_Disscuss_With_FAS", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Gamx_Documentation", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Ready_for_Archiving_and_Inform_FAS", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ML_Follow_Up", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ML_Follow_Up_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_Complexity_Assessment", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_Complexity_Assessment_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITGCs", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITGCs_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BPR", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BPR_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Application_Control_testing", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Application_Control_testing_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EAE_Report_Testing", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EAE_Report_Testing_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@JE_Testing", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@JE_Testing_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Data_Migration", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Data_Migration_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SOX", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SOX_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SRM", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SRM_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ML", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ML_Review", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;

					myCommand.Parameters["@Action"].Value = "AddNewOrUpdate";
			    	myCommand.Parameters["@Engagement_ID"].Value = int.Parse(Engagement_ID);
			      	myCommand.Parameters["@Gamx_status"].Value = Gamx_status;
			    	myCommand.Parameters["@Planning_Meeting_With_FAS"].Value = Planning_Meeting_With_FAS;
			    	myCommand.Parameters["@Scoping_Argee"].Value = Scoping_Argee;
			    	myCommand.Parameters["@IT_Planning_Memo_and_Budget"].Value = IT_Planning_Memo_and_Budget;
			    	myCommand.Parameters["@IT_Planning_Memo_and_Budget_Addendum"].Value = IT_Planning_Memo_and_Budget_Addendum;
			    	myCommand.Parameters["@YearEnd_Updated"].Value = YearEnd_Updated;;
			    	myCommand.Parameters["@Resulted_Disscuss_With_FAS"].Value = Resulted_Disscuss_With_FAS;
			    	myCommand.Parameters["@Gamx_Documentation"].Value = Gamx_Documentation;
			    	myCommand.Parameters["@Ready_for_Archiving_and_Inform_FAS"].Value = Ready_for_Archiving_and_Inform_FAS;
			    	myCommand.Parameters["@ML_Follow_Up"].Value = ML_Follow_Up;
			    	myCommand.Parameters["@ML_Follow_Up_Review"].Value = FormatConverter.standardizeDate(ML_Follow_Up_Review);
			    	myCommand.Parameters["@IT_Complexity_Assessment"].Value = IT_Complexity_Assessment;
			    	myCommand.Parameters["@IT_Complexity_Assessment_Review"].Value = FormatConverter.standardizeDate(IT_Complexity_Assessment_Review);
			    	myCommand.Parameters["@ITGCs"].Value = ITGCs;
			    	myCommand.Parameters["@ITGCs_Review"].Value = FormatConverter.standardizeDate(ITGCs_Review);
			    	myCommand.Parameters["@BPR"].Value = BPR;
			    	myCommand.Parameters["@BPR_Review"].Value = FormatConverter.standardizeDate(BPR_Review);
			    	myCommand.Parameters["@Application_Control_testing"].Value = Application_Control_testing;;
			    	myCommand.Parameters["@Application_Control_testing_Review"].Value = FormatConverter.standardizeDate(Application_Control_testing_Review);
			    	myCommand.Parameters["@EAE_Report_Testing"].Value = EAE_Report_Testing;
			    	myCommand.Parameters["@EAE_Report_Testing_Review"].Value = FormatConverter.standardizeDate(EAE_Report_Testing_Review);
			    	myCommand.Parameters["@JE_Testing"].Value = JE_Testing;		    	
			    	myCommand.Parameters["@JE_Testing_Review"].Value = FormatConverter.standardizeDate(JE_Testing_Review);
			    	myCommand.Parameters["@Data_Migration"].Value = Data_Migration;
			    	myCommand.Parameters["@Data_Migration_Review"].Value = FormatConverter.standardizeDate(Data_Migration_Review);
			    	myCommand.Parameters["@SOX"].Value = SOX;
			    	myCommand.Parameters["@SOX_Review"].Value = FormatConverter.standardizeDate(SOX_Review);
			    	myCommand.Parameters["@SRM"].Value = SRM;
			    	myCommand.Parameters["@SRM_Review"].Value = FormatConverter.standardizeDate(SRM_Review);
			    	myCommand.Parameters["@ML"].Value = ML;
			    	myCommand.Parameters["@ML_Review"].Value = FormatConverter.standardizeDate(ML_Review);
			    	
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
			    	myCommand.CommandText = "usp_Workstatus";
 	
			    	
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
			    	myCommand.CommandText = "usp_Workstatus";
			    	
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
