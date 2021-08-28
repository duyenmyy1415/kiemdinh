using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Data.SqlClient;
namespace PhanMemQLNhaSach
{
    public partial class frmDangNhap : Form
    {
        DBconnect Conn = new DBconnect();
        public frmDangNhap()
        {
            InitializeComponent();
        }

 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void comboboxNV()
        {
            string sql = "select TaiKhoan,MatKhau from NhanVien";
            Conn.loadCBO(sql);
            DataTable table = new DataTable();
            Conn.Danhsach.Fill(table);
            cboTen.DataSource = table;
            cboTen.DisplayMember = "Taikhoan";
            cboTen.ValueMember = "TaiKhoan";
            cboTen.SelectedItem = 1;

        }

      

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WIN2K\WIN2K;Initial Catalog=QLSACH_BANSACH;Persist Security Info=True;User ID=sa;Password=sa2012");
            try
            {
                conn.Open();
                string sql;
                sql = "select * from NhanVien  where TAIKHOAN='" + cboTen.Text + "' and MATKHAU='" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công", "Thông Báo");
                    frmMain main = new frmMain();
                    this.Hide();
                    main.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void frmDangNhap_Load_1(object sender, EventArgs e)
        {
            comboboxNV();
        }
    }
}
