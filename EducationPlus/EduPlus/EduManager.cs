using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EduPlus
{
	public class EduManager
	{
		List<EpQuestion> question = new List<EpQuestion> ();
		EpTheme theme = new EpTheme ();

		public List<EpQuestion> Question
		{
			get { return question; }
			set { question = value; }
		}

		public EpTheme Theme
		{
			get { return theme; }
			set { theme = value; }
		}

		public bool Load ( Stream stream )
		{
			BinaryReader b = new BinaryReader ( stream );
			int ver = b.ReadInt32 ();
			if ( ver != 0xDEAD ) { MessageBox.Show ( "버전이 일치하지 않습니다." ); return false; }
			int len = b.ReadInt32 ();
			question = new List<EpQuestion> ();
			for ( int i = 0; i < len; i++ )
			{
				EpQuestion q = new EpQuestion ();
				int lenlen = b.ReadInt32 ();
				byte[] dat = b.ReadBytes ( lenlen );
				q.SetData ( dat );
				question.Add ( q );
			}

			int lenlenlen = b.ReadInt32 ();
			byte[] datdat = b.ReadBytes ( lenlenlen );
			theme = new EpTheme ();
			theme.SetData ( datdat );

			b.Close ();

			return true;
		}

		public bool Save ( Stream stream )
		{
			BinaryWriter b = new BinaryWriter ( stream );
			b.Write ( 0xDEAD );
			b.Write ( question.Count );
			foreach ( EpQuestion q in question )
			{
				byte[] dat = q.GetData ();
				b.Write ( dat.Length );
				b.Write ( dat );
			}
			byte[] th = theme.GetData ();
			b.Write ( th.Length );
			b.Write ( th );
			b.Close ();

			return true;
		}
	}
}