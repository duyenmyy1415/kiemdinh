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
    public partial class frmNhaXuatBan : Form
    {
        DBconnect Conn = new DBconnect();  
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }
        public void LoadDL()
        {
            string sql = "select * from NHAXUATBAN";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dgvTacGia.DataSource = ds_sach.Tables[0];
            dgvTacGia.Refresh();
        }
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadDL();
        }
    }
}
