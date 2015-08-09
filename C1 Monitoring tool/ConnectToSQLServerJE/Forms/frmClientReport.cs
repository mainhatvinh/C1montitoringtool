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
using System.Data.OleDb;

using ExcelCOM = Microsoft.Office.Interop.Excel;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmWorkStatusReport.
	/// </summary>
	public partial class frmClientReport : MyFormPage
	{
		int Fiscal_Year;
		string FYear;
		int role_type;
		BindingSource myBindingSource = new BindingSource();
		public frmClientReport(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pnl = mainPanel;
			role_type = Role_type;
			GetFY();
			//defaultDisplayCmb();
			cmbYear.Text =Fiscal_Year.ToString();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
//			if (Role_type == 2)
//			{
//				btnExport1.Enabled = false;
//				btnSubmit.Enabled = false;
//				
//			}
//			else
//			{
//				btnExport1.Enabled = true;
//				btnSubmit.Enabled = true;
//				
//			}
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
	
		void DisplayCheck()
		{
			dataGridView1.DataSource = dcClientReport.GetListData(FYear);
			for (int i =0; i <= grdClient.RowCount - 1; i++)
				if (grdClient.Rows[i].Cells["Current_Fiscal_Year"].Value.ToString() == "No")
			{
				grdClient.Rows[i].Cells["Current_Fiscal_Year"].Style.BackColor = Color.Yellow;
			}
			CheckStatus();
		}
		
		void CheckStatus()
		{
			for (int i=0; i<= grdClient.RowCount-1;i++)
				if (grdClient.Rows[i].Cells["Current_Fiscal_Year"].Value.ToString() == "No")
					for (int j=0; j<=dataGridView1.RowCount -1;j++)
						if (grdClient.Rows[i].Cells["Client_Code"].Value.ToString() == dataGridView1.Rows[j].Cells["Client_Code"].Value.ToString() )
						{
							grdClient.Rows[i].Cells["Current_Fiscal_Year"].Style.BackColor = Color.White;
						}
		}
		void BtnSubmitClick(object sender, EventArgs e)
		{
			
			
			FYear = cmbYear.Text;
			myBindingSource = dcClientReport.GetAll(cmbYear.Text);
			grdClient.DataSource = myBindingSource;
			
			DisplayCheck();
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdClient);
			
			grdClient.Columns["Current_Fiscal_Year"].HeaderText = cmbYear.Text;
			grdClient.Columns["Previous_Fiscal_Year"].HeaderText = (int.Parse(cmbYear.Text) -1 ).ToString();
		}
		
		void BtnExport1Click(object sender, EventArgs e)
		{
			char chr = 'B';
			
			SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Client report.xls";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
            	return;
            }
            
            string path = sfd.FileName;
			
			ExcelCOM.Application exApp = new ExcelCOM.Application();
            ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
            ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
	
            exSheet.Name = "Client Report";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Client Report";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
			r1.Value2 = FYear.ToString();
            int loc = 4;
            for (int i =0; i<= grdClient.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdClient.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdClient.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[4,2],exSheet.Cells[4,2 + grdClient.Columns.Count -1]);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =5;
            for (int i =0; i<= grdClient.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdClient.Columns.Count-1;j++)
            		if (grdClient.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdClient.Rows[i].Cells[j].Value.ToString();
            		if (grdClient.Rows[i].Cells[j].HasStyle)
            		{
            			ExcelCOM.Range r4 =  (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[loc,j+2],exSheet.Cells[loc,j+2]);
            			r4.Interior.Color = Color.Orange;
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
		
		void GrdWorkStatusColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			//e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void CmbYearSelectedIndexChanged(object sender, EventArgs e)
		{
//			BindingSource temp1 = (BindingSource) cmbName.DataSource;
//			temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "'";
//			cmbName.DataSource = temp1;
//			
//			cmbName.SelectedIndex =-1;
		}
		
		void GrdClientCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex<0 || e.ColumnIndex<0)
				return;
			if (grdClient.Columns[e.ColumnIndex].HeaderText == "Previous_Fiscal_Year")
				return;
			if (grdClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "No")
			{
				Form frmPopup = new frmClientReport_Popup(role_type,
				                                          grdClient.Rows[e.RowIndex].Cells["Client_Code"].Value.ToString(),
				                                          grdClient.Rows[e.RowIndex].Cells["Client_Name"].Value.ToString(),
				                                         FYear);
				frmPopup.Closed +=  new EventHandler(popupclose);
				frmPopup.ShowDialog();
				
				
			}
		}
		
		void FrmClientReportActivated(object sender, EventArgs e)
		{
			//MessageBox.Show("1");
		}
		void popupclose(object sender, EventArgs e)
   		{
			DisplayCheck();
   		
   		}
		
		void GrdClientRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			
		}
		
		void GrdClientSorted(object sender, EventArgs e)
		{
			DisplayCheck();
		}
	}
	
}