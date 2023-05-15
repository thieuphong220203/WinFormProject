using FinalSE.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSE.Models
{
	
	public class TypeProduct
	{
		private FINAL_SEEntities db = new FINAL_SEEntities();

		public TYPE_PRODUCT getItem(string id)
		{
			return db.TYPE_PRODUCT.FirstOrDefault(x=>x.TypeProduct_ID==id);
		}

		public List<TYPE_PRODUCT> getList()
		{
			return db.TYPE_PRODUCT.ToList();	
		}
	}
}
