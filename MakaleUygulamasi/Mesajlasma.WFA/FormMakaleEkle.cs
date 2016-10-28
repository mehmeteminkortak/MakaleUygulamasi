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
    public partial class FormMakaleEkle : Form
    {
        public FormMakaleEkle(int yazarID)
        {
            InitializeComponent();
            this.YazarID = yazarID;
        }
        public int YazarID { get; set; }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new MesajRepo().Insert(new Mesaj()
                {
                    Baslik = txtBaslik.Text,
                    Icerik = txtIcerik.Text,
                    KisiID = YazarID
                });
                MessageBox.Show("Makaleniz Kaydedilmiştir");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
