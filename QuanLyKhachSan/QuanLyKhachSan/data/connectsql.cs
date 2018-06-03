using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyKhachSan.data
{
    class Connectsql
    {
        public void ketnoi()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP - BIBNN55\SQLEXPRESS;Initial Catalog = KHACHSAN; Integrated Security = True");
            kn.Open();
            
        }
    }

}
