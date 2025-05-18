using Microsoft.EntityFrameworkCore;
using Show10.Models;

namespace Show10 {
    internal class NhaSachContext : DbContext {
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        public DbSet<PhieuThuTien> PhieuThuTiens { get; set; }
        public DbSet<PhieuNhapSach> PhieuNhapSachs { get; set; }
        public DbSet<HoaDonBanSach> HoaDonBanSachs { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TaiKhoan>().HasData(
                new TaiKhoan { TenTK = "admin", MatKhau = "123", HoTen = "Trương Hoàng Phúc", VaiTro = "admin" },
                new TaiKhoan { TenTK = "user1", MatKhau = "pass1", HoTen = "Nguyễn Văn A", VaiTro = "user" },
                new TaiKhoan { TenTK = "user2", MatKhau = "pass2", HoTen = "Lê Thị B", VaiTro = "user" },
                new TaiKhoan { TenTK = "user3", MatKhau = "pass3", HoTen = "Trần Văn C", VaiTro = "user" },
                new TaiKhoan { TenTK = "user4", MatKhau = "pass4", HoTen = "Phạm Thị D", VaiTro = "user" },
                new TaiKhoan { TenTK = "user5", MatKhau = "pass5", HoTen = "Hoàng Văn E", VaiTro = "user" },
                new TaiKhoan { TenTK = "user6", MatKhau = "pass6", HoTen = "Đỗ Thị F", VaiTro = "user" },
                new TaiKhoan { TenTK = "user7", MatKhau = "pass7", HoTen = "Vũ Văn G", VaiTro = "user" },
                new TaiKhoan { TenTK = "user8", MatKhau = "pass8", HoTen = "Bùi Thị H", VaiTro = "user" },
                new TaiKhoan { TenTK = "user9", MatKhau = "pass9", HoTen = "Ngô Văn I", VaiTro = "user" },
                new TaiKhoan { TenTK = "user10", MatKhau = "pass10", HoTen = "Dương Thị K", VaiTro = "user" }
            );

            modelBuilder.Entity<Sach>().HasData(
                new Sach { MaSach = 1, TenSach = "Minna", SoLuong = 123, TacGia = "Minna", TheLoai = "SGK" },
                new Sach { MaSach = 2, TenSach = "C# Programming", SoLuong = 50, TacGia = "John Doe", TheLoai = "Programming" },
                new Sach { MaSach = 3, TenSach = "ASP.NET Core Guide", SoLuong = 30, TacGia = "Jane Smith", TheLoai = "Web Development" },
                new Sach { MaSach = 4, TenSach = "Entity Framework Core", SoLuong = 40, TacGia = "Alex Brown", TheLoai = "Database" },
                new Sach { MaSach = 5, TenSach = "Clean Code", SoLuong = 25, TacGia = "Robert C. Martin", TheLoai = "Software Engineering" },
                new Sach { MaSach = 6, TenSach = "Design Patterns", SoLuong = 35, TacGia = "Erich Gamma", TheLoai = "Software Engineering" },
                new Sach { MaSach = 7, TenSach = "Introduction to Algorithms", SoLuong = 20, TacGia = "Thomas H. Cormen", TheLoai = "Algorithms" },
                new Sach { MaSach = 8, TenSach = "The Pragmatic Programmer", SoLuong = 15, TacGia = "Andrew Hunt", TheLoai = "Software Engineering" },
                new Sach { MaSach = 9, TenSach = "Refactoring", SoLuong = 18, TacGia = "Martin Fowler", TheLoai = "Software Engineering" },
                new Sach { MaSach = 10, TenSach = "Artificial Intelligence", SoLuong = 22, TacGia = "Stuart Russell", TheLoai = "AI" },
                new Sach { MaSach = 11, TenSach = "Deep Learning", SoLuong = 12, TacGia = "Ian Goodfellow", TheLoai = "AI" }
            );

            modelBuilder.Entity<PhieuThuTien>().HasData(
                new PhieuThuTien { MaPT = 1, MaKH = 1, NgayThu = new DateTime(2025, 05, 08), SoTien = 50000 },
                new PhieuThuTien { MaPT = 2, MaKH = 2, NgayThu = new DateTime(2025, 05, 09), SoTien = 75000 },
                new PhieuThuTien { MaPT = 3, MaKH = 3, NgayThu = new DateTime(2025, 05, 10), SoTien = 60000 },
                new PhieuThuTien { MaPT = 4, MaKH = 4, NgayThu = new DateTime(2025, 05, 11), SoTien = 80000 },
                new PhieuThuTien { MaPT = 5, MaKH = 5, NgayThu = new DateTime(2025, 05, 12), SoTien = 55000 },
                new PhieuThuTien { MaPT = 6, MaKH = 1, NgayThu = new DateTime(2025, 05, 13), SoTien = 90000 },
                new PhieuThuTien { MaPT = 7, MaKH = 2, NgayThu = new DateTime(2025, 05, 14), SoTien = 45000 },
                new PhieuThuTien { MaPT = 8, MaKH = 3, NgayThu = new DateTime(2025, 05, 15), SoTien = 70000 },
                new PhieuThuTien { MaPT = 9, MaKH = 4, NgayThu = new DateTime(2025, 05, 16), SoTien = 65000 },
                new PhieuThuTien { MaPT = 10, MaKH = 5, NgayThu = new DateTime(2025, 05, 17), SoTien = 72000 },
                new PhieuThuTien { MaPT = 11, MaKH = 1, NgayThu = new DateTime(2025, 05, 18), SoTien = 81000 }
            );

            modelBuilder.Entity<PhieuNhapSach>().HasData(
                new PhieuNhapSach { MaPN = 1, MaSach = 1, GiaNhap = 50000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 12 },
                new PhieuNhapSach { MaPN = 2, MaSach = 2, GiaNhap = 60000, NgayNhap = new DateTime(2025, 05, 09), SoLuong = 10 },
                new PhieuNhapSach { MaPN = 3, MaSach = 3, GiaNhap = 45000, NgayNhap = new DateTime(2025, 05, 10), SoLuong = 8 },
                new PhieuNhapSach { MaPN = 4, MaSach = 4, GiaNhap = 70000, NgayNhap = new DateTime(2025, 05, 11), SoLuong = 15 },
                new PhieuNhapSach { MaPN = 5, MaSach = 5, GiaNhap = 52000, NgayNhap = new DateTime(2025, 05, 12), SoLuong = 20 },
                new PhieuNhapSach { MaPN = 6, MaSach = 6, GiaNhap = 48000, NgayNhap = new DateTime(2025, 05, 13), SoLuong = 7 },
                new PhieuNhapSach { MaPN = 7, MaSach = 7, GiaNhap = 55000, NgayNhap = new DateTime(2025, 05, 14), SoLuong = 18 },
                new PhieuNhapSach { MaPN = 8, MaSach = 8, GiaNhap = 63000, NgayNhap = new DateTime(2025, 05, 15), SoLuong = 9 },
                new PhieuNhapSach { MaPN = 9, MaSach = 9, GiaNhap = 47000, NgayNhap = new DateTime(2025, 05, 16), SoLuong = 11 },
                new PhieuNhapSach { MaPN = 10, MaSach = 10, GiaNhap = 51000, NgayNhap = new DateTime(2025, 05, 17), SoLuong = 13 },
                new PhieuNhapSach { MaPN = 11, MaSach = 11, GiaNhap = 59000, NgayNhap = new DateTime(2025, 05, 18), SoLuong = 16 }
            );

            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang { MaKH = 1, TenKH = "Trương Hoàng Phúc", GioiTinh = "nam", DiaChi = "57A", Email = "12345@gmail.com", TienNo = 100000 },
                new KhachHang { MaKH = 2, TenKH = "Nguyễn Văn An", GioiTinh = "nam", DiaChi = "12B", Email = "an.nguyen@gmail.com", TienNo = 50000 },
                new KhachHang { MaKH = 3, TenKH = "Lê Thị Hoa", GioiTinh = "nữ", DiaChi = "34C", Email = "hoa.le@gmail.com", TienNo = 75000 },
                new KhachHang { MaKH = 4, TenKH = "Phạm Minh Tuấn", GioiTinh = "nam", DiaChi = "56D", Email = "tuan.pham@gmail.com", TienNo = 20000 },
                new KhachHang { MaKH = 5, TenKH = "Trần Thị Mai", GioiTinh = "nữ", DiaChi = "78E", Email = "mai.tran@gmail.com", TienNo = 120000 },
                new KhachHang { MaKH = 6, TenKH = "Đỗ Văn Bình", GioiTinh = "nam", DiaChi = "90F", Email = "binh.do@gmail.com", TienNo = 30000 },
                new KhachHang { MaKH = 7, TenKH = "Vũ Thị Lan", GioiTinh = "nữ", DiaChi = "11G", Email = "lan.vu@gmail.com", TienNo = 45000 },
                new KhachHang { MaKH = 8, TenKH = "Ngô Quang Huy", GioiTinh = "nam", DiaChi = "22H", Email = "huy.ngo@gmail.com", TienNo = 60000 },
                new KhachHang { MaKH = 9, TenKH = "Bùi Thị Hạnh", GioiTinh = "nữ", DiaChi = "33I", Email = "hanh.bui@gmail.com", TienNo = 80000 },
                new KhachHang { MaKH = 10, TenKH = "Phan Văn Khải", GioiTinh = "nam", DiaChi = "44J", Email = "khai.phan@gmail.com", TienNo = 95000 },
                new KhachHang { MaKH = 11, TenKH = "Lý Thị Thu", GioiTinh = "nữ", DiaChi = "55K", Email = "thu.ly@gmail.com", TienNo = 110000 }
            );

