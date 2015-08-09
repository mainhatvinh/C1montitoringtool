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
	partial class frmC2Pineline
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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.txtPipeline_ID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbSearch = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbxClient = new System.Windows.Forms.GroupBox();
			this.cmbstatus = new System.Windows.Forms.ComboBox();
			this.dtpFYearTo = new System.Windows.Forms.DateTimePicker();
			this.dtpEYFYearTo = new System.Windows.Forms.DateTimePicker();
			this.dtpFYearFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpEYFYearFrom = new System.Windows.Forms.DateTimePicker();
			this.cmbOffice = new System.Windows.Forms.ComboBox();
			this.label27 = new System.Windows.Forms.Label();
			this.txtInfoUpdate = new System.Windows.Forms.TextBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtActPlan = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txtEngDesc = new System.Windows.Forms.TextBox();
			this.cmbClient = new System.Windows.Forms.ComboBox();
			this.label35 = new System.Windows.Forms.Label();
			this.cmbMIC = new System.Windows.Forms.ComboBox();
			this.cmbSIC = new System.Windows.Forms.ComboBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.txtFee = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.txtPIC = new System.Windows.Forms.TextBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtServicetype = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.grdC2Pineline = new System.Windows.Forms.DataGridView();
			this.mainPanel.SuspendLayout();
			this.gbxClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdC2Pineline)).BeginInit();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label10.Location = new System.Drawing.Point(125, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(510, 20);
			this.label10.TabIndex = 9;
			this.label10.Text = "Please fill in the following form to update an advisory opportunity for a client:" +
			"";
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Transparent;
			this.mainPanel.Controls.Add(this.txtPipeline_ID);
			this.mainPanel.Controls.Add(this.label6);
			this.mainPanel.Controls.Add(this.cmbSearch);
			this.mainPanel.Controls.Add(this.label10);
			this.mainPanel.Controls.Add(this.label24);
			this.mainPanel.Controls.Add(this.txtSearch);
			this.mainPanel.Controls.Add(this.label4);
			this.mainPanel.Controls.Add(this.gbxClient);
			this.mainPanel.Controls.Add(this.grdC2Pineline);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 16;
			// 
			// txtPipeline_ID
			// 
			this.txtPipeline_ID.Location = new System.Drawing.Point(12, 64);
			this.txtPipeline_ID.Name = "txtPipeline_ID";
			this.txtPipeline_ID.Size = new System.Drawing.Size(104, 20);
			this.txtPipeline_ID.TabIndex = 107;
			this.txtPipeline_ID.Visible = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(880, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 18);
			this.label6.TabIndex = 97;
			this.label6.Text = "in";
			// 
			// cmbSearch
			// 
			this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearch.FormattingEnabled = true;
			this.cmbSearch.Items.AddRange(new object[] {
									"Client Name",
									"Service Type",
									"Status",
									"MIC",
									"SIC"});
			this.cmbSearch.Location = new System.Drawing.Point(911, 60);
			this.cmbSearch.Name = "cmbSearch";
			this.cmbSearch.Size = new System.Drawing.Size(137, 21);
			this.cmbSearch.TabIndex = 83;
			this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearchSelectedIndexChanged);
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(602, 61);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(47, 23);
			this.label24.TabIndex = 64;
			this.label24.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSearch.Location = new System.Drawing.Point(679, 61);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(188, 20);
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
			this.gbxClient.Controls.Add(this.cmbstatus);
			this.gbxClient.Controls.Add(this.dtpFYearTo);
			this.gbxClient.Controls.Add(this.dtpEYFYearTo);
			this.gbxClient.Controls.Add(this.dtpFYearFrom);
			this.gbxClient.Controls.Add(this.dtpEYFYearFrom);
			this.gbxClient.Controls.Add(this.cmbOffice);
			this.gbxClient.Controls.Add(this.label27);
			this.gbxClient.Controls.Add(this.txtInfoUpdate);
			this.gbxClient.Controls.Add(this.txtStatus);
			this.gbxClient.Controls.Add(this.label3);
			this.gbxClient.Controls.Add(this.txtActPlan);
			this.gbxClient.Controls.Add(this.label26);
			this.gbxClient.Controls.Add(this.txtEngDesc);
			this.gbxClient.Controls.Add(this.cmbClient);
			this.gbxClient.Controls.Add(this.label35);
			this.gbxClient.Controls.Add(this.cmbMIC);
			this.gbxClient.Controls.Add(this.cmbSIC);
			this.gbxClient.Controls.Add(this.label34);
			this.gbxClient.Controls.Add(this.label11);
			this.gbxClient.Controls.Add(this.label33);
			this.gbxClient.Controls.Add(this.txtFee);
			this.gbxClient.Controls.Add(this.label32);
			this.gbxClient.Controls.Add(this.label25);
			this.gbxClient.Controls.Add(this.txtPIC);
			this.gbxClient.Controls.Add(this.btnDel);
			this.gbxClient.Controls.Add(this.btnReset);
			this.gbxClient.Controls.Add(this.btnSubmit);
			this.gbxClient.Controls.Add(this.label5);
			this.gbxClient.Controls.Add(this.label1);
			this.gbxClient.Controls.Add(this.label2);
			this.gbxClient.Controls.Add(this.txtServicetype);
			this.gbxClient.Controls.Add(this.label7);
			this.gbxClient.Controls.Add(this.label28);
			this.gbxClient.Controls.Add(this.label8);
			this.gbxClient.Controls.Add(this.label9);
			this.gbxClient.Controls.Add(this.label12);
			this.gbxClient.Controls.Add(this.label13);
			this.gbxClient.Location = new System.Drawing.Point(125, 90);
			this.gbxClient.Name = "gbxClient";
			this.gbxClient.Size = new System.Drawing.Size(950, 433);
			this.gbxClient.TabIndex = 22;
			this.gbxClient.TabStop = false;
			this.gbxClient.Text = "C2 Pineline";
			// 
			// cmbstatus
			// 
			this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbstatus.FormattingEnabled = true;
			this.cmbstatus.Items.AddRange(new object[] {
									"Pursuing",
									"Closed",
									"Won",
									"Lost"});
			this.cmbstatus.Location = new System.Drawing.Point(554, 300);
			this.cmbstatus.Name = "cmbstatus";
			this.cmbstatus.Size = new System.Drawing.Size(180, 21);
			this.cmbstatus.TabIndex = 120;
			// 
			// dtpFYearTo
			// 
			this.dtpFYearTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFYearTo.Location = new System.Drawing.Point(785, 157);
			this.dtpFYearTo.Name = "dtpFYearTo";
			this.dtpFYearTo.Size = new System.Drawing.Size(138, 20);
			this.dtpFYearTo.TabIndex = 119;
			// 
			// dtpEYFYearTo
			// 
			this.dtpEYFYearTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEYFYearTo.Location = new System.Drawing.Point(786, 127);
			this.dtpEYFYearTo.Name = "dtpEYFYearTo";
			this.dtpEYFYearTo.Size = new System.Drawing.Size(138, 20);
			this.dtpEYFYearTo.TabIndex = 118;
			// 
			// dtpFYearFrom
			// 
			this.dtpFYearFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFYearFrom.Location = new System.Drawing.Point(620, 157);
			this.dtpFYearFrom.Name = "dtpFYearFrom";
			this.dtpFYearFrom.Size = new System.Drawing.Size(138, 20);
			this.dtpFYearFrom.TabIndex = 117;
			// 
			// dtpEYFYearFrom
			// 
			this.dtpEYFYearFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEYFYearFrom.Location = new System.Drawing.Point(620, 127);
			this.dtpEYFYearFrom.Name = "dtpEYFYearFrom";
			this.dtpEYFYearFrom.Size = new System.Drawing.Size(138, 20);
			this.dtpEYFYearFrom.TabIndex = 116;
			// 
			// cmbOffice
			// 
			this.cmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOffice.FormattingEnabled = true;
			this.cmbOffice.Items.AddRange(new object[] {
									"Hanoi",
									"HCM",
									"Laos",
									"Cambodia",
									"Others"});
			this.cmbOffice.Location = new System.Drawing.Point(431, 59);
			this.cmbOffice.Name = "cmbOffice";
			this.cmbOffice.Size = new System.Drawing.Size(180, 21);
			this.cmbOffice.TabIndex = 107;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(493, 304);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(153, 17);
			this.label27.TabIndex = 91;
			this.label27.Text = "Status:";
			// 
			// txtInfoUpdate
			// 
			this.txtInfoUpdate.Location = new System.Drawing.Point(554, 198);
			this.txtInfoUpdate.Multiline = true;
			this.txtInfoUpdate.Name = "txtInfoUpdate";
			this.txtInfoUpdate.Size = new System.Drawing.Size(370, 89);
			this.txtInfoUpdate.TabIndex = 12;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(786, 29);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(138, 20);
			this.txtStatus.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(680, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 18);
			this.label3.TabIndex = 92;
			this.label3.Text = "Status (% to win):";
			// 
			// txtActPlan
			// 
			this.txtActPlan.Location = new System.Drawing.Point(101, 305);
			this.txtActPlan.Multiline = true;
			this.txtActPlan.Name = "txtActPlan";
			this.txtActPlan.Size = new System.Drawing.Size(374, 53);
			this.txtActPlan.TabIndex = 13;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(22, 304);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(153, 27);
			this.label26.TabIndex = 89;
			this.label26.Text = "Action plan:";
			// 
			// txtEngDesc
			// 
			this.txtEngDesc.Location = new System.Drawing.Point(100, 198);
			this.txtEngDesc.Multiline = true;
			this.txtEngDesc.Name = "txtEngDesc";
			this.txtEngDesc.Size = new System.Drawing.Size(375, 89);
			this.txtEngDesc.TabIndex = 11;
			// 
			// cmbClient
			// 
			this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClient.FormattingEnabled = true;
			this.cmbClient.Items.AddRange(new object[] {
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
			this.cmbClient.Location = new System.Drawing.Point(101, 27);
			this.cmbClient.Name = "cmbClient";
			this.cmbClient.Size = new System.Drawing.Size(510, 21);
			this.cmbClient.TabIndex = 1;
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(21, 29);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(152, 22);
			this.label35.TabIndex = 85;
			this.label35.Text = "Client (*):";
			// 
			// cmbMIC
			// 
			this.cmbMIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMIC.FormattingEnabled = true;
			this.cmbMIC.Items.AddRange(new object[] {
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
			this.cmbMIC.Location = new System.Drawing.Point(434, 92);
			this.cmbMIC.Name = "cmbMIC";
			this.cmbMIC.Size = new System.Drawing.Size(177, 21);
			this.cmbMIC.TabIndex = 7;
			// 
			// cmbSIC
			// 
			this.cmbSIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSIC.FormattingEnabled = true;
			this.cmbSIC.Items.AddRange(new object[] {
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
			this.cmbSIC.Location = new System.Drawing.Point(731, 92);
			this.cmbSIC.Name = "cmbSIC";
			this.cmbSIC.Size = new System.Drawing.Size(191, 21);
			this.cmbSIC.TabIndex = 8;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(680, 95);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(45, 22);
			this.label34.TabIndex = 81;
			this.label34.Text = "SIC:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(343, 94);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 22);
			this.label11.TabIndex = 79;
			this.label11.Text = "MIC:";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(343, 59);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(80, 27);
			this.label33.TabIndex = 78;
			this.label33.Text = "Office:";
			// 
			// txtFee
			// 
			this.txtFee.Location = new System.Drawing.Point(100, 60);
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(182, 20);
			this.txtFee.TabIndex = 3;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(21, 201);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(73, 56);
			this.label32.TabIndex = 74;
			this.label32.Text = "Opportunity description:";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(22, 61);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(72, 21);
			this.label25.TabIndex = 41;
			this.label25.Text = "Fee (VND):";
			// 
			// txtPIC
			// 
			this.txtPIC.Location = new System.Drawing.Point(100, 92);
			this.txtPIC.Multiline = true;
			this.txtPIC.Name = "txtPIC";
			this.txtPIC.Size = new System.Drawing.Size(182, 20);
			this.txtPIC.TabIndex = 6;
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDel.Location = new System.Drawing.Point(561, 374);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 51);
			this.btnDel.TabIndex = 17;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnReset.Location = new System.Drawing.Point(280, 374);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 51);
			this.btnReset.TabIndex = 15;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSubmit.Location = new System.Drawing.Point(424, 374);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 51);
			this.btnSubmit.TabIndex = 16;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 22);
			this.label5.TabIndex = 22;
			this.label5.Text = "PIC:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(493, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "EY Fiscal Year:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(493, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Year:";
			// 
			// txtServicetype
			// 
			this.txtServicetype.Location = new System.Drawing.Point(100, 127);
			this.txtServicetype.Multiline = true;
			this.txtServicetype.Name = "txtServicetype";
			this.txtServicetype.Size = new System.Drawing.Size(376, 55);
			this.txtServicetype.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(21, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 27);
			this.label7.TabIndex = 6;
			this.label7.Text = "Service type:";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(493, 201);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(66, 65);
			this.label28.TabIndex = 66;
			this.label28.Text = "Information update:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(764, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 17);
			this.label8.TabIndex = 112;
			this.label8.Text = "To:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(764, 157);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 17);
			this.label9.TabIndex = 113;
			this.label9.Text = "To:";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(584, 130);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 17);
			this.label12.TabIndex = 114;
			this.label12.Text = "From:";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(584, 157);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(62, 17);
			this.label13.TabIndex = 115;
			this.label13.Text = "From:";
			// 
			// grdC2Pineline
			// 
			this.grdC2Pineline.AllowUserToAddRows = false;
			this.grdC2Pineline.AllowUserToDeleteRows = false;
			this.grdC2Pineline.AllowUserToOrderColumns = true;
			this.grdC2Pineline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdC2Pineline.Location = new System.Drawing.Point(12, 529);
			this.grdC2Pineline.MultiSelect = false;
			this.grdC2Pineline.Name = "grdC2Pineline";
			this.grdC2Pineline.ReadOnly = true;
			this.grdC2Pineline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdC2Pineline.Size = new System.Drawing.Size(1168, 243);
			this.grdC2Pineline.TabIndex = 19;
			this.grdC2Pineline.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientCellClick);
			this.grdC2Pineline.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdClientDataBindingComplete);
			this.grdC2Pineline.SelectionChanged += new System.EventHandler(this.GrdClientSelectionChanged);
			this.grdC2Pineline.Sorted += new System.EventHandler(this.GrdClientSorted);
			// 
			// frmC2Pineline
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmC2Pineline";
			this.Text = "C2 Pineline";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.gbxClient.ResumeLayout(false);
			this.gbxClient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdC2Pineline)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbstatus;
		private System.Windows.Forms.DateTimePicker dtpEYFYearFrom;
		private System.Windows.Forms.DateTimePicker dtpFYearFrom;
		private System.Windows.Forms.DateTimePicker dtpEYFYearTo;
		private System.Windows.Forms.DateTimePicker dtpFYearTo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbOffice;
		private System.Windows.Forms.TextBox txtPipeline_ID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbSearch;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.ComboBox cmbClient;
		private System.Windows.Forms.TextBox txtEngDesc;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.ComboBox cmbSIC;
		private System.Windows.Forms.ComboBox cmbMIC;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtActPlan;
		private System.Windows.Forms.TextBox txtInfoUpdate;
		private System.Windows.Forms.TextBox txtPIC;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gbxClient;
		private System.Windows.Forms.DataGridView grdC2Pineline;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtServicetype;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
