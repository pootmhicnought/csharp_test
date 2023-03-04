using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EduPlus
{
	public partial class frmHelp : Form
	{
		Point loc = new Point ();
		Image image = null;

		Point msXy = new Point ();
		bool isDown = false;

		public frmHelp ()
		{
			InitializeComponent ();
		}

		private void frmHelp_Load ( object sender, EventArgs e )
		{
		}

		private void lstHelp_SelectedIndexChanged ( object sender, EventArgs e )
		{
			if ( lstHelp.FocusedItem == null ) return;

			switch(lstHelp.FocusedItem.Index)
			{
				case 0:
					image = Properties.Resources.start;
					break;
				case 1:
					image = Properties.Resources.addquestion;
					break;
				case 2:
					image = Properties.Resources.modify;
					break;
				case 3:
					image = Properties.Resources.exampleaddremove;
					break;
				case 4:
					image = Properties.Resources.gaekjoo;
					break;
				case 5:
					image = Properties.Resources.theme;
					break;
				case 6:
					image = Properties.Resources.present;
					break;
				case 7:
					image = Properties.Resources.teamnavigator;
					break;
				case 8:
					image = Properties.Resources.fileserver;
					break;
				case 9:
					image = Properties.Resources.openfromfileserver;
					break;
				case 10:
					image = Properties.Resources.makelnk;
					break;
				case 11:
					image = Properties.Resources.end;
					break;
				default:
					return;
			}

			loc=  new Point ();
			picView.Refresh ();
		}

		private void picView_MouseDown ( object sender, MouseEventArgs e )
		{
			if ( e.Button != MouseButtons.Left ) return;

			isDown = true;
			msXy = new Point ( e.X, e.Y );
		}

		private void picView_MouseMove ( object sender, MouseEventArgs e )
		{
			if ( !isDown ) return;
			if ( image == null ) return;

			int x = loc.X + (e.X - msXy.X);
			int y = loc.Y + (e.Y - msXy.Y);

			loc = new Point ( x, y );
			msXy = new Point ( e.X , e.Y );

			picView.Refresh ();
		}

		private void picView_MouseUp ( object sender, MouseEventArgs e )
		{
			isDown = false;
		}

		private void picView_Paint ( object sender, PaintEventArgs e )
		{
			if(image != null)
				e.Graphics.DrawImage ( image, loc );
		}
	}
}
