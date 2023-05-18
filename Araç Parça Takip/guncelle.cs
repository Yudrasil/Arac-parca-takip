using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Araç_Parça_Takip
{
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=arac_stok.mdb");

        void baglantiKur()
        {
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        void sqlbilgigetir_Cmb(string command, ComboBox cmb)
        {
            cmb.Items.Clear();
            baglantiKur();
            OleDbCommand komut = new OleDbCommand(command,baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmb.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }
        void stokGetir()
        {
            baglantiKur();
            OleDbCommand komut = new OleDbCommand("select * from parcalar where parca_Turu='"+cbP_Tur.SelectedItem+"' and parca_Marka='"+cbP_Marka.SelectedItem+"' ",baglanti);
            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dtStok.DataSource = dt;
            baglanti.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (textBox1.Text!="")
            {
                baglantiKur();
                if (rbChange.Checked)
                {
                    sql = "update parcalar set parca_Adet="+Convert.ToInt32(textBox1.Text)+" where parca_Turu='"+cbP_Tur.SelectedItem+"' and parca_Marka='"+cbP_Marka.Text+"' ";
                }
                else
                {
                    sql = "update parcalar set parca_Adet=parca_Adet + " + Convert.ToInt32(textBox1.Text) + " where parca_Turu='" + cbP_Tur.SelectedItem + "' and parca_Marka='" + cbP_Marka.Text + "' ";
                }
                OleDbCommand cmd = new OleDbCommand(sql,baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seçtiğiniz parça başarılı bir şekilde güncellenmiştir!");
                baglanti.Close();
                stokGetir();
            }
            else
            {
                MessageBox.Show("Lütfen Güncellenecek Parçayı Seçiniz!");
            }
        }

        private void cbP_Tur_Click(object sender, EventArgs e)
        {
            cbP_Tur.Items.Clear();
            sqlbilgigetir_Cmb("select distinct parca_Turu from parcalar",cbP_Tur);
        }
        private void cbP_Marka_Click(object sender, EventArgs e)
        {
            cbP_Marka.Items.Clear();
            sqlbilgigetir_Cmb("select distinct parca_Marka from parcalar where parca_Turu='"+cbP_Tur.SelectedItem+"' ", cbP_Marka);
        }

        private void guncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            listeleme ok = new listeleme();
            ok.Show();
            this.Hide();
        }

        private void cbP_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            stokGetir();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}