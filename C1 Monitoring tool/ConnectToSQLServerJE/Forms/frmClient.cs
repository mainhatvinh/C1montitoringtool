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
	public partial class frmClient : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSourcegrdclientcontact = new BindingSource();
		BindingSource myBindingSourcePosition = new BindingSource();
		BindingSource myBindingSourceClientApplication = new BindingSource();
		DataTable dtClient_Industry = new DataTable();
		//DataTable dtIndudtry = new DataTable();
		bool flagStart = false;
		int _Role_Type;
		
		private ListBox FromChild;
		public ListBox ListFromChild
		{
			get { return FromChild; }
            set { FromChild = value; }
		}
		
		public frmClient(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			_Role_Type = Role_type;
			
			InitializeComponent();
			this.pnl = mainPanel;
			DisplayGridview();
			DisplayDefaultCmbInf();
			DisplayDefaultChl();
			Reset();
			ReadOnly();
			//grdMembers.Columns["Acct"].HeaderText = "Mã tài khoản";
			//grdMembers.Columns["DescrVN"].HeaderText = "Mô tả";
			
			//Validation
			this.txtClientCode.KeyPress += Validation.txtIntegerOnly;
			this.txtEmail1.KeyPress += Validation.txtNoSpace;
			this.txtEmail2.KeyPress += Validation.txtNoSpace;
			this.txtEmail3.KeyPress += Validation.txtNoSpace;
			
			//User authorization
			if (Role_type == 2)
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = false;
				btnReset.Enabled = false;
			}
			else if (Role_type == 4) {
				btnDel.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
			else
			{
				btnDel.Enabled = false;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
	
		}
		
		public void DisplayDefaultCmbInf()
		{
			myBindingSourcePosition = dcPosition.GetAll();
			cmbPosition.DataSource = myBindingSourcePosition;
			cmbPosition.DisplayMember = "PositionName";
			cmbPosition.ValueMember = "ID_Position";
			
			cmbPosition.SelectedIndex = -1;
			
		}
		
		//VALIDATION
		bool isValidated()
		{
			if (txtClientCode.Text == "" || txtClientName.Text == "" || cmbCountry.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
			
			if (Validation.isInteger(txtClientCode.Text) == false)
			{
				
				MessageBox.Show("Client code is not correct.");
				return false;
			}
			else
			{
				if (txtClientCode.Text.Length !=4 && txtClientCode.Text.Length !=8)
				{
					MessageBox.Show("Client code is not correct.");
					return false;
				}
				if (txtClientCode.Text.Length == 8 && chbDummyCode.Checked)
				{
					MessageBox.Show("Client code is not correct.");
					return false;
				}
				if (txtClientCode.Text.Length == 4 && chbDummyCode.Checked == false)
				{
					MessageBox.Show("Client code is not correct.");
					return false;
				}
			}
			
			if (Validation.isNoSpace(txtContact_Email.Text) == false)
			{
				MessageBox.Show("Email of the contact is not correct.");
				return false;
			}
			
			//Check duplicate Client code
			if ((grdClient.SelectedRows.Count == 0) 
			    || ((grdClient.SelectedRows.Count != 0)&&(grdClient.CurrentRow.Cells["Client_Code"].Value.ToString() != txtClientCode.Text)))
			 {
				myBindingSource = dcClient_New.GetAll();
				grdTemp.DataSource = myBindingSource;
							
				for (int i = 0; i < grdTemp.Rows.Count; i++)
				{
					if (grdTemp.Rows[i].Cells["Client_Code"].Value != null)
				    {
						if (txtClientCode.Text == grdTemp.Rows[i].Cells["Client_Code"].Value.ToString())
						{
							MessageBox.Show("This client code existed already");
							return false;
						}
				    }
				}
			}
			
			return true;
		}
		
		
		//COMBOBOX + CHECKLISTBOX
		public void DisplayDefaultChl()
		{
			//chlIndustry
//			myBindingSource = dcIndustry.GetAll();
//			chlIndustry.DataSource = myBindingSource;
//			chlIndustry.DisplayMember = "Industry";
//			chlIndustry.ValueMember = "Industry_ID";
//		
//			for(int i = 0; i< chlIndustry.Items.Count; i++)
//			{
//				chlIndustry.SetItemCheckState(i, CheckState.Unchecked);
//			}
			
			//Code moi
			myBindingSource = dcIndustry.GetAll();
			grdIndustry.DataSource = myBindingSource;
			
			//cmbCountry.Text = "Vietnam";
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
		bool IsExistedItem1(ListBox tempListBox, string item)
		{
			
				for (int i = 0; i < tempListBox.Items.Count; i++)
				{
					if(tempListBox.Items[i].ToString() == item)
					   return true;
				}
			
			
			return false;
		}
		
		//GRIDVIEW
		void GrdClientSelectionChanged(object sender, EventArgs e)
		{
			if (flagStart == true  && grdClient.SelectedRows.Count > 0)
				
				ClickOneRow();
		}
		
		void GrdClientCellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
			{
				RemoveReadOnly();
				ClickOneRow();
			}
		}
		
		void GrdClientDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeselectGrd();
		}
		
		void DeselectGrd()
		{		
			for(int i =0; i < grdClient.SelectedRows.Count;i++)
			{
				grdClient.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void DeselectGrd1()
		{		
			for(int i =0; i < grdClientContact.SelectedRows.Count;i++)
			{
				grdClientContact.SelectedRows[i].Selected = false;
			}
			
			flagStart = false;
		}
		
		void ClickOneRow()
		{
			Reset1();
			txtClientCode.Text = grdClient.CurrentRow.Cells["Client_Code"].Value.ToString();
			txtClientAddress.Text = grdClient.CurrentRow.Cells["Address"].Value.ToString();
			txtClientName.Text = grdClient.CurrentRow.Cells["Client_name"].Value.ToString();
			cmbCountry.Text = grdClient.CurrentRow.Cells["Country"].Value.ToString();
			txtRemarks.Text = grdClient.CurrentRow.Cells["Remarks"].Value.ToString();
//			if (grdClient.CurrentRow.Cells["DummyCode"].Value = true)
				chbDummyCode.Checked = (bool)grdClient.CurrentRow.Cells["DummyCode"].Value;
//			else
//				chbDummyCode.Checked = false;
//			if (grdClient.CurrentRow.Cells["ITRA_Client"].Value = true)
				//MessageBox.Show(grdClient.CurrentRow.Cells["ITRA_Client"].Value.ToString());
				chbITRA_Client.Checked = bool.Parse(grdClient.CurrentRow.Cells["ITRA_Client"].Value.ToString());
				//chbITRA_Client.Checked = (bool)grdClient.CurrentRow.Cells["ITRA_Client"].Value;
//			else
//				chbITRA_Client.Checked = false;
			if (_Role_Type == 4)
				txtClientCode.ReadOnly = false;
			else
				txtClientCode.ReadOnly = true;
			
			//handle chlIndustry
//			DisplayDefaultChl();
			
			dtClient_Industry = (DataTable)dcClient_Industry.GetByClientCode(txtClientCode.Text).DataSource;
			
//			for(int i = 0 ; i < chlIndustry.Items.Count; i++)
//			{
//				if (IsExistedItem(dtClient_Industry, "IndustryBusiness", chlIndustry.GetItemText(chlIndustry.Items[i]).ToString()) == true)
//					chlIndustry.SetItemCheckState(i, CheckState.Checked);
//			}
			if (dtClient_Industry != null)
			{
				ltbBusiness.Items.Clear();
				for (int i=0; i< dtClient_Industry.Rows.Count;i++)
				{
					ltbBusiness.Items.Add((object) dtClient_Industry.Rows[i]["IndustryBusiness"].ToString());
				}
			}
			flagStart  = true;
			DisplayGridview1();
			
			myBindingSourceClientApplication = dcClient_New.GetApplication_ByKey("", txtClientCode.Text);
			lbClientApplication.DataSource = myBindingSourceClientApplication;
			lbClientApplication.DisplayMember = "APP_Name";
			lbClientApplication.ValueMember = "ID_Client_App";
			//grdClientApplication.Columns["ID_Client_App"].Visible = false;
			
		}
		
		void ClickOneRow1()
		{
			txtContact_Email.Text = grdClientContact.CurrentRow.Cells["Contact_Email"].Value.ToString();
			txtContact_Name.Text = grdClientContact.CurrentRow.Cells["Contact_Name"].Value.ToString();
			txtContact_Phone.Text = grdClientContact.CurrentRow.Cells["Contact_Phone"].Value.ToString();
			cmbPosition.Text = grdClientContact.CurrentRow.Cells["Contact_Position"].Value.ToString();
			txtID_ClientContact.Text = grdClientContact.CurrentRow.Cells["ID_ClientContact"].Value.ToString();
			flagStart  = true;
			//DisplayGridview1();
		}
		
		public void DisplayGridview()
		{
			myBindingSource = dcClient_New.GetAll();
			grdClient.DataSource = myBindingSource;
			grdClient.Columns[1].Frozen = true;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdClient);
			grdClient.Columns["Creator"].Visible = false;
			grdClient.Columns["CreateDate"].Visible = false;
			//grdClient.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}

		public void DisplayGridview1()
		{
			myBindingSourcegrdclientcontact = dcClient_New.GetData_ByKey_ClientContact("", txtClientCode.Text);
			grdClientContact.DataSource = myBindingSourcegrdclientcontact;
			grdClientContact.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdClientContact.Columns["Client_Code"].Visible = false;
			grdClientContact.Columns["ID_ClientContact"].Visible = false;
			//grdClient.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		public void SelectRowByID(string id) 
		{
			for(int i = 0; i < grdClient.RowCount-1 ;i++)
			{
				if(grdClient.Rows[i].Cells["Client_Code"].Value.ToString() == id)
				{
					grdClient.CurrentCell = grdClient.Rows[i].Cells[0];
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
					if (grdClient.SelectedRows.Count == 0)
						dcClient.SubmitOne(true, txtClientCode.Text, txtClientName.Text, txtClientAddress.Text, cmbCountry.Text, 
						                   txtRemarks.Text, getChbValue(chbDummyCode.CheckState), "", "", getChbValue(chbITRA_Client.CheckState));
					else
					{
					//	MessageBox.Show(chbDummyCode.Checked.ToString());
						
						dcClient.SubmitOne(false, grdClient.CurrentRow.Cells["Client_Code"].Value.ToString(), txtClientName.Text, txtClientAddress.Text, cmbCountry.Text, 
						                   txtRemarks.Text, getChbValue(chbDummyCode.CheckState), "", "", getChbValue(chbITRA_Client.CheckState));
						if (grdClient.CurrentRow.Cells["Client_Code"].Value.ToString() != txtClientCode.Text)
						{
					//		MessageBox.Show(grdClient.CurrentCell.Value.ToString() + " - " +  txtClientCode.Text);
							dcClient.UpdateClient(grdClient.CurrentCell.Value.ToString(), txtClientCode.Text);
						}
					}
					
					//handle chlIndustry
//					for(int i = 0 ; i < chlIndustry.Items.Count; i++)
//					{
//						if (chlIndustry.GetItemCheckState(i) == CheckState.Checked)
//						{
//							if (IsExistedItem(dtClient_Industry, "IndustryBusiness", chlIndustry.GetItemText(chlIndustry.Items[i]).ToString()) == false)
//							{
//								chlIndustry.SetSelected(i, true);
//								dcClient_Industry.SubmitOne(true, txtClientCode.Text, chlIndustry.SelectedValue.ToString());
//							}
//						}
//						else
//						{
//							if (IsExistedItem(dtClient_Industry, "IndustryBusiness", chlIndustry.GetItemText(chlIndustry.Items[i]).ToString()) == true)
//						    {
//						    	chlIndustry.SetSelected(i, true);
//						    	dcClient_Industry.DeleteOne(txtClientCode.Text, chlIndustry.SelectedValue.ToString());
//						    }
//						}
//					}
					
					for(int i = 0 ; i < ltbBusiness.Items.Count; i++)
					{						
						if (IsExistedItem(dtClient_Industry, "IndustryBusiness", ltbBusiness.Items[i].ToString()) == false)
							{
								//chlIndustry.SetSelected(i, true);
								dcClient_Industry.SubmitOne(true, txtClientCode.Text, GetIndustry(ltbBusiness.Items[i].ToString()));
							}					
							
					}
					for (int i = 0; i < dtClient_Industry.Rows.Count; i++)
					{
						if (IsExistedItem1(ltbBusiness, dtClient_Industry.Rows[i]["IndustryBusiness"].ToString()) == false)
							{
								//chlIndustry.SetSelected(i, true);
								dcClient_Industry.DeleteOne(txtClientCode.Text, dtClient_Industry.Rows[i]["Industry_ID"].ToString());
							}					
					}
					
					DisplayGridview();
					//SelectRowByID(txtClientCode.Text);
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
		
		string GetItem(DataTable dt, string fieldname, string item)
		{
			if (dt != null)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if(dt.Rows[i][fieldname].ToString() == item)
					{
						//MessageBox.Show(dt.Rows[i]["Industry_ID"].ToString());
						return dt.Rows[i]["Industry_ID"].ToString();
					}
				}
				//return "-1";
			}
			return "-1";
			
		}
						
		string GetIndustry(string business)
		{
			for (int i =0; i< grdIndustry.RowCount; i++)
				if (grdIndustry.Rows[i].Cells["Industry"].Value.ToString() == business)
					return (grdIndustry.Rows[i].Cells["Industry_ID"].Value.ToString());
			return "";
		}
		
		void BtnDelClick(object sender, EventArgs e)
		{
			if (grdClient.SelectedRows.Count == 0)
				return;
	        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
	        {
	            dcClient.DeleteOne(grdClient.CurrentRow.Cells["Client_Code"].Value.ToString());
	            
	            //handle chlIndustry
	            dcClient_Industry.DeleteByClientCode(grdClient.CurrentRow.Cells["Client_Code"].Value.ToString());
	            
				DisplayGridview();
				Reset();
	        }			
		}
			
		
		//OTHERS		
		void Reset()
		{
			txtClientCode.Text = "";
			txtClientAddress.Text = "";
			txtClientName.Text = "";
			cmbCountry.Text = "";
			txtName1.Text = "";
			txtName2.Text = "";
			txtName3.Text = "";
			txtPosition1.Text = "";
			txtPosition2.Text = "";
			txtPosition3.Text = "";
			txtEmail1.Text = "";
			txtEmail2.Text = "";
			txtEmail3.Text = "";
			txtPhone1.Text = "";
			txtPhone2.Text = "";
			txtPhone3.Text = "";
			txtRemarks.Text = "";
			txtClientAddress.Text = "";
			cmbPosition.Text = "";
			txtContact_Email.Text = "";
			txtContact_Name.Text = "";
			txtContact_Phone.Text = "";
			
			txtClientCode.ReadOnly = false;
			
			txtSearch.Text = "";
			
			
			
			DisplayDefaultChl();
			ltbBusiness.Items.Clear();
			//lbClientApplication.Items.Clear();
			lbClientApplication.DataSource = null;
			DeselectGrd();
		}
		
		void Reset1()
		{
			txtContact_Email.Text = "";
			txtContact_Name.Text = "";
			txtContact_Phone.Text = "";
			cmbPosition.SelectedIndex = -1;
			//DisplayDefaultChl();
			
			DeselectGrd1();
		}
		
		void ReadOnly()
		{
			txtContact_Email.ReadOnly = true;
			txtContact_Name.ReadOnly = true;
			txtContact_Phone.ReadOnly = true;
			cmbPosition.SelectedIndex = -1;
			cmbPosition.Visible = false;
			//DisplayDefaultChl();
			
			DeselectGrd1();
		}
		
		void RemoveReadOnly()
		{
			txtContact_Email.ReadOnly = false;
			txtContact_Name.ReadOnly = false;
			txtContact_Phone.ReadOnly = false;
			cmbPosition.Visible = true;
			//DisplayDefaultChl();
			
			DeselectGrd1();
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
			BindingSource tempClient = (BindingSource)grdClient.DataSource;
			tempClient.Filter = "Client_name LIKE '%" + txtSearch.Text + "%'";
			grdClient.DataSource = tempClient;
		}
		
		void GrdClientSorted(object sender, EventArgs e)
		{
			Reset();
			DeselectGrd();
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void GrdClientCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void GbxClientEnter(object sender, EventArgs e)
		{
			
		}
		
		void ChlIndustrySelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void MainPanelPaint(object sender, PaintEventArgs e)
		{
			
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
		dcClient_New.SubmitOne1(true, "", txtClientCode.Text, cmbPosition.Text, txtContact_Name.Text, txtContact_Email.Text, txtContact_Phone.Text);	
		DisplayGridview1();
		Reset1();
		}
		
		void GrdClientContactSelectionChanged(object sender, EventArgs e)
		{
			//if (flagStart == true  && grdClientContact.SelectedRows.Count > 0)
			//ClickOneRow1();
		}
		
		void GrdClientContactCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
			{
				RemoveReadOnly();
				ClickOneRow1();
			}
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			
			flagStart = false;
			Reset1();
		}
		
		void BtnDelConClick(object sender, EventArgs e)
		{
//			if (grdClientContact.SelectedRows.Count == 0)
//				return;
	        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
	        {
	            dcClient_New.DeleteClientContactOne(grdClientContact.CurrentRow.Cells["ID_ClientContact"].Value.ToString());
				DisplayGridview1();
				Reset1();
	        }
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			frmIndustrySelection child = new frmIndustrySelection(this,ltbBusiness);

            child.ListFormParent = ltbBusiness;
            //child.MdiParent = this;
            child.Show();
		}
		
		public void UpdateMessage(ListBox source)
        {
			ltbBusiness.Items.Clear();
            ListBox.ObjectCollection sourceItems = source.Items;
			foreach (var item in sourceItems)
			{
				ltbBusiness.Items.Add(item);
			}
        }
	}
}
