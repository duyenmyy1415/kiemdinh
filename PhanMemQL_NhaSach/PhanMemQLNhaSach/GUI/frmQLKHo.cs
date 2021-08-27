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
using PhanMemQLNhaSach.GUI;
namespace PhanMemQLNhaSach
{
    public partial class frmQLKHo : Form
    {
        DBconnect Conn = new DBconnect();
        public frmQLKHo()
        {
            InitializeComponent();
        }

        

        private void frmQLKHo_Load(object sender, EventArgs e)
        {
            LoadDL();
            string sql = "select  * from phieunhap";
            Conn.loadCBO(sql);
            DataTable table1 = new DataTable();
            Conn.Danhsach.Fill(table1);
            cboMaPN.DataSource = table1;
            cboMaPN.DisplayMember = "mapn";
            cboMaPN.ValueMember = "mapn";
            cboMaPN.SelectedItem = 1;
        }

        public void LoadDL()
        {
            string sql = "select * from chitietphieunhap";
            Conn.truyvanDL(sql);
            DataSet ds_kho = new DataSet();
            Conn.Danhsach.Fill(ds_kho);
            dataGridView1.DataSource = ds_kho.Tables[0];
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            cboMaPN.Text = li.Cells[0].Value.ToString().Trim();
            txtTen.Text = li.Cells[1].Value.ToString().Trim();
           
            numSoLuong.Value = int.Parse(li.Cells[2].Value.ToString().Trim());
            txtDonGia.Text = li.Cells[3].Value.ToString().Trim();
        }

        

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "select * from chitietphieunhap where mapn= "+txtTim.Text.Trim();
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
            string sql = "select * from chitietphieunhap where mapn = "+txtTim.Text.Trim() ;
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }
        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapSach NhapSach = new frmNhapSach();
            NhapSach.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPhieuNhap a = new frmPhieuNhap();
            a.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int sl = int.Parse(numSoLuong.Value.ToString());
            int dongia = int.Parse(txtDonGia.Text);
            txtThanhTien.Text = (sl * dongia).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string strSQL = "insert into chitietphieunhap values('" + cboMaPN.SelectedValue.ToString() + "',N'" + txtTen.Text + "'," + numSoLuong.Value.ToString() + "," + txtDonGia.Text + "," + txtThanhTien.Text + ")";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }
    }
}
