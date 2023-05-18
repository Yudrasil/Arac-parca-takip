using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Araç_Parça_Takip
{
    public partial class listeleme : Form
    {
        public listeleme()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=arac_stok.mdb");

        void baglantiKur()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        void sqlBilgiGetir_Cmb(string sql, ComboBox cmb)
        {
            cmb.Items.Clear();
            baglantiKur();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmb.Items.Add(oku[0].ToString());
            }
            conn.Close();
        }
        private void rbListeleme(object sender, EventArgs e)
        {
            if (araba_arama.Checked)
            {
                arac_arama_gb.Visible = true;
                parca_arama_gb.Visible = false;
                this.AcceptButton = arac_arama_listele;
                // enter a bastığınızda btnA_Listele butonu çalışır.
            }
            else
            {
                parca_arama_gb.Visible = true;
                arac_arama_gb.Visible = false;
                this.AcceptButton = parca_arama_listele;
            }
            parca_arama_marka.Items.Clear();
            parca_arama_turu.Items.Clear();
            arac_arama_model.Items.Clear();
            arac_arama_marka.Items.Clear();
        }//yazılmadı


        private void listeleme_Load(object sender, EventArgs e)
        {
            arac_arama_gb.Parent = this;
            parca_arama_gb.Parent = this;
            this.AcceptButton = arac_arama_listele;
        }

        private void arac_arama_marka_Click(object sender, EventArgs e)
        {
            arac_arama_marka.Items.Clear();
            sqlBilgiGetir_Cmb("SELECT DISTINCT arac_Marka FROM araclar", arac_arama_marka);
        }

        private void arac_arama_model_Click(object sender, EventArgs e)
        {
            sqlBilgiGetir_Cmb("SELECT DISTINCT arac_Model FROM araclar WHERE arac_Marka='" + arac_arama_marka.Text + "'", arac_arama_model);
        }

        private void parca_arama_marka_Click(object sender, EventArgs e)
        {
            sqlBilgiGetir_Cmb("SELECT DISTINCT parca_Marka FROM parcalar WHERE parca_Turu = '" + parca_arama_turu.Text + "'", parca_arama_marka);
        }

        private void parca_arama_turu_Click(object sender, EventArgs e)
        {
            parca_arama_marka.Items.Clear();
            sqlBilgiGetir_Cmb("SELECT DISTINCT parca_Turu FROM parcalar", parca_arama_turu);
        }

        private void arac_arama_listele_Click(object sender, EventArgs e)
        {
            if (arac_arama_marka.SelectedIndex != -1 && arac_arama_model.SelectedIndex != -1)
            {
                string sql = "SELECT * FROM araclar WHERE arac_Marka='" + arac_arama_marka.Text + "' AND arac_Model='" + arac_arama_model.Text + "'";
                baglantiKur();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader oku = cmd.ExecuteReader();
                int id = 0;
                while (oku.Read())
                {
                    id = Convert.ToInt32(oku[0]);
                }
                sql = "SELECT * FROM parcalar";
                cmd = new OleDbCommand(sql, conn);
                oku = cmd.ExecuteReader();
                string parca_IDs = "SELECT * FROM parcalar WHERE parca_IDs =";
                //SELECT * FROM parcalar WHERE parca_ID =21 ...or parca_ID =28

                //daha sonra bu stringin sonuna id'ler eklenip sl cümlesi olarak kulllanılacak
                while (oku.Read())
                {
                    string[] id_ler = oku[3].ToString().Split('-');
                    for (int i = 0; i < id_ler.Length; i++)
                    {
                        if (id == Convert.ToInt32(id_ler[i]))
                        {
                            parca_IDs += " " + oku[0].ToString() + " OR parca_ID=";
                        }
                    }
                }
                parca_IDs = parca_IDs.Remove(parca_IDs.Length - 13, 13);
                OleDbDataAdapter adp = new OleDbDataAdapter(parca_IDs, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Aracın Marka ve Modelini Seçiniz.");
            }
        }

        private void parca_arama_listele_Click(object sender, EventArgs e)
        {
            if (parca_arama_turu.SelectedIndex != -1 && parca_arama_marka.SelectedIndex != -1)
            {
                string sql = "SELECT * FROM parcalar WHERE parca_Turu='" + parca_arama_turu.Text + "' AND parca_Marka='" + parca_arama_marka.Text + "'";
                baglantiKur();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader oku = cmd.ExecuteReader();

                string arac_ID_sorgusu = "SELECT * FROM araclar WHERE arac_ID =";
                while (oku.Read())
                {
                    //id = Convert.ToInt32(oku[0]);
                    string[] arac_IDs = oku[4].ToString().Split('-');
                    for (int i = 0; i < arac_IDs.Length; i++)
                    {
                        arac_ID_sorgusu += " " + arac_IDs[i] + "  OR arac_ID = ";
                    }
                    arac_ID_sorgusu = arac_ID_sorgusu.Remove(arac_ID_sorgusu.Length - 13, 13);
                    OleDbDataAdapter adp = new OleDbDataAdapter(arac_ID_sorgusu, conn);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Parçanın Türünü ve Markasını Seçiniz.");
            }
        }

        private void yeniAraçVeyaParçaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekleme ekle = new ekleme();
            ekle.Show();
            this.Hide();
        }

        private void araçVeyaParçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle ekle = new guncelle();
            ekle.Show();
            this.Hide();
        }

        private void araçVeyaParçaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sil ekle = new sil();
            ekle.Show();
            this.Hide();
        }

        private void stokListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stoklistele ekle = new stoklistele();
            ekle.Show();
            this.Hide();
        }

        private void listeleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
