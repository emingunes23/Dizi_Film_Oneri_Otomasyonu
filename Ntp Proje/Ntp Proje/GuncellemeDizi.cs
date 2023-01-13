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
    public partial class GuncellemeDizi : Form
    {
        public GuncellemeDizi()
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
            TxtSezonSayısı.Text = "";
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
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void GuncellemeDizi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet1.DiziKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.diziKaydetmeTableAdapter1.Fill(this.databaseDataSet1.DiziKaydetme);
            // TODO: Bu kod satırı 'ntp_ProjeDataSet.DiziKaydetme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.diziKaydetmeTableAdapter.Fill(this.ntp_ProjeDataSet.DiziKaydetme);

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into DiziKaydetme (DiziAdi,DiziTuru,DiziYonetmen,Diziimdb,DiziSezonSayisi,DiziTarzi,DiziYili,DiziFilitreleme) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtAdi.Text );
            komut.Parameters.AddWithValue("@p2", TxtTuru.Text );
            komut.Parameters.AddWithValue("@p3",TxtYonetmen.Text );
            komut.Parameters.AddWithValue("@p4", Txtimdb.Text );
            komut.Parameters.AddWithValue("@p5",TxtSezonSayısı.Text );
            komut.Parameters.AddWithValue("@p6",TxtTarzı.Text );
            komut.Parameters.AddWithValue("@p7",TxtYili.Text );
            komut.Parameters.AddWithValue("@p8",TxtFiltreleme.Text );
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleşti", "Kayıt Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From DiziKaydetme ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;






        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update DiziKaydetme set DiziAdi=@p1,DiziTuru=@p2,DiziYonetmen=@p3,Diziimdb=@p4,DiziSezonSayisi=@p5,DiziTarzi=@p6,DiziYili=@p7,DiziFilitreleme=@p8 where  Diziid=@p9", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAdi.Text);
            komut2.Parameters.AddWithValue("@p2", TxtTuru.Text);
            komut2.Parameters.AddWithValue("@p3", TxtYonetmen.Text);
            komut2.Parameters.AddWithValue("@p4", Txtimdb.Text);
            komut2.Parameters.AddWithValue("@p5", TxtSezonSayısı.Text);
            komut2.Parameters.AddWithValue("@p6", TxtTarzı.Text);
            komut2.Parameters.AddWithValue("@p7", TxtYili.Text);
            komut2.Parameters.AddWithValue("@p8", TxtFiltreleme.Text);
            komut2.Parameters.AddWithValue("@p9", Txtid.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşti", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAdi.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtTuru.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtYonetmen.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Txtimdb.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSezonSayısı.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtTarzı.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtYili.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtFiltreleme.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temzile();
        }
        
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From DiziKaydetme Where Diziid=@c1 ",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@c1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme  Başarıyla Gerçekleşti", "Silme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
