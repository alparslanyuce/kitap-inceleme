namespace ComboBox_İnceleme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrunListe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Urunadi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.Kategori = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.stok = new System.Windows.Forms.Label();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.txtUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Listesi";
            // 
            // cmbUrunListe
            // 
            this.cmbUrunListe.FormattingEnabled = true;
            this.cmbUrunListe.Location = new System.Drawing.Point(95, 9);
            this.cmbUrunListe.Name = "cmbUrunListe";
            this.cmbUrunListe.Size = new System.Drawing.Size(312, 21);
            this.cmbUrunListe.TabIndex = 1;
            this.cmbUrunListe.SelectedIndexChanged += new System.EventHandler(this.cmbUrunListe_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrunAciklama);
            this.groupBox1.Controls.Add(this.txtStokAdet);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.stok);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.Yazar);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.Kategori);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Urunadi);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Ürün Detay Bilgisi";
            // 
            // Urunadi
            // 
            this.Urunadi.AutoSize = true;
            this.Urunadi.Location = new System.Drawing.Point(93, 19);
            this.Urunadi.Name = "Urunadi";
            this.Urunadi.Size = new System.Drawing.Size(48, 13);
            this.Urunadi.TabIndex = 0;
            this.Urunadi.Text = "Ürün Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 85);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(158, 19);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(234, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Location = new System.Drawing.Point(93, 45);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(46, 13);
            this.Kategori.TabIndex = 0;
            this.Kategori.Text = "Kategori";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(158, 45);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(234, 20);
            this.txtKategori.TabIndex = 2;
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(93, 97);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(34, 13);
            this.Yazar.TabIndex = 0;
            this.Yazar.Text = "Yazar";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(158, 97);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(234, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(93, 71);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(54, 13);
            this.stok.TabIndex = 0;
            this.stok.Text = "Stok Adet";
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(158, 71);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(234, 20);
            this.txtStokAdet.TabIndex = 2;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(6, 132);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(386, 96);
            this.txtUrunAciklama.TabIndex = 3;
            this.txtUrunAciklama.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUrunListe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrunListe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtUrunAciklama;
        private System.Windows.Forms.TextBox txtStokAdet;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Urunadi;
    }
}

