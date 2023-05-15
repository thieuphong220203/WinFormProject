namespace FinalSE.UI
{
	partial class myInformationUI
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myInformationUI));
			this.groupControlPersonal = new DevExpress.XtraEditors.GroupControl();
			this.txtBirth = new DevExpress.XtraEditors.TextEdit();
			this.txtID = new DevExpress.XtraEditors.TextEdit();
			this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
			this.comboBoxEditGender = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtAddress = new DevExpress.XtraEditors.TextEdit();
			this.txtPhone = new DevExpress.XtraEditors.TextEdit();
			this.txtMail = new DevExpress.XtraEditors.TextEdit();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.groupBoxAccount = new DevExpress.XtraEditors.GroupControl();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUserName = new DevExpress.XtraEditors.TextEdit();
			this.lblUserName = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.groupControlPersonal)).BeginInit();
			this.groupControlPersonal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBirth.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGender.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxAccount)).BeginInit();
			this.groupBoxAccount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControlPersonal
			// 
			this.groupControlPersonal.Controls.Add(this.txtBirth);
			this.groupControlPersonal.Controls.Add(this.txtID);
			this.groupControlPersonal.Controls.Add(this.dateTimePickerBirth);
			this.groupControlPersonal.Controls.Add(this.comboBoxEditGender);
			this.groupControlPersonal.Controls.Add(this.txtAddress);
			this.groupControlPersonal.Controls.Add(this.txtPhone);
			this.groupControlPersonal.Controls.Add(this.txtMail);
			this.groupControlPersonal.Controls.Add(this.txtName);
			this.groupControlPersonal.Controls.Add(this.label4);
			this.groupControlPersonal.Controls.Add(this.label3);
			this.groupControlPersonal.Controls.Add(this.label2);
			this.groupControlPersonal.Controls.Add(this.label1);
			this.groupControlPersonal.Controls.Add(this.lblGender);
			this.groupControlPersonal.Controls.Add(this.lblName);
			this.groupControlPersonal.Controls.Add(this.lblID);
			this.groupControlPersonal.Location = new System.Drawing.Point(3, 386);
			this.groupControlPersonal.Name = "groupControlPersonal";
			this.groupControlPersonal.Size = new System.Drawing.Size(1171, 244);
			this.groupControlPersonal.TabIndex = 0;
			this.groupControlPersonal.Text = "Personal Information";
			this.groupControlPersonal.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControlPersonal_Paint);
			// 
			// txtBirth
			// 
			this.txtBirth.Location = new System.Drawing.Point(275, 201);
			this.txtBirth.Name = "txtBirth";
			this.txtBirth.Size = new System.Drawing.Size(284, 26);
			this.txtBirth.TabIndex = 19;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(275, 57);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(284, 26);
			this.txtID.TabIndex = 18;
			// 
			// dateTimePickerBirth
			// 
			this.dateTimePickerBirth.CustomFormat = "";
			this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBirth.Location = new System.Drawing.Point(637, 200);
			this.dateTimePickerBirth.MaxDate = new System.DateTime(9998, 12, 14, 0, 0, 0, 0);
			this.dateTimePickerBirth.Name = "dateTimePickerBirth";
			this.dateTimePickerBirth.Size = new System.Drawing.Size(257, 27);
			this.dateTimePickerBirth.TabIndex = 17;
			// 
			// comboBoxEditGender
			// 
			this.comboBoxEditGender.Location = new System.Drawing.Point(275, 145);
			this.comboBoxEditGender.Name = "comboBoxEditGender";
			this.comboBoxEditGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.comboBoxEditGender.Size = new System.Drawing.Size(201, 26);
			this.comboBoxEditGender.TabIndex = 16;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(720, 142);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(284, 26);
			this.txtAddress.TabIndex = 13;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(720, 97);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(284, 26);
			this.txtPhone.TabIndex = 12;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(720, 54);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(284, 26);
			this.txtMail.TabIndex = 11;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(275, 97);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(284, 26);
			this.txtName.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(592, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Phone:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(592, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Email:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(592, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Address:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(174, 198);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Birth:";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGender.Location = new System.Drawing.Point(174, 145);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(90, 23);
			this.lblGender.TabIndex = 3;
			this.lblGender.Text = "Gender:";
			this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(174, 97);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(76, 23);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(174, 57);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(36, 23);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Controls.Add(this.pictureBoxImage);
			this.groupBox1.Location = new System.Drawing.Point(475, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(257, 352);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(43, 301);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(164, 45);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
			this.pictureBoxImage.Location = new System.Drawing.Point(3, 22);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(251, 272);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxImage.TabIndex = 0;
			this.pictureBoxImage.TabStop = false;
			// 
			// groupBoxAccount
			// 
			this.groupBoxAccount.Controls.Add(this.txtPassword);
			this.groupBoxAccount.Controls.Add(this.label5);
			this.groupBoxAccount.Controls.Add(this.txtUserName);
			this.groupBoxAccount.Controls.Add(this.lblUserName);
			this.groupBoxAccount.Location = new System.Drawing.Point(3, 636);
			this.groupBoxAccount.Name = "groupBoxAccount";
			this.groupBoxAccount.Size = new System.Drawing.Size(1390, 178);
			this.groupBoxAccount.TabIndex = 2;
			this.groupBoxAccount.Text = "Account Information";
			this.groupBoxAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxAccount_Paint);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(204, 118);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(284, 26);
			this.txtPassword.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(48, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Password:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(204, 57);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(284, 26);
			this.txtUserName.TabIndex = 9;
			this.txtUserName.EditValueChanged += new System.EventHandler(this.txtUserName_EditValueChanged);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.Location = new System.Drawing.Point(48, 57);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(117, 23);
			this.lblUserName.TabIndex = 1;
			this.lblUserName.Text = "UserName:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(742, 831);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(129, 56);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(988, 831);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(129, 56);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// myInformationUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBoxAccount);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupControlPersonal);
			this.Name = "myInformationUI";
			this.Size = new System.Drawing.Size(1122, 825);
			this.Load += new System.EventHandler(this.myInformationUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControlPersonal)).EndInit();
			this.groupControlPersonal.ResumeLayout(false);
			this.groupControlPersonal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBirth.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGender.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxAccount)).EndInit();
			this.groupBoxAccount.ResumeLayout(false);
			this.groupBoxAccount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControlPersonal;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraEditors.TextEdit txtAddress;
		private DevExpress.XtraEditors.TextEdit txtPhone;
		private DevExpress.XtraEditors.TextEdit txtMail;
		private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditGender;
		private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private DevExpress.XtraEditors.GroupControl groupBoxAccount;
		private System.Windows.Forms.Label lblUserName;
		private DevExpress.XtraEditors.TextEdit txtUserName;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.TextEdit txtBirth;
	}
}
