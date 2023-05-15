using DevExpress.Utils.Extensions;
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
using FinalSE.EF;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraEditors;

namespace FinalSE.UI
{
	public partial class myInformationUI : UserControl
	{
		public string userName { get; set; }
		Accountant acc;
		public myInformationUI()
		{
			InitializeComponent();
		}

	

		private void lblGender_Click(object sender, EventArgs e)
		{

		}

		private void disable(TextEdit t)
		{
			t.ReadOnly= true;
			t.Enabled= false;
		}
		private void myInformationUI_Load(object sender, EventArgs e)
		{
			acc = new Accountant();
			string[] genders = new string[] { "Male", "Female" };
			comboBoxEditGender.Properties.Items.AddRange(genders);
			/*txtID.ReadOnly = true;
			txtID.Enabled = false;
			txtUserName.ReadOnly = true;
			txtUserName.ReadOnly = false;
			txtBirth.ReadOnly = true;
			txtBirth.Enabled = false;*/
			disable(txtID);
			disable(txtUserName);
			disable(txtBirth);

		}

		private void groupControlPersonal_Paint(object sender, PaintEventArgs e)
		{
			
			ACCOUNTANT a = acc.getItemByUserName(userName);
			txtID.Text = a.Accountant_ID;
			txtUserName.Text = a.Accountant_UserName;
			txtName.Text = a.Accountant_Name;
			txtMail.Text = a.Accountant_Email;
			txtAddress.Text = a.Accountant_Address;
			txtPhone.Text = a.Accountant_Phone;
			comboBoxEditGender.Text = a.Gender;
			/*dateTimePickerBirth.Text = a.Accountant_Birth.Value.ToString();*/
			txtBirth.Text = a.Accountant_Birth.Value.ToString("dd-MM-yyyy");
			if (a.Accountant_Image != null)
			{
				pictureBoxImage.Image = BinarytoImage(a.Accountant_Image);
			}
		}

		
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Picture files (.png,jpg)|*.png;*.jpg";
			if(openFile.ShowDialog() == DialogResult.OK)
			{
				pictureBoxImage.Image = Image.FromFile(openFile.FileName);
				pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
				
			}
		}

		private void txtUserName_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void groupBoxAccount_Paint(object sender, PaintEventArgs e)
		{
			ACCOUNTANT a = acc.getItemByUserName(userName);
			txtUserName.Text= a.Accountant_Name;
			txtPassword.Text= a.Accountant_Password;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			ACCOUNTANT accountant = acc.getItemByID(txtID.Text);
			accountant.Accountant_Name = txtName.Text;
			accountant.Gender = comboBoxEditGender.Text;
			accountant.Accountant_Birth = dateTimePickerBirth.Value;
			accountant.Accountant_Address = txtAddress.Text;
			accountant.Accountant_Email = txtMail.Text;
			accountant.Accountant_Phone = txtPhone.Text;
			accountant.Accountant_UserName = txtUserName.Text;
			accountant.Accountant_Password = txtPassword.Text;
			accountant.Accountant_Image = ImageToBinary(pictureBoxImage.Image, pictureBoxImage.Image.RawFormat);

			acc.update(accountant);
			
			MessageBox.Show("Save successfully");
			txtBirth.Text = accountant.Accountant_Birth.Value.ToString("dd-MM-yyyy");
		}

		public byte[] ImageToBinary(Image img, System.Drawing.Imaging.ImageFormat format)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				img.Save(ms, format);
				byte[] imageBytes = ms.ToArray();
				return imageBytes;
			}
			
		}

		public Image BinarytoImage(byte[] imageBytes)
		{
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		
	}
}
