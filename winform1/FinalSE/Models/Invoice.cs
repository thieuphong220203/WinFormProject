using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalSE.EF;

namespace FinalSE.Models
{
	
	public class Invoice
	{
		FINAL_SEEntities db = new FINAL_SEEntities();
		
		public INVOICE getInVoiceByID(string id)
		{
			return db.INVOICEs.FirstOrDefault(x=>x.Invoice_ID == id);
		}
	}
}
