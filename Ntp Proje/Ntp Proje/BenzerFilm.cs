using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntp_Proje
{
    public partial class BenzerFilm : Form
    {
        public BenzerFilm()
        {
            InitializeComponent();
        }
        public string ad2;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BenzerFilm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet4.FilmKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmKaydetmeTableAdapter.Fill(this.databaseDataSet4.FilmKaydetme);
            LblAd.Text = ad2;
            SqlCommand komut = new SqlCommand(" Select FilmTuru,Filmimdb From FilmKaydetme where FilmAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblAd.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblTuru.Text = dr[0] + "";
                Lblimdb.Text = dr[1] + "";
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmTuru='" + LblTuru.Text +  "' and Filmimdb>'" + Lblimdb.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FilmSayfasi filmSayfasi = new FilmSayfasi();
            filmSayfasi.Show();
            this.Hide();
        }
    }
}
