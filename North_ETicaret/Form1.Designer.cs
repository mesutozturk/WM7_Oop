namespace North_ETicaret
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.lstOrderDetails = new System.Windows.Forms.ListBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnProductInsert = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.txtCategoryAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUrunFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 20;
            this.lstCategory.Location = new System.Drawing.Point(12, 75);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(310, 284);
            this.lstCategory.TabIndex = 0;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 20;
            this.lstProduct.Location = new System.Drawing.Point(328, 75);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(310, 284);
            this.lstProduct.TabIndex = 1;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // lstOrderDetails
            // 
            this.lstOrderDetails.FormattingEnabled = true;
            this.lstOrderDetails.ItemHeight = 20;
            this.lstOrderDetails.Location = new System.Drawing.Point(644, 75);
            this.lstOrderDetails.Name = "lstOrderDetails";
            this.lstOrderDetails.Size = new System.Drawing.Size(310, 284);
            this.lstOrderDetails.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 365);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(154, 27);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // nUrunFiyati
            // 
            this.nUrunFiyati.DecimalPlaces = 2;
            this.nUrunFiyati.Location = new System.Drawing.Point(172, 366);
            this.nUrunFiyati.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUrunFiyati.Name = "nUrunFiyati";
            this.nUrunFiyati.Size = new System.Drawing.Size(150, 27);
            this.nUrunFiyati.TabIndex = 4;
            this.nUrunFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProductInsert
            // 
            this.btnProductInsert.Location = new System.Drawing.Point(12, 398);
            this.btnProductInsert.Name = "btnProductInsert";
            this.btnProductInsert.Size = new System.Drawing.Size(154, 60);
            this.btnProductInsert.TabIndex = 5;
            this.btnProductInsert.Text = "Ürün Kayıt";
            this.btnProductInsert.UseVisualStyleBackColor = true;
            this.btnProductInsert.Click += new System.EventHandler(this.btnProductInsert_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(172, 399);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(150, 59);
            this.btnProductUpdate.TabIndex = 6;
            this.btnProductUpdate.Text = "Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // txtCategoryAra
            // 
            this.txtCategoryAra.Location = new System.Drawing.Point(12, 42);
            this.txtCategoryAra.Name = "txtCategoryAra";
            this.txtCategoryAra.Size = new System.Drawing.Size(310, 27);
            this.txtCategoryAra.TabIndex = 7;
            this.txtCategoryAra.TextChanged += new System.EventHandler(this.txtCategoryAra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 673);
            this.Controls.Add(this.txtCategoryAra);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductInsert);
            this.Controls.Add(this.nUrunFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lstOrderDetails);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.lstCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUrunFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.ListBox lstOrderDetails;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nUrunFiyati;
        private System.Windows.Forms.Button btnProductInsert;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox txtCategoryAra;
    }
}
