using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyKhachSan.UserForm
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
        public void ketnoi()
        {
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-BIBNN55\SQLEXPRESS;Initial Catalog = KHACHSAN; Integrated Security = True");
            kn.Open();
            string sql = "Select * from phong";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            tabledataphong.DataSource = data;
        }
        private void Phong_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
    }
}
