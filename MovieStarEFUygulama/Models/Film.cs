using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStarEFUygulama
{
    public class Film

    {
        public Film()
        {
            Oyuncular = new List<Oyuncu>();
        }
        [Key]
        public int FilmID { get; set; }
        [Required]
        [MaxLength(200)]
        public string FilmAdi { get; set; }
        [Range(1700, 2025)]
        public int Yil { get; set; }
        public string Poster { get; set; }
        public string imdbID { get; set; }
        public decimal IMDBPuani { get; set; }
        public int? TurId { get; set; }        
        public virtual Tur Tur { get; set; }       
        public virtual List<Oyuncu> Oyuncular { get; set;}
    }
}
