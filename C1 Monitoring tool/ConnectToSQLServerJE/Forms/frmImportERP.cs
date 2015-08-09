/*
 * Created by SharpDevelop.
 * User: An.C.Thien.Nguyen
 * Date: 7/18/2013
 * Time: 2:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmImportERP.
	/// </summary>
	public partial class frmImportERP : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		bool flagStart = false;
		
		public frmImportERP(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			
			ResetERP();
			ResetST();
			DisplayDefaultCmbERP();
			DisplayDefaultCmbST();
			
			grdPreviewERP.Columns.Add("ID_Engagement", "ID_Engagement");
        	grdPreviewERP.Columns.Add("Months", "Months");
        	grdPreviewERP.Columns.Add("FYear", "FYear");
        	grdPreviewERP.Columns.Add("ERP_Actual", "ERP_Actual");
        	grdPreviewST.Columns.Add("Engagement_Code", "ID_Engagement");
        	grdPreviewST.Columns.Add("Months", "Months");
        	grdPreviewST.Columns.Add("FYear", "FYear");
        	grdPreviewST.Columns.Add("Net_Fee", "ERP_Actual");
			
			flagStart = true;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			if (Role_type == 2)
			{
				btnClearERP.Enabled = false;
				btnSubmitERP.Enabled = false;
				btnBrowseERP.Enabled = false;
				btnDelERP.Enabled = false;
				btnClearST.Enabled = false;
				btnSubmitST.Enabled = false;
				btnBrowseST.Enabled = false;
				btnDelST.Enabled = false;
			}
			else 
			{
				btnClearERP.Enabled = true;
				btnSubmitERP.Enabled = true;
				btnBrowseERP.Enabled = true;
				btnDelERP.Enabled = true;
				btnClearST.Enabled = true;
				btnSubmitST.Enabled = true;
				btnBrowseST.Enabled = true;
				btnDelST.Enabled = true;
			}
		}
		
		void DisplayDefaultCmbERP()
		{
			cmbYearERP.SelectedIndex = -1;
			cmbMonthERP.SelectedIndex = -1;
			
			myBindingSource = dcImportERP.GetAllEngCode();
			
			cmbEngagementERP.DataSource = myBindingSource;
			cmbEngagementERP.DisplayMember = "ID_Engagement";
			//cmbEngagement.ValueMember = "ID_Engagement";
			cmbEngagementERP.SelectedIndex = -1;
		}
		
		void ResetERP()
		{
			myBindingSource = dcImportERP.GetAll();
			grdERP.DataSource = myBindingSource;
			
			grdPreviewERP.Rows.Clear();
			
			DisplayDefaultCmbERP();
		}
		
		void FilterbyCmbERP(string year, string month, string EngCode)
		{
			if (flagStart == true)
			{
				BindingSource tempERP = (BindingSource)grdERP.DataSource;
				tempERP.Filter = "ID_Engagement LIKE '%" + EngCode + "%' AND FYear LIKE '%" + year + "%' AND Months LIKE '%" + month + "%'";
				grdERP.DataSource = tempERP;
			}
		}
		
		bool isDuplicatedERP(string year, string month, string EngCode)
		{
			BindingSource tempERP = (BindingSource)grdTempERP.DataSource;
			tempERP.Filter = "ID_Engagement LIKE '%" + EngCode + "%' AND FYear LIKE '%" + year + "%' AND Months LIKE '%" + month + "%'";
			grdTempERP.DataSource = tempERP;
			
			for (int i = 0; i < grdTempERP.Rows.Count; i++)
			{
				if (grdTempERP.Rows[i].Cells["FYear"].Value.ToString() == year
				    & grdTempERP.Rows[i].Cells["Months"].Value.ToString() == month
				    & grdTempERP.Rows[i].Cells["ID_Engagement"].Value.ToString() == EngCode)
					return true;
			}
			return false;
		}
		
		//EVENTS
		void btnBrowseERPClick(object sender, EventArgs e)
		{
			var browseFile = new System.Windows.Forms.OpenFileDialog();
			browseFile.DereferenceLinks = true;
			browseFile.Filter = "Excel files (*.xls or .xlsx)|*.xlsx;*.xls";
			
			if (browseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
			{
			    string fileToOpen = browseFile.FileName;
			
			    //System.IO.FileInfo File = new System.IO.FileInfo(fileToOpen);
				//OR
				//System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
			    
			    Excel.ApplicationClass app = new ApplicationClass();
            	// Create the workbook object by opening the excel file.
	            
            	Excel.Workbook workBook = app.Workbooks.Open(fileToOpen,
	                                                         0,
	                                                         true,
	                                                         5,
	                                                         "",
	                                                         "",
	                                                         true,
	                                                         Excel.XlPlatform.xlWindows,
	                                                         "\t",
	                                                         false,
	                                                         false,
	                                                         0,
	                                                         true,
	                                                         1,
	                                                         0);
	            // Get the active worksheet using sheet name or active sheet
	            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.ActiveSheet;
            
	            int row_index = 2;
	            int col_index = 1;
	            
	            try
	            {
	                while (((Excel.Range)workSheet.Cells[row_index, col_index]).Value2 != null)
	                {
	                    // Read the Cells to get the required value.
	                    Object[] temp = new Object[4];
	                    temp[0] =(Object)((Excel.Range)workSheet.Cells[row_index, 1]).Value2.ToString();
	                    temp[1] =(Object)((Excel.Range)workSheet.Cells[row_index, 2]).Value2.ToString();
	                    temp[2] =(Object)((Excel.Range)workSheet.Cells[row_index, 3]).Value2.ToString();
	                    temp[3] =(Object)((Excel.Range)workSheet.Cells[row_index, 4]).Value2.ToString();
	                    
	                    grdPreviewERP.Rows.Add(temp);
	                    
	                    row_index++;
	                }
	                
	                workBook.Close(false,false,false);
            		app.Quit();
	            }
	            catch (Exception ex)
	            {
	            	MessageBox.Show("Read file unsuccessfully.\nError: " + ex.ToString());
	            }
			}
		}
		
		void BtnSubmitERPClick(object sender, EventArgs e)
		{
			int RowNum = 0;
			
			myBindingSource = dcImportERP.GetAll();
			grdTempERP.DataSource = myBindingSource;
			
			for (int i = 0; i < grdPreviewERP.Rows.Count; i++)
			{
				try
				{
					if (isDuplicatedERP(grdPreviewERP.Rows[i].Cells["FYear"].Value.ToString(),
					                 grdPreviewERP.Rows[i].Cells["Months"].Value.ToString(),
					                 grdPreviewERP.Rows[i].Cells["ID_Engagement"].Value.ToString()) == false)
					
				    {
						dcImportERP.SubmitOne(true,grdPreviewERP.Rows[i].Cells[0].Value.ToString(), 
						                      grdPreviewERP.Rows[i].Cells[1].Value.ToString(),
						                      grdPreviewERP.Rows[i].Cells[2].Value.ToString(),
						                      grdPreviewERP.Rows[i].Cells[3].Value.ToString());
					
						RowNum++;
					}
				}
				catch (Exception ex)
				{
					//MessageBox.Show("Imported unsuccessfully.\nError: " + ex.ToString());
				}
			}
			
			MessageBox.Show("Imported " + RowNum.ToString() + "/ " + grdPreviewERP.Rows.Count +" row(s) successfully.");
			ResetERP();
		}
		
		void BtnClearERPClick(object sender, EventArgs e)
		{
			ResetERP();
		}
		
		void BtnDelERPClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		    {
				int RowNum = 0;
				
				for (int i = 0; i < grdERP.Rows.Count; i++)
				{
					try
					{
						dcImportERP.DeleteOne(grdERP.Rows[i].Cells[0].Value.ToString(), 
						                      grdERP.Rows[i].Cells[1].Value.ToString(),
						                      grdERP.Rows[i].Cells[2].Value.ToString());
						RowNum++;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Imported unsuccessfully.\nError: " + ex.ToString());
					}
				}
				
				MessageBox.Show("Deleted " + RowNum.ToString() + " row(s) successfully.");
				ResetERP();
			}
		}
		
		void CmbYearERPSelectedIndexChanged(object sender, EventArgs e)
		{
			FilterbyCmbERP(cmbYearERP.Text, cmbMonthERP.Text, cmbEngagementERP.Text);
		}
		
		void CmbMonthERPSelectedIndexChanged(object sender, EventArgs e)
		{
			FilterbyCmbERP(cmbYearERP.Text, cmbMonthERP.Text, cmbEngagementERP.Text);
		}
		
		void CmbEngagementERPSelectedIndexChanged(object sender, EventArgs e)
		{
			FilterbyCmbERP(cmbYearERP.Text, cmbMonthERP.Text, cmbEngagementERP.Text);
		}	
		
		
		//========================================================
		//========================================================
		//========================================================
		//========================================================
		//========================================================
		
		
		void DisplayDefaultCmbST()
		{
			cmbYearST.SelectedIndex = -1;
			cmbMonthST.SelectedIndex = -1;
			
			myBindingSource = dcImportSoldTime.GetAllEngCode();
			
			cmbEngagementST.DataSource = myBindingSource;
			cmbEngagementST.DisplayMember = "Engagement_Code";
			//cmbEngagement.ValueMember = "ID_Engagement";
			cmbEngagementST.SelectedIndex = -1;
		}
		
		void ResetST()
		{
			myBindingSource = dcImportSoldTime.GetAll();
			grdST.DataSource = myBindingSource;
			
			grdPreviewST.Rows.Clear();
			
			DisplayDefaultCmbST();
		}
		
		void FilterbyCmbST(string year, string month, string EngCode)
		{
			if (flagStart == true)
			{
				BindingSource tempST = (BindingSource)grdST.DataSource;
				tempST.Filter = "Engagement_Code LIKE '%" + EngCode + "%' AND FYear LIKE '%" + year + "%' AND Months LIKE '%" + month + "%'";
				grdST.DataSource = tempST;
			}
		}
		
		bool isDuplicatedST(string year, string month, string EngCode)
		{
			BindingSource tempST = (BindingSource)grdTempST.DataSource;
			tempST.Filter = "Engagement_Code LIKE '%" + EngCode + "%' AND FYear LIKE '%" + year + "%' AND Months LIKE '%" + month + "%'";
			grdTempST.DataSource = tempST;
			
			for (int i = 0; i < grdTempST.Rows.Count; i++)
			{
				if (grdTempST.Rows[i].Cells["FYear"].Value.ToString() == year
				    & grdTempST.Rows[i].Cells["Months"].Value.ToString() == month
				    & grdTempST.Rows[i].Cells["Engagement_Code"].Value.ToString() == EngCode)
					return true;
			}
			return false;
		}
		
		//EVENTS
		void BtnBrowseSTClick(object sender, EventArgs e)
		{
			var browseFile = new System.Windows.Forms.OpenFileDialog();
			browseFile.DereferenceLinks = true;
			browseFile.Filter = "Excel files (*.xls or .xlsx)|.xls;*.xlsx";
			
			if (browseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
			{
			    string fileToOpen = browseFile.FileName;
			
			    //System.IO.FileInfo File = new System.IO.FileInfo(fileToOpen);
				//OR
				//System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
			    
			    Excel.ApplicationClass app = new ApplicationClass();
            	// Create the workbook object by opening the excel file.
	            
            	Excel.Workbook workBook = app.Workbooks.Open(fileToOpen,
	                                                         0,
	                                                         true,
	                                                         5,
	                                                         "",
	                                                         "",
	                                                         true,
	                                                         Excel.XlPlatform.xlWindows,
	                                                         "\t",
	                                                         false,
	                                                         false,
	                                                         0,
	                                                         true,
	                                                         1,
	                                                         0);
	            // Get the active worksheet using sheet name or active sheet
	            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.ActiveSheet;
            
	            int row_index = 2;
	            int col_index = 1;
	            
	            try
	            {
	                while (((Excel.Range)workSheet.Cells[row_index, col_index]).Value2 != null)
	                {
	                    // Read the Cells to get the required value.
	                    Object[] temp = new Object[4];
	                    temp[0] =(Object)((Excel.Range)workSheet.Cells[row_index, 1]).Value2.ToString();
	                    temp[1] =(Object)((Excel.Range)workSheet.Cells[row_index, 2]).Value2.ToString();
	                    temp[2] =(Object)((Excel.Range)workSheet.Cells[row_index, 3]).Value2.ToString();
	                    temp[3] =(Object)((Excel.Range)workSheet.Cells[row_index, 4]).Value2.ToString();
	                    
	                    grdPreviewST.Rows.Add(temp);
	                    
	                    row_index++;
	                }
	                
	                workBook.Close(false,false,false);
            		app.Quit();
	            }
	            catch (Exception ex)
	            {
	            	MessageBox.Show("Read file unsuccessfully.\nError: " + ex.ToString());
	            }
			}
		}
		
		void BtnSubmitSTClick(object sender, EventArgs e)
		{
			int RowNum = 0;
			
			myBindingSource = dcImportSoldTime.GetAll();
			grdTempST.DataSource = myBindingSource;
			
			for (int i = 0; i < grdPreviewST.Rows.Count; i++)
			{
				try
				{
					if (isDuplicatedST(grdPreviewST.Rows[i].Cells["FYear"].Value.ToString(),
					                 grdPreviewST.Rows[i].Cells["Months"].Value.ToString(),
					                 grdPreviewST.Rows[i].Cells["Engagement_Code"].Value.ToString()) == false)
					
				    {
						dcImportSoldTime.SubmitOne(true,grdPreviewST.Rows[i].Cells[0].Value.ToString(), 
						                      grdPreviewST.Rows[i].Cells[1].Value.ToString(),
						                      grdPreviewST.Rows[i].Cells[2].Value.ToString(),
						                      grdPreviewST.Rows[i].Cells[3].Value.ToString());
					
						RowNum++;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Imported unsuccessfully.\nError: " + ex.ToString());
				}
			}
			
			MessageBox.Show("Imported " + RowNum.ToString() + "/ " + grdPreviewST.Rows.Count +" row(s) successfully.");
			ResetST();
		}
		
		void BtnClearSTClick(object sender, EventArgs e)
		{
			ResetST();
		}
		
		void BtnDelSTClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		    {
				int RowNum = 0;
				
				for (int i = 0; i < grdST.Rows.Count; i++)
				{
					try
					{
						dcImportSoldTime.DeleteOne(grdST.Rows[i].Cells[0].Value.ToString(), 
							                      grdST.Rows[i].Cells[1].Value.ToString(),
							                      grdST.Rows[i].Cells[2].Value.ToString());
						RowNum++;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Imported unsuccessfully.\nError: " + ex.ToString());
					}
				}
				
				MessageBox.Show("Deleted " + RowNum.ToString() + " row(s) successfully.");
				ResetST();
			}
		}
		
		void CmbYearSTSelectedIndexChanged(object sender, EventArgs e)
		{
			FilterbyCmbST(cmbYearST.Text, cmbMonthST.Text, cmbEngagementST.Text);
		}
		
		void CmbMonthSTSelectedIndexChanged(object sender, EventArgs e)
		{
			FilterbyCmbST(cmbYearST.Text, cmbMonthST.Text, cmbEngagementST.Text);
		}
		
		void CmbEngagementSTSelectedIndexChanged(object sender, EventArgs e)
		{
			FilterbyCmbST(cmbYearST.Text, cmbMonthST.Text, cmbEngagementST.Text);
		}
	}
}
