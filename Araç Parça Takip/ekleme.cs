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
using System.Collections;

namespace Araç_Parça_Takip
{
    public partial class ekleme : Form
    {
        public ekleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=arac_stok.mdb");
        void baglan()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();
        }
        ArrayList araba_index = new ArrayList();

        void sqlBilgiGetir(string sql, ComboBox cmb)
        {
            cmb.Items.Clear();
            baglan();
            OleDbCommand komutdoldur = new OleDbCommand(sql, baglanti);
            OleDbDataReader oku = komutdoldur.ExecuteReader();
            while (oku.Read())
            {
                cmb.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }

        private void ekleme_Load(object sender, EventArgs e)
        {

        }

        private void marka_sec_cmb_Click(object sender, EventArgs e)
        {
            marka_sec_cmb.Items.Clear();
            sqlBilgiGetir("select distinct  arac_Marka from araclar", marka_sec_cmb);
        }

        private void model_sec_cmb_Click(object sender, EventArgs e)
        {
            model_sec_cmb.Items.Clear();
            sqlBilgiGetir("select distinct arac_Model from araclar where arac_Marka = '" + marka_sec_cmb.SelectedItem + "' ", model_sec_cmb);
        }

        private void ekleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            listeleme list = new listeleme();
            list.Show();
            this.Hide();
        }

        private void listeye_ekle_buton_Click(object sender, EventArgs e)
        {
            if (marka_sec_cmb.SelectedIndex != -1 && model_sec_cmb.SelectedIndex != -1)
            {
                arabalar_listesi.Items.Add(marka_sec_cmb.SelectedItem.ToString() + " - " + model_sec_cmb.SelectedItem.ToString());
                marka_sec_cmb.SelectedIndex = -1;
                model_sec_cmb.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Marka Ve Model Seçiniz!");
            }
        }

        private void hepsini_ekle_buton_Click(object sender, EventArgs e)
        {
            arabalar_listesi.Items.Clear();
            baglan();
            string sql = "select distinct * from araclar";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                arabalar_listesi.Items.Add(oku[1].ToString() + " - " + oku[2].ToString());
            }
            baglanti.Close();
        }

        private void temizle_buton_Click(object sender, EventArgs e)
        {
            arabalar_listesi.Items.Clear();
        }
        bool arabaIdBul()
        {
            if (arabalar_listesi.Items.Count != 0)
            {
                baglan();
                for (int i = 0; i < arabalar_listesi.Items.Count; i++)
                {
                    string[] ozellikler = arabalar_listesi.Items[i].ToString().Split('-');
                    ozellikler[0] = ozellikler[0].Remove(ozellikler[0].Length - 1, 1);
                    ozellikler[1] = ozellikler[1].Remove(0, 1);
                    OleDbCommand komut = new OleDbCommand("select * from  araclar where arac_Marka = '" + ozellikler[0] + "' and arac_Model = '" + ozellikler[1] + "'  ", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        araba_index.Add(oku[0].ToString());
                        break;
                    }
                }
                return true;
            }
            return false;
        }
        string aracIdBirlestir()
        {
            string toplam = "";
            for (int i = 0; i < araba_index.Count; i++)
            {
                toplam += araba_index[i].ToString() + " - ";
            }
            toplam = toplam.Remove(toplam.Length - 2, 1);
            return toplam;
        }
        private void parca_ekle_buton_Click(object sender, EventArgs e)
        {
            if (parca_adet_txtb.Text != "" && parca_marka_txtb.Text != "" && parca_turu_txtb.Text != "")
            {
                baglan();
                if (arabaIdBul())
                {
                    OleDbCommand komut = new OleDbCommand("insert into parcalar(parca_Turu,parca_Marka,parca_Adet,arac_IDs) values('"+parca_turu_txtb.Text+"','"+parca_marka_txtb.Text+"','"+parca_adet_txtb.Text+"','"+aracIdBirlestir()+"') ",baglanti);
                    int sonuc = komut.ExecuteNonQuery();
                    baglanti.Close();
                    if (sonuc==1)
                    {
                        MessageBox.Show("Seçtiğiniz arabalar için \"" +parca_turu_txtb.Text+" / "+parca_turu_txtb.Text+"\" markalı parçadan "+parca_adet_txtb.Text+" adet eklenmiştir.");
                        parca_adet_txtb.Text = "";
                        parca_marka_txtb.Text = "";
                        parca_turu_txtb.Text = "";
                        marka_sec_cmb.SelectedIndex = -1;
                        model_sec_cmb.SelectedIndex = -1;
                        arabalar_listesi.Items.Clear();
                        araba_index.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kaydetme İşlemş Gerçekleştirilemedi.");
                    }
                }
            }
        }

        private void arabalar_listesi_DoubleClick(object sender, EventArgs e)
        {
            arabalar_listesi.Items.Remove(arabalar_listesi.SelectedItem);
        }

        private void arac_ekle_buton_Click(object sender, EventArgs e)
        {
            if (arac_marka_txtb.Text!=""&&arac_model_txtb.Text!="")
            {
                baglan();
                OleDbCommand kontrol = new OleDbCommand("select * from araclar where arac_Marka='"+arac_marka_txtb.Text+"' and arac_Model='"+arac_model_txtb.Text+"' ",baglanti);
                int sonuc = Convert.ToInt32(kontrol.ExecuteScalar());
                if (sonuc!=0)
                {
                    MessageBox.Show("Bu Model Mevcuttur!");
                }
                else
                {
                    OleDbCommand komut = new OleDbCommand("insert into araclar(arac_Marka,arac_Model) values('"+arac_marka_txtb.Text+"','"+arac_model_txtb.Text+"')",baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Araç Eklenmiştir!");
                }
            }
            else
            {
                MessageBox.Show("Araç Marka ve Modelini Giriniz!");
            }
        }
    }
}
