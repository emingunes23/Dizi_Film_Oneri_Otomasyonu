using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntp_Proje
{
    public partial class DiziFilmSayfası : Form
    {
        public DiziFilmSayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmSayfasi form8 = new FilmSayfasi();
            form8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiziSayfasi form9= new DiziSayfasi();
            form9.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            KullaniciGiris form4 = new KullaniciGiris();
            form4.Show();
            this.Hide();
        }
    }
}
