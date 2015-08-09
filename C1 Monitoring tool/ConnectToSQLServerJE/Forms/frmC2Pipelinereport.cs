/*
 * Created by SharpDevelop.
 * User: luan.khanh.ha
 * Date: 6/3/2013
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using ExcelCOM = Microsoft.Office.Interop.Excel;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmRetain_Popup.
	/// </summary>
	public partial class frmC2Pipelinereport : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource(); 
		
		public frmC2Pipelinereport(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			
			//string[] month = new string[12]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
			myBindingSource = dcPipeline.GetAllReport();
			grdPipeline.DataSource = myBindingSource;
			grdPipeline.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdPipeline.Columns["pipeline_ID"].Visible = false;
			grdPipeline.Columns["Status"].HeaderText = "% to win";
			grdPipeline.Columns["Fee_USD"].HeaderText = "Fee in VND";
			grdPipeline.Columns["Fee_USD"].DefaultCellStyle.Format ="#,##0.##";
			grdPipeline.Columns["Decision"].HeaderText = "Status";
			grdPipeline.Columns["Engagement_Description"].HeaderText = "Opportunity Description";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmRetain_PopupFormClosing(object sender, FormClosingEventArgs e)
		{
			//Close();
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
	
            exSheet.Name = "CRM Report";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "CRM Report";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
            
            	r1.Value2 = "Current";
            int loc = 4;
            for (int i =0; i<= grdPipeline.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdPipeline.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdPipeline.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[4,2],exSheet.Cells[4,2 + grdPipeline.Columns.Count -1]);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =5;
            for (int i =0; i<= grdPipeline.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdPipeline.Columns.Count-1;j++)
            		if (grdPipeline.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdPipeline.Rows[i].Cells[j].Value.ToString();
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
		
		void GrdCRMDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			grdPipeline.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void GrdCRMCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
//			if (e.RowIndex<0)
//				return;
//			if (grdCRM.DataSource == null)
//				return;
//			if (grdCRM.Rows[e.RowIndex].Cells["EY_Client_Code"].Value.ToString() == "")
//				return;
//			
//			Form frmpopup = new frmCRM_popup(grdCRM.Rows[e.RowIndex].Cells["EY_Client_Code"].Value.ToString());
//			
//			frmpopup.ShowDialog();
		}
	}
}
