/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/21/2013
 * Time: 3:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Net;
using ExcelCOM = Microsoft.Office.Interop.Excel;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmTimesheet.
	/// </summary>
	public partial class frmTimesheet1 : MyFormPage
	{
		int Fiscal_Year = 2013;
		public frmTimesheet1(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			dt = new DataTable();
			ds = new DataSet();
			
			setDataTableFields();
			grdTimesheet.Visible = false;
		
			CheckWeekEnd();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			if (Role_type == 2)
			{
				chkLogin.Enabled = false;
				
				btnReset.Enabled = false;
			}
			else 
			{
				
				chkLogin.Enabled = true;
				btnReset.Enabled = true;
			}
		}
		
		void CheckWeekEnd()
		{
			DateTime today = new DateTime();
			today = DateTime.Today;
			if (today.DayOfWeek != DayOfWeek.Friday)
			{
				while (today.DayOfWeek != DayOfWeek.Friday)
				{
					today = today.AddDays(+1);
				}
			}
			bool _insert = true;
			
			if (today.Month >= 7)
			{
				if (today.Month == 7 && today.Day <5)				    
				    Fiscal_Year = today.Year;
				else
				{
					Fiscal_Year = today.Year + 1;
				}
			}				
			else
				Fiscal_Year = today.Year;
			DisplayGridViewWE();
			string[] months = new string[12]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
			for (int i =0; i <= grdWeekEnd.Rows.Count-2; i++)
			{
				string Week_Ending = today.Day.ToString() + " " + months[today.Month-1] + " " + today.Year.ToString();
				//MessageBox.Show(Week_Ending+" - "+grdWeekEnd.Rows[i].Cells[0].Value.ToString());
				if (Week_Ending == grdWeekEnd.Rows[i].Cells[0].Value.ToString())
					_insert = false;
			}
			
			if (_insert)
			{
				string Week_Ending = today.Day.ToString() + " " + months[today.Month-1] + " " + today.Year.ToString();
				//MessageBox.Show(Week_Ending);
				DateTime date1 = new DateTime(2012,7,6);
				TimeSpan span= today - date1;
				int weeks = ((int) span.TotalDays) /7;
				long templink1 = 63477129600L + 86400*7*weeks;
				string linkAdd = "http://gte2asiapac.ey.net/Timesheets/TimesheetHome.aspx?weekEnd=" + templink1.ToString() + "0000000";
				dcWeekEndGeneration.SubmitOne(true, Week_Ending, linkAdd, Fiscal_Year.ToString());
				DisplayGridViewWE();
			}
			
		}
		
		string LinkToWeek(DateTime week_date)
		{
			//MessageBox.Show(Week_Ending);
				DateTime date1 = new DateTime(2012,7,6);
				TimeSpan span= week_date - date1;
				int weeks = ((int) span.TotalDays) /7;
				long templink1 = 63477129600L + 86400*7*weeks;
				string linkAdd = "http://gte2asiapac.ey.net/Timesheets/TimesheetHome.aspx?weekEnd=" + templink1.ToString() + "0000000";
				return linkAdd;
		}
		
		DataTable dt;
		DataSet ds;
		// Click button reset
		void BtnResetClick(object sender, EventArgs e)
		{
			Reset();
		}
		
		void Reset()
		{
			txtPwd.Text = "";
			txtUser.Text = "";
		}
		
		string getYear(string weekend)
		{
			DateTime temp = FormatConverter.convertStrToDate(weekend);
			int fsy = 0;
			if (temp.Month >= 7)
			{
				if (temp.Month == 7 && temp.Day <5)				    
				    fsy = temp.Year;
				else
				{
					fsy = temp.Year + 1;
				}
			}				
			else
				fsy = temp.Year;
			return fsy.ToString();
		}
		
		
		// Click button Submit		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			//MessageBox.Show(chkLogin.Checked.ToString());
			if ((chkLogin.Checked) && ((txtPwd.Text =="") || (txtUser.Text == "")))
			{
				MessageBox.Show("Please input your Username and Password in Domain");
				return;
			}		
			dt.Clear();
			pgb1.Visible = true;
			grdTimesheet.Visible = false;
			bool first = true;
			
			if (rdb13Ws.Checked) 
			{
				pgb1.Minimum =1;
				pgb1.Maximum = 13;
				pgb1.Value =1;
				pgb1.Step = 1;				
				
				DateTime today = new DateTime();
				today = DateTime.Today;
				if (today.DayOfWeek != DayOfWeek.Friday)
				{
					while (today.DayOfWeek != DayOfWeek.Friday)
					{
						today = today.AddDays(+1);
					}
				}	
				string[] months = new string[12]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
				for (int i = 1 ; i <=13; i++)
				{
					string Week_Link = 	LinkToWeek(today);
					string Week_Ending = today.Day.ToString() + " " + months[today.Month-1] + " " + today.Year.ToString();
					//MessageBox.Show(Week_Ending);
					WebAuthentication WebAuth1;
					if (!chkLogin.Checked)
						WebAuth1 = new WebAuthentication("", "");
					else
						WebAuth1 = new WebAuthentication(txtUser.Text, txtPwd.Text);
            	
					string source = WebAuth1.AuthenticateWeb(Week_Link);
					if (source == "FALSE")
						break;
					if (!chkLogin.Checked)
					{
						dcTimesheet1.DeleteOnePerWeek2(Environment.UserName,Week_Ending);
						dcTimesheet1.CopyOldDataPerWeek(Environment.UserName,Week_Ending);
						dcTimesheet1.DeleteOnePerWeek(Environment.UserName,Week_Ending);
					}
						else
					{
							dcTimesheet1.DeleteOnePerWeek2(txtUser.Text,Week_Ending);
							dcTimesheet1.CopyOldDataPerWeek(txtUser.Text,Week_Ending);
							dcTimesheet1.DeleteOnePerWeek(txtUser.Text,Week_Ending);
					}
	            	HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();            
	            	doc.LoadHtml(source);
	            	DayListing(doc,Week_Ending);
	            	pgb1.PerformStep();
	            	today = today.AddDays(-7);
				}
				pgb1.Visible = false;
			}
			
			
			if (rdbY2D.Checked)
			{
				pgb1.Minimum =1;
				pgb1.Maximum = grdWeekEnd.Rows.Count-1;
				pgb1.Value =1;
				pgb1.Step = 1;	
				
				
				for (int i = 0 ; i <=grdWeekEnd.Rows.Count-2; i++)
				//for (int i = 0 ; i <=3; i++)
				{
					WebAuthentication WebAuth1;
					if (!chkLogin.Checked)
						WebAuth1 = new WebAuthentication("", "");
					else
						WebAuth1 = new WebAuthentication(txtUser.Text, txtPwd.Text);
            		
					string source = WebAuth1.AuthenticateWeb(grdWeekEnd.Rows[i].Cells[1].Value.ToString());					
					if (source == "FALSE")
						break;
					if (first == true)
					{
						if (!chkLogin.Checked)
						{
							dcTimesheet1.DeleteOne2(Environment.UserName,Fiscal_Year.ToString());
							dcTimesheet1.CopyOldDataPerYear(Environment.UserName,Fiscal_Year.ToString());
							dcTimesheet1.DeleteOne(Environment.UserName,Fiscal_Year.ToString());
						}
						else
						{
							dcTimesheet1.DeleteOne2(txtUser.Text,Fiscal_Year.ToString());
							dcTimesheet1.CopyOldDataPerYear(txtUser.Text,Fiscal_Year.ToString());
							dcTimesheet1.DeleteOne(txtUser.Text,Fiscal_Year.ToString());
						}
						first = false;
					}
	            	HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();            
	            	doc.LoadHtml(source);
	            	DayListing(doc,grdWeekEnd.Rows[i].Cells[0].Value.ToString());
	            	pgb1.PerformStep();
				}
				pgb1.Visible = false;
			}
			grdTimesheet.DataSource = dt;
			grdTimesheet.Visible = true;
			
		}
		public virtual string ConvertBlankText(HtmlAgilityPack.HtmlNode Original)
		{
			string output = "";
			if (Original.InnerText == "&nbsp;")
				return output;
			return Original.InnerText;
		}
		void DayListing(HtmlAgilityPack.HtmlDocument doc, string weekend)
		{
			
			foreach(HtmlAgilityPack.HtmlNode week_ending in doc.DocumentNode.SelectNodes("//span[@id='ctl00_contentPH_ucTimesheetHeader_lblWeekEnding']"))
			{	
				//MessageBox.Show(week_ending.InnerText + " - " + weekend);
				if (week_ending.InnerText != weekend)
					return;
			}
			
			string status = "";
			foreach(HtmlAgilityPack.HtmlNode _status in doc.DocumentNode.SelectNodes("//span[@id='ctl00_contentPH_ucTimesheetHeader_lblStatus']"))
			{	
				status = _status.InnerText;
				//MessageBox.Show(week_ending.InnerText + " - " + weekend);
				if (_status.InnerText == "Draft")
					return;
			}
			
			
			foreach(HtmlAgilityPack.HtmlNode link in doc.DocumentNode.SelectNodes("//table[@id='G_ctl00xcontentPHxgrdTimesheet']/tr"))
			 {
            	HtmlAgilityPack.HtmlAttribute tempatt = link.Attributes["id"];
            	string pathfind = "//tr[@id='" + tempatt.Value + "']/td";            	
            	HtmlAgilityPack.HtmlNodeCollection nodecollection = link.SelectNodes(pathfind);
            
            	if (nodecollection[6].InnerText != "&nbsp;")
            	{
					Object[] tempO = new Object[7];
					int lastindex = nodecollection.Count;
					if (chkLogin.Checked)
						tempO[0] = txtUser.Text;
					else 
						tempO[0] = Environment.UserName.ToLower();
					tempO[1] = weekend;
					tempO[6] = status;
					//MessageBox.Show(tempO[6].ToString());
					
						string nodestring = ConvertBlankText(nodecollection[5]);
						string nodestring1 = ConvertBlankText(nodecollection[3]);
						
						if (nodestring.Length == 1)
						{
							tempO[2] = ConvertBlankText(nodecollection[6]);
							tempO[3] = ConvertBlankText(nodecollection[7]);
							tempO[5] = ConvertBlankText(nodecollection[5]);
						}
						else
						{
							tempO[2] = ConvertBlankText(nodecollection[5]);
							tempO[3] = ConvertBlankText(nodecollection[7]);
							tempO[5] = ConvertBlankText(nodecollection[4]);
						}
						if (nodestring1.Length == 1)
						{
							tempO[2] = ConvertBlankText(nodecollection[4]);
							tempO[3] = ConvertBlankText(nodecollection[5]);
							tempO[5] = ConvertBlankText(nodecollection[3]);
						}
					tempO[4] = ConvertBlankText(nodecollection[lastindex-1]);
					dcTimesheet1.SubmitOne((string) tempO[2], (string) tempO[3], (string) tempO[0],(string) tempO[1], (string) tempO[6], float.Parse((string) tempO[4]), (string) tempO[5], getYear(weekend));
					dt.Rows.Add(tempO);
					
					
            	}
			 }
		}
		
		void WeekListing(HtmlAgilityPack.HtmlDocument doc)
		{
			foreach(HtmlAgilityPack.HtmlNode link in doc.DocumentNode.SelectNodes("//table[@id='ctl00_contentPH_grdResults']/tr/td/a"))
			 {
				
				HtmlAgilityPack.HtmlAttribute att = link.Attributes["href"];
            	string url = "http://gte2asiapac.ey.net/Timesheets/" + att.Value.ToString();            	
            	WebAuthentication WebAuth1 = new WebAuthentication(txtUser.Text, txtPwd.Text);
            	string	source1 = WebAuth1.AuthenticateWeb(url);
            	//StreamWriter stream = new StreamWriter(link.InnerText + ".html");
            	//stream.Write(source1);
            	HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();            
            	doc1.LoadHtml(source1);
            	DayListing(doc1,link.InnerText);
            	//stream.Close();
			 }
		}
		
		
		
		public void addColumnToDatatable( 
            ref DataTable table, // reference to the actual datatable
            string fieldName,    // field name you want to add
            string type,         // Data type just as c# se
            object defaultValue)
        {
            DataColumn auxColumn = new DataColumn(fieldName, System.Type.GetType(type));
            auxColumn.DefaultValue = defaultValue;
            table.Columns.Add(auxColumn);
        }
		
		private void setDataTableFields()
        {
            addColumnToDatatable(ref dt, "Username", "System.String", "" );
			addColumnToDatatable(ref dt, "Week", "System.String", "" );
            addColumnToDatatable(ref dt, "Engagement Code", "System.String", "" );           
            addColumnToDatatable(ref dt, "Engagement Name", "System.String", "" );               
            addColumnToDatatable(ref dt, "Total", "System.String", "" );            
            addColumnToDatatable(ref dt, "Type", "System.String", "" );
            addColumnToDatatable(ref dt, "Status", "System.String", "" );
        }
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void DisplayGridViewWE()
		{
			grdWeekEnd.DataSource = dcWeekEndGeneration.GetData_ByFY(Fiscal_Year.ToString());
			grdWeekEnd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (chkLogin.Checked)
				groupBox1.Enabled = true;
			else
				groupBox1.Enabled = false;
		}
		
		void BtnExport1Click(object sender, EventArgs e)
		{
			char chr = 'B';
			
			SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "result.xls";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
            	return;
            }
            
            string path = sfd.FileName;
			
			ExcelCOM.Application exApp = new ExcelCOM.Application();
            ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
            ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
	
            exSheet.Name = "Timesheet Report";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Timesheet Report";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
            
            	r1.Value2 = "Current";
            int loc = 4;
            for (int i =0; i<= grdTimesheet.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdTimesheet.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdTimesheet.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[4,2],exSheet.Cells[4,2 + grdTimesheet.Columns.Count -1]);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =5;
            for (int i =0; i<= grdTimesheet.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdTimesheet.Columns.Count-1;j++)
            		if (grdTimesheet.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdTimesheet.Rows[i].Cells[j].Value.ToString();
            	}
            	loc = loc + 1;
            }
            
            exSheet.Columns.AutoFit();
            

            exApp.Visible = false;
            exBook.SaveAs(path, ExcelCOM.XlFileFormat.xlWorkbookNormal,
                null, null, false, false,
                ExcelCOM.XlSaveAsAccessMode.xlExclusive,
                false, false, false, false, false);

            exBook.Close(false, false, false);
            exApp.Quit();           

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);

            MessageBox.Show("Export Successfully" );			
		}
	}
}
