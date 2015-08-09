/*
 * Created by SharpDevelop.
 * User: Ha.B.Ngoc.Le
 * Date: 5/21/2013
 * Time: 3:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C1Monitoring
{
	partial class frmClientPosition
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
			this.grdClientApp = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbApplication = new System.Windows.Forms.ComboBox();
			this.cmbClient = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDel1 = new System.Windows.Forms.Button();
			this.btbSubmit1 = new System.Windows.Forms.Button();
			this.btnReset1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.grdPosition = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtID_Position = new System.Windows.Forms.TextBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdClientApp)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPosition)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.grdClientApp);
			this.mainPanel.Controls.Add(this.groupBox2);
			this.mainPanel.Controls.Add(this.label5);
			this.mainPanel.Controls.Add(this.grdPosition);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.groupBox1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1192, 816);
			this.mainPanel.TabIndex = 0;
			// 
			// grdClientApp
			// 
			this.grdClientApp.AllowUserToAddRows = false;
			this.grdClientApp.AllowUserToDeleteRows = false;
			this.grdClientApp.AllowUserToOrderColumns = true;
			this.grdClientApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClientApp.Location = new System.Drawing.Point(607, 356);
			this.grdClientApp.MultiSelect = false;
			this.grdClientApp.Name = "grdClientApp";
			this.grdClientApp.ReadOnly = true;
			this.grdClientApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdClientApp.Size = new System.Drawing.Size(481, 391);
			this.grdClientApp.TabIndex = 29;
			this.grdClientApp.Visible = false;
			this.grdClientApp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientAppCellClick);
			this.grdClientApp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdClientAppDataBindingComplete);
			this.grdClientApp.SelectionChanged += new System.EventHandler(this.GrdClientAppSelectionChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbApplication);
			this.groupBox2.Controls.Add(this.cmbClient);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnDel1);
			this.groupBox2.Controls.Add(this.btbSubmit1);
			this.groupBox2.Controls.Add(this.btnReset1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(607, 90);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(481, 260);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Client - Application";
			this.groupBox2.Visible = false;
			// 
			// cmbApplication
			// 
			this.cmbApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbApplication.FormattingEnabled = true;
			this.cmbApplication.Location = new System.Drawing.Point(249, 116);
			this.cmbApplication.Name = "cmbApplication";
			this.cmbApplication.Size = new System.Drawing.Size(210, 21);
			this.cmbApplication.TabIndex = 12;
			// 
			// cmbClient
			// 
			this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClient.FormattingEnabled = true;
			this.cmbClient.Location = new System.Drawing.Point(249, 73);
			this.cmbClient.Name = "cmbClient";
			this.cmbClient.Size = new System.Drawing.Size(210, 21);
			this.cmbClient.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(91, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Client Name:";
			// 
			// btnDel1
			// 
			this.btnDel1.Location = new System.Drawing.Point(374, 189);
			this.btnDel1.Name = "btnDel1";
			this.btnDel1.Size = new System.Drawing.Size(85, 48);
			this.btnDel1.TabIndex = 8;
			this.btnDel1.Text = "Delete";
			this.btnDel1.UseVisualStyleBackColor = true;
			// 
			// btbSubmit1
			// 
			this.btbSubmit1.Location = new System.Drawing.Point(234, 189);
			this.btbSubmit1.Name = "btbSubmit1";
			this.btbSubmit1.Size = new System.Drawing.Size(85, 48);
			this.btbSubmit1.TabIndex = 7;
			this.btbSubmit1.Text = "Submit";
			this.btbSubmit1.UseVisualStyleBackColor = true;
			this.btbSubmit1.Click += new System.EventHandler(this.BtbSubmit1Click);
			// 
			// btnReset1
			// 
			this.btnReset1.Location = new System.Drawing.Point(90, 189);
			this.btnReset1.Name = "btnReset1";
			this.btnReset1.Size = new System.Drawing.Size(85, 48);
			this.btnReset1.TabIndex = 6;
			this.btnReset1.Text = "Clear Form";
			this.btnReset1.UseVisualStyleBackColor = true;
			this.btnReset1.Click += new System.EventHandler(this.BtnReset1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(91, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Application Name:";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(125, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "*: Fields with * are mandatory";
			// 
			// grdPosition
			// 
			this.grdPosition.AllowUserToAddRows = false;
			this.grdPosition.AllowUserToDeleteRows = false;
			this.grdPosition.AllowUserToOrderColumns = true;
			this.grdPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPosition.Location = new System.Drawing.Point(125, 356);
			this.grdPosition.MultiSelect = false;
			this.grdPosition.Name = "grdPosition";
			this.grdPosition.ReadOnly = true;
			this.grdPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPosition.Size = new System.Drawing.Size(476, 391);
			this.grdPosition.TabIndex = 6;
			this.grdPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPositionCellClick);
			this.grdPosition.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdRateDataBindingComplete);
			this.grdPosition.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GrdRateRowsAdded);
			this.grdPosition.SelectionChanged += new System.EventHandler(this.GrdRateSelectionChanged);
			this.grdPosition.Sorted += new System.EventHandler(this.GrdRateSorted);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(567, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please fill in the following form to create a new rate or update an existing rate" +
			":";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtID_Position);
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.txtPosition);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(125, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(476, 260);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Position";
			// 
			// txtID_Position
			// 
			this.txtID_Position.Location = new System.Drawing.Point(180, 73);
			this.txtID_Position.Name = "txtID_Position";
			this.txtID_Position.Size = new System.Drawing.Size(187, 20);
			this.txtID_Position.TabIndex = 9;
			this.txtID_Position.Visible = false;
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(337, 189);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(85, 48);
			this.btnDel.TabIndex = 4;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(197, 189);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 48);
			this.btnSubmit.TabIndex = 3;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(53, 189);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 48);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Clear Form";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(180, 111);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(187, 20);
			this.txtPosition.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(51, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Position (*):";
			// 
			// frmClientPosition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1192, 816);
			this.Controls.Add(this.mainPanel);
			this.Name = "frmClientPosition";
			this.Text = "Position";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdClientApp)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdPosition)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView grdClientApp;
		private System.Windows.Forms.ComboBox cmbClient;
		private System.Windows.Forms.ComboBox cmbApplication;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnReset1;
		private System.Windows.Forms.Button btbSubmit1;
		private System.Windows.Forms.Button btnDel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtID_Position;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView grdPosition;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Panel mainPanel;
		
		void Label3Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
