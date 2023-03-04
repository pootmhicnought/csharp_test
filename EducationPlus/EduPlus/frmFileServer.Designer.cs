namespace EduPlus
{
	partial class frmFileServer
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
			this.label1 = new System.Windows.Forms.Label ();
			this.label2 = new System.Windows.Forms.Label ();
			this.lstFiles = new System.Windows.Forms.ListBox ();
			this.btnStart = new System.Windows.Forms.Button ();
			this.btnAdd = new System.Windows.Forms.Button ();
			this.btnRemove = new System.Windows.Forms.Button ();
			this.btnLogs = new System.Windows.Forms.Button ();
			this.cmbIps = new System.Windows.Forms.ComboBox ();
			this.SuspendLayout ();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point ( 12, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 386, 60 );
			this.label1.TabIndex = 0;
			this.label1.Text = "파일 서버는 네트워크를 이용하여 파일을 전송하여 문제 풀기를 할 수 있도록 해주는 서버입니다. 아이피와 파일 번호만 알고 있다면 어디서든 접속하여" +
    " 문제 풀기를 할 수 있습니다.\r\n이 서버를 이용하면 이제 저장 장치에는 Education Plus만 넣고 다니셔도 문제 풀기를 이용할 수 있습" +
    "니다.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point ( 12, 82 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 64, 12 );
			this.label2.TabIndex = 1;
			this.label2.Text = "컴퓨터 IP :";
			// 
			// lstFiles
			// 
			this.lstFiles.FormattingEnabled = true;
			this.lstFiles.ItemHeight = 12;
			this.lstFiles.Location = new System.Drawing.Point ( 14, 106 );
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.Size = new System.Drawing.Size ( 384, 112 );
			this.lstFiles.TabIndex = 3;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point ( 323, 77 );
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size ( 75, 23 );
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "서버 가동";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler ( this.btnStart_Click );
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point ( 14, 224 );
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size ( 75, 23 );
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "파일 추가";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler ( this.btnAdd_Click );
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point ( 95, 224 );
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size ( 75, 23 );
			this.btnRemove.TabIndex = 6;
			this.btnRemove.Text = "파일 제거";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler ( this.btnRemove_Click );
			// 
			// btnLogs
			// 
			this.btnLogs.Location = new System.Drawing.Point ( 323, 224 );
			this.btnLogs.Name = "btnLogs";
			this.btnLogs.Size = new System.Drawing.Size ( 75, 23 );
			this.btnLogs.TabIndex = 7;
			this.btnLogs.Text = "로그 보기";
			this.btnLogs.UseVisualStyleBackColor = true;
			this.btnLogs.Click += new System.EventHandler ( this.btnLogs_Click );
			// 
			// cmbIps
			// 
			this.cmbIps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbIps.FormattingEnabled = true;
			this.cmbIps.Location = new System.Drawing.Point ( 82, 79 );
			this.cmbIps.Name = "cmbIps";
			this.cmbIps.Size = new System.Drawing.Size ( 211, 20 );
			this.cmbIps.TabIndex = 8;
			// 
			// frmFileServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 410, 260 );
			this.Controls.Add ( this.cmbIps );
			this.Controls.Add ( this.btnLogs );
			this.Controls.Add ( this.btnRemove );
			this.Controls.Add ( this.btnAdd );
			this.Controls.Add ( this.btnStart );
			this.Controls.Add ( this.lstFiles );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFileServer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "파일 서버";
			this.Load += new System.EventHandler ( this.frmFileServer_Load );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler ( this.frmFileServer_FormClosing );
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnLogs;
		private System.Windows.Forms.ComboBox cmbIps;
	}
}