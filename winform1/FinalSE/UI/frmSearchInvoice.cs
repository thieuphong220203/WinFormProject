using DevExpress.XtraExport.Xls;
using FinalSE.Class;
using FinalSE.EF;
using FinalSE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSE.UI
{
	public partial class frmDelivery : Form
	{
		FINAL_SEEntities db = new FINAL_SEEntities();
		DataTable dt = new DataTable();

		public string AccountantName { get; set; }	
		
		public frmDelivery()
		{
			InitializeComponent();
			/*Functions.connect();*/
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			/*Functions.disconnect();*/
			
			this.Close();
		}

		private void frmSearchInvoice_Load(object sender, EventArgs e)
		{
			txtAccountID.Enabled= false;
			txtCustomerID.Enabled= false;
			txtName.Enabled= false;
			btnAdd.Enabled= false;
			btnRemove.Enabled= false;
			btnEdit.Enabled= false;
			btnSave.Enabled= false;
			printbtn.Enabled= false;
			btnCreate.Enabled = false;
			txtGoodDeliver.Enabled= false;
			txtGoodDeliver.Text = Functions.AutoIDGoodDelivery();

			
			string sql = "Select Invoice_ID from [INVOICE]";
			Functions.FillComboBox(sql, cbxInvoiceID,"Invoice_ID","Invoice_ID");

			try
			{
				Accountant acc = new Accountant();
				ACCOUNTANT a = acc.getItemByUserName(AccountantName);
				txtAccountID.Text = a.Accountant_ID;

				
			}
			catch(Exception ex) { MessageBox.Show(ex.Message); }
		}


		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				
				Invoice invoice = new Invoice();
				INVOICE sub_invoice = invoice.getInVoiceByID(cbxInvoiceID.SelectedValue.ToString());
				ORDER_LIST ord = sub_invoice.ORDER_LIST;

				

				/*MessageBox.Show(ord.CUSTOMER_ACCOUNT.Customer_ID);*/
				if (ord.AGENT_ACCOUNT != null)
				{
					txtCustomerID.Text = ord.AGENT_ACCOUNT.Agent_ID;
					txtName.Text = ord.AGENT_ACCOUNT.AGENT.Agent_Name;
				}
				else
				{
					txtCustomerID.Text = ord.CUSTOMER_ACCOUNT.Customer_ID;
					txtName.Text= ord.CUSTOMER_ACCOUNT.CUSTOMER.Customer_Name;
				}

				
				string sql = "select INVOICE.Invoice_ID,ORDER_LIST_DETAILS.Product_ID, ORDER_LIST_DETAILS.Delivery_Date, ORDER_LIST_DETAILS.Quantities, INVOICE.Status_Invoice " +
					"from INVOICE inner join ORDER_LIST on  INVOICE.OrderList_ID = ORDER_LIST.OrderList_ID " +
					"inner join ORDER_LIST_DETAILS on ORDER_LIST.OrderList_ID = ORDER_LIST_DETAILS.OrderList_ID " +
					"where Invoice_ID = @id";
				SqlCommand cmd = new SqlCommand(sql,Functions.conn);
				
				cmd.Parameters.AddWithValue("@id",cbxInvoiceID.SelectedValue.ToString());
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				dt.Rows.Clear();
				adp.Fill(dt);


				dataGridViewInvoice.Refresh();
				dataGridViewInvoice.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data in Invoice");
					printbtn.Enabled = false;
					btnCreate.Enabled = false;
					return;
                }

                printbtn.Enabled = true;
				btnCreate.Enabled = true;
				
            }
			catch(Exception ex) { MessageBox.Show(ex.Message); }
		}


		private void print_Click(object sender, EventArgs e)
		{
			frmReport frm = new frmReport();
			frm.InvoiceID = cbxInvoiceID.SelectedValue.ToString();
			frm.AccountantID = txtAccountID.Text;
			frm.GoodsDelivery = txtGoodDeliver.Text;
			frm.Show();

			
		}

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
			
			GOOD_DELIVERY goodDelivery = new GOOD_DELIVERY();

			goodDelivery.Good_Delivery_ID = txtGoodDeliver.Text;
			goodDelivery.Accountant_ID = txtAccountID.Text;

			string ord = db.INVOICEs.Where(x=>x.Invoice_ID == cbxInvoiceID.SelectedValue.ToString()).Select(x=>x.OrderList_ID).Single();
			goodDelivery.OrderList_ID = ord;
			goodDelivery.Date_Created_Good_Delivery = DateTime.Now;

            TRANSACTION tr = db.TRANSACTIONs.FirstOrDefault(x => x.Invoice_ID == cbxInvoiceID.SelectedValue.ToString());
            if (tr != null)
			{
				goodDelivery.Transaction_ID = tr.Transaction_ID;
			}

			try
			{
				GOOD_DELIVERY temp = db.GOOD_DELIVERY.FirstOrDefault(x=>x.OrderList_ID == ord);


                ShowGoodsDeliver frm = new ShowGoodsDeliver();
                if (temp == null)
				{
					db.GOOD_DELIVERY.Add(goodDelivery);
					db.SaveChanges();
					MessageBox.Show("Create Successfully");
                
                    frm.GoodsDeliveryID = txtGoodDeliver.Text;
					frm.Show();
                }
				else
				{
					MessageBox.Show("Already existed");
					string TransactionID = db.TRANSACTIONs.Where(x => x.Invoice_ID == cbxInvoiceID.SelectedValue.ToString()).Select(x=>x.Transaction_ID).Single();
					string DeliveryGoodID = db.GOOD_DELIVERY.Where(x=>x.Transaction_ID == TransactionID).Select(x=>x.Good_Delivery_ID).Single();
                    frm.GoodsDeliveryID = DeliveryGoodID;
					frm.Show();
                    return;
				}
			}
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

		public void reset()
		{

		}
    }
}
