using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSE.Class;
using FinalSE.EF;
using FinalSE.Models;
namespace FinalSE.UI
{
	public partial class ProductsUI : Form
	{
		DataTable dataTable = null;
		public ProductsUI()
		{
			InitializeComponent();
		}

		private void ProductsUI_Load(object sender, EventArgs e)
		{
			btnRemove.Enabled = false;
			btnEdit.Enabled = false;
			btnSave.Enabled = false;
			btnBrowse.Enabled = false;
			txtProductID.Enabled = false;

			/*Functions.connect();*/

			string sql = "SELECT * FROM [TYPE_PRODUCT]";
			Functions.FillComboBox(sql, comboBoxTypeID, "TypeProduct_ID", "TypeProductName");
			sql = "SELECT * FROM [SUPPLIER]";
			Functions.FillComboBox(sql, comboBoxSupplier, "Supplier_ID", "Supplier_Name");
			LoadDataGridView();
		}

		private void LoadDataGridView()
		{
			string sql = null;
			sql = "select p.Product_ID, p.Product_Name, p.TypeProduct_ID, p.Supplier_ID, p.Unit, p.Price, p.Product_Quantities, p.Image_Product, t.TypeProductName " +
				"from [MOBILE_PRODUCT] p " +
				"inner join [TYPE_PRODUCT] t on p.TypeProduct_ID = t.TypeProduct_ID";
			dataTable = Functions.LoadDataToTable(sql);
			dataGridViewProducts.DataSource = dataTable;

			//Set visible
			/*dataGridViewProducts.Columns["Supplier_ID"].Visible = false;*/
			dataGridViewProducts.Columns["Image_Product"].Visible = false;
			dataGridViewProducts.Columns["TypeProduct_ID"].Visible = false;

			//Set Index
			dataGridViewProducts.Columns["TypeProductName"].DisplayIndex = 2;

			dataGridViewProducts.Columns[0].HeaderText = "ID";
			dataGridViewProducts.Columns[0].Width = 80;
			dataGridViewProducts.Columns[1].HeaderText = "Name";
			dataGridViewProducts.Columns[1].Width = 230;
			dataGridViewProducts.Columns[4].HeaderText = "Currency";
			dataGridViewProducts.Columns[4].Width = 70;

			dataGridViewProducts.Columns[6].HeaderText = "Quantities";
			dataGridViewProducts.Columns[6].Width = 70;
			dataGridViewProducts.Columns[8].HeaderText = "Type Of Product";
			dataGridViewProducts.Columns[8].Width = 250;

			dataGridViewProducts.AllowUserToAddRows = false;
			dataGridViewProducts.AllowUserToDeleteRows = false;
			dataGridViewProducts.EditMode = DataGridViewEditMode.EditProgrammatically;


		}
		private void ClearAll()
		{
			txtProductID.Text = "";
			txtName.Text = "";
			txtQuantities.Text = "0";
			dataGridViewProducts.Text = "0";
			richtxtPhoto.Text = null;
			txt.Text = "";
			txtPrice.Text = "0";
			pictureBox.Image = pictureBox.InitialImage;
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			/*Functions.disconnect();*/
			this.Close();
		}

