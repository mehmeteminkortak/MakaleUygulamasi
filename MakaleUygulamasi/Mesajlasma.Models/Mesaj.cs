using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesajlasma.Models
{
    [Table("Mesajlar")]
    public class Mesaj
    {
        [Key]
        public Guid MesajID { get; set; } = Guid.NewGuid();
        public int KisiID { get; set; } //FK
        [Required]
        [StringLength(50)]
        public string Baslik { get; set; }
        [Required]
        public string Icerik { get; set; }
        public DateTime MesajZamani { get; set; } = DateTime.Now;
        public DateTime? GuncellemeZamani { get; set; }
        public bool MakaleAktifMi { get; set; } = true;

        //navigation props

        [ForeignKey("KisiID")]
        public virtual Kisi Yazari { get; set; }
    }
}
