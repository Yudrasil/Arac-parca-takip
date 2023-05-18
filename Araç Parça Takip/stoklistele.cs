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
    public partial class stoklistele : Form
    {
        public stoklistele()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=arac_stok.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            stokyenile();
        }
        void stokyenile()
        {
            baglanti.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from parcalar",baglanti);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void stoklistele_Load(object sender, EventArgs e)
        {
            stokyenile();
        }
    }
}
