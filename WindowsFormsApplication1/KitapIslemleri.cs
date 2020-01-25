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
    public partial class KitapIslemleri : Form
    {
        DatabaseContext db = new DatabaseContext();


        public KitapIslemleri()
        {
            InitializeComponent();
        }

        public void verileriGoster()
        {
            var veri = db.Kitaplar.ToList();
            dgw_kitaplar.DataSource = veri;
        }

        private void kitapEkle()
        {
            Kitap k = new Kitap();
            k.KitapAd = txt_kitapAdi.Text;
            k.KitapYazar = txt_kitapYazar.Text;
            k.KitapISBN = txt_kitapISBN.Text;
            k.KitapBasimTarihi = txt_basimTarihi.Text;
            k.KitapYayinevi = txt_kitapYayinevi.Text;
            k.KitapStok = Convert.ToInt32(txt_kitapStokAdet.Text);

            db.Kitaplar.Add(k);
            db.SaveChanges();
            MessageBox.Show("Kitap Eklendi");
        }

        private void kitapSil(int id)
        {
            var x = db.Kitaplar.Find(id);
            db.Kitaplar.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Kitap Silindi");
        }

        private void kitapGuncelle(int id)
        {
            var x = db.Kitaplar.Find(id);
            x.KitapAd = txt_kitapAdi1.Text;
            x.KitapYazar = txt_kitapYazar1.Text;
            x.KitapISBN = txt_KitapISBN1.Text;
            x.KitapBasimTarihi = txt_basimTarihi1.Text;
            x.KitapYayinevi = txt_kitapYayinevi1.Text;

            db.SaveChanges();
            MessageBox.Show("Kitap Bilgileri Güncellendi");

        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            if (txt_kitapAdi.Text == "" || txt_kitapYazar.Text == "" || txt_kitapISBN.Text=="" || txt_basimTarihi.Text=="" || txt_kitapYayinevi.Text=="" || txt_kitapStokAdet.Text=="" )
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Eksik Kayıt Alanı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                kitapEkle();
                //this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }

        }

        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgw_kitaplar.CurrentRow.Cells["KitapId"].Value.ToString());

            if (MessageBox.Show("Güncelleme İşlemini Onaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kitapGuncelle(id);
                verileriGoster();
            }
            else
            {
                MessageBox.Show("İşlem tarafınızca iptal edilmiştir.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgw_kitaplar.CurrentRow.Cells["KitapId"].Value.ToString());

            if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kitapSil(id);
                verileriGoster();
            }
            else
            {
                MessageBox.Show("İşlem tarafınızca iptal edilmiştir.", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            verileriGoster();
            cbb_kitapFiltre.SelectedIndex = 0;
        }

        private void dgw_kitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapAdi1.Text = dgw_kitaplar.CurrentRow.Cells["KitapAd"].Value.ToString();
            txt_kitapYazar1.Text = dgw_kitaplar.CurrentRow.Cells["KitapYazar"].Value.ToString();
            txt_KitapISBN1.Text = dgw_kitaplar.CurrentRow.Cells["KitapISBN"].Value.ToString();
            txt_basimTarihi1.Text = dgw_kitaplar.CurrentRow.Cells["KitapBasimTarihi"].Value.ToString();
            txt_kitapYayinevi1.Text = dgw_kitaplar.CurrentRow.Cells["KitapYayinevi"].Value.ToString();
            txt_kitapStokAdet1.Text = dgw_kitaplar.CurrentRow.Cells["KitapStok"].Value.ToString();

        }

        private void txt_kitapStokAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_kitapFiltre_TextChanged(object sender, EventArgs e)
        {
            string neLazim = txt_kitapFiltre.Text;

            if (cbb_kitapFiltre.Text == "Kitap Adına Göre Arama")
            {
                dgw_kitaplar.DataSource = db.Kitaplar.Where(x => x.KitapAd.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre.Text == "Yazara Göre Arama")
            {
                dgw_kitaplar.DataSource = db.Kitaplar.Where(x => x.KitapYazar.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre.Text == "Yayınevine Göre Arama")
            {
                dgw_kitaplar.DataSource = db.Kitaplar.Where(x => x.KitapYayinevi.Contains(neLazim)).ToList();
            }
            else if (cbb_kitapFiltre.Text == "ISBN Göre Arama")
            {
                dgw_kitaplar.DataSource = db.Kitaplar.Where(x => x.KitapISBN.Contains(neLazim)).ToList();
            }
        }
            
    }
}
