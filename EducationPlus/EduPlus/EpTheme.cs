using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace EduPlus
{
	public class EpTheme
	{
		Rectangle[] title = new Rectangle[2];
		Color titleColor = Color.Black;
		string titleFont = "나눔고딕";
		int titleSize = 32;

		Rectangle[] example = new Rectangle[2];
		Color exampleColor = Color.Black;
		string exampleFont = "나눔고딕";
		int exampleSize = 16;
		int exampleSpace = 40;

		Rectangle imageLocation = new Rectangle ();
		int imExSpace = 20;
		Size imExSize = new Size ( 160, 120 );

		Rectangle[] hint = new Rectangle[2];
		Color hintColor = Color.CornflowerBlue;
		string hintFont = "나눔고딕";
		int hintSize = 12;

		Image bgImage = null;

		[DisplayName ( "문제 위치" )]
		public Rectangle[] Title { get { return title; } set { title = value; } }
		[DisplayName ( "보기 위치" )]
		public Rectangle[] Example { get { return example; } set { example = value; } }
		[DisplayName ( "이미지 위치" )]
		public Rectangle ImageLocation { get { return imageLocation; } set { imageLocation = value; } }
		[DisplayName ( "힌트 위치" )]
		public Rectangle[] Hint { get { return hint; } set { hint = value; } }

		[DisplayName ( "문제 색상" )]
		public Color TitleColor { get { return titleColor; } set { titleColor = value; } }
		[DisplayName ( "보기 색상" )]
		public Color ExampleColor { get { return exampleColor; } set { exampleColor = value; } }
		[DisplayName ( "힌트 색상" )]
		public Color HintColor { get { return hintColor; } set { hintColor = value; } }

		[DisplayName ( "이미지" )]
		public Image Image { get { return bgImage; } set { bgImage = value; } }

		[DisplayName ( "문제 글꼴" )]
		public string TitleFont { get { return titleFont; } set { titleFont = value; } }
		[DisplayName ( "문제 글자 크기" )]
		public int TitleFontSize { get { return titleSize; } set { titleSize = value; } }

		[DisplayName ( "힌트 글꼴" )]
		public string HintFont { get { return hintFont; } set { hintFont = value; } }
		[DisplayName ( "힌트 글자 크기" )]
		public int HintFontSize { get { return hintSize; } set { hintSize = value; } }

		[DisplayName ( "보기 글꼴" )]
		public string ExampleFont { get { return exampleFont; } set { exampleFont = value; } }
		[DisplayName ( "보기 글자 크기" )]
		public int ExampleFontSize { get { return exampleSize; } set { exampleSize = value; } }
		[DisplayName ( "보기 간격" )]
		public int ExampleSpace { get { return exampleSpace; } set { exampleSpace = value; } }

		[DisplayName ( "이미지 보기 간격" )]
		public int ImageExampleSpace { get { return imExSpace; } set { imExSpace = value; } }
		[DisplayName ( "이미지 보기 크기" )]
		public Size ImageExampleSize { get { return imExSize; } set { imExSize = value; } }

		/// <summary>
		/// 기본 흰색 테마로 초기화
		/// </summary>
		public EpTheme ()
		{
			for ( int i = 0; i < 2; i++ )
				title[i] = new Rectangle ( 20, 20, 760, 60 );

			for ( int i = 0; i < 2; i++ )
				example[i] = new Rectangle ( 60, 100, 400, 440 );

			imageLocation = new Rectangle ( 480, 120, 280, 400 );

			for ( int i = 0; i < 2; i++ )
			{
				hint[i] = new Rectangle ( 20, 560, 760, 20 );
			}
		}

		public byte[] GetData ()
		{
			MemoryStream mem = new MemoryStream ();
			BinaryWriter b = new BinaryWriter ( mem );

			foreach ( Rectangle r in title )
			{
				b.Write ( r.X ); b.Write ( r.Y );
				b.Write ( r.Width ); b.Write ( r.Height );
			}

			foreach ( Rectangle r in example )
			{
				b.Write ( r.X ); b.Write ( r.Y );
				b.Write ( r.Width ); b.Write ( r.Height );
			}

			{
				b.Write ( imageLocation.X ); b.Write ( imageLocation.Y );
				b.Write ( imageLocation.Width ); b.Write ( imageLocation.Height );
			}

			foreach ( Rectangle r in hint )
			{
				b.Write ( r.X ); b.Write ( r.Y );
				b.Write ( r.Width ); b.Write ( r.Height );
			}

			b.Write ( titleColor.ToArgb () );
			b.Write ( exampleColor.ToArgb () );
			b.Write ( hintColor.ToArgb () );

			b.Write ( titleFont );
			b.Write ( titleSize );
			b.Write ( exampleFont );
			b.Write ( exampleSize );
			b.Write ( hintFont );
			b.Write ( hintSize );

			b.Write ( imExSpace );
			b.Write ( imExSize.Width );
			b.Write ( imExSize.Height );

			if ( bgImage == null )
				b.Write ( false );
			else
			{
				b.Write ( true );
				MemoryStream temp = new MemoryStream ();
				bgImage.Save ( temp, ImageFormat.Png );
				byte[] dat = temp.ToArray ();
				b.Write ( dat.Length );
				b.Write ( dat );
			}

			b.Close ();

			return mem.ToArray ();
		}

		public void SetData ( byte[] data )
		{
			MemoryStream mem = new MemoryStream ( data );
			BinaryReader b = new BinaryReader ( mem );

			for ( int i = 0; i < 2; i++ )
			{
				int x = b.ReadInt32 (), y = b.ReadInt32 (), w = b.ReadInt32 (), h = b.ReadInt32 ();
				title[i] = new Rectangle ( x, y, w, h );
			}

			for ( int i = 0; i < 2; i++ )
			{
				int x = b.ReadInt32 (), y = b.ReadInt32 (), w = b.ReadInt32 (), h = b.ReadInt32 ();
				example[i] = new Rectangle ( x, y, w, h );
			}

			{
				int x = b.ReadInt32 (), y = b.ReadInt32 (), w = b.ReadInt32 (), h = b.ReadInt32 ();
				imageLocation = new Rectangle ( x, y, w, h );
			}

			for ( int i = 0; i < 2; i++ )
			{
				int x = b.ReadInt32 (), y = b.ReadInt32 (), w = b.ReadInt32 (), h = b.ReadInt32 ();
				hint[i] = new Rectangle ( x, y, w, h );
			}

			titleColor = Color.FromArgb ( b.ReadInt32 () );
			exampleColor = Color.FromArgb ( b.ReadInt32 () );
			hintColor = Color.FromArgb ( b.ReadInt32 () );

			titleFont = b.ReadString ();
			titleSize = b.ReadInt32 ();
			exampleFont = b.ReadString ();
			exampleSize = b.ReadInt32 ();
			hintFont = b.ReadString ();
			hintSize = b.ReadInt32 ();

			imExSpace = b.ReadInt32 ();
			imExSize = new Size ( b.ReadInt32 (), b.ReadInt32 () );

			if ( b.ReadBoolean () )
			{
				MemoryStream temp = new MemoryStream ();
				int len = b.ReadInt32 ();
				byte[] dat = b.ReadBytes ( len );
				temp.Write ( dat, 0, len );
				bgImage = Image.FromStream ( temp );
			}

			b.Close ();
		}
	}
}
