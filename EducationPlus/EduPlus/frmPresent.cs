using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EduPlus.Properties;
using System.Runtime.InteropServices;

namespace EduPlus
{
	/// <summary>
	/// 메시지 타입
	/// </summary>
	public enum MsgType
	{ 
		/// <summary>
		/// 첫번째 문제
		/// </summary>
		IsFirst = 0,
		/// <summary>
		/// 마지막 문제
		/// </summary>
		IsLast,
		/// <summary>
		/// 정답
		/// </summary>
		IsCorrect,
		/// <summary>
		/// 오답
		/// </summary>
		IsIncorrect,
	}

	/// <summary>
	/// 발표용 윈도
	/// </summary>
	public partial class frmPresent : Form
	{
		EduManager eduMan;						//< 에듀 플러스 퀘스천 매니저
		int qIndex = 0;							//< 퀘스천 인덱스
		int eIndex = 0;							//< 이그잼플 인덱스
		MsgType msgType;
		bool msgShow = false;					//< 메시지 박스를 띄웠는가
		bool rollover = false;
		string msgText = "";

		Bitmap backBuf;							//< 백 버퍼
		Graphics g;								//< 백 버퍼의 그래픽스 클래스

		frmTeam TeamNavi;

		Point backLoc = new Point ( 400 - Resources.msgBack.Width / 2, 300 - Resources.msgBack.Height / 2 );

		/// <summary>
		/// 발표용 윈도 생성
		/// </summary>
		/// <param name="eduMan">편집된 에듀 플러스 퀘스천 매니저</param>
		public frmPresent (ref EduManager eduMan)
		{
			InitializeComponent ();
			this.eduMan = eduMan;

			backBuf = new Bitmap ( 800, 600 );
			g = Graphics.FromImage ( backBuf );
		}

		public void UnshowMsg()
		{
			msgShow = false;
			if ( msgType == MsgType.IsCorrect )
			{
				if ( qIndex == eduMan.Question.Count - 1 )
				{
					msgText = "문제를 모두 풀었습니다.";
					msgType = MsgType.IsLast;
					msgShow = true;
				}
				else
				{
					qIndex++;
					eIndex = 0;
				}

				if ( TeamNavi.numPoint.Enabled )
					TeamNavi.numPoint.Value++;
			}
		}

		public void ShowSubject ()
		{
			frmSubject sub = new frmSubject ( eduMan.Question[qIndex].Examples );
			DialogResult dr = sub.ShowDialog ();

			if ( dr == DialogResult.Cancel )
			{
				msgText = "입력한 답에 정답에 필요한 단어가 하나도 들어있지 않습니다.";
				msgType = MsgType.IsIncorrect;
				msgShow = true;
			}
			else if ( dr == DialogResult.Yes )
			{
				msgText = "입력한 답에 정답에 단어가 하나 이상 들어있습니다.";
				msgType = MsgType.IsIncorrect;
				msgShow = true;
			}
			else if ( dr == DialogResult.OK )
			{
				msgText = "정답입니다.";
				msgType = MsgType.IsCorrect;
				msgShow = true;	
			}
		}

