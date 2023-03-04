namespace EduPlus
{
	partial class frmTeamAdd
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
			this.textBox1 = new System.Windows.Forms.TextBox ();
			this.btnAdd = new System.Windows.Forms.Button ();
			this.btnCancel = new System.Windows.Forms.Button ();
			this.label2 = new System.Windows.Forms.Label ();
			this.SuspendLayout ();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 31, 26 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 53, 12 );
			this.label1.TabIndex = 0;
			this.label1.Text = "팀 이름 :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point ( 90, 23 );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size ( 196, 21 );
			this.textBox1.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point ( 67, 60 );
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size ( 75, 23 );
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "추가(&A)";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler ( this.btnAdd_Click );
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point ( 182, 60 );
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size ( 75, 23 );
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "취소(&C)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler ( this.btnCancel_Click );
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point ( 20, 97 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 285, 12 );
			this.label2.TabIndex = 4;
			this.label2.Text = "※주의 : 팀 이름은 한번 설정하면 바꿀 수 없습니다.";
			// 
			// frmTeamAdd
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 324, 130 );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.btnCancel );
			this.Controls.Add ( this.btnAdd );
			this.Controls.Add ( this.textBox1 );
			this.Controls.Add ( this.label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTeamAdd";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "팀 추가";
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label2;
	}
}