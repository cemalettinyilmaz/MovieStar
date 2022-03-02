using HtmlAgilityPack;
using MovieStarEFUygulama.Data;
using MovieStarEFUygulama.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStarEFUygulama
{
    public partial class MainForm : Form
    {
        AppDbContext db = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
            //TurYukle();
            FilmYukle();
            turComboDoldur();
        }

        void turComboDoldur()
        {
            cmbTur.Items.Clear();
            cmbTur.Items.Add("Tüm Türler");
            foreach (var item in db.Turler)
            {
                cmbTur.Items.Add(item.TurAdi);
            }
            cmbTur.SelectedIndex = 0;
        }

        private void FilmYukle()
        {
            dgvFilmler.Rows.Clear();
            string arananFilm = txtFilmAra.Text.Trim();
            string arananTur = "";
            if (cmbTur.SelectedIndex > 0)
            {
                arananTur = cmbTur.Text;
            }

            foreach (var item in db.Filmler.ToList())
            {

                if (item.FilmAdi.Contains(arananFilm))
                {
                    // ((item.Tur == null || item.TurId == null || item.Tur.TurAdi == null))
                    if (item.Tur == null & string.IsNullOrEmpty(arananTur))
                    {
                        dgvFilmler.Rows.Add(item.FilmID, item.FilmAdi, item.Poster, item.Yil, item.IMDBPuani, item.imdbID, "Tür Bilgisi Yok", string.Join(",", item.Oyuncular.Select(x => x.OyuncuAdSoyad)));
                    }
                    else if (item.Tur != null)
                    {
                        if (item.Tur.TurAdi.Contains(arananTur))
                            dgvFilmler.Rows.Add(item.FilmID, item.FilmAdi, item.Poster, item.Yil, item.IMDBPuani, item.imdbID, item.Tur.TurAdi, string.Join(",", item.Oyuncular.Select(x => x.OyuncuAdSoyad)));
                    }
                }
            }
        }


        private void TurYukle()
        {
            if (!db.Turler.Any())
            {
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Bilim Kurgu",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Komedi",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Romantik",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Dram",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Gerilim",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Korku",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Fantastik",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Romantik Komedi",
                });
                db.Turler.Add(new Tur()
                {
                    TurAdi = "Belgesel",
                });
                db.SaveChanges();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tsmiOyuncular_Click(object sender, EventArgs e)
        {
            OyuncularForm oyuncularForm = new OyuncularForm(db);
            oyuncularForm.ShowDialog();
            FilmYukle();

        }

        private void dgvFilmler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count > 0)
            {
                string poster = (string)dgvFilmler.SelectedRows[0].Cells[2].Value;
                pboFilmPoster.ImageLocation = poster;
            }
        }

        private void dgvFilmler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var hti = dgvFilmler.HitTest(e.X, e.Y);
                if (hti.RowIndex < 0)
                {
                    contextMenuStrip1.Visible = false;
                    return;
                }
                dgvFilmler.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili film silinecek emin misiniz ?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
                Film silinecekFilm = db.Filmler.FirstOrDefault(x => x.FilmID == id);
                db.Filmler.Remove(silinecekFilm);
                db.SaveChanges();
                FilmYukle();

            }
        }

        private void türlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTurForm turEkle = new AddTurForm(db);
            turEkle.ShowDialog();
            FilmYukle();
            turComboDoldur();
        }

        private void filmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFilmForm filmEkle = new AddFilmForm(db);
            filmEkle.ShowDialog();
            FilmYukle();

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count > 0)
            {
                int guncellenecekID = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
                AddFilmForm guncelemeForm = new AddFilmForm(db, guncellenecekID);
                guncelemeForm.ShowDialog();
                FilmYukle();
            }
        }

        private void türGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count > 0)
            {
                int turGuncellenecekFilmId = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
                FilmTurGuncelleForm filmTurGuncelleForm = new FilmTurGuncelleForm(db, turGuncellenecekFilmId);
                filmTurGuncelleForm.ShowDialog();
                FilmYukle();
            }
        }

        private void oyuncuGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count > 0)
            {
                int oyuncuGuncellenecekFilmID = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;

                Film film = db.Filmler.FirstOrDefault(x => x.FilmID == oyuncuGuncellenecekFilmID);

                FilmOyuncuGuncelleForm oyuncuGuncelle = new FilmOyuncuGuncelleForm(db, film);

                oyuncuGuncelle.ShowDialog();

                FilmYukle();
            }
        }

        private void txtFilmAra_TextChanged(object sender, EventArgs e)
        {
            FilmYukle();
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmYukle();
        }
    }
}
