using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FinalSE.EF;

namespace FinalSE.Models
{
	public class Accountant
	{
		FINAL_SEEntities db = new FINAL_SEEntities();

		
		public ACCOUNTANT getItemByID(string id)
		{
			return db.ACCOUNTANTs.FirstOrDefault(x => x.Accountant_ID.Equals(id));
		}

		public ACCOUNTANT getItemByUserName(string username)
		{
			return db.ACCOUNTANTs.FirstOrDefault(x=>x.Accountant_UserName.Equals(username));
		}
		public List<ACCOUNTANT> getList()
		{
			return db.ACCOUNTANTs.ToList();
		}

		public ACCOUNTANT add(ACCOUNTANT item)
		{
			try
			{
				db.ACCOUNTANTs.Add(item);
				db.SaveChanges();
				return item;
			}catch(Exception ex)
			{
				 throw new Exception("Error occurred while adding an accountant: " + ex.InnerException?.Message, ex);
			}
			
		}

		public ACCOUNTANT update(ACCOUNTANT item)
		{
			try
			{
				ACCOUNTANT acc = db.ACCOUNTANTs.FirstOrDefault(x => x.Accountant_ID.Equals(item.Accountant_ID));
				acc.Accountant_Name = item.Accountant_Name;
				acc.Gender = item.Gender;
				acc.Accountant_Birth = item.Accountant_Birth;
				acc.Accountant_Address = item.Accountant_Address;
				acc.Accountant_Email = item.Accountant_Email;
				acc.Accountant_Phone = item.Accountant_Phone;
				acc.Accountant_UserName = item.Accountant_UserName;
				acc.Accountant_Password = item.Accountant_Password;
				acc.Accountant_Image = item.Accountant_Image;
				db.SaveChanges();
				return item;
			}
			catch (Exception ex)
			{
				throw new Exception("Error occurred while adding an accountant: " + ex.InnerException?.Message, ex);
			}

		}

		public void updatePassword(string userName, string password)
		{
			try
			{
				ACCOUNTANT acc = db.ACCOUNTANTs.FirstOrDefault(x => x.Accountant_UserName == userName);
				acc.Accountant_Password = password;
				db.SaveChanges();
			}catch(Exception ex) { throw new Exception("Some Error has occurs " + ex.Message); }
		}
	}
}
