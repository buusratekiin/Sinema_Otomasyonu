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
    public partial class formsatıslisteleme : Form
    {
        public formsatıslisteleme()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Satıs_BilgileriTableAdapter satislistesi = new sinemaTableAdapters.Satıs_BilgileriTableAdapter();
        private void formsatıslisteleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGöreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            dataGridView1.DataSource = satislistesi.TariheGöreListele2(dateTimePicker1.Text);
            int ucrettoplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
            }
            label1.Text = "Toplam Satış=" + ucrettoplam + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.SatışListesi2();
            ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGöreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void formsatıslisteleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnasayfa anasayfa = new FormAnasayfa();
            anasayfa.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
