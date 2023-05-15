namespace FinalSE
{
	partial class DXAccountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXAccountant));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCreateRECEIPT = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCheckInvoince = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSupplier = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlTypeProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSystem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlInformation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblAccount = new System.Windows.Forms.ToolStripLabel();
            this.mainFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.mainFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlMenu,
            this.accordionControlSystem});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(277, 721);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlMenu
            // 
            this.accordionControlMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlCreateRECEIPT,
            this.accordionControlCheckInvoince,
            this.accordionControlSupplier,
            this.accordionControlTypeProducts,
            this.accordionControlCustomer,
            this.accordionControlProduct});
            this.accordionControlMenu.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlMenu.Name = "accordionControlMenu";
            this.accordionControlMenu.Text = "MENU";
            // 
            // accordionControlCreateRECEIPT
            // 
            this.accordionControlCreateRECEIPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCreateRECEIPT.ImageOptions.Image")));
            this.accordionControlCreateRECEIPT.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlCreateRECEIPT.Name = "accordionControlCreateRECEIPT";
            this.accordionControlCreateRECEIPT.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCreateRECEIPT.Text = "Add Receipt";
            this.accordionControlCreateRECEIPT.Click += new System.EventHandler(this.accordionControlCreateRECEIPT_Click);
            // 
            // accordionControlCheckInvoince
            // 
            this.accordionControlCheckInvoince.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCheckInvoince.ImageOptions.Image")));
            this.accordionControlCheckInvoince.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlCheckInvoince.Name = "accordionControlCheckInvoince";
            this.accordionControlCheckInvoince.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCheckInvoince.Text = "Delivery Goods";
            this.accordionControlCheckInvoince.Click += new System.EventHandler(this.accordionControlCheckInvoince_Click);
            // 
            // accordionControlSupplier
            // 
            this.accordionControlSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSupplier.ImageOptions.Image")));
            this.accordionControlSupplier.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlSupplier.Name = "accordionControlSupplier";
            this.accordionControlSupplier.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSupplier.Text = "Review Supplier";
            this.accordionControlSupplier.Click += new System.EventHandler(this.accordionControlSupplier_Click);
            // 
            // accordionControlTypeProducts
            // 
            this.accordionControlTypeProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlTypeProducts.ImageOptions.Image")));
            this.accordionControlTypeProducts.Name = "accordionControlTypeProducts";
            this.accordionControlTypeProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlTypeProducts.Text = "Review Type Product";
            this.accordionControlTypeProducts.Click += new System.EventHandler(this.accordionControlTypeProducts_Click);
            // 
            // accordionControlCustomer
            // 
            this.accordionControlCustomer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlCustomer.ImageOptions.SvgImage")));
            this.accordionControlCustomer.Name = "accordionControlCustomer";
            this.accordionControlCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomer.Text = "Customer List";
            this.accordionControlCustomer.Click += new System.EventHandler(this.accordionControlCustomer_Click);
            // 
            // accordionControlProduct
            // 
            this.accordionControlProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlProduct.ImageOptions.SvgImage")));
            this.accordionControlProduct.Name = "accordionControlProduct";
            this.accordionControlProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlProduct.Text = "Product";
            this.accordionControlProduct.Click += new System.EventHandler(this.accordionControlProduct_Click);
            // 
            // accordionControlSystem
            // 
            this.accordionControlSystem.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlInformation,
            this.accordionControlLogOut,
            this.accordionControlExit});
            this.accordionControlSystem.Name = "accordionControlSystem";
            this.accordionControlSystem.Text = "SYSTEM";
            // 
            // accordionControlInformation
            // 
            this.accordionControlInformation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlInformation.ImageOptions.Image")));
            this.accordionControlInformation.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlInformation.Name = "accordionControlInformation";
            this.accordionControlInformation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlInformation.Text = "My Information";
            this.accordionControlInformation.Click += new System.EventHandler(this.accordionControlInformation_Click);
            // 
            // accordionControlLogOut
            // 
            this.accordionControlLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlLogOut.ImageOptions.Image")));
            this.accordionControlLogOut.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlLogOut.Name = "accordionControlLogOut";
            this.accordionControlLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlLogOut.Text = "Log Out";
            this.accordionControlLogOut.Click += new System.EventHandler(this.accordionControlLogOut_Click);
            // 
            // accordionControlExit
            // 
            this.accordionControlExit.Name = "accordionControlExit";
            this.accordionControlExit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlExit.Text = "Exit";
            this.accordionControlExit.Click += new System.EventHandler(this.accordionControlExit_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(919, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.lblAccount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.toolStrip1.Size = new System.Drawing.Size(642, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(86, 28);
            this.lblAccount.Text = "toolStripLabel1";
            // 
            // mainFormContainer
            // 
            this.mainFormContainer.Controls.Add(this.toolStrip1);
            this.mainFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormContainer.Location = new System.Drawing.Point(277, 31);
            this.mainFormContainer.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.mainFormContainer.Name = "mainFormContainer";
            this.mainFormContainer.Size = new System.Drawing.Size(642, 721);
            this.mainFormContainer.TabIndex = 0;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Element1";
            // 
            // DXAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 752);
            this.ControlBox = false;
            this.ControlContainer = this.mainFormContainer;
            this.Controls.Add(this.mainFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DXAccountant";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DXAccoutant";
            this.Load += new System.EventHandler(this.DXAccountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainFormContainer.ResumeLayout(false);
            this.mainFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlMenu;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCreateRECEIPT;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSystem;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCheckInvoince;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlInformation;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainFormContainer;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlLogOut;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSupplier;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripLabel lblAccount;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlExit;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlTypeProducts;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomer;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlProduct;
	}
}