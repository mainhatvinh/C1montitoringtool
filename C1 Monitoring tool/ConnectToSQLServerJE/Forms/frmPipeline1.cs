/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/17/2013
 * Time: 4:29 PM
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
	/// Description of frmITRAMember.
	/// </summary>
	public partial class frmPipeline1 : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSource1 = new BindingSource();
		bool flagStart = false;
		
		public frmPipeline1(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			DisplayCmb();
			DisplayGridview();
			
			//DisplayGridview();
			//Reset();
			
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
		
		void DisplayGridview()
		{
			grdPipeline.DataSource = dcPipeline.GetAll();
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdPipeline);
			
			//grdPipeline.CurrentCell.Selected = false;
			
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdPipeline.SelectedRows.Count;i++)
			{
				grdPipeline.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void Reset()
		{
			//DisplayCmb();
			cmbPIC.SelectedIndex =-1;
			cmbMIC.SelectedIndex =-1;
			cmbSIC.SelectedIndex =-1;
			cmbClientName.SelectedIndex = -1;
			cmbClientYear.SelectedIndex = -1;
			cmbDecision.SelectedIndex = -1;
			cmbFY.SelectedIndex = -1;			
			cmbOffice.SelectedIndex = -1;
			
			//txt
			txtActPlan.Text = "";
			txtEngDes.Text = "";
			txtFee.Text = "";
			txtInfoUpdated.Text = "";
			//txtOffice.Text = "";
			txtService.Text = "";
			txtStatus.Text = "";
			txtPipeline_ID.Text = "";
			
			DeselectGrd();
		}
		
		void DisplayCmb()
		{
			cmbMIC.DataSource = dcITRAMember.GetAllManagers();
			cmbMIC.DisplayMember = "FullName";
			cmbMIC.ValueMember = "ID_Member";
			cmbMIC.SelectedIndex =-1;
			
			cmbPIC.DataSource = dcITRAMember.GetPartner();
			cmbPIC.DisplayMember = "FullName";
			cmbPIC.ValueMember = "ID_Member";
			cmbPIC.SelectedIndex =-1;
			
			cmbSIC.DataSource = dcITRAMember.GetAllSeniors();
			cmbSIC.DisplayMember = "FullName";
			cmbSIC.ValueMember = "ID_Member";
			cmbSIC.SelectedIndex =-1;
			
			cmbClientName.DataSource = dcClient.GetAll();
			cmbClientName.DisplayMember = "Client_name";
			cmbClientName.ValueMember = "Client_Code";
			cmbClientName.SelectedIndex = -1;	
			
		}
		
		
		void BtnResetClick(object sender, EventArgs e)
		{
			Reset();
		}
		
		void Label19Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (isValidated() == true)
			{
//				MessageBox.Show(grdPipeline.RowCount.ToString());
				try
				{
					if ((grdPipeline.RowCount == 0)||(txtPipeline_ID.Text != grdPipeline.CurrentRow.Cells["Pipeline_ID"].Value.ToString()))
					{
//						MessageBox.Show("insert");
//						dcPipeline.SubmitOne(true,"0",cmbPIC.Text,cmbMIC.Text, cmbSIC.Text, cmbClientName.GetItemText(cmbClientName.SelectedValue),
//						                     cmbOffice.Text,txtService.Text,txtEngDes.Text,cmbClientYear.Text,cmbFY.Text
//						                     ,txtStatus.Text,txtInfoUpdated.Text,txtActPlan.Text,cmbDecision.Text,txtFee.Text);
					}
					else
					{
//						MessageBox.Show("update");
//						dcPipeline.SubmitOne(false,txtPipeline_ID.Text,cmbPIC.Text,cmbMIC.Text, cmbSIC.Text, cmbClientName.GetItemText(cmbClientName.SelectedValue),
//						                     cmbOffice.Text,txtService.Text,txtEngDes.Text,cmbClientYear.Text,cmbFY.Text
//						                     ,txtStatus.Text,txtInfoUpdated.Text,txtActPlan.Text,cmbDecision.Text,txtFee.Text);
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
		
		bool isValidated()
		{
			if (cmbClientName.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a client");
				return false;
			}
			
			return true;
		}
		
		
		void BtnDelClick(object sender, EventArgs e)
		{
			if (txtPipeline_ID.Text == "")
				return;
	        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            //dcPipeline.DeleteOne(grdPipeline.CurrentRow.Cells["Pipeline_ID"].Value.ToString());
		            //MessageBox.Show(grdPipeline.CurrentRow.Cells["Pipeline_ID"].Value.ToString());
		            // handle relating tables
		            dcPipeline.DeleteOne(grdPipeline.CurrentRow.Cells["Pipeline_ID"].Value.ToString());
		            
		            
					DisplayGridview();
					Reset();
		        }		
		}
		
		void GrdPipelineCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >=0)
				ClickOneRow();
		}
		
		void ClickOneRow()
		{
			txtPipeline_ID.Text = grdPipeline.CurrentRow.Cells["Pipeline_ID"].Value.ToString();				
			txtActPlan.Text = grdPipeline.CurrentRow.Cells["Action_Plan"].Value.ToString();
			txtEngDes.Text = grdPipeline.CurrentRow.Cells["Engagement_Description"].Value.ToString();
			txtStatus.Text = grdPipeline.CurrentRow.Cells["Status"].Value.ToString();
			txtInfoUpdated.Text = grdPipeline.CurrentRow.Cells["Information_Update"].Value.ToString();
			cmbOffice.Text = grdPipeline.CurrentRow.Cells["Office"].Value.ToString();
			txtFee.Text = FormatConverter.addComma(false, grdPipeline.CurrentRow.Cells["Fee_USD"].Value.ToString());
			txtService.Text = grdPipeline.CurrentRow.Cells["Service_Type"].Value.ToString();
			
			
			if (grdPipeline.CurrentRow.Cells["FYear"].Value.ToString() == "")
					cmbClientYear.SelectedIndex = -1;
			else
				cmbClientYear.Text = grdPipeline.CurrentRow.Cells["FYear"].Value.ToString();
			
			if (grdPipeline.CurrentRow.Cells["Decision"].Value.ToString() == "")
					cmbDecision.SelectedIndex = -1;
			else
				cmbDecision.Text = grdPipeline.CurrentRow.Cells["Decision"].Value.ToString();
			
			if (grdPipeline.CurrentRow.Cells["EYFYear"].Value.ToString() == "")
					cmbFY.SelectedIndex = -1;
			else
				cmbFY.Text = grdPipeline.CurrentRow.Cells["EYFYear"].Value.ToString();
			
			if (grdPipeline.CurrentRow.Cells["MIC"].Value.ToString() == "")
					cmbMIC.SelectedIndex = -1;
			else
				cmbMIC.Text = grdPipeline.CurrentRow.Cells["MIC"].Value.ToString();
			
			if (grdPipeline.CurrentRow.Cells["SIC"].Value.ToString() == "")
					cmbSIC.SelectedIndex = -1;
			else
				cmbSIC.Text = grdPipeline.CurrentRow.Cells["SIC"].Value.ToString();
			
			if (grdPipeline.CurrentRow.Cells["PIC"].Value.ToString() == "")
					cmbPIC.SelectedIndex = -1;
			else
				cmbPIC.Text = grdPipeline.CurrentRow.Cells["PIC"].Value.ToString();
				
			if (grdPipeline.CurrentRow.Cells["Client_Name"].Value.ToString() == "")
					cmbClientName.SelectedIndex = -1;
			else
				cmbClientName.Text = grdPipeline.CurrentRow.Cells["Client_Name"].Value.ToString();
		}
		
		void GrdPipelineDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
	}
}
