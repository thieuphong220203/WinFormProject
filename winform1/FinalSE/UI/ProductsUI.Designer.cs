namespace FinalSE.UI
{
	partial class ProductsUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsUI));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
			this.txt = new System.Windows.Forms.Label();
			this.richtxtPhoto = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxTypeID = new System.Windows.Forms.ComboBox();
			this.txtQuantities = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.Price = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtPrice);
			this.panel2.Controls.Add(this.Price);
			this.panel2.Controls.Add(this.btnBrowse);
			this.panel2.Controls.Add(this.pictureBox);
			this.panel2.Controls.Add(this.txtFind);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.comboBoxSupplier);
			this.panel2.Controls.Add(this.txt);
			this.panel2.Controls.Add(this.richtxtPhoto);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.comboBoxTypeID);
			this.panel2.Controls.Add(this.txtQuantities);
			this.panel2.Controls.Add(this.txtName);
			this.panel2.Controls.Add(this.txtProductID);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.lblID);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1353, 380);
			this.panel2.TabIndex = 4;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(993, 306);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(147, 49);
			this.btnBrowse.TabIndex = 34;
			this.btnBrowse.Text = "Browser";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
			this.pictureBox.Location = new System.Drawing.Point(944, 53);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(246, 241);
			this.pictureBox.TabIndex = 33;
			this.pictureBox.TabStop = false;
			// 
			// txtFind
			// 
			this.txtFind.Location = new System.Drawing.Point(626, 262);
			this.txtFind.Margin = new System.Windows.Forms.Padding(9);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(281, 26);
			this.txtFind.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(517, 264);
			this.label7.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 21);
			this.label7.TabIndex = 31;
			this.label7.Text = "Find:";
			// 
			// comboBoxSupplier
			// 
			this.comboBoxSupplier.FormattingEnabled = true;
			this.comboBoxSupplier.Location = new System.Drawing.Point(626, 206);
			this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(9);
			this.comboBoxSupplier.Name = "comboBoxSupplier";
			this.comboBoxSupplier.Size = new System.Drawing.Size(281, 28);
			this.comboBoxSupplier.TabIndex = 30;
			// 
			// txt
			// 
			this.txt.AutoSize = true;
			this.txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt.ForeColor = System.Drawing.Color.Blue;
			this.txt.Location = new System.Drawing.Point(517, 202);
			this.txt.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(82, 21);
			this.txt.TabIndex = 29;
			this.txt.Text = "Supplier:";
			// 
			// richtxtPhoto
			// 
			this.richtxtPhoto.Location = new System.Drawing.Point(626, 120);
			this.richtxtPhoto.Margin = new System.Windows.Forms.Padding(9);
			this.richtxtPhoto.Name = "richtxtPhoto";
			this.richtxtPhoto.Size = new System.Drawing.Size(281, 50);
			this.richtxtPhoto.TabIndex = 28;
			this.richtxtPhoto.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(517, 134);
			this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 21);
			this.label6.TabIndex = 27;
			this.label6.Text = "Photo:";
			// 
			// comboBoxTypeID
			// 
			this.comboBoxTypeID.FormattingEnabled = true;
			this.comboBoxTypeID.Location = new System.Drawing.Point(159, 226);
			this.comboBoxTypeID.Margin = new System.Windows.Forms.Padding(9);
			this.comboBoxTypeID.Name = "comboBoxTypeID";
			this.comboBoxTypeID.Size = new System.Drawing.Size(287, 28);
			this.comboBoxTypeID.TabIndex = 26;
			// 
			// txtQuantities
			// 
			this.txtQuantities.Location = new System.Drawing.Point(159, 273);
			this.txtQuantities.Margin = new System.Windows.Forms.Padding(9);
			this.txtQuantities.Name = "txtQuantities";
			this.txtQuantities.Size = new System.Drawing.Size(287, 26);
			this.txtQuantities.TabIndex = 25;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(159, 176);
			this.txtName.Margin = new System.Windows.Forms.Padding(9);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(287, 26);
			this.txtName.TabIndex = 24;
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(159, 132);
			this.txtProductID.Margin = new System.Windows.Forms.Padding(9);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(287, 26);
			this.txtProductID.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(38, 233);
			this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 21);
			this.label5.TabIndex = 22;
			this.label5.Text = "Type ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(38, 273);
			this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 21);
			this.label3.TabIndex = 21;
			this.label3.Text = "Quatities:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(38, 181);
			this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 21);
			this.label2.TabIndex = 20;
			this.label2.Text = "Name:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Blue;
			this.lblID.Location = new System.Drawing.Point(38, 140);
			this.lblID.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(108, 21);
			this.lblID.TabIndex = 19;
			this.lblID.Text = "Product ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(566, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 34);
			this.label1.TabIndex = 14;
			this.label1.Text = "PRODUCTS";
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewProducts.Location = new System.Drawing.Point(0, 380);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.RowHeadersWidth = 62;
			this.dataGridViewProducts.RowTemplate.Height = 28;
			this.dataGridViewProducts.Size = new System.Drawing.Size(1353, 380);
			this.dataGridViewProducts.TabIndex = 5;
			this.dataGridViewProducts.Click += new System.EventHandler(this.dataGridViewProducts_Click);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(159, 317);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(9);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(287, 26);
			this.txtPrice.TabIndex = 36;
			// 
			// Price
			// 
			this.Price.AutoSize = true;
			this.Price.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price.ForeColor = System.Drawing.Color.Blue;
			this.Price.Location = new System.Drawing.Point(38, 319);
			this.Price.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(93, 21);
			this.Price.TabIndex = 35;
			this.Price.Text = "Quatities:";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.ImageIndex = 2;
			this.btnAdd.ImageList = this.imageList1;
			this.btnAdd.Location = new System.Drawing.Point(74, 17);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(108, 42);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.ImageIndex = 3;
			this.btnRemove.ImageList = this.imageList1;
			this.btnRemove.Location = new System.Drawing.Point(219, 17);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(108, 42);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "Remove";
			this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.ImageIndex = 1;
			this.btnEdit.ImageList = this.imageList1;
			this.btnEdit.Location = new System.Drawing.Point(364, 17);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(108, 42);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.ImageKey = "diskette.png";
			this.btnSave.ImageList = this.imageList1;
			this.btnSave.Location = new System.Drawing.Point(509, 17);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(108, 42);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnFind
			// 
			this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFind.ImageIndex = 8;
			this.btnFind.ImageList = this.imageList1;
			this.btnFind.Location = new System.Drawing.Point(799, 17);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(108, 42);
			this.btnFind.TabIndex = 4;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnBack
			// 
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.ImageIndex = 6;
			this.btnBack.ImageList = this.imageList1;
			this.btnBack.Location = new System.Drawing.Point(944, 17);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(108, 42);
			this.btnBack.TabIndex = 5;
			this.btnBack.Text = "Back";
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.ImageIndex = 5;
			this.btnCancel.ImageList = this.imageList1;
			this.btnCancel.Location = new System.Drawing.Point(654, 17);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(108, 42);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.btnFind);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnEdit);
			this.panel1.Controls.Add(this.btnRemove);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 760);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1353, 76);
			this.panel1.TabIndex = 3;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "logout.png");
			this.imageList1.Images.SetKeyName(1, "pen.png");
			this.imageList1.Images.SetKeyName(2, "plus2.png");
			this.imageList1.Images.SetKeyName(3, "remove.png");
			this.imageList1.Images.SetKeyName(4, "diskette.png");
			this.imageList1.Images.SetKeyName(5, "prohibition.png");
			this.imageList1.Images.SetKeyName(6, "logout.png");
			this.imageList1.Images.SetKeyName(7, "user3.png");
			this.imageList1.Images.SetKeyName(8, "show.png");
			// 
			// ProductsUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1353, 836);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ProductsUI";
			this.Text = "ProductsUI";
			this.Load += new System.EventHandler(this.ProductsUI_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxTypeID;
		private System.Windows.Forms.TextBox txtQuantities;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBoxSupplier;
		private System.Windows.Forms.Label txt;
		private System.Windows.Forms.RichTextBox richtxtPhoto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label Price;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imageList1;
	}
}