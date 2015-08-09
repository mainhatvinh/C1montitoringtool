/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 2:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace C1Monitoring
{
	/// <summary>
	/// Description of Industry.
	/// </summary>
	public partial class frmIndustry : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		bool flagStart = false;
		bool flagStart_type = false;
		bool flagStart_business = false;
		
		public frmIndustry(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			cmbSearch.SelectedIndex = 0;
			DisplayGridview();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = false;
				btnReset.Enabled = false;
			}
			else if (Role_type == 1)
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
			else if (Role_type == 4)
			{
				btnDel.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
		}
		
		
		//VALIDATION
		bool isValidated()
		{
			if (txtBusiness.Text == "" || txtType.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
//			for (int i =0; i <= grdIndustry.RowCount -1; i++)
//				if (grdIndustry.CurrentCell.RowIndex != i 
//				    && grdIndustry.Rows[i].Cells[1].Value.ToString() == txtBusiness.Text)
//			{
//				MessageBox.Show("This industry business existed already");
//					return false;
//			}
			return true;
		}
		
		
		public void DisplayGridview()
		{
			myBindingSource = dcIndustry.GetAll1();
			grdIndustry.DataSource = myBindingSource;
			grdIndustry.Columns[0].Visible = false;
			grdIndustry.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdIndustry.Columns["Creator"].Visible = false;
			grdIndustry.Columns["CreateDate"].Visible = false;
			
			
			grdIndustryType.DataSource = dcIndustry.GetListType();
			
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdIndustryType);
			grdIndustryType.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			//DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdIndustryType);
			grdIndustryBusiness.DataSource = null;
			
		}

		
		//Reset
		void Reset()
		{
			txtIndustryID.Text = "";
			txtType.Text = "";
			txtBusiness.Text = "";		
			
			DeselectGrd();
			DeselectGrdType();
			DeselectGrdBusiness();
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			flagStart = false;
			flagStart_business = false;
			flagStart_type = false;
			Reset();
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (isValidated() == true)
			{
				if (txtIndustryID.Text != grdIndustryBusiness.CurrentRow.Cells["Industry_ID"].Value.ToString())
					dcIndustry.SubmitOne(true, txtIndustryID.Text, txtType.Text,txtBusiness.Text);
				else
					dcIndustry.SubmitOne(false, txtIndustryID.Text, txtType.Text,txtBusiness.Text );
				DisplayGridview();
				//SelectRowByID(txtID.Text);
				Reset();
				
				flagStart = false;
				
				MessageBox.Show("Submitted successfully.");
			}
		}
		
		void BtnDelClick(object sender, EventArgs e)
		{
			if (txtIndustryID.Text == "")
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcIndustry.DeleteOne(grdIndustryBusiness.CurrentRow.Cells["Industry_ID"].Value.ToString());
					DisplayGridview();
					Reset();
		        }	
		}
		
		void ClickOneRow()
		{
			txtIndustryID.Text = grdIndustry.CurrentRow.Cells["Industry_ID"].Value.ToString();
			txtType.Text = grdIndustry.CurrentRow.Cells["Industry_type"].Value.ToString();
			txtBusiness.Text = grdIndustry.CurrentRow.Cells["IndustryBusiness"].Value.ToString();
			
			flagStart  = true;
		}
		
		void GrdIndustrySelectionChanged(object sender, EventArgs e)
		{
			if (flagStart == true && grdIndustry.SelectedRows.Count > 0)
				ClickOneRow();
		}
		
		void GrdIndustryCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
				ClickOneRow();
		}
		
		void GrdIndustryDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdIndustry.SelectedRows.Count;i++)
			{
				grdIndustry.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void GrdIndustrySorted(object sender, EventArgs e)
		{
			Reset();
			DeselectGrd();
		}
		
		void CmbSearchSelectedIndexChanged(object sender, EventArgs e)
		{
			txtSearch.Text = "";
		}
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
//			BindingSource tempEng = (BindingSource)grdIndustry.DataSource;
//			tempEng.Filter = getFieldName(cmbSearch.Text) +" LIKE '%" + txtSearch.Text + "%'";
//			grdIndustry.DataSource = tempEng;
			
			BindingSource tempEng = (BindingSource)grdIndustryType.DataSource;
			tempEng.Filter = "Industry_type LIKE '%" + txtSearch.Text + "%'";
			grdIndustryType.DataSource = tempEng;
			grdIndustryBusiness.DataSource = null;

//			if (getFieldName(cmbSearch.Text) == "IndustryBusiness")
//			{
//				BindingSource tempEng = (BindingSource)grdIndustryBusiness.DataSource;
//				tempEng.Filter = getFieldName(cmbSearch.Text) +" LIKE '%" + txtSearch.Text + "%'";
//				grdIndustryBusiness.DataSource = tempEng;
//				grdIndustryBusiness.DataSource = null;
//			}
		}
		
		string getFieldName(string field)
		{
			switch (field)
			{
				case "Industry Business": return "IndustryBusiness";
				case "Industry Type": return "Industry_type";
				
			}
			return "";			
		}
		
		// Phien ban moi nhat
		
		
		void GrdIndustryTypeCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
			{
				//MessageBox.Show(grdIndustry.CurrentRow.Cells["Industry_type"].Value.ToString());
				ClickOneRow_Type(grdIndustryType.CurrentRow.Cells["Industry_type"].Value.ToString());
			}
		}
		
		void ClickOneRow_Type(string industry_type)
		{
			grdIndustryBusiness.DataSource = dcIndustry.GetData_ByType(industry_type);
			grdIndustryBusiness.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdIndustryBusiness.Columns["Industry_ID"].Visible = false;
			grdIndustryBusiness.Columns["IndustryBusiness"].HeaderText = "Industry_Business";
			
			txtType.Text = grdIndustryType.CurrentRow.Cells["Industry_type"].Value.ToString();
			txtBusiness.Text ="";
			txtIndustryID.Text = "";
			
			flagStart_type = true;
		}
		
		void GrdIndustryTypeDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrdType();
			grdIndustryType.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void DeselectGrdType()
		{
			for(int i =0; i < grdIndustryType.SelectedRows.Count;i++)
			{
				grdIndustryType.SelectedRows[i].Selected = false;
			}
			//grdIndustryType.CurrentCell = grdIndustryType.Rows[grdIndustryType.FirstDisplayedScrollingRowIndex].Cells[0];
			grdIndustryType.CurrentCell = grdIndustryType.Rows[0].Cells[0];
			grdIndustryType.CurrentCell.Selected = false;
			flagStart_type = false;
		}
		
		
		void GrdIndustryBusinessDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrdBusiness();
			grdIndustryBusiness.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void DeselectGrdBusiness()
		{
			if (grdIndustryBusiness.DataSource == null)
				return;
			for(int i =0; i < grdIndustryBusiness.SelectedRows.Count;i++)
			{
				grdIndustryBusiness.SelectedRows[i].Selected = false;
			}
			grdIndustryBusiness.CurrentCell = grdIndustryBusiness.Rows[0].Cells["IndustryBusiness"];
			grdIndustryBusiness.CurrentCell.Selected = false;
			flagStart_business = false;
		}
		
		
		
		void GrdIndustryBusinessCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
			{
				//MessageBox.Show(grdIndustry.CurrentRow.Cells["Industry_type"].Value.ToString());
				ClickOneRow_Business(grdIndustryBusiness.CurrentRow.Cells["Industry_ID"].Value.ToString()
				                    ,grdIndustryBusiness.CurrentRow.Cells["IndustryBusiness"].Value.ToString());
			}
		}
		
		void ClickOneRow_Business(string industry_ID, string industryBusiness)
		{
			//txtType.Text = grdIndustryType.CurrentRow.Cells["Industry_type"].Value.ToString();
			//MessageBox.Show(industryBusiness.ToString());
			txtIndustryID.Text = industry_ID;
//			txtType.Text = grdIndustry.CurrentRow.Cells["Industry_type"].Value.ToString();
			txtBusiness.Text = industryBusiness;
			
			flagStart_business = true;
		}
		
		
		void GrdIndustryTypeSorted(object sender, EventArgs e)
		{
			Reset();
			grdIndustryBusiness.DataSource = null;
			
			//DeselectGrdType();
		}
		
		
		
		void GrdIndustryBusinessSorted(object sender, EventArgs e)
		{
			//MessageBox.Show("2");
			txtIndustryID.Text ="";
			txtBusiness.Text = "";
			
			DeselectGrdBusiness();
		}
		
		void GrdIndustryTypeSelectionChanged(object sender, EventArgs e)
		{
			if (grdIndustryType.CurrentRow == null)
			{
//				MessageBox.Show("1");
				return;
			}
			if (flagStart_type == true && grdIndustryType.SelectedRows.Count > 0)
				ClickOneRow_Type(grdIndustryType.CurrentRow.Cells["Industry_type"].Value.ToString());
		}
		
		void GrdIndustryBusinessSelectionChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(grdIndustryBusiness.CurrentRow.Cells["Industry_ID"].Value.ToString());
			if (grdIndustryBusiness.CurrentRow == null)
			{
//				MessageBox.Show("1");
				return;
			}
			if (flagStart_business == true && grdIndustryBusiness.SelectedRows.Count > 0)
				ClickOneRow_Business(grdIndustryBusiness.CurrentRow.Cells["Industry_ID"].Value.ToString()
				                    ,grdIndustryBusiness.CurrentRow.Cells["IndustryBusiness"].Value.ToString());
		}
	}
}
