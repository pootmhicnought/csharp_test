using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EduPlus
{
	public partial class frmMain : Form
	{
		EduManager eduMan = new EduManager ();

		bool saveOk = true;
		string savePath = "";

		// 편집중인 문제
		int selectedIndex;

		/// <summary>
		/// 리스트뷰를 초기화합니다
		/// </summary>
		public void InitList ()
		{
			lstQuestion.Items.Clear ();
			foreach ( EpQuestion q in eduMan.Question )
				lstQuestion.Items.Add ( q.Question );
		}

		/// <summary>
		/// 저장 상태를 확인합니다
		/// </summary>
		public bool SaveCheck
		{
			get
			{
				if ( saveOk ) return true;

				DialogResult dr = MessageBox.Show ( "저장하시겠습니까?", "질문",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

				switch ( dr )
				{
					case DialogResult.Yes:
						return Save ();
					case DialogResult.No:
						return true;
					case DialogResult.Cancel:
						return false;
				}

				return true;
			}
		}

		/// <summary>
		/// savePath의 원본 파일 이름을 가져옵니다
		/// </summary>
		/// <returns>savePath에서 경로를 뺀 파일 이름</returns>
		public string GetName ()
		{
			string [] a = savePath.Split ( '\\' );
			return a [ a.Length - 1 ];
		}

		/// <summary>
		/// 창의 제목표시줄의 내용을 변경합니다
		/// </summary>
		public void SetTitle ()
		{
			string fn = ( savePath == "" ) ? "제목 없음.epf" : GetName ();
			fn += ( !saveOk ) ? "*" : "";
			Text = fn + " - Education Plus";
		}

		/// <summary>
		/// 새 파일
		/// </summary>
		public void New ()
		{
			if ( !SaveCheck ) return;

			saveOk = true;
			savePath = "";

			eduMan = new EduManager ();

			SetTitle ();
			InitList ();
			pgQuestion.SelectedObject = null;
		}

		/// <summary>
		/// 열기
		/// </summary>
		public void Open ()
		{
			if ( !SaveCheck ) return;

			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.Filter = "Education Plus 파일(*.epf)|*.epf";

			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;

			eduMan = new EduManager ();
			FileStream fs = new FileStream ( ofd.FileName, FileMode.Open );
			if ( !eduMan.Load ( fs ) ) return;
			fs.Close ();
			fs.Dispose ();

			saveOk = true;
			savePath = ofd.FileName;

			SetTitle ();
			InitList ();
			pgQuestion.SelectedObject = null;
		}

		public bool Save ()
		{
			if ( savePath == "" )
				return SaveAs ();

			FileStream fs = new FileStream ( savePath, FileMode.OpenOrCreate );
			fs.Position = 0;

			if ( !eduMan.Save ( fs ) ) return false;

			fs.Close ();
			fs.Dispose ();

			saveOk = true;

			SetTitle ();

			return true;
		}

		public bool SaveAs ()
		{
			SaveFileDialog sfd = new SaveFileDialog ();
			sfd.Filter = "Education Plus 파일(*.epf)|*.epf";
			if ( savePath == "" )
				sfd.FileName = "제목 없음.epf";
			else
				sfd.FileName = savePath;

			if ( sfd.ShowDialog () == DialogResult.Cancel ) return false;

			FileStream fs = new FileStream ( sfd.FileName, FileMode.OpenOrCreate );
			fs.Position = 0;

			if ( !eduMan.Save ( fs ) ) return false;

			fs.Close ();
			fs.Dispose ();

			saveOk = true;
			savePath = sfd.FileName;

			SetTitle ();

			return true;
		}

		public void Undo ()
		{
			SendKeys.Send ( "^Z" );
		}

		public void Redo ()
		{
			SendKeys.Send ( "^Y" );
		}

		public void Cut ()
		{
			SendKeys.Send ( "^X" );
		}

		public void Copy ()
		{
			SendKeys.Send ( "^C" );
		}

		public void Paste ()
		{
			SendKeys.Send ( "^V" );
		}

		public void Delete ()
		{
			SendKeys.Send ( "{DEL}" );
		}

		public void AddQuestion ()
		{
			EpQuestion que = new EpQuestion ();
			eduMan.Question.Add ( que );
			lstQuestion.Items.Add ( que.Question );

			saveOk = false;
			SetTitle ();
		}

		public void RemoveQuestion ()
		{
			if ( lstQuestion.FocusedItem == null ) return;

			eduMan.Question.RemoveAt ( lstQuestion.FocusedItem.Index );
			lstQuestion.FocusedItem.Remove ();

			selectedIndex = 0;
			pgQuestion.SelectedObject = null;

			saveOk = false;
			SetTitle ();
		}

		public frmMain ()
		{
			InitializeComponent ();
		}

		public frmMain ( string file )
		{
			InitializeComponent ();

			eduMan = new EduManager ();
			FileStream fs = new FileStream ( file, FileMode.Open );
			eduMan.Load ( fs );
			fs.Close ();
			fs.Dispose ();

			saveOk = true;
			savePath = file;

			SetTitle ();
			InitList ();
		}

		public void Present ()
		{
			if ( eduMan.Question.Count == 0 )
			{
				MessageBox.Show ( "발표할 문제가 없습니다!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}
			new frmPresent ( ref eduMan ).Show ();
		}

		private void mnuNew_Click ( object sender, EventArgs e )
		{
			New ();
		}

		private void mnuExit_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void mnuOpen_Click ( object sender, EventArgs e )
		{
			Open ();
		}

		private void mnuSave_Click ( object sender, EventArgs e )
		{
			Save ();
		}

		private void mnuSaveAs_Click ( object sender, EventArgs e )
		{
			SaveAs ();
		}

		private void mnuUndo_Click ( object sender, EventArgs e )
		{
			Undo ();
		}

		private void mnuRedo_Click ( object sender, EventArgs e )
		{
			Redo ();
		}

		private void mnuCut_Click ( object sender, EventArgs e )
		{
			Cut ();
		}

		private void mnuCopy_Click ( object sender, EventArgs e )
		{
			Copy ();
		}

		private void mnuPaste_Click ( object sender, EventArgs e )
		{
			Paste ();
		}

		private void mnuDel_Click ( object sender, EventArgs e )
		{
			Delete ();
		}

		private void tsUndo_Click ( object sender, EventArgs e )
		{
			Undo ();
		}

		private void tsRedo_Click ( object sender, EventArgs e )
		{
			Redo ();
		}

		private void tsCut_Click ( object sender, EventArgs e )
		{
			Cut ();
		}

		private void tsCopy_Click ( object sender, EventArgs e )
		{
			Copy ();
		}

		private void tsPaste_Click ( object sender, EventArgs e )
		{
			Paste ();
		}

		private void lstQuestion_MouseDoubleClick ( object sender, MouseEventArgs e )
		{
			if ( lstQuestion.FocusedItem == null ) return;
			pgQuestion.SelectedObject = eduMan.Question [ lstQuestion.FocusedItem.Index ];
			selectedIndex = lstQuestion.FocusedItem.Index;
		}

		private void mnuAdd_Click ( object sender, EventArgs e )
		{
			AddQuestion ();
		}

		private void mnuRemove_Click ( object sender, EventArgs e )
		{
			RemoveQuestion ();
		}

		private void tsAdd_Click ( object sender, EventArgs e )
		{
			AddQuestion ();
		}

		private void tsRemove_Click ( object sender, EventArgs e )
		{
			RemoveQuestion ();
		}

		private void pgQuestion_PropertyValueChanged ( object s, PropertyValueChangedEventArgs e )
		{
			lstQuestion.Items [ selectedIndex ].Text = ( ( EpQuestion ) pgQuestion.SelectedObject ).Question;

			saveOk = false;
			SetTitle ();
		}

		private void mnuFindTheme_Click ( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.Filter = "Education Plus Theme 파일(*.eptf)|*.eptf";

			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;

			FileStream fs = new FileStream ( ofd.FileName, FileMode.Open );
			byte [] dat = new byte [ fs.Length ];
			fs.Read ( dat, 0, ( int ) fs.Length );
			eduMan.Theme.SetData ( dat );
			fs.Close ();
			fs.Dispose ();

			saveOk = false;
			SetTitle ();
		}

		private void mnuThemeEdit_Click ( object sender, EventArgs e )
		{
			new frmThemeEdit ().Show ();
		}

		private void frmMain_FormClosing ( object sender, FormClosingEventArgs e )
		{
			if ( !SaveCheck ) e.Cancel = true;
		}

		private void tsNew_Click ( object sender, EventArgs e )
		{
			New ();
		}

		private void tsOpen_Click ( object sender, EventArgs e )
		{
			Open ();
		}

		private void tsSave_Click ( object sender, EventArgs e )
		{
			Save ();
		}

		private void tsPresent_Click ( object sender, EventArgs e )
		{
			Present ();
		}

		private void mnuPresent_Click ( object sender, EventArgs e )
		{
			Present ();
		}

		private void mnuAbout_Click ( object sender, EventArgs e )
		{
			new frmAbout ().ShowDialog ();
		}

		private void mnuOption_Click ( object sender, EventArgs e )
		{
			new frmOption ().ShowDialog ();
		}

		private void mnuHelpContent_Click ( object sender, EventArgs e )
		{
			new frmHelp ().Show ();
		}

		private void tsHelp_Click ( object sender, EventArgs e )
		{
			new frmHelp ().Show ();
		}

		private void mnuTeamNavi_Click ( object sender, EventArgs e )
		{
			frmTeam t = new frmTeam ();
			t.ControlBox = true;
			t.ShowDialog ();
		}

		private void mnuFileServer_Click ( object sender, EventArgs e )
		{
			this.Hide ();
			new frmFileServer ().ShowDialog ();
			this.Show ();
		}

		private void mnuShortcut_Click ( object sender, EventArgs e )
		{
			if ( !File.Exists ( "Interop.IWshRuntimeLibrary.dll" ) )
			{
				MessageBox.Show ( "Windows Script Host Runtime Library의 " +
					"Interop 파일이 존재하지 않아 바로가기 기능을 수행할 수 없었습니다."
					+ "\n기능을 수행하려면 환경 설정에서 Interop 생성 기능을 사용하십시오." );
				return;
			}

			this.Hide ();
			new frmShortcut ().ShowDialog ();
			this.Show ();
		}

		private void mnuOpenFromFileServer_Click ( object sender, EventArgs e )
		{
			this.Hide ();
			new frmOpenFromFileServer ().ShowDialog ();
			this.Show ();
		}

		private void mnuLastVerConvert_Click ( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.Filter = "초기 버전 Education Plus 파일(*.epf)|*.epf";

			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;

			byte [] data = File.ReadAllBytes ( ofd.FileName );
			int chkver = 0;
			using ( MemoryStream temp = new MemoryStream ( data ) )
			{
				BinaryReader tempb = new BinaryReader ( temp );
				chkver = tempb.ReadInt32 ();
				tempb.Close ();
				temp.Close ();
			}

			if ( chkver == 0xDEAD )
			{
				MessageBox.Show ( "이 파일은 초기 버전의 문제 파일이 아닙니다." );
				return;
			}

			using ( MemoryStream mem = new MemoryStream () )
			{
				BinaryWriter b = new BinaryWriter ( mem );
				b.Write ( 0xDEAD );
				b.Write ( data );
				b.Close ();

				File.WriteAllBytes ( ofd.FileName, mem.ToArray () );
				mem.Close ();
			}

			MessageBox.Show ( "변환에 성공하였습니다!" );
		}

		private void mnuApplicator_Click ( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.Filter = "Education Plus 파일(*.epf)|*.epf";

			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;

			SaveFileDialog sfd = new SaveFileDialog ();
			sfd.Filter = "Executor - Applicator 실행 파일(*.exe)|*.exe";

			if ( sfd.ShowDialog () == DialogResult.Cancel ) return;

			byte [] file = File.ReadAllBytes ( ofd.FileName );
			DataReverse ( file );

			byte [] myfile = File.ReadAllBytes ( Application.ExecutablePath );

			FileStream fs = new FileStream ( sfd.FileName, FileMode.OpenOrCreate );
			fs.Write ( myfile, 0, myfile.Length );
			fs.Write ( file, 0, file.Length );
			fs.Close ();
			fs.Dispose ();

			MessageBox.Show ( "애플리케이터 작업에 성공하였습니다!\n" +
				"에그제큐터 파일은 " + sfd.FileName + " 의 위치에 있습니다.",
				"애플리케이터 안내", MessageBoxButtons.OK, MessageBoxIcon.Information );
		}

		public static void DataReverse ( byte [] data )
		{
			for ( int i = 0; i < data.Length / 2; i++ )
			{
				byte temp = data [ i ];
				data [ i ] = data [ data.Length - 1 - i ];
				data [ data.Length - 1 - i ] = temp;
			}
		}

		private void mnuQuestRemoveAll_Click ( object sender, EventArgs e )
		{
			eduMan.Question.Clear ();
			lstQuestion.Items.Clear ();
		}
	}
}