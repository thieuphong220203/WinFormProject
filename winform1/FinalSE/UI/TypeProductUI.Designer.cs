namespace FinalSE.UI
{
	partial class TypeProductUI
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeProductUI));
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barButtonAdd = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.bar4 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.gcList = new DevExpress.XtraGrid.GridControl();
			this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			this.SuspendLayout();
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonAdd,
            this.barButtonItem3,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem5});
			this.barManager1.MainMenu = this.bar3;
			this.barManager1.MaxItemId = 6;
			this.barManager1.StatusBar = this.bar4;
			// 
			// bar3
			// 
			this.bar3.BarName = "Main menu";
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar3.OptionsBar.MultiLine = true;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Main menu";
			// 
			// barButtonAdd
			// 
			this.barButtonAdd.Caption = "Add";
			this.barButtonAdd.Id = 1;
			this.barButtonAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonAdd.ImageOptions.Image")));
			this.barButtonAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonAdd.ImageOptions.LargeImage")));
			this.barButtonAdd.Name = "barButtonAdd";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Edit";
			this.barButtonItem2.Id = 3;
			this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonItem4
			// 
			this.barButtonItem4.Caption = "Delete";
			this.barButtonItem4.Id = 4;
			this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
			this.barButtonItem4.Name = "barButtonItem4";
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "Exit";
			this.barButtonItem5.Id = 5;
			this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// bar4
			// 
			this.bar4.BarName = "Status bar";
			this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar4.DockCol = 0;
			this.bar4.DockRow = 0;
			this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar4.OptionsBar.AllowQuickCustomization = false;
			this.bar4.OptionsBar.DrawDragBorder = false;
			this.bar4.OptionsBar.UseWholeRow = true;
			this.bar4.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(1047, 34);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 558);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1047, 20);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1047, 34);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "barButtonItem1";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "Add";
			this.barButtonItem3.Id = 2;
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// gcList
			// 
			this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcList.Location = new System.Drawing.Point(0, 34);
			this.gcList.MainView = this.gvList;
			this.gcList.MenuManager = this.barManager1;
			this.gcList.Name = "gcList";
			this.gcList.Size = new System.Drawing.Size(1047, 524);
			this.gcList.TabIndex = 4;
			this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
			this.gcList.Click += new System.EventHandler(this.gcList_Click);
			// 
			// gvList
			// 
			this.gvList.GridControl = this.gcList;
			this.gvList.Name = "gvList";
			this.gvList.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
			// 
			// TypeProductUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gcList);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "TypeProductUI";
			this.Size = new System.Drawing.Size(1047, 578);
			this.Load += new System.EventHandler(this.TypeProductUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarButtonItem barButtonAdd;
		private DevExpress.XtraBars.Bar bar4;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraGrid.GridControl gcList;
		private DevExpress.XtraGrid.Views.Grid.GridView gvList;
	}
}