            modelBuilder.Entity<HoaDonBanSach>().HasData(
                new HoaDonBanSach { MaHD = 1, MaKH = 1, MaSach = 1, GiaBan = 50000, NgayHD = new DateTime(2025, 05, 08), SoLuong = 1 },
                new HoaDonBanSach { MaHD = 2, MaKH = 2, MaSach = 2, GiaBan = 60000, NgayHD = new DateTime(2025, 05, 09), SoLuong = 2 },
                new HoaDonBanSach { MaHD = 3, MaKH = 3, MaSach = 3, GiaBan = 70000, NgayHD = new DateTime(2025, 05, 10), SoLuong = 3 },
                new HoaDonBanSach { MaHD = 4, MaKH = 4, MaSach = 4, GiaBan = 80000, NgayHD = new DateTime(2025, 05, 11), SoLuong = 4 },
                new HoaDonBanSach { MaHD = 5, MaKH = 5, MaSach = 5, GiaBan = 90000, NgayHD = new DateTime(2025, 05, 12), SoLuong = 5 },
                new HoaDonBanSach { MaHD = 6, MaKH = 6, MaSach = 6, GiaBan = 100000, NgayHD = new DateTime(2025, 05, 13), SoLuong = 6 },
                new HoaDonBanSach { MaHD = 7, MaKH = 7, MaSach = 7, GiaBan = 110000, NgayHD = new DateTime(2025, 05, 14), SoLuong = 7 },
                new HoaDonBanSach { MaHD = 8, MaKH = 8, MaSach = 8, GiaBan = 120000, NgayHD = new DateTime(2025, 05, 15), SoLuong = 8 },
                new HoaDonBanSach { MaHD = 9, MaKH = 9, MaSach = 9, GiaBan = 130000, NgayHD = new DateTime(2025, 05, 16), SoLuong = 9 },
                new HoaDonBanSach { MaHD = 10, MaKH = 10, MaSach = 10, GiaBan = 140000, NgayHD = new DateTime(2025, 05, 17), SoLuong = 10 },
                new HoaDonBanSach { MaHD = 11, MaKH = 11, MaSach = 11, GiaBan = 150000, NgayHD = new DateTime(2025, 05, 18), SoLuong = 11 }
            );
        }

    }
}
