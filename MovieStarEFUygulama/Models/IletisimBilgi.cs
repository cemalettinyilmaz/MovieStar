using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStarEFUygulama
{
    public class IletisimBilgi
    {
       
       
        [MaxLength(13)]
        [Required]
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        [Key,ForeignKey("Oyuncu")]
        public int OyuncuID { get; set; }
        public Oyuncu Oyuncu { get; set; }

        
    }
}
