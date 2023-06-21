using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Sinema_Bilet_Otomasyonu
{
    class Class1
    {
        public static string sqlconnection = ConfigurationManager.ConnectionStrings["Sinema_Bilet_Otomasyonu.Properties.Settings.dbSinema_BiletiConnectionString"].ConnectionString;
    }
}
