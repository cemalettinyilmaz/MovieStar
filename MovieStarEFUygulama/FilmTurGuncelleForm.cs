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
    public partial class FilmTurGuncelleForm : Form
    {
        private readonly AppDbContext db;
        private readonly int gelenID;

        Film film;
        public FilmTurGuncelleForm(AppDbContext db, int gelenID)
        {
            InitializeComponent();
            this.db = db;
            this.gelenID = gelenID;
            ComboxDoldur();
            film = db.Filmler.FirstOrDefault(x => x.FilmID == gelenID);
            if (film.Tur == null)
                cmbTurler.SelectedIndex = 0;
            else
                cmbTurler.SelectedValue = film.TurId;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            film.Tur = (Tur)cmbTurler.SelectedItem;
            db.SaveChanges();
            MessageBox.Show("Filmin tür bilgisi güncellendi.");
        }

        void ComboxDoldur()
        {
            cmbTurler.DataSource = db.Turler.ToList();
            cmbTurler.DisplayMember = ("TurAdi");
            cmbTurler.ValueMember = ("TurID");
        }

        private void FilmTurGuncelleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
