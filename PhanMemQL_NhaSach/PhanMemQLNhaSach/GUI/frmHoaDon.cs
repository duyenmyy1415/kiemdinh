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
    public partial class frmHoaDon : Form
    {
        DBconnect Conn = new DBconnect();  
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
      
            string sql;
            sql = "select  * from Khachhang";
            Conn.loadCBO(sql);
            DataTable table1 = new DataTable();
            Conn.Danhsach.Fill(table1);
            cboMaKH.DataSource = table1;
            cboMaKH.DisplayMember = "tenkh";
            cboMaKH.ValueMember = "makh";
            cboMaKH.SelectedItem = 1;


            string sqlNV;
            sql = "select  * from NHanVien";
            Conn.loadCBO(sql);
            DataTable table2 = new DataTable();
            Conn.Danhsach.Fill(table2);
            cboNhanVien.DataSource = table2;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.SelectedItem = 1;

            

            LoadDL();
    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtMaHD.Text.Trim().Length == 0)
                //{
                //    MessageBox.Show("Vui nhập chọn mã Hóa Đơn");
                //    return;
                //}
                string strSQL = "select count(*) from HoaDOn where MaHD='" + txtMaHD.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã đã tồn tại  " + txtMaHD.Text.Trim() + ". Vui lòng nhập mã khác");
                    txtMaHD.Clear();
                    txtMaHD.Focus();
                    return;
                }
                //strSQL = "insert into HoaDOn values('" + txtMaHD.Text.Trim() + "','" + cboMaKH.SelectedValue.ToString().Trim() + "','" + cboNhanVien.SelectedValue.ToString().Trim() + "','" + dtpNgayLap.Value.ToShortDateString().Trim() + "',null)";
                strSQL = "insert into HoaDOn values('" + cboMaKH.SelectedValue.ToString().Trim() + "','" + cboNhanVien.SelectedValue.ToString().Trim() + "','" + dtpNgayLap.Value.ToShortDateString().Trim() + "',null)";
                
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();
                frmBanHang bh = new frmBanHang();
                bh.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm Thất bại"+ex.Message);
            }
            
        }
        public void LoadDL()
        {
            string sql = "select * from hoadon";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            txtMaHD.Text = li.Cells[0].Value.ToString().Trim();
            cboMaKH.Text = li.Cells[1].Value.ToString().Trim();
            cboNhanVien.Text = li.Cells[2].Value.ToString().Trim();
            dtpNgayLap.Text = li.Cells[3].Value.ToString().Trim();
  
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
