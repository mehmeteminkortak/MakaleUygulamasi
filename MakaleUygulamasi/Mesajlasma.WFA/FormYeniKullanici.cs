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
    public partial class FormYeniKullanici : Form
    {
        public FormYeniKullanici()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                new KisiRepo().Insert(new Kisi()
                {
                    DogumTarihi = dtpDogumTarihi.Value,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text
                });
                MessageBox.Show("Kayıt işlemi başarılı. Lütfen giriş yapınız.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işleminde hata oluştu tekrar deneyiniz!\n" + ex.Message);
            }
        }
    }
}
