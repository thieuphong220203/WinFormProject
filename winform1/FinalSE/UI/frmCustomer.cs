using FinalSE.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSE.UI
{
	public partial class frmCustomer : Form
	{
		DataTable dataTable;
		public frmCustomer()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void frmCustomer_Load(object sender, EventArgs e)
		{
			txtID.Enabled= false;
			btnSave.Enabled= false;
			btnEdit.Enabled= false;
			btnCancel.Enabled= false;
			/*Functions.connect();*/
			LoadDataGridView();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			/*Functions.disconnect();*/
			this.Close();
		}

		private void LoadDataGridView()
		{
			string sql = null;
			sql = "Select * from [CUSTOMER]";
			dataTable = Functions.LoadDataToTable(sql);
			dataGridCustomer.DataSource = dataTable;
			dataGridCustomer.Columns[0].HeaderText = "ID";
			dataGridCustomer.Columns[0].Width= 80;
			dataGridCustomer.Columns[1].HeaderText = "Name";
			dataGridCustomer.Columns[1].Width = 150;
			dataGridCustomer.Columns[2].HeaderText = "BirthDay";
			dataGridCustomer.Columns[2].Width = 70;
			dataGridCustomer.Columns[3].HeaderText = "Gender";
			dataGridCustomer.Columns[3].Width = 50;

			dataGridCustomer.Columns[4].HeaderText = "Address";
			dataGridCustomer.Columns[4].Width = 150;

			dataGridCustomer.Columns[5].HeaderText = "Email";
			dataGridCustomer.Columns[5].Width = 200;

			dataGridCustomer.Columns[6].HeaderText = "Phone";
			dataGridCustomer.AllowUserToAddRows= false;
			dataGridCustomer.AllowUserToDeleteRows= false;
			dataGridCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;


		}

		private void dataGridCustomer_Click(object sender, EventArgs e)
		{
			if(btnAdd.Enabled == false) {
				txtName.Focus();
			
			}

			txtID.Text = dataGridCustomer.CurrentRow.Cells["Customer_ID"].Value.ToString();
			txtName.Text = dataGridCustomer.CurrentRow.Cells["Customer_Name"].Value.ToString();
			txtAddress.Text = dataGridCustomer.CurrentRow.Cells["Customer_Address"].Value.ToString();
			txtEmail.Text = dataGridCustomer.CurrentRow.Cells["Customer_Email"].Value.ToString();
			txtPhone.Text = dataGridCustomer.CurrentRow.Cells["Customer_Phone"].Value.ToString();
			radioMale.Checked = (dataGridCustomer.CurrentRow.Cells["Customer_Gender"].Value.ToString() == "Male")?true:false;
			radioFemale.Checked = (dataGridCustomer.CurrentRow.Cells["Customer_Gender"].Value.ToString() == "Female")?true:false;
			dateTimePickerBirth.Value = Convert.ToDateTime(dataGridCustomer.CurrentRow.Cells["Customer_Birth"].Value);
			
		
			btnEdit.Enabled = true;	
			btnRemove.Enabled = true;
			btnCancel.Enabled = true;
			btnSave.Enabled = false;
			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			btnEdit.Enabled = false;
			btnRemove.Enabled = false;
			btnCancel.Enabled = true;
			btnSave.Enabled = true;
			ClearAll();
			//tu sinh ID
			txtID.Text = Functions.AutoIDCustomer();
			
		}

		private void ClearAll()
		{
			txtID.Text = "";
			txtName.Text = "";
			txtAddress.Text = "";
			txtEmail.Text = "";
			txtPhone.Text = "";
			radioMale.Checked=false;
			radioFemale.Checked=false;
		}

		private void dataGridCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Name");
				txtName.Focus();
				return;
			}

			if (dateTimePickerBirth.Value == DateTime.Now)
			{
				MessageBox.Show("Please Enter Birth");
				dateTimePickerBirth.Focus();
				return;
			}

			if (txtAddress.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Address");
				txtAddress.Focus();
				return;
			}

			if (txtEmail.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Email");
				txtEmail.Focus();
				return;
			}

			if (txtPhone.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Phone");
				txtPhone.Focus();
				return;
			}

			if (radioMale.Checked == false && radioFemale.Checked == false)
			{
				MessageBox.Show("Please choose gender");
				return;
			}

			try
			{
				/*if(Functions.conn.State == ConnectionState.Closed) { Functions.conn.Open(); }*/
				string sql = "INSERT INTO [CUSTOMER] VALUES(@id, @name, @birth, @gender, @address, @email, @phone)";
				SqlCommand cmd = new SqlCommand(sql, Functions.conn);
				cmd.Parameters.AddWithValue("@id", txtID.Text);
				
				cmd.Parameters.AddWithValue("@name", txtName.Text);
				cmd.Parameters.AddWithValue("@birth", dateTimePickerBirth.Value);
				cmd.Parameters.AddWithValue("@gender", (radioFemale.Checked)?"Female":"Male");
				cmd.Parameters.AddWithValue("@address", txtAddress.Text);
				cmd.Parameters.AddWithValue("@email", txtEmail.Text);
				cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				MessageBox.Show("Add Successful");
				txtID.Text = "";

				LoadDataGridView();
				
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			


		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearAll();
			btnRemove.Enabled= true;
			btnSave.Enabled= false;
			btnRemove.Enabled= false;
			btnEdit.Enabled= false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (txtName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Name");
				txtName.Focus();
				return;
			}

			if (dateTimePickerBirth.Value == DateTime.Now)
			{
				MessageBox.Show("Please Enter Birth");
				dateTimePickerBirth.Focus();
				return;
			}

			if (txtAddress.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Address");
				txtAddress.Focus();
				return;
			}

			if (txtEmail.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Email");
				txtEmail.Focus();
				return;
			}

			if (txtPhone.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please Enter Phone");
				txtPhone.Focus();
				return;
			}

			if (radioMale.Checked == false && radioFemale.Checked == false)
			{
				MessageBox.Show("Please choose gender");
				return;
			}

		
			string sql = "UPDATE [CUSTOMER] SET Customer_Name=@name, Customer_Birth=@birth, " +
				"Customer_Gender=@gender,Customer_Address=@address, Customer_Email=@email, " +
				"Customer_Phone=@phone WHERE Customer_ID=@id";
			try
			{
				if (Functions.conn.State == ConnectionState.Closed) { Functions.conn.Open(); }
				SqlCommand cmd = new SqlCommand(sql, Functions.conn);
				cmd.Parameters.AddWithValue("@name", txtName.Text);
				cmd.Parameters.AddWithValue("@birth", dateTimePickerBirth.Value);
				cmd.Parameters.AddWithValue("@gender", (radioFemale.Checked) ? "Female" : "Male");
				cmd.Parameters.AddWithValue("@address", txtAddress.Text);
				cmd.Parameters.AddWithValue("@email", txtEmail.Text);
				cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
				cmd.Parameters.AddWithValue("@id", txtID.Text);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				LoadDataGridView();
				MessageBox.Show("Edit Successful for Customer: " + txtID.Text);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult res = MessageBox.Show("Do you want to delete this customer?", "Warning Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes == res)
				{
					/*if (Functions.conn.State == ConnectionState.Closed) { Functions.conn.Open(); }*/
					string sql = "DELETE FROM [CUSTOMER] WHERE Customer_ID = '" + txtID.Text + "'";
					Functions.executeSQL(sql);
					MessageBox.Show("Delete Sucessfully");
					LoadDataGridView();
					ClearAll();
					btnRemove.Enabled = false;
					btnEdit.Enabled= false;
				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			

		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
