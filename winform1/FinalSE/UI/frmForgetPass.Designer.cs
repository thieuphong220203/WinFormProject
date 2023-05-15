namespace FinalSE
{
	partial class frmForgetPass
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPass));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnOTP = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOTP = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(282, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(237, 220);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(162, 292);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "USER NAME:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(282, 292);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(314, 26);
			this.txtUserName.TabIndex = 2;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(480, 418);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(151, 56);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset Password";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnOTP
			// 
			this.btnOTP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOTP.Location = new System.Drawing.Point(282, 418);
			this.btnOTP.Name = "btnOTP";
			this.btnOTP.Size = new System.Drawing.Size(143, 56);
			this.btnOTP.TabIndex = 6;
			this.btnOTP.Text = "get OTP";
			this.btnOTP.UseVisualStyleBackColor = true;
			this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(162, 358);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "OTP:";
			// 
			// txtOTP
			// 
			this.txtOTP.Location = new System.Drawing.Point(282, 358);
			this.txtOTP.Name = "txtOTP";
			this.txtOTP.Size = new System.Drawing.Size(314, 26);
			this.txtOTP.TabIndex = 8;
			// 
			// frmForgetPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(804, 560);
			this.Controls.Add(this.txtOTP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnOTP);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmForgetPass";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MOBILE PRODUCT ACCOUNTANT | FORGET PASSWORD";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnOTP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOTP;
	}
}