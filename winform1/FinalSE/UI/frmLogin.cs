using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSE.EF;
using FinalSE.Models;
using FinalSE.UI;

namespace FinalSE
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtUserName_Click(object sender, EventArgs e)
		{
			txtUserName.BackColor= Color.White;
			panelUserName.BackColor= Color.White;
			panelPassword.BackColor= Color.FromArgb(213, 231, 242);
			txtPassword.BackColor= Color.FromArgb(213, 231, 242);
		}

		private void txtPassword_Click(object sender, EventArgs e)
		{
			txtPassword.BackColor= Color.White;
			panelPassword.BackColor= Color.White;
			txtUserName.BackColor= Color.FromArgb(213, 231, 242);
			panelUserName.BackColor = Color.FromArgb(213, 231, 242);

		}

		

		private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
		{
			txtPassword.UseSystemPasswordChar = false;
		}

		private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
		{
			txtPassword.UseSystemPasswordChar = true;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				string userName = txtUserName.Text;
				string password = txtPassword.Text;
				Accountant accountant = new Accountant();

				ACCOUNTANT acc = accountant.getItemByUserName(userName);
				if(acc == null)
				{
					MessageBox.Show("Your username is wrong, please try again","Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtUserName.Text = string.Empty;
					txtPassword.Text = string.Empty;
					txtUserName.Focus();
				}else if(acc.Accountant_Password.Equals(password))
				{
					MessageBox.Show("Login successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Hide();
					DXAccountant frm = new DXAccountant();
					frm.userName = userName;
					frm.Show();

					Receipt receiptForm = Application.OpenForms.OfType<Receipt>().FirstOrDefault();
					if(receiptForm != null) { 
						receiptForm.AccountantUserName= userName;
					}
				}else
				{
					MessageBox.Show("Your password is wrong, please try again","Invalid Password",MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtUserName.Text = string.Empty;
					txtPassword.Text = string.Empty;
					txtUserName.Focus();
				}


			}catch(Exception ex)
			{
				MessageBox.Show("error");
				MessageBox.Show(ex.Message);

			}

			/*String userName= txtUserName.Text;
			String password= txtPassword.Text;
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			try
			{
				String query = "SELECT * FROM [ACCOUNTANT] WHERE Accountant_UserName=@userName and Accountant_Password=@password";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("username", userName);
				cmd.Parameters.AddWithValue("password", password);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				if(dt.Rows.Count > 0)
				{
					userName = txtUserName.Text;
					password = txtPassword.Text;
					Form1 frm = new Form1();
					frm.Show();
					this.Hide();
				}else
				{
					MessageBox.Show("Invalid Login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					txtUserName.Clear();
					txtPassword.Clear();

					//focus 
					txtUserName.Focus();
				}

			}catch(Exception ex)
			{
				MessageBox.Show("Error");
			}finally {
				conn.Close();
			}*/
		}

		private void btnForgetPass_Click(object sender, EventArgs e)
		{
			frmForgetPass frm = new frmForgetPass();
			frm.Show();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
