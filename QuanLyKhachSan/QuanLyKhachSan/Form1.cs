using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyKhachSan.UserForm;
namespace QuanLyKhachSan
{
    public partial class Form1 : Office2007RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            listViewEx1.Items.Clear();
            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-BIBNN55\SQLEXPRESS;Initial Catalog = KHACHSAN; Integrated Security = True");
            kn.Open();
            string sql = "Select * from phong";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            for(int i=0; i<data.Rows.Count;i++)
            {
                string maphong = data.Rows[i][0].ToString();
                string ttphong= data.Rows[i][2].ToString();
                var item = new ListViewItem(maphong);
                if (ttphong == "TT1       ")
                    item.ImageIndex = 0;
                else if (ttphong == "TT2       ")
                    item.ImageIndex = 1;
                else if (ttphong == "TT3       ")
                    item.ImageIndex = 2;
                else if (ttphong == "TT4       ")
                    item.ImageIndex = 3;
                listViewEx1.Items.Add(item);

            }
            



        }

        private void listViewEx1_MouseClick(object sender, MouseEventArgs e)
        {
            ChiTietPhong.Maphong = listViewEx1.SelectedItems[0].Text;
            ChiTietPhong phong = new ChiTietPhong();

            phong.ShowDialog();
            //string maphong= listViewEx1.SelectedItems[0].Text;
            //MessageBox.Show(maphong);
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            KhachHang kh = new UserForm.KhachHang();
            kh.ShowDialog();
        }

        private void DichVu_Click(object sender, EventArgs e)
        {
            DichVu dv = new UserForm.DichVu();
            dv.ShowDialog();
        }

        private void DSPhong_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.ShowDialog();
        }

        private void NhanPhong_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien ttnv = new ThongTinNhanVien();
            ttnv.ShowDialog();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            dsnv.ShowDialog();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();

        }

        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
