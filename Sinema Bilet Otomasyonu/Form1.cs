using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Film_BilgileriTableAdapter film = new sinemaTableAdapters.Film_BilgileriTableAdapter();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnasayfa anasayfa = new FormAnasayfa();
            anasayfa.Show();
        }

        private void filmekle_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(txtfilmadi.Text, txtyönetmen.Text, cmxfilmtürü.Text, txtsüre.Text, dateTimePicker1.Text, txtyapimyılı.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Film bilgileri eklendi.", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu film daha önceden eklendi!!!", "Uyarı");
            }
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            cmxfilmtürü.Text = "";

           
        }

        private void afissec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
