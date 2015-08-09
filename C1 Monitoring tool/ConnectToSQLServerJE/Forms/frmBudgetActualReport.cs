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
	/// Description of frmBudgetActualReport.
	/// </summary>
	public partial class frmBudgetActualReport : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		int Fiscal_Year;
		int Role_type;
		public frmBudgetActualReport(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pnl = mainPanel;
			this.Role_type = Role_type;
			
			DisableExportButton(false,false);
			defaultCmb();
			GetFY();
			DisplayDefaultCmb();
			cmbYear1.Text = Fiscal_Year.ToString();
			//MessageBox.Show(cmbYear1.Text);
			cmbYear2.Text = Fiscal_Year.ToString();
			//DisplayGridView();
			
//			if (Role_type == 2)
//			{
//				btnExport2.Enabled = false;
//				btnSubmit2.Enabled = false;
//				btnClear2.Enabled = false;
//				
//				btnExport3.Enabled = false;
//				btnSubmit3.Enabled = false;
//				btnReset3.Enabled = false;
//			}
//			else
//			{
//				btnExport2.Enabled = true;
//				btnSubmit2.Enabled = true;
//				btnClear2.Enabled = true;
//				
//				btnExport3.Enabled = true;
//				btnSubmit3.Enabled = true;
//				btnReset3.Enabled = true;
//			}
//			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		 
		void DisableExportButton(bool btn2, bool btn3)
		{
			btnExport2.Enabled = btn2;
			btnExport3.Enabled = btn3;
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
			cmbName2.DataSource = dcITRAMember.GetListDataActive();
			cmbName2.DisplayMember = "FullName";
			cmbName2.ValueMember = "ID_Member";
			cmbName2.SelectedIndex = -1;
			
			cmbName3.DataSource = dcEngagement.GetAllC1();
			cmbName3.DisplayMember = "Engagement_Name";
			cmbName3.ValueMember = "ID_Engagement";
			cmbName3.SelectedIndex = -1;
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
		
		void Label10Click(object sender, EventArgs e)
		{
			
		}
		
		void CmbYear2SelectedIndexChanged(object sender, EventArgs e)
		{
			//Fiscal_Year = FormatConverter.standardizeInt(cmbYear2.Text);
			BindingSource temp = (BindingSource) cmbName3.DataSource;
			temp.Filter = "Fiscal_Year = '" + cmbYear2.Text + "'";
			cmbName3.DataSource = temp;
			cmbName3.SelectedIndex = -1;
			//DisableExportButton(false,false);
		}
		
		void GroupByName()
		{
			int i =0;
			//int j =0;
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
		
		
		void AddColumnHeader2()
		{
			while (grdUtilization.Columns.Count>0)
			{
				grdUtilization.Columns.RemoveAt(0);
			}
				grdUtilization.Columns.Add("Staff Name","Staff Name");
				grdUtilization.Columns.Add("Level","Level");
				
				grdUtilization.Columns.Add("Engagement Code","Engagement Code");
				grdUtilization.Columns.Add("Engagement Name","Engagement Name");
				grdUtilization.Columns.Add("Budget Hours","BudgetHours");
				grdUtilization.Columns.Add("Charged Hours","Charged Hours");
				grdUtilization.Columns.Add("Remain Hours","Remain Hours");
				grdUtilization.Columns.Add("% Hours Exceed","% Hours Exceed");
				grdUtilization.Columns[3].Frozen = true;
		}
		void BtnSubmit2Click(object sender, EventArgs e)
		{
			//AddColumnHeader2();
//			if (Role_type == 2)
//				DisableExportButton(false,false);	
//			if (Role_type == 1)
//				DisableExportButton(true,false);
			DisableExportButton(true,false);			
						
			Fiscal_Year = FormatConverter.standardizeInt(cmbYear1.Text);
			BindingSource temp = dcUtilizationReport.GetAll(Fiscal_Year.ToString());
			temp.Filter = "FullName LIKE '%" + cmbName2.Text + "%'";
			temp.Sort = "FullName";
			grdTemp1.DataSource = temp;
			//grdTemp1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			RemoveGrd();
			AddColumnHeader2();
			int i =0;
			int j =0;
			string strname ="";
			while (i <= grdTemp1.Rows.Count-1)
			{
				
				if (strname.CompareTo(grdTemp1.Rows[i].Cells[1].Value.ToString())!=0)
				{

					Object[] tempo = new Object[8];
					tempo[1] = grdTemp1.Rows[i].Cells[0].Value.ToString();
					tempo[0] = grdTemp1.Rows[i].Cells[1].Value.ToString();
					
					grdUtilization.Rows.Add(tempo);
					grdUtilization.Rows[j].DefaultCellStyle.BackColor = Color.LightBlue;	
					j = j+1;
					strname = grdTemp1.Rows[i].Cells[1].Value.ToString();	
					
				}
				Object[] tempo1 = new Object[8];
				tempo1[2] = grdTemp1.Rows[i].Cells[3].Value.ToString();
				tempo1[3] = grdTemp1.Rows[i].Cells[4].Value.ToString();
				tempo1[4] = grdTemp1.Rows[i].Cells[5].Value.ToString();
				tempo1[5] = grdTemp1.Rows[i].Cells[6].Value.ToString();
				tempo1[6] = grdTemp1.Rows[i].Cells[7].Value.ToString();
				double budget = FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[5].Value.ToString());
				double remain = FormatConverter.standardizeDouble(grdTemp1.Rows[i].Cells[7].Value.ToString());
				                                            
				double hours = 0;
				if (budget == 0)
					hours =0;
				else
					hours = Math.Round((remain / budget) * 100,2);
				
				tempo1[7] = hours.ToString();
				
				grdUtilization.Rows.Add(tempo1);

				j = j+1;
				i = i+1;
			}
		}
		
		
		void CmbYear1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			//Fiscal_Year = FormatConverter.standardizeInt(cmbYear1.Text);
			//DisableExportButton(false,false);
			//MessageBox.Show(Fiscal_Year.ToString());
			//DisplayGridView();
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
		void BtnClear2Click(object sender, EventArgs e)
		{	
			cmbName2.SelectedIndex = -1;
			GetFY();
			cmbYear1.Text = Fiscal_Year.ToString();
			//DisplayGridView();			
			RemoveGrd();
			DisableExportButton(false,false);
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
		
		void CmbName3SelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(cmbName3.SelectedIndex.ToString());
			Fiscal_Year = FormatConverter.standardizeInt(cmbYear1.Text);
			//MessageBox.Show(cmbName3.SelectedIndex.ToString());
			//DisableExportButton(false,false);
			//DisplayGridView();
		}
		
		
		void BtnReset3Click(object sender, EventArgs e)
		{
			cmbName3.SelectedIndex = -1;
			cmbSIC.SelectedIndex = -1;
			cmbSM_MIC.SelectedIndex = -1;
			GetFY();
			cmbYear2.Text = Fiscal_Year.ToString();
			//DisplayGridView();			
			RemoveGrd();
			//DisableExportButton(false,false);
		}
		void AddColumnHeader3()
		{
			if (grdUtilization.DataSource != null)
			{
				grdUtilization.DataSource = null;
				return;
			}
			
			while (grdUtilization.Columns.Count>0)
			{
				grdUtilization.Columns.RemoveAt(0);
			}

		}
		void BtnSubmit3Click(object sender, EventArgs e)
		{
			DisableExportButton(false,true);
			RemoveGrd();
			//AddColumnHeader3();
			Fiscal_Year = FormatConverter.standardizeInt(cmbYear2.Text);
			BindingSource temp = dcUtilizationReport.GetAll_SMIC(Fiscal_Year.ToString(), cmbSM_MIC.Text, cmbSIC.Text);
			temp.Filter = "Engagement_Name LIKE '%" + cmbName3.Text + "%'";
			temp.Sort = "Engagement_Name";
			grdUtilization.DataSource = temp;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdUtilization);
			bool colorRow = false;
			
			for (int i = 1; i <= grdUtilization.RowCount - 1; i ++)
			{
				if (grdUtilization.Rows[i].Cells["ID_Engagement"].Value.ToString() != grdUtilization.Rows[i-1].Cells["ID_Engagement"].Value.ToString())				
					if (colorRow == true) colorRow = false; else colorRow= true;
				if (colorRow ==true)
					grdUtilization.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
			}
			
			grdUtilization.Columns["ID_Engagement"].Visible = false;
			grdUtilization.Columns["ID_Member"].Visible = false;

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
            r.Value2 = "Utilization per Engagement";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
			r1.Value2 = cmbYear2.Text;

            int loc = 4;
            for (int i =0; i<= grdUtilization.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdUtilization.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdUtilization.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[4,2],exSheet.Cells[4,2 + grdUtilization.Columns.Count -1]);
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
		
		void CmbName1SelectedIndexChanged(object sender, EventArgs e)
		{
			//DisableExportButton(false,false);
		}
		
		void CmbName2SelectedIndexChanged(object sender, EventArgs e)
		{
			//DisableExportButton(false,false);
		}
		
		void DtpToDateValueChanged(object sender, EventArgs e)
		{
		//	DisableExportButton(false,false);
		}
		
		void GrdUtilizationColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void GrdUtilizationDoubleClick(object sender, EventArgs e)
		{
		
				
		}
		
		
		void GrdUtilizationCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex<0)
				return;
			if (grdUtilization.DataSource == null)
				return;
			if (grdUtilization.Rows[e.RowIndex].Cells["Member_Name"].Value.ToString() == "")
				return;
			
			Form frmpopup = new frmBudgetActualReport_popup(grdUtilization.Rows[e.RowIndex].Cells["Member_Name"].Value.ToString(), grdUtilization.Rows[e.RowIndex].Cells["Engagement_Code"].Value.ToString());
			
			frmpopup.ShowDialog();
		}
	}
}
