namespace Mesajlasma.WFA
{
    partial class FormMakaleler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMakaleSayisi = new System.Windows.Forms.Label();
            this.lblBenimMakaleSayim = new System.Windows.Forms.Label();
            this.lblKayitliYazarlar = new System.Windows.Forms.Label();
            this.lblYazarYasi = new System.Windows.Forms.Label();
            this.lblDogumGunuOlanYazarlar = new System.Windows.Forms.Label();
            this.txtMakaleAra = new System.Windows.Forms.TextBox();
            this.lstMakaleler = new System.Windows.Forms.ListBox();
            this.txtMakale = new System.Windows.Forms.RichTextBox();
            this.lblMakaleDetay = new System.Windows.Forms.Label();
            this.btnMakaleYaz = new System.Windows.Forms.Button();
            this.btnProfilim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDogumGunuOlanYazarlar);
            this.groupBox1.Controls.Add(this.lblYazarYasi);
            this.groupBox1.Controls.Add(this.lblKayitliYazarlar);
            this.groupBox1.Controls.Add(this.lblBenimMakaleSayim);
            this.groupBox1.Controls.Add(this.lblMakaleSayisi);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatistikler";
            // 
            // lblMakaleSayisi
            // 
            this.lblMakaleSayisi.AutoSize = true;
            this.lblMakaleSayisi.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakaleSayisi.Location = new System.Drawing.Point(6, 16);
            this.lblMakaleSayisi.Name = "lblMakaleSayisi";
            this.lblMakaleSayisi.Size = new System.Drawing.Size(35, 14);
            this.lblMakaleSayisi.TabIndex = 0;
            this.lblMakaleSayisi.Text = "label1";
            // 
            // lblBenimMakaleSayim
            // 
            this.lblBenimMakaleSayim.AutoSize = true;
            this.lblBenimMakaleSayim.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBenimMakaleSayim.Location = new System.Drawing.Point(6, 52);
            this.lblBenimMakaleSayim.Name = "lblBenimMakaleSayim";
            this.lblBenimMakaleSayim.Size = new System.Drawing.Size(35, 14);
            this.lblBenimMakaleSayim.TabIndex = 0;
            this.lblBenimMakaleSayim.Text = "label1";
            // 
            // lblKayitliYazarlar
            // 
            this.lblKayitliYazarlar.AutoSize = true;
            this.lblKayitliYazarlar.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitliYazarlar.Location = new System.Drawing.Point(6, 88);
            this.lblKayitliYazarlar.Name = "lblKayitliYazarlar";
            this.lblKayitliYazarlar.Size = new System.Drawing.Size(35, 14);
            this.lblKayitliYazarlar.TabIndex = 0;
            this.lblKayitliYazarlar.Text = "label1";
            // 
            // lblYazarYasi
            // 
            this.lblYazarYasi.AutoSize = true;
            this.lblYazarYasi.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarYasi.Location = new System.Drawing.Point(6, 124);
            this.lblYazarYasi.Name = "lblYazarYasi";
            this.lblYazarYasi.Size = new System.Drawing.Size(35, 14);
            this.lblYazarYasi.TabIndex = 0;
            this.lblYazarYasi.Text = "label1";
            // 
            // lblDogumGunuOlanYazarlar
            // 
            this.lblDogumGunuOlanYazarlar.AutoSize = true;
            this.lblDogumGunuOlanYazarlar.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumGunuOlanYazarlar.Location = new System.Drawing.Point(6, 160);
            this.lblDogumGunuOlanYazarlar.Name = "lblDogumGunuOlanYazarlar";
            this.lblDogumGunuOlanYazarlar.Size = new System.Drawing.Size(35, 14);
            this.lblDogumGunuOlanYazarlar.TabIndex = 0;
            this.lblDogumGunuOlanYazarlar.Text = "label1";
            // 
            // txtMakaleAra
            // 
            this.txtMakaleAra.Location = new System.Drawing.Point(224, 13);
            this.txtMakaleAra.Name = "txtMakaleAra";
            this.txtMakaleAra.Size = new System.Drawing.Size(287, 20);
            this.txtMakaleAra.TabIndex = 1;
            this.txtMakaleAra.TextChanged += new System.EventHandler(this.txtMakaleAra_TextChanged);
            // 
            // lstMakaleler
            // 
            this.lstMakaleler.FormattingEnabled = true;
            this.lstMakaleler.Location = new System.Drawing.Point(224, 39);
            this.lstMakaleler.Name = "lstMakaleler";
            this.lstMakaleler.Size = new System.Drawing.Size(287, 186);
            this.lstMakaleler.TabIndex = 2;
            this.lstMakaleler.SelectedIndexChanged += new System.EventHandler(this.lstMakaleler_SelectedIndexChanged);
            // 
            // txtMakale
            // 
            this.txtMakale.Location = new System.Drawing.Point(540, 39);
            this.txtMakale.Name = "txtMakale";
            this.txtMakale.ReadOnly = true;
            this.txtMakale.Size = new System.Drawing.Size(345, 186);
            this.txtMakale.TabIndex = 3;
            this.txtMakale.Text = "";
            // 
            // lblMakaleDetay
            // 
            this.lblMakaleDetay.AutoSize = true;
            this.lblMakaleDetay.Location = new System.Drawing.Point(540, 13);
            this.lblMakaleDetay.Name = "lblMakaleDetay";
            this.lblMakaleDetay.Size = new System.Drawing.Size(35, 13);
            this.lblMakaleDetay.TabIndex = 4;
            this.lblMakaleDetay.Text = "label1";
            // 
            // btnMakaleYaz
            // 
            this.btnMakaleYaz.Location = new System.Drawing.Point(12, 7);
            this.btnMakaleYaz.Name = "btnMakaleYaz";
            this.btnMakaleYaz.Size = new System.Drawing.Size(84, 23);
            this.btnMakaleYaz.TabIndex = 5;
            this.btnMakaleYaz.Text = "Makale Yaz";
            this.btnMakaleYaz.UseVisualStyleBackColor = true;
            this.btnMakaleYaz.Click += new System.EventHandler(this.btnMakaleYaz_Click);
            // 
            // btnProfilim
            // 
            this.btnProfilim.Location = new System.Drawing.Point(102, 8);
            this.btnProfilim.Name = "btnProfilim";
            this.btnProfilim.Size = new System.Drawing.Size(109, 23);
            this.btnProfilim.TabIndex = 6;
            this.btnProfilim.Text = "Profilim";
            this.btnProfilim.UseVisualStyleBackColor = true;
            this.btnProfilim.Click += new System.EventHandler(this.btnProfilim_Click);
            // 
            // FormMakaleler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 244);
            this.Controls.Add(this.btnProfilim);
            this.Controls.Add(this.btnMakaleYaz);
            this.Controls.Add(this.lblMakaleDetay);
            this.Controls.Add(this.txtMakale);
            this.Controls.Add(this.lstMakaleler);
            this.Controls.Add(this.txtMakaleAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMakaleler";
            this.Text = "FormMakaleler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMakaleler_FormClosed);
            this.Load += new System.EventHandler(this.FormMakaleler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDogumGunuOlanYazarlar;
        private System.Windows.Forms.Label lblYazarYasi;
        private System.Windows.Forms.Label lblKayitliYazarlar;
        private System.Windows.Forms.Label lblBenimMakaleSayim;
        private System.Windows.Forms.Label lblMakaleSayisi;
        private System.Windows.Forms.TextBox txtMakaleAra;
        private System.Windows.Forms.ListBox lstMakaleler;
        private System.Windows.Forms.RichTextBox txtMakale;
        private System.Windows.Forms.Label lblMakaleDetay;
        private System.Windows.Forms.Button btnMakaleYaz;
        private System.Windows.Forms.Button btnProfilim;
    }
}