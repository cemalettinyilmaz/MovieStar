using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStarEFUygulama
{
    public class Tur
    {
        [Key]
        public int TurID { get; set; }
        [MaxLength(20)]        
        public string TurAdi { get; set; }
        public List<Film> Filmler { get; set; }
        public Tur()
        {
            Filmler = new List<Film>();
        }
    }
}
