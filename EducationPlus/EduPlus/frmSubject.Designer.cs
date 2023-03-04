namespace EduPlus
{
	partial class frmSubject
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
			this.txtAnswer = new System.Windows.Forms.TextBox ();
			this.btnOk = new System.Windows.Forms.Button ();
			this.SuspendLayout ();
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point ( 12, 12 );
			this.txtAnswer.Multiline = true;
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size ( 374, 194 );
			this.txtAnswer.TabIndex = 0;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point ( 161, 212 );
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size ( 75, 23 );
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "확인";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler ( this.btnOk_Click );
			// 
			// frmSubject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 398, 257 );
			this.Controls.Add ( this.btnOk );
			this.Controls.Add ( this.txtAnswer );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSubject";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "주관식 답 입력";
			this.Load += new System.EventHandler ( this.frmSubject_Load );
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnOk;
	}
}