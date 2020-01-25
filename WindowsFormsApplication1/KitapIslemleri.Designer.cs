namespace WindowsFormsApplication1
{
    partial class KitapIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_kitapStokAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_basimTarihi = new System.Windows.Forms.TextBox();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kitapYayinevi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kitapISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kitapYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kitapSil = new System.Windows.Forms.Button();
            this.txt_kitapStokAdet1 = new System.Windows.Forms.TextBox();
            this.txt_basimTarihi1 = new System.Windows.Forms.TextBox();
            this.txt_kitapId1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_kitapGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_kitapYayinevi1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_KitapISBN1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kitapYazar1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_kitapAdi1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgw_kitaplar = new System.Windows.Forms.DataGridView();
            this.cbb_kitapFiltre = new System.Windows.Forms.ComboBox();
            this.txt_kitapFiltre = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 663);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap Ekleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_kitapStokAdet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_basimTarihi);
            this.groupBox1.Controls.Add(this.btn_kitapEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kitapYayinevi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kitapISBN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_kitapYazar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kitapAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(327, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 550);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txt_kitapStokAdet
            // 
            this.txt_kitapStokAdet.Location = new System.Drawing.Point(210, 283);
            this.txt_kitapStokAdet.MaxLength = 10;
            this.txt_kitapStokAdet.Name = "txt_kitapStokAdet";
            this.txt_kitapStokAdet.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapStokAdet.TabIndex = 17;
            this.txt_kitapStokAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapStokAdet_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(67, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kitap Stok Adedi";
            // 
            // txt_basimTarihi
            // 
            this.txt_basimTarihi.Location = new System.Drawing.Point(210, 206);
            this.txt_basimTarihi.MaxLength = 4;
            this.txt_basimTarihi.Name = "txt_basimTarihi";
            this.txt_basimTarihi.Size = new System.Drawing.Size(200, 20);
            this.txt_basimTarihi.TabIndex = 12;
            this.txt_basimTarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapStokAdet_KeyPress);
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapEkle.Location = new System.Drawing.Point(147, 367);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(186, 68);
            this.btn_kitapEkle.TabIndex = 1;
            this.btn_kitapEkle.Text = "Kitabı Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = true;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kitap Basım Tarihi";
            // 
            // txt_kitapYayinevi
            // 
            this.txt_kitapYayinevi.Location = new System.Drawing.Point(210, 245);
            this.txt_kitapYayinevi.Name = "txt_kitapYayinevi";
            this.txt_kitapYayinevi.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapYayinevi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Yayınevi";
            // 
            // txt_kitapISBN
            // 
            this.txt_kitapISBN.Location = new System.Drawing.Point(210, 163);
            this.txt_kitapISBN.Name = "txt_kitapISBN";
            this.txt_kitapISBN.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapISBN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN";
            // 
            // txt_kitapYazar
            // 
            this.txt_kitapYazar.Location = new System.Drawing.Point(210, 130);
            this.txt_kitapYazar.Name = "txt_kitapYazar";
            this.txt_kitapYazar.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapYazar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Yazar:";
            // 
            // txt_kitapAdi
            // 
            this.txt_kitapAdi.Location = new System.Drawing.Point(210, 101);
            this.txt_kitapAdi.Name = "txt_kitapAdi";
            this.txt_kitapAdi.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitap Bilgileri Düzenle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_kitapFiltre);
            this.groupBox2.Controls.Add(this.txt_kitapFiltre);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgw_kitaplar);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1107, 625);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kitapSil);
            this.groupBox3.Controls.Add(this.txt_kitapStokAdet1);
            this.groupBox3.Controls.Add(this.txt_basimTarihi1);
            this.groupBox3.Controls.Add(this.txt_kitapId1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn_kitapGuncelle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_kitapYayinevi1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_KitapISBN1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_kitapYazar1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_kitapAdi1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(689, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 500);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btn_kitapSil
            // 
            this.btn_kitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapSil.Location = new System.Drawing.Point(141, 409);
            this.btn_kitapSil.Name = "btn_kitapSil";
            this.btn_kitapSil.Size = new System.Drawing.Size(156, 67);
            this.btn_kitapSil.TabIndex = 5;
            this.btn_kitapSil.Text = "Kitabı Sil";
            this.btn_kitapSil.UseVisualStyleBackColor = true;
            this.btn_kitapSil.Click += new System.EventHandler(this.btn_kitapSil_Click);
            // 
            // txt_kitapStokAdet1
            // 
            this.txt_kitapStokAdet1.Location = new System.Drawing.Point(173, 267);
            this.txt_kitapStokAdet1.Name = "txt_kitapStokAdet1";
            this.txt_kitapStokAdet1.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapStokAdet1.TabIndex = 15;
            this.txt_kitapStokAdet1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapStokAdet_KeyPress);
            // 
            // txt_basimTarihi1
            // 
            this.txt_basimTarihi1.Location = new System.Drawing.Point(173, 177);
            this.txt_basimTarihi1.MaxLength = 4;
            this.txt_basimTarihi1.Name = "txt_basimTarihi1";
            this.txt_basimTarihi1.Size = new System.Drawing.Size(200, 20);
            this.txt_basimTarihi1.TabIndex = 14;
            this.txt_basimTarihi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapStokAdet_KeyPress);
            // 
            // txt_kitapId1
            // 
            this.txt_kitapId1.Location = new System.Drawing.Point(173, 40);
            this.txt_kitapId1.Name = "txt_kitapId1";
            this.txt_kitapId1.ReadOnly = true;
            this.txt_kitapId1.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapId1.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(30, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Kitap ID";
            // 
            // btn_kitapGuncelle
            // 
            this.btn_kitapGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapGuncelle.Location = new System.Drawing.Point(117, 335);
            this.btn_kitapGuncelle.Name = "btn_kitapGuncelle";
            this.btn_kitapGuncelle.Size = new System.Drawing.Size(200, 68);
            this.btn_kitapGuncelle.TabIndex = 1;
            this.btn_kitapGuncelle.Text = "Kitap Bilgilerini Güncelle";
            this.btn_kitapGuncelle.UseVisualStyleBackColor = true;
            this.btn_kitapGuncelle.Click += new System.EventHandler(this.btn_kitapGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kitap Stok Adedi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(30, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kitap Basım Tarihi";
            // 
            // txt_kitapYayinevi1
            // 
            this.txt_kitapYayinevi1.Location = new System.Drawing.Point(173, 216);
            this.txt_kitapYayinevi1.Name = "txt_kitapYayinevi1";
            this.txt_kitapYayinevi1.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapYayinevi1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kitap Yayınevi";
            // 
            // txt_KitapISBN1
            // 
            this.txt_KitapISBN1.Location = new System.Drawing.Point(173, 134);
            this.txt_KitapISBN1.Name = "txt_KitapISBN1";
            this.txt_KitapISBN1.Size = new System.Drawing.Size(200, 20);
            this.txt_KitapISBN1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(30, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "ISBN";
            // 
            // txt_kitapYazar1
            // 
            this.txt_kitapYazar1.Location = new System.Drawing.Point(173, 101);
            this.txt_kitapYazar1.Name = "txt_kitapYazar1";
            this.txt_kitapYazar1.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapYazar1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(30, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kitap Yazar:";
            // 
            // txt_kitapAdi1
            // 
            this.txt_kitapAdi1.Location = new System.Drawing.Point(173, 72);
            this.txt_kitapAdi1.Name = "txt_kitapAdi1";
            this.txt_kitapAdi1.Size = new System.Drawing.Size(200, 20);
            this.txt_kitapAdi1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(30, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kitap Adı:";
            // 
            // dgw_kitaplar
            // 
            this.dgw_kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kitaplar.Location = new System.Drawing.Point(3, 74);
            this.dgw_kitaplar.Name = "dgw_kitaplar";
            this.dgw_kitaplar.ReadOnly = true;
            this.dgw_kitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_kitaplar.Size = new System.Drawing.Size(655, 495);
            this.dgw_kitaplar.TabIndex = 0;
            this.dgw_kitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_kitaplar_CellClick);
            // 
            // cbb_kitapFiltre
            // 
            this.cbb_kitapFiltre.FormattingEnabled = true;
            this.cbb_kitapFiltre.Items.AddRange(new object[] {
            "Kitap Adına Göre Arama",
            "Yazara Göre Arama",
            "Yayınevine Göre Arama",
            "ISBN Göre Arama"});
            this.cbb_kitapFiltre.Location = new System.Drawing.Point(91, 30);
            this.cbb_kitapFiltre.Name = "cbb_kitapFiltre";
            this.cbb_kitapFiltre.Size = new System.Drawing.Size(300, 21);
            this.cbb_kitapFiltre.TabIndex = 9;
            // 
            // txt_kitapFiltre
            // 
            this.txt_kitapFiltre.Location = new System.Drawing.Point(431, 30);
            this.txt_kitapFiltre.MaxLength = 150;
            this.txt_kitapFiltre.Name = "txt_kitapFiltre";
            this.txt_kitapFiltre.Size = new System.Drawing.Size(300, 20);
            this.txt_kitapFiltre.TabIndex = 8;
            this.txt_kitapFiltre.TextChanged += new System.EventHandler(this.txt_kitapFiltre_TextChanged);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 690);
            this.Controls.Add(this.tabControl1);
            this.Name = "KitapIslemleri";
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapYayinevi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kitapISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kitapYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kitapSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_kitapId1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_kitapGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_kitapYayinevi1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_KitapISBN1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_kitapYazar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_kitapAdi1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgw_kitaplar;
        private System.Windows.Forms.TextBox txt_basimTarihi;
        private System.Windows.Forms.TextBox txt_basimTarihi1;
        private System.Windows.Forms.TextBox txt_kitapStokAdet1;
        private System.Windows.Forms.TextBox txt_kitapStokAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_kitapFiltre;
        private System.Windows.Forms.TextBox txt_kitapFiltre;
    }
}