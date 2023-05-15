using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSE.Class;
namespace FinalSE.UI
{
	public partial class ShowGoodsDeliver : Form
	{
        public string GoodsDeliveryID { get; set; }
        DataTable dt = null;
		public ShowGoodsDeliver()
		{
			InitializeComponent();
			/*Functions.connect();*/
		}

		private void ReceiptShow_Load(object sender, EventArgs e)
		{
			dataGridViewShow.DataSource = LoadData();
			this.Size = new Size(650, 600);


			dataGridViewShow.Columns[4].Width = 200;
		}

		private DataTable LoadData()
		{
			string sql = "SELECT * FROM [GOOD_DELIVERY] WHERE Good_Delivery_ID ='" + GoodsDeliveryID +"'";
			dt = Functions.LoadDataToTable(sql);
			return dt;
		}
	}
}
