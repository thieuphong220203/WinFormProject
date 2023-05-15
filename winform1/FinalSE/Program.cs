using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSE.UI;
namespace FinalSE
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/*public static string strConn = "";*/
		[STAThread]
		static void Main()
		{
			/*strConn= ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;*/
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmLogin());
		}
	}
}
