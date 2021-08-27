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
namespace PhanMemQLNhaSach
{
    public partial class frmKhachHang : Form
    {
        DBconnect Conn = new DBconnect();  
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui nhập chọn mã sách");
                    return;
                }
                string strSQL = "select count(*) from khachhang where makh='" + txtMaKH.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã đã tồn tại  " + txtMaKH.Text.Trim() + ". Vui lòng nhập mã khác");
                    txtMaKH.Clear();
                    txtMaKH.Focus();
                    return;
                }
                strSQL = "insert into KHACHHANG values('" + txtMaKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "','" + txtEmail.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "'," + txtSDT.Text.Trim() + ")";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }
        public void LoadDL()
        {
            string sql = "select * from khachhang";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }
        public void LoadDLTim()
        {
            string sql = "select * from khachhang where TENKH = '" + txtTim.Text.Trim() + "'";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];

            txtMaKH.Text = li.Cells[0].Value.ToString().Trim();
            txtTenKH.Text = li.Cells[1].Value.ToString().Trim();
            txtEmail.Text = li.Cells[2].Value.ToString().Trim();
            txtDiaChi.Text = li.Cells[3].Value.ToString().Trim();
            txtSDT.Text = li.Cells[4].Value.ToString().Trim();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                string strSQL = "select count(*) from khachhang where makh='" + txtMaKH.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã loại " + txtMaKH.Text.Trim() + ". Để sửa");
                    txtMaKH.Clear();
                    txtMaKH.Focus();
                    return;
                }
                strSQL = "Update khachhang set tenkh=N'" + txtTenKH.Text.Trim() + "',email = '"+txtEmail.Text.Trim()+"',diachi =N'"+txtDiaChi.Text.Trim()+"', sdt="+txtSDT.Text.Trim()+"  where makh = '" + txtMaKH.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Cập nhật thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Cập nhật Thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã sách");
                    return;
                }

                string strSQL = "select count(*) from khachhang where makh='" + txtMaKH.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã loại " + txtMaKH.Text.Trim() + ". Để Xóa");
                    txtMaKH.Clear();
                    txtMaKH.Focus();
                    return;
                }
                strSQL = "Delete khachhang where makh='" + txtMaKH.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "select * from khachhang where tenkh=N'" + txtTim.Text.Trim() + "'";
                Conn.truyvanDL(strSQL);
                LoadDLTim();
            }
            catch
            {
                MessageBox.Show("Tìm Thất bại");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }
    }
}
