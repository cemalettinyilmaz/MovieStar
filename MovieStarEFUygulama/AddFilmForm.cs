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
    public partial class AddFilmForm : Form
    {
        private readonly AppDbContext db;
        private readonly int gelenID;

        public AddFilmForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            btnEkle.Text = "Ekle";
            ComboDoldur();
            this.Text = "Film Ekleme";
        }
        public AddFilmForm(AppDbContext db, int gelenID)
        {
            InitializeComponent();
            this.db = db;
            this.gelenID = gelenID;
            btnEkle.Text = "Güncelle";
            guncellenecekFilm = db.Filmler.FirstOrDefault(x => x.FilmID == gelenID);
            txtFilmAdi.Text = guncellenecekFilm.FilmAdi;
            nudYil.Value = guncellenecekFilm.Yil;
            txtPoster.Text = guncellenecekFilm.Poster;
            nudImdb.Value = guncellenecekFilm.IMDBPuani;
            cmbTur.DataSource = db.Turler.ToList();
            cmbTur.DisplayMember = ("TurAdi");
            cmbTur.ValueMember = ("TurID");
            if (guncellenecekFilm.Tur == null)
                cmbTur.SelectedIndex = 0;
            else
                cmbTur.SelectedValue = guncellenecekFilm.Tur.TurID;
            this.Text = "Film güncelleme";
        }
        Film guncellenecekFilm;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilmAdi.Text))
            {
                MessageBox.Show("Film adı ve Yılı boş olamaz");
                return;
            }
            if (btnEkle.Text == "Ekle")
            {
                Film yeniFilm = new Film();
                yeniFilm.FilmAdi = txtFilmAdi.Text;
                yeniFilm.Yil = (int)nudYil.Value;
                yeniFilm.Poster = txtPoster.Text;
                yeniFilm.IMDBPuani = nudImdb.Value;
                yeniFilm.Tur = (Tur)cmbTur.SelectedItem;
                db.Filmler.Add(yeniFilm);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Film başarıyla eklendi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Film eklenirken bir sorun oluştu.");
                }

            }
            else
            {

                guncellenecekFilm.FilmAdi = txtFilmAdi.Text;
                guncellenecekFilm.Yil = (int)nudYil.Value;
                guncellenecekFilm.Poster = txtPoster.Text;
                guncellenecekFilm.IMDBPuani = nudImdb.Value;
                guncellenecekFilm.Tur = (Tur)cmbTur.SelectedItem;
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Film başarıyla güncellendi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Film güncellenirken bir sorun oluştu.");
                }
            }

        }

        private void AddFilmForm_Load(object sender, EventArgs e)
        {

        }

        private void ComboDoldur()
        {
            cmbTur.DataSource = db.Turler.ToList();
            cmbTur.DisplayMember = ("TurAdi");
            cmbTur.ValueMember = ("TurID");
        }
    }
}
