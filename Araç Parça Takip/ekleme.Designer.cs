namespace Araç_Parça_Takip
{
    partial class ekleme
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
            this.parca_bilgleri_giris = new System.Windows.Forms.GroupBox();
            this.listeye_ekle_buton = new System.Windows.Forms.Button();
            this.parca_ekle_buton = new System.Windows.Forms.Button();
            this.temizle_buton = new System.Windows.Forms.Button();
            this.arabalar_listesi = new System.Windows.Forms.ListBox();
            this.hepsini_ekle_buton = new System.Windows.Forms.Button();
            this.model_sec_cmb = new System.Windows.Forms.ComboBox();
            this.marka_sec_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parca_adet_txtb = new System.Windows.Forms.TextBox();
            this.parca_marka_txtb = new System.Windows.Forms.TextBox();
            this.parca_turu_txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arac_ekleme = new System.Windows.Forms.GroupBox();
            this.arac_ekle_buton = new System.Windows.Forms.Button();
            this.arac_model_txtb = new System.Windows.Forms.TextBox();
            this.arac_marka_txtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.parca_bilgleri_giris.SuspendLayout();
            this.arac_ekleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // parca_bilgleri_giris
            // 
            this.parca_bilgleri_giris.Controls.Add(this.listeye_ekle_buton);
            this.parca_bilgleri_giris.Controls.Add(this.parca_ekle_buton);
            this.parca_bilgleri_giris.Controls.Add(this.temizle_buton);
            this.parca_bilgleri_giris.Controls.Add(this.arabalar_listesi);
            this.parca_bilgleri_giris.Controls.Add(this.hepsini_ekle_buton);
            this.parca_bilgleri_giris.Controls.Add(this.model_sec_cmb);
            this.parca_bilgleri_giris.Controls.Add(this.marka_sec_cmb);
            this.parca_bilgleri_giris.Controls.Add(this.label6);
            this.parca_bilgleri_giris.Controls.Add(this.label5);
            this.parca_bilgleri_giris.Controls.Add(this.label4);
            this.parca_bilgleri_giris.Controls.Add(this.parca_adet_txtb);
            this.parca_bilgleri_giris.Controls.Add(this.parca_marka_txtb);
            this.parca_bilgleri_giris.Controls.Add(this.parca_turu_txtb);
            this.parca_bilgleri_giris.Controls.Add(this.label3);
            this.parca_bilgleri_giris.Controls.Add(this.label2);
            this.parca_bilgleri_giris.Controls.Add(this.label1);
            this.parca_bilgleri_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parca_bilgleri_giris.ForeColor = System.Drawing.Color.Blue;
            this.parca_bilgleri_giris.Location = new System.Drawing.Point(13, 13);
            this.parca_bilgleri_giris.Name = "parca_bilgleri_giris";
            this.parca_bilgleri_giris.Size = new System.Drawing.Size(704, 218);
            this.parca_bilgleri_giris.TabIndex = 0;
            this.parca_bilgleri_giris.TabStop = false;
            this.parca_bilgleri_giris.Text = "Parça Bilgileri";
            // 
            // listeye_ekle_buton
            // 
            this.listeye_ekle_buton.Location = new System.Drawing.Point(344, 177);
            this.listeye_ekle_buton.Name = "listeye_ekle_buton";
            this.listeye_ekle_buton.Size = new System.Drawing.Size(199, 23);
            this.listeye_ekle_buton.TabIndex = 14;
            this.listeye_ekle_buton.Text = "Listeye Ekle";
            this.listeye_ekle_buton.UseVisualStyleBackColor = true;
            this.listeye_ekle_buton.Click += new System.EventHandler(this.listeye_ekle_buton_Click);
            // 
            // parca_ekle_buton
            // 
            this.parca_ekle_buton.Location = new System.Drawing.Point(549, 150);
            this.parca_ekle_buton.Name = "parca_ekle_buton";
            this.parca_ekle_buton.Size = new System.Drawing.Size(126, 50);
            this.parca_ekle_buton.TabIndex = 13;
            this.parca_ekle_buton.Text = "Parça Ekle";
            this.parca_ekle_buton.UseVisualStyleBackColor = true;
            this.parca_ekle_buton.Click += new System.EventHandler(this.parca_ekle_buton_Click);
            // 
            // temizle_buton
            // 
            this.temizle_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.temizle_buton.Location = new System.Drawing.Point(549, 102);
            this.temizle_buton.Name = "temizle_buton";
            this.temizle_buton.Size = new System.Drawing.Size(126, 23);
            this.temizle_buton.TabIndex = 12;
            this.temizle_buton.Text = "<< Temizle";
            this.temizle_buton.UseVisualStyleBackColor = true;
            this.temizle_buton.Click += new System.EventHandler(this.temizle_buton_Click);
            // 
            // arabalar_listesi
            // 
            this.arabalar_listesi.FormattingEnabled = true;
            this.arabalar_listesi.ItemHeight = 15;
            this.arabalar_listesi.Location = new System.Drawing.Point(344, 102);
            this.arabalar_listesi.Name = "arabalar_listesi";
            this.arabalar_listesi.Size = new System.Drawing.Size(199, 64);
            this.arabalar_listesi.TabIndex = 11;
            this.arabalar_listesi.DoubleClick += new System.EventHandler(this.arabalar_listesi_DoubleClick);
            // 
            // hepsini_ekle_buton
            // 
            this.hepsini_ekle_buton.BackColor = System.Drawing.Color.Maroon;
            this.hepsini_ekle_buton.ForeColor = System.Drawing.Color.White;
            this.hepsini_ekle_buton.Location = new System.Drawing.Point(6, 177);
            this.hepsini_ekle_buton.Name = "hepsini_ekle_buton";
            this.hepsini_ekle_buton.Size = new System.Drawing.Size(332, 23);
            this.hepsini_ekle_buton.TabIndex = 10;
            this.hepsini_ekle_buton.Text = "Hepsini Ekle (Tüm Arabalar İle Uyumlu Olacaksa)";
            this.hepsini_ekle_buton.UseVisualStyleBackColor = false;
            this.hepsini_ekle_buton.Click += new System.EventHandler(this.hepsini_ekle_buton_Click);
            // 
            // model_sec_cmb
            // 
            this.model_sec_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_sec_cmb.FormattingEnabled = true;
            this.model_sec_cmb.Location = new System.Drawing.Point(162, 143);
            this.model_sec_cmb.Name = "model_sec_cmb";
            this.model_sec_cmb.Size = new System.Drawing.Size(166, 23);
            this.model_sec_cmb.TabIndex = 9;
            this.model_sec_cmb.Click += new System.EventHandler(this.model_sec_cmb_Click);
            // 
            // marka_sec_cmb
            // 
            this.marka_sec_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marka_sec_cmb.FormattingEnabled = true;
            this.marka_sec_cmb.Location = new System.Drawing.Point(162, 102);
            this.marka_sec_cmb.Name = "marka_sec_cmb";
            this.marka_sec_cmb.Size = new System.Drawing.Size(166, 23);
            this.marka_sec_cmb.TabIndex = 8;
            this.marka_sec_cmb.Click += new System.EventHandler(this.marka_sec_cmb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Modelini Seçiniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Markasını Seçiniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parçanın Kullanılacağı Araçlar";
            // 
            // parca_adet_txtb
            // 
            this.parca_adet_txtb.Location = new System.Drawing.Point(571, 30);
            this.parca_adet_txtb.Name = "parca_adet_txtb";
            this.parca_adet_txtb.Size = new System.Drawing.Size(104, 21);
            this.parca_adet_txtb.TabIndex = 5;
            // 
            // parca_marka_txtb
            // 
            this.parca_marka_txtb.Location = new System.Drawing.Point(334, 30);
            this.parca_marka_txtb.Name = "parca_marka_txtb";
            this.parca_marka_txtb.Size = new System.Drawing.Size(145, 21);
            this.parca_marka_txtb.TabIndex = 4;
            // 
            // parca_turu_txtb
            // 
            this.parca_turu_txtb.Location = new System.Drawing.Point(102, 30);
            this.parca_turu_txtb.Name = "parca_turu_txtb";
            this.parca_turu_txtb.Size = new System.Drawing.Size(128, 21);
            this.parca_turu_txtb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(485, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parça Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(236, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parça Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parça Türü:";
            // 
            // arac_ekleme
            // 
            this.arac_ekleme.Controls.Add(this.arac_ekle_buton);
            this.arac_ekleme.Controls.Add(this.arac_model_txtb);
            this.arac_ekleme.Controls.Add(this.arac_marka_txtb);
            this.arac_ekleme.Controls.Add(this.label8);
            this.arac_ekleme.Controls.Add(this.label7);
            this.arac_ekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arac_ekleme.ForeColor = System.Drawing.Color.Blue;
            this.arac_ekleme.Location = new System.Drawing.Point(13, 237);
            this.arac_ekleme.Name = "arac_ekleme";
            this.arac_ekleme.Size = new System.Drawing.Size(704, 72);
            this.arac_ekleme.TabIndex = 1;
            this.arac_ekleme.TabStop = false;
            this.arac_ekleme.Text = "Araç Bilgileri";
            // 
            // arac_ekle_buton
            // 
            this.arac_ekle_buton.Location = new System.Drawing.Point(559, 26);
            this.arac_ekle_buton.Name = "arac_ekle_buton";
            this.arac_ekle_buton.Size = new System.Drawing.Size(126, 32);
            this.arac_ekle_buton.TabIndex = 5;
            this.arac_ekle_buton.Text = "Araç Ekle";
            this.arac_ekle_buton.UseVisualStyleBackColor = true;
            this.arac_ekle_buton.Click += new System.EventHandler(this.arac_ekle_buton_Click);
            // 
            // arac_model_txtb
            // 
            this.arac_model_txtb.Location = new System.Drawing.Point(391, 31);
            this.arac_model_txtb.Name = "arac_model_txtb";
            this.arac_model_txtb.Size = new System.Drawing.Size(152, 22);
            this.arac_model_txtb.TabIndex = 4;
            // 
            // arac_marka_txtb
            // 
            this.arac_marka_txtb.Location = new System.Drawing.Point(130, 31);
            this.arac_marka_txtb.Name = "arac_marka_txtb";
            this.arac_marka_txtb.Size = new System.Drawing.Size(140, 22);
            this.arac_marka_txtb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(290, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Araç Modeli:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araç Markası:";
            // 
            // ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 324);
            this.Controls.Add(this.arac_ekleme);
            this.Controls.Add(this.parca_bilgleri_giris);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ekleme";
            this.Text = "ekleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ekleme_FormClosed);
            this.Load += new System.EventHandler(this.ekleme_Load);
            this.parca_bilgleri_giris.ResumeLayout(false);
            this.parca_bilgleri_giris.PerformLayout();
            this.arac_ekleme.ResumeLayout(false);
            this.arac_ekleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox parca_bilgleri_giris;
        private System.Windows.Forms.TextBox parca_adet_txtb;
        private System.Windows.Forms.TextBox parca_marka_txtb;
        private System.Windows.Forms.TextBox parca_turu_txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox model_sec_cmb;
        private System.Windows.Forms.ComboBox marka_sec_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button listeye_ekle_buton;
        private System.Windows.Forms.Button parca_ekle_buton;
        private System.Windows.Forms.Button temizle_buton;
        private System.Windows.Forms.ListBox arabalar_listesi;
        private System.Windows.Forms.Button hepsini_ekle_buton;
        private System.Windows.Forms.GroupBox arac_ekleme;
        private System.Windows.Forms.Button arac_ekle_buton;
        private System.Windows.Forms.TextBox arac_model_txtb;
        private System.Windows.Forms.TextBox arac_marka_txtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}