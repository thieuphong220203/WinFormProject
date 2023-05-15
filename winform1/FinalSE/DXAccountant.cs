using DevExpress.XtraBars;
using FinalSE.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinalSE.Class;

namespace FinalSE
{
	public partial class DXAccountant : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		
		public string userName{ get; set; }
		public DXAccountant()
		{
			InitializeComponent();
			Functions.connect();
		}

		

		SupplierUI UISupplier;
		private void accordionControlSupplier_Click(object sender, EventArgs e)
		{
			if(UISupplier == null)
			{
				UISupplier = new SupplierUI();
				UISupplier.Dock = DockStyle.Fill;
				mainFormContainer.Controls.Add(UISupplier);
				UISupplier.BringToFront();
			}else
			{
				UISupplier.BringToFront();
			}
		}

		private void accordionControlLogOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmLogin frm = new frmLogin();
			frm.Show();
		}

		myInformationUI myInformationUI;
		private void accordionControlInformation_Click(object sender, EventArgs e)
		{
			if(myInformationUI == null)
			{
				myInformationUI = new myInformationUI();
				myInformationUI.Dock = DockStyle.Fill;
				mainFormContainer.Controls.Add(myInformationUI);
				myInformationUI.BringToFront();
				myInformationUI.userName= userName;
			}else
			{
				myInformationUI.BringToFront();
			}
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}

		private void DXAccountant_Load(object sender, EventArgs e)
		{
			/*this.WindowState= FormWindowState.Maximized;*/
			this.Size = new Size(1200,625);
			lblAccount.Text = "Welcome Back " + userName;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void accordionControlExit_Click(object sender, EventArgs e)
		{
			Functions.disconnect();
			Application.Exit();
		}

		TypeProductUI typeProductUI;
		private void accordionControlTypeProducts_Click(object sender, EventArgs e)
		{
			if(typeProductUI == null)
			{
				typeProductUI = new TypeProductUI();
				typeProductUI.Dock = DockStyle.Fill;
				mainFormContainer.Controls.Add(typeProductUI);
				typeProductUI.BringToFront();
			}else
			{
				typeProductUI.BringToFront();
			}
		}

		
		private void accordionControlCustomer_Click(object sender, EventArgs e)
		{
			frmCustomer frm = null;
			if (frm == null)
			{
				frm = new frmCustomer();
				frm.TopLevel = false;
				frm.Dock = DockStyle.Fill;
				mainFormContainer.Controls.Add(frm);
				frm.Show();
				frm.BringToFront();
			}else
			{
				frm.BringToFront();
			}
			
			

		}

		private void accordionControlProduct_Click(object sender, EventArgs e)
		{
			ProductsUI frm = new ProductsUI();
			frm.TopLevel = false;
			frm.Dock = DockStyle.Fill;
			mainFormContainer.Controls.Add(frm);
			frm.Show();
			frm.BringToFront();
		}

		private void accordionControlCheckReceipt_Click(object sender, EventArgs e)
		{
			
		}

		private void accordionControlCheckInvoince_Click(object sender, EventArgs e)
		{
			frmDelivery frm = new frmDelivery();
			frm.TopLevel = false;
			frm.Dock = DockStyle.Fill;
			mainFormContainer.Controls.Add(frm);
			frm.AccountantName = userName;
			frm.Show();
			frm.BringToFront();
		}

		private void accordionControlCreateRECEIPT_Click(object sender, EventArgs e)
		{
			Receipt frm = new Receipt();
			frm.TopLevel = false;
			frm.Dock = DockStyle.Fill;
			mainFormContainer.Controls.Add(frm);
			frm.AccountantUserName = userName;
			frm.Show();
			frm.BringToFront();
		}
	}
}
