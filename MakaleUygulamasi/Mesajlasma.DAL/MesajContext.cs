using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mesajlasma.Models;

namespace Mesajlasma.DAL
{
    public class MesajContext : DbContext
    {
        public MesajContext() :
            base("name=MesajCon")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public virtual DbSet<Kisi> Kisiler { get; set; }
        public virtual DbSet<Mesaj> Mesajlar { get; set; }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Ders> Dersler { get; set; }
        public virtual DbSet<OgrenciDers> OgrenciDers { get; set; }
    }
}
