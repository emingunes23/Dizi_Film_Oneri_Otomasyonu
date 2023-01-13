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
    public partial class FilmSayfasi : Form
    {
        public FilmSayfasi()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DiziFilmSayfası form10 = new DiziFilmSayfası();
            form10.Show();
            this.Hide();
        }

        private void FilmSayfasi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet2.FilmKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmKaydetmeTableAdapter1.Fill(this.databaseDataSet2.FilmKaydetme);
            // TODO: Bu kod satırı 'ntp_ProjeDataSet.FilmKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmKaydetmeTableAdapter.Fill(this.ntp_ProjeDataSet.FilmKaydetme);

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button18_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='En İyi 10 Film' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            BenzerFilm benzerFilm = new BenzerFilm();
            benzerFilm.ad2 = TxtBenzer.Text;
            benzerFilm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='En İyi 10 Yerli Film' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where Filmimdb >'9,0' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='Dram' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='Saniyesi' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='Komedi' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='Korku' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='Animasyonlar' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='Kurgu' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme where FilmFilitreleme ='Tarih' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
    }
    
    
    
    
    

