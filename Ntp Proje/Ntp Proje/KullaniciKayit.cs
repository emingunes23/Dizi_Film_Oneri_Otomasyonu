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
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GirisSayfasi form1= new GirisSayfasi();
            form1.Show();
            this.Hide();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into KullaniciKaydetme (KullaniciAdi,KullaniciSifre) values(@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleşti", "Kayıt Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
