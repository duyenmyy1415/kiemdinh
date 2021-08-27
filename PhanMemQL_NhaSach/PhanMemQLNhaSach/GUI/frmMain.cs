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
    public partial class frmMain : Form
    {
        DBconnect Conn = new DBconnect();
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuHeThong_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuThanhToan_Click(object sender, EventArgs e)
        {
            frmHoaDon banhang = new frmHoaDon();
          
            banhang.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe nv = new frmThongKe();
      
            nv.ShowDialog();
        }

        private void mnuKho_Click(object sender, EventArgs e)
        {
            
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLSach s = new frmQLSach();
           
            s.ShowDialog();
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSach  ls= new frmLoaiSach();
   
            ls.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Do you want to exit (haha bé đạt đây) ???","Thông báo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (DialogResult.Yes == thongbao)
                this.Close();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia s = new frmTacGia();

            s.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanVien nv = new frmQLNhanVien();

            nv.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang nv = new frmKhachHang();

            nv.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKHo a = new frmQLKHo();
            a.ShowDialog();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan a = new frmNhaXuatBan();
            a.ShowDialog();
        }

    }
}
