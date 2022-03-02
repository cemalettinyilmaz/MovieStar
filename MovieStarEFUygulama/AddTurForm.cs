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
    public partial class AddTurForm : Form
    {
        private readonly AppDbContext db;

        public AddTurForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            Turlistele();
        }
        Tur guncellenecekTur;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTurAdi.Text))
            {
                MessageBox.Show("Tür adı boş olamaz");
                return;
            }
            if (btnEkle.Text == "Ekle")
            {

                Tur yeniTur = new Tur();
                yeniTur.TurAdi = txtTurAdi.Text;
                db.Turler.Add(yeniTur);
                if (db.SaveChanges() > 0)
                {
                    Turlistele();
                    MessageBox.Show("Yeni Tür bilgisi eklendi.");
                }
                else
                {
                    MessageBox.Show("Tür bilgisi eklenirken bir sorun oluştu.");
                }
            }
            else
            {
                guncellenecekTur.TurAdi = txtTurAdi.Text;
                if (db.SaveChanges() > 0)
                {
                    Turlistele();
                    MessageBox.Show("Tür bilgisi Güncellendi");
                    txtTurAdi.Clear();
                    btnEkle.Text = "Ekle";
                    btnIptal.Visible = false;
                }
            }
        }

        private void Turlistele()
        {
            dgvTurler.DataSource = db.Turler.ToList();
        }

        private void dgvTurler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvTurler.HitTest(e.X, e.Y);
                if (hit.RowIndex < 0)
                {
                    contextMenuStrip1.Enabled = false;
                    return;
                }
                dgvTurler.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTurler.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçtiğiniz tür silinecek emin misin=", "Silme İşlemi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Tur silinecekTur = new Tur();
                    int Id = (int)dgvTurler.SelectedRows[0].Cells[0].Value;
                    silinecekTur = db.Turler.FirstOrDefault(x => x.TurID == Id);
                    db.Turler.Remove(silinecekTur);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Seçili Tür Silindi");
                    }
                    Turlistele();
                }
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTurler.SelectedRows.Count > 0)
            {
                int turId = (int)dgvTurler.SelectedRows[0].Cells[0].Value;
                guncellenecekTur = db.Turler.FirstOrDefault(x => x.TurID == turId);
                txtTurAdi.Text = guncellenecekTur.TurAdi;
                btnEkle.Text = "Güncelle";
                btnIptal.Visible = true;

            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnEkle.Text = "Ekle";
            txtTurAdi.Clear();
            btnIptal.Visible = false;
        }
    }
}
