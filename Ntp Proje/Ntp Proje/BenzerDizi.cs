using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ntp_Proje
{
    public partial class BenzerDizi : Form
    {
        public BenzerDizi()
        {
            InitializeComponent();
        }
        public string ad;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BenzerDizi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet5.DiziKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.diziKaydetmeTableAdapter.Fill(this.databaseDataSet5.DiziKaydetme);
            LblAd.Text = ad;
            SqlCommand komut = new SqlCommand(" Select DiziTuru,Diziimdb From DiziKaydetme where DiziAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblAd.Text);
           
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblTuru.Text = dr[0] + "" ;
                Lblimdb.Text = dr[1] + "" ;
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziTuru='" + LblTuru.Text +  "' and Diziimdb>'" + Lblimdb.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            


        }

        private void button14_Click(object sender, EventArgs e)
        {
            DiziSayfasi diziSayfasi = new DiziSayfasi();
            diziSayfasi.Show();
            this.Hide();
        }
    }
}
