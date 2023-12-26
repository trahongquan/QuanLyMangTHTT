using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyMangTHTT
{
    internal class ModifyQLThietBi
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;


        public ModifyQLThietBi() { }

        public DataTable getAllThieBi()
        {
            DataTable dt = new DataTable();
            string SQL = "select * from tbl_ThietBi";
            using (conn = cls_KetNoi.KetNoi())
            {
                conn.Open();
                da = new SqlDataAdapter(SQL, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

    
    }
}
