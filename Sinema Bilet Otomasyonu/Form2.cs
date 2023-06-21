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
   
    public partial class Form2 : Form
    {  UserManager userManager;
        public Form2()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (userManager.LoginControl(kullanıcıadı.Text,sifre.Text))
            {
                FormAnasayfa formAnasayfa = new FormAnasayfa();
                formAnasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ve Şifre", "HATA");
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kaydol kaydol = new kaydol();
            kaydol.Show();
            this.Hide();

        }
    }
}
