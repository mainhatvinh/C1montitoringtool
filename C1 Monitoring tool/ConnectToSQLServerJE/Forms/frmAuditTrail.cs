/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 7/19/2013
 * Time: 2:37 PM
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
	/// Description of frmAuditTrail.
	/// </summary>
	public partial class frmAuditTrail : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		public frmAuditTrail(int Role_Access)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			this.pnl = mainPanel;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		
		void BtnResetClick(object sender, EventArgs e)
		{
			dcAuditTrail.UpdateInfo();
			MessageBox.Show("Save successfully");
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			myBindingSource = dcAuditTrail.GetData_ByDate();
//			myBindingSource = dcRevenue.GetAll("2014");
			grdAuditTrail.DataSource = myBindingSource;
			
			//grdAuditTrail.Columns[1].Visible = false;
			//grdAuditTrail.Columns[5].Frozen = true;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdAuditTrail);
			
		}
		
		
		
		void BtnExportClick(object sender, EventArgs e)
		{
			if (grdAuditTrail.RowCount == 0)
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
	
            exSheet.Name = "Audit Trail";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Audit Trail Report";
			
            
            	
            int loc = 4;
            for (int i =0; i<= grdAuditTrail.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdAuditTrail.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdAuditTrail.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[4,2],exSheet.Cells[4,2 + grdAuditTrail.Columns.Count -1]);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =5;
            for (int i =0; i<= grdAuditTrail.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdAuditTrail.Columns.Count-1;j++)
            		if (grdAuditTrail.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdAuditTrail.Rows[i].Cells[j].Value.ToString();
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
