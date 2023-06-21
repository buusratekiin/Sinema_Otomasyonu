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
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = .; Initial Catalog = dbSinema_Bileti; Integrated Security = True");
        int sayac = 0;
        private void FilmVeSalonGetir(ComboBox combo,string sql1,string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        private void FilmAfişiGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from film_bilgileri where filmadi='"+filmadı.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["resim"].ToString();
            }
            baglanti.Close();
        }
        private void Combo_Dolu_Koltuklar()
        {
            iptalkoltuk.Items.Clear();
            iptalkoltuk.Text = "";
            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        iptalkoltuk.Items.Add(item.Text);
                    }
                }
            }
        }
        private void YenidenRenklendir()
        {
            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void Veritabani_Dolu_Koltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from satıs_bilgileri where filmadi='"+filmadı.SelectedItem+"' and salonadi='"+salonadı.Text+"' and tarih='"+filmtarihi.SelectedItem+"' and saat='"+filmseansı.SelectedItem+"'",baglanti);
           SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel2.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukno"].ToString()==item.Text)
                        {
                           item.BackColor = Color.Red;
                        }
                        
                    }

                }
            }
            baglanti.Close();
        }
        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmVeSalonGetir(filmadı, "select *from film_bilgileri", "filmadi");
            FilmVeSalonGetir(salonadı, "select *from salon_bilgileri", "salonadi");

        }

        private void Boş_Koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel2.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor==Color.White)
            {
                koltukno.Text = b.Text;
            }
        }

        private void salonekle_Click(object sender, EventArgs e)
        {
            Formsalonek ekle = new Formsalonek();
            ekle.Show();
            this.Hide();
        }
       
        private void filmekle_Click(object sender, EventArgs e)
        {
            Form1 ekle = new Form1();
            ekle.Show();
            this.Hide();
        }
        

        private void seansekle_Click(object sender, EventArgs e)
        {
            FrmSeansekleorm3 ekle = new FrmSeansekleorm3();
            ekle.Show();
            this.Hide();
        }
        

        private void satısbuton_Click(object sender, EventArgs e)
        {
            formsatıslisteleme satis = new formsatıslisteleme();
            satis.Show();
            this.Hide();
            
        }
       

        private void seanslistesi_Click(object sender, EventArgs e)
        {
            frmSeansListele seanslistele = new frmSeansListele();
            seanslistele.Show();
            this.Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void filmadı_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmseansı.Items.Clear();
            filmtarihi.Items.Clear();
            filmseansı.Text = "";
            filmtarihi.Text = "";
            salonadı.Text = "";
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";   
            FilmAfişiGoster();
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }
        sinemaTableAdapters.Satıs_BilgileriTableAdapter satis = new sinemaTableAdapters.Satıs_BilgileriTableAdapter();

        private void biletsat_Click(object sender, EventArgs e)
        {
            if (koltukno.Text!="")
            {
                try
                {
                    satis.Satış_Yap(koltukno.Text, salonadı.Text, filmadı.Text, filmtarihi.Text, filmseansı.Text, müsteriad.Text, müsterisoyadı.Text, ücret.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata Oluştu"+hata.Message, "Uyarı");
                } 
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!!!", "Uyarı");
            }
        }

        private void FormAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        private void Film_Tarihi_Getir()
        {
            filmtarihi.Text = "";
            filmseansı.Text = "";
            filmtarihi.Items.Clear();
            filmseansı.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where filmadi='"+filmadı.SelectedItem+"' and salonadi='"+salonadı.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!filmtarihi.Items.Contains(read["tarih"].ToString()))
                    {
                       filmtarihi.Items.Add(read["tarih"].ToString());
                    }
                   
                }
                
            }
            baglanti.Close();
        }
        private void salonadı_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
        }
        private void Film_Seansi_Getir()
        {
            filmseansı.Text = "";
            filmseansı.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where filmadi='" + filmadı.SelectedItem + "' and salonadi='" + salonadı.SelectedItem + "' and tarih='"+filmtarihi.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["seans"].ToString())>DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                       filmseansı.Items.Add(read["seans"].ToString());
                    }
                                           
                }
               else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                   
                        filmseansı.Items.Add(read["seans"].ToString());
                    

                }

            }
            baglanti.Close();
        }
        private void filmtarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansi_Getir();
        }

        private void filmseansı_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            Veritabani_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();
        }

        private void ücret_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void biletiptal_Click(object sender, EventArgs e)
        {
            if (iptalkoltuk.Text!="")
            {
                try
                {
                    satis.Satış_İptal(filmadı.Text,salonadı.Text,filmtarihi.Text,filmseansı.Text,iptalkoltuk.Text);
                    YenidenRenklendir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu"+hata.Message, "Uyarı");

                }
                

            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız", "Uyarı");
            }
            
        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void koltukno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
