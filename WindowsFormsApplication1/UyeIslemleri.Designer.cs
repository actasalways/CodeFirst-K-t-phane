namespace WindowsFormsApplication1
{
    partial class UyeIslemleri
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
            this.btn_uyeEkle = new System.Windows.Forms.Button();
            this.txt_uyeTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_uyeSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uyeAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_uyeCeza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_uyeSil = new System.Windows.Forms.Button();
            this.txt_uyeId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_uyeGuncelle = new System.Windows.Forms.Button();
            this.txt_uyeTelefon1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_uyeSoyad1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_uyeAd1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgw_uyeler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uyeler)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üye Ekleme";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(120, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 550);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_uyeEkle
            // 
            this.btn_uyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeEkle.Location = new System.Drawing.Point(283, 275);
            this.btn_uyeEkle.Name = "btn_uyeEkle";
            this.btn_uyeEkle.Size = new System.Drawing.Size(186, 68);
            this.btn_uyeEkle.TabIndex = 1;
            this.btn_uyeEkle.Text = "Üye Kaydet";
            this.btn_uyeEkle.UseVisualStyleBackColor = true;
            this.btn_uyeEkle.Click += new System.EventHandler(this.btn_uyeEkle_Click);
            // 
            // txt_uyeTelefon
            // 
            this.txt_uyeTelefon.Location = new System.Drawing.Point(346, 166);
            this.txt_uyeTelefon.MaxLength = 20;
            this.txt_uyeTelefon.Name = "txt_uyeTelefon";
            this.txt_uyeTelefon.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeTelefon.TabIndex = 5;
            this.txt_uyeTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_uyeTelefon_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(203, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Üye Telefon";
            // 
            // txt_uyeSoyad
            // 
            this.txt_uyeSoyad.Location = new System.Drawing.Point(346, 133);
            this.txt_uyeSoyad.MaxLength = 40;
            this.txt_uyeSoyad.Name = "txt_uyeSoyad";
            this.txt_uyeSoyad.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(203, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üye Soyad";
            // 
            // txt_uyeAd
            // 
            this.txt_uyeAd.Location = new System.Drawing.Point(346, 104);
            this.txt_uyeAd.MaxLength = 40;
            this.txt_uyeAd.Name = "txt_uyeAd";
            this.txt_uyeAd.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(203, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Ad :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Üye Bilgileri Düzenle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgw_uyeler);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1107, 625);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_uyeCeza);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_uyeSil);
            this.groupBox3.Controls.Add(this.txt_uyeId);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn_uyeGuncelle);
            this.groupBox3.Controls.Add(this.txt_uyeTelefon1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_uyeSoyad1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_uyeAd1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(689, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 581);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // txt_uyeCeza
            // 
            this.txt_uyeCeza.Location = new System.Drawing.Point(177, 255);
            this.txt_uyeCeza.Name = "txt_uyeCeza";
            this.txt_uyeCeza.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeCeza.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Üye Ceza";
            // 
            // btn_uyeSil
            // 
            this.btn_uyeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeSil.Location = new System.Drawing.Point(133, 430);
            this.btn_uyeSil.Name = "btn_uyeSil";
            this.btn_uyeSil.Size = new System.Drawing.Size(156, 67);
            this.btn_uyeSil.TabIndex = 5;
            this.btn_uyeSil.Text = "Üye Sil";
            this.btn_uyeSil.UseVisualStyleBackColor = true;
            this.btn_uyeSil.Click += new System.EventHandler(this.btn_uyeSil_Click);
            // 
            // txt_uyeId
            // 
            this.txt_uyeId.Enabled = false;
            this.txt_uyeId.Location = new System.Drawing.Point(177, 119);
            this.txt_uyeId.Name = "txt_uyeId";
            this.txt_uyeId.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeId.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(34, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Üye ID";
            // 
            // btn_uyeGuncelle
            // 
            this.btn_uyeGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeGuncelle.Location = new System.Drawing.Point(112, 336);
            this.btn_uyeGuncelle.Name = "btn_uyeGuncelle";
            this.btn_uyeGuncelle.Size = new System.Drawing.Size(200, 68);
            this.btn_uyeGuncelle.TabIndex = 1;
            this.btn_uyeGuncelle.Text = "Üye Bilgilerini Güncelle";
            this.btn_uyeGuncelle.UseVisualStyleBackColor = true;
            this.btn_uyeGuncelle.Click += new System.EventHandler(this.btn_uyeGuncelle_Click);
            // 
            // txt_uyeTelefon1
            // 
            this.txt_uyeTelefon1.Location = new System.Drawing.Point(177, 213);
            this.txt_uyeTelefon1.Name = "txt_uyeTelefon1";
            this.txt_uyeTelefon1.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeTelefon1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(34, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Üye Telefon";
            // 
            // txt_uyeSoyad1
            // 
            this.txt_uyeSoyad1.Location = new System.Drawing.Point(177, 180);
            this.txt_uyeSoyad1.Name = "txt_uyeSoyad1";
            this.txt_uyeSoyad1.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeSoyad1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(34, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Üye Soyad";
            // 
            // txt_uyeAd1
            // 
            this.txt_uyeAd1.Location = new System.Drawing.Point(177, 151);
            this.txt_uyeAd1.Name = "txt_uyeAd1";
            this.txt_uyeAd1.Size = new System.Drawing.Size(200, 20);
            this.txt_uyeAd1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(34, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Üye Ad";
            // 
            // dgw_uyeler
            // 
            this.dgw_uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_uyeler.Location = new System.Drawing.Point(3, 16);
            this.dgw_uyeler.Name = "dgw_uyeler";
            this.dgw_uyeler.ReadOnly = true;
            this.dgw_uyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_uyeler.Size = new System.Drawing.Size(655, 584);
            this.dgw_uyeler.TabIndex = 0;
            this.dgw_uyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_uyeler_CellClick);
            // 
            // UyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 689);
            this.Controls.Add(this.tabControl1);
            this.Name = "UyeIslemleri";
            this.Text = "UyeIslemleri";
            this.Load += new System.EventHandler(this.UyeIslemleri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uyeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_uyeEkle;
        private System.Windows.Forms.TextBox txt_uyeTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_uyeSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uyeAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_uyeSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_uyeId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_uyeGuncelle;
        private System.Windows.Forms.TextBox txt_uyeTelefon1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_uyeSoyad1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_uyeAd1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgw_uyeler;
        private System.Windows.Forms.TextBox txt_uyeCeza;
        private System.Windows.Forms.Label label3;
    }
}