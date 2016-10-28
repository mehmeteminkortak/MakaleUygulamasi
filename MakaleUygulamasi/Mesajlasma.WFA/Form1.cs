using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mesajlasma.BLL;
using Mesajlasma.Models;

namespace Mesajlasma.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Kisi Kullanici { get; set; }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var girisYapanKullanici = new KisiRepo().LoginControl(txtKullaniciAdi.Text, txtSifre.Text);
            if (girisYapanKullanici == null)
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!", "Login Hatası", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                Kullanici = girisYapanKullanici;
                MessageBox.Show($"Hoşgeldin: {Kullanici.KullaniciAdi}");
                FormMakaleler makaleForm = new FormMakaleler();
                makaleForm.Text += $": {Kullanici.KullaniciAdi}";
                makaleForm.Kullanici = this.Kullanici;
                makaleForm.Show();
                this.Hide();
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            FormYeniKullanici yeniKullanici = new FormYeniKullanici();
            yeniKullanici.ShowDialog();
        }
    }
}
