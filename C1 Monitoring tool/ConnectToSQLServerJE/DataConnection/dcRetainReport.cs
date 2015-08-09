/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/17/2013
 * Time: 4:10 PM
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
	/// Description of dcRetainReport.
	/// </summary>
	public class dcRetainReport
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcRetainReport()
		{
			
		}
		
		public static BindingSource GetAll(DateTime FromDate, DateTime ToDate, string SIC, String MIC)
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
			    	myCommand.CommandText = "[rpt_Retain_by_Employee_3Months]";		    				    	
			    	myCommand.Parameters.Add("@FromDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ToDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@SIC", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@MIC", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;
					myCommand.Parameters["@FromDate"].Value = FromDate;
					myCommand.Parameters["@ToDate"].Value = ToDate;
					myCommand.Parameters["@SIC"].Value = SIC;
					myCommand.Parameters["@MIC"].Value = MIC;
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
		
		public static BindingSource GetAll_SumHour(DateTime FromDate, DateTime ToDate)
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
			    	myCommand.CommandText = "[rpt_Retain_by_Employee_TotalHours_6Months]";		    				    	
			    	myCommand.Parameters.Add("@FromDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ToDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	
					myCommand.Parameters["@FromDate"].Value = FromDate;
					myCommand.Parameters["@ToDate"].Value = ToDate;
					
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
		
		public static BindingSource GetListRetainEng(string Month, string Year)
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
			    	myCommand.CommandText = "[rpt_Retain_by_Engagement]";
			    	
			    	
			    	myCommand.Parameters.Add("@Month", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Year", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Month"].Value = FormatConverter.standardizeInt(Month);
			    	myCommand.Parameters["@Year"].Value = FormatConverter.standardizeInt(Year);
			    	
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
		
		public static BindingSource GetTotalHour_ByEng(string Month, string Year)
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
			    	myCommand.CommandText = "[rpt_Retain_by_Engagement_TotalHours_3Months]";
			    	
			    	
			    	myCommand.Parameters.Add("@Month", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Year", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
			    	myCommand.Parameters["@Month"].Value = FormatConverter.standardizeInt(Month);
			    	myCommand.Parameters["@Year"].Value = FormatConverter.standardizeInt(Year);
			    	
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
		
		public static BindingSource GetAll_SumHour_ByType(string Year, string Month)
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
			    	myCommand.CommandText = "[rpt_Retain_by_Employee_TotalHours_CPN]";		    				    	
			    	myCommand.Parameters.Add("@Month", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Year", OleDbType.Numeric, 18).Direction = ParameterDirection.Input;
			    	
					myCommand.Parameters["@Year"].Value = FormatConverter.standardizeInt(Year);
					myCommand.Parameters["@Month"].Value = FormatConverter.standardizeInt(Month);
					
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
		
		
		public static BindingSource GetAll_SumHour_ByType_FromDate(DateTime FromDate, DateTime ToDate)
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
			    	myCommand.CommandText = "[rpt_Retain_by_Employee_TotalHours_CPN]";		    				    	
			    	myCommand.Parameters.Add("@FromDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@ToDate", OleDbType.Date).Direction = ParameterDirection.Input;
			    	
					myCommand.Parameters["@FromDate"].Value = FromDate;
					myCommand.Parameters["@ToDate"].Value = ToDate;
					
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
