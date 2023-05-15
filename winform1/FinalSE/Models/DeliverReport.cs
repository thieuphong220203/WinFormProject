using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSE.Models
{
	public class DeliverReport
	{
		public string InvoiceID { get; set; }
		public string OrderListID { get; set; }
		public string CustomerName { get; set; }
		public string AccountantName { get; set; }

		public string Product_Name { get; set; }
		public DateTime date_created { get; set; }

		public int Quantities { get; set; }
		public DateTime delivery_date { get; set; }

		public decimal price { get; set; }

		public double TotalMoney { get; set; }

		public string goodDelivery { get; set; }

	}
}
