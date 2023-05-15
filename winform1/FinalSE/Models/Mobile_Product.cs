using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraLayout;
using FinalSE.EF;
using FinalSE.Models;

namespace FinalSE.Models
{
	internal class Mobile_Product
	{
		FINAL_SEEntities db = new FINAL_SEEntities();

		public  MOBILE_PRODUCT findProduct(string variable)
		{
			MOBILE_PRODUCT mobile = new MOBILE_PRODUCT();
			mobile = db.MOBILE_PRODUCT.FirstOrDefault(x=>x.Product_ID == variable || x.Product_Name == variable);
			return mobile;
		}

		public List<MOBILE_PRODUCT> getList()
		{
			return db.MOBILE_PRODUCT.ToList();
		}

		public MOBILE_PRODUCT getProductByID(string id)
		{
			return db.MOBILE_PRODUCT.FirstOrDefault(x => x.Product_ID == id);
		}

		public List<MOBILE_PRODUCT> getListProductByID(string id)
		{
			return db.ORDER_LIST_DETAILS.Where(x =>x.OrderList_ID == id).Select(x=>x.MOBILE_PRODUCT).ToList();
		}
	}
}
