using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.Utils.About;
using FinalSE.EF;
using FinalSE.Models;
using FinalSE.UI;

namespace FinalSE
{
	public partial class frmForgetPass : Form
	{
		
	
		public frmForgetPass()
		{		
			InitializeComponent();
		}

		

		string otp = "";
		private string createRandomOTP()
		{
			char[] chars = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
			Random rd = new Random();
			string s = null;
			for (int i = 0; i < 10; i++)
			{
				s += chars[rd.Next(0, 36)].ToString();
			}
			return s;
		}

	Accountant acc = new Accountant();
	

		private void btnOTP_Click(object sender, EventArgs e)
		{
			try
			{
				otp = createRandomOTP();
				var AddressSend = new MailAddress("tangthieuphong123@gmail.com");
				string EmailReceive= acc.getItemByUserName(txtUserName.Text.ToLower()).Accountant_Email;

				var AddressReceive = new MailAddress(EmailReceive);
				const string AddressSend_Pass = "kxcakzrusdtyqitm";
				const string subject = "OTP code for reset password from Accountant Application";
				string body = "Your OTP: "+otp + "\nPlease keep this for your own, DO NOT share with anyone";

				var smtp = new SmtpClient
				{
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(AddressSend.Address, AddressSend_Pass),
					Timeout = 20000
				};

				using(var message = new MailMessage(AddressSend, AddressReceive)
				{
					Subject= subject,
					Body= body,
				})
				{
					try
					{
						smtp.Send(message);
					}catch(SmtpFailedRecipientException ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
				MessageBox.Show("OTP sent, Please check your Gmail");

				
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			
			if (otp.Equals(txtOTP.Text))
			{
				this.Hide();
				ResetPassword frm = new ResetPassword();
				frm.userName= txtUserName.Text;
				frm.Show();
			}else
			{
				MessageBox.Show("the OTP is wrong, check it again");
			}
		}
	}
}
