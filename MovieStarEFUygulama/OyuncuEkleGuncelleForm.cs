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
    public partial class OyuncuEkleGuncelleForm : Form
    {
        private readonly AppDbContext db;
        private readonly int gelenID;
        bool guncelleMi = false;

        public OyuncuEkleGuncelleForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }
        Oyuncu guncellenecekOyuncu;
        public OyuncuEkleGuncelleForm(AppDbContext db, int gelenID)
        {
            InitializeComponent();
            this.gelenID = gelenID;
            this.db = db;
            guncelleMi = true;
            guncellenecekOyuncu = db.Oyuncular.FirstOrDefault(x => x.OyuncuID == gelenID);
            guncellenecekOyuncu.IletisimBilgileri = db.IletisimBilgileri.FirstOrDefault(x => x.OyuncuID == gelenID);
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtAdSoyAd.Text) || string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Tüm alanları doldur");
                return;
            }
            if (btnEkleGuncelle.Text == "Ekle")
            {
                Oyuncu yeniOyuncu = new Oyuncu();
                yeniOyuncu.OyuncuAdSoyad = txtAdSoyAd.Text;
                IletisimBilgi yeniOyuncuIletisimBilgi = new IletisimBilgi();
                yeniOyuncuIletisimBilgi.Adres = txtAdres.Text;
                yeniOyuncuIletisimBilgi.TelefonNo = txtTelefon.Text;

                yeniOyuncu.IletisimBilgileri = yeniOyuncuIletisimBilgi;

                db.Oyuncular.Add(yeniOyuncu);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Oyuncu Başarıyla eklendi");
                    txtAdres.Clear();
                    txtAdSoyAd.Clear();
                    txtTelefon.Clear();
                }
                else
                {
                    MessageBox.Show("Oyuncu Eklenirken bir hata oluştu.");
                }

            }
            else
            {
                guncellenecekOyuncu.OyuncuAdSoyad = txtAdSoyAd.Text;
                if (guncellenecekOyuncu.IletisimBilgileri == null)
                {
                    IletisimBilgi ıletisimBilgi = new IletisimBilgi();
                    guncellenecekOyuncu.IletisimBilgileri = ıletisimBilgi;
                }
                guncellenecekOyuncu.IletisimBilgileri.Adres = txtAdres.Text;
                guncellenecekOyuncu.IletisimBilgileri.TelefonNo = txtTelefon.Text;
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Oyuncu Başarıyla güncellendi");
                    txtAdres.Clear();
                    txtAdSoyAd.Clear();
                    txtTelefon.Clear();
                    btnEkleGuncelle.Text = "Ekle";
                }
                else
                {
                    MessageBox.Show("Oyuncu güncellenirken bir hata oluştu.");
                }
            }
        }

        private void OyuncuEkleGuncelleForm_Load(object sender, EventArgs e)
        {
            if (guncelleMi == true)
            {

                txtAdSoyAd.Text = guncellenecekOyuncu.OyuncuAdSoyad;
                if (guncellenecekOyuncu.IletisimBilgileri != null)
                {
                    txtTelefon.Text = guncellenecekOyuncu.IletisimBilgileri.TelefonNo;
                    txtAdres.Text = guncellenecekOyuncu.IletisimBilgileri.Adres;

                }
                btnEkleGuncelle.Text = "Güncelle";

            }
        }
    }
}
