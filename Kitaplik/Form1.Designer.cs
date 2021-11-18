
namespace Kitaplik
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(80, 10);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(195, 27);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazarı";
            // 
            // txtYazarAdSoyad
            // 
            this.txtYazarAdSoyad.Location = new System.Drawing.Point(80, 43);
            this.txtYazarAdSoyad.Name = "txtYazarAdSoyad";
            this.txtYazarAdSoyad.Size = new System.Drawing.Size(195, 27);
            this.txtYazarAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Basım";
            // 
            // txtBasim
            // 
            this.txtBasim.Location = new System.Drawing.Point(80, 76);
            this.txtBasim.Name = "txtBasim";
            this.txtBasim.Size = new System.Drawing.Size(195, 27);
            this.txtBasim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yılı";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(80, 109);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(195, 27);
            this.txtYil.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(151, 142);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(124, 78);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.ContextMenuStrip = this.cmsSil;
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 20;
            this.lstKitaplar.Location = new System.Drawing.Point(282, 10);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(294, 424);
            this.lstKitaplar.TabIndex = 3;
            this.lstKitaplar.SelectedIndexChanged += new System.EventHandler(this.lstKitaplar_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(13, 142);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 78);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmsSil
            // 
            this.cmsSil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.bilgiToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(211, 80);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBasim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYazarAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsSil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazarAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBasim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip cmsSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
    }
}
