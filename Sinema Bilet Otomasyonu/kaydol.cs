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
    public partial class kaydol : Form
    {
        UserManager userManager;
        public kaydol()
        {
            
            InitializeComponent();
            userManager = UserManager.GetInstance();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sifre2.Text != sifretekrar.Text)
            {
                MessageBox.Show("Şifre Bilgileri Birbiriyle Uyuşmuyorlar.");
                return;
            }
            User user = new User(kullanıcıadı2.Text, sifre2.Text);
            MessageBox.Show(userManager.AddUser(user));


        }
    }
}
