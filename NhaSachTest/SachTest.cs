using Show10;


namespace NhaSachTest {
    [TestClass]
    public sealed class SachTest {
        NhaSachService service = new();

        [TestMethod]
        public void Sach_BlankField() {
            // Arrange
            Sach sach = new() {
                MaSach = 1,
                TenSach = "",
                TacGia = "",
                SoLuong = 0,
                TheLoai = ""
            };

            // Act
            bool isValid = service.IsSachValid(sach);

            // Assert
            Assert.AreEqual(false, isValid, "Có miền trống");
        }

        [TestMethod]
        public void PhieuNhapSach_BlankField() {
            // Arrange
            PhieuNhapSach phieu = new() {
                MaPN = 1,
                MaSach = 1,
                SoLuong = 1,
                GiaNhap = 0,
                NgayNhap = default,
                NhaCungCap = ""
            };

            // Act
            bool isValid = service.IsPNSValid(phieu);

            // Assert
            Assert.AreEqual(false, isValid, "Có miền trống");
        }

    }
}
