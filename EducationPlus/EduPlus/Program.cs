using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace EduPlus
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main (string[] args)
		{
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault ( false );

			// 만약 뒤쪽부터 검사하여 파일 버전이 검출되면 발표 모드로 실행한다
			{
				byte [] data = File.ReadAllBytes ( Application.ExecutablePath );
				frmMain.DataReverse ( data );
				MemoryStream mem = new MemoryStream ( data );
				BinaryReader b = new BinaryReader ( mem );
				if ( b.ReadInt32 () == 0xDEAD )
				{
					EduManager edu = new EduManager ();
					mem = new MemoryStream ( data );
					edu.Load ( mem );
					new frmPresent ( ref edu ).ShowDialog ();
					return;
				}
			}

			// 명령인자가 없다면 편집모드를 실행한다
			if ( args.Length == 0 )
				Application.Run ( new frmMain () );
			else
			{
				switch ( args [ 0 ] )
				{
					case "-pre":
					case "/발표":
						{
							// 명령인자가 2개 이상이 아닐 경우 오류
							if ( args.Length < 2 )
							{
								MessageBox.Show ( "파일 경로를 지정해주세요." );
							}
							// args[1]이 파일로 존재하지 않는다면 오류
							if ( !File.Exists ( args [ 1 ] ) )
							{
								MessageBox.Show ( "파일 경로가 올바르지 않습니다." );
							}

							// 에듀 플러스 파일을 불러온다
							FileStream fs = new FileStream ( args [ 1 ], FileMode.Open );
							EduManager eduMan = new EduManager ();
							eduMan.Load ( fs );
							fs.Close ();
							fs.Dispose ();

							// 발표를 시작한다
							Application.Run ( new frmPresent ( ref eduMan ) );
						}
						break;
					case "-h":
					case "-?":
					case "/도움말":
						{
							Application.Run ( new frmHelp () );
						}
						break;
					case "-opt":
					case "/환경설정":
					case "/옵션":
						{
							Application.Run ( new frmOption () );
						}
						break;
					case "-theme":
					case "-thm":
					case "/테마":
						{
							if ( args.Length >= 2 )
							{
								if ( File.Exists ( args [ 1 ] ) )
								{
									Application.Run ( new frmThemeEdit ( args [ 1 ] ) );
								}
								else
								{
									MessageBox.Show ( "파일 경로가 올바르지 않습니다." );
								}
							}
							else
							{
								Application.Run ( new frmThemeEdit () );
							}
						}
						break;
					case "-netpre":
					case "-np":
					case "/넷발표":
						Application.Run ( new frmOpenFromFileServer () );
						break;
					case "-team":
					case "/팀네비":
						frmTeam team = new frmTeam ();
						team.ControlBox = true;
						Application.Run ( team );
						break;
					case "-fserv":
					case "/파일서버":
						Application.Run ( new frmFileServer () );
						break;
					default:
						{
							// args[0]이 파일로 존재한다면 해당 파일을 편집모드로 연다
							if ( File.Exists ( args [ 0 ] ) )
								Application.Run ( new frmMain ( args [ 0 ] ) );
							// 파일로 존재하지 않는다면 오류
							else
							{
								MessageBox.Show ( "명령어가 잘못됬거나 파일이 없습니다." );
							}
						}
						break;
				}
			}
		}
	}
}
