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
	public partial class frmNews : MyFormPage
	{
		BindingSource myBindingSource1 = new BindingSource();
		BindingSource myBindingSource2 = new BindingSource();
		BindingSource myBindingSource3 = new BindingSource();
		
		bool flagStartOS = false;
		
		
		public frmNews(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			
			
			DisplayGridview();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				
				btnDel2.Enabled = false;
				btnSubmit2.Enabled = false;
				
				btnReset2.Enabled = false;
				
			}
			else if (Role_type == 1)
			{
				
				btnDel2.Enabled = false;
				
				btnSubmit2.Enabled = true;
				
				btnReset2.Enabled = true;
				
			}
			else if (Role_type == 4)
			{
				
				btnDel2.Enabled = true;
				
				btnSubmit2.Enabled = true;
				
				btnReset2.Enabled = true;
				
			}				
		}
			
		//OS
		
		public void DisplayGridview()
		{
			myBindingSource2 = dcNews.GetAll();
			grdNews.DataSource = myBindingSource2;
			grdNews.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdNews.Columns[0].Visible = false;
			grdNews.Columns["Creator"].Visible = false;
			grdNews.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdNews);
			
		}
		void ResetOS()
		{
			
			txtITRA_Content.Text = "";
			txtITRA_Title.Text = "";
			txtNews_ID.Text = "";
			flagStartOS = false;
			//txtOS_Std_Hours.Text = "";			
			if (grdNews.Rows.Count >0)
				grdNews.CurrentCell = grdNews.Rows[0].Cells[1];
		}
		void ClickOneRowOS()
		{
			
			txtITRA_Content.Text = grdNews.CurrentRow.Cells["ITRA_Content"].Value.ToString();
			txtITRA_Title.Text = grdNews.CurrentRow.Cells["ITRA_Title"].Value.ToString();
			txtNews_ID.Text = grdNews.CurrentRow.Cells["News_ID"].Value.ToString();
			flagStartOS	 = true;		 
		}
		
		
		void BtnReset2Click(object sender, EventArgs e)
		{
			ResetOS();
			grdNews.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdNews.CurrentRow.Selected = false;
		}
		
		bool IsValidateOS()
		{
			for (int i =0; i<= grdNews.RowCount -1; i++)
				if (txtITRA_Content.Text.ToLower() == grdNews.Rows[i].Cells["ITRA_Content"].Value.ToString().ToLower())
					return false;
			return true;
		}
		
		void BtnSubmit2Click(object sender, EventArgs e)
		{			
			
			if (txtITRA_Content.Text == "")
			{
				MessageBox.Show("Please fill in content.");
				return;
			}
		
			if (txtITRA_Title.Text == "")
			{
				MessageBox.Show("Please fill in title.");
				return;
			}
			
			if (txtNews_ID.Text == "")
			{
				
				if (IsValidateOS() == true)
				{
//					if (Environment.UserName.ToLower() == grdNews.SelectedRows[0].Cells["Creator"].Value.ToString().ToLower())
//					{
						dcNews.SubmitOne(true, txtNews_ID.Text, txtITRA_Title.Text, txtITRA_Content.Text);
//					}
//					else
//					{
//						MessageBox.Show("Abc.");
//						return;
//					}
//				    DisplayGridview();
//					ResetOS();				
//					MessageBox.Show("Submitted successfully.");
				}
				
			}
			else
			{
//				MessageBox.Show(Environment.UserName.ToLower() + " "+  grdNews.SelectedRows[0].Cells["Creator"].Value.ToString().ToLower());
					if (Environment.UserName.ToLower() == grdNews.SelectedRows[0].Cells["Creator"].Value.ToString().ToLower())
				    	dcNews.SubmitOne(false, txtNews_ID.Text, txtITRA_Title.Text, txtITRA_Content.Text);
					else
					{
						MessageBox.Show("You are not allowed to edit this news.");
						DisplayGridview();
						ResetOS();
						return;
					}
			}
				    DisplayGridview();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
			
				
			
		}
		
		void BtnDel2Click(object sender, EventArgs e)
		{
			if (txtNews_ID.Text == "")
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcNews.DeleteOne(grdNews.CurrentRow.Cells["News_ID"].Value.ToString());
					DisplayGridview();
					ResetOS();
		        }	
		}
		
		void GrdOSCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0 && e.ColumnIndex>=0)
				ClickOneRowOS();
		}	
		
		void DeSelectGrdView(int grd)
		{
			
		}
		
		
		
		void GrdOSDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DeSelectGrdView(2);
			grdNews.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		
		
		void GrdOSSorted(object sender, EventArgs e)
		{
			ResetOS();
			DeSelectGrdView(2);
		}
		
		
		
		void GrdOSSelectionChanged(object sender, EventArgs e)
		{
			if (flagStartOS == true && grdNews.RowCount >0)
				ClickOneRowOS();
		}
		
		
	}
}
