using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSE.EF;
using FinalSE.Models;

namespace FinalSE.UI
{
    public partial class SupplierUI : DevExpress.XtraEditors.XtraUserControl
    {
        public SupplierUI()
		{
			InitializeComponent();
		}

		private void Supplier_Load(object sender, EventArgs e)
		{
			barButtonItem2.Enabled= false;
			Supplier supplier = new Supplier();
			List<SUPPLIER> l = supplier.getList();
			gcList.DataSource = l;
			gvList.Columns.Remove(gvList.Columns["MOBILE_PRODUCT"]);
			
		}

		private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Hide();
			
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			
		}

		private void gcList_Click(object sender, EventArgs e)
		{

		}
	}
}
