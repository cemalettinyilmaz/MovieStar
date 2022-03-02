using MovieStarEFUygulama.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStarEFUygulama
{
    public partial class FilmOyuncuGuncelleForm : Form
    {
        private readonly AppDbContext db;
        Film film;
        public FilmOyuncuGuncelleForm(AppDbContext db, Film film)
        {
            InitializeComponent();
            this.db = db;
            this.film = film;
        }

        private void FilmOyuncuGuncelleForm_Load(object sender, EventArgs e)
        {
            TumOyunculariDoldur();

            FilmOyunculariniYukle();
        }

        private void TumOyunculariDoldur()
        {
            dgvTumOyuncular.Rows.Clear();

            foreach (var item in db.Oyuncular.ToList())
            {
                dgvTumOyuncular.Rows.Add(item.OyuncuID, item.OyuncuAdSoyad);
            }

            lblFilmAdi.Text = "Film Adı :" + film.FilmAdi.ToString();
        }

        void FilmOyunculariniYukle()
        {
            dgvFilminOyunculari.Rows.Clear();
            foreach (var item in film.Oyuncular)
            {
                dgvFilminOyunculari.Rows.Add(item.OyuncuID, item.OyuncuAdSoyad);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvFilminOyunculari.SelectedRows.Count > 0)
            {
                int silinecekOyuncuId = (int)dgvFilminOyunculari.SelectedRows[0].Cells[0].Value;
                Oyuncu kaldirilacakOyuncu = film.Oyuncular.FirstOrDefault(x => x.OyuncuID == silinecekOyuncuId);
                film.Oyuncular.Remove(kaldirilacakOyuncu);
                db.SaveChanges();
                FilmOyunculariniYukle();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (dgvTumOyuncular.SelectedRows.Count > 0)
            {

                List<Oyuncu> eklenecekOyuncular = new List<Oyuncu>();

                for (int i = 0; i < dgvTumOyuncular.SelectedRows.Count; i++)
                {
                    int eklenecekOyuncuId = (int)dgvTumOyuncular.SelectedRows[i].Cells[0].Value;

                    Oyuncu filmeEklenecekOyuncu = db.Oyuncular.FirstOrDefault(x => x.OyuncuID == eklenecekOyuncuId);

                    if (!film.Oyuncular.Contains(filmeEklenecekOyuncu))
                    {
                        eklenecekOyuncular.Add(filmeEklenecekOyuncu);
                    }                   

                }

                foreach (var item in eklenecekOyuncular)
                {
                    film.Oyuncular.Add(item);
                }               
                db.SaveChanges();
                FilmOyunculariniYukle();
            }
        }
    }
}
