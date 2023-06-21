using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Bilet_Otomasyonu
{
    
    class UserManager
    {
        static UserManager userManager;
        List<User> users = new List<User>()
        {
            new User(1,"büşra","12345"),
            new User(1,"songül","12345"),
            new User(1,"metin","12345"),
        };
        private UserManager()
        {

        }
        public string AddUser(User user)
        {
            try
            {
                if (!IsUserComplete(user))
                {
                    return "Kullanıcı eklenemez";
                }
                
                users.Add(user);
                return user.kullanıcıadı + "Olarak Başarıyla Kaydoldunuz";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
            public string UpdatePassword(int userId ,string password)
            {
                try
                {
                    foreach (User item in users)
                    {
                        if (item.Id==userId)
                        {
                            item.Sifre = password;
                            return "Şifreniz Başarıyla Güncellendi";
                        }
                    }
                    return "Kullanıcı Bulunamadı";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                   
                }
            }
        public bool LoginControl (string userName,string password)
        {
            try
            {
                foreach (User item in users)
                {
                    if(item.kullanıcıadı==userName&&item.Sifre==password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        bool IsUserComplete(User user)
        {
            if (string.IsNullOrEmpty(user.kullanıcıadı) || string.IsNullOrEmpty(user.Sifre)) 
            {
                return false;
            }
            return true;
        }
        bool IsPasswordComplete(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password.Length<8)
            {
                return false;
            }
            return true;
        }
        public static UserManager GetInstance()
        {
            if (userManager==null)
            {
                userManager = new UserManager();
            }
            return userManager;
        }
        }

    }

