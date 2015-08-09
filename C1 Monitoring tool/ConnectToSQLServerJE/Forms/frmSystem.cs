/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace C1Monitoring
{
	/// <summary>
	/// Description of Application.
	/// </summary>
	public partial class frmSystem : MyFormPage
	{
		BindingSource myBindingSource1 = new BindingSource();
		BindingSource myBindingSource2 = new BindingSource();
		BindingSource myBindingSource3 = new BindingSource();
		bool flagStartApp = false;
		bool flagStartOS = false;
		bool flagStartDB = false;
		
		public frmSystem(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			cmbAppType.SelectedIndex = -1;
			DisplayGridviewApp();
			DisplayGridviewOS();
			DisplayGridviewDB();
			txtApp_Std_Hours.Text = "0";
			txtDB_Std_Hours.Text = "0";
			txtOS_Std_Hours.Text = "0";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				btnDel1.Enabled = false;
				btnDel2.Enabled = false;
				btnDel3.Enabled = false;
				btnSubmit1.Enabled = false;
				btnSubmit2.Enabled = false;
				btnSubmit3.Enabled = false;
				btnReset1.Enabled = false;
				btnReset2.Enabled = false;
				btnReset3.Enabled = false;
			}
			else if (Role_type == 1)
			{
				btnDel1.Enabled = false;
				btnDel2.Enabled = false;
				btnDel3.Enabled = false;
				btnSubmit1.Enabled = true;
				btnSubmit2.Enabled = true;
				btnSubmit3.Enabled = true;
				btnReset1.Enabled = true;
				btnReset2.Enabled = true;
				btnReset3.Enabled = true;
			}
			else if (Role_type == 4)
			{
				btnDel1.Enabled = true;
				btnDel2.Enabled = true;
				btnDel3.Enabled = true;
				btnSubmit1.Enabled = true;
				btnSubmit2.Enabled = true;
				btnSubmit3.Enabled = true;
				btnReset1.Enabled = true;
				btnReset2.Enabled = true;
				btnReset3.Enabled = true;
			}				
		}
		
		// Application
		public void DisplayGridviewApp()
		{
			myBindingSource1 = dcApp.GetAll();
			grdApp.DataSource = myBindingSource1;
			grdApp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdApp.Columns[0].Visible = false;
			grdApp.Columns["App_Std_Hours"].Visible = false;
			grdApp.Columns["Creator"].Visible = false;
			grdApp.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdApp);
		}
		void ResetApp()
		{
			txtAppID.Text = "";
			txtAppName.Text = "";
			cmbAppType.SelectedIndex = -1;
			txtApp_Std_Hours.Text = "";
			flagStartApp = false;
			if (grdApp.Rows.Count >0)
				grdApp.CurrentCell = grdApp.Rows[0].Cells[1];
			
		}
		
		
		void BtnReset1Click(object sender, EventArgs e)
		{
			ResetApp();
			grdApp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdApp.CurrentRow.Selected = false;
		}
		
		bool IsValidateApp()
		{
			for (int i =0; i<= grdApp.RowCount -1; i++)
				if (txtAppName.Text.ToLower() == grdApp.Rows[i].Cells["APP_Name"].Value.ToString().ToLower())
					return false;
			return true;
		}
		
		void BtnSubmit1Click(object sender, EventArgs e)
		{
			if (txtAppName.Text == "" || cmbAppType.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return;
			}
			
			if (txtAppID.Text == "")
			{
				if (IsValidateApp() == true)
				{
					dcApp.SubmitOne(true, txtAppID.Text, txtAppName.Text,cmbAppType.Text, txtApp_Std_Hours.Text);
					DisplayGridviewApp();
					ResetApp();
				}
				else 
					MessageBox.Show("This application name existed already");
			}
			else if ((txtAppName.Text != grdApp.CurrentRow.Cells["APP_Name"].Value.ToString()) ||
			         (cmbAppType.Text != grdApp.CurrentRow.Cells["APP_Type"].Value.ToString())||
			         (txtApp_Std_Hours.Text != grdApp.CurrentRow.Cells["App_Std_Hours"].Value.ToString()))
			{	

				if (txtAppName.Text != grdApp.CurrentRow.Cells["APP_Name"].Value.ToString())
				{
					if (IsValidateApp() == true)
					{
						dcApp.SubmitOne(false, txtAppID.Text, txtAppName.Text,cmbAppType.Text, txtApp_Std_Hours.Text);
						DisplayGridviewApp();
						ResetApp();
					}
					else 
						MessageBox.Show("This application name existed already");
				}
				else{
					dcApp.SubmitOne(false, txtAppID.Text, txtAppName.Text,cmbAppType.Text, txtApp_Std_Hours.Text);
					DisplayGridviewApp();
					ResetApp();
				}
			}			
		}
		
		void BtnDel1Click(object sender, EventArgs e)
		{
			if (txtAppID.Text == "")
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
				//MessageBox.Show(grdApp.CurrentRow.Cells["APP_ID"].Value.ToString());
					dcInfrastructure.DeleteByApp(grdApp.CurrentRow.Cells["APP_ID"].Value.ToString());
					dcApp.DeleteOne(grdApp.CurrentRow.Cells["APP_ID"].Value.ToString());
					DisplayGridviewApp();
					ResetApp();
		        }	
		}
		
		void ClickOneRowApp()
		{
			txtAppID.Text = grdApp.CurrentRow.Cells["APP_ID"].Value.ToString();
			txtAppName.Text = grdApp.CurrentRow.Cells["APP_Name"].Value.ToString();
			cmbAppType.Text = grdApp.CurrentRow.Cells["APP_Type"].Value.ToString();
			txtApp_Std_Hours.Text = grdApp.CurrentRow.Cells["App_Std_Hours"].Value.ToString();
			flagStartApp = true;
			
		}
		
		void GrdAppCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0 )
				ClickOneRowApp();
		}
		
		//OS
		
		public void DisplayGridviewOS()
		{
			myBindingSource2 = dcOS.GetAll();
			grdOS.DataSource = myBindingSource2;
			grdOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdOS.Columns[0].Visible = false;
			grdOS.Columns["OS_Std_Hours"].Visible = false;
			grdOS.Columns["Creator"].Visible = false;
			grdOS.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdOS);
			
		}
		void ResetOS()
		{
			txtOSID.Text = "";
			txtOSName.Text = "";
			flagStartOS = false;
			txtOS_Std_Hours.Text = "";			
			if (grdOS.Rows.Count >0)
				grdOS.CurrentCell = grdOS.Rows[0].Cells[1];
		}
		void ClickOneRowOS()
		{
			txtOSID.Text = grdOS.CurrentRow.Cells["OS_ID"].Value.ToString();			
			txtOSName.Text = grdOS.CurrentRow.Cells["OS_Name"].Value.ToString();
			txtOS_Std_Hours.Text = grdOS.CurrentRow.Cells["OS_Std_Hours"].Value.ToString();
			flagStartOS	 = true;		 
		}
		
		
		void BtnReset2Click(object sender, EventArgs e)
		{
			ResetOS();
			grdOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdOS.CurrentRow.Selected = false;
		}
		
		bool IsValidateOS()
		{
			for (int i =0; i<= grdOS.RowCount -1; i++)
				if (txtOSName.Text.ToLower() == grdOS.Rows[i].Cells["OS_Name"].Value.ToString().ToLower())
					return false;
			return true;
		}
		
		void BtnSubmit2Click(object sender, EventArgs e)
		{
			
			
			if (txtOSName.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return;
			}
		
			if (txtOSID.Text == "")
			{
				if (IsValidateOS() == true)
				{
				    dcOS.SubmitOne(true, txtOSID.Text, txtOSName.Text, txtOS_Std_Hours.Text);
				    DisplayGridviewOS();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
				}
				else 
					MessageBox.Show("This Operating System name existed already");
			}
			else if ((txtOSName.Text != grdOS.CurrentRow.Cells["OS_Name"].Value.ToString())  ||
			         (txtOS_Std_Hours.Text != grdOS.CurrentRow.Cells["OS_Std_Hours"].Value.ToString()))
			{
				if (txtOSName.Text != grdOS.CurrentRow.Cells["OS_Name"].Value.ToString())
				{				
				if (IsValidateOS() == true)
				{
				    dcOS.SubmitOne(false, txtOSID.Text, txtOSName.Text, txtOS_Std_Hours.Text);
				    DisplayGridviewOS();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
				}
				else 
					MessageBox.Show("This Operating System name existed already");
				}
				else
					dcOS.SubmitOne(false, txtOSID.Text, txtOSName.Text, txtOS_Std_Hours.Text);
				    DisplayGridviewOS();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
			}
		}
		
		void BtnDel2Click(object sender, EventArgs e)
		{
			if (txtOSID.Text == "")
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
					dcInfrastructure.UpdateEng(true, txtOSID.Text,grdOS.CurrentRow.Cells["OS_ID"].Value.ToString(),"");
		            dcOS.DeleteOne(grdOS.CurrentRow.Cells["OS_ID"].Value.ToString());
					DisplayGridviewOS();
					ResetOS();
		        }	
		}
		
		void GrdOSCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0 && e.ColumnIndex>=0)
				ClickOneRowOS();
		}
		
		//DB
		public void DisplayGridviewDB()
		{
			myBindingSource3 = dcDB.GetAll();
			grdDB.DataSource = myBindingSource3;
			grdDB.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdDB.Columns[0].Visible = false;
			grdDB.Columns["DB_Std_Hours"].Visible = false;
			grdDB.Columns["Creator"].Visible = false;
			grdDB.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdDB);
		}
		void ResetDB()
		{
			txtDBID.Text = "";
			txtDBName.Text = "";
			flagStartDB = false;
			txtDB_Std_Hours.Text = "";
			if (grdDB.Rows.Count >0)
				grdDB.CurrentCell = grdDB.Rows[0].Cells[1];
		}
		void ClickOneRowDB()
		{
			txtDBID.Text = grdDB.CurrentRow.Cells["DB_ID"].Value.ToString();
			txtDBName.Text = grdDB.CurrentRow.Cells["DB_Name"].Value.ToString();
			txtDB_Std_Hours.Text = grdDB.CurrentRow.Cells["DB_Std_Hours"].Value.ToString();
			flagStartDB = true;
		}
		
		
		void BtnReset3Click(object sender, EventArgs e)
		{
			ResetDB();
			grdDB.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdDB.CurrentRow.Selected = false;
		}
		
		void GrdDBCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0 && e.ColumnIndex>=0)
				ClickOneRowDB();
		}
		
		bool IsValidateDB()
		{
			for (int i =0; i<= grdDB.RowCount -1; i++)
				if (txtDBName.Text.ToLower() == grdDB.Rows[i].Cells["DB_Name"].Value.ToString().ToLower())
					return false;
			return true;
		}
		
		void BtnSubmit3Click(object sender, EventArgs e)
		{
			if (txtDBName.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return;
			}
		
			if (txtDBID.Text == "")
			{
				if (IsValidateDB() == true)
				{
					dcDB.SubmitOne(true, txtDBID.Text, txtDBName.Text, txtDB_Std_Hours.Text);
					DisplayGridviewDB();
					ResetDB();
					
					MessageBox.Show("Submitted successfully.");
				}
				else
					MessageBox.Show("This Database name existed already");
				
			}
			else if ((txtDBName.Text != grdDB.CurrentRow.Cells["DB_Name"].Value.ToString())  ||
			         (txtDB_Std_Hours.Text != grdDB.CurrentRow.Cells["DB_Std_Hours"].Value.ToString()))
			{
				if (txtDBName.Text != grdDB.CurrentRow.Cells["DB_Name"].Value.ToString())
				{				
				if (IsValidateOS() == true)
				{
				    dcDB.SubmitOne(false, txtDBID.Text, txtDBName.Text, txtDB_Std_Hours.Text);
					DisplayGridviewDB();
					ResetDB();
					
					MessageBox.Show("Submitted successfully.");
				}
				else 
					MessageBox.Show("This Operating System name existed already");
				}
				else
					dcDB.SubmitOne(false, txtDBID.Text, txtDBName.Text, txtDB_Std_Hours.Text);
					DisplayGridviewDB();
					ResetDB();
					
					MessageBox.Show("Submitted successfully.");
			}
//			else if (txtDBName.Text != grdDB.CurrentRow.Cells["DB_Name"].Value.ToString())
//			{				
//				if (IsValidateDB() == true)
//				{
//					dcDB.SubmitOne(false, txtDBID.Text, txtDBName.Text);
//					DisplayGridviewDB();
//					ResetDB();
//					
//					MessageBox.Show("Submitted successfully.");
//				}
//				else
//					MessageBox.Show("This Database name existed already");
//			}
		}
		
		void BtnDel3Click(object sender, EventArgs e)
		{
			if (txtDBName.Text == "")			
				return;
			
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
	        {
				dcInfrastructure.UpdateEng(false,txtDBID.Text,"",grdDB.CurrentRow.Cells["DB_ID"].Value.ToString());
	            dcDB.DeleteOne(grdDB.CurrentRow.Cells["DB_ID"].Value.ToString());
				DisplayGridviewDB();
				ResetDB();
	        }	
		}
		
		void DeSelectGrdView(int grd)
		{
			if (grd ==1)
			{
				for (int i = 1; i <= grdApp.SelectedRows.Count; i++)
					grdApp.SelectedRows[i-1].Selected = false;				
			}
			else if (grd ==2){
				for (int i = 1; i <= grdOS.SelectedRows.Count; i++)
					grdOS.SelectedRows[i-1].Selected = false;
			}
			else 
			{
				for (int i = 1; i <= grdDB.SelectedRows.Count; i++)
					grdDB.SelectedRows[i-1].Selected = false;
			}
		}
		
		void GrdAppDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeSelectGrdView(1);
		}
		
		void GrdOSDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeSelectGrdView(2);
		}
		
		void GrdDBDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeSelectGrdView(3);
		}
		

		
		void GrdAppSorted(object sender, EventArgs e)
		{
			
			DeSelectGrdView(1);
			ResetApp();
		}
		
		void GrdOSSorted(object sender, EventArgs e)
		{
			ResetOS();
			DeSelectGrdView(2);
		}
		
		void GrdDBSorted(object sender, EventArgs e)
		{
			ResetDB();
			DeSelectGrdView(3);
		}
		
		void GrdAppSelectionChanged(object sender, EventArgs e)
		{
			if (flagStartApp == true && grdApp.RowCount >0)
				ClickOneRowApp();
		}
		
		void GrdOSSelectionChanged(object sender, EventArgs e)
		{
			if (flagStartOS == true && grdOS.RowCount >0)
				ClickOneRowOS();
		}
		
		void GrdDBSelectionChanged(object sender, EventArgs e)
		{
			if (flagStartDB == true && grdDB.RowCount >0)
				ClickOneRowDB();
		}
	}
}
