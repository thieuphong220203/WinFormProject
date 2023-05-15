namespace FinalSE.UI
{
	partial class frmDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtGoodDeliver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbxInvoiceID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 49);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageIndex = 6;
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(552, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 27);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 5;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(452, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageKey = "diskette.png";
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(352, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(252, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 27);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.ImageIndex = 3;
            this.btnRemove.ImageList = this.imageList1;
            this.btnRemove.Location = new System.Drawing.Point(152, 11);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 27);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(52, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 334);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(902, 41);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtGoodDeliver);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.btnCreate);
            this.panelControl2.Controls.Add(this.printbtn);
            this.panelControl2.Controls.Add(this.btnPrint);
            this.panelControl2.Controls.Add(this.cbxInvoiceID);
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Controls.Add(this.txtCustomerID);
            this.panelControl2.Controls.Add(this.txtAccountID);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.lblID);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(902, 169);
            this.panelControl2.TabIndex = 4;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // txtGoodDeliver
            // 
            this.txtGoodDeliver.Location = new System.Drawing.Point(166, 35);
            this.txtGoodDeliver.Name = "txtGoodDeliver";
            this.txtGoodDeliver.Size = new System.Drawing.Size(210, 21);
            this.txtGoodDeliver.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(42, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Goods Delivery ID:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(744, 115);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 31);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // printbtn
            // 
            this.printbtn.Location = new System.Drawing.Point(625, 115);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(94, 31);
            this.printbtn.TabIndex = 15;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.print_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(972, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 37);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cbxInvoiceID
            // 
            this.cbxInvoiceID.FormattingEnabled = true;
            this.cbxInvoiceID.Location = new System.Drawing.Point(166, 62);
            this.cbxInvoiceID.Name = "cbxInvoiceID";
            this.cbxInvoiceID.Size = new System.Drawing.Size(210, 21);
            this.cbxInvoiceID.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(516, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 31);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(595, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 21);
            this.txtName.TabIndex = 11;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(589, 24);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(258, 21);
            this.txtCustomerID.TabIndex = 10;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(166, 95);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(210, 21);
            this.txtAccountID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(39, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Accountant ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(483, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(491, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(42, 64);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(0, 169);
            this.dataGridViewInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 62;
            this.dataGridViewInvoice.RowTemplate.Height = 28;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(902, 165);
            this.dataGridViewInvoice.TabIndex = 5;
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 424);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDelivery";
            this.Text = "Delivery Goods";
            this.Load += new System.EventHandler(this.frmSearchInvoice_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ImageList imageList1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.DataGridView dataGridViewInvoice;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.TextBox txtAccountID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cbxInvoiceID;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button printbtn;
		public DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtGoodDeliver;
        private System.Windows.Forms.Label label2;
    }
}