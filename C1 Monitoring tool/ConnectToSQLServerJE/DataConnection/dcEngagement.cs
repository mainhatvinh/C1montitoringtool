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
	/// Description of dcEngagement.
	/// </summary>
	public class dcEngagement
	{
		static OleDbConnection conn = MainForm.myConnection;
		
		public dcEngagement()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
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
		
		public static BindingSource GetC2Engagement()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListC2";
			    	
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
		
		public static BindingSource GetSIC(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@ID_Engagement", OleDbType.Integer).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters["@Action"].Value = "GetSIC";
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
		
		public static BindingSource GetMIC(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@ID_Engagement", OleDbType.Integer).Direction = ParameterDirection.Input;			    	
			    	myCommand.Parameters["@Action"].Value = "GetMIC";
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
		
		public static BindingSource GetAll_WithStatus()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListData_Non_Budget";
			    	
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
		
		public static BindingSource GetAll_C2Engagement()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListData_C2Engagement";
			    	
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
		
		public static BindingSource GetListEngNotBudget()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "CheckListEngagementNotBudget";
			    	
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
		
		public static BindingSource GetAllC1()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListC1";
			    	
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
		
		public static BindingSource GetAllC12()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListC1&2";
			    	
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
		
		public static BindingSource GetAllNC()
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;			    				    	
			    	myCommand.Parameters["@Action"].Value = "GetListNC";
			    	
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
		
		public static void SubmitOne(bool IsInsert, string ID_Engagement, string Fiscal_Year, string Engagement_Code, string Engagement_Name, string Client_Code,
										string ERP_Planned, string FAS_SIC, string Audit_Hours, string ITRA_Fee, 
										string FieldWorkDate, string FieldWork_Location, string Feedback_EY_Eagle, string IT_ML_Release_Date,
										string FS_Release_date, string Remark, string Engagement_Type, string EAGle_Status,
										string AQR, string RevenueSource,
									    string ITRA_SIC, string ITRA_MIC, string ERP_PrevActual, string ClientYE, string FAS_MIC)
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Integer).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Type", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Code", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FAS_SIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITRA_Fee", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Audit_Hours", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FS_Release_date", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ERP_Planned", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_ML_Release_Date", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Feedback_EY_Eagle", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IndustryBusiness", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FieldWork_Location", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EAGle_Status", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@AQR", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Remark", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FieldWorkDate", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@RevenueSource", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITRA_SIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITRA_MIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ERP_PrevActual", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ClientYE", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FAS_MIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    			    			    	
			    				 
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    	{
			    		myCommand.Parameters["@Action"].Value = "Update";
			    		myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	}			    	
			    	myCommand.Parameters["@Engagement_Type"].Value = Engagement_Type;
			    	myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
			    	myCommand.Parameters["@Engagement_Code"].Value = Engagement_Code;
			    	myCommand.Parameters["@Engagement_Name"].Value = Engagement_Name;
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
			    	myCommand.Parameters["@FAS_SIC"].Value = FAS_SIC;
			    	myCommand.Parameters["@ITRA_Fee"].Value = FormatConverter.standardizeDouble(FormatConverter.skipComma(ITRA_Fee));
			    	myCommand.Parameters["@Audit_Hours"].Value = FormatConverter.standardizeDouble(FormatConverter.skipComma(Audit_Hours));
			    	myCommand.Parameters["@FS_Release_date"].Value = FormatConverter.standardizeDate(FS_Release_date);
			    	myCommand.Parameters["@ERP_Planned"].Value = FormatConverter.standardizeDouble(ERP_Planned);
			    	myCommand.Parameters["@IT_ML_Release_Date"].Value = IT_ML_Release_Date;
			    	myCommand.Parameters["@Feedback_EY_Eagle"].Value = Feedback_EY_Eagle;
			    	myCommand.Parameters["@FieldWork_Location"].Value = FieldWork_Location;
			    	myCommand.Parameters["@EAGle_Status"].Value = EAGle_Status;		    	
			    	myCommand.Parameters["@AQR"].Value = AQR;
			    	myCommand.Parameters["@Remark"].Value = Remark;	
			    	myCommand.Parameters["@FieldWorkDate"].Value = FormatConverter.standardizeDate(FieldWorkDate);
			    	myCommand.Parameters["@RevenueSource"].Value = RevenueSource;
			    	myCommand.Parameters["@ITRA_SIC"].Value = ITRA_SIC;
			    	myCommand.Parameters["@ITRA_MIC"].Value = ITRA_MIC;
			    	myCommand.Parameters["@ERP_PrevActual"].Value = FormatConverter.standardizeDouble(ERP_PrevActual);
			    	myCommand.Parameters["@ClientYE"].Value = ClientYE;
			    	myCommand.Parameters["@FAS_MIC"].Value = FAS_MIC;
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
		
		public static void C2SubmitOne(bool IsInsert, string ID_Engagement, string Fiscal_Year, string Engagement_Code, string Engagement_Name, string Client_Code,
										string ERP_Planned, string ITRA_Fee, string FieldWork_Location, string Remark, string C2_Status, string RevenueSource,
									    string ITRA_SIC, string ITRA_MIC, string C2_CloseDate, string C2_PIC, string ClientYE, string C2_Work_Completion, string C2_Billing, string C2_Collection, string C2_DetailSOW)
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
 	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Integer).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Type", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Code", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Name", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Client_Code", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FAS_SIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITRA_Fee", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Audit_Hours", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FS_Release_date", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ERP_Planned", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_ML_Release_Date", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Feedback_EY_Eagle", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IndustryBusiness", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FieldWork_Location", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EAGle_Status", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@AQR", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Remark", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FieldWorkDate", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@RevenueSource", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITRA_SIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ITRA_MIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ERP_PrevActual", OleDbType.Double).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ClientYE", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@FAS_MIC", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Creator", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    			    			    	
			    	myCommand.Parameters.Add("@ITGCs", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@BPR", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Application_Control_testing", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@JE_Testing", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@EAE_Report_Testing", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@IT_Complexity_Assessment", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SOX", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Data_Migration", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@C2_Status", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@C2_PIC", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@C2_Work_Completion", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@C2_Billing", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@C2_Collection", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@C2_CloseDate", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@C2_DetailSOW", OleDbType.VarChar, 500).Direction = ParameterDirection.Input;
			    	
			    	if(IsInsert == true)
			    		myCommand.Parameters["@Action"].Value = "AddNew";
			    	else
			    	{
			    		myCommand.Parameters["@Action"].Value = "Update";
			    		myCommand.Parameters["@ID_Engagement"].Value = FormatConverter.standardizeInt(ID_Engagement);
			    	}			    	
			    	myCommand.Parameters["@Engagement_Type"].Value = "Channel 2";
			    	myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
			    	myCommand.Parameters["@Engagement_Code"].Value = Engagement_Code;
			    	myCommand.Parameters["@Engagement_Name"].Value = Engagement_Name;
			    	myCommand.Parameters["@Client_Code"].Value = Client_Code;
			    	//myCommand.Parameters["@FAS_SIC"].Value = FAS_SIC;
			    	myCommand.Parameters["@ITRA_Fee"].Value = FormatConverter.standardizeDouble(FormatConverter.skipComma(ITRA_Fee));
			    	//myCommand.Parameters["@Audit_Hours"].Value = FormatConverter.standardizeDouble(FormatConverter.skipComma(Audit_Hours));
			    	//myCommand.Parameters["@FS_Release_date"].Value = FormatConverter.standardizeDate(FS_Release_date);
			    	myCommand.Parameters["@ERP_Planned"].Value = FormatConverter.standardizeDouble(ERP_Planned);
			    	//myCommand.Parameters["@IT_ML_Release_Date"].Value = IT_ML_Release_Date;
			    	//myCommand.Parameters["@Feedback_EY_Eagle"].Value = Feedback_EY_Eagle;
			    	myCommand.Parameters["@FieldWork_Location"].Value = FieldWork_Location;
			    	//myCommand.Parameters["@EAGle_Status"].Value = EAGle_Status;		    	
			    	//myCommand.Parameters["@AQR"].Value = AQR;
			    	myCommand.Parameters["@Remark"].Value = Remark;	
			    	//myCommand.Parameters["@FieldWorkDate"].Value = FormatConverter.standardizeDate(FieldWorkDate);
			    	myCommand.Parameters["@RevenueSource"].Value = RevenueSource;
			    	myCommand.Parameters["@ITRA_SIC"].Value = ITRA_SIC;
			    	myCommand.Parameters["@ITRA_MIC"].Value = ITRA_MIC;
			    	
			    	myCommand.Parameters["@C2_Status"].Value = C2_Status;
			    	myCommand.Parameters["@C2_PIC"].Value = C2_PIC;
			    	myCommand.Parameters["@C2_Work_Completion"].Value = C2_Work_Completion;
			    	myCommand.Parameters["@C2_Billing"].Value = C2_Billing;
			    	myCommand.Parameters["@C2_Collection"].Value = C2_Collection;
			    	myCommand.Parameters["@C2_CloseDate"].Value = C2_CloseDate;
			    	myCommand.Parameters["@FieldWork_Location"].Value = FieldWork_Location;
			    	myCommand.Parameters["@C2_DetailSOW"].Value = C2_DetailSOW;
			    	
			    	//myCommand.Parameters["@ERP_PrevActual"].Value = FormatConverter.standardizeDouble(ERP_PrevActual);
			    	//myCommand.Parameters["@ClientYE"].Value = ClientYE;
			    	//myCommand.Parameters["@FAS_MIC"].Value = FAS_MIC;
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
		
		public static void DeleteOne(string ID_Engagement)
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
			    	myCommand.CommandText = "usp_WorkingEngagement";
 	
			    	
			    	myCommand.Parameters.Add("@Action", OleDbType.VarWChar, 50).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ID_Engagement", OleDbType.Integer).Direction = ParameterDirection.Input;
			    				    	
			    	myCommand.Parameters["@Action"].Value = "Delete";
			    	myCommand.Parameters["@ID_Engagement"].Value = ID_Engagement;
			    	
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
