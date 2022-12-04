using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection baglanti = new SqlConnection(
            @"Data Source=DESKTOP-3DO8R5T;Initial Catalog=yazOkulu;Integrated Security=True;Connect 
            Timeout=30;Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
