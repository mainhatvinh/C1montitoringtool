/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/31/2013
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmInfrastructure.
	/// </summary>
	public partial class frmInfrastructure : MyFormPage
	{
		BindingSource myBindingSourceEng = new BindingSource();
		BindingSource myBindingSourceApp = new BindingSource();
		BindingSource myBindingSourceApp1 = new BindingSource();
		BindingSource myBindingSourceOS = new BindingSource();
		BindingSource myBindingSourceOS_DB = new BindingSource();
		BindingSource myBindingSourceDB = new BindingSource();
		BindingSource myBindingSourceGrd = new BindingSource();
		BindingSource myBindingSourceGrd1 = new BindingSource();
		BindingSource myBindingSourceGrd2 = new BindingSource();
		BindingSource myBindingSourceGrd3 = new BindingSource();
		
		bool flagStart = false;
		bool flagstart1 = false;
		public frmInfrastructure(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl =mainPanel;

			DisplayDefaultCmbEng();
			DisplayDefaultCmbInf();
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
			//AddHeaderGrd();
			
			DisplayGridView();
			ResetApp();
			DeSelectGrdView();
			flagstart1 = true;
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
			else
			{
				btnDel.Enabled = true;
				btnSubmit.Enabled = true;
				btnReset.Enabled = true;
			}
		}
		
		public void AddHeaderGrd()
		{
			while (grdInfrastructure.ColumnCount >0)
				grdInfrastructure.Columns.RemoveAt(0);
			grdInfrastructure.Columns.Add("Infrastructure_ID","Infrastructure_ID");
			grdInfrastructure.Columns.Add("ID_Engagement","ID_Engagement");
			grdInfrastructure.Columns.Add("APP_ID","APP_ID");
			grdInfrastructure.Columns.Add("APP_Name","Application Name");
			grdInfrastructure.Columns.Add("OS_APP_Name","OS Application Name");
			grdInfrastructure.Columns.Add("No_OS_APP_ID","No_OS_APP_ID");
			grdInfrastructure.Columns.Add("DB_Name","Database Name");
			grdInfrastructure.Columns.Add("No_DB_ID","No_DB_ID");
			grdInfrastructure.Columns.Add("OS_DB_ID","OS_DB_ID");
			grdInfrastructure.Columns.Add("OS_DB_Name","OS_DB_Name");
			grdInfrastructure.Columns.Add("No_OS_ID","No_OS_ID");
			grdInfrastructure.Columns.Add("Vendor","Vendor");
			grdInfrastructure.Columns.Add("Remark","Remark");
			
			
			
			
		}
		
		public void DisplayDefaultGrd()
		{
			myBindingSourceGrd1 = dcInfrastructure.GetOSDBData();
			grdOS.DataSource = myBindingSourceGrd1;
//			myBindingSourceGrd2 = dcInfrastructure.GetOSDBData();
//			grdOS_DB.DataSource = myBindingSourceGrd2;
			myBindingSourceGrd3 = dcInfrastructure.GetDBData();
			grdOS_DB.DataSource = myBindingSourceGrd3;
		}
		// ComboBox Infrastructure
		public void DisplayDefaultCmbInf()
		{
//			myBindingSourceApp = dcApp.GetAll();
//			cmbAppName.DataSource = myBindingSourceApp;
//			cmbAppName.DisplayMember = "APP_Name";
//			cmbAppName.ValueMember = "APP_ID";
			
			myBindingSourceOS = dcOS.GetAll();
			cmbOS.DataSource = myBindingSourceOS;
			cmbOS.DisplayMember = "OS_Name";
			cmbOS.ValueMember = "OS_ID";
			
			myBindingSourceOS_DB = dcOS.GetAll();
			cmbOS_DB.DataSource = myBindingSourceOS_DB;
			cmbOS_DB.DisplayMember = "OS_Name";
			cmbOS_DB.ValueMember = "OS_ID";
			
			myBindingSourceDB = dcDB.GetAll();
			cmbDB.DataSource = myBindingSourceDB;
			cmbDB.DisplayMember = "DB_Name";
			cmbDB.ValueMember = "DB_ID";
			
			cmbAppName.SelectedIndex =-1;
			
			cmbOS.SelectedIndex =-1;
			
			cmbOS_DB.SelectedIndex =-1;
			
			cmbDB.SelectedIndex =-1;
			
			txtVendor.Text = "";
			txtRemark.Text = "";
			txtNo_DB_ID.Text = "";
			txtNo_OS_APP_ID.Text = "";
			txtNo_OS_ID.Text = "";
		}
		
		public void DisplayApp()
		{
			myBindingSourceApp1 = dcApp.GetApp_ByClient(cmbEngID.Text);
			cmbAppName.DataSource = myBindingSourceApp1;
			cmbAppName.DisplayMember = "APP_NAME";
			cmbAppName.ValueMember = "APP_ID";
			cmbAppName.SelectedIndex = -1;
		}
		
		// ComboBox Engagement
		public void DisplayDefaultCmbEng()
		{		
			myBindingSourceEng = dcEngagement.GetAllC1();
			cmbEngID.DataSource = myBindingSourceEng;
			cmbEngID.DisplayMember = "ID_Engagement";
			cmbEngID.SelectedIndex =-1;
			
			cmbEngCode.DataSource = myBindingSourceEng;
			cmbEngCode.DisplayMember = "Engagement_Code";
			cmbEngCode.SelectedIndex =-1;
			
			cmbEngName.DataSource = myBindingSourceEng;
			cmbEngName.DisplayMember = "Engagement_Name";
			cmbEngName.SelectedIndex =-1;		
		}
		
		void CmbEngNameSelectedIndexChanged(object sender, EventArgs e)
		{
			cmbEngCode.SelectedItem = cmbEngName.SelectedItem;
			cmbEngID.SelectedItem = cmbEngName.SelectedItem;
			txtEngCode.Text = cmbEngCode.Text;
//			if (cmbEngName.SelectedIndex >=0)
//			 toolTip1.SetToolTip(cmbEngName,cmbEngName.SelectedItem.ToString());
			DisplayGridView();
			ResetApp();
			DeSelectGrdView();
			if (flagstart1 == true)
				DisplayApp();	
		}
		
		void CmbEngCodeSelectedIndexChanged(object sender, EventArgs e)
		{
			cmbEngID.SelectedItem = cmbEngCode.SelectedItem;
			cmbEngName.SelectedItem = cmbEngCode.SelectedItem;
			DisplayGridView();
			ResetApp();
			DeSelectGrdView();
			if (flagstart1 == true)
			DisplayApp();
		}
		
		
		Object SearchOS(string OS_ID)
		{
			for (int i =0; i <= grdOS.Rows.Count-1; i++)
				if (OS_ID == grdOS.Rows[i].Cells[0].Value.ToString())
					return (Object) grdOS.Rows[i].Cells[1].Value.ToString();
			return 0;
		}
		
		Object SearchDB(string DB_ID)
		{
			for (int i =0; i <= grdOS_DB.Rows.Count-1; i++)
				if (DB_ID == grdOS_DB.Rows[i].Cells[0].Value.ToString())
					return (Object) grdOS_DB.Rows[i].Cells[1].Value.ToString();
			return 0;
		}
		// DisplayGridView
		void DisplayGridView()
		{
			//MessageBox.Show(cmbEngID.Text);
			
			myBindingSourceGrd = dcInfrastructure.GetDataByKey(cmbEngID.Text);
			grdTemp.DataSource = myBindingSourceGrd;
			//grdTemp.Columns[0].Visible = false;
			//grdTemp.Columns[1].Visible = false;
			//grdTemp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			AddHeaderGrd();
			DisplayDefaultGrd();
			
			
			while (grdInfrastructure.Rows.Count >=1)
			{
				grdInfrastructure.Rows.RemoveAt(0);
				//grdTemp.Rows.RemoveAt(0);
				
			}
			for (int i =0; i <= grdTemp.Rows.Count-1; i++)
			{
//			grdInfrastructure.Columns.Add("Infrastructure_ID","Infrastructure_ID");
//			grdInfrastructure.Columns.Add("ID_Engagement","ID_Engagement");
//			grdInfrastructure.Columns.Add("APP_ID","APP_ID");
//			grdInfrastructure.Columns.Add("APP_Name","Application Name");
//			grdInfrastructure.Columns.Add("OS_APP_Name","OS Application Name");
//			grdInfrastructure.Columns.Add("No_OS_APP_ID","No_OS_APP_ID");
//			grdInfrastructure.Columns.Add("DB_Name","Database Name");
//			grdInfrastructure.Columns.Add("No_DB_ID","No_DB_ID");
//			grdInfrastructure.Columns.Add("OS_DB_ID","OS_DB_ID");
//			grdInfrastructure.Columns.Add("OS_DB_Name","OS_DB_Name");
//			grdInfrastructure.Columns.Add("No_OS_ID","No_OS_ID");
//			grdInfrastructure.Columns.Add("Vendor","Vendor");
//			grdInfrastructure.Columns.Add("Remark","Remark");

				Object[] tempo = new Object[13];
				tempo[0] = grdTemp.Rows[i].Cells["Infrastructure_ID"].Value;
				tempo[1] = grdTemp.Rows[i].Cells["ID_Engagement"].Value;
				tempo[2] = grdTemp.Rows[i].Cells["APP_ID"].Value;
				tempo[3] = grdTemp.Rows[i].Cells["APP_Name"].Value;
				tempo[5] = grdTemp.Rows[i].Cells["No_OS_APP_ID"].Value;
				
				tempo[7] = grdTemp.Rows[i].Cells["No_DB_ID"].Value;
				tempo[8] = grdTemp.Rows[i].Cells["OS_DB_ID"].Value;
				tempo[10] = grdTemp.Rows[i].Cells["No_OS_ID"].Value;
				tempo[11] = grdTemp.Rows[i].Cells["Vendor"].Value;
				tempo[12] = grdTemp.Rows[i].Cells["Remark"].Value;
				
				if (grdTemp.Rows[i].Cells[4].Value.ToString() == "")
					tempo[4] = (Object) "";
				else
					tempo[4] =SearchOS(grdTemp.Rows[i].Cells[4].Value.ToString());
				
				if (grdTemp.Rows[i].Cells[5].Value.ToString() == "")
					tempo[6] = (Object) "";
				else
					tempo[6] =SearchDB(grdTemp.Rows[i].Cells[5].Value.ToString());
				if (grdTemp.Rows[i].Cells[9].Value.ToString() == "")
					tempo[9] = (Object) "";
				else
					tempo[9] =SearchOS(grdTemp.Rows[i].Cells["OS_DB_ID"].Value.ToString());
				grdInfrastructure.Rows.Add(tempo);
			}
			//grdInfrastructure.Columns[0].Visible = false;
			//grdInfrastructure.Columns[1].Visible = false;
			grdInfrastructure.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			
			grdInfrastructure.Columns["Infrastructure_ID"].Visible =false;
			grdInfrastructure.Columns["ID_Engagement"].Visible =false;
			grdInfrastructure.Columns["APP_ID"].Visible =false;
			grdInfrastructure.Columns["OS_DB_ID"].Visible =false;
			
			
			
		}
		void ResetEng()
		{
			cmbEngID.SelectedIndex = -1;
			cmbEngID.Text = cmbEngID.SelectedText;
			
			cmbEngName.SelectedIndex = -1;
			cmbEngName.Text = cmbEngName.SelectedText;
			
			cmbEngCode.SelectedIndex = -1;
			cmbEngCode.Text = cmbEngCode.SelectedText;
		}
		void ResetApp()
		{
			cmbAppName.SelectedIndex =-1;			
			cmbOS.SelectedIndex =-1;			
			cmbDB.SelectedIndex =-1;
			cmbOS_DB.SelectedIndex = -1;
			txtVendor.Text = "";
			txtRemark.Text = "";
			txtNo_DB_ID.Text = "";
			txtNo_OS_APP_ID.Text = "";
			txtNo_OS_ID.Text = "";
			flagStart = false;
			//grdInfrastructure.CurrentCell = grdInfrastructure.Rows[grdInfrastructure.RowCount-1].Cells[2];			
		}
		
		// Reset Click
		void BtnResetClick(object sender, EventArgs e)
		{
			DeSelectGrdView();
			ResetApp();
			ResetEng();
		}
		
		// Submit Click
		
		void DeSelectGrdView()
		{
			for (int i = 1; i <= grdInfrastructure.SelectedRows.Count; i++)
				grdInfrastructure.SelectedRows[i-1].Selected = false;
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (cmbEngName.Text == "" && cmbEngCode.Text =="")
				return;
			if (cmbAppName.Text =="")
			{
				MessageBox.Show("Please input the application name");
				return;
			}
			if (grdInfrastructure.SelectedRows.Count == 0)
			{
				
						string osid = cmbOS.Text == ""? "":cmbOS.GetItemText(cmbOS.SelectedValue);
						string dbid = cmbDB.Text == ""? "":cmbDB.GetItemText(cmbDB.SelectedValue);
						string os_dbid = cmbOS_DB.Text == ""? "":cmbOS_DB.GetItemText(cmbOS_DB.SelectedValue);
						//MessageBox.Show(cmbDB.GetItemText(cmbDB.SelectedValue));
						dcInfrastructure.SubmitOne(true,"", cmbEngID.Text, cmbAppName.GetItemText(cmbAppName.SelectedValue), 
				                           osid,dbid, txtVendor.Text, txtRemark.Text,"", os_dbid, txtNo_DB_ID.Text, txtNo_OS_APP_ID.Text, txtNo_OS_ID.Text);
						DisplayGridView();
						DeSelectGrdView();
						
						ResetApp();
						MessageBox.Show("Submitted successfully.");
						return;
					
			}
			
			else 				
			{
				string osid1 = cmbOS.Text == ""? "":cmbOS.GetItemText(cmbOS.SelectedValue);
				string dbid1 = cmbDB.Text == ""? "":cmbDB.GetItemText(cmbDB.SelectedValue);
				string os_dbid1 = cmbOS_DB.Text == ""? "":cmbOS_DB.GetItemText(cmbOS_DB.SelectedValue);
				//MessageBox.Show(cmbAppName.GetItemText(cmbAppName.SelectedValue));
				
				dcInfrastructure.SubmitOne(false, grdInfrastructure.CurrentRow.Cells[0].Value.ToString(), cmbEngID.Text, grdInfrastructure.CurrentRow.Cells[1].Value.ToString(),
						                           osid1,dbid1, txtVendor.Text, txtRemark.Text,cmbAppName.GetItemText(cmbAppName.SelectedValue), os_dbid1, txtNo_DB_ID.Text, txtNo_OS_APP_ID.Text, txtNo_OS_ID.Text);
						ResetApp();
						DisplayGridView();
						DeSelectGrdView();
														
						
						MessageBox.Show("Submitted successfully.");
					
			}
		}
		
		
		void ClickOneRow()
		{
			cmbAppName.Text = grdInfrastructure.CurrentRow.Cells["APP_Name"].Value.ToString();
			cmbOS.Text = grdInfrastructure.CurrentRow.Cells["OS_APP_Name"].Value.ToString();
			cmbDB.Text = grdInfrastructure.CurrentRow.Cells["DB_Name"].Value.ToString();
			cmbOS_DB.Text = grdInfrastructure.CurrentRow.Cells["OS_DB_Name"].Value.ToString();						
			txtVendor.Text = grdInfrastructure.CurrentRow.Cells["Vendor"].Value.ToString();
			txtRemark.Text = grdInfrastructure.CurrentRow.Cells["Remark"].Value.ToString();
			txtNo_DB_ID.Text = grdInfrastructure.CurrentRow.Cells["No_DB_ID"].Value.ToString();
			txtNo_OS_APP_ID.Text = grdInfrastructure.CurrentRow.Cells["No_OS_APP_ID"].Value.ToString();
			txtNo_OS_ID.Text = grdInfrastructure.CurrentRow.Cells["No_OS_ID"].Value.ToString();
			flagStart = true;
		}
		void GrdInfrastructureCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
				ClickOneRow();
			
		}
		
		void BtnDelClick(object sender, EventArgs e)
		{
			if (cmbEngID.Text == "")
			{
				
				return;
			}
			if (grdInfrastructure.SelectedRows.Count ==0)
				return;
			if (MessageBox.Show("Would you like to Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
	        {
	            dcInfrastructure.DeleteOne(grdInfrastructure.CurrentRow.Cells["Infrastructure_ID"].Value.ToString());
				
				DisplayGridView();
				ResetApp();
				DeSelectGrdView();	
	        }
		}
		
		void GrdInfrastructureSelectionChanged(object sender, EventArgs e)
		{
			if (flagStart == true && grdInfrastructure.RowCount>0)
				ClickOneRow();
		}
		
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			flagstart1 = false;
			BindingSource temp = (BindingSource) cmbEngID.DataSource;
			temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "'";
			cmbEngID.DataSource = temp;
			
			BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
			temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "'";
			cmbEngName.DataSource = temp1;
			
			BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
			temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "'";
			cmbEngCode.DataSource = temp2;
			
			cmbEngID.SelectedIndex =-1;
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.SelectedIndex =-1;
			
			flagstart1 = true;
		}
		
	
		
		void FrmInfrastructureLoad(object sender, EventArgs e)
		{
		    
		}
		
		
		
		void CmbEngNameDrawItem(object sender, DrawItemEventArgs e)
		{
			    
		}
		
		
		
		void CmbEngNameMouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(cmbEngName,cmbEngName.GetItemText(cmbEngName.SelectedItem));
			//MessageBox.Show(cmbEngName.SelectedText);
		}
		
		void Label8Click(object sender, EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void TxtRemarkTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		
		void Label10Click(object sender, EventArgs e)
		{
			
		}
	}
}
