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
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=arac_stok.mdb");
        
        void baglantiKur()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }


        private void btnParcaSil_Click(object sender, EventArgs e)
        {
            if (dgParca_Sil.RowCount>0)
            {
                int id = int.Parse(dgParca_Sil.CurrentRow.Cells[0].Value.ToString());
                baglantiKur();
                string sql = "delete from parcalar where parca_ID= " + id;
                OleDbCommand komut = new OleDbCommand(sql,baglanti);
                int i = komut.ExecuteNonQuery();
                MessageBox.Show(i.ToString()+" adet parça kayıdı silinmiştir!");
                sql = "select * from parcalar";
                OleDbDataAdapter adp = new OleDbDataAdapter(sql,baglanti);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgParca_Sil.DataSource = dt;
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Listede Hiç Parça Yok!");
            }
        }

        private void rbAracSil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAracSil.Checked)
            {
                gbParca_Silme.Visible = false;
                gbArac_Silme.Visible = true;
                aracListele();
            }
            else
            {
                gbParca_Silme.Visible = true;
                gbArac_Silme.Visible =  false;
                parcaListele();
            }
        }

        private void parcaListele()
        {
            baglantiKur();
            string sql = "select * from parcalar";
            OleDbDataAdapter adap = new OleDbDataAdapter(sql,baglanti);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgParca_Sil.DataSource = dt;
            baglanti.Close();
        }

        private void aracListele()
        {
            baglantiKur();
            string sql = "select * from araclar";
            OleDbDataAdapter adap = new OleDbDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgArac_Sil.DataSource = dt;
            baglanti.Close();

        }

        private void sil_FormClosed(object sender, FormClosedEventArgs e)
        {
            listeleme ok = new listeleme();
            ok.Show();
            this.Hide();
        }

        private void sil_Load(object sender, EventArgs e)
        {
            aracListele();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            int arac_id = int.Parse(dgArac_Sil.CurrentRow.Cells[0].Value.ToString());
            baglantiKur();
            string sql = "delete from araclar where arac_ID= "+arac_id;
            OleDbCommand komut2 = new OleDbCommand(sql,baglanti);
            int j = komut2.ExecuteNonQuery();
            MessageBox.Show(j.ToString()+" adet arac silinmiştir!");
            sql = "select * from parcalar";
            komut2 = new OleDbCommand(sql,baglanti);
            OleDbDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                string[] arac_idleri = oku[4].ToString().Split('-');
                for (int i = 0; i < arac_idleri.Length; i++)
                {
                    if (arac_id==Convert.ToInt32(arac_idleri[i]))
                    {
                        string deger = oku[4].ToString();
                        string sonuc = "";
                        if (deger.EndsWith(arac_id.ToString()))
                        {
                            try
                            {
                                sonuc = deger.Remove(deger.Length - 3, 3);
                            }
                            catch
                            {
                                sonuc = deger.Remove(deger.Length - 2, 2);
                            }
                        }
                        else
                        {
                            int indis = deger.IndexOf(arac_id.ToString());
                            sonuc = deger.Remove(indis,arac_id.ToString().Length+1);
                        }
                        string sqlc = "UPDATE parcalar SET arac_IDs='" + sonuc + "' where parca_ID=" + Convert.ToInt32(oku[0]);
                        OleDbCommand guncelle = new OleDbCommand(sqlc,baglanti);
                        guncelle.ExecuteNonQuery();
                    }
                }
            }
            sql = "select * from parcalar";
            OleDbDataAdapter adap = new OleDbDataAdapter(sql,baglanti);
            DataTable dts = new DataTable();
            dgArac_Sil.DataSource=dts;
            baglanti.Close();
        }
    }
}
