using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using IWshRuntimeLibrary;

namespace EduPlus
{
	public partial class frmShortcut : Form
	{
		public frmShortcut ()
		{
			InitializeComponent ();
			cmbCmd.Text = "환경 설정";
		}

		public void MakeShortCut ( string path, string arguments )
		{
			/*
			WshShellClass s = new WshShellClass ();
			IWshShortcut shortCut = s.CreateShortcut ( path ) as IWshShortcut;
			shortCut.TargetPath = Application.ExecutablePath;
			shortCut.Arguments = arguments;
			shortCut.Save ();
			*/
		}

		private void btnSave_Click ( object sender, EventArgs e )
		{
			string arg = "";

			switch ( cmbCmd.Text.Trim() )
			{
				case "환경 설정":
					arg = "-opt";
					break;
				case "도움말":
					arg = "-h";
					break;
				case "발표":
					arg = "-pre \"" + txtFilePath.Text + "\"";
					break;
				case "테마 에디터":
					arg = "-thm";
					break;
				case "팀 네비게이터":
					arg = "-team";
					break;
				case "네트워킹 발표":
					arg = "-netpre";
					break;
				case "파일 서버":
					arg = "-fserv";
					break;
			}

			MakeShortCut ( txtSavePath.Text, arg );

			this.Close ();
		}

		private void btnSavePath_Click ( object sender, EventArgs e )
		{
			SaveFileDialog sfd = new SaveFileDialog ();
			sfd.Filter = "바로가기 파일(*.lnk)|*.lnk";

			if ( sfd.ShowDialog () == DialogResult.Cancel ) return;

			txtSavePath.Text = sfd.FileName;
		}
	}
}
