/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 12:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmBooking.
	/// </summary>
	public partial class frmC2Booking : MyFormPage
	{
		BindingSource myBindingSourceEng = new BindingSource();
		BindingSource myBindingSourceMem = new BindingSource();
		BindingSource myBindingSource1 = new BindingSource();
		int form_Role_type = new int();
		string[] arr_date = new string[28];
		
		public frmC2Booking(int Role_type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			form_Role_type = Role_type; 
			InitializeComponent();
			this.pnl = mainPanel;
			dtpFromDate.Text = DateTime.Today.ToShortDateString();
			DefaultSetting();
			cmbYear.Text = DateSupport.GetCurrentFiscalYear().ToString();
			comboBox1.SelectedIndex =0;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//User authorization
			if (Role_type == 2)
			{
				btnSubmit.Enabled = false;
			}
			else
			{
				btnSubmit.Enabled = true;
			}
		}
		
		void DefaultSetting()
		{
			grdBooking.Columns.Add("Fullname","Fullname");
			grdBooking.Columns.Add("Level","Level");
			grdBooking.Columns[1].Frozen = true;
			grdTemp.Columns.Add("Fullname","Fullname");
			grdTemp.Columns.Add("Level","Level");
			DisplayDefaultCmbEng();
			DisplayGridViewEngMember();
			AddColumnforGrd3();
			RetainForEng(dtpFromDate.Value.ToString());
			Create4WeekFromDate(dtpFromDate.Value.ToString());
			RetainforAllEng(dtpFromDate.Value.ToString());
			Bookingboard();
		}

		
		void RetainForEng(string datestring)
		{
			myBindingSource1 = dcRetain.GetData_ByKey(cmbEngID.Text, datestring);
			grd2.DataSource = myBindingSource1;
		}
		
		
		//COMBOBOX
		public void DisplayDefaultCmbEng()
		{
			myBindingSourceEng = dcEngagement.GetAll();
			
			//MessageBox.Show(Environment.UserName.ToLower());
			//myBindingSourceEng.Filter = "ITRA_SIC = '" + Environment.UserName.ToLower() + "'"; 
			
			cmbEngID.DataSource = myBindingSourceEng;
			cmbEngID.DisplayMember = "ID_Engagement";
			cmbEngID.SelectedIndex = -1;
			
			cmbEngName.DataSource = myBindingSourceEng;
			cmbEngName.DisplayMember = "Engagement_Name";
			cmbEngName.SelectedIndex = -1;
			
			
			cmbEngCode.DataSource = myBindingSourceEng;
			cmbEngCode.DisplayMember = "Engagement_Code";
			cmbEngCode.SelectedIndex = -1;
		}
		
		void AddColumnforGrd3()
		{
			if (grd3.ColumnCount ==0)
			{
				grd3.Columns.Add("ID","ID");
				grd3.Columns.Add("Date","Date");
				grd3.Columns.Add("Hour","Hour");
			}
		}
		
		void CmbEngNameSelectedIndexChanged(object sender, EventArgs e)
		{
			if (dtpFromDate.Value.ToString() == "")
			{
				return;
			}
			cmbEngCode.SelectedItem = cmbEngName.SelectedItem;
			cmbEngID.SelectedItem = cmbEngName.SelectedItem;
			txtEngCode.Text = cmbEngCode.Text;
			DisplayGridViewEngMember();
			Create4WeekFromDate(dtpFromDate.Value.ToString());
			RetainForEng(dtpFromDate.Value.ToString());
			AddColumnforGrd3();
			RetainforAllEng(dtpFromDate.Value.ToString());
			Bookingboard();
		}
		
		void CmbEngCodeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (dtpFromDate.Value.ToString() == "")
			{
				return;
			}
			cmbEngID.SelectedItem = cmbEngCode.SelectedItem;
			cmbEngName.SelectedItem = cmbEngCode.SelectedItem;
			DisplayGridViewEngMember();
			
			Create4WeekFromDate(dtpFromDate.Value.ToString());
			RetainForEng(dtpFromDate.Value.ToString());
			RetainforAllEng(dtpFromDate.Value.ToString());
			Bookingboard();
		}
		
		void DisplayGridViewEngMember()
		{
			myBindingSourceMem = dcBudgetStaffing.GetDataMemberByKey(cmbEngID.Text);
			grd1.DataSource = myBindingSourceMem;
		}
		
		void RemoveOldColumn()
		{
			if (grdBooking.ColumnCount ==0) {
				grdBooking.Columns.Add("Fullname","Fullname");
				grdBooking.Columns.Add("Level","Level");
				grdBooking.Columns[1].Frozen = true;
				grdTemp.Columns.Add("Fullname","Fullname");
				grdTemp.Columns.Add("Level","Level");
			}
			while (grdBooking.Columns.Count >2)
			{
				grdBooking.Columns.RemoveAt(grdBooking.Columns.Count-1);
				grdTemp.Columns.RemoveAt(grdBooking.Columns.Count-1);
			}
			//MessageBox.Show(grdBooking.Columns.Count.ToString());
		}
		
		void Create4WeekFromDate(string dtptext)
		{
			
			RemoveOldColumn();
			DateTime tempDate = new DateTime();
			tempDate =  DateTime.Parse(dtptext);
			grdBooking.Columns.Add(tempDate.ToShortDateString().ToString(),tempDate.ToShortDateString().ToString());
			grdTemp.Columns.Add(tempDate.ToShortDateString().ToString(),tempDate.ToShortDateString().ToString());
			arr_date[0] =  tempDate.ToShortDateString();
			
			for (int i = 1; i<=27; i++)
			{
				tempDate =  tempDate.AddDays(1);				
				grdBooking.Columns.Add(tempDate.ToShortDateString().ToString(),tempDate.ToShortDateString().ToString());
				//grdBooking.Columns.Add(tempDate.ToShortDateString(),tempDate.ToShortDateString());
				grdTemp.Columns.Add(tempDate.ToShortDateString().ToString(),tempDate.ToShortDateString().ToString());
				//grdTemp.Columns.Add(tempDate.ToShortDateString(),tempDate.ToShortDateString());
				arr_date[i] = tempDate.ToShortDateString();
			}
			grdBooking.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdTemp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			
		}
		
		void RetainforAllEng(string datestring)
		{
			
			while (grd3.Rows.Count >1)
			{
				grd3.Rows.RemoveAt(0);
				
			}
			for (int i = 0; i<=grd1.Rows.Count-2; i++)
			{
				
				BindingSource myBindingSource2 = dcRetain.Sum_ByDate(grd1.Rows[i].Cells[0].Value.ToString(),datestring);
				grd4.DataSource = myBindingSource2;
				
				for (int j =0; j <= grd4.Rows.Count-2; j++)
				{
					Object[] tempo = new Object[3];
					tempo[0] = grd4.Rows[j].Cells[0].Value;
					tempo[1] = grd4.Rows[j].Cells[1].Value;
					tempo[2] = grd4.Rows[j].Cells[2].Value;
					grd3.Rows.Add(tempo);
				}
			}
			
		}
		
		void BookingBoard1(int i)
		{
			Object[] tempo = new Object[30]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
			tempo[0] = grd1.Rows[i].Cells[1].Value.ToString();
			tempo[1] = grd1.Rows[i].Cells[2].Value.ToString();
			for (int j = 2; j<=29;j++)
			{
				for (int k =0; k <= grd2.Rows.Count - 2; k++)
					if (grd1.Rows[i].Cells[1].Value.ToString() == grd2.Rows[k].Cells[1].Value.ToString())
					{						
						DateTime tempDate = new DateTime();
						tempDate =  DateTime.Parse(grd2.Rows[k].Cells[2].Value.ToString());						
						if (arr_date[j-2] == tempDate.ToShortDateString())
							tempo[j] = grd2.Rows[k].Cells[3].Value.ToString();					
					}
			}
			grdBooking.Rows.Add(tempo);
			grdTemp.Rows.Add(tempo);
		}
		
		void BookingBoard2(int i)
		{
			Object[] tempo = new Object[30]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
			tempo[0] = (Object) "";
			tempo[1] = (Object) "";
			for (int j = 2; j<=29;j++)
			{
				for (int k =0; k <= grd3.Rows.Count - 2; k++)
					if (grd1.Rows[i].Cells[0].Value.ToString() == grd3.Rows[k].Cells[0].Value.ToString())
					{
						DateTime tempDate = new DateTime();
						tempDate =  DateTime.Parse(grd3.Rows[k].Cells[1].Value.ToString());						
						if (arr_date[j-2] == tempDate.ToShortDateString())
							tempo[j] = grd3.Rows[k].Cells[2].Value.ToString();			
					}
			}
			grdBooking.Rows.Add(tempo);
			grdTemp.Rows.Add(tempo);
			grdBooking.Rows[grdBooking.Rows.Count-1].ReadOnly = true;
			grdBooking.Rows[grdBooking.Rows.Count-1].DefaultCellStyle.BackColor = Color.LightBlue;
		}
		
		
		void CheckLimitedHour(int i)
		{
			if (grdBooking.RowCount ==1)
				return;
			for (int j =1; j<=grdBooking.Rows.Count-1;j=j+2)
			{
				//MessageBox.Show(grdBooking.Rows[j].Cells[i].Value.ToString());
				if (double.Parse(grdBooking.Rows[j].Cells[i].Value.ToString()) >= 12)
				{
						grdBooking.Rows[j].Cells[i].Style.ForeColor = Color.Red;
				}
			}
		}
		
		void CheckBookingHour(int i)
		{
			if (grdBooking.RowCount ==1)
				return;
			for (int j =0; j<=grdBooking.Rows.Count-2;j=j+2)
			{
				//MessageBox.Show(grdBooking.Rows[j].Cells[i].Value.ToString());
				if (double.Parse(grdBooking.Rows[j].Cells[i].Value.ToString()) > 0)
				{
						grdBooking.Rows[j].Cells[i].Style.BackColor = Color.Yellow;
				}
			}
		}
		
		void Bookingboard()
		{
			
			while (grdBooking.Rows.Count >0)
			{
				grdBooking.Rows.RemoveAt(0);
				grdTemp.Rows.RemoveAt(0);
				
			}
			if (cmbEngID.SelectedIndex == -1)
				return;
			for (int i = 0; i<=grd1.Rows.Count-2; i++)
			{
				BookingBoard1(i);
				BookingBoard2(i);
			}
			if (grdBooking.Rows.Count >0)
			{
				for (int i =2; i<=29; i++)
				{
					DateTime temp = FormatConverter.convertDateFromDBToCode(arr_date[i-2]);
					if ((temp.DayOfWeek == DayOfWeek.Saturday) || (temp.DayOfWeek == DayOfWeek.Sunday))
					{
						for (int j =0; j<=grdBooking.Rows.Count-1;j++)
							grdBooking.Rows[j].Cells[i].Style.BackColor = Color.Orange;
					}
					CheckLimitedHour(i);
					CheckBookingHour(i);
				}
			}
		}
		
		void UpdateGridView()
		{
			Create4WeekFromDate(dtpFromDate.Value.ToString());
			RetainForEng(dtpFromDate.Value.ToString());
			RetainforAllEng(dtpFromDate.Value.ToString());
			Bookingboard();
		}
		
		void DtpDateValueChanged(object sender, EventArgs e)
		{
			UpdateGridView();
			
		}
		
		void CheckData()
		{
			for ( int i =0; i<=grdBooking.Rows.Count-1; i=i+2)
				for (int j =2; j<=29; j++)
					if (grdBooking.Rows[i].Cells[j].Value == null)
						grdBooking.Rows[i].Cells[j].Value = (Object) 0;
			
			for ( int i =0; i<=grdBooking.Rows.Count-1; i=i+2)
			{
				for (int j =2; j<=29; j++)
				{
					
					if (grdBooking.Rows[i].Cells[j].Value.ToString() != grdTemp.Rows[i].Cells[j].Value.ToString())
					{
						
						
						if (grdTemp.Rows[i].Cells[j].Value.ToString() == "0")
						{
							//MessageBox.Show(Environment.UserName.ToLower());
							dcRetain.SubmitOne(1, cmbEngID.Text, grd1.Rows[i/2].Cells[0].Value.ToString(),arr_date[j-2],grdBooking.Rows[i].Cells[j].Value.ToString(),Environment.UserName.ToLower());
						}
						else 
						{
							if (grdBooking.Rows[i].Cells[j].Value.ToString() == "0")
								dcRetain.SubmitOne(3, cmbEngID.Text, grd1.Rows[i/2].Cells[0].Value.ToString(),arr_date[j-2],grdBooking.Rows[i].Cells[j].Value.ToString(),Environment.UserName.ToLower());
							else							
								dcRetain.SubmitOne(2, cmbEngID.Text, grd1.Rows[i/2].Cells[0].Value.ToString(),arr_date[j-2],grdBooking.Rows[i].Cells[j].Value.ToString(),Environment.UserName.ToLower());
						}
								
					}
				}
				
			}
		}
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			if (cmbEngID.Text == "")
				return;
			CheckData();
			DisplayGridViewEngMember();
				Create4WeekFromDate(dtpFromDate.Value.ToString());
			RetainForEng(dtpFromDate.Value.ToString());
			RetainforAllEng(dtpFromDate.Value.ToString());
			Bookingboard();
			MessageBox.Show("Submitted successfully.");
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
		
		void GrdBookingCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if ( e.RowIndex % 2 ==1)
				return;
			
			if (grdBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
				grdBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			bool _newVal = Validation.IsDouble(grdBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
			if (!_newVal)
				grdBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			if (FormatConverter.standardizeDouble(grdBooking.Rows[e.RowIndex].Cells[5].Value.ToString()) <0)
				grdBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			
			
			double oldvalue = FormatConverter.standardizeDouble(grdTemp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
			
			double newvalue = FormatConverter.standardizeDouble(grdBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
			
			if (newvalue <0)
			{
				
				grdBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (Object) oldvalue.ToString();
				return;
			}
			
			double readvalue = FormatConverter.standardizeDouble(grdTemp.Rows[e.RowIndex+1].Cells[e.ColumnIndex].Value.ToString());
			
			double newvaluecal = readvalue + newvalue - oldvalue;
			
			grdBooking.Rows[e.RowIndex+1].Cells[e.ColumnIndex].Value = (Object) newvaluecal.ToString();
			if (newvaluecal >= 12)
				grdBooking.Rows[e.RowIndex+1].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
			else
				grdBooking.Rows[e.RowIndex+1].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;		
		}
		
		void GrdBookingCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if ( e.RowIndex % 2 ==0)
				return;
			Form frmpopup = new frmRetain_Popup(grd1.Rows[e.RowIndex/2].Cells[0].Value.ToString(), arr_date[e.ColumnIndex-2]);
			
			frmpopup.ShowDialog();
		}
		
		void CmbYearSelectedIndexChanged(object sender, EventArgs e)
		{
			if (form_Role_type == 4) // ADMIN
			{
				BindingSource temp = (BindingSource) cmbEngID.DataSource;
				temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text + "'";
				cmbEngID.DataSource = temp;
				
				BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
				temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text + "'";
				cmbEngName.DataSource = temp1;
				
				BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
				temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text + "'";
				cmbEngCode.DataSource = temp2;
			}
		    else
		    {
				BindingSource temp = (BindingSource) cmbEngID.DataSource;
				temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
					+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
				cmbEngID.DataSource = temp;
				
				BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
				temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
					+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
				cmbEngName.DataSource = temp1;
				
				BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
				temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
					+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
				cmbEngCode.DataSource = temp2;
		    }
			
			cmbEngID.SelectedIndex =-1;
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.SelectedIndex =-1;
		}
		
		void GrdBookingColumnAdded(object sender, DataGridViewColumnEventArgs e)
		{
			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Authorized Project")
			{
				cmbYear.Enabled = false;
				
				if (form_Role_type == 4) // ADMIN
				{
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
					BindingSource temp = (BindingSource) cmbEngID.DataSource;
					temp.Filter = "Engagement_Type = '" + comboBox1.Text
						+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
					cmbEngID.DataSource = temp;
					
					BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
					temp1.Filter = "Engagement_Type = '" + comboBox1.Text
						+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
					cmbEngName.DataSource = temp1;
					
					BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
					temp2.Filter = "Engagement_Type = '" + comboBox1.Text 
						+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
					cmbEngCode.DataSource = temp2;
				}
				
			}
			//if (comboBox1.Text == "Authorized Project")
			else
			{
				cmbYear.Enabled = true;
//				MessageBox.Show(comboBox1.Text);
				
				if (form_Role_type == 4) // ADMIN
				{
					BindingSource temp = (BindingSource) cmbEngID.DataSource;
					temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text + "'";
					cmbEngID.DataSource = temp;
					
					BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
					temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text + "'";
					cmbEngName.DataSource = temp1;
					
					BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
					temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text + "'";
					cmbEngCode.DataSource = temp2;					
				}
				else
				{
					BindingSource temp = (BindingSource) cmbEngID.DataSource;
					temp.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
						+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
					cmbEngID.DataSource = temp;
					
					BindingSource temp1 = (BindingSource) cmbEngName.DataSource;
					temp1.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
						+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
					cmbEngName.DataSource = temp1;
					
					BindingSource temp2 = (BindingSource) cmbEngCode.DataSource;
					temp2.Filter = "Fiscal_Year = '" + cmbYear.Text + "' and Engagement_Type = '" + comboBox1.Text 
						+ "' and (ITRA_SIC = '" + Environment.UserName.ToLower() + "' or ITRA_MIC = '" + Environment.UserName.ToLower() +"')";
					cmbEngCode.DataSource = temp2;
				}
			}
			
			
			cmbEngID.SelectedIndex =-1;
			cmbEngName.SelectedIndex =-1;
			cmbEngCode.SelectedIndex =-1;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (cmbEngID.Text == "")
				return;
			Form frmpopup = new frmRetain_Popup1(cmbEngID.Text);
			
			frmpopup.ShowDialog();
		}
	}
}
