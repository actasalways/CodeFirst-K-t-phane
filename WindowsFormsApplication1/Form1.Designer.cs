namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.dgw_kitap = new System.Windows.Forms.DataGridView();
            this.btn_kitapIslemleri = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbb_kitapFiltre = new System.Windows.Forms.ComboBox();
            this.txt_kitapFiltre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_uyeFiltre = new System.Windows.Forms.TextBox();
            this.cbb_uyeFiltre = new System.Windows.Forms.ComboBox();
            this.dgw_uye = new System.Windows.Forms.DataGridView();
            this.btn_uyeIslemleri = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_alinacakTarih = new System.Windows.Forms.DateTimePicker();
            this.dtp_verilenTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_uyeEkle = new System.Windows.Forms.Button();
            this.txt_uyeTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_uyeSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uyeAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbb_uyeFiltre1 = new System.Windows.Forms.ComboBox();
            this.txt_uyeFiltre1 = new System.Windows.Forms.TextBox();
            this.dgw_uye1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_kitapFiltre1 = new System.Windows.Forms.TextBox();
            this.cbb_kitapFiltre1 = new System.Windows.Forms.ComboBox();
            this.dgw_kitap1 = new System.Windows.Forms.DataGridView();
            this.btn_teslimVer = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgw_kiralanmislar = new System.Windows.Forms.DataGridView();
            this.btn_teslimAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitap)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uye)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uye1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitap1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kiralanmislar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_kitap
            // 
            this.dgw_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kitap.Location = new System.Drawing.Point(35, 130);
            this.dgw_kitap.Name = "dgw_kitap";
            this.dgw_kitap.ReadOnly = true;
            this.dgw_kitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_kitap.Size = new System.Drawing.Size(750, 425);
            this.dgw_kitap.TabIndex = 2;
            // 
            // btn_kitapIslemleri
            // 
            this.btn_kitapIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapIslemleri.Location = new System.Drawing.Point(900, 300);
            this.btn_kitapIslemleri.Name = "btn_kitapIslemleri";
            this.btn_kitapIslemleri.Size = new System.Drawing.Size(200, 90);
            this.btn_kitapIslemleri.TabIndex = 3;
            this.btn_kitapIslemleri.Text = "Kitap İşlemleri";
            this.btn_kitapIslemleri.UseVisualStyleBackColor = true;
            this.btn_kitapIslemleri.Click += new System.EventHandler(this.btn_kitapIslemleri_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 700);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbb_kitapFiltre);
            this.tabPage1.Controls.Add(this.txt_kitapFiltre);
            this.tabPage1.Controls.Add(this.dgw_kitap);
            this.tabPage1.Controls.Add(this.btn_kitapIslemleri);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbb_kitapFiltre
            // 
            this.cbb_kitapFiltre.FormattingEnabled = true;
            this.cbb_kitapFiltre.Items.AddRange(new object[] {
            "Kitap Adına Göre Arama",
            "Yazara Göre Arama",
            "Yayınevine Göre Arama",
            "ISBN Göre Arama"});
            this.cbb_kitapFiltre.Location = new System.Drawing.Point(35, 60);
            this.cbb_kitapFiltre.Name = "cbb_kitapFiltre";
            this.cbb_kitapFiltre.Size = new System.Drawing.Size(300, 21);
            this.cbb_kitapFiltre.TabIndex = 7;
            // 
            // txt_kitapFiltre
            // 
            this.txt_kitapFiltre.Location = new System.Drawing.Point(375, 60);
            this.txt_kitapFiltre.MaxLength = 150;
            this.txt_kitapFiltre.Name = "txt_kitapFiltre";
            this.txt_kitapFiltre.Size = new System.Drawing.Size(300, 20);
            this.txt_kitapFiltre.TabIndex = 6;
            this.txt_kitapFiltre.TextChanged += new System.EventHandler(this.txt_kitapFiltre_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_uyeFiltre);
            this.tabPage2.Controls.Add(this.cbb_uyeFiltre);
            this.tabPage2.Controls.Add(this.dgw_uye);
            this.tabPage2.Controls.Add(this.btn_uyeIslemleri);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Üye";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_uyeFiltre
            // 
            this.txt_uyeFiltre.Location = new System.Drawing.Point(375, 60);
            this.txt_uyeFiltre.MaxLength = 100;
            this.txt_uyeFiltre.Name = "txt_uyeFiltre";
            this.txt_uyeFiltre.Size = new System.Drawing.Size(300, 20);
            this.txt_uyeFiltre.TabIndex = 8;
            this.txt_uyeFiltre.TextChanged += new System.EventHandler(this.txt_uyeFiltre_TextChanged);
            // 
            // cbb_uyeFiltre
            // 
            this.cbb_uyeFiltre.FormattingEnabled = true;
            this.cbb_uyeFiltre.Items.AddRange(new object[] {
            "Üye Adı Ara",
            "Telefon Numarasıyla Ara"});
            this.cbb_uyeFiltre.Location = new System.Drawing.Point(35, 60);
            this.cbb_uyeFiltre.Name = "cbb_uyeFiltre";
            this.cbb_uyeFiltre.Size = new System.Drawing.Size(300, 21);
            this.cbb_uyeFiltre.TabIndex = 7;
            // 
            // dgw_uye
            // 
            this.dgw_uye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_uye.Location = new System.Drawing.Point(35, 130);
            this.dgw_uye.Name = "dgw_uye";
            this.dgw_uye.ReadOnly = true;
            this.dgw_uye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_uye.Size = new System.Drawing.Size(750, 425);
            this.dgw_uye.TabIndex = 4;
            // 
            // btn_uyeIslemleri
            // 
            this.btn_uyeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeIslemleri.Location = new System.Drawing.Point(900, 300);
            this.btn_uyeIslemleri.Name = "btn_uyeIslemleri";
            this.btn_uyeIslemleri.Size = new System.Drawing.Size(200, 90);
            this.btn_uyeIslemleri.TabIndex = 5;
            this.btn_uyeIslemleri.Text = "Üye İşlemleri";
            this.btn_uyeIslemleri.UseVisualStyleBackColor = true;
            this.btn_uyeIslemleri.Click += new System.EventHandler(this.btn_uyeIslemleri_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.btn_teslimVer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 674);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kitap Ver";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_alinacakTarih);
            this.groupBox2.Controls.Add(this.dtp_verilenTarih);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(807, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 213);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zaman Belirle";
            // 
            // dtp_alinacakTarih
            // 
            this.dtp_alinacakTarih.Location = new System.Drawing.Point(178, 108);
            this.dtp_alinacakTarih.Name = "dtp_alinacakTarih";
            this.dtp_alinacakTarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_alinacakTarih.TabIndex = 15;
            // 
            // dtp_verilenTarih
            // 
            this.dtp_verilenTarih.Location = new System.Drawing.Point(178, 61);
            this.dtp_verilenTarih.Name = "dtp_verilenTarih";
            this.dtp_verilenTarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_verilenTarih.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Teslim Alınacak Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Verilen Tarih";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_uyeEkle);
            this.groupBox1.Controls.Add(this.txt_uyeTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_uyeSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_uyeAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(807, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 289);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hızlı Üye Kayıt";
            // 
            // btn_uyeEkle
            // 
            this.btn_uyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeEkle.Location = new System.Drawing.Point(91, 174);
            this.btn_uyeEkle.Name = "btn_uyeEkle";
            this.btn_uyeEkle.Size = new System.Drawing.Size(186, 68);
            this.btn_uyeEkle.TabIndex = 7;
            this.btn_uyeEkle.Text = "Üye Kaydet";
            this.btn_uyeEkle.UseVisualStyleBackColor = true;
            this.btn_uyeEkle.Click += new System.EventHandler(this.btn_uyeEkle_Click);
            // 
            // txt_uyeTelefon
            // 
            this.txt_uyeTelefon.Location = new System.Drawing.Point(178, 124);
            this.txt_uyeTelefon.MaxLength = 20;
            this.txt_uyeTelefon.Name = "txt_uyeTelefon";
            this.txt_uyeTelefon.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeTelefon.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Üye Telefon";
            // 
            // txt_uyeSoyad
            // 
            this.txt_uyeSoyad.Location = new System.Drawing.Point(178, 91);
            this.txt_uyeSoyad.MaxLength = 40;
            this.txt_uyeSoyad.Name = "txt_uyeSoyad";
            this.txt_uyeSoyad.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeSoyad.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Üye Soyad";
            // 
            // txt_uyeAd
            // 
            this.txt_uyeAd.Location = new System.Drawing.Point(178, 62);
            this.txt_uyeAd.MaxLength = 40;
            this.txt_uyeAd.Name = "txt_uyeAd";
            this.txt_uyeAd.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeAd.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Üye Ad :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbb_uyeFiltre1);
            this.groupBox5.Controls.Add(this.txt_uyeFiltre1);
            this.groupBox5.Controls.Add(this.dgw_uye1);
            this.groupBox5.Location = new System.Drawing.Point(8, 311);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(792, 339);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Üye Seç";
            // 
            // cbb_uyeFiltre1
            // 
            this.cbb_uyeFiltre1.FormattingEnabled = true;
            this.cbb_uyeFiltre1.Items.AddRange(new object[] {
            "Üye Adı Ara",
            "Telefon Numarasıyla Ara"});
            this.cbb_uyeFiltre1.Location = new System.Drawing.Point(6, 30);
            this.cbb_uyeFiltre1.Name = "cbb_uyeFiltre1";
            this.cbb_uyeFiltre1.Size = new System.Drawing.Size(300, 21);
            this.cbb_uyeFiltre1.TabIndex = 13;
            // 
            // txt_uyeFiltre1
            // 
            this.txt_uyeFiltre1.Location = new System.Drawing.Point(321, 31);
            this.txt_uyeFiltre1.MaxLength = 150;
            this.txt_uyeFiltre1.Name = "txt_uyeFiltre1";
            this.txt_uyeFiltre1.Size = new System.Drawing.Size(300, 20);
            this.txt_uyeFiltre1.TabIndex = 9;
            this.txt_uyeFiltre1.TextChanged += new System.EventHandler(this.txt_uyeFiltre1_TextChanged);
            // 
            // dgw_uye1
            // 
            this.dgw_uye1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_uye1.Location = new System.Drawing.Point(12, 74);
            this.dgw_uye1.Name = "dgw_uye1";
            this.dgw_uye1.ReadOnly = true;
            this.dgw_uye1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_uye1.Size = new System.Drawing.Size(726, 182);
            this.dgw_uye1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_kitapFiltre1);
            this.groupBox3.Controls.Add(this.cbb_kitapFiltre1);
            this.groupBox3.Controls.Add(this.dgw_kitap1);
            this.groupBox3.Location = new System.Drawing.Point(8, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 289);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Seç";
            // 
            // txt_kitapFiltre1
            // 
            this.txt_kitapFiltre1.Location = new System.Drawing.Point(321, 31);
            this.txt_kitapFiltre1.MaxLength = 100;
            this.txt_kitapFiltre1.Name = "txt_kitapFiltre1";
            this.txt_kitapFiltre1.Size = new System.Drawing.Size(300, 20);
            this.txt_kitapFiltre1.TabIndex = 9;
            this.txt_kitapFiltre1.TextChanged += new System.EventHandler(this.txt_kitapFiltre1_TextChanged);
            // 
            // cbb_kitapFiltre1
            // 
            this.cbb_kitapFiltre1.FormattingEnabled = true;
            this.cbb_kitapFiltre1.Items.AddRange(new object[] {
            "Kitap Adına Göre Arama",
            "Yazara Göre Arama",
            "Yayınevine Göre Arama",
            "ISBN Göre Arama"});
            this.cbb_kitapFiltre1.Location = new System.Drawing.Point(6, 31);
            this.cbb_kitapFiltre1.Name = "cbb_kitapFiltre1";
            this.cbb_kitapFiltre1.Size = new System.Drawing.Size(300, 21);
            this.cbb_kitapFiltre1.TabIndex = 10;
            // 
            // dgw_kitap1
            // 
            this.dgw_kitap1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kitap1.Location = new System.Drawing.Point(12, 74);
            this.dgw_kitap1.Name = "dgw_kitap1";
            this.dgw_kitap1.ReadOnly = true;
            this.dgw_kitap1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_kitap1.Size = new System.Drawing.Size(726, 182);
            this.dgw_kitap1.TabIndex = 1;
            // 
            // btn_teslimVer
            // 
            this.btn_teslimVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teslimVer.Location = new System.Drawing.Point(888, 558);
            this.btn_teslimVer.Name = "btn_teslimVer";
            this.btn_teslimVer.Size = new System.Drawing.Size(248, 92);
            this.btn_teslimVer.TabIndex = 3;
            this.btn_teslimVer.Text = "Seçiliyi Seçiliye Teslim Et";
            this.btn_teslimVer.UseVisualStyleBackColor = true;
            this.btn_teslimVer.Click += new System.EventHandler(this.btn_teslim_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_teslimAl);
            this.tabPage4.Controls.Add(this.dgw_kiralanmislar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1232, 674);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Teslim Al";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgw_kiralanmislar
            // 
            this.dgw_kiralanmislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kiralanmislar.Location = new System.Drawing.Point(35, 130);
            this.dgw_kiralanmislar.Name = "dgw_kiralanmislar";
            this.dgw_kiralanmislar.ReadOnly = true;
            this.dgw_kiralanmislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_kiralanmislar.Size = new System.Drawing.Size(750, 425);
            this.dgw_kiralanmislar.TabIndex = 0;
            // 
            // btn_teslimAl
            // 
            this.btn_teslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teslimAl.Location = new System.Drawing.Point(900, 300);
            this.btn_teslimAl.Name = "btn_teslimAl";
            this.btn_teslimAl.Size = new System.Drawing.Size(200, 90);
            this.btn_teslimAl.TabIndex = 1;
            this.btn_teslimAl.Text = "Kitabı Teslim Al";
            this.btn_teslimAl.UseVisualStyleBackColor = true;
            this.btn_teslimAl.Click += new System.EventHandler(this.btn_teslimAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 722);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görevli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitap)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uye)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uye1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitap1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kiralanmislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgw_kitap;
        private System.Windows.Forms.Button btn_kitapIslemleri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgw_uye;
        private System.Windows.Forms.Button btn_uyeIslemleri;
        private System.Windows.Forms.ComboBox cbb_kitapFiltre;
        private System.Windows.Forms.TextBox txt_kitapFiltre;
        private System.Windows.Forms.TextBox txt_uyeFiltre;
        private System.Windows.Forms.ComboBox cbb_uyeFiltre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_teslimVer;
        private System.Windows.Forms.DataGridView dgw_kitap1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_uyeFiltre1;
        private System.Windows.Forms.DataGridView dgw_uye1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_kitapFiltre1;
        private System.Windows.Forms.ComboBox cbb_kitapFiltre1;
        private System.Windows.Forms.ComboBox cbb_uyeFiltre1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgw_kiralanmislar;
        private System.Windows.Forms.Button btn_uyeEkle;
        private System.Windows.Forms.TextBox txt_uyeTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_uyeSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uyeAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_alinacakTarih;
        private System.Windows.Forms.DateTimePicker dtp_verilenTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_teslimAl;
    }
}

