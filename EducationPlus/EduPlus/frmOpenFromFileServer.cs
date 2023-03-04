using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace EduPlus
{
	public partial class frmOpenFromFileServer : Form
	{
		Thread thread;
		byte [] readedData;

		EduManager eduMan;

		public frmOpenFromFileServer ()
		{
			InitializeComponent ();
		}

		private void btnOpen_Click ( object sender, EventArgs e )
		{
			lblWait.Visible = true;
			thread = new Thread ( new ThreadStart ( DownloadFile ) );
			thread.Start ();

			while ( thread.ThreadState == ThreadState.Running )
			{
				Application.DoEvents ();
			}

			lblWait.Visible = false;

			if ( readedData == null ) return;

			eduMan = new EduManager ();
			MemoryStream mem = new MemoryStream ( readedData );
			eduMan.Load ( mem );

			new frmPresent ( ref eduMan ).ShowDialog ();
		}

		public void DownloadFile ()
		{
			try
			{
				Socket sock = new Socket ( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
				sock.Connect ( new IPEndPoint ( IPAddress.Parse ( txtIp.Text ), 3401 ) );
				byte [] num = new byte [1];
				num [0] = ( byte )numFileNum.Value;

				sock.Send ( num, 1, SocketFlags.None );
				sock.Receive ( num, 1, SocketFlags.None );
				if ( num [0] == 0 )
				{
					MessageBox.Show ( "요청한 파일 번호는 잘못된 번호입니다." );
					sock.Close ();
					readedData = null;
					return;
				}

				byte [] len = new byte [4];
				if ( sock.Receive ( len, 4, SocketFlags.None ) == 0 )
					throw new Exception ( "서버와의 연결이 끊겼습니다." );

				MemoryStream mem = new MemoryStream ( len );
				BinaryReader b = new BinaryReader ( mem );
				int length = b.ReadInt32 ();
				b.Close (); mem.Close (); mem.Dispose ();

				int total = 0;
				readedData = new byte [length];
				while ( total < length )
				{
					int temp = sock.Receive ( readedData, total, length - total, SocketFlags.None );
					if ( temp == 0 )
						throw new Exception ( "서버와의 연결이 끊겼습니다." );
					total += temp;
				}
			}
			catch ( Exception e )
			{
				MessageBox.Show ( "파일을 전송받는 도중 오류가 발생했습니다.\n"
					+ "오류 메시지 : " + e.Message );
				readedData = null;
			}
		}
	}
}
