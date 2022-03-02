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
using System.Data.Entity;

namespace MovieStarEFUygulama
{
    public partial class OyuncularForm : Form
    {
        private readonly AppDbContext db;

        public OyuncularForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void OyuncularForm_Load(object sender, EventArgs e)
        {
            OyunculariListele();
        }

        void OyunculariListele()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in db.Oyuncular.Include(x => x.IletisimBilgileri))
            {
                if (item.IletisimBilgileri != null)
                {

                    dataGridView1.Rows.Add(item.OyuncuID, item.OyuncuAdSoyad, item.IletisimBilgileri.Adres, item.IletisimBilgileri.TelefonNo);
                }
                else
                {
                    dataGridView1.Rows.Add(item.OyuncuID, item.OyuncuAdSoyad, "Yok", "Yok");
                }
            }
        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            OyuncuEkleGuncelleForm oyuncuEkle = new OyuncuEkleGuncelleForm(db);
            oyuncuEkle.ShowDialog();
            OyunculariListele();

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int gidecekId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                OyuncuEkleGuncelleForm oyuncuGuncelle = new OyuncuEkleGuncelleForm(db, gidecekId);
                oyuncuGuncelle.ShowDialog();
                OyunculariListele();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Oyuncu silinecekOyuncu = new Oyuncu();
                int silinecekID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                silinecekOyuncu = db.Oyuncular.FirstOrDefault(x => x.OyuncuID == silinecekID);
                IletisimBilgi silinecekbilgi = db.IletisimBilgileri.FirstOrDefault(x => x.OyuncuID == silinecekOyuncu.OyuncuID);
                db.Oyuncular.Remove(silinecekOyuncu);
                //db.IletisimBilgileri.Remove(silinecekbilgi);
                db.SaveChanges();
                OyunculariListele();
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var hti = dataGridView1.HitTest(e.X, e.Y);
                if (hti.RowIndex < 0)
                {
                    contextMenuStrip1.Visible = false;
                    return;
                }
                dataGridView1.Rows[hti.RowIndex].Selected = true;
            }
        }
    }
}
