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
	public partial class frmThemeEdit : Form
	{
		EpTheme theme = new EpTheme ();
		ThemeType editIndex;

		bool saveOk = true;
		string savePath = "";

		public frmThemeEdit ()
		{
			InitializeComponent ();
			cmbThemeType.SelectedIndex = 0;
			pgEdit.SelectedObject = theme;
			saveOk = true;
			SetTitle ();
		}

		public frmThemeEdit ( string filename )
		{
			InitializeComponent ();

			FileStream fs = new FileStream ( filename, FileMode.Open );
			pgEdit.SelectedObject = theme = new EpTheme ();
			byte[] data = new byte[fs.Length];
			fs.Read ( data, 0, ( int ) fs.Length );
			theme.SetData ( data );
			fs.Close ();
			fs.Dispose ();

			cmbThemeType.SelectedIndex = 0;
			pgEdit.SelectedObject = theme;
			saveOk = true;
			savePath = filename;
			SetTitle ();
		}

		public string GetName (string file)
		{
			string[] t = file.Split ( '\\' );
			return t[t.Length - 1];
		}

		public void SetTitle ()
		{
			string fn = ( savePath == "" ) ? "제목 없음.epft" : GetName ( savePath );
			fn += ( !saveOk ) ? "*" : "";
			Text = fn + " - Theme Editor";
		}

		public bool SaveCheck
		{
			get 
			{
				if ( !saveOk )
				{
					DialogResult dr = MessageBox.Show ( "저장하시겠습니까?", "질문", MessageBoxButtons.YesNoCancel,
						MessageBoxIcon.Question );
					switch ( dr )
					{ 
						case DialogResult.Yes:
							return Save ();
						case DialogResult.No:
							return true;
						case DialogResult.Cancel:
							return false;
					}
				}

				return true;
			}
		}

		public void New ()
		{
			if ( !SaveCheck ) return;

			pgEdit.SelectedObject = theme = new EpTheme ();
			
			saveOk = true;
			savePath = "";

			SetTitle ();

			picEdit.Refresh ();
		}

		public void Open ()
		{
			if ( !SaveCheck ) return;

			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.Filter = "Education Plus Theme 파일(*.eptf)|*.eptf";

			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;

			FileStream fs = new FileStream ( ofd.FileName, FileMode.Open );
			pgEdit.SelectedObject = theme = new EpTheme ();
			byte[] data = new byte[fs.Length];
			fs.Read(data, 0, (int)fs.Length);
			theme.SetData ( data );
			fs.Close ();
			fs.Dispose ();

			saveOk = true;
			savePath = ofd.FileName;

			SetTitle ();

			picEdit.Refresh ();
		}

		public bool Save ()
		{
			if ( savePath == "" ) return SaveAs ();

			FileStream fs = new FileStream ( savePath, FileMode.Open );
			byte[] dat = theme.GetData ();
			fs.Write ( dat, 0, dat.Length );
			fs.Close ();
			fs.Dispose ();

			saveOk = true;

			SetTitle ();

			return true;
		}

		public bool SaveAs ()
		{
			SaveFileDialog sfd = new SaveFileDialog ();
			sfd.Filter = "Education Plus Theme 파일(*.eptf)|*.eptf";
			if ( savePath == "" ) sfd.FileName = "제목 없음.eptf"; else sfd.FileName = GetName ( savePath );

			if ( sfd.ShowDialog () == DialogResult.Cancel ) return false;

			FileStream fs = new FileStream ( sfd.FileName, FileMode.OpenOrCreate );
			byte[] dat = theme.GetData ();
			fs.Write ( dat, 0, dat.Length );
			fs.Close ();
			fs.Dispose ();

			saveOk = true;
			savePath = sfd.FileName;

			SetTitle ();

			return true;
		}

		private void cmbThemeType_SelectedIndexChanged ( object sender, EventArgs e )
		{
			editIndex = ( ThemeType ) cmbThemeType.SelectedIndex;
			picEdit.Refresh ();
		}

		private void picEdit_Paint ( object sender, PaintEventArgs e )
		{
			int idx = ( int ) editIndex;

			if ( theme.Image != null )
			{
				e.Graphics.DrawImage ( theme.Image, 
					new Rectangle ( 0, 0, 400, 300 ), 
					new Rectangle ( 0, 0, theme.Image.Width, theme.Image.Height ), 
					GraphicsUnit.Pixel );
			}

			e.Graphics.DrawRectangle ( new Pen ( theme.TitleColor ),
				new Rectangle ( 
					theme.Title[idx].X / 2, 
					theme.Title[idx].Y / 2,
					theme.Title[idx].Width / 2, 
					theme.Title[idx].Height / 2 
					) );
			e.Graphics.DrawString ( "문제", new Font ( theme.TitleFont, theme.TitleFontSize / 2 ), 
				new SolidBrush ( theme.TitleColor ), 
				new PointF (theme.Title[idx].X / 2, theme.Title[idx].Y / 2) );
			
			e.Graphics.DrawRectangle ( new Pen ( theme.HintColor ),
				new Rectangle ( 
					theme.Hint[idx].X / 2, 
					theme.Hint[idx].Y / 2,
					theme.Hint[idx].Width / 2, 
					theme.Hint[idx].Height / 2
					) );
			e.Graphics.DrawString ( "힌트", new Font ( theme.HintFont, theme.HintFontSize / 2 ), 
				new SolidBrush ( theme.HintColor ),
				new PointF ( theme.Hint[idx].X / 2, theme.Hint[idx].Y / 2 ) );

			e.Graphics.FillRectangle ( new SolidBrush ( Color.Crimson ),
				new Rectangle (
					theme.ImageLocation.X / 2,
					theme.ImageLocation.Y / 2,
					theme.ImageLocation.Width / 2,
					theme.ImageLocation.Height / 2
					) );
			e.Graphics.DrawString ( "그림", new Font ( "나눔고딕", 12 ),
				new SolidBrush ( Color.FromArgb ( 255 - Color.Crimson.R,
					255 - Color.Crimson.G, 255 - Color.Crimson.B ) ),
				new PointF ( theme.ImageLocation.X / 2, theme.ImageLocation.Y / 2 ) );

			e.Graphics.DrawRectangle ( new Pen ( theme.ExampleColor ),
				new Rectangle (
					theme.Example[idx].X / 2,
					theme.Example[idx].Y / 2,
					theme.Example[idx].Width / 2,
					theme.Example[idx].Height / 2
					) );

			switch ( editIndex )
			{ 
				case ThemeType.기본_테마_형식:
					for ( int i = 0; i < 5; i++ )
					{
						e.Graphics.Clip = new Region ( new Rectangle ( theme.Example[0].X / 2, theme.Example[0].Y / 2,
							theme.Example[0].Width / 2, theme.Example[0].Height / 2 ) );
						e.Graphics.DrawString ( String.Format ( "{0:00}. xxxx", (i + 1) ), 
							new Font ( theme.ExampleFont, theme.ExampleFontSize / 2 ),
							new SolidBrush ( Color.Black ),
							new Point ( theme.Example[0].X / 2, theme.Example[0].Y / 2 + i * theme.ExampleSpace / 2 ) );
					}
					break;
				case ThemeType.보기가_그림인_테마:
					Rectangle box = new Rectangle ( theme.Example[1].X / 2, theme.Example[1].Y / 2,
							theme.ImageExampleSize.Width / 2, theme.ImageExampleSize.Height / 2 );
					e.Graphics.DrawRectangle ( new Pen ( Color.Gray ), box );
					e.Graphics.DrawRectangle ( new Pen ( Color.Gray ),
						new Rectangle ( box.X + box.Width + theme.ImageExampleSpace, box.Y, 
							box.Width, box.Height ) );
					e.Graphics.DrawRectangle ( new Pen ( Color.Gray ),
						new Rectangle ( box.X, box.Y + box.Height + theme.ImageExampleSpace,
							box.Width, box.Height ) );
					e.Graphics.DrawRectangle ( new Pen ( Color.Gray ),
						new Rectangle ( box.X + box.Width + theme.ImageExampleSpace, 
							box.Y + box.Height + theme.ImageExampleSpace,
							box.Width, box.Height ) );
					e.Graphics.DrawRectangle ( new Pen ( Color.Gray ),
						new Rectangle ( box.X, box.Y + ( box.Height + theme.ImageExampleSpace ) * 2,
							box.Width, box.Height ) );
					break;
			}
		}

		private void pgEdit_PropertyValueChanged ( object s, PropertyValueChangedEventArgs e )
		{
			picEdit.Refresh ();

			saveOk = false;
			picEdit.Refresh ();
			
			SetTitle ();
		}

		private void mnuNew_Click ( object sender, EventArgs e )
		{
			New ();
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

		private void mnuExit_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void frmThemeEdit_FormClosing ( object sender, FormClosingEventArgs e )
		{
			if ( !SaveCheck ) e.Cancel = true;
		}

		private void mnuAbout_Click ( object sender, EventArgs e )
		{
			new frmThEditAbout ().ShowDialog ();
		}
	}
}
