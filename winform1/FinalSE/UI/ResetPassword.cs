using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout.Customization.Controls;
using FinalSE.EF;
using FinalSE.Models;

namespace FinalSE.UI
{
	public partial class ResetPassword : Form
	{
		public string userName { get; set; }
		Accountant ac = new Accountant();
		public ResetPassword()
		{
			InitializeComponent();
			btnOK.Enabled = false;
		}
		
		private void btnReset_Click(object sender, EventArgs e)
		{
			if (txtNew.Text == txtAgain.Text)
			{
				ac.updatePassword(userName, txtNew.Text);
				MessageBox.Show("Update successful");
				btnOK.Enabled = true;
			}else
			{
				MessageBox.Show("PASSWORD NOT MATCH, PLEASE TYPE AGAIN","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

			}

		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmLogin frm = new frmLogin();
			frm.Show();
		}

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
