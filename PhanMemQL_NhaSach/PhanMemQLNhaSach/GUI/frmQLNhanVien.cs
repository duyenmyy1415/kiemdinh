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
    public partial class frmQLNhanVien : Form
    {
        DBconnect Conn = new DBconnect();
        string gt = "";
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã NV");
                    return;
                }
                string strSQL = "select count(*) from nhanvien where manv='" + txtMaNV.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại " + txtMaNV.Text.Trim() + ".Vui lòng nhập mã khác");
                    txtMaNV.Clear();
                    txtMaNV.Focus();
                    return;
                }
                strSQL = "insert into nhanvien values('" + txtMaNV.Text.Trim() + "',N'" + txtTenNV.Text.Trim() + "',N'" + gt.Trim() + "',N'" + dtbNgaySinh.Value.ToShortDateString() + "',N'" + txtDiaChi.Text.Trim() + "',N'" + txtEmail.Text.Trim() + "')";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm Thành công");
                LOAD();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                string strSQL = "select count(*) from nhanvien where manv='" + txtMaNV.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã Nhân viên" + txtMaNV.Text.Trim() + "không tồn tại!!");
                    txtMaNV.Clear();
                    txtMaNV.Focus();
                    return;
                }
                strSQL = "Update nhanvien set tennv=N'" + txtTenNV.Text + "' , gioitinh=N'" + gt.Trim() + "',ngaysinh='" + dtbNgaySinh.Value.ToShortDateString() + "',diachi=N'" + txtDiaChi.Text.Trim() + "',email='" + txtEmail.Text.Trim() + "' where manv='" + txtMaNV.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Sửa thành công");
                LOAD();

            }
            catch
            {
                MessageBox.Show("Sửa Thất bại");
            }
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            LOAD();
            LoadComBoBox();
        }
        public void LOAD()
        {
            string sql = "select * from nhanvien";
            Conn.truyvanDL(sql);

            DataSet ds_nhanvien = new DataSet();
            Conn.Danhsach.Fill(ds_nhanvien);
            dataGridView1.DataSource = ds_nhanvien.Tables[0];
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text = li.Cells[0].Value.ToString().Trim();
            txtTenNV.Text = li.Cells[1].Value.ToString().Trim();
            if (li.Cells[2].Value.ToString().Trim() == "Nam")
            {
                rdoNam.Checked = true;
            }
            if (li.Cells[2].Value.ToString().Trim() == "Nữ")
            {
                
                rdoNu.Checked = true;
            }
                
           
            dtbNgaySinh.Text = li.Cells[3].Value.ToString().Trim();
            txtDiaChi.Text = li.Cells[4].Value.ToString().Trim();
            txtEmail.Text = li.Cells[5].Value.ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên");
                    return;
                }

                string strSQL = "select count(*) from nhanvien where manv='" + txtMaNV.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã nhân viên " + txtMaNV.Text.Trim() + "Này!!");
                    txtMaNV.Clear();
                    txtMaNV.Focus();
                    return;
                }
                strSQL = "Delete nhanvien where manv='" + txtMaNV.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Xóa thành công");
                LOAD();
            }
            catch
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            gt = "Nam";
        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {
            gt = "Nữ";
        }

        private void cboTimNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string cbTen = cboTimNhanVien.Text.ToString();
                string strSQL = "";
                strSQL = "select * from nhanvien where manv like N'" + cbTen + "%'";
                Conn.truyvanDL(strSQL);
                DataSet ds_nv = new DataSet();
                Conn.Danhsach.Fill(ds_nv);
                dataGridView1.DataSource = ds_nv.Tables[0];
                dataGridView1.Refresh();

            }
            catch
            {
                MessageBox.Show("tìm kiếm  Thất bại");
            }
        }
        public void LoadComBoBox()
        {
            string sql = "select  manv from nhanvien";
            Conn.loadCBO(sql);
            DataTable table = new DataTable();
            Conn.Danhsach.Fill(table);
            cboTimNhanVien.DataSource = table;
            cboTimNhanVien.DisplayMember = "manv";
            cboTimNhanVien.SelectedItem = null;
            cboTimNhanVien.SelectedText = "Hãy chọn mã nhân viên";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }

        private void btnTaiLại_Click(object sender, EventArgs e)
        {
            LOAD();
        }
    }
}