		private void frmPresent_KeyDown ( object sender, KeyEventArgs e )
		{
			switch ( e.KeyCode )
			{ 
				// 왼쪽 키 혹은 PgUp 키를 눌렀을 경우
				case Keys.Left:
				case Keys.PageUp:
					// 메시지 박스가 떠있다면 나간다
					if ( msgShow ) break;
					// 문제의 테마타입이 보기가 그림인 테마인 경우 보기를 이동시킨다
					if ( eduMan.Question[qIndex].ThemeType == ThemeType.보기가_그림인_테마 )
						if ( e.KeyCode == Keys.Left )
							goto case Keys.Up;
					// 문제 인덱스가 처음일 경우 메시지 박스를 띄운다
					if ( qIndex == 0 )
					{
						msgText = "문제의 시작입니다.";
						msgType = MsgType.IsFirst;
						msgShow = true;
					}
					else
					{
						qIndex--;
						eIndex = 0;
					}
					break;
				// 오른쪽 키 혹은 PgDn 키를 눌렀을 경우
				case Keys.Right:
				case Keys.PageDown:
					// 메시지 박스가 떠있다면 나간다
					if ( msgShow ) break;
					// 문제의 테마타입이 보기가 그림인 테마인 경우 보기를 이동시킨다
					if ( eduMan.Question[qIndex].ThemeType == ThemeType.보기가_그림인_테마 )
						if ( e.KeyCode == Keys.Right )
							goto case Keys.Down;
					// 문제 인덱스가 끝일 경우 메시지 박스를 띄운다
					if ( qIndex == eduMan.Question.Count - 1 )
					{
						msgText = "문제의 끝입니다.";
						msgType = MsgType.IsLast;
						msgShow = true;
					}
					else
					{
						qIndex++;
						eIndex = 0;
					}
					break;
				case Keys.Up:
					{
						// 메시지 박스가 떠있다면 나간다
						if ( msgShow ) break;
						if ( eduMan.Question[qIndex].ThemeType == ThemeType.기본_테마_형식 ||
							( eduMan.Question[qIndex].ThemeType == ThemeType.보기가_그림인_테마 && e.KeyCode == Keys.Left ) )
						{
							if ( eIndex > 0 )
								eIndex--;
							else
								eIndex = eduMan.Question[qIndex].Examples.Count - 1;
						}
						else
						{
							if ( eIndex > 1 )
								eIndex -= 2;
							else
								eIndex = eduMan.Question[qIndex].Examples.Count - 1;	
						}
					}
					break;
				case Keys.Down:
					{
						// 메시지 박스가 떠있다면 나간다
						if ( msgShow ) break;
						if ( eduMan.Question[qIndex].ThemeType == ThemeType.기본_테마_형식 ||
							( eduMan.Question[qIndex].ThemeType == ThemeType.보기가_그림인_테마 && e.KeyCode == Keys.Right ) )
						{
							if ( eIndex < eduMan.Question[qIndex].Examples.Count - 1 )
								eIndex++;
							else
								eIndex = 0;
						}
						else
						{
							if ( eIndex < eduMan.Question[qIndex].Examples.Count - 2 )
								eIndex += 2;
							else
								eIndex = 0;
						}
					}
					break;
				case Keys.Enter:
					{
						// 메시지 박스가 떠있다면 메시지 박스를 끈다
						if ( msgShow )
						{
							UnshowMsg ();
							break;
						}
						else
						{
							if ( eduMan.Question[qIndex].QuestionType == QType.객관식 )
							{
								if ( eduMan.Question[qIndex].Examples.Count == 0 )
								{
									msgText = "객관식 문제이지만 보기가 없습니다.";
									msgType = MsgType.IsCorrect;
									msgShow = true;
								}
								else
								{
									if ( eduMan.Question[qIndex].Examples[eIndex].IsAnswer )
									{
										msgText = "정답입니다!";
										msgType = MsgType.IsCorrect;
										msgShow = true;
									}
									else
									{
										msgText = "오답입니다.";
										msgType = MsgType.IsIncorrect;
										msgShow = true;
									}
								}
							}
							else
							{
								// 주관식 처리
								ShowSubject ();
							}
						}
					}
					break;
				// Esc 키를 눌렀을 경우
				case Keys.Escape:
					{
						// 메시지 박스가 떠있다면 메시지 박스를 끈다
						if ( msgShow )
						{
							UnshowMsg ();
							break;
						}
						// 아닐 경우 창을 닫는다.
						this.Close ();
					}
					break;
			}

			Refresh ();
		}

