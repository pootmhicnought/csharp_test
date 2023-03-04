namespace EduPlus
{
	partial class frmThemeEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmThemeEdit ) );
			this.mnuMain = new System.Windows.Forms.MenuStrip ();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuNew = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem ();
			this.cmbThemeType = new System.Windows.Forms.ComboBox ();
			this.picEdit = new System.Windows.Forms.PictureBox ();
			this.pgEdit = new System.Windows.Forms.PropertyGrid ();
			this.mnuMain.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picEdit ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuFile,
            this.mnuHelp} );
			this.mnuMain.Location = new System.Drawing.Point ( 0, 0 );
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size ( 641, 24 );
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuNew,
            this.mnuOpen,
            this.toolStripMenuItem1,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripMenuItem2,
            this.mnuExit} );
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size ( 57, 20 );
			this.mnuFile.Text = "파일(&F)";
			// 
			// mnuNew
			// 
			this.mnuNew.Name = "mnuNew";
			this.mnuNew.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N ) ) );
			this.mnuNew.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuNew.Text = "새 테마(&N)";
			this.mnuNew.Click += new System.EventHandler ( this.mnuNew_Click );
			// 
			// mnuOpen
			// 
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
			this.mnuOpen.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuOpen.Text = "열기(&O)";
			this.mnuOpen.Click += new System.EventHandler ( this.mnuOpen_Click );
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size ( 179, 6 );
			// 
			// mnuSave
			// 
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S ) ) );
			this.mnuSave.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuSave.Text = "저장(&S)";
			this.mnuSave.Click += new System.EventHandler ( this.mnuSave_Click );
			// 
			// mnuSaveAs
			// 
			this.mnuSaveAs.Name = "mnuSaveAs";
			this.mnuSaveAs.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuSaveAs.Text = "새 이름으로 저장(&A)";
			this.mnuSaveAs.Click += new System.EventHandler ( this.mnuSaveAs_Click );
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size ( 179, 6 );
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4 ) ) );
			this.mnuExit.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuExit.Text = "종료(&X)";
			this.mnuExit.Click += new System.EventHandler ( this.mnuExit_Click );
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuAbout} );
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size ( 72, 20 );
			this.mnuHelp.Text = "도움말(&H)";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.mnuAbout.Size = new System.Drawing.Size ( 162, 22 );
			this.mnuAbout.Text = "버전 정보(&A)";
			this.mnuAbout.Click += new System.EventHandler ( this.mnuAbout_Click );
			// 
			// cmbThemeType
			// 
			this.cmbThemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbThemeType.FormattingEnabled = true;
			this.cmbThemeType.Items.AddRange ( new object [] {
            "기본 테마 형식",
            "보기가 그림인 테마"} );
			this.cmbThemeType.Location = new System.Drawing.Point ( 23, 45 );
			this.cmbThemeType.Name = "cmbThemeType";
			this.cmbThemeType.Size = new System.Drawing.Size ( 264, 20 );
			this.cmbThemeType.TabIndex = 1;
			this.cmbThemeType.SelectedIndexChanged += new System.EventHandler ( this.cmbThemeType_SelectedIndexChanged );
			// 
			// picEdit
			// 
			this.picEdit.BackColor = System.Drawing.Color.White;
			this.picEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picEdit.Location = new System.Drawing.Point ( 23, 82 );
			this.picEdit.Name = "picEdit";
			this.picEdit.Size = new System.Drawing.Size ( 400, 300 );
			this.picEdit.TabIndex = 2;
			this.picEdit.TabStop = false;
			this.picEdit.Paint += new System.Windows.Forms.PaintEventHandler ( this.picEdit_Paint );
			// 
			// pgEdit
			// 
			this.pgEdit.Location = new System.Drawing.Point ( 429, 82 );
			this.pgEdit.Name = "pgEdit";
			this.pgEdit.Size = new System.Drawing.Size ( 188, 300 );
			this.pgEdit.TabIndex = 3;
			this.pgEdit.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler ( this.pgEdit_PropertyValueChanged );
			// 
			// frmThemeEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 641, 401 );
			this.Controls.Add ( this.pgEdit );
			this.Controls.Add ( this.picEdit );
			this.Controls.Add ( this.cmbThemeType );
			this.Controls.Add ( this.mnuMain );
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject ( "$this.Icon" ) ) );
			this.MainMenuStrip = this.mnuMain;
			this.MaximizeBox = false;
			this.Name = "frmThemeEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "제목 없음.eptf - Theme Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler ( this.frmThemeEdit_FormClosing );
			this.mnuMain.ResumeLayout ( false );
			this.mnuMain.PerformLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picEdit ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuNew;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ComboBox cmbThemeType;
		private System.Windows.Forms.PictureBox picEdit;
		private System.Windows.Forms.PropertyGrid pgEdit;
	}
}