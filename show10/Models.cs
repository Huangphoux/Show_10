using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Show10 {
    public class TaiKhoan {
        [Key]
        public required string TenTK { get; set; }
        public required string MatKhau { get; set; }
        public required string HoTen { get; set; }
        public required string VaiTro { get; set; }
    }
    public class Sach {
        [Key]
        public required int MaSach { get; set; }
        public required string TenSach { get; set; }
        public required string TacGia { get; set; }
        public required int SoLuong { get; set; }
        public required string TheLoai { get; set; }
    }
    public class PhieuThuTien {
        [Key]
        public required int MaPT { get; set; }
        public required int MaKH { get; set; }
        [Column(TypeName = "smalldatetime")]
        public required DateTime NgayThu { get; set; }
        [Column(TypeName = "money")]
        public required double SoTien { get; set; }
    }
    public class PhieuNhapSach {
        [Key]
        public required int MaPN { get; set; }
        public required int MaSach { get; set; }
        public required int SoLuong { get; set; }
        [Column(TypeName = "money")]
        public required double GiaNhap { get; set; }
        public required DateTime NgayNhap { get; set; }
        public required string NhaCungCap { get; set; }

    }
    public class KhachHang {
        [Key]
        public required int MaKH { get; set; }
        public required string TenKH { get; set; }
        public required string GioiTinh { get; set; }
        public required string Email { get; set; }
        public required string DiaChi { get; set; }
        [Column(TypeName = "money")]
        public required double TienNo { get; set; }

    }
    public class HoaDonBanSach {
        [Key]
        public required int MaHD { get; set; }
        public required int MaSach { get; set; }
        public required int MaKH { get; set; }
        public required int SoLuong { get; set; }
        [Column(TypeName = "money")]
        public required double GiaBan { get; set; }
        public required double TongTien { get; set; }
        public required double SoTienTra { get; set; }
        public required double ConLai { get; set; }
        public required DateTime NgayHD { get; set; }
    }
    public class BaoCaoTon {
        [Key]
        public required string TenSach { get; set; }
        public required int TonDau { get; set; }
        public required int PhatSinh { get; set; }
        public required int TonCuoi { get; set; }
    }
    public class BaoCaoNo {
        [Key]
        public required string TenKH { get; set; }
        [Column(TypeName = "money")]
        public required double NoDau { get; set; }
        [Column(TypeName = "money")]
        public required double PhatSinh { get; set; }
        [Column(TypeName = "money")]
        public required double NoCuoi { get; set; }
    }
}
