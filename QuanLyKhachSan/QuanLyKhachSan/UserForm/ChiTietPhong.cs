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

namespace QuanLyKhachSan.UserForm
{
    public partial class ChiTietPhong : Form
    {
        public ChiTietPhong()
        {
            InitializeComponent();
        }


        public static string Maphong;



        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            DichVuTungPhong dvtp = new DichVuTungPhong();
            dvtp.ShowDialog();
        }

        private void ChiTietPhong_Load(object sender, EventArgs e)
        {

            SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-BIBNN55\SQLEXPRESS;Initial Catalog = KHACHSAN; Integrated Security = True");
            kn.Open();
            
            try
            {
                string sql = " SELECT p.maphong,P.LoaiPhong,LP.gia,LP.songuoi,KH.tenkhachhang,KH.sodienthoai,KH.cmnd_passport,PDP.songuoi FROM dbo.khachhang AS KH, dbo.chitietdatphong AS  CTDP, dbo.phieudatphong AS PDP,phong AS P,loaiphong AS LP WHERE KH.makhachhang = PDP.makhachhang AND PDP.maphieudat = CTDP.maphieudat AND P.maphong = '" + Maphong + "' AND P.LoaiPhong = LP.maloai AND P.maphong = CTDP.maphong";
                //MessageBox.Show(sql);

                SqlCommand commandsql = new SqlCommand(sql, kn);

                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable data = new DataTable();
                com.Fill(data);
                DataRow dr = data.Rows[0];
                lb_tenp.Text = dr.ItemArray[0].ToString();
                lb_lp.Text = dr.ItemArray[1].ToString();
                lp_gp.Text = dr.ItemArray[2].ToString();
                txt_songuoidp.Text = dr.ItemArray[7].ToString() + "/" + dr.ItemArray[3].ToString();
                txt_ten.Text = dr.ItemArray[4].ToString();
                txt_sdt.Text = dr.ItemArray[5].ToString();
                txt_socm.Text = dr.ItemArray[6].ToString();
            }
            catch
            {
                string sql = "Select p.maphong,P.LoaiPhong,LP.gia,Lp.songuoi from phong AS P,loaiphong AS LP WHERE maphong = '"+Maphong+"' AND P.LoaiPhong = LP.maloai";
                SqlCommand commandsql = new SqlCommand(sql, kn);

                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable data = new DataTable();
                com.Fill(data);
                DataRow dr = data.Rows[0];
                lb_tenp.Text = dr.ItemArray[0].ToString();
                lb_lp.Text = dr.ItemArray[1].ToString();
                lp_gp.Text = dr.ItemArray[2].ToString();
                txt_songuoidp.Text = "0/" + dr.ItemArray[3].ToString();
            }

            



        }
    }
}
