using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesajlasma.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }
        public string Ad { get; set; }

        public virtual List<OgrenciDers> OgrenciDers { get; set; } = new List<OgrenciDers>();
    }
}
