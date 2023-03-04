using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Drawing.Imaging;

namespace EduPlus
{
	public enum QType
	{ 
		객관식 = 0,
		주관식
	}

	public enum ThemeType
	{ 
		기본_테마_형식 = 0,
		보기가_그림인_테마,
	}

	public class EpQuestion
	{
		string question = "문제가 생성됐습니다.";
		List<EpExample> example = new List<EpExample> ();
		Image image = null;
		string hint = "";
		QType qType = QType.객관식;
		ThemeType themeType = ThemeType.기본_테마_형식;

		[DisplayName ( "문제" )]
		[Description ( "학생들이 풀 문제를 작성합니다." )]
		public string Question { get { return question; } set { question = value; } }
		
		[DisplayName ( "힌트" )]
		[Description ( "힌트가 필요한 경우 적습니다." )]
		public string Hint { get { return hint; } set { hint = value; } }

		[DisplayName ( "보조 그림" )]
		[Description ( "보조적으로 띄울 그림을 선택합니다." )]
		public Image Image { get { return image; } set { image = value; } }
		
		[DisplayName ( "보기" )]
		[Description ( "객관식의 경우 보기 항목을 채웁니다. 주관식의 경우 적어도 하나의 보기 항목이 있어야 합니다." )]
		public List<EpExample> Examples { get { return example; } set { example = value; } }
		
		[DisplayName ( "문제 형식" )]
		[Description ( "문제의 형식을 결정합니다." )]
		public QType QuestionType { get { return qType; } set { qType = value; } }
		
		[DisplayName ( "테마 형식" )]
		[Description ( "화면에 표시할 때 사용할 테마의 형식을 결정합니다." )]
		public ThemeType ThemeType { get { return themeType; } set { themeType = value; } }

		public byte[] GetData ()
		{
			MemoryStream mem = new MemoryStream ();
			BinaryWriter b = new BinaryWriter ( mem );

			b.Write ( question );
			b.Write ( hint );

			if ( image == null )
				b.Write ( false );
			else
			{
				b.Write ( true );
				MemoryStream temp = new MemoryStream ();
				image.Save ( temp, ImageFormat.Png );
				byte[] dat = temp.ToArray ();
				b.Write ( dat.Length );
				b.Write ( dat );
			}

			if ( example.Count == 0 )
				b.Write ( false );
			else
			{
				b.Write ( true );
				b.Write ( example.Count );
				foreach ( EpExample ex in example )
				{
					byte[] dat = ex.GetData ();
					b.Write ( dat.Length );
					b.Write ( dat );
				}
			}

			b.Write ( ( int ) qType );
			b.Write ( ( int ) themeType );

			b.Close ();

			return mem.ToArray ();
		}

		public void SetData ( byte[] data )
		{
			MemoryStream mem = new MemoryStream ( data );
			BinaryReader b = new BinaryReader ( mem );

			question = b.ReadString ();
			hint = b.ReadString ();

			if ( b.ReadBoolean () )
			{
				MemoryStream temp = new MemoryStream ();
				int len = b.ReadInt32 ();
				temp.Write ( b.ReadBytes ( len ), 0, len );
				image = Image.FromStream ( temp );
			}

			if ( b.ReadBoolean () )
			{
				int len = b.ReadInt32 ();
				example = new List<EpExample> ();
				for ( int i = 0; i < len; i++ )
				{
					EpExample ex = new EpExample ();
					int lenlen = b.ReadInt32 ();
					byte[] dat = b.ReadBytes ( lenlen );
					ex.SetData ( dat );
					example.Add ( ex );
				}
			}

			qType = ( QType ) b.ReadInt32 ();
			themeType = ( ThemeType ) b.ReadInt32 ();

			b.Close ();
		}
	}
}
