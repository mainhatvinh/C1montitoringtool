/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/20/2013
 * Time: 2:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmIndustry
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.grdIndustryBusiness = new System.Windows.Forms.DataGridView();
			this.grdIndustryType = new System.Windows.Forms.DataGridView();
			this.label28 = new System.Windows.Forms.Label();
			this.cmbSearch = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.txtIndustryID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.grdIndustry = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtBusiness = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustryBusiness)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustryType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustry)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(281, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Industry Type (*):";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(281, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Industry Business (*):";
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdIndustryBusiness);
			this.mainPanel.Controls.Add(this.grdIndustryType);
			this.mainPanel.Controls.Add(this.label28);
			this.mainPanel.Controls.Add(this.cmbSearch);
			this.mainPanel.Controls.Add(this.label17);
			this.mainPanel.Controls.Add(this.txtSearch);
			this.mainPanel.Controls.Add(this.txtIndustryID);
			this.mainPanel.Controls.Add(this.label3);
			this.mainPanel.Controls.Add(this.label5);
			this.mainPanel.Controls.Add(this.grdIndustry);
			this.mainPanel.Controls.Add(this.label10);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 5;
			// 
			// grdIndustryBusiness
			// 
			this.grdIndustryBusiness.AllowUserToAddRows = false;
			this.grdIndustryBusiness.AllowUserToDeleteRows = false;
			this.grdIndustryBusiness.AllowUserToOrderColumns = true;
			this.grdIndustryBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdIndustryBusiness.Location = new System.Drawing.Point(605, 321);
			this.grdIndustryBusiness.MultiSelect = false;
			this.grdIndustryBusiness.Name = "grdIndustryBusiness";
			this.grdIndustryBusiness.ReadOnly = true;
			this.grdIndustryBusiness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdIndustryBusiness.Size = new System.Drawing.Size(470, 407);
			this.grdIndustryBusiness.TabIndex = 70;
			this.grdIndustryBusiness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdIndustryBusinessCellClick);
			this.grdIndustryBusiness.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdIndustryBusinessDataBindingComplete);
			this.grdIndustryBusiness.SelectionChanged += new System.EventHandler(this.GrdIndustryBusinessSelectionChanged);
			this.grdIndustryBusiness.Sorted += new System.EventHandler(this.GrdIndustryBusinessSorted);
			// 
			// grdIndustryType
			// 
			this.grdIndustryType.AllowUserToAddRows = false;
			this.grdIndustryType.AllowUserToDeleteRows = false;
			this.grdIndustryType.AllowUserToOrderColumns = true;
			this.grdIndustryType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdIndustryType.Location = new System.Drawing.Point(126, 321);
			this.grdIndustryType.MultiSelect = false;
			this.grdIndustryType.Name = "grdIndustryType";
			this.grdIndustryType.ReadOnly = true;
			this.grdIndustryType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdIndustryType.Size = new System.Drawing.Size(445, 407);
			this.grdIndustryType.TabIndex = 69;
			this.grdIndustryType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdIndustryTypeCellClick);
			this.grdIndustryType.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdIndustryTypeDataBindingComplete);
			this.grdIndustryType.SelectionChanged += new System.EventHandler(this.GrdIndustryTypeSelectionChanged);
			this.grdIndustryType.Sorted += new System.EventHandler(this.GrdIndustryTypeSorted);
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(983, 61);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(166, 23);
			this.label28.TabIndex = 68;
			this.label28.Text = "in Industry Type";
			// 
			// cmbSearch
			// 
			this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearch.FormattingEnabled = true;
			this.cmbSearch.Items.AddRange(new object[] {
									"Industry Business",
									"Industry Type"});
			this.cmbSearch.Location = new System.Drawing.Point(622, 6);
			this.cmbSearch.Name = "cmbSearch";
			this.cmbSearch.Size = new System.Drawing.Size(143, 21);
			this.cmbSearch.TabIndex = 67;
			this.cmbSearch.Visible = false;
			this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearchSelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(782, 61);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 23);
			this.label17.TabIndex = 66;
			this.label17.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSearch.Location = new System.Drawing.Point(835, 58);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(140, 20);
			this.txtSearch.TabIndex = 65;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// txtIndustryID
			// 
			this.txtIndustryID.Location = new System.Drawing.Point(907, 12);
			this.txtIndustryID.Name = "txtIndustryID";
			this.txtIndustryID.ReadOnly = true;
			this.txtIndustryID.Size = new System.Drawing.Size(168, 20);
			this.txtIndustryID.TabIndex = 7;
			this.txtIndustryID.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(771, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Industry ID:";
			this.label3.Visible = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(125, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 23);
			this.label5.TabIndex = 27;
			this.label5.Text = "*: Fields with * are mandatory";
			// 
			// grdIndustry
			// 
			this.grdIndustry.AllowUserToAddRows = false;
			this.grdIndustry.AllowUserToDeleteRows = false;
			this.grdIndustry.AllowUserToOrderColumns = true;
			this.grdIndustry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdIndustry.Location = new System.Drawing.Point(12, 478);
			this.grdIndustry.MultiSelect = false;
			this.grdIndustry.Name = "grdIndustry";
			this.grdIndustry.ReadOnly = true;
			this.grdIndustry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdIndustry.Size = new System.Drawing.Size(108, 263);
			this.grdIndustry.TabIndex = 6;
			this.grdIndustry.Visible = false;
			this.grdIndustry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdIndustryCellClick);
			this.grdIndustry.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdIndustryDataBindingComplete);
			this.grdIndustry.SelectionChanged += new System.EventHandler(this.GrdIndustrySelectionChanged);
			this.grdIndustry.Sorted += new System.EventHandler(this.GrdIndustrySorted);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label10.Location = new System.Drawing.Point(125, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(548, 24);
			this.label10.TabIndex = 10;
			this.label10.Text = "Please fill in the following form to create a new industry or update an existing " +
			"industry:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtBusiness);
			this.groupBox1.Controls.Add(this.txtType);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(125, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 208);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Industry";
			// 
			// txtBusiness
			// 
			this.txtBusiness.Location = new System.Drawing.Point(452, 73);
			this.txtBusiness.Name = "txtBusiness";
			this.txtBusiness.Size = new System.Drawing.Size(252, 20);
			this.txtBusiness.TabIndex = 2;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(452, 29);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(252, 20);
			this.txtType.TabIndex = 1;
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDel.Location = new System.Drawing.Point(619, 132);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 51);
			this.btnDel.TabIndex = 5;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnReset.Location = new System.Drawing.Point(280, 132);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 51);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSubmit.Location = new System.Drawing.Point(452, 132);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 51);
			this.btnSubmit.TabIndex = 4;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// frmIndustry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmIndustry";
			this.Text = "Industry";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustryBusiness)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustryType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustry)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView grdIndustryType;
		private System.Windows.Forms.DataGridView grdIndustryBusiness;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cmbSearch;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIndustryID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView grdIndustry;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.TextBox txtBusiness;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
