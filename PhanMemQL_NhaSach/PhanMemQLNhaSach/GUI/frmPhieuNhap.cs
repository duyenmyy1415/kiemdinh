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
namespace PhanMemQLNhaSach.GUI
{
    public partial class frmPhieuNhap : Form
    {
        DBconnect Conn = new DBconnect();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadDL();
        }
        public void LoadDL()
        {
            string sql = "select * from phieunhap";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPN.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui nhập chọn mã sách");
                    return;
                }
                string strSQL = "select count(*) from phieunhap where mapn='" + txtMaPN.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã đã tồn tại  " + txtMaPN.Text.Trim() + ". Vui lòng nhập mã khác");
                    txtMaPN.Clear();
                    txtMaPN.Focus();
                    return;
                }
                strSQL = "insert into phieunhap values('" + txtMaPN.Text.Trim() + "','" + dtpNgayNhap.Value.ToShortDateString() + "'," + txtTongTien.Text.Trim() + ")";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                string strSQL = "select count(*) from phieunhap where mapn='" + txtMaPN.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã loại " + txtMaPN.Text.Trim() + ". Để sửa");
                    txtMaPN.Clear();
                    txtMaPN.Focus();
                    return;
                }
                strSQL = "Update phieunhap set ngaynhap='" + dtpNgayNhap.Value.ToShortDateString() + "', tongtien = "+txtTongTien.Text+" where mapn = '" + txtMaPN.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Cập nhật thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Cập nhật Thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPN.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã sách");
                    return;
                }

                string strSQL = "select count(*) from phieunhap where mapn='" + txtMaPN.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã loại " + txtMaPN.Text.Trim() + ". Để Xóa");
                    txtMaPN.Clear();
                    txtMaPN.Focus();
                    return;
                }
                strSQL = "Delete phieunhap where mapn='" + txtMaPN.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }
    }
}
