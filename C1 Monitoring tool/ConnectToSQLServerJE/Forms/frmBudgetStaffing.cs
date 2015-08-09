/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmBudgetStaffing.
	/// </summary>
	public partial class frmBudgetStaffing : MyFormPage
	{
		BindingSource myBindingSource = new BindingSource();
		BindingSource myBindingSourceGrd = new BindingSource();
		BindingSource myBindingSourceGrd1 = new BindingSource();
		BindingSource myBindingSourceMem = new BindingSource();
		
		//bool[] visible_arr = new bool[13]{true,true,true,true,true,true,true,true,true,true,true,true,true};
		bool[] visible_arr = new bool[13]{false,false,false,false,true,true,true,true,true,true,true,true,true};
		bool[] readonly_arr = new bool[13]{true,true,true,true,true,false,false,false,false,false,false,false,true};
		
		int form_Role_type = new int();
		bool flagStart = false;
		public frmBudgetStaffing(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pnl = mainPanel;
			form_Role_type = Role_type;
			DisplayDefaultCmb();
			DisplayDefaultCmbMem();
			comboBox1.SelectedIndex =0;
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
			
			cmbLevel.Enabled = false;
			cmbName.Enabled = false;
			cmbMemLvl.Enabled = false;
			//DisplayGridView();
			//grdStaffing.CurrentCell = grdStaffing.Rows[grdStaffing.RowCount-1].Cells[4];
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
		
		//COMBOBOX
		public void DisplayDefaultCmbMem()
		{
			myBindingSourceMem = dcITRAMember.GetAll();
		
			cmbName.DataSource= myBindingSourceMem;
			cmbName.DisplayMember = "FullName";
			cmbName.ValueMember ="ID_Member";
			cmbName.SelectedIndex = -1;
			
			cmbMemLvl.DataSource = myBindingSourceMem;
			cmbMemLvl.DisplayMember = "Member_Level";
			cmbMemLvl.SelectedIndex = -1;
			
		}
		
		public void DisplayDefaultCmb()
		{
			
			//cmbName.Text = cmbName.SelectedText;
			
			myBindingSource = dcEngagement.GetAll();
			//MessageBox.Show(Environment.UserName);
			//myBindingSource.Filter= "ITRA_SIC = '" + Environment.UserName + "' or ITRA_MIC = '"  + Environment.UserName + "'";
			
			cmbEngID.DataSource = myBindingSource;
			cmbEngID.DisplayMember = "ID_Engagement";
			//cmbEngID.Text = cmbEngID.GetItemText(cmbEngID.Items[0]);
			cmbEngID.SelectedIndex =-1;
			
			cmbEngName.DataSource = myBindingSource;
			cmbEngName.DisplayMember = "Engagement_Name";
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.DataSource = myBindingSource;
			cmbEngCode.DisplayMember = "Engagement_Code";
			cmbEngCode.SelectedIndex =-1;
			
			
		}
		
		void CmbEngNameSelectedIndexChanged(object sender, EventArgs e)
		{
			cmbEngCode.SelectedItem = cmbEngName.SelectedItem;
			cmbEngID.SelectedItem = cmbEngName.SelectedItem;
			txtEngCode.Text = cmbEngCode.Text;
			if (cmbEngName.SelectedIndex == -1 )
			{
				cmbLevel.Enabled = false;
				cmbName.Enabled = false;
				cmbMemLvl.Enabled = false;
			}
			else
			{
				cmbLevel.Enabled = true;
				cmbName.Enabled = true;
				cmbMemLvl.Enabled = true;
			}
			DisplayGridView();	
			ResetMem();
		}
		
		
		void CmbEngCodeSelectedIndexChanged(object sender, EventArgs e)
		{
			cmbEngID.SelectedItem = cmbEngCode.SelectedItem;
			cmbEngName.SelectedItem = cmbEngCode.SelectedItem;
			if (cmbEngCode.SelectedIndex == -1 )
			{
				cmbLevel.Enabled = false;
				cmbName.Enabled = false;
				cmbMemLvl.Enabled = false;
			}
			else
			{
				cmbLevel.Enabled = true;
				cmbName.Enabled = true;
				cmbMemLvl.Enabled = true;
			}
			DisplayGridView();
			ResetMem();
		}
		
		void DisplayGridView()
		{
			//myBindingSourceGrd = dcBudgetStaffing.GetDataEngMem_ByKey(cmbEngID.Text);
			myBindingSourceGrd1 = dcBudgetStaffing.GetDataEngMem_ByKey(cmbEngID.Text);
			//grdStaffing.DataSource = myBindingSourceGrd;
			
			//grdStaffing.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			
			grdTemp.DataSource = myBindingSourceGrd1;
			grdTemp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			while (grdStaffing.Columns.Count>0)
			{
				grdStaffing.Columns.RemoveAt(0);
			}
			while (grdStaffing.Rows.Count>1)
			{
				grdStaffing.Rows.RemoveAt(0);
			}
			/// <summary>
			/// doi vi tri cot
			/// </summary>
			for (int i =0; i <= 3; i ++)
				grdStaffing.Columns.Add(grdTemp.Columns[i].HeaderText,grdTemp.Columns[i].HeaderText);
			grdStaffing.Columns.Add(grdTemp.Columns[12].HeaderText,grdTemp.Columns[4].HeaderText);
			
			//Combobox column for level selection
			DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
			myBindingSourceMem = dcRate.GetAll();
			col.DataSource= myBindingSourceMem;
			col.DisplayMember = "Level";
			grdStaffing.Columns.Add(col);
			grdStaffing.Columns[5].HeaderText = grdTemp.Columns[12].HeaderText;
			
			for (int i =5; i <= 11; i ++)
				grdStaffing.Columns.Add(grdTemp.Columns[i].HeaderText,grdTemp.Columns[i].HeaderText);
			
			/// <summary>
			/// doi vi tri cot
			/// </summary>
			for (int i =0; i <= grdTemp.Rows.Count - 2; i ++)
			{
				Object[] tempo = new Object[grdTemp.Columns.Count];
				for (int j = 0; j<= 4; j++)
					tempo[j] = grdTemp.Rows[i].Cells[j].Value;
				tempo[5] = grdTemp.Rows[i].Cells[12].Value;
				for (int j = 5; j<= 11; j++)
					tempo[j+1] = grdTemp.Rows[i].Cells[j].Value;
				
				grdStaffing.Rows.Add(tempo);
			}
			
			DeSelectGrdView();
			for ( int i =0; i <= 12; i++)
			{
				grdStaffing.Columns[i].Visible = visible_arr[i];
				grdStaffing.Columns[i].ReadOnly = readonly_arr[i];
			}
			
			grdStaffing.Columns[12].DefaultCellStyle.BackColor = Color.LightBlue;
			//grdStaffing.Columns[12].Visible = false;
		}
		
		void DeSelectGrdView()
		{
			for (int i = 1; i <= grdStaffing.SelectedRows.Count; i++)
				grdStaffing.SelectedRows[i-1].Selected = false;
		}
		
		
		void ClickOneRow(int row)
		{
			flagStart = true;
 //			string level = grdStaffing.CurrentRow.Cells[5].Value.ToString();
//			string[] ss = level.Split(' ');
//			string strnew ="";
//		    for (int i = 0; i < ss.Length-1; i++)
//		        {
//		            strnew += ss[i];
//		        }
//		    
//		    string lvl ="";
//		    switch(strnew)
//		    {
//		    	case "Senior": lvl = "Senior"; break;
//			    case "SeniorManager": lvl = "Senior Manager";break;
//			    case "Manager": lvl ="Manager";break;
//			    case "Partner": lvl ="Partner";break;
//			    default: lvl="Staff"; break;
//		    }
//		    if (level  == "Partner") lvl = "Partner";
//		    cmbLevel.Text = lvl;
			cmbName.Text = grdStaffing.CurrentRow.Cells[4].Value.ToString();
		}
		
		void GrdStaffingCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
				ClickOneRow(e.RowIndex);
			
//			if (e.RowIndex == grdStaffing.Rows.Count -1)
//			{
//				
//				DisplayDefaultCmbMem();
//				ResetMem();
//			}
		}
		
		void SetComboBoxMember(string level)
		{
			myBindingSourceMem = dcITRAMember.GetData_ByKeyLevel(level);
			
			cmbName.DataSource= myBindingSourceMem;
			cmbName.DisplayMember = "FullName";
			cmbName.ValueMember = "ID_Member";
			cmbName.SelectedIndex = -1;
			
			cmbMemLvl.DataSource = myBindingSourceMem;
			cmbMemLvl.DisplayMember = "Member_Level";
			cmbMemLvl.SelectedIndex = -1;
			
//			cmbMLevel.DataSource= myBindingSourceMem;
//			cmbMLevel.DisplayMember = "Member_Level";
//			cmbMLevel.ValueMember = "FullName";
//			cmbMLevel.SelectedIndex = -1;
		}
		
		void CmbLevelSelectedIndexChanged(object sender, EventArgs e)
		{
			SetComboBoxMember(cmbLevel.Text);
			
			//MessageBox.Show(cmbLevel.Text);
		}
		
		void ResetMem()
		{
			
			cmbLevel.SelectedIndex  = -1;
			DisplayDefaultCmbMem();
			flagStart = false;
			
			//grdStaffing.CurrentCell = grdStaffing.Rows[grdStaffing.RowCount-1].Cells[4];
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			DeSelectGrdView();
			ResetMem();
			DisplayDefaultCmbMem();
		}
		
		bool CheckChar(string check)
		{
			int temp1 = (int) check[0];
			
			if ((temp1 == 45) || (temp1>= 48 && temp1<= 57))
			{
				for (int i =1; i<= check.Length-1; i++)
				{
					int temp = (int) check[i];
					//MessageBox.Show(temp.ToString());
					if ((temp < 48) ||(temp >57))
						return false;
				}
			}
			else
				return false;
			
			
			return true;
		}
		
		
		
		void GrdStaffingCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			
			if (e.ColumnIndex<=5)
				return;
			if (grdStaffing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
				grdStaffing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value;
			bool _newVal = Validation.IsDouble(grdStaffing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
			if (!_newVal)
				grdStaffing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value;
			if (e.ColumnIndex == 6 && FormatConverter.standardizeDouble(grdStaffing.Rows[e.RowIndex].Cells[6].Value.ToString()) <0)
				grdStaffing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value;
			
			double newH = 0;
			for ( int i =6; i<=11; i++)
				newH = newH + FormatConverter.standardizeDouble(grdStaffing.Rows[e.RowIndex].Cells[i].Value.ToString());			
			grdStaffing.Rows[e.RowIndex].Cells[12].Value = (Object) newH;
			
		}
		
		bool CheckPosition(int iRow)
		{
			//MessageBox.Show(iRow.ToString());
			for (int i = 0; i <= grdStaffing.RowCount-1; i++)
				if (i != iRow && grdStaffing.Rows[i].Cells[4].Value.ToString() == grdStaffing.Rows[iRow].Cells[4].Value.ToString()
				   && grdStaffing.Rows[i].Cells[5].Value.ToString() == grdStaffing.Rows[iRow].Cells[5].Value.ToString())
					return false;
			for (int j = 0; j <= grdStaffing.RowCount-1; j++)
				if (j!= iRow && grdTemp.Rows[j].Cells[4].Value.ToString() == grdStaffing.Rows[iRow].Cells[4].Value.ToString()
				   && grdTemp.Rows[j].Cells[12].Value.ToString() == grdStaffing.Rows[iRow].Cells[5].Value.ToString())
					return false;
			return true;
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (cmbEngName.Text == "")
			{
				MessageBox.Show("Please select one engagement to booking");
				return;
			}	
			
			if (cmbName.Text == "")
			{
				MessageBox.Show("Please select one person in ITRA List");
				return;
			}
				
			bool _update = false;

			if (grdStaffing.SelectedRows.Count == 0)
			{
				bool _insert = true;
				if (cmbName.Text != "")
				{
					
					for (int i =0; i < grdStaffing.Rows.Count; i++)
					{
						//MessageBox.Show(grdStaffing.Rows[i].Cells[4].Value.ToString() + " " + grdStaffing.Rows[i].Cells[5].Value.ToString());
						if (cmbName.Text == grdStaffing.Rows[i].Cells[4].Value.ToString() && cmbMemLvl.Text == grdStaffing.Rows[i].Cells[5].Value.ToString())
							_insert = false;
					}
					//MessageBox.Show(_insert.ToString());
					if (_insert)
					{
						dcBudgetStaffing.SubmitOne(true, cmbEngID.Text, cmbName.GetItemText(cmbName.SelectedValue), "0", "0", "0", "0", "0", "0","","","","");
						DeSelectGrdView();
						ResetMem();
						DisplayGridView();
						DisplayDefaultCmbMem();
						MessageBox.Show("Submitted successfully.");
						return;
					}
					else 
					{
						MessageBox.Show(cmbName.Text + " (" + cmbMemLvl.Text + ") was already here.");
						return;
					}
				}
			}
			
			for (int i =0; i<= grdStaffing.Rows.Count -1; i++)
			{
				bool update_ = false;
				for (int j = 6;j<=11;j++)
				{
//					
					if (grdStaffing.Rows[i].Cells[j].Value.ToString() != grdTemp.Rows[i].Cells[j-1].Value.ToString())
					{
						update_ = true;
						//break;
					}
				}
				if (grdStaffing.Rows[i].Cells[5].Value.ToString() != grdTemp.Rows[i].Cells[12].Value.ToString())
					update_ = CheckPosition(i);
				
				if (update_)
				{
					_update = true;
					string EngID = grdStaffing.Rows[i].Cells[0].Value.ToString();
					string MemID = grdStaffing.Rows[i].Cells[3].Value.ToString();
					string Hours = grdStaffing.Rows[i].Cells[6].Value.ToString();
					string Amend1 = grdStaffing.Rows[i].Cells[7].Value.ToString();
					string Amend2 = grdStaffing.Rows[i].Cells[8].Value.ToString();
					string Amend3 = grdStaffing.Rows[i].Cells[9].Value.ToString();
					string Amend4 = grdStaffing.Rows[i].Cells[10].Value.ToString();
					string Amend5 = grdStaffing.Rows[i].Cells[11].Value.ToString();
					string Level = grdStaffing.Rows[i].Cells[5].Value.ToString();
					string OldLevel = grdTemp.Rows[i].Cells[12].Value.ToString();
					if (grdTemp.Rows[i].Cells[12].Value.ToString() == grdStaffing.Rows[i].Cells[5].Value.ToString())
						Level = "NoUpdate";
					//MessageBox.Show(Level.ToString() + "     " + OldLevel.ToString());
					dcBudgetStaffing.SubmitOne(false, EngID, MemID, Hours, Amend1, Amend2, Amend3, Amend4, Amend5, Level,OldLevel,"","");				
				}
				
			}
			
			if ((grdStaffing.SelectedRows.Count !=0)&&(grdStaffing.CurrentRow.Cells[4].Value.ToString() != cmbName.Text))
			{
				
				bool _update1 = true;
				for (int i =0; i < grdStaffing.Rows.Count; i++)
						if (cmbName.Text == grdStaffing.Rows[i].Cells[4].Value.ToString() && cmbMemLvl.Text == grdStaffing.Rows[i].Cells[5].Value.ToString())
							_update1 = false;
				if (_update1)
				{
					_update = true;
					dcRetain.UpdateMember(grdStaffing.SelectedRows[0].Cells[0].Value.ToString(), 
					                      grdStaffing.SelectedRows[0].Cells[3].Value.ToString(),
					                      cmbName.GetItemText(cmbName.SelectedValue));
					dcBudgetStaffing.UpdateMember(grdStaffing.SelectedRows[0].Cells[0].Value.ToString(), 
					                      grdStaffing.SelectedRows[0].Cells[3].Value.ToString(),
					                      cmbName.GetItemText(cmbName.SelectedValue));
				}
				
					
			}
			if (_update)
			{
				
				DeSelectGrdView();
				ResetMem();
				DisplayDefaultCmbMem();
				DisplayGridView();
				MessageBox.Show("Submitted successfully.");
			}
			else
			{
				MessageBox.Show("Cannot update. Please check again before submit");
				return;
			}
		}
		
		void CmbNameSelectedIndexChanged(object sender, EventArgs e)
		{
			cmbMemLvl.SelectedIndex = cmbName.SelectedIndex;
						
		}
		
		void GrdStaffingPaint(object sender, PaintEventArgs e)
		{
			
		}
		
		void GrdStaffingDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			
		}
		
		void CmbNameSelectedValueChanged(object sender, EventArgs e)
		{
			//grdStaffing.CurrentRow.Selected = true;	
		}
		
		void BtnDelClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to delete this record? The related data in Retain will be deleted.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		        {
					dcRetain.DeleteMem_byKey(grdStaffing.CurrentRow.Cells[0].Value.ToString(),grdStaffing.CurrentRow.Cells[3].Value.ToString());
					dcBudgetStaffing.DeleteOne(grdStaffing.CurrentRow.Cells[0].Value.ToString(),grdStaffing.CurrentRow.Cells[3].Value.ToString());
					DeSelectGrdView();
					ResetMem();
					DisplayGridView();
		        }
		}
	
		
		
		
		void CmbYearSelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (form_Role_type ==4)
			{			
				BindingSource temp = (BindingSource) cmbEngID.DataSource;
				temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
								+ "'";
				cmbEngID.DataSource = temp;
				
				BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
				temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
								+ "'";
				cmbEngName.DataSource = temp1;
				
				BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
				temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
								+ "'";
				cmbEngCode.DataSource = temp2;
			}
			else
			{
				BindingSource temp = (BindingSource) cmbEngID.DataSource;
				temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
								+ "' and (ITRA_SIC = '" + Environment.UserName + "' or ITRA_MIC = '"  + Environment.UserName + "')";
				cmbEngID.DataSource = temp;
				
				BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
				temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
								+ "' and (ITRA_SIC = '" + Environment.UserName + "' or ITRA_MIC = '"  + Environment.UserName + "')";
				cmbEngName.DataSource = temp1;
				
				BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
				temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
								+ "' and (ITRA_SIC = '" + Environment.UserName + "' or ITRA_MIC = '"  + Environment.UserName + "')";
				cmbEngCode.DataSource = temp2;
			}
			
			
			cmbEngID.SelectedIndex =-1;
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.SelectedIndex =-1;
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Authorized Project" || comboBox1.Text == "Non-chargeable")
			{
				cmbYear.Enabled = false;
				BindingSource temp = (BindingSource) cmbEngID.DataSource;
				temp.Filter = "Engagement_Type = '" + comboBox1.Text + "'";
				cmbEngID.DataSource = temp;
				
				BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
				temp1.Filter = "Engagement_Type = '" + comboBox1.Text + "'";
				cmbEngName.DataSource = temp1;
				
				BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
				temp2.Filter = "Engagement_Type = '" + comboBox1.Text + "'";
				cmbEngCode.DataSource = temp2;
				
			}
			else
			{
				cmbYear.Enabled = true;
				if (form_Role_type ==4)
				{
					BindingSource temp = (BindingSource) cmbEngID.DataSource;
					temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
									+ "'";
					cmbEngID.DataSource = temp;
					
					BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
					temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
									+ "'";
					cmbEngName.DataSource = temp1;
					
					BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
					temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
									+ "'";
					cmbEngCode.DataSource = temp2;
				}
				else
				{
					BindingSource temp = (BindingSource) cmbEngID.DataSource;
					temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
									+ "' and (ITRA_SIC = '" + Environment.UserName + "' or ITRA_MIC = '"  + Environment.UserName + "')";
					cmbEngID.DataSource = temp;
					
					BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
					temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
									+ "' and (ITRA_SIC = '" + Environment.UserName + "' or ITRA_MIC = '"  + Environment.UserName + "')";
					cmbEngName.DataSource = temp1;
					
					BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
					temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
									+ "' and (ITRA_SIC = '" + Environment.UserName + "' or ITRA_MIC = '"  + Environment.UserName + "')";
					cmbEngCode.DataSource = temp2;
				}
				
				
			}
			
			
			cmbEngID.SelectedIndex =-1;
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.SelectedIndex =-1;
		}
		
		void GrdStaffingSelectionChanged(object sender, EventArgs e)
		{
			
			if (flagStart == true && grdStaffing.RowCount >0)
				ClickOneRow(grdStaffing.CurrentCell.RowIndex);
		}
	}
}
