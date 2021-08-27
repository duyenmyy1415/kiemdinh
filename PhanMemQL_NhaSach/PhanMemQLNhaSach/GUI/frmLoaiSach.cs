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
    public partial class frmLoaiSach : Form
    {
        DBconnect Conn = new DBconnect();  
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui nhập chọn mã sách");
                    return;
                }
                string strSQL = "select count(*) from THELOAI where MATL='" + txtMaLoai.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã đã tồn tại  " + txtMaLoai.Text.Trim() + ". Vui lòng nhập mã khác");
                    txtMaLoai.Clear();
                    txtMaLoai.Focus();
                    return;
                }
                strSQL = "insert into THELOAI values('" + txtMaLoai.Text.Trim() + "',N'" + txtTenLoai.Text.Trim() + "')";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã sách");
                    return;
                }

                string strSQL = "select count(*) from THELOAI where MATL='" + txtMaLoai.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã loại " + txtMaLoai.Text.Trim() + ". Để Xóa");
                    txtMaLoai.Clear();
                    txtMaLoai.Focus();
                    return;
                }
                strSQL = "Delete THELOAI where MATL='" + txtMaLoai.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }
        public void LoadDL()
        {
            string sql = "select * from THELOAI";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }
        
        public void LoadDLTim()
        {
            string sql = "select * from THELOAI where TENTL = '" + txtTim.Text.Trim() + "'";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];

            txtMaLoai.Text = li.Cells[0].Value.ToString().Trim();
            txtTenLoai.Text = li.Cells[1].Value.ToString().Trim();
            
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                string strSQL = "select count(*) from THELOAI where MATL='" + txtMaLoai.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã loại " + txtMaLoai.Text.Trim() + ". Để sửa");
                    txtMaLoai.Clear();
                    txtMaLoai.Focus();
                    return;
                }
                strSQL = "Update THELOAI set TENTL=N'" + txtTenLoai.Text + "' where MATL = '" + txtMaLoai.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Cập nhật thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Cập nhật Thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "select * from THELOAI where TENTL=N'" + txtTim.Text.Trim() + "'";
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
    }
}
