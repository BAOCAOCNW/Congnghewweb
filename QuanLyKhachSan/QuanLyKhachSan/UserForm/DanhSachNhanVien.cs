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
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
            kn.Open();
            InitializeComponent();
            
        }
        string strkn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True";
        SqlConnection kn;
        private void LoadData()

        {
            string sql = "SELECT MA_NV,HOTEN,NGAYSINH,GIOITINH,DIACHI,SDT,CHUCVU FROM NHANVIEN";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            // SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhongBan", conn); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            tablenhanvien.DataSource = dt;
        }
        DataTable data = new DataTable();
       
        public void ketnoi()
        {
            //SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
            kn.Open();
            string sql = "SELECT MA_NV AS N'Mã Nhân Viên', HOTEN AS N'Tên Nhân Viên' ,DIACHI AS N'Địa Chỉ', NGAYSINH AS N'Ngày Sinh',SDT AS N'SDT', CHUCVU AS N'Chức Vụ' FROM dbo.nhanvien";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);

            com.Fill(data);
            tablenhanvien.DataSource = data;

        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void tablenhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            int index = tablenhanvien.CurrentRow.Index;
			txt_ma.Text = tablenhanvien.Rows[index].Cells[6].Value.ToString();
			txt_ten.Text = tablenhanvien.Rows[index].Cells[1].Value.ToString();
            txt_diachi.Text = tablenhanvien.Rows[index].Cells[2].Value.ToString();
            txt_sdt.Text = tablenhanvien.Rows[index].Cells[4].Value.ToString();
            txt_chucvu.Text = tablenhanvien.Rows[index].Cells[5].Value.ToString();
            txt_ngaysinh.Text = tablenhanvien.Rows[index].Cells[3].Value.ToString();
           


        }

		private void bt_them_Click(object sender, EventArgs e)
		{
			SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
			kn.Open();
			SqlCommand cmd = new SqlCommand("SP_ThemNV", kn);

			cmd.CommandType = CommandType.StoredProcedure;

			SqlParameter p = new SqlParameter("@MaNV", txt_ma.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@TenNV", txt_ten.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@DiaChi", txt_diachi.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@Sdt", txt_sdt.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@ChucVu", txt_chucvu.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@NgaySinh", txt_ngaysinh.Text);
			cmd.Parameters.Add(p);

            if (rdbNam.Checked)
                p = new SqlParameter("@GT", "1");
            else
                p = new SqlParameter("@GT", "0");
            cmd.Parameters.Add(p);


            int count = cmd.ExecuteNonQuery();
			if (count > 0)
			{
				MessageBox.Show("Thêm mới thành công");
				ketnoi();
			}
			else
				MessageBox.Show("Không thể thêm mới");
		}

		private void bt_sua_Click(object sender, EventArgs e)
		{
			SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
			kn.Open();
			SqlCommand cmd = new SqlCommand("SP_SuaNV", kn);

			cmd.CommandType = CommandType.StoredProcedure;

			SqlParameter p = new SqlParameter("@MaNV", txt_ma.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@TenNV", txt_ten.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@DiaChi", txt_diachi.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@Sdt", txt_sdt.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@ChucVu", txt_chucvu.Text);
			cmd.Parameters.Add(p);

			p = new SqlParameter("@NgaySinh", txt_ngaysinh.Text);
			cmd.Parameters.Add(p);

            if (rdbNam.Checked)
                p = new SqlParameter("@GT", "1");
            else
                p = new SqlParameter("@GT", "0");
            cmd.Parameters.Add(p);

            int count = cmd.ExecuteNonQuery();
			if (count > 0)
			{
				MessageBox.Show("Sửa thành công!");
				ketnoi();
			}
			else
				MessageBox.Show("Không sửa được!");
		}

		private void bt_xoa_Click(object sender, EventArgs e)
		{
			SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
			kn.Open();
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
			{
				SqlCommand cmd = new SqlCommand("SP_XoaNV", kn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlParameter p = new SqlParameter("@MaNV", txt_ma.Text);
				cmd.Parameters.Add(p);

				int count = cmd.ExecuteNonQuery();
				if (count > 0)
				{
					MessageBox.Show("Xóa thành công!");
					ketnoi();
					txt_ma.Text = "";
					txt_ten.Text = "";
				}
				else
					MessageBox.Show("Không thể xóa bản ghi hiện thời!");
			}
		}

        private void tablenhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablenhanvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            tablenhanvien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void tablenhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_ma.Text = Convert.ToString(tablenhanvien.CurrentRow.Cells["MA_NV"].Value);
                txt_ten.Text = Convert.ToString(tablenhanvien.CurrentRow.Cells["HOTEN"].Value);
                txt_diachi.Text = Convert.ToString(tablenhanvien.CurrentRow.Cells["DIACHI"].Value);
                txt_sdt.Text = Convert.ToString(tablenhanvien.CurrentRow.Cells["SDT"].Value);
                txt_ngaysinh.Text = Convert.ToString(tablenhanvien.CurrentRow.Cells["NGAYSINH"].Value);
                txt_chucvu.Text = Convert.ToString(tablenhanvien.CurrentRow.Cells["CHUCVU"].Value);
                if (tablenhanvien.Rows[e.RowIndex].Cells["GIOITINH"].Value.ToString() == "1") rdbNam.Checked = true;
                else rdbNu.Checked = true;

            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
                kn.Open();
                string sqlTimKiem = "select * from NHANVIEN where Ma_NV='" + txt_ma.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, kn);

                cmd.Parameters.AddWithValue("Ma_NV", txt_ma.Text.Trim());
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                tablenhanvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
