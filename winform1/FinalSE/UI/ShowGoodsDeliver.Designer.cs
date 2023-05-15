namespace FinalSE.UI
{
	partial class ShowGoodsDeliver
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
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShow.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowHeadersWidth = 62;
            this.dataGridViewShow.RowTemplate.Height = 28;
            this.dataGridViewShow.Size = new System.Drawing.Size(542, 292);
            this.dataGridViewShow.TabIndex = 0;
            // 
            // ShowGoodsDeliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.dataGridViewShow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowGoodsDeliver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Good Delivery";
            this.Load += new System.EventHandler(this.ReceiptShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewShow;
	}
}