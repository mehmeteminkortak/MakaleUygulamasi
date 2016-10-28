namespace Mesajlasma.WFA
{
    partial class FromProfilim
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
            this.lblMakaleDetay = new System.Windows.Forms.Label();
            this.txtMakale = new System.Windows.Forms.RichTextBox();
            this.lstMakaleler = new System.Windows.Forms.ListBox();
            this.txtMakaleAra = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMakaleDetay
            // 
            this.lblMakaleDetay.AutoSize = true;
            this.lblMakaleDetay.Location = new System.Drawing.Point(328, 12);
            this.lblMakaleDetay.Name = "lblMakaleDetay";
            this.lblMakaleDetay.Size = new System.Drawing.Size(35, 13);
            this.lblMakaleDetay.TabIndex = 8;
            this.lblMakaleDetay.Text = "label1";
            // 
            // txtMakale
            // 
            this.txtMakale.Location = new System.Drawing.Point(328, 64);
            this.txtMakale.Name = "txtMakale";
            this.txtMakale.Size = new System.Drawing.Size(345, 160);
            this.txtMakale.TabIndex = 7;
            this.txtMakale.Text = "";
            // 
            // lstMakaleler
            // 
            this.lstMakaleler.FormattingEnabled = true;
            this.lstMakaleler.Location = new System.Drawing.Point(12, 38);
            this.lstMakaleler.Name = "lstMakaleler";
            this.lstMakaleler.Size = new System.Drawing.Size(287, 186);
            this.lstMakaleler.TabIndex = 6;
            this.lstMakaleler.SelectedIndexChanged += new System.EventHandler(this.lstMakaleler_SelectedIndexChanged);
            // 
            // txtMakaleAra
            // 
            this.txtMakaleAra.Location = new System.Drawing.Point(12, 12);
            this.txtMakaleAra.Name = "txtMakaleAra";
            this.txtMakaleAra.Size = new System.Drawing.Size(287, 20);
            this.txtMakaleAra.TabIndex = 5;
            this.txtMakaleAra.TextChanged += new System.EventHandler(this.txtMakaleAra_TextChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(598, 7);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(328, 38);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(345, 20);
            this.txtBaslik.TabIndex = 10;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(328, 230);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FromProfilim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 261);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblMakaleDetay);
            this.Controls.Add(this.txtMakale);
            this.Controls.Add(this.lstMakaleler);
            this.Controls.Add(this.txtMakaleAra);
            this.Name = "FromProfilim";
            this.Text = "FromProfilim";
            this.Load += new System.EventHandler(this.FromProfilim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakaleDetay;
        private System.Windows.Forms.RichTextBox txtMakale;
        private System.Windows.Forms.ListBox lstMakaleler;
        private System.Windows.Forms.TextBox txtMakaleAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Button btnSil;
    }
}