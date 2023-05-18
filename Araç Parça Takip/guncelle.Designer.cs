namespace Araç_Parça_Takip
{
    partial class guncelle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbP_Tur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbP_Marka = new System.Windows.Forms.ComboBox();
            this.txtParca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbChange = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtStok = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtStok);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.rbAdd);
            this.groupBox1.Controls.Add(this.rbChange);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtParca);
            this.groupBox1.Controls.Add(this.cbP_Marka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbP_Tur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parçaya Göre Araç Arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türünü Seçiniz:";
            // 
            // cbP_Tur
            // 
            this.cbP_Tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP_Tur.FormattingEnabled = true;
            this.cbP_Tur.Location = new System.Drawing.Point(148, 31);
            this.cbP_Tur.Name = "cbP_Tur";
            this.cbP_Tur.Size = new System.Drawing.Size(180, 26);
            this.cbP_Tur.TabIndex = 1;
            this.cbP_Tur.Click += new System.EventHandler(this.cbP_Tur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(351, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Markasın Seçiniz:";
            // 
            // cbP_Marka
            // 
            this.cbP_Marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP_Marka.FormattingEnabled = true;
            this.cbP_Marka.Location = new System.Drawing.Point(486, 31);
            this.cbP_Marka.Name = "cbP_Marka";
            this.cbP_Marka.Size = new System.Drawing.Size(151, 26);
            this.cbP_Marka.TabIndex = 3;
            this.cbP_Marka.SelectedIndexChanged += new System.EventHandler(this.cbP_Marka_SelectedIndexChanged);
            this.cbP_Marka.Click += new System.EventHandler(this.cbP_Marka_Click);
            // 
            // txtParca
            // 
            this.txtParca.AutoSize = true;
            this.txtParca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParca.Location = new System.Drawing.Point(657, 34);
            this.txtParca.Name = "txtParca";
            this.txtParca.Size = new System.Drawing.Size(44, 16);
            this.txtParca.TabIndex = 4;
            this.txtParca.Text = "Adet:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(710, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // rbChange
            // 
            this.rbChange.AutoSize = true;
            this.rbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbChange.Location = new System.Drawing.Point(20, 67);
            this.rbChange.Name = "rbChange";
            this.rbChange.Size = new System.Drawing.Size(80, 20);
            this.rbChange.TabIndex = 6;
            this.rbChange.TabStop = true;
            this.rbChange.Text = "Değiştir";
            this.rbChange.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAdd.Location = new System.Drawing.Point(148, 67);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(109, 20);
            this.rbAdd.TabIndex = 7;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Üstüne Ekle";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(660, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtStok
            // 
            this.dtStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStok.Location = new System.Drawing.Point(20, 96);
            this.dtStok.Name = "dtStok";
            this.dtStok.Size = new System.Drawing.Size(790, 112);
            this.dtStok.TabIndex = 9;
            // 
            // guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 241);
            this.Controls.Add(this.groupBox1);
            this.Name = "guncelle";
            this.Text = "guncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.guncelle_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtStok;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbChange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtParca;
        private System.Windows.Forms.ComboBox cbP_Marka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbP_Tur;
        private System.Windows.Forms.Label label1;
    }
}