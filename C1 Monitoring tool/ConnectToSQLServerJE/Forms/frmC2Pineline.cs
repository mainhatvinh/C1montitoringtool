/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/17/2013
 * Time: 4:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmClient.
	/// </summary>
	public partial class frmC2Pineline : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		DataTable dtClient_Industry = new DataTable();
		//DataTable dtIndudtry = new DataTable();
		bool flagStart = false;
		int _Role_Type;
		
		public frmC2Pineline(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			_Role_Type = Role_type;
			
			InitializeComponent();
			this.pnl = mainPanel;
			DisplayCmb();
			DisplayGridview();
			cmbSearch.SelectedIndex = 0;
			//grdMembers.Columns["Acct"].HeaderText = "Mã tài khoản";
			//grdMembers.Columns["DescrVN"].HeaderText = "Mô tả";
			
			//Validation
			txtStatus.KeyPress += Validation.txtIntegerOnly;
			txtFee.KeyPress += Validation.txtIntegerOnly;
			txtPIC.Text = "henri.hoang";
			txtStatus.Text = "0";
//			this.txtClientCode.KeyPress += Validation.txtIntegerOnly;
//			this.txtEmail1.KeyPress += Validation.txtNoSpace;
//			this.txtEmail2.KeyPress += Validation.txtNoSpace;
//			this.txtEmail3.KeyPress += Validation.txtNoSpace;
			
			
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
		
		// combobox setting
		void DisplayCmb()
		{
			cmbMIC.DataSource = dcITRAMember.GetAllManagers();
			cmbMIC.DisplayMember = "FullName";
			cmbMIC.ValueMember = "ID_Member";
			cmbMIC.SelectedIndex =-1;
									
			cmbSIC.DataSource = dcITRAMember.GetAllSeniors();
			cmbSIC.DisplayMember = "FullName";
			cmbSIC.ValueMember = "ID_Member";
			cmbSIC.SelectedIndex =-1;
			
			cmbClient.DataSource = dcClient.GetAll();
			cmbClient.DisplayMember = "Client_name";
			cmbClient.ValueMember = "Client_Code";
			cmbClient.SelectedIndex = -1;	
			
		}
		
		
		//VALIDATION
		bool isValidated()
		{
			if (cmbClient.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a client");
				return false;
			}
			
			if (Validation.isInteger(txtStatus.Text) == false)
			{
				MessageBox.Show("Please input a correct percent");
				return false;
			}
			else if ((int.Parse(txtStatus.Text) > 100) || (int.Parse(txtStatus.Text) <= 0))
			{
				MessageBox.Show("Please input a correct percent");
				return false;
			}
			
			return true;
		}
		
		
				
		bool IsExistedItem(DataTable dt, string fieldname, string item)
		{
			if (dt != null)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if(dt.Rows[i][fieldname].ToString() == item)
					   return true;
				}
			}
			
			return false;
		}
		
		
		//GRIDVIEW
		void GrdClientSelectionChanged(object sender, EventArgs e)
		{
			if (flagStart == true  && grdC2Pineline.SelectedRows.Count > 0)
				ClickOneRow();
		}
		
		void GrdClientCellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >=0)
				ClickOneRow();
		}
		
		void GrdClientDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdC2Pineline.SelectedRows.Count;i++)
			{
				grdC2Pineline.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void ClickOneRow()
		{
			txtPipeline_ID.Text = grdC2Pineline.CurrentRow.Cells["Pipeline_ID"].Value.ToString();				
			txtActPlan.Text = grdC2Pineline.CurrentRow.Cells["Action_Plan"].Value.ToString();
			txtEngDesc.Text = grdC2Pineline.CurrentRow.Cells["Engagement_Description"].Value.ToString();
			txtStatus.Text = grdC2Pineline.CurrentRow.Cells["Status"].Value.ToString();
			txtInfoUpdate.Text = grdC2Pineline.CurrentRow.Cells["Information_Update"].Value.ToString();
			if (grdC2Pineline.CurrentRow.Cells["Office"].Value.ToString() != "")
			{
			cmbOffice.Text = grdC2Pineline.CurrentRow.Cells["Office"].Value.ToString();
			}
			else
			cmbOffice.SelectedIndex = -1;
			txtFee.Text = FormatConverter.addComma(false, grdC2Pineline.CurrentRow.Cells["Fee_USD"].Value.ToString());
			txtServicetype.Text = grdC2Pineline.CurrentRow.Cells["Service_Type"].Value.ToString();
			txtPIC.Text = grdC2Pineline.CurrentRow.Cells["PIC"].Value.ToString();
			if (grdC2Pineline.CurrentRow.Cells["Decision"].Value.ToString() != "")
			{
			cmbstatus.Text = grdC2Pineline.CurrentRow.Cells["Decision"].Value.ToString();
			}
			else
			cmbstatus.SelectedIndex = -1;	
			//txtYear.Text = grdC2Pineline.CurrentRow.Cells["FYear"].Value.ToString();
			//txtEYFY.Text = grdC2Pineline.CurrentRow.Cells["EYFYear"].Value.ToString();
			dtpEYFYearFrom.Text = grdC2Pineline.CurrentRow.Cells["EYFYearFrom"].Value.ToString();
			dtpEYFYearTo.Text = grdC2Pineline.CurrentRow.Cells["EYFYearTo"].Value.ToString();
			dtpFYearFrom.Text = grdC2Pineline.CurrentRow.Cells["FYearFrom"].Value.ToString();
			dtpFYearTo.Text = grdC2Pineline.CurrentRow.Cells["FYearTo"].Value.ToString();
			if (grdC2Pineline.CurrentRow.Cells["MIC"].Value.ToString() == "")
					cmbMIC.SelectedIndex = -1;
			else
				cmbMIC.Text = grdC2Pineline.CurrentRow.Cells["MIC"].Value.ToString();
			
			if (grdC2Pineline.CurrentRow.Cells["SIC"].Value.ToString() == "")
					cmbSIC.SelectedIndex = -1;
			else
				cmbSIC.Text = grdC2Pineline.CurrentRow.Cells["SIC"].Value.ToString();
								
			if (grdC2Pineline.CurrentRow.Cells["Client_Name"].Value.ToString() == "")
					cmbClient.SelectedIndex = -1;
			else
				cmbClient.Text = grdC2Pineline.CurrentRow.Cells["Client_Name"].Value.ToString();
			flagStart = true;
		}
		
		public void DisplayGridview()
		{
			grdC2Pineline.DataSource = dcPipeline.GetAll();
			grdC2Pineline.Columns["pipeline_ID"].Visible = false;
			grdC2Pineline.Columns["Client_Code"].Visible = false;
			grdC2Pineline.Columns["Status"].HeaderText = "% to win";
			grdC2Pineline.Columns["Fee_USD"].HeaderText = "Fee in VND";
			grdC2Pineline.Columns["Decision"].HeaderText = "Status";
			grdC2Pineline.Columns["Fee_USD"].DefaultCellStyle.Format ="#,##0.##";
			grdC2Pineline.Columns["Engagement_Description"].HeaderText = "Opportunity Description";
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdC2Pineline);
			//grdClient.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		public void SelectRowByID(string id) 
		{
			for(int i = 0; i < grdC2Pineline.RowCount-1 ;i++)
			{
				if(grdC2Pineline.Rows[i].Cells["Client_Code"].Value.ToString() == id)
				{
					grdC2Pineline.CurrentCell = grdC2Pineline.Rows[i].Cells[0];
					break;
				}
			}			
		}
		
		
		//BUTTONS
		void BtnResetClick(object sender, EventArgs e)
		{
			flagStart = false;
			Reset();
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (isValidated() == true)
			{
//				MessageBox.Show(grdC2Pineline.RowCount.ToString());
				try
				{
					if ((grdC2Pineline.RowCount == 0)||(txtPipeline_ID.Text != grdC2Pineline.CurrentRow.Cells["Pipeline_ID"].Value.ToString()))
					{
//						MessageBox.Show("insert");
						dcPipeline.SubmitOne(true,"0",txtPIC.Text,cmbMIC.Text, cmbSIC.Text, cmbClient.GetItemText(cmbClient.SelectedValue),
						                     cmbOffice.Text,txtServicetype.Text,txtEngDesc.Text,txtStatus.Text,txtInfoUpdate.Text,txtActPlan.Text,cmbstatus.Text,txtFee.Text, dtpEYFYearFrom.Text, dtpEYFYearTo.Text, dtpFYearFrom.Text, dtpFYearTo.Text);
					}
					else
					{
//						MessageBox.Show("update");
						dcPipeline.SubmitOne(false,txtPipeline_ID.Text,txtPIC.Text,cmbMIC.Text, cmbSIC.Text, cmbClient.GetItemText(cmbClient.SelectedValue),
						                     cmbOffice.Text,txtServicetype.Text,txtEngDesc.Text,txtStatus.Text,txtInfoUpdate.Text,txtActPlan.Text,cmbstatus.Text,txtFee.Text,dtpEYFYearFrom.Text, dtpEYFYearTo.Text, dtpFYearFrom.Text, dtpFYearTo.Text);
					}
					DisplayGridview();
					Reset();
					DeselectGrd();
					MessageBox.Show("Submitted successfully.");
					
				}
				catch (Exception ex)
				{
					MessageBox.Show("Submitted unsuccessfully.\nError: " + ex.ToString());
				}
			}
		}

		void BtnDelClick(object sender, EventArgs e)
		{
			if (txtPipeline_ID.Text == "")
				return;
	        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            //dcPipeline.DeleteOne(grdC2Pineline.CurrentRow.Cells["Pipeline_ID"].Value.ToString());
		            //MessageBox.Show(grdC2Pineline.CurrentRow.Cells["Pipeline_ID"].Value.ToString());
		            // handle relating tables
		            dcPipeline.DeleteOne(grdC2Pineline.CurrentRow.Cells["Pipeline_ID"].Value.ToString());
		            
		            
					DisplayGridview();
					Reset();
		        }			
		}
			
		
		//OTHERS		
		void Reset()
		{
			//DisplayCmb();			
			cmbMIC.SelectedIndex =-1;
			cmbSIC.SelectedIndex =-1;
			cmbClient.SelectedIndex = -1;
			cmbOffice.SelectedIndex = -1;
			dtpEYFYearFrom.Text = DateTime.Today.ToShortDateString();
			dtpEYFYearTo.Text = DateTime.Today.ToShortDateString();
			dtpFYearFrom.Text = DateTime.Today.ToShortDateString();
			dtpFYearTo.Text = DateTime.Today.ToShortDateString();
			//txt
			txtActPlan.Text = "";
			txtEngDesc.Text = "";
			txtFee.Text = "";
			txtInfoUpdate.Text = "";
			txtStatus.Text = "0";
			//txtOffice.Text = "";
			txtServicetype.Text = "";
			txtStatus.Text = "";
			txtPipeline_ID.Text = "";
			cmbstatus.SelectedIndex = -1;
			//txtEYFY.Text = "";
			//txtYear.Text = "";
			
			txtSearch.Text = "";
			txtPIC.Text = "henri.hoang";
			DeselectGrd();
		}
		
		string getChbValue(CheckState checkstate)
		{
			if (checkstate == CheckState.Checked)
				return "1";
			else
				return "0";
		}
		
		
		//SEARCH
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			BindingSource temp = (BindingSource) grdC2Pineline.DataSource;
			temp.Filter = getFieldName(cmbSearch.Text) + " LIKE '%" + txtSearch.Text + "%'";
			
			grdC2Pineline.DataSource = temp;
		}
		
		void GrdClientSorted(object sender, EventArgs e)
		{
			Reset();
			DeselectGrd();
		}
		
		
		
		
		
		string getFieldName(string field)
		{
			switch (field)
			{
				case "Client Name": return "Client_Name";
				case "Service Type": return "Service_Type";
				case "Status": return "Decision";
				case "MIC": return "MIC";
				case "SIC": return "SIC";
				
			}
			return "";			
		}
		
		void CmbSearchSelectedIndexChanged(object sender, EventArgs e)
		{
			txtSearch.Text = "";
		}
	}
}
