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
    public partial class GuncellemeDiziFilm : Form
    {
        public GuncellemeDiziFilm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuncellemeFilm form6 = new GuncellemeFilm();
            form6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuncellemeDizi form7 = new GuncellemeDizi();
            form7.Show(); 
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AdminGiris form3 = new AdminGiris();
            form3.Show();
            this.Hide();
        }
    }
}
