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
    public partial class FromProfilim : Form
    {
        public FromProfilim(int yazarID)
        {
            InitializeComponent();
            this.yazarID = yazarID;
        }
        int yazarID = 0;
        public Kisi Yazar { get; set; }
        private void FromProfilim_Load(object sender, EventArgs e)
        {
            Yazar = new KisiRepo().GetByID(yazarID);
            lstMakaleler.DisplayMember = "Baslik";
            lstMakaleler.ValueMember = "MesajID";
            lstMakaleler.DataSource = Yazar.Mesajlar;
        }

        private void txtMakaleAra_TextChanged(object sender, EventArgs e)
        {
            lstMakaleler.DataSource = new MesajRepo().MakaleAra(txtMakaleAra.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMakaleler.SelectedItem == null)
            {
                MessageBox.Show("Önce güncellenecek makaleyi seçiniz");
                return;
            }

            var guncellenecekMakale = new MesajRepo().GetByID((Guid)(lstMakaleler.SelectedValue));
            guncellenecekMakale.Baslik = txtBaslik.Text;
            guncellenecekMakale.Icerik = txtMakale.Text;
            guncellenecekMakale.GuncellemeZamani = DateTime.Now;
            try
            {
                new MesajRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lstMakaleler.DataSource = new KisiRepo().GetByID(yazarID).Mesajlar;
        }

        private void lstMakaleler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMakaleler.SelectedItem == null) return;

            var SeciliMakale = lstMakaleler.SelectedItem as Mesaj;
            txtMakale.Text = SeciliMakale.Icerik;
            txtBaslik.Text = SeciliMakale.Baslik;
            lblMakaleDetay.Text = $"Yazarı: {SeciliMakale.Yazari.KullaniciAdi}, Makale Tarihi: {SeciliMakale.MesajZamani:dd MMMM yyyy - hh:mm}";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekMakale = new MesajRepo().GetByID((Guid)(lstMakaleler.SelectedValue));
            new MesajRepo().Delete(silinecekMakale);
            lstMakaleler.DataSource = new KisiRepo().GetByID(yazarID).Mesajlar;
        }
    }
}
