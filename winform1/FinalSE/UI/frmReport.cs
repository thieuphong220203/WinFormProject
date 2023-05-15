using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using FinalSE.Class;
using FinalSE.EF;
using FinalSE.Models;
using Microsoft.Reporting.WinForms;

namespace FinalSE.UI
{
	public partial class frmReport : Form
	{
		public string InvoiceID { get; set; }
		public string AccountantID { get; set; }

        public string GoodsDelivery { get; set; }
        public frmReport()
		{
			InitializeComponent();
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			FINAL_SEEntities db = new FINAL_SEEntities();
			Invoice invoice = new Invoice();
			INVOICE ivs = invoice.getInVoiceByID(InvoiceID);


			
			/*DeliverReport deliver = new DeliverReport();
			deliver.InvoiceID = InvoiceID;
			deliver.OrderListID = ivs.OrderList_ID;
			deliver.date_created = Convert.ToDateTime(ivs.Date_Created_Invoice);*/

			OrderList_Details order = new OrderList_Details();
			ORDER_LIST_DETAILS ord = order.getOrderListDetails(ivs.OrderList_ID);
			/*MessageBox.Show(ord.Delivery_Date.ToString());
			deliver.Quantities = Convert.ToInt32(ord.Quantities);
			deliver.price = Convert.ToDecimal(ord.MOBILE_PRODUCT.Price);
			deliver.TotalMoney = Convert.ToDouble(ord.Total_Money);
			deliver.delivery_date = Convert.ToDateTime(ord.Delivery_Date);*/

			/*if (ivs.ORDER_LIST.AGENT_ACCOUNT != null)
			{
				deliver.CustomerName = ivs.ORDER_LIST.AGENT_ACCOUNT.AGENT.Agent_Name;
			}
			else
			{
				deliver.CustomerName = ivs.ORDER_LIST.CUSTOMER_ACCOUNT.CUSTOMER.Customer_Name;
			}*/

			/*MessageBox.Show(deliver.CustomerName);*/

			Mobile_Product mb = new Mobile_Product();
			List<MOBILE_PRODUCT> listMobiles = mb.getListProductByID(ord.OrderList_ID);
			List<DeliverReport> listDelivery = new List<DeliverReport>();

			Accountant acc = new Accountant();
			ACCOUNTANT a = acc.getItemByID(AccountantID);

			try
			{
				foreach (MOBILE_PRODUCT pr in listMobiles)
				{
					DeliverReport dl = new DeliverReport();
					dl.InvoiceID = InvoiceID;
					dl.OrderListID = ivs.OrderList_ID;
					dl.date_created = Convert.ToDateTime(ivs.Date_Created_Invoice);
					dl.Quantities = Convert.ToInt32(ord.Quantities);
					dl.price = Convert.ToDecimal(ord.MOBILE_PRODUCT.Price);
					dl.delivery_date = Convert.ToDateTime(ord.Delivery_Date);
					dl.TotalMoney = Convert.ToDouble(ord.Total_Money);
					dl.Product_Name= pr.Product_Name;
					dl.AccountantName = a.Accountant_Name;
					dl.goodDelivery = GoodsDelivery;
					if (ivs.ORDER_LIST.AGENT_ACCOUNT != null)
					{
						dl.CustomerName = ivs.ORDER_LIST.AGENT_ACCOUNT.AGENT.Agent_Name;
					}
					else
					{
						dl.CustomerName = ivs.ORDER_LIST.CUSTOMER_ACCOUNT.CUSTOMER.Customer_Name;
					}
					listDelivery.Add(dl);
				}


			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
			/*deliver.*/

			reportViewer1.LocalReport.ReportPath = "rptDelivery.rdlc";
			var source = new ReportDataSource("DeliveryDS", listDelivery);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(source);

			this.StartPosition= FormStartPosition.CenterScreen;
			this.Size = new Size(950, 600);
			this.reportViewer1.RefreshReport();
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
