namespace EduPlus
{
	partial class frmTeam
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container ();
			this.btnOpen = new System.Windows.Forms.Button ();
			this.btnSave = new System.Windows.Forms.Button ();
			this.cmbTeam = new System.Windows.Forms.ComboBox ();
			this.btnAdd = new System.Windows.Forms.Button ();
			this.btnRemove = new System.Windows.Forms.Button ();
			this.lstTeamMember = new System.Windows.Forms.ListBox ();
			this.label1 = new System.Windows.Forms.Label ();
			this.numPoint = new System.Windows.Forms.NumericUpDown ();
			this.txtAddName = new System.Windows.Forms.TextBox ();
			this.btnAddName = new System.Windows.Forms.Button ();
			this.tmrEscCheck = new System.Windows.Forms.Timer ( this.components );
			( ( System.ComponentModel.ISupportInitialize )( this.numPoint ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point ( 12, 12 );
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size ( 75, 23 );
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "열기(&O)";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler ( this.btnOpen_Click );
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point ( 98, 12 );
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size ( 75, 23 );
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "저장(&S)";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler ( this.btnSave_Click );
			// 
			// cmbTeam
			// 
			this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTeam.FormattingEnabled = true;
			this.cmbTeam.Location = new System.Drawing.Point ( 12, 52 );
			this.cmbTeam.Name = "cmbTeam";
			this.cmbTeam.Size = new System.Drawing.Size ( 105, 20 );
			this.cmbTeam.TabIndex = 2;
			this.cmbTeam.SelectedIndexChanged += new System.EventHandler ( this.cmbTeam_SelectedIndexChanged );
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point ( 123, 50 );
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size ( 22, 23 );
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler ( this.btnAdd_Click );
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point ( 151, 50 );
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size ( 22, 23 );
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "-";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler ( this.btnRemove_Click );
			// 
			// lstTeamMember
			// 
			this.lstTeamMember.FormattingEnabled = true;
			this.lstTeamMember.ItemHeight = 12;
			this.lstTeamMember.Location = new System.Drawing.Point ( 12, 78 );
			this.lstTeamMember.Name = "lstTeamMember";
			this.lstTeamMember.Size = new System.Drawing.Size ( 161, 124 );
			this.lstTeamMember.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 12, 258 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 33, 12 );
			this.label1.TabIndex = 6;
			this.label1.Text = "점수:";
			// 
			// numPoint
			// 
			this.numPoint.Location = new System.Drawing.Point ( 51, 256 );
			this.numPoint.Name = "numPoint";
			this.numPoint.Size = new System.Drawing.Size ( 122, 21 );
			this.numPoint.TabIndex = 7;
			this.numPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numPoint.ValueChanged += new System.EventHandler ( this.numPoint_ValueChanged );
			// 
			// txtAddName
			// 
			this.txtAddName.Location = new System.Drawing.Point ( 12, 208 );
			this.txtAddName.Name = "txtAddName";
			this.txtAddName.Size = new System.Drawing.Size ( 100, 21 );
			this.txtAddName.TabIndex = 8;
			// 
			// btnAddName
			// 
			this.btnAddName.Location = new System.Drawing.Point ( 118, 206 );
			this.btnAddName.Name = "btnAddName";
			this.btnAddName.Size = new System.Drawing.Size ( 55, 23 );
			this.btnAddName.TabIndex = 9;
			this.btnAddName.Text = "추가(&P)";
			this.btnAddName.UseVisualStyleBackColor = true;
			this.btnAddName.Click += new System.EventHandler ( this.btnAddName_Click );
			// 
			// tmrEscCheck
			// 
			this.tmrEscCheck.Enabled = true;
			this.tmrEscCheck.Tick += new System.EventHandler ( this.tmrEscCheck_Tick );
			// 
			// frmTeam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 187, 289 );
			this.ControlBox = false;
			this.Controls.Add ( this.btnAddName );
			this.Controls.Add ( this.txtAddName );
			this.Controls.Add ( this.numPoint );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.lstTeamMember );
			this.Controls.Add ( this.btnRemove );
			this.Controls.Add ( this.btnAdd );
			this.Controls.Add ( this.cmbTeam );
			this.Controls.Add ( this.btnSave );
			this.Controls.Add ( this.btnOpen );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTeam";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "팀 네비게이터";
			this.TopMost = true;
			( ( System.ComponentModel.ISupportInitialize )( this.numPoint ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cmbTeam;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.ListBox lstTeamMember;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAddName;
		private System.Windows.Forms.Button btnAddName;
		private System.Windows.Forms.Timer tmrEscCheck;
		public System.Windows.Forms.NumericUpDown numPoint;
	}
}