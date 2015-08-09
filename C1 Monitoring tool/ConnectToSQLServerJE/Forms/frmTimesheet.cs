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

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmTimesheet.
	/// </summary>
	public partial class frmTimesheet : MyFormPage
	{
		int Fiscal_Year = 2013;
		public frmTimesheet(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			dt = new DataTable();
			ds = new DataSet();
			comboBox1.Text = "2013";
			setDataTableFields();
			grdTimesheet.Visible = false;
		
			CheckWeekEnd();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CheckWeekEnd()
		{
			DateTime today = new DateTime();
			today = DateTime.Today;
			if (today.DayOfWeek != DayOfWeek.Friday)
			{
				while (today.DayOfWeek != DayOfWeek.Friday)
				{
					today = today.AddDays(-1);
			
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
			
			Fiscal_Year = int.Parse(comboBox1.Text);
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
			
			if (rdb13Ws.Checked) {
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
						today = today.AddDays(-1);
				
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
							dcTimesheet1.DeleteOnePerWeek(Environment.UserName,Week_Ending);
						else 
							dcTimesheet1.DeleteOnePerWeek(txtUser.Text,Week_Ending);

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
							dcTimesheet1.DeleteOne(Environment.UserName,Fiscal_Year.ToString());
						else 
							dcTimesheet1.DeleteOne(txtUser.Text,Fiscal_Year.ToString());
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
			
			foreach(HtmlAgilityPack.HtmlNode link in doc.DocumentNode.SelectNodes("//table[@id='G_ctl00xcontentPHxgrdTimesheet']/tr"))
			 {
            	HtmlAgilityPack.HtmlAttribute tempatt = link.Attributes["id"];
            	string pathfind = "//tr[@id='" + tempatt.Value + "']/td";            	
            	HtmlAgilityPack.HtmlNodeCollection nodecollection = link.SelectNodes(pathfind);
            
            	if (nodecollection[5].InnerText != "&nbsp;")
            	{
					Object[] tempO = new Object[5];
					int lastindex = nodecollection.Count;
					if (chkLogin.Checked)
						tempO[0] = txtUser.Text;
					else 
						tempO[0] = Environment.UserName.ToLower();
					tempO[1] = weekend;
					
						string nodestring = ConvertBlankText(nodecollection[5]);
						string nodestring1 = ConvertBlankText(nodecollection[3]);
						
						if (nodestring.Length == 1)
						{
							tempO[2] = ConvertBlankText(nodecollection[6]);
							tempO[4] = ConvertBlankText(nodecollection[5]);
						}
						else
						{
							tempO[2] = ConvertBlankText(nodecollection[5]);
							tempO[4] = ConvertBlankText(nodecollection[4]);
						}
						if (nodestring1.Length == 1)
						{
							tempO[2] = ConvertBlankText(nodecollection[4]);
							tempO[4] = ConvertBlankText(nodecollection[3]);
						}
					
					tempO[3] = ConvertBlankText(nodecollection[lastindex-1]);
					//dcTimesheet1.SubmitOne((string) tempO[2],(string) tempO[0],(string) tempO[1], float.Parse((string) tempO[3]), (string) tempO[4], getYear(weekend));
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
            addColumnToDatatable(ref dt, "Total", "System.String", "" );            
            addColumnToDatatable(ref dt, "Type", "System.String", "" );
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
	}
}
