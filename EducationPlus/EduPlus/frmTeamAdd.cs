using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EduPlus
{
	public partial class frmTeamAdd : Form
	{
		string teamName;

		public string TeamName
		{
			get { return teamName; }
		}

		public frmTeamAdd ()
		{
			InitializeComponent ();
		}

		private void btnCancel_Click ( object sender, EventArgs e )
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnAdd_Click ( object sender, EventArgs e )
		{
			teamName = textBox1.Text;
			DialogResult = DialogResult.OK;
		}
	}
}
