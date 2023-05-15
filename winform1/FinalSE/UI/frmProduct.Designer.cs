namespace FinalSE.UI
{
	partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantities = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richtxtPhoto = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.comboBoxTypeID = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 314);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1070, 417);
            this.dataGridViewProducts.TabIndex = 6;
            this.dataGridViewProducts.Click += new System.EventHandler(this.dataGridViewProducts_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(19, 76);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(73, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quatities:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(424, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Photo:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(118, 77);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(263, 21);
            this.txtProductID.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 121);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 21);
            this.txtName.TabIndex = 9;
            // 
            // txtQuantities
            // 
            this.txtQuantities.Location = new System.Drawing.Point(118, 204);
            this.txtQuantities.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQuantities.Name = "txtQuantities";
            this.txtQuantities.Size = new System.Drawing.Size(263, 21);
            this.txtQuantities.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(118, 237);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(263, 21);
            this.txtPrice.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(401, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "PRODUCTS";
            // 
            // richtxtPhoto
            // 
            this.richtxtPhoto.Location = new System.Drawing.Point(499, 68);
            this.richtxtPhoto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richtxtPhoto.Name = "richtxtPhoto";
            this.richtxtPhoto.Size = new System.Drawing.Size(189, 34);
            this.richtxtPhoto.TabIndex = 14;
            this.richtxtPhoto.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(750, 19);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(180, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(750, 230);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(180, 43);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // comboBoxTypeID
            // 
            this.comboBoxTypeID.FormattingEnabled = true;
            this.comboBoxTypeID.Location = new System.Drawing.Point(118, 161);
            this.comboBoxTypeID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxTypeID.Name = "comboBoxTypeID";
            this.comboBoxTypeID.Size = new System.Drawing.Size(263, 21);
            this.comboBoxTypeID.TabIndex = 18;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.Blue;
            this.txt.Location = new System.Drawing.Point(424, 119);
            this.txt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(59, 17);
            this.txt.TabIndex = 19;
            this.txt.Text = "Supplier:";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(499, 123);
            this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(189, 21);
            this.comboBoxSupplier.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(424, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Find:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(499, 160);
            this.txtFind.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(189, 21);
            this.txtFind.TabIndex = 22;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.txtFind);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.comboBoxSupplier);
            this.panelControl2.Controls.Add(this.txt);
            this.panelControl2.Controls.Add(this.comboBoxTypeID);
            this.panelControl2.Controls.Add(this.btnBrowse);
            this.panelControl2.Controls.Add(this.pictureBox);
            this.panelControl2.Controls.Add(this.richtxtPhoto);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txtPrice);
            this.panelControl2.Controls.Add(this.txtQuantities);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Controls.Add(this.txtProductID);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.lblID);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1070, 314);
            this.panelControl2.TabIndex = 5;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(49, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 27);
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
            this.btnRemove.Location = new System.Drawing.Point(146, 11);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 27);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(243, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 27);
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
            this.btnSave.Location = new System.Drawing.Point(339, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 27);
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
            this.btnFind.Location = new System.Drawing.Point(533, 11);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(72, 27);
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
            this.btnBack.Location = new System.Drawing.Point(629, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 27);
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
            this.btnCancel.Location = new System.Drawing.Point(436, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 27);
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
            this.panel1.Location = new System.Drawing.Point(0, 731);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 45);
            this.panel1.TabIndex = 2;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1070, 776);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtQuantities;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richtxtPhoto;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.ComboBox comboBoxTypeID;
		private System.Windows.Forms.Label txt;
		private System.Windows.Forms.ComboBox comboBoxSupplier;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFind;
		private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}