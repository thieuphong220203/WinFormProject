using FinalSE.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSE.Models;
using DevExpress.XtraEditors;
using System.Runtime.Remoting.Messaging;
using FinalSE.Class;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using System.Xml.Linq;

namespace FinalSE.UI
{
	public partial class Receipt : Form
	{
		
		DataTable table = null;
		FINAL_SEEntities db = new FINAL_SEEntities();
		public string AccountantUserName { get; set; }
		public Receipt()
		{
			InitializeComponent();
			/*Functions.connect();*/


		}

		private void Receipt_Load(object sender, EventArgs e)
		{
			txtAccountantID.Enabled = false;
			txtAccountantName.Enabled = false;
			txtSupplierID.Enabled = false;
			txtReceiptID.Enabled = false;
			dataGridViewInput.AutoGenerateColumns = false;
			dataGridViewInput.Columns[2].ReadOnly = true;
			dataGridViewInput.Columns[3].ReadOnly = true;

			dateCreated.Value= DateTime.Now;
			txtAccountantName.Text = AccountantUserName;
			txtReceiptID.Text = Functions.AutoIDReceipt();

			/*fillCombo();*/
			ProductIDComboBox();




			List<string> info = AccountantInfo();
			if(info != null)
			{
				txtAccountantID.Text = info[0];
				txtAccountantName.Text = info[1];
			}else
			{
				MessageBox.Show("Do not have accountant");
				return;
			}

			string sql = "SELECT * FROM [SUPPLIER]";
			Functions.FillComboBox(sql, comboBoxSupplierName,"Supplier_ID", "Supplier_Name");
			
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			
			string product_ID = null;
			int quantities = 0;
			decimal price = 0;
			decimal total = 0;
			string driverName = txtDriverName.Text;

			/*driverName = (dataGridViewInput.Rows[0].Cells[3].Value.ToString().Equals(DBNull.Value)) ? "": dataGridViewInput.Rows[0].Cells[3].Value.ToString();*/
			if (dataGridViewInput.Rows[0].Cells[0].Value == null)
			{
				MessageBox.Show("You have not enter data");
				return;
			}

			string sql = "INSERT INTO WAREHOUSE_RECEIPT VALUES(@receipt, @accountant, @date, @driver, @address, @total)";
			SqlCommand cmd = new SqlCommand(sql, Functions.conn);
			cmd.Parameters.AddWithValue("@receipt", txtReceiptID.Text);
			cmd.Parameters.AddWithValue("@accountant", txtAccountantID.Text);
			cmd.Parameters.AddWithValue("@date", dateCreated.Value);
			cmd.Parameters.AddWithValue("@driver", driverName);
			cmd.Parameters.AddWithValue("@address", txtAddress.Text);
			cmd.Parameters.AddWithValue("@total", total);
			cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();
			cmd.Dispose();

			for (int i = 0; i < dataGridViewInput.Rows.Count - 1; i++)
			{
				Mobile_Product prs = new Mobile_Product();
				product_ID = dataGridViewInput.Rows[i].Cells[0].Value.ToString();
				quantities = Convert.ToInt32(dataGridViewInput.Rows[i].Cells[1].Value.ToString());
				/*MOBILE_PRODUCT temp = prs.getProductByID(product_ID);
				temp.Product_Quantities += quantities;*/
				var entity = db.MOBILE_PRODUCT.Find(product_ID);

				if (entity != null)
				{
					int? temp = entity.Product_Quantities;
					temp = temp + quantities;
					entity.Product_Quantities = temp;
					
					try
					{
						db.SaveChanges();

					}
					catch (Exception ex) { MessageBox.Show(ex.Message); }
				}

				price = Convert.ToDecimal(dataGridViewInput.Rows[i].Cells[2].Value.ToString());
				/*total = price +  Convert.ToDecimal(dataGridViewInput.Rows[i].Cells[3].Value.ToString());*/
				
				driverName = dataGridViewInput.Rows[i].Cells[3].Value.ToString();
				total += price;
				RECEIPT_DETAILS rc = new RECEIPT_DETAILS();
				rc.Receipt_ID = txtReceiptID.Text;
				rc.Product_ID= product_ID;
				rc.Price= price;
				rc.Quantities= quantities;
				db.RECEIPT_DETAILS.Add(rc);
				db.SaveChanges();
			}

			try
			{
				sql = "Update WAREHOUSE_RECEIPT SET Total = @total WHERE Receipt_ID =@id";
				SqlCommand cmd2 = new SqlCommand(sql, Functions.conn);
				cmd2.Parameters.AddWithValue("@total", total);
				cmd2.Parameters.AddWithValue("@id", txtReceiptID.Text);
				cmd2.ExecuteNonQuery();
				cmd2.Dispose();
			}
			catch(Exception ex) { MessageBox.Show(ex.Message); }
			
			MessageBox.Show("Create Successfully");
			dataGridViewInput.Rows.Clear();
			dataGridViewInput.DataSource = null;
			ClearAll();
		}

