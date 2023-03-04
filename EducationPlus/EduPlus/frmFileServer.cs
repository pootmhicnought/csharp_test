using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace EduPlus
{
	public partial class frmFileServer : Form
	{
		Socket m_Listen;
		Socket m_Conn;
		string m_Logs;

		List<string> fileData = new List<string> ();

		Thread m_ServerThread;

		public frmFileServer ()
		{
			InitializeComponent ();
		}

		private void frmFileServer_Load ( object sender, EventArgs e )
		{
			cmbIps.Items.Add ( "IP 주소 보기" );
			cmbIps.Text = "IP 주소 보기";
			IPAddress[] add = Dns.GetHostEntry ( Dns.GetHostName () ).AddressList;
			foreach ( IPAddress a in add )
				cmbIps.Items.Add ( a.ToString () );
		}

		private void btnStart_Click ( object sender, EventArgs e )
		{
			m_Listen = new Socket ( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
			m_Listen.Bind ( new IPEndPoint ( IPAddress.Any, 3401 ) );
			m_Listen.Listen ( 5 );

			m_ServerThread = new Thread ( new ThreadStart ( ServerThread ) );
			m_ServerThread.Start ();

			btnStart.Enabled = false;
		}

		public void AddLog ( string data )
		{
			m_Logs += data + Environment.NewLine;
		}

		private void frmFileServer_FormClosing ( object sender, FormClosingEventArgs e )
		{
			if ( m_ServerThread != null )
				m_ServerThread.Interrupt ();
		}

		private void btnAdd_Click ( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.Filter = "Education Plus 파일(*.epf)|*.epf";

			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;

			fileData.Add ( ofd.FileName );
			RefreshList ();
		}

		private void btnRemove_Click ( object sender, EventArgs e )
		{
			if ( lstFiles.SelectedIndex > 0 && lstFiles.SelectedIndex < fileData.Count )
				fileData.RemoveAt ( lstFiles.SelectedIndex );
			RefreshList ();
		}

		public string GetFileName ( string path )
		{
			string [] a = path.Split ( '\\' );
			return a [a.Length - 1];
		}

		public void RefreshList ()
		{
			lstFiles.Items.Clear ();

			for ( int i = 0; i < fileData.Count; i++ )
			{
				lstFiles.Items.Add ( string.Format ( "{0:000} : {1}", i + 1, GetFileName ( fileData [i] ) ) );
			}
		}

		public void ServerThread ()
		{
			Application.DoEvents ();

			m_Conn = m_Listen.Accept ();
			AddLog ( m_Conn.LocalEndPoint.ToString () + "에서 접속되었습니다." );

			try
			{
				byte [] num = new byte [1];
				m_Conn.Receive ( num, 1, SocketFlags.None );
				AddLog ( "클라이언트에서 " + num [0].ToString () + "번째 데이터를 요구합니다." );

				byte number = num [0];

				// 문서 번호를 받고 0을 보내면 잘못된 문서 번호, 1을 보내면 보낼 준비중
				if ( number < 0 && number > fileData.Count )
				{
					num [0] = 0;
					AddLog ( "클라이언트에서 잘못된 데이터를 요구하였습니다." );
					m_Conn.Send ( num, 1, SocketFlags.None );
					m_Conn.Close ();
					return;
				}
				else
				{
					num [0] = 1;
					m_Conn.Send ( num, 1, SocketFlags.None );
				}

				byte [] data = System.IO.File.ReadAllBytes ( fileData [number - 1] );
				
				MemoryStream mem = new MemoryStream ();
				BinaryWriter bLength = new BinaryWriter ( mem );
				bLength.Write ( data.Length );
				bLength.Close ();
				m_Conn.Send ( mem.ToArray (), 4, SocketFlags.None );
				mem.Close ();
				mem.Dispose ();

				int sendedLength = 0;
				while ( sendedLength < data.Length )
				{
					int temp = m_Conn.Send ( data,
						sendedLength, data.Length - sendedLength, SocketFlags.None );
					sendedLength += temp;
				}
				AddLog ( "클라이언트에서 원하는 파일을 성공적으로 보냈습니다." );

				m_Conn.Close ();
			}
			catch ( Exception ex )
			{
				AddLog ( "클라이언트와의 데이터 교환에 오류가 있었습니다."
					+ "오류 메시지 : " + ex.Message );
				if ( m_Conn.Connected )
					m_Conn.Close ();
			}
		}

		private void btnLogs_Click ( object sender, EventArgs e )
		{
			new frmLog ( m_Logs ).ShowDialog ();
		}
	}
}
