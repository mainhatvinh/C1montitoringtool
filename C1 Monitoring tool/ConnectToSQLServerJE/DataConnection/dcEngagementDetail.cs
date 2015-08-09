/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 7/30/2013
 * Time: 3:57 PM
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
	/// Description of dcEngagementDetail.
	/// </summary>
	public class dcEngagementDetail
	{
		static OleDbConnection conn = MainForm.myConnection;
		public dcEngagementDetail()
		{
		}
		
		public static BindingSource GetEngSOW_BySIC(string Revenue_Source, string Fiscal_Year)
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
			    	myCommand.CommandText = "[rpt_Engagements_SOW_ITRA_SIC]";
			    	
			    	myCommand.Parameters.Add("@Revenue_Source", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					if (Revenue_Source != "")
			    		myCommand.Parameters["@Revenue_Source"].Value = Revenue_Source;
					
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
		
		public static BindingSource GetEngSOW_ByMIC(string Revenue_Source, string Fiscal_Year)
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
			    	myCommand.CommandText = "[rpt_Engagements_SOW_ITRA_MIC]";
			    	
			    	myCommand.Parameters.Add("@Revenue_Source", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					if (Revenue_Source != "")
			    		myCommand.Parameters["@Revenue_Source"].Value = Revenue_Source;
					
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
		
		public static BindingSource GetEngSOW_ByStaff(string Revenue_Source, string Fiscal_Year)
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
			    	myCommand.CommandText = "[rpt_Engagements_SOW_ITRA_Staff]";
			    	
			    	myCommand.Parameters.Add("@Revenue_Source", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					if (Revenue_Source != "")
			    		myCommand.Parameters["@Revenue_Source"].Value = Revenue_Source;
					
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
		
		public static BindingSource GetEngSOW_Detail(string Revenue_Source, string Fiscal_Year, int SorM, string Person)
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
			    	myCommand.CommandText = "[rpt_Engagements_SOW_Detail]";
			    	
			    	myCommand.Parameters.Add("@Revenue_Source", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					myCommand.Parameters.Add("@SorM", OleDbType.Boolean).Direction = ParameterDirection.Input;
					myCommand.Parameters.Add("@Person", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					if (Revenue_Source != "")
			    		myCommand.Parameters["@Revenue_Source"].Value = Revenue_Source;
					
			    	myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
			    	myCommand.Parameters["@SorM"].Value = SorM;
			    	myCommand.Parameters["@Person"].Value = Person;
			    	
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
		
		public static BindingSource GetEngSOW_Staff_Detail(string Revenue_Source, string Fiscal_Year, string Person)
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
			    	myCommand.CommandText = "[rpt_Engagements_SOW_ITRA_Staff_Detail]";
			    	
			    	myCommand.Parameters.Add("@Revenue_Source", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					myCommand.Parameters.Add("@ITRA_Staff", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					if (Revenue_Source != "")
			    		myCommand.Parameters["@Revenue_Source"].Value = Revenue_Source;
					
			    	myCommand.Parameters["@Fiscal_Year"].Value = Fiscal_Year;
			    	//myCommand.Parameters["@SorM"].Value = SorM;
			    	myCommand.Parameters["@ITRA_Staff"].Value = Person;
			    	
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
		
		public static BindingSource GetEng_Detail(string Revenue_Source, string Fiscal_Year)
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
			    	myCommand.CommandText = "[rpt_Engagements_Detail]";
			    	
			    	myCommand.Parameters.Add("@Revenue_Source", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;	
					myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarChar, 255).Direction = ParameterDirection.Input;			    				    				    	
					
					if (Revenue_Source != "")
			    		myCommand.Parameters["@Revenue_Source"].Value = Revenue_Source;
					
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
		
	}
}
