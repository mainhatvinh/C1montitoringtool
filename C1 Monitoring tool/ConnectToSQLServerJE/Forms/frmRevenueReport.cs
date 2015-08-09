/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/31/2013
 * Time: 6:46 PM
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
	/// Description of frmRevenueReport.
	/// </summary>
	public partial class frmRevenueReport : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		public frmRevenueReport(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pnl = mainPanel;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
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
			fm = new DgvFilterPopup.DgvFilterManager();
			fm.DataGridView = grdRevenue;
			radioButton1.Checked = true;
		}
		DgvFilterPopup.DgvFilterManager fm;
		void BtnSubmitClick(object sender, EventArgs e)
		{
			try
			{
			
			if (radioButton1.Checked)
			{
				//fm.RebuildFilter();
				
				//dcRevenue.ExecuteFY(cmbYear.Text);
				myBindingSource = dcRevenue.GetAll(cmbYear.Text);
				grdRevenue.DataSource =myBindingSource;
				grdRevenue.Columns["ERP_Planned"].DefaultCellStyle.Format ="#,##0";
				grdRevenue.Columns["ERP_Planned"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				grdRevenue.Columns["ERP_Actual"].DefaultCellStyle.Format ="#,##0";
				grdRevenue.Columns["ERP_Actual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				grdRevenue.Columns["ITRA_Plan_Fees"].DefaultCellStyle.Format ="#,##0";
				grdRevenue.Columns["ITRA_Plan_Fees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				grdRevenue.Columns["ITRA_Actual_Fees"].DefaultCellStyle.Format ="#,##0";
				grdRevenue.Columns["ITRA_Actual_Fees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				grdRevenue.Columns["Hour_Plan"].DefaultCellStyle.Format ="#,##0";
				grdRevenue.Columns["Hour_Plan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				grdRevenue.Columns["Hour_Actual_Per_FY"].DefaultCellStyle.Format ="#,##0";
				grdRevenue.Columns["Hour_Actual_Per_FY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				
				for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["ERP_Planned"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["ERP_Actual"].Value.ToString()) >4.9)
					{
						grdRevenue.Rows[i].Cells["ERP_Actual"].Style.BackColor = Color.Red;
						grdRevenue.Rows[i].Cells["ERP_Actual"].Style.Font = new Font(this.Font, FontStyle.Bold);
						
					}
				}
				
				for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["Hour_Plan"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Value.ToString()) >Double.Parse(grdRevenue.Rows[i].Cells["Hour_Plan"].Value.ToString())*0.1)
					{
						grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Style.BackColor = Color.Yellow;
						grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Style.Font = new Font(this.Font, FontStyle.Bold);
					}
				}
				
				for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["ITRA_Plan_Fees"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Value.ToString()) >10000000)
					{
						grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Style.BackColor = Color.Orange;
						grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Style.Font = new Font(this.Font, FontStyle.Bold);
					}
				}
				
				grdRevenue.Columns["Week_Ending"].Visible = false;
				grdRevenue.Columns["EYFISYEAR"].Visible = false;
				txtNoofWeek.Text = grdRevenue.Rows[1].Cells["Week_Ending"].Value.ToString();
				txtWeek_Ending.Text = grdRevenue.Rows[1].Cells["EYFISYEAR"].Value.ToString();
				//if (grdRevenue.Columns["ERP_Planned"].CellType.va)
//				grdRevenue.Columns["Net_Fees"].DefaultCellStyle.ForeColor = Color.Maroon;
//				grdRevenue.Columns["Net_Fees"].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
//				grdRevenue.Columns["Sum_of_Hours"].DefaultCellStyle.ForeColor = Color.HotPink;
//				grdRevenue.Columns["Sum_of_Hours"].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
				//fm.ActivateFilter(true,1);
				//DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdRevenue);
				
			}
			if (radioButton2.Checked)
			{
				if (grdRevenue.DataSource != null)
					grdRevenue.DataSource = null;
				fm.RebuildFilter();
				myBindingSource = dcRevenue.GetDetail(cmbYear.Text);
				grdRevenue.DataSource =myBindingSource;
				grdRevenue.Columns["Actual_Amount"].DefaultCellStyle.Format ="#,##0";
				grdRevenue.Columns["Actual_Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			}
			}
			catch(Exception ex)
			{
			    MessageBox.Show("Have no data for selected year, thank you.");
			}
			return;	
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
	
            exSheet.Name = "Revenue Report";
            ExcelCOM.Range r = (ExcelCOM.Range)exSheet.get_Range("A1", "A1");
            r.Value2 = "Revenue Report";
			ExcelCOM.Range r1 = (ExcelCOM.Range)exSheet.get_Range("A2", "A2");
            
            	r1.Value2 = "Current";
            int loc = 4;
            for (int i =0; i<= grdRevenue.Columns.Count-1;i++)
                 exSheet.Cells[4,i+2] = grdRevenue.Columns[i].HeaderText;
            
            chr = (char)((int)chr + grdRevenue.Columns.Count-1 );
            //MessageBox.Show(((char) chr).ToString());
            ExcelCOM.Range r3 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[4,2],exSheet.Cells[4,2 + grdRevenue.Columns.Count -1]);
            r3.Font.Bold = true;
            r3.Interior.Color = System.Drawing.Color.Yellow;
            
            loc =5;
            for (int i =0; i<= grdRevenue.Rows.Count-1;i++)
            {          	            	
            	for (int j =0; j<= grdRevenue.Columns.Count-1;j++)
            		if (grdRevenue.Rows[i].Cells[j].Value != null)
            	{
            		 ExcelCOM.Range r4 = (ExcelCOM.Range)exSheet.get_Range(exSheet.Cells[loc,j+2],exSheet.Cells[loc,j+2]);
            		//r4.Font.Bold = true;
            		if (grdRevenue.Rows[i].Cells[j].Style.BackColor == Color.Red)
            			r4.Interior.Color = System.Drawing.Color.Red;
            		if (grdRevenue.Rows[i].Cells[j].Style.BackColor == Color.Orange)
            			r4.Interior.Color = System.Drawing.Color.Orange;
            		if (grdRevenue.Rows[i].Cells[j].Style.BackColor == Color.Yellow)
            			r4.Interior.Color = System.Drawing.Color.Yellow;
            		exSheet.Cells[loc,j+2] = grdRevenue.Rows[i].Cells[j].Value.ToString();
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
		
		void GrdRevenueColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			//e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void GrdRevenueCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex<0)
				return;
			if (grdRevenue.DataSource == null)
				return;
			if (grdRevenue.Rows[e.RowIndex].Cells["Eng_Number"].Value.ToString() == "")
				return;
			
			Form frmpopup = new frmRevenue_popup(grdRevenue.Rows[e.RowIndex].Cells["Eng_Number"].Value.ToString());
			
			frmpopup.ShowDialog();
		}
		
		void GrdRevenueColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
		{
			System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
			messageBoxCS.AppendFormat("{0} = {1}", "Column", e.Column );
			messageBoxCS.AppendLine();
			MessageBox.Show(messageBoxCS.ToString(), "ColumnSortModeChanged Event" );
		}
		
		void GrdRevenueSorted(object sender, EventArgs e)
		{
			for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["ERP_Planned"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["ERP_Actual"].Value.ToString()) >4.9)
					{
						grdRevenue.Rows[i].Cells["ERP_Actual"].Style.BackColor = Color.Red;
						grdRevenue.Rows[i].Cells["ERP_Actual"].Style.Font = new Font(this.Font, FontStyle.Bold);
						
					}
				}
				
				for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["Hour_Plan"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Value.ToString()) >Double.Parse(grdRevenue.Rows[i].Cells["Hour_Plan"].Value.ToString())*0.05)
					{
						grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Style.BackColor = Color.Yellow;
						grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Style.Font = new Font(this.Font, FontStyle.Bold);
					}
				}
				
				for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["ITRA_Plan_Fees"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Value.ToString()) >5000000)
					{
						grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Style.BackColor = Color.Orange;
						grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Style.Font = new Font(this.Font, FontStyle.Bold);
					}
				}
		}
		
		void GrdRevenueDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["ERP_Planned"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["ERP_Actual"].Value.ToString()) >4.9)
					{
						grdRevenue.Rows[i].Cells["ERP_Actual"].Style.BackColor = Color.Red;
						grdRevenue.Rows[i].Cells["ERP_Actual"].Style.Font = new Font(this.Font, FontStyle.Bold);
						
					}
				}
				
				for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["Hour_Plan"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Value.ToString()) >Double.Parse(grdRevenue.Rows[i].Cells["Hour_Plan"].Value.ToString())*0.1)
					{
						grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Style.BackColor = Color.Yellow;
						grdRevenue.Rows[i].Cells["Hour_Actual_Per_FY"].Style.Font = new Font(this.Font, FontStyle.Bold);
					}
				}
				
				for(int i = 0; i < grdRevenue.RowCount; i++)
				{
					if (Double.Parse(grdRevenue.Rows[i].Cells["ITRA_Plan_Fees"].Value.ToString()) - Double.Parse(grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Value.ToString()) >10000000)
					{
						grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Style.BackColor = Color.Orange;
						grdRevenue.Rows[i].Cells["ITRA_Actual_Fees"].Style.Font = new Font(this.Font, FontStyle.Bold);
					}
				}
		}
	}
}
