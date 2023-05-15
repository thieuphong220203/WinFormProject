using FinalSE.EF;
using FinalSE.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSE.Models
{
	public class Supplier
	{
		private FINAL_SEEntities db = new FINAL_SEEntities();
		
		public Supplier() {
			
			
		}
		public SUPPLIER getItem(string id)
		{
			return db.SUPPLIERs.FirstOrDefault(x=>x.Supplier_ID.Equals(id));
		}

		public List<SUPPLIER> getList()
		{
			return db.SUPPLIERs.ToList();
			/*var query = from s in db.SUPPLIERs select new { s.Supplier_ID, s.Supplier_Name, s.Supplier_Address, s.Supplier_Email, s.Suppler_Phone };
			var suppliers = new List<SUPPLIER>();
			foreach (var item in query)
			{
				suppliers.Add(new SUPPLIER
				{
					Supplier_ID = item.Supplier_ID,
					Supplier_Name = item.Supplier_Name,
					Supplier_Address = item.Supplier_Address,
					Supplier_Email= item.Supplier_Email,
					Suppler_Phone= item.Suppler_Phone,
				});
			}
			return suppliers;*/

		}

		public SUPPLIER findSupplierByID(string id)
		{
			return db.SUPPLIERs.FirstOrDefault(x=>x.Supplier_ID == id);
		}
	}
}
