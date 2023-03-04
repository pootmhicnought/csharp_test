namespace EduPlus
{
	partial class frmShortcut
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
			this.cmbCmd = new System.Windows.Forms.ComboBox ();
			this.txtFilePath = new System.Windows.Forms.TextBox ();
			this.btnFilePath = new System.Windows.Forms.Button ();
			this.btnSavePath = new System.Windows.Forms.Button ();
			this.txtSavePath = new System.Windows.Forms.TextBox ();
			this.label3 = new System.Windows.Forms.Label ();
			this.btnSave = new System.Windows.Forms.Button ();
			this.SuspendLayout ();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 28, 35 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 65, 12 );
			this.label1.TabIndex = 0;
			this.label1.Text = "만들 명령 :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point ( 28, 75 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 65, 12 );
			this.label2.TabIndex = 1;
			this.label2.Text = "파일 경로 :";
			// 
			// cmbCmd
			// 
			this.cmbCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCmd.FormattingEnabled = true;
			this.cmbCmd.Items.AddRange ( new object [] {
            "환경 설정",
            "도움말",
            "발표",
            "테마 에디터",
            "팀 네비게이터",
            "네트워킹 발표",
            "파일 서버"} );
			this.cmbCmd.Location = new System.Drawing.Point ( 99, 32 );
			this.cmbCmd.Name = "cmbCmd";
			this.cmbCmd.Size = new System.Drawing.Size ( 238, 20 );
			this.cmbCmd.TabIndex = 2;
			// 
			// txtFilePath
			// 
			this.txtFilePath.Location = new System.Drawing.Point ( 99, 72 );
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size ( 203, 21 );
			this.txtFilePath.TabIndex = 3;
			// 
			// btnFilePath
			// 
			this.btnFilePath.Location = new System.Drawing.Point ( 308, 70 );
			this.btnFilePath.Name = "btnFilePath";
			this.btnFilePath.Size = new System.Drawing.Size ( 29, 23 );
			this.btnFilePath.TabIndex = 4;
			this.btnFilePath.Text = "...";
			this.btnFilePath.UseVisualStyleBackColor = true;
			// 
			// btnSavePath
			// 
			this.btnSavePath.Location = new System.Drawing.Point ( 308, 111 );
			this.btnSavePath.Name = "btnSavePath";
			this.btnSavePath.Size = new System.Drawing.Size ( 29, 23 );
			this.btnSavePath.TabIndex = 7;
			this.btnSavePath.Text = "...";
			this.btnSavePath.UseVisualStyleBackColor = true;
			this.btnSavePath.Click += new System.EventHandler ( this.btnSavePath_Click );
			// 
			// txtSavePath
			// 
			this.txtSavePath.Location = new System.Drawing.Point ( 99, 113 );
			this.txtSavePath.Name = "txtSavePath";
			this.txtSavePath.Size = new System.Drawing.Size ( 203, 21 );
			this.txtSavePath.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point ( 28, 116 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 65, 12 );
			this.label3.TabIndex = 5;
			this.label3.Text = "저장할 곳 :";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point ( 151, 149 );
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size ( 75, 23 );
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "만들기";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler ( this.btnSave_Click );
			// 
			// frmShortcut
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 372, 198 );
			this.Controls.Add ( this.btnSave );
			this.Controls.Add ( this.btnSavePath );
			this.Controls.Add ( this.txtSavePath );
			this.Controls.Add ( this.label3 );
			this.Controls.Add ( this.btnFilePath );
			this.Controls.Add ( this.txtFilePath );
			this.Controls.Add ( this.cmbCmd );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frmShortcut";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "바로가기 만들기";
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbCmd;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Button btnFilePath;
		private System.Windows.Forms.Button btnSavePath;
		private System.Windows.Forms.TextBox txtSavePath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSave;
	}
}