        private void ClearAll()
        {
            txtReceiptID.Text = Functions.AutoIDReceipt();
            dateCreated.Value = DateTime.Now;
            txtAddress.Text = "";
			txtPhone.Text = "";
            txtDriverName.Text = "";
        }

        private bool HasDuplicateFields(DataGridView datagridview)
		{
			for(int i = 0; i < datagridview.Rows.Count - 1; i++)
			{
				DataGridViewRow row = datagridview.Rows[i];

				for(int j = i + 1; j < datagridview.Rows.Count - 1; j++)
				{
					DataGridViewRow otherRow = datagridview.Rows[j];
					if (row.Cells[0].Value.ToString() == otherRow.Cells[0].Value.ToString())
					{
						return true;
					}
				}
			}
			return false;
		}
		

		private void TableOfProduct_Click(object sender, EventArgs e)
		{
			ProductsUI frm = new ProductsUI();
			frm.StartPosition = FormStartPosition.CenterScreen;
			frm.Width = 1000;
			frm.Height = 600;
			frm.FormBorderStyle= FormBorderStyle.Sizable;
			frm.Show();
		}

		private void txtReceiptID_TextChanged(object sender, EventArgs e)
		{

		}

		public List<string> AccountantInfo() { 
			Accountant acc = new Accountant();
			try
			{
				ACCOUNTANT temp = acc.getItemByUserName(AccountantUserName);
				
					List<string> list = new List<string>();
					list.Add(temp.Accountant_ID);
					list.Add(temp.Accountant_Name);
				
					return list;
				
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
			return null;
		}

		private void comboBoxSupplierName_SelectedValueChanged(object sender, EventArgs e)
		{
			Supplier supplier = new Supplier();
			SUPPLIER supplierInfo = supplier.findSupplierByID(comboBoxSupplierName.SelectedValue.ToString());
			if(supplierInfo != null ) {
				txtSupplierID.Text= supplierInfo.Supplier_ID;
			}else
			{
				txtSupplierID.Text = string.Empty;
			}
			/*txtSupplierID.Text = supplierInfo.Supplier_ID;*/
			/*txtSupplierID.Text = comboBoxSupplierName.SelectedValue.ToString();*/

		}

		string selectedValue = string.Empty;
		private void dataGridViewInput_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		DataGridViewComboBoxColumn combo = null;
		private void fillCombo()
		{
			Mobile_Product products = new Mobile_Product();
			List<MOBILE_PRODUCT> listPro = products.getList();

			combo = (DataGridViewComboBoxColumn)dataGridViewInput.Columns["Product_Name"];
			combo.DisplayMember = "Product_Name";
			combo.ValueMember = "Product_ID";
			combo.DataSource = listPro;

		}

		void ProductIDComboBox()
		{
			DataTable dataTable= Functions.LoadDataToTable("SELECT * FROM MOBILE_PRODUCT");
			cbxProductName.DisplayMember= "Product_Name";
			cbxProductName.ValueMember= "Product_ID";
			DataRow topItem = dataTable.NewRow();
			topItem[0] = 0;
			topItem[1] = "--Select--";
			dataTable.Rows.InsertAt(topItem,0);
			cbxProductName.DataSource = dataTable;

		}


		private void dataGridViewInput_Click(object sender, EventArgs e)
		{

			
		}

		private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			

		}

		private void dataGridViewInput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

			if (e.ColumnIndex == 0)
			{
				if (HasDuplicateFields(dataGridViewInput))
				{
					MessageBox.Show("You have this product is receipt, Please modify the quantities");
					foreach (DataGridViewRow row in dataGridViewInput.SelectedRows)
					{
						if (!row.IsNewRow) { dataGridViewInput.Rows.Remove(row); }
					}
					return;
				}

				
			}
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridViewInput_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 1)
			{
				Mobile_Product pr = new Mobile_Product();
				var s = pr.getProductByID(dataGridViewInput.Rows[e.RowIndex].Cells[0].Value.ToString());


				/*var entity = db.MOBILE_PRODUCT.Find();*/

				int quantities = Convert.ToInt32(dataGridViewInput.Rows[e.RowIndex].Cells[1].Value);

				dataGridViewInput.Rows[e.RowIndex].Cells[2].Value = quantities * s.Price;
			}

			if(e.ColumnIndex == 0)
			{
				dataGridViewInput.Rows[e.RowIndex].Cells[3].Value = txtDriverName.Text;
				Mobile_Product pr = new Mobile_Product();
				var s = pr.getProductByID(dataGridViewInput.Rows[e.RowIndex].Cells[0].Value.ToString());



				int quantities = Convert.ToInt32(dataGridViewInput.Rows[e.RowIndex].Cells[1].Value);

				dataGridViewInput.Rows[e.RowIndex].Cells[2].Value = quantities * s.Price;
			}
			
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridViewInput.SelectedRows)
			{
				if (!row.IsNewRow) { dataGridViewInput.Rows.Remove(row); }
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
			
        }
    }
}
