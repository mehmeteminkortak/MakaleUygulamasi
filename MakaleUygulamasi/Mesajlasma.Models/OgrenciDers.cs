using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesajlasma.Models
{
    [Table("OgrenciDers")]
    public class OgrenciDers
    {
        [Key]
        [Column(Order = 10)]
        public int OgrenciID { get; set; }
        [Key]
        [Column(Order = 20)]
        public int DersID { get; set; }
        public short Sene { get; set; }

        [ForeignKey("OgrenciID")]
        public virtual Ogrenci Ogrencisi { get; set; }
        [ForeignKey("DersID")]
        public virtual Ders Dersi { get; set; }
    }
}
