using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EduPlus.Properties;

namespace EduPlus
{
	public partial class frmOption : Form
	{
		public frmOption ()
		{
			InitializeComponent ();
		}

		private void btnClose_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void btnCreateInterop_Click ( object sender, EventArgs e )
		{
			FileStream fs = new FileStream ( "Interop.IWshRuntimeLibrary.dll", FileMode.OpenOrCreate );
			//fs.Write ( Resources.Interop_IWshRuntimeLibrary, 0, 
			//	Resources.Interop_IWshRuntimeLibrary.Length );
			fs.Close ();
		}
	}
}
