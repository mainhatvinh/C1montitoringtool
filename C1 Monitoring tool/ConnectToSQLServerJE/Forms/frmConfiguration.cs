/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 7/18/2013
 * Time: 11:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmConfiguration.
	/// </summary>
	public partial class frmConfiguration : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSource1 = new BindingSource();
		bool flagStart = false;
		
		int[] WeekYear = new int[13]{0,0,0,0,0,0,0,0,0,0,0,0,0};
		
		public frmConfiguration(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			GetAllData();
			Reset();			
			
			flagStart = true;
			ShowSelectedOne();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			ShowWeekRevenue();
			
			//Validation
			this.txtSeniorTargetedHrs.KeyPress += Validation.txtDouble;
			this.txtStaffTargetedHrs.KeyPress += Validation.txtDouble;
			
			//User authorization
			if (Role_type == 2)
			{
				btnSubmit.Enabled = false;
			}
			else if (Role_type == 1)
			{
				btnSubmit.Enabled = true;
			}
			else if (Role_type == 4)
			{
				btnSubmit.Enabled = true;
			}
		}
		
		
		//VALIDATION
		bool isValidated()
		{
			if ((cmbEY_FY.Text == "") || (cmbLevel.Text == ""))
			{
				MessageBox.Show("Please fill in all mandatory fields.");
				return false;
			}
			
			
			
			return true;
		}

		
		//BUTTONS
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (isValidated() == true)
			{
				try
				{
					//handle peak season target
//					if (grdPeakSeasonTarget.SelectedRows.Count == 0)
//						dcRateChange.SubmitOne(true, "", cmbEY_FY.GetItemText(cmbEY_FY.SelectedValue), cmbNewLevel.Text, dtpEffDate.Text);
//					else
					for (int i = 0; i <= grdPeakSeason.RowCount - 1; i ++ )
					{
						
							dcPeakSeasonMember.SubmitData(cmbEY_FY.Text,
							                              //grdPeakSeason.Rows[i].Cells["EY_FY"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["ID_Member"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Fullname"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Member_Level"].Value.ToString(),							                             
							                             grdPeakSeason.Rows[i].Cells["Jul"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Aug"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Sep"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Oct"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Nov"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Dec"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Jan"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Feb"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Mar"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Apr"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["May"].Value.ToString(),
							                             grdPeakSeason.Rows[i].Cells["Jun"].Value.ToString()
							                             );
							
					}
					
					myBindingSource = dcPeakSeasonMember.GetData_ByFY(cmbEY_FY.Text);
					grdTemp.DataSource = myBindingSource;
					cmbLevel.SelectedIndex = -1;
					DisplayGridView();
					
					//handle peak season member
//					for(int i = 0; i<chlITRAMember.Items.Count;i++)
//					{
//						if (checkExist(chlITRAMember.GetItemText(chlITRAMember.Items[i])) == true & chlITRAMember.GetItemCheckState(i) == CheckState.Unchecked)
//						{
//							dcPeakSeasonMember.DeleteOne(cmbEY_FY.Text, chlITRAMember.GetItemText(chlITRAMember.Items[i]));
//						}
//						else if (checkExist(chlITRAMember.GetItemText(chlITRAMember.Items[i])) == false & chlITRAMember.GetItemCheckState(i) == CheckState.Checked)
//						{
//							dcPeakSeasonMember.SubmitOne(true, cmbEY_FY.Text, chlITRAMember.GetItemText(chlITRAMember.Items[i]));
//						}
//				    }
					
					//GetAllData();
					
					//Reset();
					
					//flagStart = false;
					
					MessageBox.Show("Submitted successfully.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Submitted unsuccessfully.\nError: " + ex.ToString());
				}
			}
		}


		//COMBOBOX & CHECKLIST
		void DisplayDefaultCmbChl()
		{
			cmbEY_FY.Text = DateTime.Today.Year.ToString();
			
			
			
			//DisplayChl();
		}
		
		void DisplayChl()
		{
			//Display chlITRAMember
			for (int i = 0; i < chlITRAMember.Items.Count; i++)
			{
				chlITRAMember.SetItemChecked(i, false);
				
				if (checkExist(chlITRAMember.GetItemText(chlITRAMember.Items[i])) == true)
				{
					chlITRAMember.SetItemChecked(i,true);
				}
			}
		}
		
		void CmbEY_FYSelectedIndexChanged(object sender, EventArgs e)
		{
			//ShowSelectedOne();
			
			//myBindingSource = dcPeakSeasonMember.GetDataByFY(cmbEY_FY.Text);
			//grdPeakSeasonMember.DataSource = myBindingSource;
			
			//DisplayChl();
			cmbLevel.SelectedIndex = -1;
			myBindingSource = dcPeakSeasonMember.GetData_ByFY(cmbEY_FY.Text);
			grdTemp.DataSource = myBindingSource;
			RemoveGrd();
			//DisplayGridView();
		}
		void RemoveGrd()
		{
			while (grdPeakSeason.RowCount >0)
				grdPeakSeason.Rows.RemoveAt(0);
			while (grdPeakSeason.ColumnCount >0)
				grdPeakSeason.Columns.RemoveAt(0);
		}
		void DisplayGridView()
		{
			RemoveGrd();
			
			if (cmbLevel.Text == "")
			{
				return;
			}
			//MessageBox.Show("1");
			for (int j =0; j<= grdTemp.ColumnCount  - 1; j++)
				grdPeakSeason.Columns.Add(grdTemp.Columns[j].HeaderText,grdTemp.Columns[j].HeaderText);
			
			grdPeakSeason.Columns["ID_Member"].ReadOnly = true;
			grdPeakSeason.Columns["Fullname"].ReadOnly = true;
			grdPeakSeason.Columns["Member_Level"].Visible = false;
			
			
			grdPeakSeason.Columns["Fullname"].Frozen =true;
			for (int i =0; i <= grdTemp.RowCount - 1; i++)
			{
				Object[] tempo = new Object[grdTemp.ColumnCount];
				for (int j =0; j<= grdTemp.ColumnCount  - 1; j++)
					tempo[j] = (Object) grdTemp.Rows[i].Cells[j].Value;
				grdPeakSeason.Rows.Add(tempo);
			}
			
			for (int i =0; i <= grdPeakSeason.RowCount - 1; i++)
				for (int j =0; j<= grdPeakSeason.ColumnCount  - 1; j++)
					if (Validation.IsDouble(grdPeakSeason.Rows[i].Cells[j].Value.ToString()))
						if (double.Parse(grdPeakSeason.Rows[i].Cells[j].Value.ToString())>40)
							grdPeakSeason.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
		
		}
		
		//OTHERS
		bool checkExist(string Fullname)
		{
			for (int i = 0; i < grdPeakSeasonMember.Rows.Count; i++)
			{
				if (grdPeakSeasonMember.Rows[i].Cells["Fullname"].Value.ToString() == Fullname)
					return true;
			}
			
			return false;
		}
		
		void ShowSelectedOne()
		{
			if (flagStart == true)
			{
				for (int i =0; i < grdPeakSeasonTarget.Rows.Count;i++)
			    {
				    if (grdPeakSeasonTarget.Rows[i].Cells["EY_FY"].Value.ToString() == cmbEY_FY.Text)
		     	    {
				    	chbJan.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Jan"].Value;
						chbFeb.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Feb"].Value;
						chbMar.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Mar"].Value;
						chbApr.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Apr"].Value;
						chbMay.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["May"].Value;
						chbJun.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Jun"].Value;
						chbJul.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Jul"].Value;
						chbAug.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Aug"].Value;
						chbSep.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Sep"].Value;
						chbOct.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Oct"].Value;
						chbNov.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Nov"].Value;
						chbDec.Checked = (bool)grdPeakSeasonTarget.Rows[i].Cells["Dec"].Value;
						txtSeniorTargetedHrs.Text = grdPeakSeasonTarget.Rows[i].Cells["Senior_targeted_charged_hrs"].Value.ToString();
						txtStaffTargetedHrs.Text = grdPeakSeasonTarget.Rows[i].Cells["Staff_targeted_charged_hrs"].Value.ToString();
						
						flagStart  = true;
		     	    }
			    }
			}
		}
	
		void Reset()
		{
			// Reset if selected year does not equal to current year (default value)
			if (cmbEY_FY.Text != DateSupport.GetCurrentFiscalYear().ToString())
			{
				chbJan.Checked = false;
				chbFeb.Checked = false;
				chbMar.Checked = false;
				chbApr.Checked = false;
				chbMay.Checked = false;
				chbJun.Checked = false;
				chbJul.Checked = false;
				chbAug.Checked = false;
				chbSep.Checked = false;
				chbOct.Checked = false;
				chbNov.Checked = false;
				chbDec.Checked = false;
				
				txtSeniorTargetedHrs.Text = "";
				txtStaffTargetedHrs.Text = "";
				
				DisplayDefaultCmbChl();
			}
		}
		
		void GetAllData()
		{
			//myBindingSource = dcPeakSeasonTarget.GetAll();
			//grdPeakSeasonTarget.DataSource = myBindingSource;
			//grdEngagement.Columns[2].Frozen = true;
		}
		
		string getChbValue(CheckState checkstate)
		{
			if (checkstate == CheckState.Checked)
				return "1";
			else
				return "0";
		}
		
		void CmbLevelSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbLevel.Text == "")
				return;
			BindingSource temp = (BindingSource) grdTemp.DataSource;
			if (cmbLevel.Text == "Staff")
			    temp.Filter = "Member_Level LIKE 'Staff%' or Member_Level LIKE 'Intern%' ";
			else
				temp.Filter = "Member_Level LIKE '" + cmbLevel.Text + "%'";
			grdTemp.DataSource = temp;
			DisplayGridView();
		}
		
		void GrdPeakSeasonCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex<=2)
				return;
			if (Validation.IsDouble(grdPeakSeason.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) == false)
			    grdPeakSeason.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			if (double.Parse(grdPeakSeason.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) < 0)
				grdPeakSeason.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
		}
		//int WeekYear[] = new int[12]{0,0,0,0,0,0,0,0,0,0,0,0};
		void CmbEYFYSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbEYFY.Text == "")
				return;
			myBindingSource1 = dcStandardHour.GetDataByFY(cmbEYFY.Text);
			grdTempStd.DataSource = myBindingSource1;
			
			CalculateWeek(int.Parse(cmbEYFY.Text));
			
			DisplayGridView_StdHour();
			
			
		}
		
		void CalculateWeek(int year)
		{
			WeekYear[0] =0;
			
			for (int i =1 ; i <=12; i++)
			{
				if (i>=7)
					WeekYear[i] = DateSupport.DoM(i,year-1) / 7;
				else
					WeekYear[i] = DateSupport.DoM(i,year) / 7;
				
				WeekYear[0] = WeekYear[0]+WeekYear[i];
			}
		}
		
		void DisplayGridView_StdHour()
		{
			
			while (grdStdHour.RowCount >0)
				grdStdHour.Rows.RemoveAt(0);
			while (grdStdHour.ColumnCount >0)
				grdStdHour.Columns.RemoveAt(0);
			
			for (int i =0; i<= grdTempStd.ColumnCount -1 ; i ++)
				grdStdHour.Columns.Add(grdTempStd.Columns[i].HeaderText,grdTempStd.Columns[i].HeaderText);
			grdStdHour.Columns.Add("Target Percentage","Target Percentage");
			for  (int i =0; i<= grdTempStd.RowCount - 1; i ++)
			{
				Object[] temp = new Object[ grdTempStd.ColumnCount+1];
				for (int j =0; j<= grdTempStd.ColumnCount -1 ; j ++)
					temp[j] = (Object) grdTempStd.Rows[i].Cells[j].Value;
				temp[grdTempStd.ColumnCount] = (Object) 0;
				grdStdHour.Rows.Add(temp);
				grdStdHour.Rows[grdStdHour.RowCount - 1].Cells["Target Percentage"].Value = (Object) CalculatePercent(grdStdHour.RowCount -1);
			}
			grdStdHour.Columns[0].Frozen = true;
			grdStdHour.Columns["Target Percentage"].DefaultCellStyle.BackColor = Color.LightBlue;
			grdStdHour.Columns["Target Percentage"].ReadOnly = true;
			
			
		}
		
		string CalculatePercent(int row)
		{
			double targethour = 0;
			int[] tempM = new int[13]{0,7,8,9,10,11,12,1,2,3,4,5,6};
//			MessageBox.Show(
//				//grdStdHour.Rows[row].Cells[Array.IndexOf(tempM,1)].Value.ToString() + " - " + WeekYear[1].ToString()
//				WeekYear[0].ToString()
//			);
			
			
			
			for (int i = 1; i <= 12; i++)
				targethour  = targethour + (int.Parse(grdStdHour.Rows[row].Cells[Array.IndexOf(tempM,i)].Value.ToString())
				                            * WeekYear[i]);
			targethour =Math.Round( (targethour*100) /(WeekYear[0]*40),2);
			return targethour.ToString();
		}
		
		void GrdStdHourCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 )
				return;
			if (e.ColumnIndex < 1)
				return;
			if (e.ColumnIndex == grdStdHour.RowCount -1)
				return;
			if (Validation.IsDouble(grdStdHour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) == false)
			    grdStdHour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTempStd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			if (double.Parse(grdStdHour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) < 0)
				grdStdHour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTempStd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			grdStdHour.Rows[e.RowIndex].Cells["Target Percentage"].Value = (Object) CalculatePercent(e.RowIndex);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
			
				for (int i = 0; i <= grdStdHour.RowCount -1; i++)
					dcStandardHour.SubmitOne(grdStdHour.Rows[i].Cells["Level"].Value.ToString(),cmbEYFY.Text,
				                         grdStdHour.Rows[i].Cells["Jul"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Aug"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Sep"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Oct"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Nov"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Dec"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Jan"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Feb"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Mar"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Apr"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["May"].Value.ToString(),
				                         grdStdHour.Rows[i].Cells["Jun"].Value.ToString()
				                        );
			
				MessageBox.Show("Submitted successfully.");
				//cmbEYFY.Text = cmbEYFY.Text;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Submitted unsuccessfully.\nError: " + ex.ToString());
				}
		}
		
		
		void GrdStdHourColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void GrdPeakSeasonColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;	
		}
		
		void ShowWeekRevenue()
		{
			grdWeekRev.DataSource = dcNews.GetData_ByKey_Config("1");
			
			textBox1.Text = grdWeekRev.Rows[0].Cells["Week_Number"].Value.ToString();
			textBox2.Text = grdWeekRev.Rows[0].Cells["Revenue_Per"].Value.ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (isValidated_Week())
			{
				dcNews.SubmitOne_Config("1",textBox1.Text,textBox2.Text);
				MessageBox.Show("Submit successfully");
				ShowWeekRevenue();				
			}
			
			
		}
		
		bool isValidated_Week()
		{
			if (!Validation.isInteger(textBox1.Text))
			{
				MessageBox.Show("Wrong week number");
				return false;
			}
			
					
			if (!Validation.IsDouble(textBox2.Text)) {
				MessageBox.Show("Wrong revenue percentage");
				return false;
			}			
			
			int week = int.Parse(textBox1.Text);
			double rev = double.Parse(textBox2.Text);
			
			if ((week <0) || (week >52))
			{
				MessageBox.Show("Wrong week number");
				return false;
			}
			
			if ((rev < 0) || (rev > 200)) {
				MessageBox.Show("Wrong revenue percentage");
				return false;
			}
			
			return true;	
		}
	}
}
