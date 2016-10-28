using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesajlasma.Models
{
    [Table("Dersler")]
    public class Ders
    {
        [Key]
        public int DersID { get; set; }
        public string DersAdi { get; set; }
        public short Kredi { get; set; }

        public virtual List<OgrenciDers> OgrenciDers { get; set; } = new List<OgrenciDers>();
    }
}
