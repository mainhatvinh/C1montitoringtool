/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/29/2013
 * Time: 6:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;



using ExcelCOM = Microsoft.Office.Interop.Excel;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmRetainReport.
	/// </summary>
	public partial class frmRetainReport : MyFormPage
	{
		DateTime[] arrDate;
		BindingSource myBindingSource = new BindingSource();
	
		
		public frmRetainReport(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pnl = mainPanel;
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			groupBox2.Enabled = false;
			groupBox3.Enabled = false;
			
			DisplayCmb();
			DisplayCmbMonthYear();
			DisplayDefaultCmb();
			myBindingSource = dcRetainReport.GetListRetainEng(cmbMonth.Text,cmbYear.Text);
			cmbEngName.DataSource = myBindingSource;
				cmbEngName.DisplayMember = "Engagement_Name";
				//cmbEngName.ValueMember = "ID_Engagement";
				
				
				cmbEngCode.DataSource = myBindingSource;
				cmbEngCode.DisplayMember = "Engagement_Code";
				//cmbEngCode.ValueMember = "ID_Engagement";
				
				
				cmbEngCode.SelectedIndex = -1;
				cmbEngName.SelectedIndex = -1;
			//BindingSource myBindingSource = new BindingSource();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				btnExport.Enabled = false;
				btnSubmit.Enabled = false;
				btnReset.Enabled = false;
			}
			else if (Role_type == 1)
			{
				btnExport.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
		}
		void DisplayCmbMonthYear()
		{
			DateTime today = DateTime.Today;
			cmbMonth.Text = DateSupport.GetMonth(today).ToString();
			cmbYear.Text = today.Year.ToString();
		}
		void DisplayCmb()
		{
			cmbName.DataSource = dcITRAMember.GetListDataActive();
			cmbName.DisplayMember = "FullName";
			cmbName.ValueMember = "ID_Member";
			cmbName.SelectedIndex = -1;			
		}
		
		
		public void DisplayDefaultCmb()
		{
			
			myBindingSource = dcITRAMember.GetAllSeniors1();
			cmbSIC.DataSource = myBindingSource;
			cmbSIC.DisplayMember = "FullName";
			//cmbSIC.ValueMember = "Client_Code";
			cmbSIC.SelectedIndex = -1;
			
			myBindingSource = dcITRAMember.GetAllManagers1();
			cmbSM_MIC.DataSource = myBindingSource;
			cmbSM_MIC.DisplayMember = "FullName";
			//cmbSM_MIC.ValueMember = "Client_Code";
			cmbSM_MIC.SelectedIndex = -1;
			
		}
		
		void Reset()
		{
			if (radioButton1.Checked)
			{
				cmbName.SelectedIndex = -1;
			
				radGeneral.Checked = false;
				radDetail.Checked = true;
			}
			if (radioButton2.Checked)
			{
				cmbEngName.SelectedIndex =-1;
				cmbEngCode.SelectedIndex =-1;
			}
		}
		
		void RemoveGrd()
		{
			while (grdRetain.Rows.Count > 0)
				grdRetain.Rows.RemoveAt(0);
			while (grdRetain.Columns.Count > 0)
				grdRetain.Columns.RemoveAt(0);
		}
		
			
		void AddHeaderColumn()
		{
			
			
			if (radioButton1.Checked && radDetail.Checked)
			{
				grdRetain.Columns.Add("Staff Name","Staff Name");
				grdRetain.Columns.Add("Level","Level");
				grdRetain.Columns.Add("Engagement Code", "Engagement Code");
				grdRetain.Columns.Add("Engagement Name", "Engagement Name");
				
				grdRetain.Columns[grdRetain.ColumnCount -1].Frozen = true;
				int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text));
				//MessageBox.Show(col.ToString());
				arrDate = DateSupport.ListDo6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text));
				for (int i =0; i<= col-1; i++)
				{
					string header = arrDate[i].Month.ToString() + "/" + arrDate[i].Day.ToString();
					grdRetain.Columns.Add(header,header);
					grdRetain.Columns[grdRetain.ColumnCount -1].Width = 60;
				}
				grdRetain.Columns.Add("Total","Total");
			}
			if (radioButton1.Checked && radGeneral.Checked)
			{
				grdRetain.Columns.Add("Staff Name","Staff Name");
				grdRetain.Columns.Add("Level","Level");
				
				int month = int.Parse(cmbMonth.Text);
				int year = int.Parse(cmbYear.Text);
				arrDate = DateSupport.ListDo6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text));
				int week = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text)) / 7;
				DateTime date;
				if (int.Parse(cmbMonth.Text) != 1)
					date = new DateTime(int.Parse(cmbYear.Text),int.Parse(cmbMonth.Text)-1,26);
				else
					date = new DateTime(int.Parse(cmbYear.Text)-1,12,26);
				
				while (int.Parse(cmbMonth.Text) != DateSupport.GetMonth(date))
				{
					date = date.AddDays(1);
				}
				
				DateTime enddate;
				int endmonth = (month+6)%12;
				int endyear = ((month+6) > 12 )? year+1:year;
				
				if (endmonth != 0)
				{
					enddate = new DateTime(endyear,endmonth+1,05);
				}
				else
				{
					endmonth = 12;
					enddate = new DateTime(endyear,1,05);
				}
				
				while (endmonth != DateSupport.GetMonth(enddate))
				{
						enddate = enddate.AddDays(-1);
				}
				
				//grdRetain.Columns[grdRetain.ColumnCount -1].Frozen = true;
				for (int i =1; i <=week; i ++ )
					if (date < enddate)
				{
					DateTime date1 = date;
					date1 = date1.AddDays(6);
					grdRetain.Columns.Add(date.Day.ToString()+ "/"+date.Month.ToString()+" - "+date1.Day.ToString()+ "/"+date1.Month.ToString() + " - %C",
					                     date.Day.ToString()+ "/"+date.Month.ToString()+" - "+date1.Day.ToString()+ "/"+date1.Month.ToString() + " - %C");
					//grdRetain.Columns[grdRetain.ColumnCount -1].DefaultCellStyle.BackColor = Color.LightBlue;
					grdRetain.Columns.Add(date.Day.ToString()+ "/"+date.Month.ToString()+" - "+date1.Day.ToString()+ "/"+date1.Month.ToString() + " - %P",
					                     date.Day.ToString()+ "/"+date.Month.ToString()+" - "+date1.Day.ToString()+ "/"+date1.Month.ToString() + " - %P");
					grdRetain.Columns.Add(date.Day.ToString()+ "/"+date.Month.ToString()+" - "+date1.Day.ToString()+ "/"+date1.Month.ToString() + " - %N",
					                     date.Day.ToString()+ "/"+date.Month.ToString()+" - "+date1.Day.ToString()+ "/"+date1.Month.ToString() + " - %N");
					if (i%2 ==1)
					{
						grdRetain.Columns[grdRetain.ColumnCount -3].DefaultCellStyle.BackColor = Color.LightBlue;
						grdRetain.Columns[grdRetain.ColumnCount -2].DefaultCellStyle.BackColor = Color.LightBlue;
						grdRetain.Columns[grdRetain.ColumnCount -1].DefaultCellStyle.BackColor = Color.LightBlue;
					}
					
					date = date.AddDays(7);
				}
				//grdRetain.Columns.Add("Total","Total");
			}
			if (radioButton2.Checked)
			{
				grdRetain.Columns.Add("Engagement Code", "Engagement Code");
				grdRetain.Columns.Add("Engagement Name", "Engagement Name");
				
				grdRetain.Columns.Add("Staff Name","Staff Name");
				grdRetain.Columns.Add("Level","Level");
				
				grdRetain.Columns[grdRetain.ColumnCount -1].Frozen = true;
				int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text));
				arrDate = DateSupport.ListDo6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text));
				for (int i =0; i<= col-1; i++)
				{
					string header = arrDate[i].Month.ToString() + "/" + arrDate[i].Day.ToString();
					grdRetain.Columns.Add(header,header);
//					grdRetain.Columns.Add(header+"- %P",header+"- %P");
//					grdRetain.Columns.Add(header+"- %N",header+"- %N");
					grdRetain.Columns[grdRetain.ColumnCount -1].Width = 70;
				
				}
				grdRetain.Columns.Add("Total","Total");
			}
		}
		
		void Retain_Detail()
		{
			string strname = "";
			string streng = "";
			int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text))+4;
			int first =0;
			for (int i =0; i <= grdTemp.Rows.Count - 1; i ++)			
			{
				DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp.Rows[i].Cells[5].Value.ToString());
				if (arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1])
				{
					if (strname != grdTemp.Rows[i].Cells[4].Value.ToString())
					{
						if (i != first)
						{
							AddSubTotalRow(strname);
							streng = "";
						}
						AddRowName(grdTemp.Rows[i].Cells[3].Value.ToString(),
						           grdTemp.Rows[i].Cells[4].Value.ToString());
						strname = grdTemp.Rows[i].Cells[4].Value.ToString();
					}
					if (streng != grdTemp.Rows[i].Cells[1].Value.ToString())
					{
						AddDetailRow(strname, grdTemp.Rows[i].Cells[1].Value.ToString(), grdTemp.Rows[i].Cells[2].Value.ToString());
						streng = grdTemp.Rows[i].Cells[1].Value.ToString();
					}
				}
				else first ++;
				
			}
			AddSubTotalRow(strname);
			for (int i =4; i <= col -2; i++)
			{
				DateTime tempdate = arrDate[i-4];
				if ((tempdate.DayOfWeek == DayOfWeek.Saturday)||(tempdate.DayOfWeek == DayOfWeek.Sunday))
				{
					for (int j =0; j <= grdRetain.RowCount - 1; j ++)
						if (grdRetain.Rows[j].Cells[0].Value == null 
						    && grdRetain.Rows[j].Cells[3].Value != null )
							grdRetain.Rows[j].Cells[i].Style.BackColor = Color.Orange;
				}
			}
		}
		
		void AddDetailRow(string name , string eng, string code)
		{
			if (radioButton1.Checked && radDetail.Checked)
			{
				
				int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text))+5;
				Object[] tempo = new Object[col];
				tempo[2] = (Object) eng;
				tempo[3] = (Object) code;
				double totalH = 0;
				for (int j = 4; j<= col -1 ; j++)
					tempo[j]= (Object) 0;
				for (int i =0; i <= grdTemp.RowCount - 1; i ++ )					
				{
					DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp.Rows[i].Cells[5].Value.ToString());
					if (name == grdTemp.Rows[i].Cells[4].Value.ToString() 
					    	&& eng == grdTemp.Rows[i].Cells[1].Value.ToString() 
					    	&& arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1])
					{
						totalH = totalH + FormatConverter.standardizeDouble(grdTemp.Rows[i].Cells[6].Value.ToString());
						int index = Array.IndexOf(arrDate,tempdate);
						tempo[index + 4] = FormatConverter.standardizeDouble(grdTemp.Rows[i].Cells[6].Value.ToString());
					}
				}
				tempo[col - 1] = (Object) totalH;
				grdRetain.Rows.Add(tempo);
				
			}
			
		}
		
		void AddSubTotalRow(string name)
		{
			if (radioButton1.Checked && radDetail.Checked)
			{
				if (grdRetain.RowCount ==0)
					return;
				int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text))+5;
				Object[] tempo = new Object[col];
				
				double totalH = 0;
				for (int j = 4; j<= col -1 ; j++)
					tempo[j]= (Object) 0;
				for (int i =0; i <= grdTemp1.RowCount - 1; i ++ )
				{
					DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp1.Rows[i].Cells[2].Value.ToString());
					if (name == grdTemp1.Rows[i].Cells[1].Value.ToString()
					    && arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1])
					{
						
						totalH = totalH + FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[3].Value.ToString());
						int index = Array.IndexOf(arrDate,tempdate);
						tempo[index + 4] = FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[3].Value.ToString());
	//					MessageBox.Show(name + " - "+ grdTemp1.Rows[i].Cells[1].Value.ToString()
	//					                + " - "+  grdTemp1.Rows[i].Cells[2].Value.ToString()
	//					                + " - "+ tempdate.Day.ToString()
	//					                + " - "+  grdTemp1.Rows[i].Cells[3].Value.ToString());
					}
				}
				tempo[col - 1] = (Object) totalH;
				grdRetain.Rows.Add(tempo);
				grdRetain.Rows[grdRetain.RowCount-1].DefaultCellStyle.BackColor = Color.LightBlue;
			}
		}
		
		void AddRowName(string id, string name)
		{
			if (radDetail.Checked)
			{
				int col = DateTime.DaysInMonth(int.Parse(cmbYear.Text),int.Parse(cmbMonth.Text))+4;
				Object[] tempo = new Object[col];
				tempo[1] = (Object) id;
				tempo[0] = (Object) name;
				grdRetain.Rows.Add(tempo);
				grdRetain.Rows[grdRetain.RowCount-1].DefaultCellStyle.BackColor = Color.LightGray;
			}
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			Reset();
			RemoveGrd();			
			choose =0;
		}
		
		void Retain_General()
		{
			
			string strname = "";
			string streng = "";
			//int col  = DateSupport.DoM(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text))+4;
			for (int i =0; i <= grdTemp1.Rows.Count - 1; i ++)			
			{
				DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp1.Rows[i].Cells[2].Value.ToString());
				if (arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1])
				{
					if (strname != grdTemp1.Rows[i].Cells[1].Value.ToString())
					{						
						AddRowGeneral(grdTemp1.Rows[i].Cells[0].Value.ToString(),
						           grdTemp1.Rows[i].Cells[1].Value.ToString());
						strname = grdTemp1.Rows[i].Cells[1].Value.ToString();
					}
					
				}
				
			}
			
			grdRetain.Columns[1].Frozen = true;
			
			
		}
		void AddRowGeneral(string staffid, string staffname)
		{
			int week = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text)) / 7;
			double[] tempd_C = new double[week];
			double[] tempd_P = new double[week];
			double[] tempd_N = new double[week];
			Object[] tempo = new Object[3*week+2];
			tempo[1] = (Object)staffid;
			tempo[0] = (Object)staffname;
			for (int k =0; k <= week-1; k++)
			{
				tempd_C[k] = 0;
				tempd_P[k] = 0;
				tempd_N[k] = 0;
			}
			double totalH = 0;
			//MessageBox.Show(arrDate[0].ToShortDateString());
			for (int i =0; i <= grdTemp1.Rows.Count - 1; i ++)
			{
				DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp1.Rows[i].Cells[2].Value.ToString());
				if (arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1]
				    && staffname == grdTemp1.Rows[i].Cells[1].Value.ToString())
				{
					
					TimeSpan span= tempdate - arrDate[0];
					int noweeks = (((int) span.TotalDays) /7);
					if (grdTemp1.Rows[i].Cells["Type_Engagement"].Value.ToString() == "Authorized Project")
						tempd_P[noweeks] = tempd_P[noweeks] +
					                               FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[4].Value.ToString());
					else if (grdTemp1.Rows[i].Cells["Type_Engagement"].Value.ToString() == "Non-chargeable")
						tempd_N[noweeks] = tempd_N[noweeks] +
					                               FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[4].Value.ToString());	
					else 
						//if (grdTemp1.Rows[i].Cells["Type_Engagement"].Value.ToString() == "Channel 1") || grdTemp1.Rows[i].Cells[4].Value.ToString() == "Channel 2")
						tempd_C[noweeks] = tempd_C[noweeks] +
					                               FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[4].Value.ToString());	
					//MessageBox.Show(arrDate[0].ToShortDateString()+ " - " + tempdate.ToShortDateString() + " - " + span.TotalDays.ToString());
					
					//totalH = totalH + FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[4].Value.ToString());
						
				}
			}
