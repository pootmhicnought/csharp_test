using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EduPlus
{
	public partial class frmLog : Form
	{
		public frmLog ( string log )
		{
			InitializeComponent ();
			textBox1.Text = log;
		}
	}
}
