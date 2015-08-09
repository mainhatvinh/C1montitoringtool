/*
 * Created by SharpDevelop.
 * User: Luan.Khanh.Ha
 * Date: 6/17/2013
 * Time: 11:15 AM
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
	/// Description of dcWorkSatusReport.
	/// </summary>
	public class dcWorkSatusReport
	{
		public dcWorkSatusReport()
		{
		}
		static OleDbConnection conn = MainForm.myConnection;
		
		public static BindingSource GetData_ByKey(string Engagement_ID, string Fiscal_Year)
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
			    	myCommand.CommandText = "[rpt_WorkStatus_by_Engagement]";		    				    	
			    	myCommand.Parameters.Add("@Engagement_ID", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	myCommand.Parameters.Add("@Fiscal_Year", OleDbType.VarWChar, 255).Direction = ParameterDirection.Input;
			    	if (Engagement_ID !="")
			    		myCommand.Parameters["@Engagement_ID"].Value = Engagement_ID;
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
