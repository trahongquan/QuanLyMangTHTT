using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMangTHTT
{
    internal class cls_KetNoi
    {
        //private static string stringConnection = @"Data Source=DESKTOP-TMQ39CO\NGUYENQUOCMANH;Initial Catalog=d75;Integrated Security=True";
        private static string stringConnection = "Server = TRHQUAN\\TRHQUANMS;" + "uid=sa;pwd=1;" + "database=d75";
        public static SqlConnection KetNoi()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
     
