namespace QuanLyMaverikStudio.GUI
{
    partial class SellProducts
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
            this.lbNameProduct = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.pnQuantityWantSell = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtQuantityWantSell = new System.Windows.Forms.TextBox();
            this.lbQuantityWantSell = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.pnQuantityWantSell.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNameProduct
            // 
            this.lbNameProduct.AutoSize = true;
            this.lbNameProduct.Location = new System.Drawing.Point(13, 13);
            this.lbNameProduct.Name = "lbNameProduct";
            this.lbNameProduct.Size = new System.Drawing.Size(94, 19);
            this.lbNameProduct.TabIndex = 0;
            this.lbNameProduct.Text = "Tên sản phẩm";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Enabled = false;
            this.txtNameProduct.Location = new System.Drawing.Point(17, 36);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(214, 25);
            this.txtNameProduct.TabIndex = 2;
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(251, 36);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(72, 25);
            this.txtSize.TabIndex = 3;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(247, 13);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(32, 19);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Size";
            // 
            // pnQuantityWantSell
            // 
            this.pnQuantityWantSell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnQuantityWantSell.Controls.Add(this.btnSell);
            this.pnQuantityWantSell.Controls.Add(this.txtQuantityWantSell);
            this.pnQuantityWantSell.Location = new System.Drawing.Point(17, 98);
            this.pnQuantityWantSell.Name = "pnQuantityWantSell";
            this.pnQuantityWantSell.Size = new System.Drawing.Size(396, 81);
            this.pnQuantityWantSell.TabIndex = 4;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnSell.Location = new System.Drawing.Point(155, 44);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(86, 29);
            this.btnSell.TabIndex = 5;
            this.btnSell.Text = "Đồng ý";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // txtQuantityWantSell
            // 
            this.txtQuantityWantSell.Location = new System.Drawing.Point(13, 13);
            this.txtQuantityWantSell.Name = "txtQuantityWantSell";
            this.txtQuantityWantSell.Size = new System.Drawing.Size(369, 25);
            this.txtQuantityWantSell.TabIndex = 1;
            // 
            // lbQuantityWantSell
            // 
            this.lbQuantityWantSell.AutoSize = true;
            this.lbQuantityWantSell.Location = new System.Drawing.Point(13, 76);
            this.lbQuantityWantSell.Name = "lbQuantityWantSell";
            this.lbQuantityWantSell.Size = new System.Drawing.Size(130, 19);
            this.lbQuantityWantSell.TabIndex = 5;
            this.lbQuantityWantSell.Text = "Số lượng muốn bán";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(341, 36);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(72, 25);
            this.txtQuantity.TabIndex = 4;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(337, 13);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(63, 19);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Số lượng";
            // 
            // SellProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(431, 196);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbQuantityWantSell);
            this.Controls.Add(this.pnQuantityWantSell);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.lbNameProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaximizeBox = false;
            this.Name = "SellProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập số lượng sản phẩm cần bán";
            this.pnQuantityWantSell.ResumeLayout(false);
            this.pnQuantityWantSell.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Panel pnQuantityWantSell;
        private System.Windows.Forms.Label lbQuantityWantSell;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtQuantityWantSell;
    }
}