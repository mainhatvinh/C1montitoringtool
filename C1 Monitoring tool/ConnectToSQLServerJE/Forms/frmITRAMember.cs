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
	public partial class frmITRAMember : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSource1 = new BindingSource();
		bool flagStart = false;
		
		public frmITRAMember(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			DisplayGridview();
			Reset();
			
			//Naming grd comlumn
			grdMembers.Columns["Sex"].HeaderText = "Gender";
			//grdMembers.Columns["DescrVN"].HeaderText = "Mô tả";
			grdMembers.Columns[2].Frozen = true;
			
			//Validation
			this.txtName.KeyPress += Validation.txtNameEY;
			this.txtEmail.KeyPress += Validation.txtNoSpace;
			this.txtID.KeyPress += Validation.txtNoSpace;
			
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
			if (txtContactNo.Text == "" || txtEmail.Text == "" || txtID.Text == "" || txtName.Text == ""
			   || cmbLevel.Text == "" || cmbGender.Text == "" || cmbStatus.Text == "" || cmbRole.Text == ""
			   || cmbWorkingLocation.Text == "" || cmbGroup.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
			
			if (Validation.isNameEY(txtName.Text) == false)
			{
				MessageBox.Show("Employee name is not correct.");
				return false;
			}
				
			if (Validation.isNoSpace(txtEmail.Text) == false)
			{
				MessageBox.Show("Email is not correct.");
				return false;
			}
			
			if (Validation.isMemberIDFormat(txtID.Text) == false)
			{
				MessageBox.Show("Employee ID is not correct.");
				return false;
			}
			
			if (dtpEndDate.Value < dtpStartDate.Value && cmbStatus.Text == "Resigned")
			{
				MessageBox.Show("End date is prior to start date.");
				return false;
			}
			
			//Check duplicate Risk Member ID
			if (txtID.ReadOnly == false)
			{
				myBindingSource = dcITRAMember.GetAll();
				grdTemp.DataSource = myBindingSource;
							
				for (int i = 0; i < grdTemp.Rows.Count; i++)
				{
					if (grdTemp.Rows[i].Cells["ID_Member"].Value != null)
				    {
						if (txtID.Text == grdTemp.Rows[i].Cells["ID_Member"].Value.ToString())
						{
							MessageBox.Show("Risk member ID existed already");
							return false;
						}
				    }
				}
			}
			
			return true;
		}
		
		
		//COMBOBOX
		public void DisplayDefaultCmb()
		{
			myBindingSource = dcRate.GetAll();
			cmbLevel.DataSource = myBindingSource;
			cmbLevel.DisplayMember = "Level";
			cmbLevel.SelectedIndex = -1;
			
			cmbStatus.SelectedIndex = -1;
			cmbGender.SelectedIndex = -1;
			cmbWorkingLocation.SelectedIndex = -1;
			cmbGroup.SelectedIndex = -1;
			
			if(cmbStatus.Text == "Resigned")
				dtpEndDate.Enabled = true;
			else
				dtpEndDate.Enabled = false;
			
			cmbRole.Text = "Normal";
			
			myBindingSource1 = dcITRAMember.GetManagerUp();
			cmbClor.DataSource =  myBindingSource1;
			cmbClor.DisplayMember = "FullName";
			cmbClor.SelectedIndex = -1;
			
		}
		
		
		//GRIDVIEW
		void GrdMembersSelectionChanged(object sender, EventArgs e)
		{
			if (flagStart == true && grdMembers.SelectedRows.Count > 0)
				ClickOneRow();
		}
		
		void GrdMembersCellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0 )
				ClickOneRow();
		}
		
		void GrdMembersDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();	
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdMembers.SelectedRows.Count;i++)
			{
				grdMembers.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void ClickOneRow()
		{
			txtName.Text = grdMembers.CurrentRow.Cells["FullName"].Value.ToString();
			txtEmail.Text = grdMembers.CurrentRow.Cells["Email"].Value.ToString();
			txtContactNo.Text = grdMembers.CurrentRow.Cells["Phone"].Value.ToString();
			txtID.Text = grdMembers.CurrentRow.Cells["ID_Member"].Value.ToString();
			cmbGender.SelectedItem = grdMembers.CurrentRow.Cells["Sex"].Value.ToString();
			cmbLevel.Text = grdMembers.CurrentRow.Cells["Member_Level"].Value.ToString();
			cmbStatus.SelectedItem = grdMembers.CurrentRow.Cells["Status"].Value.ToString();
			cmbRole.SelectedItem = grdMembers.CurrentRow.Cells["Role"].Value.ToString();
			cmbWorkingLocation.SelectedItem = grdMembers.CurrentRow.Cells["WorkingLocation"].Value.ToString();
			cmbGroup.SelectedItem = grdMembers.CurrentRow.Cells["Group"].Value.ToString();
			if (grdMembers.CurrentRow.Cells["Counsellor"].Value.ToString() =="")
				cmbClor.SelectedIndex = -1;
			else
				cmbClor.Text = grdMembers.CurrentRow.Cells["Counsellor"].Value.ToString();
			dtpStartDate.Text = grdMembers.CurrentRow.Cells["StartDate"].Value.ToString();
			dtpEndDate.Text = grdMembers.CurrentRow.Cells["EndDate"].Value.ToString();
			
			txtID.ReadOnly = true;
			
			if(cmbStatus.Text == "Resigned")
				dtpEndDate.Enabled = true;
			else
				dtpEndDate.Enabled = false;			   
			
			flagStart  = true;
		}
		
		public void DisplayGridview()
		{
			myBindingSource = dcITRAMember.GetAll();
			grdMembers.DataSource = myBindingSource;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdMembers);
			grdMembers.Columns["ID_Member"].HeaderText = "Employee ID";
			grdMembers.Columns["FullName"].HeaderText = "Employee name";
			grdMembers.Columns["Member_Level"].HeaderText = "Level";
			grdMembers.Columns["Phone"].HeaderText = "Contact Number";
			grdMembers.Columns[4].Frozen = true;
			//grdMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		public void SelectRowByID(string id)
		{
			for(int i = 0; i < grdMembers.RowCount-1 ;i++)
			{
				if(grdMembers.Rows[i].Cells["ID_Member"].Value.ToString() == id)
				{
					grdMembers.CurrentCell = grdMembers.Rows[i].Cells[0];
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
				try
				{
					if (txtID.ReadOnly == false)
						dcITRAMember.SubmitOne(true, txtID.Text, txtName.Text, cmbLevel.Text, txtContactNo.Text, cmbGender.Text, 
					    	                   dtpStartDate.Text, dtpEndDate.Text, cmbStatus.Text, txtEmail.Text, cmbRole.Text, cmbWorkingLocation.Text, cmbGroup.Text, cmbClor.Text);
					else
						dcITRAMember.SubmitOne(false, txtID.Text, txtName.Text, cmbLevel.Text, txtContactNo.Text, cmbGender.Text, 
					    	                   dtpStartDate.Text, dtpEndDate.Text, cmbStatus.Text, txtEmail.Text, cmbRole.Text,cmbWorkingLocation.Text, cmbGroup.Text, cmbClor.Text);
					DisplayGridview();
					//SelectRowByID(txtID.Text);
					Reset();
					
					flagStart = false;
					
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
			if (grdMembers.SelectedRows.Count == 0)
				return;
			
	        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcITRAMember.DeleteOne(grdMembers.CurrentRow.Cells["ID_Member"].Value.ToString());
					DisplayGridview();
					Reset();
		        }			
		}
				

		//OTHERS		
		void Reset()
		{
			txtEmail.Text = "";
			txtContactNo.Text = "";
			txtID.Text = "";
			txtName.Text = "";
			dtpStartDate.Text = "1/1/2000";
			dtpEndDate.Text = "1/1/2000";
			
			txtID.ReadOnly = false;
			
			DisplayDefaultCmb();
			
			DeselectGrd();
		}
		
		void CmbStatusSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbStatus.Text == "Resigned")
				dtpEndDate.Enabled = true;
			else 
				dtpEndDate.Enabled = false;
		}
		
		void GrdMembersSorted(object sender, EventArgs e)
		{
			Reset();
			DeselectGrd();
		}
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			BindingSource tempITRAMember = (BindingSource)grdMembers.DataSource;
			
			try
			{
				tempITRAMember.Filter = "Fullname LIKE '%" + txtSearch.Text + "%'";
				grdMembers.DataSource = tempITRAMember;
			}
			catch (Exception ex)
			{
				
			}	
		}
	}
}
