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
    public partial class frmTacGia : Form
    {
        DBconnect Conn = new DBconnect();  
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTG.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui nhập chọn mã tác giả");
                    return;
                }
                string strSQL = "select count(*) from tacgia where MATG='" + txtMaTG.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã đã tồn tại  " + txtMaTG.Text.Trim() + ". Vui lòng nhập mã khác");
                    txtMaTG.Clear();
                    txtMaTG.Focus();
                    return;
                }
                strSQL = "INSERT into TACGIA values ('"+txtMaTG.Text+"', N'"+txtTenTG.Text+"', N'"+txtDiaChi.Text+"', '"+txtSDT.Text+"')";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }
        public void LoadDL()
        {
            string sql = "select * from TACGIA";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dgvTacGia.DataSource = ds_sach.Tables[0];
            dgvTacGia.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTG.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã sách");
                    return;
                }

                string strSQL = "select count(*) from tacgia where MATG='" + txtMaTG.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã tác giả " + txtMaTG.Text.Trim() + ". Để Xóa");
                    txtMaTG.Clear();
                    txtMaTG.Focus();
                    return;
                }
                strSQL = "Delete tacgia where MATG='" + txtMaTG.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadDL();

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

                string strSQL = "select count(*) from tacgia where MATG='" + txtMaTG.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã tác giả " + txtMaTG.Text.Trim() + ". Để sửa");
                    txtMaTG.Clear();
                    txtMaTG.Focus();
                    return;
                }
                strSQL = "Update tacgia set TENTG=N'" + txtTenTG.Text + "', DiaChi = N'"+txtDiaChi.Text+"',SDT = '"+txtSDT.Text+"' where MATG = '" + txtMaTG.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Cập nhật thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Cập nhật Thất bại");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "select * from TACGIA where TenTG=N'" + txtTim.Text.Trim() + "'";
                Conn.truyvanDL(strSQL);
                LoadDLTim();
            }
            catch
            {
                MessageBox.Show("Tìm Thất bại");
            }
        }
        public void LoadDLTim()
        {
            string sql = "select * from tacgia where TENTG = '" + txtTim.Text.Trim() + "'";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dgvTacGia.DataSource = ds_sach.Tables[0];
            dgvTacGia.Refresh();
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dgvTacGia.Rows[e.RowIndex];

            txtMaTG.Text = li.Cells[0].Value.ToString().Trim();
            txtTenTG.Text = li.Cells[1].Value.ToString().Trim();
            txtDiaChi.Text = li.Cells[2].Value.ToString().Trim();
            txtSDT.Text = li.Cells[3].Value.ToString().Trim();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
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
