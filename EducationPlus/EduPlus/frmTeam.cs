using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace EduPlus
{	
	public partial class frmTeam : Form
	{
		[DllImport ( "user32.dll" )]
		private static extern Int16 GetAsyncKeyState ( int vKey );


		List<EpTeam> team = new List<EpTeam> ();

		public frmTeam ()
		{
			InitializeComponent ();
			SetEnable ();
		}

		private void btnOpen_Click ( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.Filter = "Education Plus Team 파일(*.ept)|*.ept";
			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;

			FileStream fs = new FileStream ( ofd.FileName, FileMode.Open );

			BinaryReader b = new BinaryReader ( fs );
			int len = b.ReadInt32 ();

			team.Clear ();
			for ( int i = 0; i < len; i++ )
			{
				EpTeam temp = new EpTeam ();
				temp.TeamName = b.ReadString ();
				int tlen = b.ReadInt32 ();
				temp.SetData ( b.ReadBytes ( tlen ) );
				team.Add ( temp );
			}

			b.Close ();

			fs.Close ();
			fs.Dispose ();

			cmbTeam.Text = "";
			numPoint.Value = 0;
			lstTeamMember.Items.Clear ();
			SetEnable ();

			foreach ( EpTeam t in team )
			{
				cmbTeam.Items.Add ( t.TeamName );
			}
		}

		private void btnSave_Click ( object sender, EventArgs e )
		{
			SaveFileDialog sfd = new SaveFileDialog ();
			sfd.Filter = "Education Plus Team 파일(*.ept)|*.ept";
			if ( sfd.ShowDialog () == DialogResult.Cancel ) return;

			FileStream f = new FileStream ( sfd.FileName, FileMode.OpenOrCreate );

			BinaryWriter b = new BinaryWriter ( f );

			b.Write ( team.Count );

			foreach ( EpTeam t in team )
			{
				byte[] dat = t.GetData ();
				b.Write ( t.TeamName );
				b.Write ( dat.Length );
				b.Write ( dat );
			}

			b.Close ();

			f.Close ();
			f.Dispose ();
		}

		public void SetEnable ()
		{
			if ( team.Count == 0 && cmbTeam.SelectedIndex < 0 )
			{
				lstTeamMember.Enabled = false;
				txtAddName.Enabled = false;
				btnAddName.Enabled = false;
				numPoint.Enabled = false;
			}
			else
			{
				lstTeamMember.Enabled = true;
				txtAddName.Enabled = true;
				btnAddName.Enabled = true;
				numPoint.Enabled = true;
			}
		}

		private void cmbTeam_SelectedIndexChanged ( object sender, EventArgs e )
		{
			SetEnable ();
			lstTeamMember.Items.Clear ();
			foreach ( string name in team[cmbTeam.SelectedIndex].Name )
			{
				lstTeamMember.Items.Add ( name );
			}
		}

		private void btnAddName_Click ( object sender, EventArgs e )
		{
			team[cmbTeam.SelectedIndex].Name.Add ( txtAddName.Text );
			lstTeamMember.Items.Add ( txtAddName.Text );
			txtAddName.Text = "";
		}

		private void btnRemove_Click ( object sender, EventArgs e )
		{
			if ( cmbTeam.SelectedIndex >= 0 )
			{
				team.RemoveAt ( cmbTeam.SelectedIndex );
				cmbTeam.Items.RemoveAt ( cmbTeam.SelectedIndex );

				lstTeamMember.Items.Clear ();

				numPoint.Value = 0;

				SetEnable ();
			}
		}

		private void numPoint_ValueChanged ( object sender, EventArgs e )
		{
			team[cmbTeam.SelectedIndex].Point = ( int ) numPoint.Value;
		}

		private void btnAdd_Click ( object sender, EventArgs e )
		{
			frmTeamAdd add = new frmTeamAdd ();
			if ( add.ShowDialog () == DialogResult.Cancel ) return;

			EpTeam t = new EpTeam ();
			t.TeamName = add.TeamName;
			team.Add ( t );
			cmbTeam.Items.Add ( t.TeamName );
		}

		private void tmrEscCheck_Tick ( object sender, EventArgs e )
		{
			Application.DoEvents ();
			//if ( this.Focused )
			//{
				if ( GetAsyncKeyState ( ( int )Keys.Escape ) == -32767 )
				{
					this.Close ();
				}
			//}
		}
	}
}
