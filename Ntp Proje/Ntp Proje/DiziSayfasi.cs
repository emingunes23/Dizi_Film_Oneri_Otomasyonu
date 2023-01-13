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
    public partial class DiziSayfasi : Form
    {
        public DiziSayfasi()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DiziFilmSayfası form10 = new DiziFilmSayfası();
            form10.Show();
            this.Hide();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='En İyi 10 Dizi' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void DiziSayfasi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet3.DiziKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.diziKaydetmeTableAdapter1.Fill(this.databaseDataSet3.DiziKaydetme);
            // TODO: Bu kod satırı 'ntp_ProjeDataSet.DiziKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.diziKaydetmeTableAdapter.Fill(this.ntp_ProjeDataSet.DiziKaydetme);
            // TODO: Bu kod satırı 'ntp_ProjeDataSet.DiziKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.diziKaydetmeTableAdapter.Fill(this.ntp_ProjeDataSet.DiziKaydetme);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='En İyi 10 Yerli Dizi' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
           
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where Diziimdb > '9,0' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BenzerDizi benzerDizi = new BenzerDizi();
            benzerDizi.ad = TxtBenzer.Text;
            benzerDizi.Show();
            this.Hide();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Mini Diziler' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Damga Vurmuş' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Süper Kahraman' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Anime' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Asla' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Uzun Süre' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Sitcom' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme where DiziFilitreleme ='Netflix' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
