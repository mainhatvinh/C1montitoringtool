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
	public partial class frmEngagementDetail : MyFormPage
	{
		DateTime[] arrDate;
		BindingSource myBindingSource = new BindingSource();
		int choose = 0;
		public frmEngagementDetail(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pnl = mainPanel;
			
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
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
			else
			{
				btnExport.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
			
			DefaultCmb();
		}
		
		void DefaultCmb()
		{
			
			
		}
		
		void BtnResetClick(object sender, EventArgs e)
		{
			cmbRevenue.SelectedIndex = -1;
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (radSIC.Checked)
			{
				choose = 1;
				myBindingSource = dcEngagementDetail.GetEngSOW_BySIC(cmbRevenue.Text, cmbYear.Text);
			}
			if (radMIC.Checked)
			{
				choose = 0;
				myBindingSource = dcEngagementDetail.GetEngSOW_ByMIC(cmbRevenue.Text, cmbYear.Text);
			}
				
			if (radDetail.Checked)
			{
				choose = 3;
				myBindingSource = dcEngagementDetail.GetEng_Detail(cmbRevenue.Text, cmbYear.Text);
			}
			if (radStaff.Checked)
			{
				choose = 2;
				myBindingSource = dcEngagementDetail.GetEngSOW_ByStaff(cmbRevenue.Text, cmbYear.Text);
			}
			
			if (grdEngagement.DataSource != null)
				grdEngagement.DataSource = null;
			else
			{
				while (grdEngagement.ColumnCount >0)
					grdEngagement.Columns.RemoveAt(0);
			}
			
			
		
			
			
			
			if (radSIC.Checked || radMIC.Checked || radStaff.Checked)
			{
				grdTemp.DataSource = myBindingSource;
				for (int j =0; j <= grdTemp.ColumnCount - 1; j++)
				{
					grdEngagement.Columns.Add(grdTemp.Columns[j].HeaderText,grdTemp.Columns[j].HeaderText);
				}
				Object[] tempo1 = new Object[grdTemp.ColumnCount];
				tempo1[0] = (Object) "Total";
				for (int j =2; j <= grdTemp.ColumnCount - 1; j++)
					tempo1[j] = (Object) 0;
				
				for (int i = 0; i<=grdTemp.RowCount - 1; i++)
				{
					Object[] tempo = new Object[grdTemp.ColumnCount];
					for (int j =0; j <= grdTemp.ColumnCount - 1; j++)
					{
						tempo[j] = (Object) grdTemp.Rows[i].Cells[j].Value;
						if (j >=3 && choose < 4)
							tempo1[j] = (Object) (int.Parse(tempo1[j].ToString()) + int.Parse(tempo[j].ToString()));
					}
					grdEngagement.Rows.Add(tempo);
					
				}
				grdEngagement.Rows.Add(tempo1);
				grdEngagement.Columns[2].Frozen = true;
				grdEngagement.Rows[grdEngagement.RowCount -1].DefaultCellStyle.BackColor = Color.LightBlue;
			}
			
			if (radDetail.Checked)
			{
//				grdEngagement.Columns[0].Visible = false;
//				grdEngagement.Columns[1].Visible = false;
//				grdEngagement.Columns[2].Visible = false;
//				
				grdEngagement.DataSource = myBindingSource;
				grdEngagement.Columns[1].Frozen = true;
				DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdEngagement);
			}
			
		}
		
		void FrmEngagementDetailFormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
		
		void BtnExportClick(object sender, EventArgs e)
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
	
            exSheet.Name = "Engagement List";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Engagement List";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
			if ( cmbRevenue.Text == "")
				r1.Value2 = "Full";
			else
				r1.Value2 = cmbRevenue.Text;
            ExcelCOM.Range r2 = (ExcelCOM.Range)exSheet.get_Range("A3", "A3");
            r2.Value2 = cmbYear.Text;
            
            int loc = 5;
            for (int i =0; i<= grdEngagement.Columns.Count-1;i++)
                 exSheet.Cells[5,i+2] = grdEngagement.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdEngagement.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[5,2],exSheet.Cells[5,2 + grdEngagement.Columns.Count -1]);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =6;
            for (int i =0; i<= grdEngagement.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdEngagement.Columns.Count-1;j++)
            		if (grdEngagement.Rows[i].Cells[j].Value != null)
            	{
            		
            		exSheet.Cells[loc,j+2] = grdEngagement.Rows[i].Cells[j].Value.ToString();
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
		
		void GrdEngagementCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0 || choose > 2 )
				return;
			if (e.RowIndex == grdEngagement.RowCount -1)
				return;
			Form frmpopup = new frmEngSOW_Popup(grdEngagement.Rows[e.RowIndex].Cells[1].Value.ToString(),cmbYear.Text,choose,
												grdEngagement.Rows[e.RowIndex].Cells[0].Value.ToString());
			
			frmpopup.ShowDialog();
		}
		
		void RadDetailCheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