		private void frmPresent_Paint ( object sender, PaintEventArgs e )
		{
			// 인덱스를 가져온다
			int tIn = ( int ) eduMan.Question[qIndex].ThemeType;

			g.Clear ( Color.White );

			// 배경 그림이 있다면 그린다
			if ( eduMan.Theme.Image != null )
			{
				g.DrawImage ( eduMan.Theme.Image, new Rectangle ( 0, 0, 800, 600 ),
					new Rectangle ( 0, 0, eduMan.Theme.Image.Width, eduMan.Theme.Image.Height ),
					GraphicsUnit.Pixel );
			}

			// 제목을 출력한다
			g.DrawString ( eduMan.Question[qIndex].Question, new Font ( eduMan.Theme.TitleFont, eduMan.Theme.TitleFontSize ),
				new SolidBrush ( eduMan.Theme.TitleColor ), eduMan.Theme.Title[tIn] );

			// 힌트를 출력한다
			g.DrawString ( eduMan.Question[qIndex].Hint, new Font ( eduMan.Theme.HintFont, eduMan.Theme.HintFontSize ),
				new SolidBrush ( eduMan.Theme.TitleColor ), eduMan.Theme.Hint[tIn] );


			Font font = new Font ( eduMan.Theme.ExampleFont, eduMan.Theme.ExampleFontSize );
			Rectangle r = eduMan.Theme.Example[tIn];

			// 테마 타입에 따라 보기를 다르게 그린다
			switch ( eduMan.Question[qIndex].ThemeType )
			{
				case ThemeType.기본_테마_형식:
					{	
						if ( eduMan.Question[qIndex].QuestionType == QType.객관식 )
						{
							g.Clip = new Region ( eduMan.Theme.Example[tIn] );

							int idx = 0;
							foreach ( EpExample ex in eduMan.Question[qIndex].Examples )
							{
								Color clr = eduMan.Theme.ExampleColor;

								if ( eIndex == idx )
								{
									clr = Color.Red;
								}

								string fmt = String.Format ( "{0:0}. ", idx + 1 );
								g.DrawString ( fmt + ex.Example, font, new SolidBrush ( clr ),
									new Rectangle ( r.X, r.Y + ( idx * eduMan.Theme.ExampleSpace ), r.Width, 120 ) );

								idx++;
							}

							g.Clip = new Region ();
						}
						else
						{
							g.DrawRectangle ( new Pen ( eduMan.Theme.ExampleColor, 2 ), eduMan.Theme.Example[tIn] );
							g.DrawString ( "주관식 문제입니다. 네모 안쪽을 클릭해주세요.", font,
								new SolidBrush ( eduMan.Theme.ExampleColor ), r );
						}
					}
					break;
				case ThemeType.보기가_그림인_테마:
					{ 
						if ( eduMan.Question[qIndex].QuestionType == QType.객관식 )
						{
							g.Clip = new Region ( eduMan.Theme.Example[tIn] );

							for ( int i = 0; i < eduMan.Question[qIndex].Examples.Count; i++ )
							{
								EpExample ea = eduMan.Question[qIndex].Examples[i];
								Rectangle dest = new Rectangle ();

								if ( i == 0 || i % 2 == 0 )
								{
									dest = new Rectangle (
												eduMan.Theme.Example[tIn].X,
												eduMan.Theme.Example[tIn].Y + ( eduMan.Theme.ImageExampleSize.Height +
													eduMan.Theme.ImageExampleSpace ) * ( i / 2 ),
												eduMan.Theme.ImageExampleSize.Width,
												eduMan.Theme.ImageExampleSize.Height
												);
								}
								else
								{
									dest = new Rectangle (
												eduMan.Theme.Example[tIn].X + eduMan.Theme.ImageExampleSpace +
													eduMan.Theme.ImageExampleSize.Width,
												eduMan.Theme.Example[tIn].Y + ( eduMan.Theme.ImageExampleSpace +
													eduMan.Theme.ImageExampleSize.Height ) * ( i / 2 ),
												eduMan.Theme.ImageExampleSize.Width,
												eduMan.Theme.ImageExampleSize.Height
												);
								}

								if ( ea.Image != null )
									g.DrawImage ( ea.Image, dest, new Rectangle ( 0, 0, ea.Image.Width, ea.Image.Height ),
										GraphicsUnit.Pixel );

								if ( eIndex == i )
								{
									g.DrawRectangle ( new Pen ( Color.Red, 2 ), dest );
								}
							}
						}
						else
						{
							g.DrawRectangle ( new Pen ( eduMan.Theme.ExampleColor, 2 ), eduMan.Theme.Example[tIn] );
							g.DrawString ( "주관식 문제입니다. 네모 안쪽을 클릭해주세요.", font, 
								new SolidBrush ( eduMan.Theme.ExampleColor ), r );
						}

						g.Clip = new Region ();
					}
					break;
			}

			// 이미지를 그린다.
			if ( eduMan.Question[qIndex].Image != null )
			{
				Image img = eduMan.Question[qIndex].Image;
				g.DrawImage ( img,
					eduMan.Theme.ImageLocation, new Rectangle ( 0, 0, img.Width, img.Height ),
					GraphicsUnit.Pixel );
			}

			// 메시지박스를 띄운 상태일 경우 메시지박스를 그린다
			if ( msgShow )
			{
				g.DrawImage ( Resources.msgBack, backLoc );
				Point btnLoc = new Point ( backLoc.X + Resources.msgBack.Width / 2 - Resources.msgButton.Width / 2, 
					backLoc.Y + 270 );
				g.DrawImage ( ( ( rollover ) ? Resources.msgButtonDown : Resources.msgButton ), btnLoc );

				Font msgFont = new Font ( "맑은 고딕", 24 );
				g.DrawString ( msgText, msgFont, new SolidBrush ( Color.Black ),
					new Rectangle (
						backLoc.X + 40,
						backLoc.Y + 40, 
						Resources.msgBack.Width - 80, 
						Resources.msgBack.Height - 20 ) );
				Font btnFont = new Font ( "맑은 고딕", 14 );
				g.DrawString ( "OK", btnFont, new SolidBrush ( Color.Black ),
					new PointF (
						btnLoc.X + Resources.msgButton.Width / 2 - ( btnFont.GetHeight () * "OK".Length ) / 2,
						btnLoc.Y + Resources.msgButton.Height / 2 - btnFont.GetHeight() / 2 ) );
			}

			// 백 버퍼를 화면에 출력한다
			e.Graphics.DrawImage ( backBuf, new Rectangle ( 0, 0, this.Width, this.Height ),
				new Rectangle ( 0, 0, 800, 600 ), GraphicsUnit.Pixel );
		}