//			for (int j =0; j <= week-1; j++)
//			{
//				string percentC = Math.Round(tempd_C[j] *100 / 40, 2).ToString();
//				string percentP = Math.Round(tempd_P[j] *100/ 40, 2).ToString();
//				string percentN = Math.Round(tempd_N[j] *100/ 40, 2).ToString();
//				tempo[j*3+2] = (Object) percentC + "% (" + tempd_C[j].ToString() + ")";
//				tempo[j*3+3] = (Object) percentP + "% (" + tempd_P[j].ToString() + ")";
//				tempo[j*3+4] = (Object) percentN + "% (" + tempd_N[j].ToString() + ")";
//			}
//			//tempo[week +2] = (Object) totalH;
//			
//			
//			grdRetain.Rows.Add(tempo);
			
			bool[] target = new bool[week]; 
			for (int i = 2; i <= grdRetain.ColumnCount -1; i= i + 3)
			{
				int mon = arrDate[((i-2)*7)/3].Month;
				int year = arrDate[((i-2)*7)/3].Year;
				double targetH = 40;
				BindingSource temp2 = (BindingSource) grdTemp.DataSource;
				temp2.Filter = "Fullname LIKE '"+staffname+"%' and EY_FY = '" + year.ToString() + "'";
				grdTemp.DataSource = temp2;
				
				if (grdTemp.RowCount>0)
					targetH = double.Parse(grdTemp.Rows[grdTemp.RowCount - 1].Cells[mon + 3].Value.ToString());
				
				string percentC = Math.Round(tempd_C[(i-2)/3] *100 / targetH, 2).ToString();
				string percentP = Math.Round(tempd_P[(i-2)/3] *100/ 40, 2).ToString();
				string percentN = Math.Round(tempd_N[(i-2)/3] *100/ 40, 2).ToString();
				tempo[i] = (Object) percentC + "% (" + tempd_C[(i-2)/3].ToString() + ")";
				tempo[i+1] = (Object) percentP + "% (" + tempd_P[(i-2)/3].ToString() + ")";
				tempo[i+2] = (Object) percentN + "% (" + tempd_N[(i-2)/3].ToString() + ")";
				
				
				
				if (grdTemp.RowCount > 0 && tempd_C[(i-2)/3] < targetH)
					target[(i-2)/3] = true;
				else
					target[(i-2)/3] = false;
			}
			grdRetain.Rows.Add(tempo);
			
			for (int j =0;j<=week-1; j++)
				if (target[j])
					grdRetain.Rows[grdRetain.RowCount-1].Cells[j*3+2].Style.BackColor = Color.Orange;
			
		}
		int choose =0;
		
		void PerEmployee()
		{
			
			if (radDetail.Checked)
			{
				choose =1;
				//MessageBox.Show(arrDate.Length.ToString());
				BindingSource temp = dcRetainReport.GetAll(arrDate[0],arrDate[arrDate.Length-1], "", "");
				temp.Filter = "FullName LIKE '%" + cmbName.Text + "%'";
				temp.Sort = "FullName";
				grdTemp.DataSource = temp;
	
				
				BindingSource temp1 = dcRetainReport.GetAll_SumHour(arrDate[0],arrDate[arrDate.Length-1]);
				temp1.Filter = "FullName LIKE '%" + cmbName.Text + "%'";
				temp1.Sort = "FullName";
				grdTemp1.DataSource = temp1;

				Retain_Detail();
			}
			if (radGeneral.Checked)
			{
				choose =2;
				BindingSource temp1 = dcRetainReport.GetAll_SumHour_ByType_FromDate(arrDate[0],arrDate[arrDate.Length-1]);
				temp1.Filter = "FullName LIKE '%" + cmbName.Text + "%'";
				//temp1.Sort = "FullName";
				grdTemp1.DataSource = temp1;	

				BindingSource temp = dcPeakSeasonTarget.GetData_ByFY(cmbYear.Text);
				temp.Filter = "FullName LIKE '%" + cmbName.Text + "%'";
				//temp.Sort = "FullName";
				grdTemp.DataSource = temp;
				
				Retain_General();
				//DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdRetain);
				
			}

		}
		
		void AddDetailRowEng(string eng ,string engcode, string name, string code)
		{
			if (radioButton2.Checked)
			{
				
				int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text))+5;
				Object[] tempo = new Object[col];
				tempo[3] = (Object) code;
				tempo[2] = (Object) name;
				double totalH = 0;
				for (int j = 4; j<= col -1 ; j++)
					tempo[j]= (Object) 0;
				for (int i =0; i <= grdTemp.RowCount - 1; i ++ )					
				{
					DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp.Rows[i].Cells[5].Value.ToString());
					if (name == grdTemp.Rows[i].Cells[4].Value.ToString() 
					    	&& eng == grdTemp.Rows[i].Cells[1].Value.ToString() 
					    	&& engcode == grdTemp.Rows[i].Cells[2].Value.ToString() 
					    	&& arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1])
					{
						totalH = totalH + FormatConverter.standardizeDouble(grdTemp.Rows[i].Cells[6].Value.ToString());
						int index = Array.IndexOf(arrDate,tempdate);
						tempo[index + 4] = FormatConverter.standardizeDouble(grdTemp.Rows[i].Cells[6].Value.ToString());
					}
				}
				tempo[col - 1] = (Object) totalH;
				grdRetain.Rows.Add(tempo);
				
			}
			
		}
		
		void AddSubTotalRowEng(string eng, string code)
		{
			if (radioButton2.Checked)
			{
				if (grdRetain.RowCount ==0)
					return;
				int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text))+5;
				Object[] tempo = new Object[col];
				
				double totalH = 0;
				for (int j = 4; j<= col -1 ; j++)
					tempo[j]= (Object) 0;
				for (int i =0; i <= grdTemp1.RowCount - 1; i ++ )
				{
					DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp1.Rows[i].Cells[3].Value.ToString());
					if (eng == grdTemp1.Rows[i].Cells[1].Value.ToString()
					    && code == grdTemp1.Rows[i].Cells[2].Value.ToString()
					    && arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1])
					{
						
						totalH = totalH + FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[4].Value.ToString());
						int index = Array.IndexOf(arrDate,tempdate);
						tempo[index + 4] = FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[4].Value.ToString());
	//					MessageBox.Show(name + " - "+ grdTemp1.Rows[i].Cells[1].Value.ToString()
	//					                + " - "+  grdTemp1.Rows[i].Cells[2].Value.ToString()
	//					                + " - "+ tempdate.Day.ToString()
	//					                + " - "+  grdTemp1.Rows[i].Cells[3].Value.ToString());
					}
				}
				tempo[col - 1] = (Object) totalH;
				grdRetain.Rows.Add(tempo);
				grdRetain.Rows[grdRetain.RowCount-1].DefaultCellStyle.BackColor = Color.LightBlue;
			}
		}
		
		void AddRowNameEng(string id, string name)
		{
			if (radioButton2.Checked)
			{
				int col = DateTime.DaysInMonth(int.Parse(cmbYear.Text),int.Parse(cmbMonth.Text))+4;
				Object[] tempo = new Object[col];
				tempo[1] = (Object) id;
				tempo[0] = (Object) name;
				grdRetain.Rows.Add(tempo);
				grdRetain.Rows[grdRetain.RowCount-1].DefaultCellStyle.BackColor = Color.LightGray;
			}
		}
				
		void PerEngagement()
		{
			choose = 3;
			BindingSource temp = dcRetainReport.GetAll(arrDate[0],arrDate[arrDate.Length-1], cmbSIC.Text, cmbSM_MIC.Text);
			
			temp.Filter = "Engagement_Code like '%" + cmbEngCode.Text + "%' and Engagement_Name like '%" + cmbEngName.Text + "%'";
			temp.Sort = "Engagement_Name,Engagement_Code";
			grdTemp.DataSource = temp;
			
			BindingSource temp1 = dcRetainReport.GetTotalHour_ByEng(cmbMonth.Text,cmbYear.Text);
				temp.Filter = "Engagement_Code like '%" + cmbEngCode.Text + "%' and Engagement_Name like '%" + cmbEngName.Text + "%'";
			temp.Sort = "Engagement_Name,Engagement_Code";
				grdTemp1.DataSource = temp1;
			
			string strname = "";
			string streng = "";
			string strengcode = "";
			int col  = DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text))+4;
			int first =0;
			
			for (int i =0; i <= grdTemp.Rows.Count - 1; i ++)			
			{
				DateTime tempdate = FormatConverter.convertDateFromDBToCode(grdTemp.Rows[i].Cells[5].Value.ToString());
				if (arrDate[0] <= tempdate && tempdate <= arrDate[arrDate.Length-1])
				{
					//MessageBox.Show(grdTemp.Rows[i].Cells[1].Value.ToString() + " - " + streng);
					if (streng != grdTemp.Rows[i].Cells[1].Value.ToString()
					    && ((strengcode != grdTemp.Rows[i].Cells[2].Value.ToString()) || (grdTemp.Rows[i].Cells[2].Value.ToString() == "" && strengcode == "") ))
					{
						if (i != first)
						{
							//MessageBox.Show(i.ToString());
							AddSubTotalRowEng(streng,strengcode);
							streng = "";
							strengcode ="";
						}
						
							
						
						streng = grdTemp.Rows[i].Cells[1].Value.ToString();
						strengcode = grdTemp.Rows[i].Cells[2].Value.ToString();
						
						AddRowNameEng(grdTemp.Rows[i].Cells[1].Value.ToString(),
						           grdTemp.Rows[i].Cells[2].Value.ToString());
						//MessageBox.Show(streng);
					}
					if (strname != grdTemp.Rows[i].Cells[4].Value.ToString() )
					{
						AddDetailRowEng(streng,strengcode, grdTemp.Rows[i].Cells[4].Value.ToString(), grdTemp.Rows[i].Cells[3].Value.ToString());
						strname = grdTemp.Rows[i].Cells[4].Value.ToString();
						//MessageBox.Show(strname);
					}
					
				}
				else
					first++;
			}
			AddSubTotalRowEng(streng, strengcode);
			for (int i =4; i <= col -2; i++)
			{
				DateTime tempdate = arrDate[i-4];
				if ((tempdate.DayOfWeek == DayOfWeek.Saturday)||(tempdate.DayOfWeek == DayOfWeek.Sunday))
				{
					for (int j =0; j <= grdRetain.RowCount - 1; j ++)
						if (grdRetain.Rows[j].Cells[0].Value == null 
						    && grdRetain.Rows[j].Cells[3].Value != null )
							grdRetain.Rows[j].Cells[i].Style.BackColor = Color.Orange;
				}
			}
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if ((cmbYear.Text == "")||(cmbMonth.Text == ""))
				return;
			
			RemoveGrd();
			AddHeaderColumn();
			
			if (radioButton1.Checked)
			{
				PerEmployee();
			}
			if (radioButton2.Checked)
			{
				PerEngagement();
			}
			
			if ((radioButton1.Checked && radDetail.Checked)||(radioButton2.Checked))
			{
			for (int i =0; i <= grdRetain.RowCount - 1; i++)
			{
				if (grdRetain.Rows[i].Cells[2].Value != null && grdRetain.Rows[i].Cells[3].Value != null)
				{
					for (int j = 4; j <= grdRetain.ColumnCount - 1; j ++)
						if (double.Parse(grdRetain.Rows[i].Cells[j].Value.ToString()) > 0)
						{
							grdRetain.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
						}
				}
			}
			}
			//MessageBox.Show(DateSupport.Do6M(int.Parse(cmbMonth.Text),int.Parse(cmbYear.Text)).ToString());
		}
		

		
		void BtnExportClick(object sender, EventArgs e)
		{
			if (choose ==0)
				return;
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
	
            exSheet.Name = "Retain Report";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Retain Report";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
            if (choose ==1)
            	r1.Value2 = "Per Employee - Detail";
            if (choose ==2)
            	r1.Value2 = "Per Employee - General";
            if (choose ==3)
            	r1.Value2 = "Per Engagement";
            int loc = 4;
            for (int i =0; i<= grdRetain.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdRetain.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdRetain.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[4,2],exSheet.Cells[4,2 + grdRetain.Columns.Count -1]);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Orange;
            
            loc =5;
            for (int i =0; i<= grdRetain.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdRetain.Columns.Count-1;j++)
            	{
            		ExcelCOM.Range r4 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[loc,j+2],exSheet.Cells[loc,j+2]);		           	
					r4.BorderAround2();
            		if ((grdRetain.Rows[i].Cells[j].Value != null) && (grdRetain.Rows[i].Cells[j].Value.ToString() != "0"))
            		{
            			if (j+2 >=6)
            				r4.Interior.Color = System.Drawing.Color.Yellow;
            			
           				exSheet.Cells[loc,j+2] = grdRetain.Rows[i].Cells[j].Value.ToString();
            		}
            		
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
		
		void GrdRetainColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{

			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void RadioButton1CheckedChanged(object sender, System.EventArgs e)
		{
			if (radioButton1.Checked)
			{
				
				groupBox2.Enabled =true;
				radioButton2.Checked = false;
			}
			else
				groupBox2.Enabled =false;
		}
		
		void RadioButton2CheckedChanged(object sender, System.EventArgs e)
		{
			if (radioButton2.Checked)
			{
				
				groupBox3.Enabled =true;
				radioButton1.Checked = false;
				
				myBindingSource = dcRetainReport.GetListRetainEng(cmbMonth.Text,cmbYear.Text);
				cmbEngName.SelectedIndex =-1;
				cmbEngCode.SelectedIndex =-1;
				
			}
			else
				groupBox3.Enabled =false;
		}
		
		
		void CmbEngNameSelectedIndexChanged(object sender, System.EventArgs e)
		{
			//MessageBox.Show(cmbEngName.SelectedIndex.ToString() + " " +cmbEngCode.SelectedIndex.ToString() );
			cmbEngCode.SelectedIndex = cmbEngName.SelectedIndex;
		}
		
		void CmbEngCodeSelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(cmbEngName.SelectedItem.ToString() + " " +cmbEngCode.SelectedItem.ToString() );
			//if (cmbEngCode.SelectedIndex != - 1)
			cmbEngName.SelectedIndex = cmbEngCode.SelectedIndex;
			
			
		}
		
		
		
		void CmbMonthSelectedIndexChanged(object sender, EventArgs e)
		{
			myBindingSource = dcRetainReport.GetListRetainEng(cmbMonth.Text,cmbYear.Text);
			cmbEngName.DataSource = myBindingSource;
			cmbEngCode.DataSource = myBindingSource;
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.SelectedIndex =-1;
		}
		
		void CmbYearSelectedValueChanged(object sender, EventArgs e)
		{
			
		}
	}
}
