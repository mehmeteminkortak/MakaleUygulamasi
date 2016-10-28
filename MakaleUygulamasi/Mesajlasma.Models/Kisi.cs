using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesajlasma.Models
{
    [Table("Kisiler")]
    public class Kisi
    {
        [Key]
        public int KisiID { get; set; }
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Kullanici adi 3-25 karakter arası olmalı")]
        [Column("UserName",TypeName = "varchar")]
        [Index(IsUnique = true)]
        [Required]
        public string KullaniciAdi { get; set; }
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Şifre 4-8 karakter aralığında olmalı")]
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$",ErrorMessage = "Password matching expression. Password must be at least 4 characters, no more than 8 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.")]
        [Column("Password")]
        public string Sifre { get; set; }
        [Column(TypeName ="smalldatetime")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        [Required]
        [Column(TypeName ="date")]
        public DateTime DogumTarihi { get; set; }
        [NotMapped]
        public int Yas
        {
            get
            {
                return DateTime.Now.Year - DogumTarihi.Year;
            }
        }

        //navigation props
        public virtual List<Mesaj> Mesajlar { get; set; } = new List<Mesaj>();
    }
}
