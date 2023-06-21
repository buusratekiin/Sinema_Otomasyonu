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

namespace Sinema_Bilet_Otomasyonu
{
    public partial class Formsalonek : Form
    {
        public Formsalonek()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formsalonek_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnasayfa anasayfa = new FormAnasayfa();
            anasayfa.Show();

        }
        sinemaTableAdapters.Salon_BilgileriTableAdapter salon = new sinemaTableAdapters.Salon_BilgileriTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(textsalonadı.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı salonu daha önce eklediniz!!!","Uyarı");
            }
            textsalonadı.Text = "";
        }

        private void Formsalonek_Load(object sender, EventArgs e)
        {

        }
    }
}
