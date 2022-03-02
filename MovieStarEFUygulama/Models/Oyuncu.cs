using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStarEFUygulama
{
    public class Oyuncu
    {
        
        public Oyuncu()
        {
            Filmler = new List<Film>();
        }
        [Key]
        public int OyuncuID { get; set; }
        [MaxLength(60)]
        [Required]             
        public string OyuncuAdSoyad { get; set; }       
        public List<Film> Filmler { get; set; }     
       
        public IletisimBilgi IletisimBilgileri { get; set; }


    }
}
