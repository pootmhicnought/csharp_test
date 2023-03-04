namespace EduPlus
{
	partial class frmMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmMain ) );
			this.mnuMain = new System.Windows.Forms.MenuStrip ();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuNew = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuOpenFromFileServer = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuCut = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuDel = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuQuestion = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuQuestRemoveAll = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuTheme = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuFindTheme = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuThemeEdit = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuPresent = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuTeamNavi = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuShortcut = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuOption = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuFileServer = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuLastVerConvert = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuExecutor = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuApplicator = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuHelpContent = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem ();
			this.tsMain = new System.Windows.Forms.ToolStrip ();
			this.tsNew = new System.Windows.Forms.ToolStripButton ();
			this.tsOpen = new System.Windows.Forms.ToolStripButton ();
			this.tsSave = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsUndo = new System.Windows.Forms.ToolStripButton ();
			this.tsRedo = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsCut = new System.Windows.Forms.ToolStripButton ();
			this.tsCopy = new System.Windows.Forms.ToolStripButton ();
			this.tsPaste = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsAdd = new System.Windows.Forms.ToolStripButton ();
			this.tsRemove = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsPresent = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsHelp = new System.Windows.Forms.ToolStripButton ();
			this.sttMain = new System.Windows.Forms.StatusStrip ();
			this.tspbMarquee = new System.Windows.Forms.ToolStripProgressBar ();
			this.tssVersion = new System.Windows.Forms.ToolStripStatusLabel ();
			this.scMain = new System.Windows.Forms.SplitContainer ();
			this.lstQuestion = new System.Windows.Forms.ListView ();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader ();
			this.pgQuestion = new System.Windows.Forms.PropertyGrid ();
			this.mnuMain.SuspendLayout ();
			this.tsMain.SuspendLayout ();
			this.sttMain.SuspendLayout ();
			this.scMain.Panel1.SuspendLayout ();
			this.scMain.Panel2.SuspendLayout ();
			this.scMain.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// mnuMain
			// 
			this.mnuMain.ImageScalingSize = new System.Drawing.Size ( 14, 14 );
			this.mnuMain.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuQuestion,
            this.mnuTheme,
            this.mnuTools,
            this.mnuHelp} );
			this.mnuMain.Location = new System.Drawing.Point ( 0, 0 );
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size ( 526, 24 );
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.AutoToolTip = true;
			this.mnuFile.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuOpenFromFileServer,
            this.toolStripMenuItem1,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripMenuItem2,
            this.mnuExit} );
			this.mnuFile.Image = global::EduPlus.Properties.Resources.script;
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size ( 71, 20 );
			this.mnuFile.Text = "파일(&F)";
			this.mnuFile.ToolTipText = "파일 관련 작업을 수행합니다.";
			// 
			// mnuNew
			// 
			this.mnuNew.Image = global::EduPlus.Properties.Resources.page;
			this.mnuNew.Name = "mnuNew";
			this.mnuNew.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N ) ) );
			this.mnuNew.Size = new System.Drawing.Size ( 280, 22 );
			this.mnuNew.Text = "새 파일(&N)";
			this.mnuNew.Click += new System.EventHandler ( this.mnuNew_Click );
			// 
			// mnuOpen
			// 
			this.mnuOpen.Image = global::EduPlus.Properties.Resources.folder;
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
			this.mnuOpen.Size = new System.Drawing.Size ( 280, 22 );
			this.mnuOpen.Text = "열기(&O)";
			this.mnuOpen.Click += new System.EventHandler ( this.mnuOpen_Click );
			// 
			// mnuOpenFromFileServer
			// 
			this.mnuOpenFromFileServer.Name = "mnuOpenFromFileServer";
			this.mnuOpenFromFileServer.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift )
						| System.Windows.Forms.Keys.O ) ) );
			this.mnuOpenFromFileServer.Size = new System.Drawing.Size ( 280, 22 );
			this.mnuOpenFromFileServer.Text = "파일 서버로부터 열기(&E)";
			this.mnuOpenFromFileServer.Click += new System.EventHandler ( this.mnuOpenFromFileServer_Click );
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size ( 277, 6 );
			// 
			// mnuSave
			// 
			this.mnuSave.Image = global::EduPlus.Properties.Resources.disk;
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S ) ) );
			this.mnuSave.Size = new System.Drawing.Size ( 280, 22 );
			this.mnuSave.Text = "저장(&S)";
			this.mnuSave.Click += new System.EventHandler ( this.mnuSave_Click );
			// 
			// mnuSaveAs
			// 
			this.mnuSaveAs.Name = "mnuSaveAs";
			this.mnuSaveAs.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift )
						| System.Windows.Forms.Keys.S ) ) );
			this.mnuSaveAs.Size = new System.Drawing.Size ( 280, 22 );
			this.mnuSaveAs.Text = "새 이름으로 저장(&A)";
			this.mnuSaveAs.Click += new System.EventHandler ( this.mnuSaveAs_Click );
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size ( 277, 6 );
			// 
			// mnuExit
			// 
			this.mnuExit.Image = global::EduPlus.Properties.Resources.door;
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4 ) ) );
			this.mnuExit.Size = new System.Drawing.Size ( 280, 22 );
			this.mnuExit.Text = "종료(&X)";
			this.mnuExit.Click += new System.EventHandler ( this.mnuExit_Click );
			// 
			// mnuEdit
			// 
			this.mnuEdit.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripMenuItem3,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDel} );
			this.mnuEdit.Image = global::EduPlus.Properties.Resources.pencil;
			this.mnuEdit.Name = "mnuEdit";
			this.mnuEdit.Size = new System.Drawing.Size ( 71, 20 );
			this.mnuEdit.Text = "편집(&E)";
			// 
			// mnuUndo
			// 
			this.mnuUndo.Image = global::EduPlus.Properties.Resources.arrow_undo;
			this.mnuUndo.Name = "mnuUndo";
			this.mnuUndo.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z ) ) );
			this.mnuUndo.Size = new System.Drawing.Size ( 183, 22 );
			this.mnuUndo.Text = "실행 취소(&U)";
			this.mnuUndo.Click += new System.EventHandler ( this.mnuUndo_Click );
			// 
			// mnuRedo
			// 
			this.mnuRedo.Image = global::EduPlus.Properties.Resources.arrow_redo;
			this.mnuRedo.Name = "mnuRedo";
			this.mnuRedo.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y ) ) );
			this.mnuRedo.Size = new System.Drawing.Size ( 183, 22 );
			this.mnuRedo.Text = "반복(&R)";
			this.mnuRedo.Click += new System.EventHandler ( this.mnuRedo_Click );
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size ( 180, 6 );
			// 
			// mnuCut
			// 
			this.mnuCut.Image = global::EduPlus.Properties.Resources.cut;
			this.mnuCut.Name = "mnuCut";
			this.mnuCut.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X ) ) );
			this.mnuCut.Size = new System.Drawing.Size ( 183, 22 );
			this.mnuCut.Text = "잘라내기(&T)";
			this.mnuCut.Click += new System.EventHandler ( this.mnuCut_Click );
			// 
			// mnuCopy
			// 
			this.mnuCopy.Image = global::EduPlus.Properties.Resources.page_copy;
			this.mnuCopy.Name = "mnuCopy";
			this.mnuCopy.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C ) ) );
			this.mnuCopy.Size = new System.Drawing.Size ( 183, 22 );
			this.mnuCopy.Text = "복사(&C)";
			this.mnuCopy.Click += new System.EventHandler ( this.mnuCopy_Click );
			// 
			// mnuPaste
			// 
			this.mnuPaste.Image = global::EduPlus.Properties.Resources.paste_plain;
			this.mnuPaste.Name = "mnuPaste";
			this.mnuPaste.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V ) ) );
			this.mnuPaste.Size = new System.Drawing.Size ( 183, 22 );
			this.mnuPaste.Text = "붙여넣기(&P)";
			this.mnuPaste.Click += new System.EventHandler ( this.mnuPaste_Click );
			// 
			// mnuDel
			// 
			this.mnuDel.Name = "mnuDel";
			this.mnuDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.mnuDel.Size = new System.Drawing.Size ( 183, 22 );
			this.mnuDel.Text = "삭제(&D)";
			this.mnuDel.Click += new System.EventHandler ( this.mnuDel_Click );
			// 
			// mnuQuestion
			// 
			this.mnuQuestion.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuAdd,
            this.mnuRemove,
            this.toolStripSeparator8,
            this.mnuQuestRemoveAll} );
			this.mnuQuestion.Image = global::EduPlus.Properties.Resources.page_white_key;
			this.mnuQuestion.Name = "mnuQuestion";
			this.mnuQuestion.Size = new System.Drawing.Size ( 74, 20 );
			this.mnuQuestion.Text = "문제(&Q)";
			// 
			// mnuAdd
			// 
			this.mnuAdd.Image = global::EduPlus.Properties.Resources.page_add;
			this.mnuAdd.Name = "mnuAdd";
			this.mnuAdd.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A ) ) );
			this.mnuAdd.Size = new System.Drawing.Size ( 186, 22 );
			this.mnuAdd.Text = "문제 추가(&A)";
			this.mnuAdd.Click += new System.EventHandler ( this.mnuAdd_Click );
			// 
			// mnuRemove
			// 
			this.mnuRemove.Image = global::EduPlus.Properties.Resources.page_delete;
			this.mnuRemove.Name = "mnuRemove";
			this.mnuRemove.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D ) ) );
			this.mnuRemove.Size = new System.Drawing.Size ( 186, 22 );
			this.mnuRemove.Text = "문제 제거(&D)";
			this.mnuRemove.Click += new System.EventHandler ( this.mnuRemove_Click );
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size ( 183, 6 );
			// 
			// mnuQuestRemoveAll
			// 
			this.mnuQuestRemoveAll.Name = "mnuQuestRemoveAll";
			this.mnuQuestRemoveAll.Size = new System.Drawing.Size ( 186, 22 );
			this.mnuQuestRemoveAll.Text = "문제 모두 제거(&C)";
			this.mnuQuestRemoveAll.Click += new System.EventHandler ( this.mnuQuestRemoveAll_Click );
			// 
			// mnuTheme
			// 
			this.mnuTheme.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuFindTheme,
            this.toolStripMenuItem4,
            this.mnuThemeEdit} );
			this.mnuTheme.Image = global::EduPlus.Properties.Resources.layout;
			this.mnuTheme.Name = "mnuTheme";
			this.mnuTheme.Size = new System.Drawing.Size ( 76, 20 );
			this.mnuTheme.Text = "테마(&M)";
			// 
			// mnuFindTheme
			// 
			this.mnuFindTheme.Image = global::EduPlus.Properties.Resources.find;
			this.mnuFindTheme.Name = "mnuFindTheme";
			this.mnuFindTheme.Size = new System.Drawing.Size ( 152, 22 );
			this.mnuFindTheme.Text = "테마 찾기(&F)";
			this.mnuFindTheme.Click += new System.EventHandler ( this.mnuFindTheme_Click );
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size ( 149, 6 );
			// 
			// mnuThemeEdit
			// 
			this.mnuThemeEdit.Image = global::EduPlus.Properties.Resources.layout_edit;
			this.mnuThemeEdit.Name = "mnuThemeEdit";
			this.mnuThemeEdit.Size = new System.Drawing.Size ( 152, 22 );
			this.mnuThemeEdit.Text = "테마 편집기(&E)";
			this.mnuThemeEdit.Click += new System.EventHandler ( this.mnuThemeEdit_Click );
			// 
			// mnuTools
			// 
			this.mnuTools.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuPresent,
            this.mnuTeamNavi,
            this.mnuShortcut,
            this.toolStripMenuItem5,
            this.mnuOption,
            this.toolStripSeparator5,
            this.mnuFileServer,
            this.mnuLastVerConvert,
            this.toolStripSeparator7,
            this.mnuExecutor} );
			this.mnuTools.Image = global::EduPlus.Properties.Resources.application;
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size ( 71, 20 );
			this.mnuTools.Text = "도구(&T)";
			// 
			// mnuPresent
			// 
			this.mnuPresent.Image = global::EduPlus.Properties.Resources.photo;
			this.mnuPresent.Name = "mnuPresent";
			this.mnuPresent.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.mnuPresent.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuPresent.Text = "문제 발표(&P)";
			this.mnuPresent.Click += new System.EventHandler ( this.mnuPresent_Click );
			// 
			// mnuTeamNavi
			// 
			this.mnuTeamNavi.Name = "mnuTeamNavi";
			this.mnuTeamNavi.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuTeamNavi.Text = "팀 네비게이터(&T)";
			this.mnuTeamNavi.Click += new System.EventHandler ( this.mnuTeamNavi_Click );
			// 
			// mnuShortcut
			// 
			this.mnuShortcut.Name = "mnuShortcut";
			this.mnuShortcut.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuShortcut.Text = "바로가기 만들기(&H)";
			this.mnuShortcut.Click += new System.EventHandler ( this.mnuShortcut_Click );
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size ( 179, 6 );
			// 
			// mnuOption
			// 
			this.mnuOption.Image = global::EduPlus.Properties.Resources.cog;
			this.mnuOption.Name = "mnuOption";
			this.mnuOption.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuOption.Text = "환경설정(&O)";
			this.mnuOption.Click += new System.EventHandler ( this.mnuOption_Click );
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size ( 179, 6 );
			// 
			// mnuFileServer
			// 
			this.mnuFileServer.Name = "mnuFileServer";
			this.mnuFileServer.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuFileServer.Text = "파일 서버(&S)";
			this.mnuFileServer.Click += new System.EventHandler ( this.mnuFileServer_Click );
			// 
			// mnuLastVerConvert
			// 
			this.mnuLastVerConvert.Name = "mnuLastVerConvert";
			this.mnuLastVerConvert.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuLastVerConvert.Text = "초기 버전 파일 변환";
			this.mnuLastVerConvert.Click += new System.EventHandler ( this.mnuLastVerConvert_Click );
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size ( 179, 6 );
			// 
			// mnuExecutor
			// 
			this.mnuExecutor.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuApplicator} );
			this.mnuExecutor.Name = "mnuExecutor";
			this.mnuExecutor.Size = new System.Drawing.Size ( 182, 22 );
			this.mnuExecutor.Text = "에그제큐터(&X)";
			// 
			// mnuApplicator
			// 
			this.mnuApplicator.Name = "mnuApplicator";
			this.mnuApplicator.Size = new System.Drawing.Size ( 162, 22 );
			this.mnuApplicator.Text = "애플리케이터(&A)";
			this.mnuApplicator.Click += new System.EventHandler ( this.mnuApplicator_Click );
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuHelpContent,
            this.toolStripMenuItem6,
            this.mnuAbout} );
			this.mnuHelp.Image = global::EduPlus.Properties.Resources.help;
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size ( 86, 20 );
			this.mnuHelp.Text = "도움말(&H)";
			// 
			// mnuHelpContent
			// 
			this.mnuHelpContent.Image = global::EduPlus.Properties.Resources.help;
			this.mnuHelpContent.Name = "mnuHelpContent";
			this.mnuHelpContent.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.mnuHelpContent.Size = new System.Drawing.Size ( 174, 22 );
			this.mnuHelpContent.Text = "도움말 항목(&C)";
			this.mnuHelpContent.Click += new System.EventHandler ( this.mnuHelpContent_Click );
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size ( 171, 6 );
			// 
			// mnuAbout
			// 
			this.mnuAbout.Image = global::EduPlus.Properties.Resources.information;
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size ( 174, 22 );
			this.mnuAbout.Text = "버전 정보(&A)";
			this.mnuAbout.Click += new System.EventHandler ( this.mnuAbout_Click );
			// 
			// tsMain
			// 
			this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsMain.ImageScalingSize = new System.Drawing.Size ( 14, 14 );
			this.tsMain.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.tsNew,
            this.tsOpen,
            this.tsSave,
            this.toolStripSeparator1,
            this.tsUndo,
            this.tsRedo,
            this.toolStripSeparator2,
            this.tsCut,
            this.tsCopy,
            this.tsPaste,
            this.toolStripSeparator3,
            this.tsAdd,
            this.tsRemove,
            this.toolStripSeparator4,
            this.tsPresent,
            this.toolStripSeparator6,
            this.tsHelp} );
			this.tsMain.Location = new System.Drawing.Point ( 0, 24 );
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size ( 526, 25 );
			this.tsMain.TabIndex = 1;
			this.tsMain.Text = "toolStrip1";
			// 
			// tsNew
			// 
			this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsNew.Image = global::EduPlus.Properties.Resources.page;
			this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsNew.Name = "tsNew";
			this.tsNew.Size = new System.Drawing.Size ( 23, 22 );
			this.tsNew.Text = "새 파일";
			this.tsNew.Click += new System.EventHandler ( this.tsNew_Click );
			// 
			// tsOpen
			// 
			this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsOpen.Image = global::EduPlus.Properties.Resources.folder;
			this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsOpen.Name = "tsOpen";
			this.tsOpen.Size = new System.Drawing.Size ( 23, 22 );
			this.tsOpen.Text = "열기";
			this.tsOpen.Click += new System.EventHandler ( this.tsOpen_Click );
			// 
			// tsSave
			// 
			this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsSave.Image = global::EduPlus.Properties.Resources.disk;
			this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsSave.Name = "tsSave";
			this.tsSave.Size = new System.Drawing.Size ( 23, 22 );
			this.tsSave.Text = "저장";
			this.tsSave.Click += new System.EventHandler ( this.tsSave_Click );
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsUndo
			// 
			this.tsUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsUndo.Image = global::EduPlus.Properties.Resources.arrow_undo;
			this.tsUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsUndo.Name = "tsUndo";
			this.tsUndo.Size = new System.Drawing.Size ( 23, 22 );
			this.tsUndo.Text = "실행 취소";
			this.tsUndo.Click += new System.EventHandler ( this.tsUndo_Click );
			// 
			// tsRedo
			// 
			this.tsRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRedo.Image = global::EduPlus.Properties.Resources.arrow_redo;
			this.tsRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRedo.Name = "tsRedo";
			this.tsRedo.Size = new System.Drawing.Size ( 23, 22 );
			this.tsRedo.Text = "반복";
			this.tsRedo.Click += new System.EventHandler ( this.tsRedo_Click );
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsCut
			// 
			this.tsCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsCut.Image = global::EduPlus.Properties.Resources.cut;
			this.tsCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsCut.Name = "tsCut";
			this.tsCut.Size = new System.Drawing.Size ( 23, 22 );
			this.tsCut.Text = "잘라내기";
			this.tsCut.Click += new System.EventHandler ( this.tsCut_Click );
			// 
			// tsCopy
			// 
			this.tsCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsCopy.Image = global::EduPlus.Properties.Resources.page_copy;
			this.tsCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsCopy.Name = "tsCopy";
			this.tsCopy.Size = new System.Drawing.Size ( 23, 22 );
			this.tsCopy.Text = "복사";
			this.tsCopy.Click += new System.EventHandler ( this.tsCopy_Click );
			// 
			// tsPaste
			// 
			this.tsPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsPaste.Image = global::EduPlus.Properties.Resources.paste_plain;
			this.tsPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsPaste.Name = "tsPaste";
			this.tsPaste.Size = new System.Drawing.Size ( 23, 22 );
			this.tsPaste.Text = "붙여넣기";
			this.tsPaste.Click += new System.EventHandler ( this.tsPaste_Click );
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsAdd
			// 
			this.tsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsAdd.Image = global::EduPlus.Properties.Resources.page_add;
			this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsAdd.Name = "tsAdd";
			this.tsAdd.Size = new System.Drawing.Size ( 23, 22 );
			this.tsAdd.Text = "문제 추가";
			this.tsAdd.Click += new System.EventHandler ( this.tsAdd_Click );
			// 
			// tsRemove
			// 
			this.tsRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRemove.Image = global::EduPlus.Properties.Resources.page_delete;
			this.tsRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRemove.Name = "tsRemove";
			this.tsRemove.Size = new System.Drawing.Size ( 23, 22 );
			this.tsRemove.Text = "문제 제거";
			this.tsRemove.Click += new System.EventHandler ( this.tsRemove_Click );
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsPresent
			// 
			this.tsPresent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsPresent.Image = global::EduPlus.Properties.Resources.photo;
			this.tsPresent.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsPresent.Name = "tsPresent";
			this.tsPresent.Size = new System.Drawing.Size ( 23, 22 );
			this.tsPresent.Text = "문제 발표";
			this.tsPresent.Click += new System.EventHandler ( this.tsPresent_Click );
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsHelp
			// 
			this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsHelp.Image = global::EduPlus.Properties.Resources.help;
			this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsHelp.Name = "tsHelp";
			this.tsHelp.Size = new System.Drawing.Size ( 23, 22 );
			this.tsHelp.Text = "도움말";
			this.tsHelp.Click += new System.EventHandler ( this.tsHelp_Click );
			// 
			// sttMain
			// 
			this.sttMain.ImageScalingSize = new System.Drawing.Size ( 14, 14 );
			this.sttMain.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.tspbMarquee,
            this.tssVersion} );
			this.sttMain.Location = new System.Drawing.Point ( 0, 393 );
			this.sttMain.Name = "sttMain";
			this.sttMain.Size = new System.Drawing.Size ( 526, 22 );
			this.sttMain.TabIndex = 2;
			this.sttMain.Text = "statusStrip1";
			// 
			// tspbMarquee
			// 
			this.tspbMarquee.AutoToolTip = true;
			this.tspbMarquee.Name = "tspbMarquee";
			this.tspbMarquee.Size = new System.Drawing.Size ( 100, 16 );
			this.tspbMarquee.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.tspbMarquee.ToolTipText = "현재 아무 기능도 수행하지 않는 진행막대입니다.";
			// 
			// tssVersion
			// 
			this.tssVersion.AutoToolTip = true;
			this.tssVersion.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
			this.tssVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tssVersion.Name = "tssVersion";
			this.tssVersion.Size = new System.Drawing.Size ( 409, 17 );
			this.tssVersion.Spring = true;
			this.tssVersion.Text = "추가 개발용 버전";
			this.tssVersion.ToolTipText = "이 버전은 정보올림피아드 공모부문에 출품하기 위한 버전입니다.";
			// 
			// scMain
			// 
			this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.scMain.Location = new System.Drawing.Point ( 0, 49 );
			this.scMain.Name = "scMain";
			// 
			// scMain.Panel1
			// 
			this.scMain.Panel1.Controls.Add ( this.lstQuestion );
			// 
			// scMain.Panel2
			// 
			this.scMain.Panel2.Controls.Add ( this.pgQuestion );
			this.scMain.Size = new System.Drawing.Size ( 526, 344 );
			this.scMain.SplitterDistance = 197;
			this.scMain.TabIndex = 3;
			// 
			// lstQuestion
			// 
			this.lstQuestion.Columns.AddRange ( new System.Windows.Forms.ColumnHeader [] {
            this.columnHeader1} );
			this.lstQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstQuestion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstQuestion.Location = new System.Drawing.Point ( 0, 0 );
			this.lstQuestion.MultiSelect = false;
			this.lstQuestion.Name = "lstQuestion";
			this.lstQuestion.Size = new System.Drawing.Size ( 197, 344 );
			this.lstQuestion.TabIndex = 0;
			this.lstQuestion.UseCompatibleStateImageBehavior = false;
			this.lstQuestion.View = System.Windows.Forms.View.Details;
			this.lstQuestion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler ( this.lstQuestion_MouseDoubleClick );
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "문제";
			this.columnHeader1.Width = 170;
			// 
			// pgQuestion
			// 
			this.pgQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgQuestion.Location = new System.Drawing.Point ( 0, 0 );
			this.pgQuestion.Name = "pgQuestion";
			this.pgQuestion.Size = new System.Drawing.Size ( 325, 344 );
			this.pgQuestion.TabIndex = 0;
			this.pgQuestion.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler ( this.pgQuestion_PropertyValueChanged );
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 526, 415 );
			this.Controls.Add ( this.scMain );
			this.Controls.Add ( this.sttMain );
			this.Controls.Add ( this.tsMain );
			this.Controls.Add ( this.mnuMain );
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject ( "$this.Icon" ) ) );
			this.MainMenuStrip = this.mnuMain;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "제목 없음.epf - Education Plus";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler ( this.frmMain_FormClosing );
			this.mnuMain.ResumeLayout ( false );
			this.mnuMain.PerformLayout ();
			this.tsMain.ResumeLayout ( false );
			this.tsMain.PerformLayout ();
			this.sttMain.ResumeLayout ( false );
			this.sttMain.PerformLayout ();
			this.scMain.Panel1.ResumeLayout ( false );
			this.scMain.Panel2.ResumeLayout ( false );
			this.scMain.ResumeLayout ( false );
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuNew;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuEdit;
		private System.Windows.Forms.ToolStripMenuItem mnuUndo;
		private System.Windows.Forms.ToolStripMenuItem mnuRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuCut;
		private System.Windows.Forms.ToolStripMenuItem mnuCopy;
		private System.Windows.Forms.ToolStripMenuItem mnuPaste;
		private System.Windows.Forms.ToolStripMenuItem mnuDel;
		private System.Windows.Forms.ToolStripMenuItem mnuQuestion;
		private System.Windows.Forms.ToolStripMenuItem mnuAdd;
		private System.Windows.Forms.ToolStripMenuItem mnuRemove;
		private System.Windows.Forms.ToolStripMenuItem mnuTheme;
		private System.Windows.Forms.ToolStripMenuItem mnuFindTheme;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem mnuThemeEdit;
		private System.Windows.Forms.ToolStripMenuItem mnuTools;
		private System.Windows.Forms.ToolStripMenuItem mnuPresent;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem mnuOption;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpContent;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton tsNew;
		private System.Windows.Forms.ToolStripButton tsOpen;
		private System.Windows.Forms.ToolStripButton tsSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsUndo;
		private System.Windows.Forms.ToolStripButton tsRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsCut;
		private System.Windows.Forms.ToolStripButton tsCopy;
		private System.Windows.Forms.ToolStripButton tsPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsAdd;
		private System.Windows.Forms.ToolStripButton tsRemove;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsPresent;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton tsHelp;
		private System.Windows.Forms.StatusStrip sttMain;
		private System.Windows.Forms.ToolStripStatusLabel tssVersion;
		private System.Windows.Forms.SplitContainer scMain;
		private System.Windows.Forms.ListView lstQuestion;
		private System.Windows.Forms.PropertyGrid pgQuestion;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ToolStripProgressBar tspbMarquee;
		private System.Windows.Forms.ToolStripMenuItem mnuTeamNavi;
		private System.Windows.Forms.ToolStripMenuItem mnuShortcut;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem mnuFileServer;
		private System.Windows.Forms.ToolStripMenuItem mnuOpenFromFileServer;
		private System.Windows.Forms.ToolStripMenuItem mnuLastVerConvert;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem mnuExecutor;
		private System.Windows.Forms.ToolStripMenuItem mnuApplicator;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem mnuQuestRemoveAll;
	}
}

