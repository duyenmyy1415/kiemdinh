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
    public partial class frmBanHang : Form
    {
        DBconnect Conn = new DBconnect();
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtMaHD.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Vui nhập chọn mã sách");
            //        return;
            //    }
            //    string strSQL = "select count(*) from chitiethoadon where mahd='" + txtMaHD.Text.Trim() + "'";
            //    if (Conn.KiemTraTrung(strSQL))
            //    {
            //        MessageBox.Show("Mã đã tồn tại  " + txtMaKH.Text.Trim() + ". Vui lòng nhập mã khác");
            //        txtMaKH.Clear();
            //        txtMaKH.Focus();
            //        return;
            //    }
            //    strSQL = "insert into KHACHHANG values('" + txtMaKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "','" + txtEmail.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "'," + txtSDT.Text.Trim() + ")";
            //    Conn.updateDatabase(strSQL);

            //    MessageBox.Show("Thêm thành công");
            //    LoadDL();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thêm Thất bại");
            //}
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            frmHoaDon a = new frmHoaDon();
            a.ShowDialog();
            
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDL();
            
            string sql = "select  * from hoadon";
            Conn.loadCBO(sql);
            DataTable table1 = new DataTable();
            Conn.Danhsach.Fill(table1);
            cboMaHD.DataSource = table1;
            cboMaHD.DisplayMember = "mahd";
            cboMaHD.ValueMember = "mahd";
            cboMaHD.SelectedItem = 1;

            string sqlkh = "select * from sach";
            Conn.loadCBO(sqlkh);
            DataTable table2 = new DataTable();
            Conn.Danhsach.Fill(table2);
            cboTen.DataSource = table2;
            cboTen.DisplayMember = "tensach";
            cboTen.ValueMember = "masach";
            cboTen.SelectedItem = 1;

            
            


        }
        public void loadcbo()
        {
            
        }
        public void LoadDL()
        {
            string sql = "select * from ChiTietHD";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            int gia = int.Parse(cboGia.SelectedValue.ToString());
            int sl = int.Parse(numSoLuong.Value.ToString());
            txtTongTien.Text = (gia * sl).ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            try
            {

                string strSQL = "insert into ChiTIetHD values(" + cboMaHD.SelectedValue.ToString() + ",N'" + cboTen.SelectedValue.ToString() + "'," + numSoLuong.Value.ToString() + "," + cboGia.SelectedValue.ToString() + "," + txtTongTien.Text.Trim() + ")";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }

        private void cboTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlhd = "select * from Sach where MASACH = '" + cboTen.SelectedValue.ToString().Trim() + "'";
            Conn.loadCBO(sqlhd);
            DataTable table3 = new DataTable();
            Conn.Danhsach.Fill(table3);
            cboGia.DataSource = table3;
            cboGia.DisplayMember = "GIABAN";
            cboGia.ValueMember = "GIABAN";
            cboGia.SelectedItem = 1;
        }
    }
}
