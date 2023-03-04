using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace EduPlus
{
	partial class frmThEditAbout : Form
	{
		public frmThEditAbout ()
		{
			InitializeComponent ();
			this.Text = String.Format ( "{0} 정보", "Theme Editor" );
			this.labelProductName.Text = "Theme Editor";
			this.labelVersion.Text = String.Format ( "버전 {0}", "1.0.0.0" );
			this.labelCopyright.Text = AssemblyCopyright;
			this.labelCompanyName.Text = AssemblyCompany;
		}

		#region 어셈블리 특성 접근자

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly ().GetName ().Version.ToString ();
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly ().GetCustomAttributes ( typeof ( AssemblyCopyrightAttribute ), false );
				if ( attributes.Length == 0 )
				{
					return "";
				}
				return ( ( AssemblyCopyrightAttribute ) attributes[0] ).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly ().GetCustomAttributes ( typeof ( AssemblyCompanyAttribute ), false );
				if ( attributes.Length == 0 )
				{
					return "";
				}
				return ( ( AssemblyCompanyAttribute ) attributes[0] ).Company;
			}
		}
		#endregion
	}
}
