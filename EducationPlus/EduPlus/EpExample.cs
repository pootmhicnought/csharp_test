using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace EduPlus
{
	public class EpExample
	{
		string example = "";
		Image image = null;
		bool isAnswer = false;

		[DisplayName("보기")]
		[Description("문제의 보기를 설정하거나 주관식의 답을 설정합니다.")]
		public string Example
		{
			get { return example; }
			set { example = value; }
		}

		[DisplayName("그림")]
		[Description("문제의 보기 형식이 이미지인 경우 표시할 그림입니다.")]
		public Image Image
		{
			get { return image; }
			set { image = value; }
		}

		[DisplayName("답")]
		[Description("이 보기가 답인 경우 True, 아닌 경우 False를 설정합니다.")]
		public bool IsAnswer
		{
			get { return isAnswer; }
			set { isAnswer = value; }
		}

		public byte[] GetData ()
		{
			MemoryStream mem = new MemoryStream ();
			BinaryWriter b = new BinaryWriter ( mem );

			b.Write ( example );

			if ( image == null )
				b.Write ( false );
			else
			{
				b.Write ( true );
				MemoryStream img = new MemoryStream ();
				image.Save ( img, ImageFormat.Png );
				byte[] dat = img.ToArray ();
				b.Write ( dat.Length );
				b.Write ( dat );
			}

			b.Write ( isAnswer );

			b.Close ();

			return mem.ToArray ();
		}

		public void SetData ( byte[] data )
		{
			MemoryStream mem = new MemoryStream ( data );
			BinaryReader b = new BinaryReader ( mem );

			example = b.ReadString ();

			if ( b.ReadBoolean () )
			{
				int length = b.ReadInt32 ();
				byte[] dat = b.ReadBytes ( length );
				MemoryStream temp = new MemoryStream ( dat );
				image = Image.FromStream ( temp );
			}

			isAnswer = b.ReadBoolean ();

			b.Close ();
		}
	}
}