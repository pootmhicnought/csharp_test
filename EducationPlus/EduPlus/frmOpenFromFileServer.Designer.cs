namespace EduPlus
{
	partial class frmOpenFromFileServer
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
			this.numFileNum = new System.Windows.Forms.NumericUpDown ();
			this.btnOpen = new System.Windows.Forms.Button ();
			this.txtIp = new System.Windows.Forms.TextBox ();
			this.lblWait = new System.Windows.Forms.Label ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numFileNum ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 27, 31 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 52, 12 );
			this.label1.TabIndex = 0;
			this.label1.Text = "서버 IP :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point ( 27, 73 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 65, 12 );
			this.label2.TabIndex = 1;
			this.label2.Text = "파일 번호 :";
			// 
			// numFileNum
			// 
			this.numFileNum.Location = new System.Drawing.Point ( 98, 71 );
			this.numFileNum.Maximum = new decimal ( new int [] {
            255,
            0,
            0,
            0} );
			this.numFileNum.Name = "numFileNum";
			this.numFileNum.Size = new System.Drawing.Size ( 127, 21 );
			this.numFileNum.TabIndex = 6;
			this.numFileNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numFileNum.Value = new decimal ( new int [] {
            1,
            0,
            0,
            0} );
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point ( 92, 111 );
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size ( 75, 23 );
			this.btnOpen.TabIndex = 7;
			this.btnOpen.Text = "열기";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler ( this.btnOpen_Click );
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point ( 85, 28 );
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size ( 140, 21 );
			this.txtIp.TabIndex = 9;
			this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblWait
			// 
			this.lblWait.BackColor = System.Drawing.Color.White;
			this.lblWait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblWait.Location = new System.Drawing.Point ( 12, 9 );
			this.lblWait.Name = "lblWait";
			this.lblWait.Size = new System.Drawing.Size ( 234, 142 );
			this.lblWait.TabIndex = 10;
			this.lblWait.Text = "파일을 다운로드 중입니다.";
			this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblWait.Visible = false;
			// 
			// frmOpenFromFileServer
			// 
			this.AcceptButton = this.btnOpen;
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 258, 160 );
			this.Controls.Add ( this.lblWait );
			this.Controls.Add ( this.txtIp );
			this.Controls.Add ( this.btnOpen );
			this.Controls.Add ( this.numFileNum );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmOpenFromFileServer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "파일 서버로부터 열기";
			( ( System.ComponentModel.ISupportInitialize ) ( this.numFileNum ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numFileNum;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.Label lblWait;
	}
}