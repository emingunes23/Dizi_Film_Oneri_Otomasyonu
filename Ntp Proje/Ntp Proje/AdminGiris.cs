using Ntp_Proje;
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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From KullaniciKaydetme Where KullaniciAdi=@p1 and KullaniciSifre =@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (TxtKullaniciAdi.Text=="Admin"&& TxtSifre.Text=="admin")
            {

                GuncellemeDiziFilm form5 = new GuncellemeDiziFilm();
                form5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre", "Giriş İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GirisSayfasi form1 = new GirisSayfasi();
            form1.Show();
            this.Hide();
        }
    }
}
