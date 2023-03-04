namespace EduPlus
{
	partial class frmPresent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmPresent ) );
			this.tmrChkTeamNavi = new System.Windows.Forms.Timer ( this.components );
			this.SuspendLayout ();
			// 
			// tmrChkTeamNavi
			// 
			this.tmrChkTeamNavi.Tick += new System.EventHandler ( this.tmrChkTeamNavi_Tick );
			// 
			// frmPresent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size ( 284, 264 );
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject ( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPresent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "문제 발표";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Paint += new System.Windows.Forms.PaintEventHandler ( this.frmPresent_Paint );
			this.MouseClick += new System.Windows.Forms.MouseEventHandler ( this.frmPresent_MouseClick );
			this.Shown += new System.EventHandler ( this.frmPresent_Shown );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler ( this.frmPresent_FormClosing );
			this.MouseMove += new System.Windows.Forms.MouseEventHandler ( this.frmPresent_MouseMove );
			this.KeyDown += new System.Windows.Forms.KeyEventHandler ( this.frmPresent_KeyDown );
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.Timer tmrChkTeamNavi;
	}
}