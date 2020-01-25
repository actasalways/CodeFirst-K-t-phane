using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DatabaseContext db = new DatabaseContext();

        public Form1()
        {
            InitializeComponent();
        }

        #region region1


        public void kitapVerileriGoster()
        {
            var veri = db.Kitaplar.Where(x => x.KitapStok > 0).ToList();
            dgw_kitap.DataSource = veri;
            dgw_kitap1.DataSource = veri;
        }

        public void uyeVerileriGoster()
        {
            var veri = db.Alicilar.ToList();
            dgw_uye.DataSource = veri;
            dgw_uye1.DataSource = veri;

        }

        private void uyeEkle()
        {
            Alici a = new Alici();

            a.AliciAd = txt_uyeAd.Text;
            a.AliciSoyad = txt_uyeSoyad.Text;
            a.AliciTelefon = txt_uyeTelefon.Text;

            db.Alicilar.Add(a);
            db.SaveChanges();
            MessageBox.Show("Üye Eklendi");
        }

        private void btn_kitapIslemleri_Click(object sender, EventArgs e)
        {
            KitapIslemleri f1 = new KitapIslemleri();
            //this.Hide();
            f1.ShowDialog();

        }

        private void txt_kitapFiltre_TextChanged(object sender, EventArgs e)
        {
            string neLazim = txt_kitapFiltre.Text;

            if (cbb_kitapFiltre.Text == "Kitap Adına Göre Arama")
            {
                dgw_kitap.DataSource = db.Kitaplar.Where(x => x.KitapAd.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre.Text == "Yazara Göre Arama")
            {
                dgw_kitap.DataSource = db.Kitaplar.Where(x => x.KitapYazar.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre.Text == "Yayınevine Göre Arama")
            {
                dgw_kitap.DataSource = db.Kitaplar.Where(x => x.KitapYayinevi.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre.Text == "ISBN Göre Arama")
            {
                dgw_kitap.DataSource = db.Kitaplar.Where(x => x.KitapISBN.Contains(neLazim)).ToList();
            }

        }

        private void txt_uyeFiltre_TextChanged(object sender, EventArgs e)
        {
            string neLazim = txt_uyeFiltre.Text;

            if (cbb_uyeFiltre.Text == "Üye Adı Ara")
            {
                dgw_uye.DataSource = db.Alicilar.Where(x => x.AliciAd.Contains(neLazim)).ToList();
            }
            else if (cbb_uyeFiltre.Text == "Telefon Numarasıyla Ara")
            {
                dgw_uye.DataSource = db.Alicilar.Where(x => x.AliciTelefon.StartsWith(neLazim)).ToList();
            }

        }

        private void btn_uyeIslemleri_Click(object sender, EventArgs e)
        {
            UyeIslemleri u = new UyeIslemleri();
            //this.Hide();
            u.ShowDialog();
        }

        private void btn_uyeEkle_Click(object sender, EventArgs e)
        {
            if (txt_uyeAd.Text == "" || txt_uyeSoyad.Text == "" || txt_uyeTelefon.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Eksik Kayıt Alanı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                uyeEkle();
                uyeVerileriGoster();
            }
        }

        private void txt_kitapFiltre1_TextChanged(object sender, EventArgs e)
        {
            string neLazim = txt_kitapFiltre1.Text;

            if (cbb_kitapFiltre1.Text == "Kitap Adına Göre Arama")
            {
                dgw_kitap1.DataSource = db.Kitaplar.Where(x => x.KitapAd.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre1.Text == "Yazara Göre Arama")
            {
                dgw_kitap1.DataSource = db.Kitaplar.Where(x => x.KitapYazar.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre1.Text == "Yayınevine Göre Arama")
            {
                dgw_kitap1.DataSource = db.Kitaplar.Where(x => x.KitapYayinevi.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre1.Text == "ISBN Göre Arama")
            {
                dgw_kitap1.DataSource = db.Kitaplar.Where(x => x.KitapISBN.Contains(neLazim)).ToList();
            }
        }

        private void txt_uyeFiltre1_TextChanged(object sender, EventArgs e)
        {
            string neLazim = txt_uyeFiltre1.Text;

            if (cbb_uyeFiltre1.Text == "Üye Adı Ara")
            {
                dgw_uye1.DataSource = db.Alicilar.Where(x => x.AliciAd.Contains(neLazim)).ToList();
            }
            else if (cbb_uyeFiltre1.Text == "Telefon Numarasıyla Ara")
            {
                dgw_uye1.DataSource = db.Alicilar.Where(x => x.AliciTelefon.StartsWith(neLazim)).ToList();
            }
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapVerileriGoster();
            uyeVerileriGoster();
            cbb_kitapFiltre.SelectedIndex = 0;
            cbb_uyeFiltre.SelectedIndex = 0;
            cbb_kitapFiltre1.SelectedIndex = 0;
            cbb_uyeFiltre1.SelectedIndex = 0;
            kiralanmislarGoster();

            cezaHesapla(5);
        }

        private void kiralanmisEkle(int KitapId, int AliciId)
        {
            Kiralanmislar k = new Kiralanmislar();
            k.RehinTarih = (Convert.ToDateTime(dtp_verilenTarih.Text)).ToString();
            k.TeslimTarih = Convert.ToDateTime(dtp_alinacakTarih.Text).ToString();
            k.KitapId = KitapId;
            k.Alici_id = AliciId;

            db.Kiralanmislar.Add(k);
            db.SaveChanges();
            MessageBox.Show("İlgili İşlem Yapılmıştır.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void kitapStokAzalt(int KitapId)
        {
            var x = db.Kitaplar.Find(KitapId);
            x.KitapStok--;
            db.SaveChanges();
            //MessageBox.Show("Kitap Stok Bilgisi Güncellendi");
        }

        private void kiralanmislarGoster()
        {
            var veri = db.Kiralanmislar.ToList();
            dgw_kiralanmislar.DataSource = veri;
        }

        private void kitapStokArttır(int KitapId)
        {
            var x = db.Kitaplar.Find(KitapId);
            x.KitapStok++;
            db.SaveChanges();
            //MessageBox.Show("Kitap Stok Bilgisi Güncellendi");
        }

        private void teslimAlindi(int KiralanmisId)
        {
            var x = db.Kiralanmislar.Find(KiralanmisId);
            x.TeslimAlindi = true;
            db.SaveChanges();
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {
            cezaHesapla(5);

            int KitapId = Convert.ToInt32(dgw_kitap1.CurrentRow.Cells["KitapId"].Value.ToString());
            int AliciId = Convert.ToInt32(dgw_uye1.CurrentRow.Cells["Alici_id"].Value.ToString());
            int cezaMiktar = 100;

            int AliciCeza = Convert.ToInt32(dgw_uye1.CurrentRow.Cells["AliciCeza"].Value.ToString());
            if (AliciCeza > cezaMiktar)
            {
                MessageBox.Show("Bu Borçla ilgili kitap rehin verilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DateTime bTarih = Convert.ToDateTime(dtp_alinacakTarih.Text);
                DateTime kTarih = Convert.ToDateTime(dtp_verilenTarih.Text);
                TimeSpan Sonuc = bTarih - kTarih;
                if (Sonuc.TotalDays < 0)
                {
                    MessageBox.Show("Teslim Tarihi Daha Erken Olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    kiralanmisEkle(KitapId, AliciId);
                    kitapStokAzalt(KitapId);
                    kitapVerileriGoster();
                }
            }

        }

        private void btn_teslimAl_Click(object sender, EventArgs e)
        {
            int KitapId = Convert.ToInt32(dgw_kiralanmislar.CurrentRow.Cells["KitapId"].Value.ToString());
            int KiralanmisId = Convert.ToInt32(dgw_kiralanmislar.CurrentRow.Cells["KiralanmisId"].Value.ToString());

            teslimAlindi(KiralanmisId);
            kitapStokArttır(KitapId);
            kiralanmislarGoster();

        }

        private void cezaKes(int Alici_id, int s, int cezaMiktari)
        {
            var x = db.Alicilar.Find(Alici_id);
            x.AliciCeza += cezaMiktari * - ((s/60)/24) ;
            db.SaveChanges();
            uyeVerileriGoster();
        }

        private void cezaHesapla(int cezaMiktari)
        {
            var veri = db.Kiralanmislar.ToList();
            foreach (var v in veri)
            {
                DateTime AlinacakTarih = Convert.ToDateTime(v.TeslimTarih);
                TimeSpan diff1 = AlinacakTarih.Subtract(DateTime.Today);
                int miliSaniye = (int)diff1.TotalMinutes;
                if ( miliSaniye < 0 )
                {
                    if (v.TeslimAlindi == false)//teslim alınmamış ve teslim tarihi geçmiş olan kitaplar
                    {
                        cezaKes(v.Alici_id,miliSaniye,cezaMiktari);
                    }

                }
            }


        }


    }
}