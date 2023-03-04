namespace EduPlus
{
	partial class frmOption
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
			this.btnClose = new System.Windows.Forms.Button ();
			this.btnCreateInterop = new System.Windows.Forms.Button ();
			this.ttBtnClrInterop = new System.Windows.Forms.ToolTip ( this.components );
			this.SuspendLayout ();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point ( 90, 58 );
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size ( 75, 23 );
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "닫기(&C)";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler ( this.btnClose_Click );
			// 
			// btnCreateInterop
			// 
			this.btnCreateInterop.Location = new System.Drawing.Point ( 12, 12 );
			this.btnCreateInterop.Name = "btnCreateInterop";
			this.btnCreateInterop.Size = new System.Drawing.Size ( 232, 23 );
			this.btnCreateInterop.TabIndex = 2;
			this.btnCreateInterop.Text = "CLR Interop 파일 생성";
			this.ttBtnClrInterop.SetToolTip ( this.btnCreateInterop, "Windows Host Scripting Runtime Library의 CLR Interop 파일을 같은 폴더 내에 생성합니다." );
			this.btnCreateInterop.UseVisualStyleBackColor = true;
			this.btnCreateInterop.Click += new System.EventHandler ( this.btnCreateInterop_Click );
			// 
			// ttBtnClrInterop
			// 
			this.ttBtnClrInterop.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttBtnClrInterop.ToolTipTitle = "Interop.WshRuntimeLibrary.dll 파일을 같은 폴더 내에 생성합니다.";
			// 
			// frmOption
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 256, 92 );
			this.Controls.Add ( this.btnCreateInterop );
			this.Controls.Add ( this.btnClose );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmOption";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "환경설정";
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCreateInterop;
		private System.Windows.Forms.ToolTip ttBtnClrInterop;

	}
}