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
    public partial class FormMakaleler : Form
    {
        public FormMakaleler()
        {
            InitializeComponent();
        }
        public Kisi Kullanici { get; set; }

        private void FormMakaleler_Load(object sender, EventArgs e)
        {
            IstatistikleriGuncelle();
            MakaleleriGuncelle();
        }
        void MakaleleriGuncelle()
        {
            var tumMakaleler= new MesajRepo().GetALL().OrderBy(x=>x.MesajZamani).ToList();
            lstMakaleler.DisplayMember = "Baslik";
            lstMakaleler.ValueMember = "MesajID";
            lstMakaleler.DataSource = tumMakaleler;
        }
        void IstatistikleriGuncelle()
        {
            lblBenimMakaleSayim.Text = $"Makale Sayım: {new MesajRepo().GetALL().Where(x => x.KisiID == Kullanici.KisiID).Count()}";
            lblKayitliYazarlar.Text = $"Yazar Sayisi: {new KisiRepo().GetALL().Count()}";

            lblMakaleSayisi.Text = $"Kayıtlı Makale Sayisi: {new MesajRepo().GetALL().Count()}";

            lblYazarYasi.Text = $"Yaşınız: {Kullanici.Yas}";

            var yazarAdlari = new KisiRepo().GetALL().Where(x => x.DogumTarihi.Day == DateTime.Now.Day && x.DogumTarihi.Month == DateTime.Now.Month).Select(x => x.KullaniciAdi).ToList();

            lblDogumGunuOlanYazarlar.Text = $"Bugün doğum günü olan yazarlar:\n ";
            foreach (var ad in yazarAdlari)
            {
                lblDogumGunuOlanYazarlar.Text += ad + " ";
            }
        }
        public Mesaj SeciliMakale { get; set; }
        private void lstMakaleler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMakaleler.SelectedItem == null) return;

            SeciliMakale = lstMakaleler.SelectedItem as Mesaj;
            txtMakale.Text = SeciliMakale.Icerik;
            lblMakaleDetay.Text = $"Yazarı: {SeciliMakale.Yazari.KullaniciAdi}, Makale Tarihi: {SeciliMakale.MesajZamani:dd MMMM yyyy - hh:mm}";
        }

        private void btnMakaleYaz_Click(object sender, EventArgs e)
        {
            FormMakaleEkle makaleEkleForm = new FormMakaleEkle(Kullanici.KisiID);
            makaleEkleForm.ShowDialog();
            IstatistikleriGuncelle();
            MakaleleriGuncelle();
        }

        private void txtMakaleAra_TextChanged(object sender, EventArgs e)
        {
            lstMakaleler.DataSource = new MesajRepo().MakaleAra(txtMakaleAra.Text);
        }

        private void FormMakaleler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfilim_Click(object sender, EventArgs e)
        {
            FromProfilim profilForm = new FromProfilim(Kullanici.KisiID);
            profilForm.ShowDialog();
            IstatistikleriGuncelle();
            MakaleleriGuncelle();
        }
    }
}
