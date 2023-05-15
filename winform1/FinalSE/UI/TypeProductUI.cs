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
	public partial class TypeProductUI : UserControl
	{
		public TypeProductUI()
		{
			InitializeComponent();
		}

		private void gcList_Click(object sender, EventArgs e)
		{

		}

		private void TypeProductUI_Load(object sender, EventArgs e)
		{
			TypeProduct t = new TypeProduct();
			List<TYPE_PRODUCT> l = t.getList();
			gcList.DataSource = l;
			gvList.Columns.Remove(gvList.Columns["MOBILE_PRODUCT"]);
			gvList.EditingValue = false;
			gcList.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
		}
	}
}
