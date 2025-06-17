using Show10;

namespace NhaSachTest {

    // Nhớ chuyển Target OS sang Windows

    [TestClass]
    public sealed class TaiKhoanTest {
        NhaSachService service = new();

        [TestMethod]
        public void TaiKhoan_BlankField() {
            // Arrange
            TaiKhoan taiKhoan = new() {
                TenTK = "dá",
                MatKhau = "dsaa",
                HoTen = "",
                VaiTro = "dsa"
            };

            // Act
            bool isValid = service.IsTaiKhoanValid(taiKhoan);

            // Assert
            Assert.AreEqual(false, isValid, "Có miền trống");
        }

        // fix bằng trường MaxLength
        //[TestMethod]
        public void TaiKhoan_UsernameTooLong() {
            // Arrange
            TaiKhoan taiKhoan = new() {
                TenTK = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                MatKhau = "dsa",
                HoTen = "dsa",
                VaiTro = "dsa"
            };

            // Act
            bool isValid = service.IsTaiKhoanValid(taiKhoan);

            // Assert
            Assert.AreEqual(false, isValid, "Tên đăng nhập dài quá!");
        }

        // fix bằng trường MaxLength
        //[TestMethod]
        public void TaiKhoan_PasswordTooLong() {
            // Arrange
            TaiKhoan taiKhoan = new() {
                TenTK = "david",
                MatKhau = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                HoTen = "da",
                VaiTro = "dsa"
            };

            // Act
            bool isValid = service.IsTaiKhoanValid(taiKhoan);

            // Assert
            Assert.AreEqual(false, isValid, "Mật khẩu dài quá!");
        }

        // TextBox_TK_HoTen_KeyPress
        [TestMethod]
        public void TaiKhoan_TenCoSo() {
            // Arrange
            TaiKhoan taiKhoan = new() {
                TenTK = "123",
                MatKhau = "123",
                HoTen = "Nguyễn Văn 2",
                VaiTro = "dsa"
            };

            // Act
            bool isValid = service.IsTaiKhoanValid(taiKhoan);

            // Assert
            Assert.AreEqual(false, isValid, "Tên không được có số!");
        }
    }
}
