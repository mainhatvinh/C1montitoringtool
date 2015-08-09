/*
 * Created by SharpDevelop.
 * User: luan.khanh.ha
 * Date: 8/29/2014
 * Time: 2:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace C1Monitoring
{
	/// <summary>
	/// Description of frmIndustrySelection.
	/// </summary>
	public partial class frmIndustrySelection : Form
	{
		BindingSource myBindingSource = new BindingSource();
		
		private ListBox FromParent;
		public ListBox ListFormParent 
		{
			get { return FromParent; }
            set { FromParent = value; }
		}
		
		public frmIndustrySelection()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//DataConnect.ConnectData();
			DisplayGridView();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private frmClient mdiParent;
		public frmIndustrySelection(frmClient mdi, ListBox temp)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.mdiParent = mdi;
			//MessageBox.Show(temp.Items[1].ToString());
			DisplayMessageFromParent(temp);
			
			DisplayGridView();
			//DataConnect.ConnectData();
			//DisplayGridView();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void DisplayMessageFromParent(ListBox source)
        {
           // lblMessageFromParent.Text = MessageFromParent;
           listBox2.Items.Clear();
			ListBox.ObjectCollection sourceItems = source.Items;
			foreach (var item in sourceItems)
			{
				listBox2.Items.Add(item);
			}
			
			//MessageBox.Show(ListFormParent.Items[1].ToString());
			
			
        }
		
		void DisplayGridView()
		{
			myBindingSource = dcIndustry.GetAll1();
			grdIndustry.DataSource = myBindingSource;
			grdIndustry.Columns[0].Visible = false;
			grdIndustry.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grdIndustry.Columns["Creator"].Visible = false;
			grdIndustry.Columns["CreateDate"].Visible = false;
			
			//AddtoListBox();
			//SortListBox(listBox1);
			//MessageBox.Show(grdIndustry.Rows[grdIndustry.RowCount-1].Cells[1].Value.ToString());
		}
		
		void AddtoListBox()
		{
			listBox1.Items.Clear();
			for (int i =0; i<grdIndustry.RowCount -1; i++)
				listBox1.Items.Add((object) grdIndustry.Rows[i].Cells[2].Value.ToString() + "/" + grdIndustry.Rows[i].Cells[1].Value.ToString());
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			MoveListBoxItems(listBox1, listBox2);
			SortListBox(listBox2);
			if (btnAdd.Enabled == true)
				btnAdd.Enabled = false;
		}
		
		void MoveListBoxItems(ListBox source, ListBox destination)
		{
			ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
			foreach (var item in sourceItems)
			{
				destination.Items.Add(item);
			}
			while (source.SelectedItems.Count >0)
			{
				source.Items.Remove(source.SelectedItems[0]);
			}
		}
		
		
		
		void SortListBox(ListBox source)
		{
			ArrayList q = new ArrayList();
			foreach (object o in source.Items)
				q.Add(o);
			q.Sort();
			source.Items.Clear();
			foreach (object o in q)
				source.Items.Add(o);
		}
		
		void BtnRemoveClick(object sender, EventArgs e)
		{
			MoveListBoxItems(listBox2, listBox1);			
			SortListBox(listBox1);
			if (btnRemove.Enabled == true)
				btnRemove.Enabled = false;
		}
		
		void ListBox1Click(object sender, EventArgs e)
		{
			if (btnAdd.Enabled == false)
				btnAdd.Enabled = true;
		}
		
		void ListBox2Click(object sender, EventArgs e)
		{
			if (btnRemove.Enabled == false)
				btnRemove.Enabled = true;
		}
		
		
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			BindingSource tempEng = (BindingSource)grdIndustry.DataSource;
			tempEng.Filter = "Industry_type LIKE '%" + textBox1.Text + "%' or IndustryBusiness LIKE '%" + textBox1.Text + "%'";
			grdIndustry.DataSource = tempEng;
			//grdIndustryBusiness.DataSource = null;
			
		}
		
		void AddtoListBoxfromGrd()
		{
			listBox1.Items.Clear();
			for (int i =0; i<grdIndustry.RowCount -1; i++)
			{
				int Iindex = listBox2.FindStringExact( grdIndustry.Rows[i].Cells[2].Value.ToString() + "/" + grdIndustry.Rows[i].Cells[1].Value.ToString());
				if (Iindex == -1)
					listBox1.Items.Add((object) grdIndustry.Rows[i].Cells[2].Value.ToString() + "/" + grdIndustry.Rows[i].Cells[1].Value.ToString());
			}
		}
		
		void GrdIndustryDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			AddtoListBoxfromGrd();
			SortListBox(listBox1);
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.mdiParent.UpdateMessage(listBox2);
			this.Close();
		}
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
