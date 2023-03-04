namespace EduPlus
{
	partial class frmHelp
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem ( "시작하기" );
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem ( "문제 추가/제거" );
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem ( "문제 수정하기" );
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem ( "보기 추가/제거" );
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem ( "객관식과 주관식" );
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem ( "테마" );
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem ( "문제 발표하기" );
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem ( "팀 네비게이터" );
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem ( "파일 서버" );
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem ( "파일 서버로부터 열기" );
			System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem ( "바로가기 만들기" );
			System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem ( "끝내기" );
			this.scHelp = new System.Windows.Forms.SplitContainer ();
			this.lstHelp = new System.Windows.Forms.ListView ();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader ();
			this.picView = new System.Windows.Forms.PictureBox ();
			this.label1 = new System.Windows.Forms.Label ();
			this.scHelp.Panel1.SuspendLayout ();
			this.scHelp.Panel2.SuspendLayout ();
			this.scHelp.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize )( this.picView ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// scHelp
			// 
			this.scHelp.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.scHelp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.scHelp.Location = new System.Drawing.Point ( 0, 24 );
			this.scHelp.Name = "scHelp";
			// 
			// scHelp.Panel1
			// 
			this.scHelp.Panel1.Controls.Add ( this.lstHelp );
			// 
			// scHelp.Panel2
			// 
			this.scHelp.Panel2.Controls.Add ( this.picView );
			this.scHelp.Size = new System.Drawing.Size ( 495, 267 );
			this.scHelp.SplitterDistance = 182;
			this.scHelp.TabIndex = 0;
			// 
			// lstHelp
			// 
			this.lstHelp.Columns.AddRange ( new System.Windows.Forms.ColumnHeader [] {
            this.columnHeader1} );
			this.lstHelp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstHelp.GridLines = true;
			this.lstHelp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstHelp.Items.AddRange ( new System.Windows.Forms.ListViewItem [] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12} );
			this.lstHelp.LabelWrap = false;
			this.lstHelp.Location = new System.Drawing.Point ( 0, 0 );
			this.lstHelp.MultiSelect = false;
			this.lstHelp.Name = "lstHelp";
			this.lstHelp.Size = new System.Drawing.Size ( 182, 267 );
			this.lstHelp.TabIndex = 0;
			this.lstHelp.UseCompatibleStateImageBehavior = false;
			this.lstHelp.View = System.Windows.Forms.View.Details;
			this.lstHelp.SelectedIndexChanged += new System.EventHandler ( this.lstHelp_SelectedIndexChanged );
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "도움말 항목";
			this.columnHeader1.Width = 157;
			// 
			// picView
			// 
			this.picView.BackColor = System.Drawing.Color.White;
			this.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picView.Location = new System.Drawing.Point ( 0, 0 );
			this.picView.Name = "picView";
			this.picView.Size = new System.Drawing.Size ( 309, 267 );
			this.picView.TabIndex = 0;
			this.picView.TabStop = false;
			this.picView.MouseMove += new System.Windows.Forms.MouseEventHandler ( this.picView_MouseMove );
			this.picView.MouseDown += new System.Windows.Forms.MouseEventHandler ( this.picView_MouseDown );
			this.picView.Paint += new System.Windows.Forms.PaintEventHandler ( this.picView_Paint );
			this.picView.MouseUp += new System.Windows.Forms.MouseEventHandler ( this.picView_MouseUp );
			// 
			// label1
			// 
			this.label1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.label1.AutoEllipsis = true;
			this.label1.Location = new System.Drawing.Point ( 6, 6 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 483, 12 );
			this.label1.TabIndex = 1;
			this.label1.Text = "팁 : 도움말 항목에서 항목을 선택한 후 오른쪽 그림을 드래그하시면 볼 수 있습니다.";
			// 
			// frmHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 495, 291 );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.scHelp );
			this.Name = "frmHelp";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "도움말";
			this.Load += new System.EventHandler ( this.frmHelp_Load );
			this.scHelp.Panel1.ResumeLayout ( false );
			this.scHelp.Panel2.ResumeLayout ( false );
			this.scHelp.ResumeLayout ( false );
			( ( System.ComponentModel.ISupportInitialize )( this.picView ) ).EndInit ();
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.SplitContainer scHelp;
		private System.Windows.Forms.PictureBox picView;
		private System.Windows.Forms.ListView lstHelp;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label1;


	}
}