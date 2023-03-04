using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EduPlus
{
	public partial class frmSubject : Form
	{
		List<EpExample> ex;

		public frmSubject (List<EpExample> ex)
		{
			InitializeComponent ();

			this.ex = ex;
		}

		private void frmSubject_Load ( object sender, EventArgs e )
		{

		}

		private void btnOk_Click ( object sender, EventArgs e )
		{
			int count = 0;
			foreach ( EpExample str in ex )
				if ( txtAnswer.Text.Contains ( str.Example.Trim () ) )
					count++;

			if ( count == ex.Count )
				DialogResult = DialogResult.OK;
			else if ( count >= 1 )
				DialogResult = DialogResult.Yes;
			else
				DialogResult = DialogResult.Cancel;

			this.Close ();
		}
	}
}
