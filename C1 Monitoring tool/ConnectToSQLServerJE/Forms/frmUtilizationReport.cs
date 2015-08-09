/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/29/2013
 * Time: 6:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using ExcelCOM = Microsoft.Office.Interop.Excel;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmUtilizationReport.
	/// </summary>
	public partial class frmUtilizationReport : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		int Fiscal_Year;
		public frmUtilizationReport(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pnl = mainPanel;
			
			
			//DisableExportButton(false,false,false);
			defaultCmb();
			GetFY();
			//MessageBox.Show(cmbYear1.Text);
			//DisplayGridView();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		 
//		void DisableExportButton(bool btn3, bool btn2, bool btn3)
//		{
//			btnExport1.Enabled = btn3;
//		}
		
		void GetFY()
		{
			DateTime today = DateTime.Today;
			if (today.Month >= 7)
			{
				if (today.Month == 7 && today.Day <5)				    
				    Fiscal_Year = today.Year;
				else
					Fiscal_Year = today.Year + 1;
			}				
			else
				Fiscal_Year = today.Year;
			
			
		}
		void defaultCmb()
		{
			cmbName1.DataSource = dcITRAMember.GetListDataActive();
			cmbName1.DisplayMember = "FullName";
			cmbName1.ValueMember = "ID_Member";
			cmbName1.SelectedIndex = -1;
		}
		
		void DisplayGridView()
		{
			grdTemp.DataSource = dcUtilizationReport.GetAll(Fiscal_Year.ToString());
			
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

            exSheet.Name = "Effective Utilization";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "B1");
            r.Merge();
            r.Value2 = "Effective Utilization";
            ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "B2");
            r1.Merge();
            if (radMonth.Checked)
            {
            	r1.Value2 = "Month To Date";
            }
            if (radYear.Checked)
            {
            	r1.Value2 = "Year To Date";	
            }
            exSheet.Cells[3,1] = dtpToDate.Text;
            int loc = 5;
            for (int i =0; i<= grdUtilization.Columns.Count-1;i++)
                 exSheet.Cells[5,i+2] = grdUtilization.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdUtilization.Columns.Count-1 );
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range("B5", chr.ToString()+"5");
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            
            loc =6;
            for (int i =0; i<= grdUtilization.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdUtilization.Columns.Count-1;j++)
            		exSheet.Cells[loc,j+2] = grdUtilization.Rows[i].Cells[j].Value.ToString();
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

            MessageBox.Show("Export Successfully");
			
		}
		
		void AddColumnHeader1()
		{
			while (grdUtilization.Columns.Count>0)
			{
				grdUtilization.Columns.RemoveAt(0);
			}
			if (radYear.Checked)
			{
				grdUtilization.Columns.Add("Staff Name","Staff Name");
				grdUtilization.Columns.Add("Level","Level");
				
				grdUtilization.Columns.Add("Utilization (MTD)","Utilization (MTD)");
				grdUtilization.Columns.Add("%","%");
				grdUtilization.Columns.Add("Utilization (YTD)","Utilization (YTD)");
				grdUtilization.Columns.Add("%","%");
				
			}
			if (radMonth.Checked)
			{
				
				grdUtilization.Columns.Add("Staff Name","Staff Name");
				grdUtilization.Columns.Add("Level","Level");
				grdUtilization.Columns.Add("7","7");
				grdUtilization.Columns.Add("8","8");
				grdUtilization.Columns.Add("9","9");
				grdUtilization.Columns.Add("10","10");
				grdUtilization.Columns.Add("11","11");
				grdUtilization.Columns.Add("12","12");
				grdUtilization.Columns.Add("1","1");
				grdUtilization.Columns.Add("2","2");
				grdUtilization.Columns.Add("3","3");
				grdUtilization.Columns.Add("4","4");
				grdUtilization.Columns.Add("5","5");
				grdUtilization.Columns.Add("6","6");
				grdUtilization.Columns.Add("Total","Total");
				grdUtilization.Columns.Add("%","%");
				grdUtilization.Columns[1].Frozen = true;
				//DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdUtilization);
			}
		}
		
		void GroupByName()
		{
			int i =0;
			int j =0;
			string strname ="";
			while (grdTemp2.Rows.Count >0)
			{
				grdTemp2.Rows.RemoveAt(0);
			}
			while (grdTemp2.Columns.Count >0)
			{
				grdTemp2.Columns.RemoveAt(0);
			}
			grdTemp2.Columns.Add("ID","ID");
			grdTemp2.Columns.Add("FullName","FullName");
			while (i <= grdTemp1.Rows.Count-1)
			{
				if (strname.CompareTo(grdTemp1.Rows[i].Cells[1].Value.ToString())!=0)
				{
					Object[] tempo = new Object[2];
					tempo[0] = grdTemp1.Rows[i].Cells[0].Value;
					tempo[1] = grdTemp1.Rows[i].Cells[1].Value;
					grdTemp2.Rows.Add(tempo);
					strname = grdTemp1.Rows[i].Cells[1].Value.ToString();
				}
				i++;
			}
		}
		int GetMonth(DateTime tempdate1)
		{
			DateTime tempdate2 = tempdate1;
			if (tempdate1.DayOfWeek == DayOfWeek.Saturday && tempdate1.Day <=5)
				return (tempdate1.Month-1);
			if (tempdate1.DayOfWeek == DayOfWeek.Sunday && tempdate1.Day <=6)
				return (tempdate1.Month-1);
			if (tempdate1.Day <= 4)
			{
				while (tempdate2.DayOfWeek != DayOfWeek.Friday)
					tempdate2 = tempdate2.AddDays(1);
				if (tempdate2.Day<=4)
				{
					if (tempdate2.Month == 1)
						return 12;
					else
						return (tempdate2.Month-1);
				}
				else
					return tempdate2.Month;
			}
			else
			{
				return tempdate1.Month;
			}
		}
		void YearToDate(int Fiscal_Year_ToDate)
		{
			DateTime date1 = FormatConverter.convertDateFromDBToCode(dtpToDate.Text);
			while (date1.DayOfWeek != DayOfWeek.Friday)
				{
					date1 = date1.AddDays(-1);			
				}
			DateTime date = FormatConverter.convertDateFromDBToCode(dtpToDate.Text);
									
			GroupByName();
			
			for (int i =0; i <= grdTemp2.Rows.Count - 1; i ++)
			{
				
				Object[] tempo = new Object[6];
				tempo[1] = grdTemp2.Rows[i].Cells[0].Value.ToString();
				tempo[0] = grdTemp2.Rows[i].Cells[1].Value.ToString();
				double TypeC = 0;
				double TypeP = 0;
				double TypeN =	0;
				
				double TypeC1 = 0;
				double TypeP1 = 0;
				double TypeN1 = 0;				
				
				DateTime firstweekY = date;
				DateTime firstweekM = date;
				for (int j =0; j <= grdTemp1.Rows.Count -1; j++)
					if (grdTemp2.Rows[i].Cells[1].Value.ToString() == grdTemp1.Rows[j].Cells[1].Value.ToString())
					{
						bool MTD = false;
						bool YTD = false;
						
						
						DateTime tempdate = FormatConverter.convertStrToDate(grdTemp1.Rows[j].Cells[2].Value.ToString());
						if (firstweekY >tempdate)
						    firstweekY = tempdate;
						
						if ((firstweekM >tempdate) && GetMonth(tempdate) == GetMonth(date) )
						    firstweekM = tempdate;
						if (tempdate <= date)
							YTD = true;
						if ((YTD) && GetMonth(tempdate) == GetMonth(date))
							MTD = true;

						if (YTD)
						{
							double hours = FormatConverter.standardizeDouble(grdTemp1.Rows[j].Cells[3].Value.ToString());
							TypeC = TypeC + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "C" ? hours : 0);
							TypeP = TypeP + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "P" ? hours : 0);
							TypeN = TypeN + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "N" ? hours : 0);
						}
						if (MTD)
						{
							double hours = FormatConverter.standardizeDouble(grdTemp1.Rows[j].Cells[3].Value.ToString());
							TypeC1 = TypeC1 + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "C" ? hours : 0);
							TypeP1 = TypeP1 + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "P" ? hours : 0);
							TypeN1 = TypeN1 + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "N" ? hours : 0);
						}
					}
				

				TimeSpan span= date - firstweekY;				
				Double Hours_Week_Y = 0;
				if (GetMonth(date) != GetMonth (date1))
					Hours_Week_Y = (((int) span.TotalDays + 7) /7) * 40;
				else
					Hours_Week_Y = (((int) span.TotalDays + 7 ) /7) * 40;
				Hours_Week_Y = Hours_Week_Y - TypeN;
				
				TimeSpan span1= date - firstweekM;		
				Double Hours_Week_M	=0;			
				if (GetMonth(date) != GetMonth (date1))
					Hours_Week_M = (((int) span1.TotalDays) /7) * 40;
				else
					Hours_Week_M = (((int) span1.TotalDays +7) /7) * 40;
				Hours_Week_M = Hours_Week_M - TypeN1;
				tempo[2] = (Object) TypeC1.ToString() + "/"+ Hours_Week_M.ToString();
				if (Hours_Week_M ==0)
					tempo[3] = (Object) 0;
				else
					tempo[3] = (Object) Math.Round((TypeC1/Hours_Week_M)*100,2);
				tempo[4] = (Object) TypeC.ToString() + "/"+ Hours_Week_Y.ToString();
				if (Hours_Week_Y ==0)
					tempo[5] = (Object) 0;
				else
					tempo[5] = (Object) Math.Round((TypeC/Hours_Week_Y)*100,2);
				grdUtilization.Rows.Add(tempo);
			}
			//
			
			//DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdUtilization);
		}
		void MonthToDate(int Fiscal_Year_ToDate)
		{
			
			DateTime date1 = FormatConverter.convertDateFromDBToCode(dtpToDate.Text);
			while (date1.DayOfWeek != DayOfWeek.Friday)
				{
					date1 = date1.AddDays(-1);			
				}
			DateTime date = FormatConverter.convertDateFromDBToCode(dtpToDate.Text);
			grdTemp.DataSource = dcWeekEndGeneration.GetData_ByFY(Fiscal_Year_ToDate.ToString());
			GroupByName();
			DateTime firstweekY = date;
			for (int i =0; i <= grdTemp2.Rows.Count - 1; i ++)
			{
				double[] MonthsC = new double[12]{0,0,0,0,0,0,0,0,0,0,0,0};
				double[] MonthsP = new double[12]{0,0,0,0,0,0,0,0,0,0,0,0};
				double[] MonthsT = new double[12]{0,0,0,0,0,0,0,0,0,0,0,0};
				double[] MonthsN = new double[12]{0,0,0,0,0,0,0,0,0,0,0,0};
				int[] M_FY = new int[12]{7,8,9,10,11,12,1,2,3,4,5,6};
				DateTime[] Months = DateSupport.GetLastDayinYear(Fiscal_Year_ToDate);
//				for (int u =1; u<=12; u++)
//				{
////					int year = (u>=7 ? Fiscal_Year_ToDate-1:Fiscal_Year_ToDate);
////					DateTime lastday = new DateTime(year, u, DateTime.DaysInMonth(year,u));
////					
////					Months[Array.IndexOf(M_FY,u)] = lastday;
//					//MessageBox.Show(Months[u].ToShortDateString());
//				}	
				Object[] tempo = new Object[16];
				tempo[1] = grdTemp2.Rows[i].Cells[0].Value.ToString();
				tempo[0] = grdTemp2.Rows[i].Cells[1].Value.ToString();
				for (int j =0; j <= grdTemp1.Rows.Count -1; j++)
					if (grdTemp2.Rows[i].Cells[1].Value.ToString() == grdTemp1.Rows[j].Cells[1].Value.ToString())
					{
						
						DateTime tempdate = FormatConverter.convertStrToDate(grdTemp1.Rows[j].Cells[2].Value.ToString());
						if (firstweekY > tempdate)
							firstweekY = tempdate;
						int tempint =Array.IndexOf(M_FY, GetMonth(tempdate));
//						MessageBox.Show(tempdate.ToShortDateString() + " - " + tempdate.DayOfWeek.ToString() + " - "
//						                + tempint.ToString());
						if (Months[Array.IndexOf(M_FY, GetMonth(tempdate))] > tempdate)
							Months[Array.IndexOf(M_FY, GetMonth(tempdate))] = tempdate;
						if (tempdate <= date)
						{
							double hours = FormatConverter.standardizeDouble(grdTemp1.Rows[j].Cells[3].Value.ToString());
							MonthsC[Array.IndexOf(M_FY, GetMonth(tempdate))] = MonthsC[Array.IndexOf(M_FY, GetMonth(tempdate))] + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "C" ? hours : 0);
							MonthsP[Array.IndexOf(M_FY, GetMonth(tempdate))] = MonthsC[Array.IndexOf(M_FY, GetMonth(tempdate))] + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "P" ? hours : 0);
							MonthsN[Array.IndexOf(M_FY, GetMonth(tempdate))] = MonthsN[Array.IndexOf(M_FY, GetMonth(tempdate))] + (grdTemp1.Rows[j].Cells[4].Value.ToString() == "N" ? hours : 0);
						}
						
					}
				double totalH = 0;
				double totalC = 0;
				for (int k=0; k <=Array.IndexOf(M_FY,GetMonth(date))-1; k++)
				{
					if (MonthsC[k] ==0 && MonthsP[k] ==0 && MonthsC[k] ==0)
						tempo[k+2] = (Object) "0/0" ;
					else
					{
						//TimeSpan span= Months[k+1] - Months[k];
						int year = ((M_FY[k])>=7) ? Fiscal_Year_ToDate-1:Fiscal_Year_ToDate;
						int day = DateSupport.DoM(M_FY[k],year);
						//MessageBox.Show(day.ToString());
						MonthsT[k] = ((day /7) * 40) - MonthsN[k];
						tempo[k+2] = (Object) MonthsC[k].ToString() + "/" +  MonthsT[k].ToString();
						totalH = totalH + MonthsT[k];
						totalC = totalC + MonthsC[k];
					}
				}
				if (GetMonth(date) == GetMonth(date1))
				{
				    //TimeSpan span= date1 - Months[Array.IndexOf(M_FY,GetMonth(date))];
				    int year = (GetMonth(date)>=7) ? Fiscal_Year_ToDate-1:Fiscal_Year_ToDate;
					int day = DateSupport.DoM(GetMonth(date),year);
					//Double Hours_Week_Y = 0;
					MonthsT[Array.IndexOf(M_FY,GetMonth(date))] = ((day /7) * 40) - MonthsN[Array.IndexOf(M_FY,GetMonth(date))];
					tempo[Array.IndexOf(M_FY,GetMonth(date))+2] = (Object) MonthsC[Array.IndexOf(M_FY,GetMonth(date))].ToString() + "/" +  MonthsT[Array.IndexOf(M_FY,GetMonth(date))].ToString();
					totalH = totalH +MonthsT[Array.IndexOf(M_FY,GetMonth(date))];
					totalC = totalC + MonthsC[Array.IndexOf(M_FY,GetMonth(date))];
				}
				else
					tempo[Array.IndexOf(M_FY,GetMonth(date))+2] = (Object)  "0/0";
				for (int v= Array.IndexOf(M_FY,GetMonth(date))+1; v<=11; v++)
					tempo[v+2] = (Object) "0/0";
				//totalH = totalH;
				tempo[14] = (Object) totalC.ToString() +"/"+totalH.ToString();
				tempo[15] = (Object) Math.Round((totalC/totalH)*100,2);
				grdUtilization.Rows.Add(tempo);
			}
			//DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdUtilization);	
		}
		int choose=0;
		void BtnSubmitClick(object sender, EventArgs e)
		{
			//DisableExportButton(true,false,false);
			DateTime date = FormatConverter.convertDateFromDBToCode(dtpToDate.Text);
			if (radWTD.Checked && date.DayOfWeek != DayOfWeek.Friday)
				return;
			int Fiscal_Year_ToDate = 2013;
			if (GetMonth(date) == 6 && date.Month == 7)
				Fiscal_Year = date.Year;
			else
			{
				if (GetMonth(date) >= 7)
				{
					if (GetMonth(date) == 12 && date.Month ==1)
						Fiscal_Year_ToDate = date.Year;	
					else
						Fiscal_Year_ToDate = date.Year + 1;
				}				
				else
					Fiscal_Year_ToDate = date.Year;								
			}
			//MessageBox.Show(Fiscal_Year_ToDate.ToString());
			BindingSource temp;
			if (radMonth.Checked || radYear.Checked)
			{

				temp = dcUtilizationReport.GetAll_Week(Fiscal_Year_ToDate.ToString());
				temp.Filter = "FullName LIKE '%" + cmbName1.Text + "%'";
				//temp.Sort = "FullName";
				grdTemp1.DataSource = temp;
				grdTemp1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
				
				RemoveGrd();
				AddColumnHeader1();
				if (radYear.Checked)
				{
					YearToDate(Fiscal_Year_ToDate);
					choose =1;
				}
				if (radMonth.Checked)
				{
					MonthToDate(Fiscal_Year_ToDate);
					choose =2;
				}
			}
			if (radWTD.Checked)
			{
				choose =3;
				RemoveGrd();
				//MessageBox.Show("1");
				temp = dcUtilizationReport.GetData_ByWeekEnd(date.ToShortDateString());
				temp.Filter = "Member_Name LIKE '%" + cmbName1.Text + "%'";
				//temp.Sort = "FullName";
				grdUtilization.DataSource = temp;
				//MessageBox.Show("1");
				grdUtilization.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			}
			
			if (radTargetH.Checked)
			{
				choose =4;
				RemoveGrd();
				//MessageBox.Show("1");
				int fyear = DateSupport.GetFiscalYear(DateTime.Today);
				DateTime begin = new DateTime(fyear-1,7,1);
				DateTime end = new DateTime(fyear,6,30);
				
				temp = dcUtilizationReport.GetTargetHoursNextWeek(fyear.ToString(),end,begin);
				temp.Filter = "Member_Name LIKE '%" + cmbName1.Text + "%'";
				//temp.Sort = "FullName";
				grdUtilization.DataSource = temp;
				//MessageBox.Show("1");
				grdUtilization.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			}
			
		
			
		}
		
		
		void AddColumnHeader2()
		{
			while (grdUtilization.Columns.Count>0)
			{
				grdUtilization.Columns.RemoveAt(0);
			}
				grdUtilization.Columns.Add("Staff ID","Staff ID");
				grdUtilization.Columns.Add("Staff Name","Staff Name");
				grdUtilization.Columns.Add("Engagement Code","Engagement Code");
				grdUtilization.Columns.Add("Engagement Name","Engagement Name");
				grdUtilization.Columns.Add("Budget Hours","BudgetHours");
				grdUtilization.Columns.Add("Charged Hours","Charged Hours");
				grdUtilization.Columns.Add("Remain Hours","Remain Hours");
				grdUtilization.Columns.Add("% Hours Exceed","% Hours Exceed");
				grdUtilization.Columns[3].Frozen = true;
		}
		
		
		void RemoveGrd()
		{
			if (grdUtilization.DataSource != null)
			{
				grdUtilization.DataSource = null;
				return;
			}
			while (grdUtilization.Rows.Count >0)
			{
				grdUtilization.Rows.RemoveAt(0);
			}
			while (grdUtilization.Columns.Count >0)
			{
				grdUtilization.Columns.RemoveAt(0);
			}
		}
		
		void BtnExport2Click(object sender, EventArgs e)
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

            exSheet.Name = "Utilization Report per Employee";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Utilization Report per Employee";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
			r1.Value2 = Fiscal_Year.ToString();
            int loc = 4;
            for (int i =0; i<= grdUtilization.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdUtilization.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdUtilization.Columns.Count-1 );
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range("B4", chr.ToString()+"4");
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =5;
            for (int i =0; i<= grdUtilization.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdUtilization.Columns.Count-1;j++)
            		if (grdUtilization.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdUtilization.Rows[i].Cells[j].Value.ToString();
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
				
		
		void AddColumnHeader3()
		{
			while (grdUtilization.Columns.Count>0)
			{
				grdUtilization.Columns.RemoveAt(0);
			}
				grdUtilization.Columns.Add("Engagement Name","Engagement Name");
				grdUtilization.Columns.Add("Engagement Code","Engagement Code");
				
				grdUtilization.Columns.Add("Staff ID","Staff ID");
				grdUtilization.Columns.Add("Staff Name","Staff Name");
				grdUtilization.Columns.Add("Budget Hours","BudgetHours");
				grdUtilization.Columns.Add("Charged Hours","Charged Hours");
				grdUtilization.Columns.Add("Remain Hours","Remain Hours");
				grdUtilization.Columns.Add("% Hours Exceed","% Hours Exceed");
				grdUtilization.Columns[3].Frozen = true;
		}
				
		void BtnExport3Click(object sender, EventArgs e)
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

            exSheet.Name = "Utilization per Engagement";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Utilization Report per Engagement";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
			r1.Value2 = Fiscal_Year.ToString();
            int loc = 4;
            for (int i =0; i<= grdUtilization.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdUtilization.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdUtilization.Columns.Count-1 );
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range("B4", chr.ToString()+"4");
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =5;
            for (int i =0; i<= grdUtilization.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdUtilization.Columns.Count-1;j++)
            		if (grdUtilization.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdUtilization.Rows[i].Cells[j].Value.ToString();
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
		
		void BtnReset1Click(object sender, EventArgs e)
		{
			cmbName1.SelectedIndex = -1;
			dtpToDate.Text = DateTime.Today.ToShortDateString();
			RemoveGrd();
			//DisableExportButton(false,false,false);
		}
		
//		void DtpToDateValueChanged(object sender, EventArgs e)
//		{
//			DisableExportButton(false,false,false);
//		}
		
		void GrdUtilizationColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			//e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void GrdUtilizationCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex<0)
				return;
			if (grdUtilization.DataSource == null)
				return;
			if (choose !=3)
				return;
			if (grdUtilization.Rows[e.RowIndex].Cells["Week_Ending"].Value.ToString() == "")
				return;
			
			DateTime date2 = FormatConverter.convertStrToDate(grdUtilization.Rows[e.RowIndex].Cells["Week_Ending"].Value.ToString());
			
			
			Form frmpopup = new frmUtilization_Popup(date2.ToShortDateString(),
												grdUtilization.Rows[e.RowIndex].Cells["Member_Name"].Value.ToString());
			
			frmpopup.ShowDialog();
		}
		
		void RadWTDCheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
