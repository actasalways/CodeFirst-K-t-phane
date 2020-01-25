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
    public partial class UyeIslemleri : Form
    {
        DatabaseContext db = new DatabaseContext();

        public UyeIslemleri()
        {
            InitializeComponent();
        }

        public void verileriGoster()
        {
            var veri = db.Alicilar.ToList();
            dgw_uyeler.DataSource = veri;
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

        private void uyeGuncelle(int id)
        {
            var a = db.Alicilar.Find(id);

            a.AliciAd = txt_uyeAd1.Text;
            a.AliciSoyad = txt_uyeSoyad1.Text;
            a.AliciTelefon = txt_uyeTelefon1.Text;
            a.AliciCeza = Convert.ToInt32(txt_uyeCeza.Text);

            db.SaveChanges();
            MessageBox.Show("Kitap Bilgileri Güncellendi");

        }

        private void uyeSil(int id)
        {
            var x = db.Alicilar.Find(id);
            db.Alicilar.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Kitap Silindi");
        }

        private void UyeIslemleri_Load(object sender, EventArgs e)
        {
            verileriGoster();
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
                verileriGoster();
            }

        }

        private void txt_uyeTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_uyeGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgw_uyeler.CurrentRow.Cells["Alici_id"].Value.ToString());

            if (MessageBox.Show("Güncelleme İşlemini Onaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uyeGuncelle(id);
                verileriGoster();
            }
            else
            {
                MessageBox.Show("İşlem tarafınızca iptal edilmiştir.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dgw_uyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_uyeId.Text= dgw_uyeler.CurrentRow.Cells["Alici_id"].Value.ToString();
            txt_uyeAd1.Text=dgw_uyeler.CurrentRow.Cells["AliciAd"].Value.ToString();
            txt_uyeSoyad1.Text=dgw_uyeler.CurrentRow.Cells["AliciSoyad"].Value.ToString();
            txt_uyeTelefon1.Text=dgw_uyeler.CurrentRow.Cells["AliciTelefon"].Value.ToString();
            txt_uyeCeza.Text= dgw_uyeler.CurrentRow.Cells["AliciCeza"].Value.ToString();

        }

        private void btn_uyeSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgw_uyeler.CurrentRow.Cells["Alici_id"].Value.ToString());

            if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uyeSil(id);
                verileriGoster();
            }
            else
            {
                MessageBox.Show("İşlem tarafınızca iptal edilmiştir.", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
