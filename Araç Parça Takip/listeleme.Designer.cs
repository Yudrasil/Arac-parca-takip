namespace Araç_Parça_Takip
{
    partial class listeleme
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iŞLEMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniAraçVeyaParçaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.araçVeyaParçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.araçVeyaParçaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.stokListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parca_arama = new System.Windows.Forms.RadioButton();
            this.araba_arama = new System.Windows.Forms.RadioButton();
            this.parca_arama_gb = new System.Windows.Forms.GroupBox();
            this.parca_arama_listele = new System.Windows.Forms.Button();
            this.parca_arama_marka = new System.Windows.Forms.ComboBox();
            this.parca_arama_turu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arac_arama_gb = new System.Windows.Forms.GroupBox();
            this.arac_arama_listele = new System.Windows.Forms.Button();
            this.arac_arama_model = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arac_arama_marka = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.parca_arama_gb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.arac_arama_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iŞLEMLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            this.iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniAraçVeyaParçaEkleToolStripMenuItem,
            this.toolStripSeparator1,
            this.araçVeyaParçaToolStripMenuItem,
            this.toolStripSeparator2,
            this.araçVeyaParçaSilToolStripMenuItem,
            this.toolStripSeparator3,
            this.stokListesiToolStripMenuItem});
            this.iŞLEMLERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iŞLEMLERToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            this.iŞLEMLERToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // yeniAraçVeyaParçaEkleToolStripMenuItem
            // 
            this.yeniAraçVeyaParçaEkleToolStripMenuItem.Name = "yeniAraçVeyaParçaEkleToolStripMenuItem";
            this.yeniAraçVeyaParçaEkleToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.yeniAraçVeyaParçaEkleToolStripMenuItem.Text = "Yeni Araç Veya Parça Ekle";
            this.yeniAraçVeyaParçaEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniAraçVeyaParçaEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // araçVeyaParçaToolStripMenuItem
            // 
            this.araçVeyaParçaToolStripMenuItem.Name = "araçVeyaParçaToolStripMenuItem";
            this.araçVeyaParçaToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.araçVeyaParçaToolStripMenuItem.Text = "Araç Veya Parça Güncelle";
            this.araçVeyaParçaToolStripMenuItem.Click += new System.EventHandler(this.araçVeyaParçaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // araçVeyaParçaSilToolStripMenuItem
            // 
            this.araçVeyaParçaSilToolStripMenuItem.Name = "araçVeyaParçaSilToolStripMenuItem";
            this.araçVeyaParçaSilToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.araçVeyaParçaSilToolStripMenuItem.Text = "Araç Veya Parça Sil";
            this.araçVeyaParçaSilToolStripMenuItem.Click += new System.EventHandler(this.araçVeyaParçaSilToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(247, 6);
            // 
            // stokListesiToolStripMenuItem
            // 
            this.stokListesiToolStripMenuItem.Name = "stokListesiToolStripMenuItem";
            this.stokListesiToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.stokListesiToolStripMenuItem.Text = "Stok Listesi";
            this.stokListesiToolStripMenuItem.Click += new System.EventHandler(this.stokListesiToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parca_arama);
            this.groupBox1.Controls.Add(this.araba_arama);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Seçenekleri";
            // 
            // parca_arama
            // 
            this.parca_arama.AutoSize = true;
            this.parca_arama.ForeColor = System.Drawing.Color.Black;
            this.parca_arama.Location = new System.Drawing.Point(179, 20);
            this.parca_arama.Name = "parca_arama";
            this.parca_arama.Size = new System.Drawing.Size(170, 20);
            this.parca_arama.TabIndex = 1;
            this.parca_arama.TabStop = true;
            this.parca_arama.Text = "Parçaya Göre Arama";
            this.parca_arama.UseVisualStyleBackColor = true;
            // 
            // araba_arama
            // 
            this.araba_arama.AutoSize = true;
            this.araba_arama.ForeColor = System.Drawing.Color.Black;
            this.araba_arama.Location = new System.Drawing.Point(6, 20);
            this.araba_arama.Name = "araba_arama";
            this.araba_arama.Size = new System.Drawing.Size(150, 20);
            this.araba_arama.TabIndex = 0;
            this.araba_arama.TabStop = true;
            this.araba_arama.Text = "Arabaya Göre Ara";
            this.araba_arama.UseVisualStyleBackColor = true;
            // 
            // parca_arama_gb
            // 
            this.parca_arama_gb.Controls.Add(this.parca_arama_listele);
            this.parca_arama_gb.Controls.Add(this.parca_arama_marka);
            this.parca_arama_gb.Controls.Add(this.parca_arama_turu);
            this.parca_arama_gb.Controls.Add(this.label2);
            this.parca_arama_gb.Controls.Add(this.label1);
            this.parca_arama_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.parca_arama_gb.ForeColor = System.Drawing.Color.Blue;
            this.parca_arama_gb.Location = new System.Drawing.Point(13, 83);
            this.parca_arama_gb.Name = "parca_arama_gb";
            this.parca_arama_gb.Size = new System.Drawing.Size(732, 67);
            this.parca_arama_gb.TabIndex = 2;
            this.parca_arama_gb.TabStop = false;
            this.parca_arama_gb.Text = "Parçaya Göre Araç Ara";
            // 
            // parca_arama_listele
            // 
            this.parca_arama_listele.Location = new System.Drawing.Point(603, 25);
            this.parca_arama_listele.Name = "parca_arama_listele";
            this.parca_arama_listele.Size = new System.Drawing.Size(87, 23);
            this.parca_arama_listele.TabIndex = 4;
            this.parca_arama_listele.Text = "LİSTELE";
            this.parca_arama_listele.UseVisualStyleBackColor = true;
            this.parca_arama_listele.Click += new System.EventHandler(this.parca_arama_listele_Click);
            // 
            // parca_arama_marka
            // 
            this.parca_arama_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parca_arama_marka.FormattingEnabled = true;
            this.parca_arama_marka.Location = new System.Drawing.Point(430, 25);
            this.parca_arama_marka.Name = "parca_arama_marka";
            this.parca_arama_marka.Size = new System.Drawing.Size(154, 24);
            this.parca_arama_marka.TabIndex = 3;
            this.parca_arama_marka.Click += new System.EventHandler(this.parca_arama_marka_Click);
            // 
            // parca_arama_turu
            // 
            this.parca_arama_turu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parca_arama_turu.FormattingEnabled = true;
            this.parca_arama_turu.Location = new System.Drawing.Point(128, 25);
            this.parca_arama_turu.Name = "parca_arama_turu";
            this.parca_arama_turu.Size = new System.Drawing.Size(136, 24);
            this.parca_arama_turu.TabIndex = 2;
            this.parca_arama_turu.Click += new System.EventHandler(this.parca_arama_turu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(291, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Markasını Seçiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türünü Seçiniz:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(13, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 235);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama Sonuçları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // arac_arama_gb
            // 
            this.arac_arama_gb.Controls.Add(this.arac_arama_listele);
            this.arac_arama_gb.Controls.Add(this.arac_arama_model);
            this.arac_arama_gb.Controls.Add(this.label4);
            this.arac_arama_gb.Controls.Add(this.label3);
            this.arac_arama_gb.Controls.Add(this.arac_arama_marka);
            this.arac_arama_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arac_arama_gb.ForeColor = System.Drawing.Color.Blue;
            this.arac_arama_gb.Location = new System.Drawing.Point(12, 165);
            this.arac_arama_gb.Name = "arac_arama_gb";
            this.arac_arama_gb.Size = new System.Drawing.Size(732, 89);
            this.arac_arama_gb.TabIndex = 4;
            this.arac_arama_gb.TabStop = false;
            this.arac_arama_gb.Text = "Araca Göre Parça Ara";
            // 
            // arac_arama_listele
            // 
            this.arac_arama_listele.Location = new System.Drawing.Point(603, 31);
            this.arac_arama_listele.Name = "arac_arama_listele";
            this.arac_arama_listele.Size = new System.Drawing.Size(87, 23);
            this.arac_arama_listele.TabIndex = 4;
            this.arac_arama_listele.Text = "LİSTELE";
            this.arac_arama_listele.UseVisualStyleBackColor = true;
            this.arac_arama_listele.Click += new System.EventHandler(this.arac_arama_listele_Click);
            // 
            // arac_arama_model
            // 
            this.arac_arama_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arac_arama_model.FormattingEnabled = true;
            this.arac_arama_model.Location = new System.Drawing.Point(430, 31);
            this.arac_arama_model.Name = "arac_arama_model";
            this.arac_arama_model.Size = new System.Drawing.Size(154, 24);
            this.arac_arama_model.TabIndex = 3;
            this.arac_arama_model.Click += new System.EventHandler(this.arac_arama_model_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(299, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Modelini Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Markasını Seçiniz:";
            // 
            // arac_arama_marka
            // 
            this.arac_arama_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arac_arama_marka.FormattingEnabled = true;
            this.arac_arama_marka.Location = new System.Drawing.Point(148, 31);
            this.arac_arama_marka.Name = "arac_arama_marka";
            this.arac_arama_marka.Size = new System.Drawing.Size(136, 24);
            this.arac_arama_marka.TabIndex = 2;
            this.arac_arama_marka.Click += new System.EventHandler(this.arac_arama_marka_Click);
            // 
            // listeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 527);
            this.Controls.Add(this.arac_arama_gb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.parca_arama_gb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listeleme";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.listeleme_FormClosed);
            this.Load += new System.EventHandler(this.listeleme_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.parca_arama_gb.ResumeLayout(false);
            this.parca_arama_gb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.arac_arama_gb.ResumeLayout(false);
            this.arac_arama_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton parca_arama;
        private System.Windows.Forms.RadioButton araba_arama;
        private System.Windows.Forms.GroupBox parca_arama_gb;
        private System.Windows.Forms.Button parca_arama_listele;
        private System.Windows.Forms.ComboBox parca_arama_marka;
        private System.Windows.Forms.ComboBox parca_arama_turu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox arac_arama_gb;
        private System.Windows.Forms.Button arac_arama_listele;
        private System.Windows.Forms.ComboBox arac_arama_model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox arac_arama_marka;
        private System.Windows.Forms.ToolStripMenuItem yeniAraçVeyaParçaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem araçVeyaParçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem araçVeyaParçaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem stokListesiToolStripMenuItem;
    }
}