		private void frmPresent_Shown ( object sender, EventArgs e )
		{
			TeamNavi = new frmTeam ();
			TeamNavi.Show ();
			TeamNavi.Location = new Point ( Screen.PrimaryScreen.WorkingArea.Width - TeamNavi.Width, 0 );

			// 창이 띄워지면 포커스를 발표 윈도로 맞춘다
			Focus ();

			tmrChkTeamNavi.Enabled = true;
		}

		private void frmPresent_MouseMove ( object sender, MouseEventArgs e )
		{
			// 이 프로시저는 메시지 박스가 띄워져 있는 상태에서만 적용된다
			if ( !msgShow ) return;

			Point btnLoc = new Point ( backLoc.X + Resources.msgBack.Width / 2 - Resources.msgButton.Width / 2,
					backLoc.Y + 270 );

			int x = ( int ) ( e.X * ( ( double ) 800 / ( double ) Width ) );
			int y = ( int ) ( e.Y * ( ( double ) 600 / ( double ) Height ) );

			if ( btnLoc.X <= x + 1 && x <= btnLoc.X + Resources.msgButton.Width &&
				btnLoc.Y <= y + 1 && y <= btnLoc.Y + Resources.msgButton.Height )
			{
				rollover = true;
			}
			else
			{
				rollover = false;
			}

			Refresh ();
		}

		private void frmPresent_MouseClick ( object sender, MouseEventArgs e )
		{
			if ( msgShow )
			{
				if ( rollover )
				{
					UnshowMsg ();
					Refresh ();
				}
			}
			else
			{
				if ( eduMan.Question[qIndex].QuestionType == QType.주관식 && e.Button == MouseButtons.Left )
				{
					Rectangle ex = eduMan.Theme.Example[( int ) eduMan.Question[qIndex].ThemeType];
					int x = ( int ) ( e.X * ( ( double ) 800 / ( double ) Width ) );
					int y = ( int ) ( e.Y * ( ( double ) 600 / ( double ) Height ) );

					if ( x <= ex.X + ex.Width && ex.X <= x + 1 &&
						y <= ex.Y + ex.Height && ex.Y <= y + 1 )
					{
						ShowSubject ();
					}
				}
			}
		}

		private void frmPresent_FormClosing ( object sender, FormClosingEventArgs e )
		{
			TeamNavi.Close ();
		}

		private void tmrChkTeamNavi_Tick ( object sender, EventArgs e )
		{
			Application.DoEvents ();

			if ( TeamNavi == null )
			{
				this.Close ();
			}
			else
			{
				if ( !TeamNavi.Created )
					this.Close ();
			}
		}
	}
}