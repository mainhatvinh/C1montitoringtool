/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/31/2013
 * Time: 6:21 PM
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
	/// Description of frmWorkStatusReport.
	/// </summary>
	public partial class frmWorkStatusReport : MyFormPage
	{
		int Fiscal_Year;
		public frmWorkStatusReport(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pnl = mainPanel;
			GetFY();
			defaultDisplayCmb();
			cmbYear.Text = Fiscal_Year.ToString();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				btnExport1.Enabled = false;
				btnSubmit.Enabled = false;
				btnReset.Enabled = false;
			}
			else
			{
				btnExport1.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
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
		
		void defaultDisplayCmb()
		{
			cmbName.DataSource = dcEngagement.GetAllC1();
			cmbName.DisplayMember = "Engagement_Name";
			cmbName.ValueMember = "ID_Engagement";
			cmbName.SelectedIndex = -1;
		}
		
		void Reset()
		{
			cmbName.SelectedIndex = -1;
			cmbYear.Text = Fiscal_Year.ToString();
		}
		
		void RemoveGrd()
		{
			while (grdWorkStatus.Columns.Count > 0) {
				grdWorkStatus.Columns.RemoveAt(0);
			}
			while (grdWorkStatus.Rows.Count > 0) {
				grdWorkStatus.Rows.RemoveAt(0);
			}
		}
		
		void BtnResetClick(object sender, EventArgs e)
		{
			Reset();
			RemoveGrd();			
		}
		
		void Validation()
		{
			for ( int i = 0 ; i <= grdWorkStatus.Rows.Count - 1 ; i ++)
				for ( int j =3; j <= grdWorkStatus.Columns.Count -1;j++)
					if (grdWorkStatus.Rows[i].Cells[j].Value.ToString() == "Please update")
			{
				grdWorkStatus.Rows[i].Cells[j].Style.ForeColor = Color.Red;
				grdWorkStatus.Rows[i].Cells[j].Style.Font = new Font(grdWorkStatus.Font.FontFamily,8.25F,FontStyle.Bold);
			}
			
		}
		BindingSource myBindingSource = new BindingSource();
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (cmbName.Text == "")
				myBindingSource = dcWorkSatusReport.GetData_ByKey("",cmbYear.Text);
			else
				myBindingSource = dcWorkSatusReport.GetData_ByKey(cmbName.GetItemText(cmbName.SelectedValue),cmbYear.Text);
			grdWorkStatus.DataSource = myBindingSource;
			grdWorkStatus.Columns[2].Frozen = true;
			grdWorkStatus.Columns[0].Visible = false;
			
			Validation();
			for ( int i = 0 ; i <= grdWorkStatus.Rows.Count - 1 ; i ++)
				if (i % 2 != 0)
					grdWorkStatus.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
			
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdWorkStatus);
		}
		
		void BtnExport1Click(object sender, EventArgs e)
		{
			if (grdWorkStatus.Rows.Count <=0)
				return;
			
			SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "WorskStatus Report.xls";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
            	return;
            }
            string path = sfd.FileName;
            
			ExcelCOM.Application exApp = new ExcelCOM.Application();
            ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
            ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];

            exSheet.Name = "WorkStatus";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "B1");
            r.Merge();
            r.Value2 = grdWorkStatus.Rows[0].Cells[3].Value.ToString();
            ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "B2");
            r1.Merge();
            if (grdWorkStatus.Rows.Count >1)
            	r1.Value2 = "Full";
            else r1.Value2 = grdWorkStatus.Rows[0].Cells[2].Value.ToString();
                        
            int loc = 4;
            for (int i =0; i<= grdWorkStatus.Columns.Count-1;i++)
            {
                 exSheet.Cells[4,i+2] = grdWorkStatus.Columns[i].HeaderText;
                  
            }
            string temp1= "";
           	int col1 = grdWorkStatus.Columns.Count / 26;
          	int col2 = grdWorkStatus.Columns.Count % 26;
          	char chr1 = 'A';
          	char chr2 = 'B';
          	if (col1 >0)
          		temp1  =  temp1 + ((char)((int) chr1 + col1 -1 )).ToString();
          	temp1 = temp1 + ((char)((int) chr2 + col2 - 1)).ToString() + "4";
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range("B4", temp1);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            
            loc =5;
            for (int i =0; i<= grdWorkStatus.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdWorkStatus.Columns.Count-1;j++)
            		exSheet.Cells[loc,j+2] = grdWorkStatus.Rows[i].Cells[j].Value.ToString();
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

            MessageBox.Show("Đã export ra file " + path);
		}
		
		void GrdWorkStatusColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			//e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void CmbYearSelectedIndexChanged(object sender, EventArgs e)
		{
			BindingSource temp1 = (BindingSource) cmbName.DataSource;
			temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "'";
			cmbName.DataSource = temp1;
			
			cmbName.SelectedIndex =-1;
		}
	}
}
