using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhanMemQLNhaSach;
namespace UnitTestProject_Code
{
    [TestClass]
    public class TestAddSach
    {
        private frmQLSach sach;

        public frmQLSach Sach { get => sach; set => sach = value; }

        [TestInitialize]
        public void TestInitialize()
        {
            this.Sach = new frmQLSach();
        }
        [TestMethod]
        [TestCategory("Passs")]
        public void TC1_TestAddSach()
        {
            string maSach = "SH11";
            string tenSach = "Sách TC 1";
            string giaSach = "150000";
            string maTGia = "TG1";
            string maNXB = "NXB1";
            string maTL = "TL1";
            string soLuong = "20";
            int input = TamGiacTest1.kiemTra(num1, num2, num3);
            sach.
            string Expected = "Thêm thành công !";
            Assert.AreEqual(Expected, Sach.btnThem_Click, "Loi xay ra");
        }
    }
}
