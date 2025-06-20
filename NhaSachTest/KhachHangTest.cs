using Show10;

namespace NhaSachTest {
    [TestClass]
    public sealed class KhachHangTest {
        NhaSachService service = new();

        [TestMethod]
        public void KhachHang_BlankField() {
            // Arrange
            KhachHang khach = new() {
                MaKH = 0,
                TenKH = "",
                GioiTinh = "",
                Email = "",
                DiaChi = "",
                TienNo = 0
            };

            // Act
            bool isValid = service.IsKhachHangValid(khach);

            // Assert
            Assert.AreEqual(false, isValid, "Có miền trống");
        }
        //[TestMethod]
        public void KhachHang_TenKHTooLong() {
            // Arrange
            KhachHang khach = new() {
                MaKH = 0,
                TenKH = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                GioiTinh = "ads",
                Email = "đâsd",
                DiaChi = "đâsds",
                TienNo = 0
            };

            // Act
            bool isValid = service.IsKhachHangValid(khach);

            // Assert
            Assert.AreEqual(false, isValid, "Tên quá dài!");
        }
        //[TestMethod]
        public void KhachHang_TenCoSo() {
            // Arrange
            KhachHang khach = new() {
                MaKH = 0,
                TenKH = "Nguyen Van 2",
                GioiTinh = "ads",
                Email = "đâsd",
                DiaChi = "đâsds",
                TienNo = 0
            };

            // Act
            bool isValid = service.IsKhachHangValid(khach);

            // Assert
            Assert.AreEqual(false, isValid, "Tên có số!");
        }
        //[TestMethod]
        public void KhachHang_EmailKhongHopLe() {
            // Arrange
            KhachHang khach = new() {
                MaKH = 0,
                TenKH = "Nguyen Van Hai",
                GioiTinh = "ads",
                Email = "đâsd",
                DiaChi = "đâsds",
                TienNo = 0
            };

            // Act
            bool isValid = service.IsKhachHangValid(khach);

            // Assert
            Assert.AreEqual(false, isValid, "Email không hợp lệ!");
        }
    }
}
