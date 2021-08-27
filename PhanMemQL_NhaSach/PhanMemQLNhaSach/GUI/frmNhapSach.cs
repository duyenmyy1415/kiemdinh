using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary1;
namespace PhanMemQLNhaSach
{
    public partial class frmNhapSach : Form
    {
        DBconnect Conn = new DBconnect();
        public frmNhapSach()
        {
            InitializeComponent();
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACHDataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qL_NHASACHDataSet1.SACH);
            txtDonGia.Text = cboTenHang.SelectedValue.ToString();
            LoadDL();   


        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            string strSQL = "insert into phieunhap values(getdate(),null)";
            Conn.updateDatabase(strSQL);
            phieunhap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu nhập");
                    return;
                }
                string strSQL = "select count(*) from CHITIETPHIEUNHAP where mapn='" + txtMa.Text.Trim() + "' and tensach=N'" + cboTenHang.Text +"'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Đã tồn tại mã sách này " + txtMa.Text.Trim() + ". Vui lòng chọn sách khác !!!");
                    return;
                }
                int sl = int.Parse(nru1.Value.ToString());
                int dongia = int.Parse(txtDonGia.Text);
                int thanhtien = sl * dongia;
                strSQL = "insert into CHITIETPHIEUNHAP values(" + txtMa.Text.Trim() + ",N'" + cboTenHang.Text.Trim() + "'," + sl + "," + dongia + "," + thanhtien + ")";
                Conn.updateDatabase(strSQL);
                LoadDL();
                MessageBox.Show("Thêm hàng Thành công");

                XoaTrang();
            }
            catch
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }
        public void phieunhap()
        {
            string strSQL = "select mapn from PHIEUNHAP";
            SqlDataReader rdr = Conn.getDataReader(strSQL);
            while (rdr.Read())
            {
                txtMa.Text = (rdr["mapn"].ToString());

            }

            rdr.Close();

        }
        public void LoadDL()
        {
            string sql = "select p.MAPN,TENSACH,SOLUONGNHAP, DONGIANHAP,THANHTIEN from phieunhap p,CHITIETPHIEUNHAP c where p.mapn=c.mapn";
            Conn.truyvanDL(sql);
            DataSet ds_PN = new DataSet();
            Conn.Danhsach.Fill(ds_PN);
            dgv1.DataSource = ds_PN.Tables[0];
            dgv1.Refresh();
        }
    
        public void XoaTrang()
        {
            cboTenHang.Text = "Vui lòng chọn tên sách";

            nru1.Value = 0;
            cboTenHang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu nhập");
                    return;
                }

                string strSQL = "select count(*) from CHITIETPHIEUNHAP where mapn='" + txtMa.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã hàng " + txtMa.Text.Trim() + ". Để Xóa");
                    txtMa.Clear();
                    txtMa.Focus();
                    return;
                }
                strSQL = "Delete CHITIETPHIEUNHAP where mapn=" + txtMa.Text.Trim() + " and tensach=N'" + cboTenHang.Text + "'";
                Conn.updateDatabase(strSQL);
                LoadDL();
                MessageBox.Show("Xóa thành công");

                XoaTrang();
            }
            catch
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(nru1.Value.ToString());
                int dongia = int.Parse(txtDonGia.Text);
                int thanhtien = sl * dongia;
                string strSQL = "select count(*) from CHITIETPHIEUNHAP where mapn=" + txtMa.Text.Trim() + " and tensach=N'" + cboTenHang.Text + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã sách " + txtMa.Text.Trim() + ". Để sửa");
                    txtMa.Clear();
                    txtMa.Focus();
                    return;
                }
                
                strSQL = "Update CHITIETPHIEUNHAP set soluongnhap=" + sl + ", thanhtien = " + thanhtien + " where mapn='" + txtMa.Text.Trim() + "' and tensach=N'" + cboTenHang.Text + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Cập nhật thành công");
                LoadDL();
                XoaTrang();
            }
            catch
            {
                MessageBox.Show("Cập nhật Thất bại");
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            XoaTrang();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
        }

        private void lblMa_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dgv1.Rows[e.RowIndex];
            txtMa.Text = li.Cells[0].Value.ToString().Trim();
            cboTenHang.Text = li.Cells[1].Value.ToString().Trim();
            nru1.Value = int.Parse(li.Cells[2].Value.ToString().Trim());
            txtDonGia.Text = li.Cells[3].Value.ToString().Trim();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
                string strSQL = "";
                strSQL = "select * from chitietphieunhap where mapn=" + txtTim.Text.Trim();
                Conn.truyvanDL(strSQL);
                DataSet ds_kho = new DataSet();
                Conn.Danhsach.Fill(ds_kho);
                dgv1.DataSource = ds_kho.Tables[0];
                dgv1.Refresh();

        }
    }
}
