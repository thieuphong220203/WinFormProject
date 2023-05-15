using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Security.Policy;

namespace FinalSE.Class
{
	internal class Functions
	{
		public static SqlConnection conn; //doi tuong ket noi
		
		//Connection Function
		public static void connect()
		{
			conn = new SqlConnection();
			conn.ConnectionString = Properties.Settings.Default.FinalSeConnection;
			if (conn.State!= ConnectionState.Open)
			{
				conn.Open();
				MessageBox.Show("Connect Successfully");
			}else
			{
				MessageBox.Show("Connect Unsucessfully");

			}
		}

		//Disconect Function
		public static void disconnect() { 
			if(conn.State == ConnectionState.Open) {
				conn.Close();
				conn.Dispose();
				conn = null;
			}
		}

		//Load Data
		public static DataTable LoadDataToTable(string sql)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(sql,conn);
			da.Fill(dt);

			return dt;
		}

		//Insert SQL Command 
		public static void executeSQL(string sql)
		{
			if(conn.State != ConnectionState.Open) { conn.Open(); }
			SqlCommand cmd = new SqlCommand(sql,conn);
			try
			{
				cmd.ExecuteNonQuery(); //No need Query
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			cmd.Dispose();
			cmd = null;

		}

		public static string AutoIDCustomer()
		{
			if(conn.State!= ConnectionState.Open) { conn.Open();}
			string res = null;
			int temp;
			string sql = "SELECT MAX(Customer_ID) FROM [CUSTOMER]";
			SqlCommand cmd = new SqlCommand(sql,conn);
			string maxID = cmd.ExecuteScalar() as string;

			
			if(maxID == null)
			{
				res = "C000000001";
			}else
			{
				temp = Convert.ToInt32(maxID.Substring(1,9));
				temp++;
				res = String.Format("C{0:000000000}", temp);
			}
			
			return res;
		}

		public static string AutoIDProduct()
		{
			if(conn.State != ConnectionState.Open) { conn.Open();}	
			string res = null;
			int temp;
			string sql = "SELECT MAX(Product_ID) FROM [MOBILE_PRODUCT]";
			SqlCommand cmd = new SqlCommand(sql, conn);
			string maxID = cmd.ExecuteScalar() as string;

			if(maxID == null)
			{
				res = "PR00000001";
			}else
			{
				temp = Convert.ToInt32(maxID.Substring(2,8));
				temp++;
				res = String.Format("PR{0:00000000}", temp);
			}
			return res;
		}

		public static string AutoIDReceipt()
		{
			if (conn.State != ConnectionState.Open) { conn.Open(); }
			string res = null;
			int temp;
			string sql = "SELECT MAX(Receipt_ID) FROM [WAREHOUSE_RECEIPT]";
			SqlCommand cmd = new SqlCommand(sql, conn);
			string maxID = cmd.ExecuteScalar() as string;

			if (maxID == null)
			{
				res = "RE00000001";
			}
			else
			{
				temp = Convert.ToInt32(maxID.Substring(2, 8));
				temp++;
				res = String.Format("RE{0:00000000}", temp);
			}
			return res;
		}

        public static string AutoIDGoodDelivery()
        {
            if (conn.State != ConnectionState.Open) { conn.Open(); }
            string res = null;
            int temp;
            string sql = "SELECT MAX(Good_Delivery_ID) FROM [GOOD_DELIVERY]";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string maxID = cmd.ExecuteScalar() as string;

            if (maxID == null)
            {
                res = "GD00000001";
            }
            else
            {
                temp = Convert.ToInt32(maxID.Substring(2, 8));
                temp++;
                res = String.Format("GD{0:00000000}", temp);
            }
            return res;
        }

        public static void FillComboBox(string sql, ComboBox cbo, string ID, string Name)
		{
			if(conn.State != ConnectionState.Open) { conn.Open(); }
			SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			dap.Fill(dt);
			cbo.DataSource = dt;
			cbo.ValueMember = ID; //value range
			cbo.DisplayMember = Name; //name range of value
		}

		//getValue 
		public static string getValue(string sql)
		{
			string res = null;
			try
			{
				if(conn.State != ConnectionState.Open) { conn.Open(); }
				SqlCommand cmd = new SqlCommand(sql, conn);
				res = cmd.ExecuteScalar() as string;
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return res;
		}
	}
}
