namespace Araç_Parça_Takip
{
    partial class sil
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
            this.rbParca_Sil = new System.Windows.Forms.RadioButton();
            this.rbAracSil = new System.Windows.Forms.RadioButton();
            this.gbArac_Silme = new System.Windows.Forms.GroupBox();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.dgArac_Sil = new System.Windows.Forms.DataGridView();
            this.gbParca_Silme = new System.Windows.Forms.GroupBox();
            this.btnParcaSil = new System.Windows.Forms.Button();
            this.dgParca_Sil = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbArac_Silme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArac_Sil)).BeginInit();
            this.gbParca_Silme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParca_Sil)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbParca_Sil);
            this.groupBox1.Controls.Add(this.rbAracSil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Silme Seçenekleri";
            // 
            // rbParca_Sil
            // 
            this.rbParca_Sil.AutoSize = true;
            this.rbParca_Sil.Location = new System.Drawing.Point(219, 32);
            this.rbParca_Sil.Name = "rbParca_Sil";
            this.rbParca_Sil.Size = new System.Drawing.Size(145, 24);
            this.rbParca_Sil.TabIndex = 1;
            this.rbParca_Sil.TabStop = true;
            this.rbParca_Sil.Text = "Parçaya Göre Sil";
            this.rbParca_Sil.UseVisualStyleBackColor = true;
            // 
            // rbAracSil
            // 
            this.rbAracSil.AutoSize = true;
            this.rbAracSil.Location = new System.Drawing.Point(38, 32);
            this.rbAracSil.Name = "rbAracSil";
            this.rbAracSil.Size = new System.Drawing.Size(130, 24);
            this.rbAracSil.TabIndex = 0;
            this.rbAracSil.TabStop = true;
            this.rbAracSil.Text = "Araca Göre Sil";
            this.rbAracSil.UseVisualStyleBackColor = true;
            this.rbAracSil.CheckedChanged += new System.EventHandler(this.rbAracSil_CheckedChanged);
            // 
            // gbArac_Silme
            // 
            this.gbArac_Silme.Controls.Add(this.btnAracSil);
            this.gbArac_Silme.Controls.Add(this.dgArac_Sil);
            this.gbArac_Silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbArac_Silme.Location = new System.Drawing.Point(12, 91);
            this.gbArac_Silme.Name = "gbArac_Silme";
            this.gbArac_Silme.Size = new System.Drawing.Size(564, 218);
            this.gbArac_Silme.TabIndex = 1;
            this.gbArac_Silme.TabStop = false;
            this.gbArac_Silme.Text = "Araç Silme";
            this.gbArac_Silme.Visible = false;
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(413, 185);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(144, 27);
            this.btnAracSil.TabIndex = 1;
            this.btnAracSil.Text = "Seçileni Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // dgArac_Sil
            // 
            this.dgArac_Sil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArac_Sil.Location = new System.Drawing.Point(7, 20);
            this.dgArac_Sil.Name = "dgArac_Sil";
            this.dgArac_Sil.Size = new System.Drawing.Size(551, 159);
            this.dgArac_Sil.TabIndex = 0;
            // 
            // gbParca_Silme
            // 
            this.gbParca_Silme.Controls.Add(this.btnParcaSil);
            this.gbParca_Silme.Controls.Add(this.dgParca_Sil);
            this.gbParca_Silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbParca_Silme.Location = new System.Drawing.Point(12, 91);
            this.gbParca_Silme.Name = "gbParca_Silme";
            this.gbParca_Silme.Size = new System.Drawing.Size(564, 218);
            this.gbParca_Silme.TabIndex = 1;
            this.gbParca_Silme.TabStop = false;
            this.gbParca_Silme.Text = "Parça Silme";
            this.gbParca_Silme.Visible = false;
            // 
            // btnParcaSil
            // 
            this.btnParcaSil.Location = new System.Drawing.Point(413, 185);
            this.btnParcaSil.Name = "btnParcaSil";
            this.btnParcaSil.Size = new System.Drawing.Size(144, 27);
            this.btnParcaSil.TabIndex = 1;
            this.btnParcaSil.Text = "Seçileni Sil";
            this.btnParcaSil.UseVisualStyleBackColor = true;
            this.btnParcaSil.Click += new System.EventHandler(this.btnParcaSil_Click);
            // 
            // dgParca_Sil
            // 
            this.dgParca_Sil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParca_Sil.Location = new System.Drawing.Point(6, 19);
            this.dgParca_Sil.Name = "dgParca_Sil";
            this.dgParca_Sil.Size = new System.Drawing.Size(551, 159);
            this.dgParca_Sil.TabIndex = 0;
            // 
            // sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 323);
            this.Controls.Add(this.gbParca_Silme);
            this.Controls.Add(this.gbArac_Silme);
            this.Controls.Add(this.groupBox1);
            this.Name = "sil";
            this.Text = "sil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sil_FormClosed);
            this.Load += new System.EventHandler(this.sil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbArac_Silme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArac_Sil)).EndInit();
            this.gbParca_Silme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgParca_Sil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbParca_Sil;
        private System.Windows.Forms.RadioButton rbAracSil;
        private System.Windows.Forms.GroupBox gbArac_Silme;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.DataGridView dgArac_Sil;
        private System.Windows.Forms.GroupBox gbParca_Silme;
        private System.Windows.Forms.DataGridView dgParca_Sil;
        private System.Windows.Forms.Button btnParcaSil;
    }
}