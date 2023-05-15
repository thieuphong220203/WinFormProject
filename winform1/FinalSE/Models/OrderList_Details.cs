using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalSE.EF;
namespace FinalSE.Models
{
	internal class OrderList_Details
	{
		FINAL_SEEntities db = new FINAL_SEEntities();

		public ORDER_LIST_DETAILS getOrderListDetails(string id)
		{
			return db.ORDER_LIST_DETAILS.FirstOrDefault(x=>x.OrderList_ID == id);
		}
	}
}
