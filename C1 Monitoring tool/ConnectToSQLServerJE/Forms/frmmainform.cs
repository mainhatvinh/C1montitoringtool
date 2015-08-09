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
	public partial class frmmainform : MyFormPage
	{
		BindingSource myBindingSource1 = new BindingSource();
		BindingSource myBindingSource2 = new BindingSource();
		BindingSource myBindingSource3 = new BindingSource();
		
		bool flagStartOS = false;
		
		
		public frmmainform(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;

			
			DisplayGridviewOS();
			DisplayGridviewNews();
			DisplayWeekRev();
			
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
		
		public void DisplayGridviewOS()
		{
			myBindingSource2 = dcMainboard.GetAll();
			grdOS.DataSource = myBindingSource2;
			grdOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdOS.Columns[0].Visible = false;
			grdOS.Columns["Creator"].Visible = false;
			grdOS.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdOS);
			//ClickOneRowOS();
			txtInformation.Text = grdOS.Rows[0].Cells[1].Value.ToString();
		}
		
		public void DisplayGridviewNews()
		{
			myBindingSource2 = dcNews.GetAll();
			grdNews.DataSource = myBindingSource2;
			grdNews.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdNews.Columns[0].Visible = false;
			grdNews.Columns["ITRA_Content"].Visible = false;
			//grdNews.Columns["CreateDate"].Visible = false;
			DgvFilterPopup.DgvFilterManager fm = new DgvFilterPopup.DgvFilterManager(grdNews);
			grdNews.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void ResetOS()
		{
			
			txtInformation.Text = "";
			flagStartOS = false;
			//txtOS_Std_Hours.Text = "";			
			if (grdOS.Rows.Count >0)
				grdOS.CurrentCell = grdOS.Rows[0].Cells[1];
		}
		void ClickOneRowOS()
		{
			
			txtInformation.Text = grdOS.CurrentRow.Cells["ITRA_Information"].Value.ToString();
			txtOSID.Text = grdOS.CurrentRow.Cells["No_of_Information"].Value.ToString();
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
				if (txtInformation.Text.ToLower() == grdOS.Rows[i].Cells["ITRA_Information"].Value.ToString().ToLower())
					return false;
			return true;
		}
		
		void BtnSubmit2Click(object sender, EventArgs e)
		{			
			
			if (txtInformation.Text == "")
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return;
			}
		
			if (txtOSID.Text == "")
			{
				if (IsValidateOS() == true)
				{
				    dcMainboard.SubmitOne(true, txtOSID.Text, txtInformation.Text);
				    DisplayGridviewOS();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
				}
				
			}
			else if (txtInformation.Text != grdOS.CurrentRow.Cells["ITRA_Information"].Value.ToString())
			{
				if (txtInformation.Text != grdOS.CurrentRow.Cells["ITRA_Information"].Value.ToString())
				{				
				if (IsValidateOS() == true)
				{
				    dcMainboard.SubmitOne(false, txtOSID.Text, txtInformation.Text);
				    DisplayGridviewOS();
					ResetOS();				
					MessageBox.Show("Submitted successfully.");
				}
				
				}
				
			}
		}
		
		void BtnDel2Click(object sender, EventArgs e)
		{
			if (txtOSID.Text == "")
				return;
			if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
		            dcMainboard.DeleteOne(grdOS.CurrentRow.Cells["No_of_Information"].Value.ToString());
					DisplayGridviewOS();
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
			grdOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		
		
		void GrdOSSorted(object sender, EventArgs e)
		{
			ResetOS();
			DeSelectGrdView(2);
		}
		
		
		
		void GrdOSSelectionChanged(object sender, EventArgs e)
		{
			if (flagStartOS == true && grdOS.RowCount >0)
				ClickOneRowOS();
		}
		
		
		
		void FrmmainformLoad(object sender, EventArgs e)
		{
			
		}
		
		void GrdNewsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			grdNews.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void GrdNewsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex<0)
				return;
			if (grdNews.DataSource == null)
				return;
			if (grdNews.Rows[e.RowIndex].Cells["News_ID"].Value.ToString() == "")
				return;
			
			Form frmmainform_popup = new frmmainform_popup(grdNews.Rows[e.RowIndex].Cells["News_ID"].Value.ToString());
			
			frmmainform_popup.ShowDialog();
		}
		
		void DisplayWeekRev()
		{
			
			grdWeekRev.DataSource = dcNews.GetData_ByKey_Config("1");
			
			int week = int.Parse(grdWeekRev.Rows[0].Cells["Week_Number"].Value.ToString());
			double rev = double.Parse(grdWeekRev.Rows[0].Cells["Revenue_Per"].Value.ToString());
			
			progressBar1.Minimum = 0;
			progressBar1.Maximum = 52;
			progressBar1.Value = week;
			progressBar1.Step = 1;	
			label3.Text = "Week "+week.ToString()+"/52";
			
//			int percent = (int)(((double)(progressBar1.Value - progressBar1.Minimum) /
//			(double)(progressBar1.Maximum - progressBar1.Minimum)) * 100);
//			//MessageBox.Show(percent.ToString());
//			using (Graphics gr = progressBar1.CreateGraphics())
//			{
////			    gr.DrawString(percent.ToString() + "%",
////			        SystemFonts.DefaultFont,
////			        Brushes.Black,
////			        new PointF(progressBar1.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
////			            SystemFonts.DefaultFont).Width / 2.0F),
////			        progressBar1.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
////			            SystemFonts.DefaultFont).Height / 2.0F)));
//							    gr.DrawString(percent.ToString() + "%",
//			        SystemFonts.DefaultFont,
//			        Brushes.Black,
//			        new PointF(100,50));
//				//gr.
//				//MessageBox.Show(gr.IsVisible(10,10).ToString());
//			}
			
			if (rev <= 100)
			{
				int per = (int) Math.Round(rev,0);
				
				progressBar2.Minimum = 0;
				progressBar2.Maximum = 100;
				progressBar2.Value = per;
				progressBar2.Step = 1;	
				progressBar2.Text = per.ToString();
				progressBar3.Visible = false;
				label4.Text = per.ToString() + " %";
				label5.Visible = false;
			}
			else
			{
				progressBar2.Minimum = 0;
				progressBar2.Maximum = 100;
				progressBar2.Value = 100;
				progressBar3.Visible = true;
				label4.Text = "100 %";
				label5.Visible = true;
				int per = (int) Math.Round(rev-100,0);
				progressBar3.Minimum = 0;
				progressBar3.Maximum = 100;
				progressBar3.Value = per;
				progressBar3.Step = 1;
				label5.Text = (rev-100).ToString() + " %";
					
			}
		}
	}
}
