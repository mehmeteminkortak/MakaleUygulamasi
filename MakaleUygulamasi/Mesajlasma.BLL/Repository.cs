using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mesajlasma.DAL;
using Mesajlasma.Models;

namespace Mesajlasma.BLL
{
    public class KisiRepo : RepositoryBase<Kisi, int>
    {
        public Kisi LoginControl(string userName, string pass)
        {
            MesajContext db = new MesajContext();
            return db.Kisiler.Where(x => x.KullaniciAdi == userName && x.Sifre == pass).FirstOrDefault();
        }
        public override void Delete(Kisi entity)
        {
            throw new Exception("Kişiyi silemezsiniz");
        }
    }
    public class MesajRepo : RepositoryBase<Mesaj, Guid>
    {
        public List<Mesaj> MakaleAra(string kelime)
        {
            string aranan = kelime.ToLower();
            return this.GetALL().Where(
                x => x.MakaleAktifMi == true && (x.Baslik.ToLower().Contains(aranan) ||
                x.Icerik.ToLower().Contains(aranan) ||
                x.Yazari.KullaniciAdi.ToLower().StartsWith(aranan))
            ).ToList();
        }
        public override void Insert(Mesaj entity)
        {
            base.Insert(entity);
            //MailGonder(entity);
        }
        public override void Delete(Mesaj entity)
        {
            var silinecekMesaj = this.GetByID(entity.MesajID);
            silinecekMesaj.MakaleAktifMi = false;
            dbContext.SaveChanges();
        }
    }
}
