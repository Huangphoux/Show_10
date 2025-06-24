namespace Show10 {
    public class NhaSachService {
        public bool IsDangNhapDangKyValid(string tenTK, string matKhau) {
            if (string.IsNullOrWhiteSpace(tenTK)) return false;
            if (string.IsNullOrWhiteSpace(matKhau)) return false;

            return true;
        }

        public bool IsTaiKhoanValid(TaiKhoan taiKhoan) {
            if (string.IsNullOrWhiteSpace(taiKhoan.TenTK)) return false;
            if (string.IsNullOrWhiteSpace(taiKhoan.MatKhau)) return false;

            if (string.IsNullOrWhiteSpace(taiKhoan.HoTen)) return false;

            if (taiKhoan.HoTen.Any(char.IsDigit)) return false;

            return true;
        }

        public bool IsSachValid(Sach sach) {
            if (string.IsNullOrWhiteSpace(sach.TenSach)) return false;
            if (string.IsNullOrWhiteSpace(sach.TacGia)) return false;
            if (string.IsNullOrWhiteSpace(sach.TheLoai)) return false;
            if (sach.SoLuong < 0) return false;

            return true;
        }

        public bool IsPNSValid(PhieuNhapSach phieu) {
            if (phieu.MaSach <= 0) return false;
            if (phieu.SoLuong <= 0) return false;
            if (phieu.GiaNhap < 0) return false;
            if (string.IsNullOrWhiteSpace(phieu.NhaCungCap)) return false;
            if (phieu.NgayNhap == default) return false;



            return true;
        }

        public bool IsHoaDonValid(HoaDonBanSach hoaDon) {
            if (hoaDon.MaSach <= 0) return false;
            if (hoaDon.MaKH <= 0) return false;
            if (hoaDon.SoLuong <= 0) return false;
            if (hoaDon.GiaBan < 0) return false;
            if (hoaDon.TongTien < 0) return false;
            if (hoaDon.SoTienTra < 0) return false;
            if (hoaDon.ConLai < 0) return false;
            if (hoaDon.NgayHD == default) return false;

            return true;
        }

        public bool IsKhachHangValid(KhachHang khach) {
            if (string.IsNullOrWhiteSpace(khach.TenKH)) return false;
            if (string.IsNullOrWhiteSpace(khach.GioiTinh)) return false;
            if (string.IsNullOrWhiteSpace(khach.Email)) return false;
            if (string.IsNullOrWhiteSpace(khach.DiaChi)) return false;
            if (khach.TienNo < 0) return false;

            return true;
        }

        public bool IsPTTValid(PhieuThuTien phieu) {
            if (phieu.MaKH <= 0) return false;
            if (phieu.SoTien <= 0) return false;
            if (phieu.NgayThu == default) return false;

            return true;
        }
    }
}