		private void dataGridViewProducts_Click(object sender, EventArgs e)
		{
			txtProductID.Text = dataGridViewProducts.CurrentRow.Cells["Product_ID"].Value.ToString();
			txtName.Text = dataGridViewProducts.CurrentRow.Cells["Product_Name"].Value.ToString();
			comboBoxTypeID.Text = dataGridViewProducts.CurrentRow.Cells["TypeProductName"].Value.ToString();
			txtPrice.Text = dataGridViewProducts.CurrentRow.Cells["Price"].Value.ToString();
			txtQuantities.Text = dataGridViewProducts.CurrentRow.Cells["Product_Quantities"].Value.ToString();
			comboBoxSupplier.Text = Functions.getValue("SELECT Supplier_Name FROM [SUPPLIER] WHERE Supplier_ID='" + dataGridViewProducts.CurrentRow.Cells["Supplier_ID"].Value.ToString() + "'");
			string sql = "SELECT Image_Product FROM [MOBILE_PRODUCT] WHERE Product_ID='" + txtProductID.Text + "'";

			richtxtPhoto.Text = Functions.getValue(sql);
			/*MessageBox.Show(Application.StartupPath.Length.ToString());*/
			/*MessageBox.Show(Application.StartupPath);*/
			int Lenghtpath = Application.StartupPath.Length;
            try
            {
				string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath.Substring(0, Lenghtpath - 9);
				
				/*string absolutePath = Path.GetDirectoryName(exeFile);*/
                /*MessageBox.Show(absolutePath);*/
                string fileName = exeFile + "\\img\\" + richtxtPhoto.Text;
				if (!string.IsNullOrEmpty(richtxtPhoto.Text) && System.IO.File.Exists(fileName))
				{
					pictureBox.Controls.Clear();

					pictureBox.Image = Image.FromFile(fileName);

					pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				}
				else
				{
					pictureBox.Image = pictureBox.InitialImage;
				}
			}
			catch (System.OutOfMemoryException ex)
			{
				MessageBox.Show(ex.Message);
			}



			btnEdit.Enabled = true;
			btnRemove.Enabled = true;
			btnBrowse.Enabled = true;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
			open.FilterIndex = 1;

			try
			{
				if (open.ShowDialog() == DialogResult.OK)
				{
					int LengthPath = Application.StartupPath.Length;
					MessageBox.Show(Application.StartupPath);
					richtxtPhoto.Text = open.FileName.Substring(LengthPath - 5);
					
					if (System.IO.File.Exists(open.FileName))
					{

						pictureBox.Controls.Clear();
						pictureBox.Image = Image.FromFile(open.FileName);
						pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					}

				}
			}
			catch (System.OutOfMemoryException ex)
			{
				MessageBox.Show("Failed to load image: " + ex.Message);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			pictureBox.Image = pictureBox.InitialImage;
			btnEdit.Enabled = false;
			btnRemove.Enabled = false;
			btnFind.Enabled = true;
			btnSave.Enabled = true;
			btnBrowse.Enabled = true;
			ClearAll();
			txtName.Focus();
			txtProductID.Text = Functions.AutoIDProduct();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Name");
				txtName.Focus();
				return;
			}

			if (comboBoxTypeID.SelectedValue == null)
			{
				MessageBox.Show("Please Enter TypeID");
				comboBoxTypeID.Focus();
				return;
			}

			if (txtQuantities.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Quantities");
				txtQuantities.Focus();
				return;
			}

			if (txtPrice.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Price");
				txtPrice.Focus();
				return;
			}

			try
			{
				string sql = "INSERT INTO [MOBILE_PRODUCT] VALUES(@id, @name, @type, @supplier, @unit, @price, @quantities, @image)";
				SqlCommand cmd = new SqlCommand(sql, Functions.conn);
				cmd.Parameters.AddWithValue("@id", txtProductID.Text);

				cmd.Parameters.AddWithValue("@name", txtName.Text);
				cmd.Parameters.AddWithValue("@type", comboBoxTypeID.SelectedValue.ToString());
				cmd.Parameters.AddWithValue("@supplier", comboBoxSupplier.SelectedValue.ToString());
				cmd.Parameters.AddWithValue("@unit", "USD");
				cmd.Parameters.AddWithValue("@price", txtPrice.Text);
				cmd.Parameters.AddWithValue("@quantities", txtQuantities.Text);
				cmd.Parameters.AddWithValue("@image", richtxtPhoto.Text);

				cmd.ExecuteNonQuery();
				cmd.Dispose();
				MessageBox.Show("Add Successful");
				txtProductID.Text = "";

				LoadDataGridView();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (txtName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Name");
				txtName.Focus();
				return;
			}

			if (comboBoxTypeID.SelectedValue == null)
			{
				MessageBox.Show("Please Enter TypeID");
				comboBoxTypeID.Focus();
				return;
			}

			if (txtQuantities.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Quantities");
				txtQuantities.Focus();
				return;
			}

			if (txtPrice.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Price");
				txtPrice.Focus();
				return;
			}

			string sql = "UPDATE [MOBILE_PRODUCT] SET Product_Name=@name, TypeProduct_ID=@type, " +
				"Supplier_ID=@supplier, Price=@price, " +
				"Product_Quantities=@quantities, Image_Product =@image WHERE Product_ID=@id";
			try
			{
				SqlCommand cmd = new SqlCommand(sql, Functions.conn);
				cmd.Parameters.AddWithValue("@name", txtName.Text);
				cmd.Parameters.AddWithValue("@type", comboBoxTypeID.SelectedValue.ToString());
				cmd.Parameters.AddWithValue("@supplier", comboBoxSupplier.SelectedValue.ToString());
				cmd.Parameters.AddWithValue("@price", txtPrice.Text);
				cmd.Parameters.AddWithValue("@quantities", txtQuantities.Text);
				cmd.Parameters.AddWithValue("@image", richtxtPhoto.Text);
				cmd.Parameters.AddWithValue("@id", txtProductID.Text);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				LoadDataGridView();
				MessageBox.Show("Edit Successful for Customer: " + txtProductID.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			Mobile_Product mo = new Mobile_Product();
			MOBILE_PRODUCT mobile = mo.findProduct(txtFind.Text);
			if (mobile == null)
			{
				MessageBox.Show("Do not have this object");
				LoadDataGridView();
				return;
			}

			try
			{
				string sql = null;
				sql = "select p.Product_ID, p.Product_Name, p.TypeProduct_ID, p.Supplier_ID, p.Unit, p.Price, p.Product_Quantities, p.Image_Product, t.TypeProductName " + "from [MOBILE_PRODUCT] p " + "inner join [TYPE_PRODUCT] t on p.TypeProduct_ID = t.TypeProduct_ID where Product_ID='" + mobile.Product_ID + "'" +
					"or Product_Name='" + mobile.Product_Name + "'";
				dataTable = Functions.LoadDataToTable(sql);


				dataGridViewProducts.DataSource = dataTable;

				dataGridViewProducts.Columns["Image_Product"].Visible = false;
				dataGridViewProducts.Columns["TypeProduct_ID"].Visible = false;

				//Set Index
				dataGridViewProducts.Columns["TypeProductName"].DisplayIndex = 2;

				dataGridViewProducts.Columns[0].HeaderText = "ID";
				dataGridViewProducts.Columns[0].Width = 80;
				dataGridViewProducts.Columns[1].HeaderText = "Name";
				dataGridViewProducts.Columns[1].Width = 230;
				dataGridViewProducts.Columns[4].HeaderText = "Currency";
				dataGridViewProducts.Columns[4].Width = 70;

				dataGridViewProducts.Columns[6].HeaderText = "Quantities";
				dataGridViewProducts.Columns[6].Width = 70;
				dataGridViewProducts.Columns[8].HeaderText = "Type Of Product";
				dataGridViewProducts.Columns[8].Width = 250;

				dataGridViewProducts.AllowUserToAddRows = false;
				dataGridViewProducts.AllowUserToDeleteRows = false;
				dataGridViewProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

			ClearAll();
			btnRemove.Enabled = true;
			btnSave.Enabled = false;
			btnRemove.Enabled = false;
			btnEdit.Enabled = false;
			LoadDataGridView();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = "delete from MOBILE_PRODUCT where Product_ID ='" + txtProductID.Text+"'";
				Functions.executeSQL(sql);
				MessageBox.Show("Delete Successful");
				LoadDataGridView();
				ClearAll();
			}
			catch(Exception ex) { MessageBox.Show(ex.Message); }
		}
	}
}
