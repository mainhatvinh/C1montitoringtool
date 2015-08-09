/*
 * Created by SharpDevelop.
 * User: luan.khanh.ha
 * Date: 6/3/2013
 * Time: 3:23 PM
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
	/// Description of frmRetain_Popup.
	/// </summary>
	public partial class frmEngSOW_Popup : Form
	{
		BindingSource myBindingSource = new BindingSource(); 
		string Revenue;
		string FY;
		string PIC;
		
		public frmEngSOW_Popup(string Revenure_Source, string Fiscal_Year,int SorM, string Person)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			//MessageBox.Show(SorM.ToString() + " - " + Revenure_Source + " - " + Fiscal_Year + " - " + Person);
			InitializeComponent();
			if (SorM <=1)
				myBindingSource = dcEngagementDetail.GetEngSOW_Detail( Revenure_Source,Fiscal_Year,SorM,Person);
			else
				myBindingSource = dcEngagementDetail.GetEngSOW_Staff_Detail( Revenure_Source,Fiscal_Year,Person);
			
			grdRetain.DataSource = myBindingSource;
			grdRetain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdRetain.Columns[1].Frozen = true;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdRetain);
			
			Revenue = Revenure_Source;
			FY = Fiscal_Year;
			PIC = Person;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmRetain_PopupFormClosing(object sender, FormClosingEventArgs e)
		{
			//Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			char chr = 'B';
			
			SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "result.xls";
            sfd.Filter = "Excel files (*.xls or .xlsx)|*.xls;*.xlsx";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
            	return;
            }
            
            string path = sfd.FileName;
			
			ExcelCOM.Application exApp = new ExcelCOM.Application();
            ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
            ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
	
            exSheet.Name = "Engagement Detail";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Engagement Detail";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
			if ( Revenue == "")
				r1.Value2 = "Full";
			else
				r1.Value2 = Revenue;
            ExcelCOM.Range r2 = (ExcelCOM.Range)exSheet.get_Range("A3", "A3");
            r2.Value2 = FY;
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range("A4", "A4");
            r3.Value2 = PIC;
            
            int loc = 6;
            for (int i =0; i<= grdRetain.Columns.Count-1;i++)
                 exSheet.Cells[6,i+2] = grdRetain.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdRetain.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r4 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[6,2],exSheet.Cells[6,2 + grdRetain.Columns.Count -1]);
            r4.Font.Bold = true;
            r4.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =7;
            for (int i =0; i<= grdRetain.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdRetain.Columns.Count-1;j++)
            		if (grdRetain.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdRetain.Rows[i].Cells[j].Value.ToString();
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
