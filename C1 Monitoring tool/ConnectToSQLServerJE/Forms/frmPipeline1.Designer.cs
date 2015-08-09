/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/17/2013
 * Time: 4:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmPipeline1
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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.txtPipeline_ID = new System.Windows.Forms.TextBox();
			this.grdPipeline = new System.Windows.Forms.DataGridView();
			this.Pipeline = new System.Windows.Forms.GroupBox();
			this.cmbOffice = new System.Windows.Forms.ComboBox();
			this.cmbClientYear = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbDecision = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtInfoUpdated = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtEngDes = new System.Windows.Forms.TextBox();
			this.txtService = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btnDel = new System.Windows.Forms.Button();
			this.txtActPlan = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtFee = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbClientName = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbFY = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.cmbMIC = new System.Windows.Forms.ComboBox();
			this.cmbPIC = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbSIC = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grdTemp = new System.Windows.Forms.DataGridView();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPipeline)).BeginInit();
			this.Pipeline.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.txtPipeline_ID);
			this.mainPanel.Controls.Add(this.grdPipeline);
			this.mainPanel.Controls.Add(this.Pipeline);
			this.mainPanel.Controls.Add(this.grdTemp);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 13;
			// 
			// txtPipeline_ID
			// 
			this.txtPipeline_ID.Location = new System.Drawing.Point(12, 54);
			this.txtPipeline_ID.Name = "txtPipeline_ID";
			this.txtPipeline_ID.Size = new System.Drawing.Size(104, 20);
			this.txtPipeline_ID.TabIndex = 106;
			// 
			// grdPipeline
			// 
			this.grdPipeline.AllowUserToAddRows = false;
			this.grdPipeline.AllowUserToDeleteRows = false;
			this.grdPipeline.AllowUserToOrderColumns = true;
			this.grdPipeline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPipeline.Location = new System.Drawing.Point(140, 428);
			this.grdPipeline.MultiSelect = false;
			this.grdPipeline.Name = "grdPipeline";
			this.grdPipeline.ReadOnly = true;
			this.grdPipeline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPipeline.Size = new System.Drawing.Size(970, 338);
			this.grdPipeline.TabIndex = 102;
			this.grdPipeline.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPipelineCellClick);
			this.grdPipeline.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdPipelineDataBindingComplete);
			// 
			// Pipeline
			// 
			this.Pipeline.Controls.Add(this.cmbOffice);
			this.Pipeline.Controls.Add(this.cmbClientYear);
			this.Pipeline.Controls.Add(this.label15);
			this.Pipeline.Controls.Add(this.cmbDecision);
			this.Pipeline.Controls.Add(this.label10);
			this.Pipeline.Controls.Add(this.label8);
			this.Pipeline.Controls.Add(this.txtInfoUpdated);
			this.Pipeline.Controls.Add(this.label12);
			this.Pipeline.Controls.Add(this.txtEngDes);
			this.Pipeline.Controls.Add(this.txtService);
			this.Pipeline.Controls.Add(this.label13);
			this.Pipeline.Controls.Add(this.label14);
			this.Pipeline.Controls.Add(this.btnDel);
			this.Pipeline.Controls.Add(this.txtActPlan);
			this.Pipeline.Controls.Add(this.btnReset);
			this.Pipeline.Controls.Add(this.txtFee);
			this.Pipeline.Controls.Add(this.btnSubmit);
			this.Pipeline.Controls.Add(this.label11);
			this.Pipeline.Controls.Add(this.txtStatus);
			this.Pipeline.Controls.Add(this.label9);
			this.Pipeline.Controls.Add(this.label6);
			this.Pipeline.Controls.Add(this.cmbClientName);
			this.Pipeline.Controls.Add(this.label19);
			this.Pipeline.Controls.Add(this.label7);
			this.Pipeline.Controls.Add(this.cmbFY);
			this.Pipeline.Controls.Add(this.label21);
			this.Pipeline.Controls.Add(this.cmbMIC);
			this.Pipeline.Controls.Add(this.cmbPIC);
			this.Pipeline.Controls.Add(this.label1);
			this.Pipeline.Controls.Add(this.cmbSIC);
			this.Pipeline.Controls.Add(this.label2);
			this.Pipeline.Location = new System.Drawing.Point(140, 29);
			this.Pipeline.Name = "Pipeline";
			this.Pipeline.Size = new System.Drawing.Size(966, 393);
			this.Pipeline.TabIndex = 101;
			this.Pipeline.TabStop = false;
			this.Pipeline.Text = "Pipeline";
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
			this.cmbOffice.Location = new System.Drawing.Point(109, 89);
			this.cmbOffice.Name = "cmbOffice";
			this.cmbOffice.Size = new System.Drawing.Size(147, 21);
			this.cmbOffice.TabIndex = 106;
			// 
			// cmbClientYear
			// 
			this.cmbClientYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClientYear.FormattingEnabled = true;
			this.cmbClientYear.Items.AddRange(new object[] {
									"2013",
									"2014",
									"2015",
									"2016",
									"2017",
									"2018",
									"2019",
									"2020"});
			this.cmbClientYear.Location = new System.Drawing.Point(428, 292);
			this.cmbClientYear.Name = "cmbClientYear";
			this.cmbClientYear.Size = new System.Drawing.Size(121, 21);
			this.cmbClientYear.TabIndex = 105;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(339, 297);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 21);
			this.label15.TabIndex = 104;
			this.label15.Text = "Client Year:";
			// 
			// cmbDecision
			// 
			this.cmbDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDecision.FormattingEnabled = true;
			this.cmbDecision.Items.AddRange(new object[] {
									"Go",
									"Not go"});
			this.cmbDecision.Location = new System.Drawing.Point(735, 292);
			this.cmbDecision.Name = "cmbDecision";
			this.cmbDecision.Size = new System.Drawing.Size(121, 21);
			this.cmbDecision.TabIndex = 103;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(672, 297);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 35);
			this.label10.TabIndex = 102;
			this.label10.Text = "Decision:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(20, 219);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 27);
			this.label8.TabIndex = 101;
			this.label8.Text = "Information Updated:";
			// 
			// txtInfoUpdated
			// 
			this.txtInfoUpdated.Location = new System.Drawing.Point(109, 216);
			this.txtInfoUpdated.Multiline = true;
			this.txtInfoUpdated.Name = "txtInfoUpdated";
			this.txtInfoUpdated.Size = new System.Drawing.Size(360, 63);
			this.txtInfoUpdated.TabIndex = 100;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(20, 125);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(83, 27);
			this.label12.TabIndex = 99;
			this.label12.Text = "Engagement description:";
			// 
			// txtEngDes
			// 
			this.txtEngDes.Location = new System.Drawing.Point(109, 122);
			this.txtEngDes.Multiline = true;
			this.txtEngDes.Name = "txtEngDes";
			this.txtEngDes.Size = new System.Drawing.Size(360, 79);
			this.txtEngDes.TabIndex = 98;
			// 
			// txtService
			// 
			this.txtService.Location = new System.Drawing.Point(606, 92);
			this.txtService.Name = "txtService";
			this.txtService.Size = new System.Drawing.Size(327, 20);
			this.txtService.TabIndex = 97;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(517, 92);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(83, 23);
			this.label13.TabIndex = 96;
			this.label13.Text = "Service Type:";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(20, 92);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(83, 23);
			this.label14.TabIndex = 94;
			this.label14.Text = "Office:";
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDel.Location = new System.Drawing.Point(588, 327);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 51);
			this.btnDel.TabIndex = 93;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// txtActPlan
			// 
			this.txtActPlan.Location = new System.Drawing.Point(606, 218);
			this.txtActPlan.Multiline = true;
			this.txtActPlan.Name = "txtActPlan";
			this.txtActPlan.Size = new System.Drawing.Size(327, 63);
			this.txtActPlan.TabIndex = 83;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnReset.Location = new System.Drawing.Point(301, 327);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 51);
			this.btnReset.TabIndex = 91;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// txtFee
			// 
			this.txtFee.Location = new System.Drawing.Point(606, 167);
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(199, 20);
			this.txtFee.TabIndex = 88;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSubmit.Location = new System.Drawing.Point(445, 327);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 51);
			this.btnSubmit.TabIndex = 92;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(517, 167);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 35);
			this.label11.TabIndex = 87;
			this.label11.Text = "Fee:";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(606, 129);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(327, 20);
			this.txtStatus.TabIndex = 79;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(517, 221);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 27);
			this.label9.TabIndex = 84;
			this.label9.Text = "Action plan:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(517, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 35);
			this.label6.TabIndex = 78;
			this.label6.Text = "Status % to win:";
			// 
			// cmbClientName
			// 
			this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClientName.FormattingEnabled = true;
			this.cmbClientName.Location = new System.Drawing.Point(109, 22);
			this.cmbClientName.Name = "cmbClientName";
			this.cmbClientName.Size = new System.Drawing.Size(463, 21);
			this.cmbClientName.TabIndex = 58;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(20, 25);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(110, 23);
			this.label19.TabIndex = 60;
			this.label19.Text = "Client Name:";
			this.label19.Click += new System.EventHandler(this.Label19Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(20, 295);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 23);
			this.label7.TabIndex = 62;
			this.label7.Text = "Fiscal year:";
			// 
			// cmbFY
			// 
			this.cmbFY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFY.FormattingEnabled = true;
			this.cmbFY.Items.AddRange(new object[] {
									"2010",
									"2011",
									"2012",
									"2013",
									"2014",
									"2015",
									"2016",
									"2017",
									"2018",
									"2019",
									"2020"});
			this.cmbFY.Location = new System.Drawing.Point(109, 292);
			this.cmbFY.Name = "cmbFY";
			this.cmbFY.Size = new System.Drawing.Size(121, 21);
			this.cmbFY.TabIndex = 63;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(20, 57);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(83, 23);
			this.label21.TabIndex = 61;
			this.label21.Text = "PIC:";
			// 
			// cmbMIC
			// 
			this.cmbMIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMIC.FormattingEnabled = true;
			this.cmbMIC.Location = new System.Drawing.Point(428, 54);
			this.cmbMIC.Name = "cmbMIC";
			this.cmbMIC.Size = new System.Drawing.Size(200, 21);
			this.cmbMIC.TabIndex = 68;
			// 
			// cmbPIC
			// 
			this.cmbPIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPIC.FormattingEnabled = true;
			this.cmbPIC.Location = new System.Drawing.Point(109, 54);
			this.cmbPIC.Name = "cmbPIC";
			this.cmbPIC.Size = new System.Drawing.Size(206, 21);
			this.cmbPIC.TabIndex = 59;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(375, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 65;
			this.label1.Text = "MIC:";
			// 
			// cmbSIC
			// 
			this.cmbSIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSIC.FormattingEnabled = true;
			this.cmbSIC.Location = new System.Drawing.Point(735, 54);
			this.cmbSIC.Name = "cmbSIC";
			this.cmbSIC.Size = new System.Drawing.Size(198, 21);
			this.cmbSIC.TabIndex = 69;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(686, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 67;
			this.label2.Text = "SIC:";
			// 
			// grdTemp
			// 
			this.grdTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTemp.Location = new System.Drawing.Point(1147, 0);
			this.grdTemp.Name = "grdTemp";
			this.grdTemp.Size = new System.Drawing.Size(45, 30);
			this.grdTemp.TabIndex = 67;
			this.grdTemp.Visible = false;
			// 
			// frmPipeline1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmPipeline1";
			this.Text = "Risk Members ";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPipeline)).EndInit();
			this.Pipeline.ResumeLayout(false);
			this.Pipeline.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTemp)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbOffice;
		private System.Windows.Forms.TextBox txtPipeline_ID;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cmbClientYear;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtService;
		private System.Windows.Forms.TextBox txtEngDes;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtInfoUpdated;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbDecision;
		private System.Windows.Forms.DataGridView grdPipeline;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbSIC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbPIC;
		private System.Windows.Forms.ComboBox cmbMIC;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox cmbFY;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox cmbClientName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox txtActPlan;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.GroupBox Pipeline;
		private System.Windows.Forms.DataGridView grdTemp;
		private System.Windows.Forms.Panel mainPanel;
	}
}
