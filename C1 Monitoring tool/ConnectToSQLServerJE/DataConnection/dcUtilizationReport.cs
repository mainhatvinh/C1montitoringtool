/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 06/10/2013
 * Time: 3:34 PM
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
	/// Description of dcUtilizationReport.
	/// </summary>
	public class dcUtilizationReport
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcUtilizationReport()
		{
		}
		public static BindingSource GetAll(string Fiscal_Year)
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
			    	myCommand.CommandText = "[rpt_Utilization per Employee ID_1]";		    				    	
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
					myCommand.Parameters["@Fiscal_Year"].Value = FormatConverter.standardizeInt(Fiscal_Year);
					
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
		
		public static BindingSource GetAll_SMIC(string Fiscal_Year, string MIC, string SIC)
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
			    	myCommand.CommandText = "[rpt_Budget_Actual_Per_SIC_MIC_Revenue]";	
//					myCommand.CommandText = "[rpt_Utilization_per_week_with_status]";			    	
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@MIC", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SIC", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
					myCommand.Parameters["@MIC"].Value = MIC;
					myCommand.Parameters["@SIC"].Value = SIC;
					
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
		
		
		public static BindingSource GetAll_Week(string Fiscal_Year)
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
			    	myCommand.CommandText = "[rpt_Utilization_per_week]";		    				    	
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
					
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
		
		public static BindingSource GetData_ByWeekEnd(string Week_Ending)
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
			    	myCommand.CommandText = "[rpt_Utilization_per_week_with_status]";		    				    	
			    	myCommand.Parameters.Add("@Week_Ending", OleDbType.Date).Direction = ParameterDirection.Input;
			    	//MessageBox.Show(Week_Ending);
			    	myCommand.Parameters["@Week_Ending"].Value = Week_Ending;
					
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
		
		public static BindingSource GetData_ByWeekEnd_Detail(string Week_Ending, string Fullname)
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
			    	myCommand.CommandText = "[rpt_Utilization_per_week_with_status_detail]";		    				    	
			    	myCommand.Parameters.Add("@Week_Ending", OleDbType.DBDate).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fullname", OleDbType.VarWChar,255).Direction = ParameterDirection.Input;
					myCommand.Parameters["@Week_Ending"].Value = Week_Ending;
					myCommand.Parameters["@Fullname"].Value = Fullname;
					
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
		
		
		public static BindingSource GetData_ByEngagement_Detail(string Fullname, string Engagement_Code)
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
			    	myCommand.CommandText = "[rpt_Budget_Actual_Charged_detail]";		    				    	
			    	myCommand.Parameters.Add("@Fullname", OleDbType.VarWChar,255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Engagement_Code", OleDbType.VarWChar,255).Direction = ParameterDirection.Input;
					myCommand.Parameters["@Fullname"].Value = Fullname;
					myCommand.Parameters["@Engagement_Code"].Value = Engagement_Code;
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
		
		public static BindingSource GetTargetHoursNextWeek(string Fiscal_Year, DateTime YEnd, DateTime YBegind)
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
			    	myCommand.CommandText = "[rpt_Utilization_For_Nextweek]";		    				    	
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@YEnd", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@YBegind", OleDbType.Date).Direction = ParameterDirection.Input;
					myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
					myCommand.Parameters["@YEnd"].Value = YEnd;
					myCommand.Parameters["@YBegind"].Value = YBegind;
					
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
