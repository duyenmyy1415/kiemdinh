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
        [TestCategory("Passed")]
        public void TC1_TestAddSach()
        {
            string maSach = "SH11";
            string tenSach = "Sách TC 1";
            string giaSach = "150000";
            string maTGia = "TG1";
            string maNXB = "NXB1";
            string maTL = "TL1";
            string soLuong = "20";
            bool input = Sach.themSach(maSach, maNXB, maTGia, maTL, tenSach, soLuong, giaSach);
            bool Expected = true;
            Assert.AreEqual(Expected, input, "Loi xay ra");
        }
        [TestMethod]
        [TestCategory("Failed")]
        public void TC2_TestAddSach()
        {
            string maSach = "SH1";
            string tenSach = "Sách TC 1";
            string giaSach = "150000";
            string maTGia = "TG1";
            string maNXB = "NXB1";
            string maTL = "TL1";
            string soLuong = "20";
            bool input = Sach.themSach(maSach, maNXB, maTGia, maTL, tenSach, soLuong, giaSach);
            bool Expected = true;
            Assert.AreEqual(Expected, input, "Loi xay ra");
        }
        [TestMethod]
        [TestCategory("Passed")]
        public void TC3_TestDeleteSach()
        {
            string maSach = "SH11";
            
            bool input = Sach.xoaSach(maSach);
            bool Expected = true;
            Assert.AreEqual(Expected, input, "Loi xay ra");
        }
    }
}
