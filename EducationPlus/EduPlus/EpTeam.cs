using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EduPlus
{
	public class EpTeam
	{
		string teamName = "";
		List<string> name = new List<string> ();
		int point = 0;

		public string TeamName
		{
			get { return teamName; }
			set { teamName = value; }
		}

		public List<string> Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Point
		{
			get { return point; }
			set { point = value; }
		}

		public byte[] GetData ()
		{
			MemoryStream mem = new MemoryStream ();

			BinaryWriter b = new BinaryWriter ( mem );

			b.Write ( name.Count );
			foreach ( string nm in name )
				b.Write ( nm );
			b.Write ( point );

			b.Close ();

			return mem.ToArray ();
		}

		public void SetData ( byte[] data )
		{
			MemoryStream mem = new MemoryStream ( data );

			BinaryReader b = new BinaryReader ( mem );

			int len = b.ReadInt32 ();
			name.Clear ();
			for ( int i = 0; i < len;i++ )
			{
				name.Add ( b.ReadString () );
			}
			point = b.ReadInt32 ();

			b.Close ();

			mem.Close ();
			mem.Dispose ();
		}
	}
}