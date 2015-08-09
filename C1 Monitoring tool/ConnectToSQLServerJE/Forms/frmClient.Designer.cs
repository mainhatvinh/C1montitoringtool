/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/17/2013
 * Time: 4:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmClient
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
			this.label10 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.grdITRAclient = new System.Windows.Forms.DataGridView();
			this.grdIndustry = new System.Windows.Forms.DataGridView();
			this.grdClientContact = new System.Windows.Forms.DataGridView();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.label24 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbxClient = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ltbBusiness = new System.Windows.Forms.ListBox();
			this.lbClientApplication = new System.Windows.Forms.ListBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.label32 = new System.Windows.Forms.Label();
			this.btnDelCon = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.txtContact_Phone = new System.Windows.Forms.TextBox();
			this.txtContact_Email = new System.Windows.Forms.TextBox();
			this.txtContact_Name = new System.Windows.Forms.TextBox();
			this.cmbPosition = new System.Windows.Forms.ComboBox();
			this.chbITRA_Client = new System.Windows.Forms.CheckBox();
			this.chbDummyCode = new System.Windows.Forms.CheckBox();
			this.label25 = new System.Windows.Forms.Label();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtClientAddress = new System.Windows.Forms.TextBox();
			this.txtClientCode = new System.Windows.Forms.TextBox();
			this.txtClientName = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.txtID_ClientContact = new System.Windows.Forms.TextBox();
			this.grdClient = new System.Windows.Forms.DataGridView();
			this.txtEmail1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtName2 = new System.Windows.Forms.TextBox();
			this.txtName1 = new System.Windows.Forms.TextBox();
			this.txtPosition3 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtPosition2 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtPosition1 = new System.Windows.Forms.TextBox();
			this.chlIndustry = new System.Windows.Forms.CheckedListBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtEmail3 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtEmail2 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtPhone3 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtPhone2 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPhone1 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdITRAclient)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdClientContact)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			this.gbxClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label10.Location = new System.Drawing.Point(125, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(510, 20);
			this.label10.TabIndex = 9;
			this.label10.Text = "Please fill in the following form to create a new client or update an existing cl" +
			"ient:";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnReset.Location = new System.Drawing.Point(153, 350);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 39);
			this.btnReset.TabIndex = 18;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDel.Location = new System.Drawing.Point(440, 350);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 39);
			this.btnDel.TabIndex = 20;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSubmit.Location = new System.Drawing.Point(297, 350);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 39);
			this.btnSubmit.TabIndex = 19;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Transparent;
			this.mainPanel.Controls.Add(this.grdITRAclient);
			this.mainPanel.Controls.Add(this.grdIndustry);
			this.mainPanel.Controls.Add(this.grdClientContact);
			this.mainPanel.Controls.Add(this.label10);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Controls.Add(this.label24);
			this.mainPanel.Controls.Add(this.txtSearch);
			this.mainPanel.Controls.Add(this.label4);
			this.mainPanel.Controls.Add(this.gbxClient);
			this.mainPanel.Controls.Add(this.grdClient);
			this.mainPanel.Controls.Add(this.txtEmail1);
			this.mainPanel.Controls.Add(this.label3);
			this.mainPanel.Controls.Add(this.txtName3);
			this.mainPanel.Controls.Add(this.label6);
			this.mainPanel.Controls.Add(this.txtName2);
			this.mainPanel.Controls.Add(this.txtName1);
			this.mainPanel.Controls.Add(this.txtPosition3);
			this.mainPanel.Controls.Add(this.label12);
			this.mainPanel.Controls.Add(this.txtPosition2);
			this.mainPanel.Controls.Add(this.label13);
			this.mainPanel.Controls.Add(this.txtPosition1);
			this.mainPanel.Controls.Add(this.chlIndustry);
			this.mainPanel.Controls.Add(this.label14);
			this.mainPanel.Controls.Add(this.txtEmail3);
			this.mainPanel.Controls.Add(this.label15);
			this.mainPanel.Controls.Add(this.txtEmail2);
			this.mainPanel.Controls.Add(this.label16);
			this.mainPanel.Controls.Add(this.label17);
			this.mainPanel.Controls.Add(this.txtPhone3);
			this.mainPanel.Controls.Add(this.label18);
			this.mainPanel.Controls.Add(this.txtPhone2);
			this.mainPanel.Controls.Add(this.label19);
			this.mainPanel.Controls.Add(this.txtPhone1);
			this.mainPanel.Controls.Add(this.label20);
			this.mainPanel.Controls.Add(this.label23);
			this.mainPanel.Controls.Add(this.label21);
			this.mainPanel.Controls.Add(this.label22);
			this.mainPanel.Controls.Add(this.label9);
			this.mainPanel.Controls.Add(this.label8);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 16;
			this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanelPaint);
			// 
			// grdITRAclient
			// 
			this.grdITRAclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdITRAclient.Location = new System.Drawing.Point(1103, 40);
			this.grdITRAclient.Name = "grdITRAclient";
			this.grdITRAclient.Size = new System.Drawing.Size(72, 22);
			this.grdITRAclient.TabIndex = 68;
			this.grdITRAclient.Visible = false;
			// 
			// grdIndustry
			// 
			this.grdIndustry.AllowUserToAddRows = false;
			this.grdIndustry.AllowUserToDeleteRows = false;
			this.grdIndustry.AllowUserToOrderColumns = true;
			this.grdIndustry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdIndustry.Location = new System.Drawing.Point(387, 3);
			this.grdIndustry.MultiSelect = false;
			this.grdIndustry.Name = "grdIndustry";
			this.grdIndustry.ReadOnly = true;
			this.grdIndustry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdIndustry.Size = new System.Drawing.Size(517, 75);
			this.grdIndustry.TabIndex = 67;
			this.grdIndustry.Visible = false;
			// 
			// grdClientContact
			// 
			this.grdClientContact.AllowUserToAddRows = false;
			this.grdClientContact.AllowUserToDeleteRows = false;
			this.grdClientContact.AllowUserToOrderColumns = true;
			this.grdClientContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClientContact.Location = new System.Drawing.Point(778, 303);
			this.grdClientContact.MultiSelect = false;
			this.grdClientContact.Name = "grdClientContact";
			this.grdClientContact.ReadOnly = true;
			this.grdClientContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdClientContact.Size = new System.Drawing.Size(325, 176);
			this.grdClientContact.TabIndex = 66;
			this.grdClientContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientContactCellClick);
			this.grdClientContact.SelectionChanged += new System.EventHandler(this.GrdClientContactSelectionChanged);
			// 
			// grdTemp
			// 
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(1108, 12);
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.Size = new System.Drawing.Size(72, 22);
			this.grdTemp.TabIndex = 65;
			this.grdTemp.Visible = false;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(764, 58);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(47, 23);
			this.label24.TabIndex = 64;
			this.label24.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSearch.Location = new System.Drawing.Point(841, 58);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(208, 20);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(125, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 23);
			this.label4.TabIndex = 23;
			this.label4.Text = "*: Fields with * are mandatory";
			// 
			// gbxClient
			// 
			this.gbxClient.Controls.Add(this.button1);
			this.gbxClient.Controls.Add(this.ltbBusiness);
			this.gbxClient.Controls.Add(this.lbClientApplication);
			this.gbxClient.Controls.Add(this.btnClear);
			this.gbxClient.Controls.Add(this.label32);
			this.gbxClient.Controls.Add(this.btnDelCon);
			this.gbxClient.Controls.Add(this.btnAdd);
			this.gbxClient.Controls.Add(this.label31);
			this.gbxClient.Controls.Add(this.txtContact_Phone);
			this.gbxClient.Controls.Add(this.txtContact_Email);
			this.gbxClient.Controls.Add(this.txtContact_Name);
			this.gbxClient.Controls.Add(this.cmbPosition);
			this.gbxClient.Controls.Add(this.chbITRA_Client);
			this.gbxClient.Controls.Add(this.chbDummyCode);
			this.gbxClient.Controls.Add(this.label25);
			this.gbxClient.Controls.Add(this.txtRemarks);
			this.gbxClient.Controls.Add(this.cmbCountry);
			this.gbxClient.Controls.Add(this.btnDel);
			this.gbxClient.Controls.Add(this.btnReset);
			this.gbxClient.Controls.Add(this.btnSubmit);
			this.gbxClient.Controls.Add(this.label5);
			this.gbxClient.Controls.Add(this.label1);
			this.gbxClient.Controls.Add(this.label2);
			this.gbxClient.Controls.Add(this.label7);
			this.gbxClient.Controls.Add(this.label11);
			this.gbxClient.Controls.Add(this.txtClientAddress);
			this.gbxClient.Controls.Add(this.txtClientCode);
			this.gbxClient.Controls.Add(this.txtClientName);
			this.gbxClient.Controls.Add(this.label27);
			this.gbxClient.Controls.Add(this.label29);
			this.gbxClient.Controls.Add(this.label26);
			this.gbxClient.Controls.Add(this.label30);
			this.gbxClient.Controls.Add(this.label28);
			this.gbxClient.Controls.Add(this.txtID_ClientContact);
			this.gbxClient.Location = new System.Drawing.Point(125, 90);
			this.gbxClient.Name = "gbxClient";
			this.gbxClient.Size = new System.Drawing.Size(1002, 404);
			this.gbxClient.TabIndex = 22;
			this.gbxClient.TabStop = false;
			this.gbxClient.Text = "Client";
			this.gbxClient.Enter += new System.EventHandler(this.GbxClientEnter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 85);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 80;
			this.button1.Text = "Mapping";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// ltbBusiness
			// 
			this.ltbBusiness.FormattingEnabled = true;
			this.ltbBusiness.Location = new System.Drawing.Point(180, 63);
			this.ltbBusiness.Name = "ltbBusiness";
			this.ltbBusiness.Size = new System.Drawing.Size(309, 82);
			this.ltbBusiness.TabIndex = 4;
			// 
			// lbClientApplication
			// 
			this.lbClientApplication.FormattingEnabled = true;
			this.lbClientApplication.Location = new System.Drawing.Point(179, 154);
			this.lbClientApplication.Name = "lbClientApplication";
			this.lbClientApplication.Size = new System.Drawing.Size(310, 56);
			this.lbClientApplication.TabIndex = 7;
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnClear.Location = new System.Drawing.Point(527, 262);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(85, 20);
			this.btnClear.TabIndex = 73;
			this.btnClear.Text = "Clear contact";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(22, 154);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(153, 27);
			this.label32.TabIndex = 74;
			this.label32.Text = "Application list:";
			// 
			// btnDelCon
			// 
			this.btnDelCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDelCon.Location = new System.Drawing.Point(527, 289);
			this.btnDelCon.Name = "btnDelCon";
			this.btnDelCon.Size = new System.Drawing.Size(85, 20);
			this.btnDelCon.TabIndex = 76;
			this.btnDelCon.Text = "Delete contact";
			this.btnDelCon.UseVisualStyleBackColor = true;
			this.btnDelCon.Click += new System.EventHandler(this.BtnDelConClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnAdd.Location = new System.Drawing.Point(527, 235);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(85, 20);
			this.btnAdd.TabIndex = 72;
			this.btnAdd.Text = "Add contact";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(508, 212);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(139, 18);
			this.label31.TabIndex = 70;
			this.label31.Text = "Client Contact List:";
			this.label31.Visible = false;
			// 
			// txtContact_Phone
			// 
			this.txtContact_Phone.Location = new System.Drawing.Point(298, 315);
			this.txtContact_Phone.Name = "txtContact_Phone";
			this.txtContact_Phone.Size = new System.Drawing.Size(191, 20);
			this.txtContact_Phone.TabIndex = 12;
			// 
			// txtContact_Email
			// 
			this.txtContact_Email.Location = new System.Drawing.Point(298, 273);
			this.txtContact_Email.Name = "txtContact_Email";
			this.txtContact_Email.Size = new System.Drawing.Size(191, 20);
			this.txtContact_Email.TabIndex = 11;
			// 
			// txtContact_Name
			// 
			this.txtContact_Name.Location = new System.Drawing.Point(298, 234);
			this.txtContact_Name.Name = "txtContact_Name";
			this.txtContact_Name.Size = new System.Drawing.Size(191, 20);
			this.txtContact_Name.TabIndex = 10;
			// 
			// cmbPosition
			// 
			this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPosition.FormattingEnabled = true;
			this.cmbPosition.Location = new System.Drawing.Point(76, 233);
			this.cmbPosition.Name = "cmbPosition";
			this.cmbPosition.Size = new System.Drawing.Size(215, 21);
			this.cmbPosition.TabIndex = 9;
			// 
			// chbITRA_Client
			// 
			this.chbITRA_Client.Location = new System.Drawing.Point(334, 32);
			this.chbITRA_Client.Name = "chbITRA_Client";
			this.chbITRA_Client.Size = new System.Drawing.Size(104, 24);
			this.chbITRA_Client.TabIndex = 2;
			this.chbITRA_Client.Text = "ITRA client";
			this.chbITRA_Client.UseVisualStyleBackColor = true;
			this.chbITRA_Client.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// chbDummyCode
			// 
			this.chbDummyCode.Location = new System.Drawing.Point(334, 11);
			this.chbDummyCode.Name = "chbDummyCode";
			this.chbDummyCode.Size = new System.Drawing.Size(104, 24);
			this.chbDummyCode.TabIndex = 1;
			this.chbDummyCode.Text = "Dummy Code";
			this.chbDummyCode.UseVisualStyleBackColor = true;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(508, 137);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(90, 27);
			this.label25.TabIndex = 41;
			this.label25.Text = "Remarks:";
			// 
			// txtRemarks
			// 
			this.txtRemarks.Location = new System.Drawing.Point(653, 137);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(325, 66);
			this.txtRemarks.TabIndex = 8;
			// 
			// cmbCountry
			// 
			this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCountry.FormattingEnabled = true;
			this.cmbCountry.Items.AddRange(new object[] {
									"Afghanistan",
									"Albania",
									"Algeria",
									"Andorra",
									"Angola",
									"Antigua and Barbuda",
									"Argentina",
									"Armenia",
									"Aruba",
									"Australia",
									"Austria",
									"Azerbaijan",
									"Bahamas, The",
									"Bahrain",
									"Bangladesh",
									"Barbados",
									"Belarus",
									"Belgium",
									"Belize",
									"Benin",
									"Bhutan",
									"Bolivia",
									"Bosnia and Herzegovina",
									"Botswana",
									"Brazil",
									"Brunei ",
									"Bulgaria",
									"Burkina Faso",
									"Burma",
									"Burundi",
									"Cambodia",
									"Cameroon",
									"Canada",
									"Cape Verde",
									"Central African Republic",
									"Chad",
									"Chile",
									"China",
									"Colombia",
									"Comoros",
									"Congo, Democratic Republic of the",
									"Congo, Republic of the",
									"Costa Rica",
									"Cote d\'Ivoire",
									"Croatia",
									"Cuba",
									"Curacao",
									"Cyprus",
									"Czech Republic",
									"Denmark",
									"Djibouti",
									"Dominica",
									"Dominican Republic",
									"East Timor",
									"Ecuador",
									"Egypt",
									"El Salvador",
									"Equatorial Guinea",
									"Eritrea",
									"Estonia",
									"Ethiopia",
									"Fiji",
									"Finland",
									"France",
									"Gabon",
									"Gambia, The",
									"Georgia",
									"Germany",
									"Ghana",
									"Greece",
									"Grenada",
									"Guatemala",
									"Guinea",
									"Guinea-Bissau",
									"Guyana",
									"Haiti",
									"Holy See",
									"Honduras",
									"Hong Kong",
									"Hungary",
									"Iceland",
									"India",
									"Indonesia",
									"Iran",
									"Iraq",
									"Ireland",
									"Israel",
									"Italy",
									"Jamaica",
									"Japan",
									"Jordan",
									"Kazakhstan",
									"Kenya",
									"Kiribati",
									"Korea, North",
									"Korea, South",
									"Kosovo",
									"Kuwait",
									"Kyrgyzstan",
									"Laos",
									"Latvia",
									"Lebanon",
									"Lesotho",
									"Liberia",
									"Libya",
									"Liechtenstein",
									"Lithuania",
									"Luxembourg",
									"Macau",
									"Macedonia",
									"Madagascar",
									"Malawi",
									"Malaysia",
									"Maldives",
									"Mali",
									"Malta",
									"Marshall Islands",
									"Mauritania",
									"Mauritius",
									"Mexico",
									"Micronesia",
									"Moldova",
									"Monaco",
									"Mongolia",
									"Montenegro",
									"Morocco",
									"Mozambique",
									"Namibia",
									"Nauru",
									"Nepal",
									"Netherlands",
									"Netherlands Antilles",
									"New Zealand",
									"Nicaragua",
									"Niger",
									"Nigeria",
									"North Korea",
									"Norway",
									"Oman",
									" Pakistan",
									"Palau",
									"Palestinian Territories",
									"Panama",
									"Papua New Guinea",
									"Paraguay",
									"Peru",
									"Philippines",
									"Poland",
									"Portugal",
									"Qatar",
									" Romania",
									"Russia",
									"Rwanda",
									"Saint Kitts and Nevis",
									"Saint Lucia",
									"Saint Vincent and the Grenadines",
									"Samoa ",
									"San Marino",
									"Sao Tome and Principe",
									"Saudi Arabia",
									"Senegal",
									"Serbia",
									"Seychelles",
									"Sierra Leone",
									"Singapore",
									"Sint Maarten",
									"Slovakia",
									"Slovenia",
									"Solomon Islands",
									"Somalia",
									"South Africa",
									"South Korea",
									"South Sudan",
									"Spain ",
									"Sri Lanka",
									"Sudan",
									"Suriname",
									"Swaziland ",
									"Sweden",
									"Switzerland",
									"Syria",
									"Taiwan",
									"Tajikistan",
									"Tanzania",
									"Thailand ",
									"Timor-Leste",
									"Togo",
									"Tonga",
									"Trinidad and Tobago",
									"Tunisia",
									"Turkey",
									"Turkmenistan",
									"Tuvalu",
									"Uganda",
									"Ukraine",
									"United Arab Emirates",
									"United Kingdom",
									"Uruguay",
									"Uzbekistan",
									"Vanuatu",
									"Venezuela",
									"Vietnam",
									"Yemen",
									"Zambia",
									"Zimbabwe"});
			this.cmbCountry.Location = new System.Drawing.Point(653, 60);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(325, 21);
			this.cmbCountry.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 22);
			this.label5.TabIndex = 22;
			this.label5.Text = "Business Industry:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Client Code (*):";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(508, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Client Name (*):";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(508, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 27);
			this.label7.TabIndex = 6;
			this.label7.Text = "Address:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(508, 60);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(153, 27);
			this.label11.TabIndex = 21;
			this.label11.Text = "Country (*):";
			// 
			// txtClientAddress
			// 
			this.txtClientAddress.Location = new System.Drawing.Point(653, 98);
			this.txtClientAddress.Name = "txtClientAddress";
			this.txtClientAddress.Size = new System.Drawing.Size(325, 20);
			this.txtClientAddress.TabIndex = 6;
			// 
			// txtClientCode
			// 
			this.txtClientCode.Location = new System.Drawing.Point(180, 24);
			this.txtClientCode.Name = "txtClientCode";
			this.txtClientCode.Size = new System.Drawing.Size(142, 20);
			this.txtClientCode.TabIndex = 0;
			// 
			// txtClientName
			// 
			this.txtClientName.Location = new System.Drawing.Point(653, 24);
			this.txtClientName.Name = "txtClientName";
			this.txtClientName.Size = new System.Drawing.Size(325, 20);
			this.txtClientName.TabIndex = 3;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(24, 234);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(68, 23);
			this.label27.TabIndex = 66;
			this.label27.Text = "Position:";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(298, 257);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(42, 23);
			this.label29.TabIndex = 67;
			this.label29.Text = "Email:";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(298, 212);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(68, 18);
			this.label26.TabIndex = 66;
			this.label26.Text = "Name:";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(298, 299);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(52, 23);
			this.label30.TabIndex = 68;
			this.label30.Text = "Phone:";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(21, 212);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(153, 27);
			this.label28.TabIndex = 66;
			this.label28.Text = "Client Contact Person:";
			// 
			// txtID_ClientContact
			// 
			this.txtID_ClientContact.Location = new System.Drawing.Point(298, 247);
			this.txtID_ClientContact.Name = "txtID_ClientContact";
			this.txtID_ClientContact.Size = new System.Drawing.Size(191, 20);
			this.txtID_ClientContact.TabIndex = 77;
			this.txtID_ClientContact.Visible = false;
			// 
			// grdClient
			// 
			this.grdClient.AllowUserToAddRows = false;
			this.grdClient.AllowUserToDeleteRows = false;
			this.grdClient.AllowUserToOrderColumns = true;
			this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClient.Location = new System.Drawing.Point(125, 500);
			this.grdClient.MultiSelect = false;
			this.grdClient.Name = "grdClient";
			this.grdClient.ReadOnly = true;
			this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdClient.Size = new System.Drawing.Size(1002, 272);
			this.grdClient.TabIndex = 21;
			this.grdClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientCellClick);
			this.grdClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientCellContentClick);
			this.grdClient.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdClientDataBindingComplete);
			this.grdClient.SelectionChanged += new System.EventHandler(this.GrdClientSelectionChanged);
			this.grdClient.Sorted += new System.EventHandler(this.GrdClientSorted);
			// 
			// txtEmail1
			// 
			this.txtEmail1.Location = new System.Drawing.Point(922, 599);
			this.txtEmail1.Name = "txtEmail1";
			this.txtEmail1.Size = new System.Drawing.Size(181, 20);
			this.txtEmail1.TabIndex = 8;
			this.txtEmail1.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(376, 569);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "Client Contact Person:";
			this.label3.Visible = false;
			// 
			// txtName3
			// 
			this.txtName3.Location = new System.Drawing.Point(479, 665);
			this.txtName3.Name = "txtName3";
			this.txtName3.Size = new System.Drawing.Size(178, 20);
			this.txtName3.TabIndex = 14;
			this.txtName3.Visible = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(387, 602);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 23);
			this.label6.TabIndex = 24;
			this.label6.Text = "Contact 1:";
			this.label6.Visible = false;
			// 
			// txtName2
			// 
			this.txtName2.Location = new System.Drawing.Point(479, 633);
			this.txtName2.Name = "txtName2";
			this.txtName2.Size = new System.Drawing.Size(178, 20);
			this.txtName2.TabIndex = 10;
			this.txtName2.Visible = false;
			// 
			// txtName1
			// 
			this.txtName1.Location = new System.Drawing.Point(479, 599);
			this.txtName1.Name = "txtName1";
			this.txtName1.Size = new System.Drawing.Size(178, 20);
			this.txtName1.TabIndex = 6;
			this.txtName1.Visible = false;
			// 
			// txtPosition3
			// 
			this.txtPosition3.Location = new System.Drawing.Point(721, 665);
			this.txtPosition3.Name = "txtPosition3";
			this.txtPosition3.Size = new System.Drawing.Size(147, 20);
			this.txtPosition3.TabIndex = 15;
			this.txtPosition3.Visible = false;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(886, 602);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 23);
			this.label12.TabIndex = 27;
			this.label12.Text = "Email:";
			this.label12.Visible = false;
			// 
			// txtPosition2
			// 
			this.txtPosition2.Location = new System.Drawing.Point(721, 633);
			this.txtPosition2.Name = "txtPosition2";
			this.txtPosition2.Size = new System.Drawing.Size(147, 20);
			this.txtPosition2.TabIndex = 11;
			this.txtPosition2.Visible = false;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(1123, 602);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(52, 23);
			this.label13.TabIndex = 28;
			this.label13.Text = "Phone:";
			this.label13.Visible = false;
			// 
			// txtPosition1
			// 
			this.txtPosition1.Location = new System.Drawing.Point(721, 599);
			this.txtPosition1.Name = "txtPosition1";
			this.txtPosition1.Size = new System.Drawing.Size(147, 20);
			this.txtPosition1.TabIndex = 7;
			this.txtPosition1.Visible = false;
			// 
			// chlIndustry
			// 
			this.chlIndustry.CheckOnClick = true;
			this.chlIndustry.FormattingEnabled = true;
			this.chlIndustry.Location = new System.Drawing.Point(30, 61);
			this.chlIndustry.Name = "chlIndustry";
			this.chlIndustry.Size = new System.Drawing.Size(59, 94);
			this.chlIndustry.TabIndex = 3;
			this.chlIndustry.Visible = false;
			this.chlIndustry.SelectedIndexChanged += new System.EventHandler(this.ChlIndustrySelectedIndexChanged);
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(886, 636);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 23);
			this.label14.TabIndex = 29;
			this.label14.Text = "Email:";
			this.label14.Visible = false;
			// 
			// txtEmail3
			// 
			this.txtEmail3.Location = new System.Drawing.Point(922, 665);
			this.txtEmail3.Name = "txtEmail3";
			this.txtEmail3.Size = new System.Drawing.Size(181, 20);
			this.txtEmail3.TabIndex = 16;
			this.txtEmail3.Visible = false;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(387, 636);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(57, 23);
			this.label15.TabIndex = 30;
			this.label15.Text = "Contact 2:";
			this.label15.Visible = false;
			// 
			// txtEmail2
			// 
			this.txtEmail2.Location = new System.Drawing.Point(922, 633);
			this.txtEmail2.Name = "txtEmail2";
			this.txtEmail2.Size = new System.Drawing.Size(181, 20);
			this.txtEmail2.TabIndex = 12;
			this.txtEmail2.Visible = false;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(387, 668);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(57, 23);
			this.label16.TabIndex = 31;
			this.label16.Text = "Contact 3:";
			this.label16.Visible = false;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(674, 636);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(68, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "Position:";
			this.label17.Visible = false;
			// 
			// txtPhone3
			// 
			this.txtPhone3.Location = new System.Drawing.Point(1172, 665);
			this.txtPhone3.Name = "txtPhone3";
			this.txtPhone3.Size = new System.Drawing.Size(105, 20);
			this.txtPhone3.TabIndex = 17;
			this.txtPhone3.Visible = false;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(674, 668);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(68, 23);
			this.label18.TabIndex = 33;
			this.label18.Text = "Position:";
			this.label18.Visible = false;
			// 
			// txtPhone2
			// 
			this.txtPhone2.Location = new System.Drawing.Point(1172, 633);
			this.txtPhone2.Name = "txtPhone2";
			this.txtPhone2.Size = new System.Drawing.Size(105, 20);
			this.txtPhone2.TabIndex = 13;
			this.txtPhone2.Visible = false;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(443, 636);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(68, 23);
			this.label19.TabIndex = 34;
			this.label19.Text = "Name:";
			this.label19.Visible = false;
			// 
			// txtPhone1
			// 
			this.txtPhone1.Location = new System.Drawing.Point(1172, 599);
			this.txtPhone1.Name = "txtPhone1";
			this.txtPhone1.Size = new System.Drawing.Size(105, 20);
			this.txtPhone1.TabIndex = 9;
			this.txtPhone1.Visible = false;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(443, 668);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 23);
			this.label20.TabIndex = 35;
			this.label20.Text = "Name:";
			this.label20.Visible = false;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(1123, 668);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(52, 23);
			this.label23.TabIndex = 38;
			this.label23.Text = "Phone:";
			this.label23.Visible = false;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(886, 668);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(42, 23);
			this.label21.TabIndex = 36;
			this.label21.Text = "Email:";
			this.label21.Visible = false;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(1123, 636);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(52, 23);
			this.label22.TabIndex = 37;
			this.label22.Text = "Phone:";
			this.label22.Visible = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(674, 602);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 23);
			this.label9.TabIndex = 26;
			this.label9.Text = "Position:";
			this.label9.Visible = false;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(443, 599);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 23);
			this.label8.TabIndex = 25;
			this.label8.Text = "Name:";
			this.label8.Visible = false;
			// 
			// frmClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmClient";
			this.Text = "Client";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdITRAclient)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdIndustry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdClientContact)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.gbxClient.ResumeLayout(false);
			this.gbxClient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView grdITRAclient;
		private System.Windows.Forms.DataGridView grdIndustry;
		private System.Windows.Forms.ListBox ltbBusiness;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox lbClientApplication;
		private System.Windows.Forms.TextBox txtID_ClientContact;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView grdClientContact;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelCon;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.ComboBox cmbPosition;
		private System.Windows.Forms.TextBox txtContact_Name;
		private System.Windows.Forms.TextBox txtContact_Email;
		private System.Windows.Forms.TextBox txtContact_Phone;
		private System.Windows.Forms.CheckBox chbITRA_Client;
		private System.Windows.Forms.CheckBox chbDummyCode;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.CheckedListBox chlIndustry;
		private System.Windows.Forms.TextBox txtPhone1;
		private System.Windows.Forms.TextBox txtPhone2;
		private System.Windows.Forms.TextBox txtPhone3;
		private System.Windows.Forms.TextBox txtEmail1;
		private System.Windows.Forms.TextBox txtEmail2;
		private System.Windows.Forms.TextBox txtEmail3;
		private System.Windows.Forms.TextBox txtPosition1;
		private System.Windows.Forms.TextBox txtPosition2;
		private System.Windows.Forms.TextBox txtPosition3;
		private System.Windows.Forms.TextBox txtName1;
		private System.Windows.Forms.TextBox txtName2;
		private System.Windows.Forms.TextBox txtName3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gbxClient;
		private System.Windows.Forms.DataGridView grdClient;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtClientCode;
		private System.Windows.Forms.TextBox txtClientName;
		private System.Windows.Forms.TextBox txtClientAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
