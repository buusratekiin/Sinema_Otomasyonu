using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Bilet_Otomasyonu
{
    class User
    {
        int _id; string _kullanıcıadı,_sifre;
        public int Id { get => _id; set => _id = value; }
        public string kullanıcıadı { get => _kullanıcıadı; set => _kullanıcıadı = value; }
        public string Sifre { get => _sifre; set => _sifre = value; }
        
        public User(int id,string kullanıcıadı,string sifre)
        {
            _id = id;
            _kullanıcıadı = kullanıcıadı;
            _sifre = sifre;
            
        }

        public User(string kullanıcıadı, string sifre)
        {
            _kullanıcıadı = kullanıcıadı;
            _sifre = sifre;
        }
    }
}
