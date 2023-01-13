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
    public partial class GuncellemeFilm : Form
    {
        public GuncellemeFilm()
        {
            InitializeComponent();
        }
        void temzile()
        {
            Txtid.Text = "";
            TxtAdi.Text = "";
            TxtTuru.Text = "";
            TxtYonetmen.Text = "";
            Txtimdb.Text = "";
            TxtSeriSayısı.Text = "";
            TxtTarzı.Text = "";
            TxtYili.Text = "";
            TxtFiltreleme.Text = "";
            TxtAdi.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GuncellemeDiziFilm form5 = new GuncellemeDiziFilm();
            form5.Show();
            this.Hide();
        }
        sqlbaglantisi  bgl= new sqlbaglantisi();
        private void GuncellemeFilm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet.FilmKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmKaydetmeTableAdapter1.Fill(this.databaseDataSet.FilmKaydetme);
            // TODO: Bu kod satırı 'ntp_ProjeDataSet.FilmKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmKaydetmeTableAdapter.Fill(this.ntp_ProjeDataSet.FilmKaydetme);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From FilmKaydetme ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into FilmKaydetme (FilmAdi,FilmTuru,FilmYonetmen,Filmimdb,FilmSeriSayisi,FilmTarzi,FilmYili,FilmFilitreleme) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtTuru.Text);
            komut.Parameters.AddWithValue("@p3", TxtYonetmen.Text);
            komut.Parameters.AddWithValue("@p4", Txtimdb.Text);
            komut.Parameters.AddWithValue("@p5", TxtSeriSayısı.Text);
            komut.Parameters.AddWithValue("@p6", TxtTarzı.Text);
            komut.Parameters.AddWithValue("@p7", TxtYili.Text);
            komut.Parameters.AddWithValue("@p8", TxtFiltreleme.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleşti", "Kayıt Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtTuru.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtYonetmen.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Txtimdb.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSeriSayısı.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtTarzı.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtYili.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtFiltreleme.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update FilmKaydetme set FilmAdi=@p1,FilmTuru=@p2,FilmYonetmen=@p3,Filmimdb=@p4,FilmSeriSayisi=@p5,FilmTarzi=@p6,FilmYili=@p7,FilmFilitreleme=@p8 where  Filmid=@p9", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut2.Parameters.AddWithValue("@p2", TxtTuru.Text);
            komut2.Parameters.AddWithValue("@p3", TxtYonetmen.Text);
            komut2.Parameters.AddWithValue("@p4", Txtimdb.Text);
            komut2.Parameters.AddWithValue("@p5", TxtSeriSayısı.Text);
            komut2.Parameters.AddWithValue("@p6", TxtTarzı.Text);
            komut2.Parameters.AddWithValue("@p7", TxtYili.Text);
            komut2.Parameters.AddWithValue("@p8", TxtFiltreleme.Text);
            komut2.Parameters.AddWithValue("@p9", Txtid.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşti", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temzile();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From FilmKaydetme Where Filmid=@c1 ", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@c1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme  Başarıyla Gerçekleşti", "Silme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
