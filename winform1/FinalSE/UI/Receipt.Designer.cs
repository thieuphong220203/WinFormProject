namespace FinalSE.UI
{
	partial class Receipt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.txtAccountantName = new System.Windows.Forms.TextBox();
            this.txtAccountantID = new System.Windows.Forms.TextBox();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TableOfProduct = new System.Windows.Forms.Button();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.cbxProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 49);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 5;
            this.btnCancel.Location = new System.Drawing.Point(471, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageIndex = 6;
            this.btnBack.Location = new System.Drawing.Point(591, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 27);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageKey = "diskette.png";
            this.btnSave.Location = new System.Drawing.Point(357, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.Location = new System.Drawing.Point(250, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 27);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.ImageIndex = 3;
            this.btnRemove.Location = new System.Drawing.Point(145, 11);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 27);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.ImageIndex = 2;
            this.btnCreate.Location = new System.Drawing.Point(35, 11);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(72, 27);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(921, 443);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDriverName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBoxSupplierName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtSupplierID);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.dateCreated);
            this.groupBox1.Controls.Add(this.txtAccountantName);
            this.groupBox1.Controls.Add(this.txtAccountantID);
            this.groupBox1.Controls.Add(this.txtReceiptID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(921, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(675, 13);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(183, 21);
            this.txtDriverName.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(632, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Driver:";
            // 
            // comboBoxSupplierName
            // 
            this.comboBoxSupplierName.FormattingEnabled = true;
            this.comboBoxSupplierName.Location = new System.Drawing.Point(436, 13);
            this.comboBoxSupplierName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSupplierName.Name = "comboBoxSupplierName";
            this.comboBoxSupplierName.Size = new System.Drawing.Size(185, 23);
            this.comboBoxSupplierName.TabIndex = 15;
            this.comboBoxSupplierName.SelectedValueChanged += new System.EventHandler(this.comboBoxSupplierName_SelectedValueChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(436, 90);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 21);
            this.txtPhone.TabIndex = 14;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(436, 40);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(185, 21);
            this.txtSupplierID.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(436, 67);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 21);
            this.txtAddress.TabIndex = 12;
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(131, 42);
            this.dateCreated.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(185, 21);
            this.dateCreated.TabIndex = 11;
            // 
            // txtAccountantName
            // 
            this.txtAccountantName.Location = new System.Drawing.Point(131, 90);
            this.txtAccountantName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccountantName.Name = "txtAccountantName";
            this.txtAccountantName.Size = new System.Drawing.Size(185, 21);
            this.txtAccountantName.TabIndex = 10;
            // 
            // txtAccountantID
            // 
            this.txtAccountantID.Location = new System.Drawing.Point(131, 66);
            this.txtAccountantID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccountantID.Name = "txtAccountantID";
            this.txtAccountantID.Size = new System.Drawing.Size(185, 21);
            this.txtAccountantID.TabIndex = 9;
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.Location = new System.Drawing.Point(131, 16);
            this.txtReceiptID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.Size = new System.Drawing.Size(185, 21);
            this.txtReceiptID.TabIndex = 8;
            this.txtReceiptID.TextChanged += new System.EventHandler(this.txtReceiptID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Supplier ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Supplier Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Accountant Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Accountant ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Created:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Receipt ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(323, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECEIPT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchInvoice);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TableOfProduct);
            this.groupBox2.Controls.Add(this.dataGridViewInput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(921, 271);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receipt";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(451, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(302, 35);
            this.label13.TabIndex = 23;
            this.label13.Text = "If you don\'t know the product information, please click to the button Table of Pr" +
    "oduct for more detail";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(231, 57);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 23);
            this.comboBox2.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Search Receipt:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Search Invoice:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(599, 16);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 30);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(9, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Enter data below";
            // 
            // TableOfProduct
            // 
            this.TableOfProduct.Location = new System.Drawing.Point(453, 16);
            this.TableOfProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TableOfProduct.Name = "TableOfProduct";
            this.TableOfProduct.Size = new System.Drawing.Size(118, 30);
            this.TableOfProduct.TabIndex = 14;
            this.TableOfProduct.Text = "Table Of Product";
            this.TableOfProduct.UseVisualStyleBackColor = true;
            this.TableOfProduct.Click += new System.EventHandler(this.TableOfProduct_Click);
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbxProductName,
            this.Quantities,
            this.txtPrice,
            this.Driver_Name});
            this.dataGridViewInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewInput.Location = new System.Drawing.Point(2, 95);
            this.dataGridViewInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowHeadersWidth = 62;
            this.dataGridViewInput.RowTemplate.Height = 28;
            this.dataGridViewInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInput.Size = new System.Drawing.Size(917, 174);
            this.dataGridViewInput.TabIndex = 13;
            this.dataGridViewInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_CellClick);
            this.dataGridViewInput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_CellContentClick);
            this.dataGridViewInput.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_CellEndEdit);
            this.dataGridViewInput.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_CellValueChanged);
            this.dataGridViewInput.Click += new System.EventHandler(this.dataGridViewInput_Click);
            // 
            // cbxProductName
            // 
            this.cbxProductName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbxProductName.HeaderText = "Product Name";
            this.cbxProductName.MinimumWidth = 8;
            this.cbxProductName.Name = "cbxProductName";
            this.cbxProductName.Width = 300;
            // 
            // Quantities
            // 
            this.Quantities.HeaderText = "Quantities";
            this.Quantities.MinimumWidth = 8;
            this.Quantities.Name = "Quantities";
            this.Quantities.Width = 150;
            // 
            // txtPrice
            // 
            this.txtPrice.HeaderText = "Price";
            this.txtPrice.MinimumWidth = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Width = 150;
            // 
            // Driver_Name
            // 
            this.Driver_Name.HeaderText = "Driver Name";
            this.Driver_Name.MinimumWidth = 8;
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.Width = 150;
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Location = new System.Drawing.Point(280, 18);
            this.btnSearchInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(118, 30);
            this.btnSearchInvoice.TabIndex = 24;
            this.btnSearchInvoice.Text = "Search Invoice";
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(921, 492);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtReceiptID;
		private System.Windows.Forms.TextBox txtAccountantName;
		private System.Windows.Forms.TextBox txtAccountantID;
		private System.Windows.Forms.DateTimePicker dateCreated;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtSupplierID;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.ComboBox comboBoxSupplierName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewInput;
		private System.Windows.Forms.Button TableOfProduct;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridViewComboBoxColumn cbxProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantities;
		private System.Windows.Forms.DataGridViewTextBoxColumn txtPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Driver_Name;
		private System.Windows.Forms.TextBox txtDriverName;
		private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearchInvoice;
    }
}