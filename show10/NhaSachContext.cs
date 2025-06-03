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
        public DbSet<BaoCaoTon> BaoCaoTons { get; set; }
        public DbSet<BaoCaoNo> BaoCaoNos { get; set; }

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
                new Sach { MaSach = 1, TenSach = "Minna", SoLuong = 0, TacGia = "Minna", TheLoai = "SGK" },
                new Sach { MaSach = 2, TenSach = "C# Programming", SoLuong = 0, TacGia = "John Doe", TheLoai = "Programming" },
                new Sach { MaSach = 3, TenSach = "ASP.NET Core Guide", SoLuong = 0, TacGia = "Jane Smith", TheLoai = "Web Development" },
                new Sach { MaSach = 4, TenSach = "Entity Framework Core", SoLuong = 0, TacGia = "Alex Brown", TheLoai = "Database" },
                new Sach { MaSach = 5, TenSach = "Clean Code", SoLuong = 0, TacGia = "Robert C. Martin", TheLoai = "Software Engineering" },
                new Sach { MaSach = 6, TenSach = "Design Patterns", SoLuong = 0, TacGia = "Erich Gamma", TheLoai = "Software Engineering" },
                new Sach { MaSach = 7, TenSach = "Introduction to Algorithms", SoLuong = 0, TacGia = "Thomas H. Cormen", TheLoai = "Algorithms" },
                new Sach { MaSach = 8, TenSach = "The Pragmatic Programmer", SoLuong = 0, TacGia = "Andrew Hunt", TheLoai = "Software Engineering" },
                new Sach { MaSach = 9, TenSach = "Refactoring", SoLuong = 0, TacGia = "Martin Fowler", TheLoai = "Software Engineering" },
                new Sach { MaSach = 10, TenSach = "Artificial Intelligence", SoLuong = 0, TacGia = "Stuart Russell", TheLoai = "AI" },
                new Sach { MaSach = 11, TenSach = "Deep Learning", SoLuong = 0, TacGia = "Ian Goodfellow", TheLoai = "AI" }
            );

            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang { MaKH = 1, TenKH = "Trương Hoàng Phúc", GioiTinh = "Nam", DiaChi = "57A", Email = "12345@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 2, TenKH = "Nguyễn Văn An", GioiTinh = "Nam", DiaChi = "12B", Email = "an.nguyen@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 3, TenKH = "Lê Thị Hoa", GioiTinh = "Nữ", DiaChi = "34C", Email = "hoa.le@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 4, TenKH = "Phạm Minh Tuấn", GioiTinh = "Nam", DiaChi = "56D", Email = "tuan.pham@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 5, TenKH = "Trần Thị Mai", GioiTinh = "Nữ", DiaChi = "78E", Email = "mai.tran@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 6, TenKH = "Đỗ Văn Bình", GioiTinh = "Nam", DiaChi = "90F", Email = "binh.do@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 7, TenKH = "Vũ Thị Lan", GioiTinh = "Nữ", DiaChi = "11G", Email = "lan.vu@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 8, TenKH = "Ngô Quang Huy", GioiTinh = "Nam", DiaChi = "22H", Email = "huy.ngo@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 9, TenKH = "Bùi Thị Hạnh", GioiTinh = "Nữ", DiaChi = "33I", Email = "hanh.bui@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 10, TenKH = "Phan Văn Khải", GioiTinh = "Nam", DiaChi = "44J", Email = "khai.phan@gmail.com", TienNo = 0 },
                new KhachHang { MaKH = 11, TenKH = "Lý Thị Thu", GioiTinh = "Nữ", DiaChi = "55K", Email = "thu.ly@gmail.com", TienNo = 0 }
            );

            modelBuilder.Entity<PhieuThuTien>().HasData(
                new PhieuThuTien { MaPT = 1, MaKH = 1, NgayThu = new DateTime(2025, 05, 08), SoTien = 2000 },
                new PhieuThuTien { MaPT = 2, MaKH = 2, NgayThu = new DateTime(2025, 05, 09), SoTien = 20000 },
                new PhieuThuTien { MaPT = 3, MaKH = 3, NgayThu = new DateTime(2025, 05, 10), SoTien = 10000 },
                new PhieuThuTien { MaPT = 4, MaKH = 4, NgayThu = new DateTime(2025, 06, 08), SoTien = 320000 },
                new PhieuThuTien { MaPT = 5, MaKH = 5, NgayThu = new DateTime(2025, 06, 20), SoTien = 50000 },
                new PhieuThuTien { MaPT = 6, MaKH = 6, NgayThu = new DateTime(2025, 06, 30), SoTien = 100000 },
                new PhieuThuTien { MaPT = 7, MaKH = 7, NgayThu = new DateTime(2025, 07, 10), SoTien = 70000 },
                new PhieuThuTien { MaPT = 8, MaKH = 8, NgayThu = new DateTime(2025, 07, 20), SoTien = 160000 },
                new PhieuThuTien { MaPT = 9, MaKH = 9, NgayThu = new DateTime(2025, 07, 29), SoTien = 170000 },
                new PhieuThuTien { MaPT = 10, MaKH = 10, NgayThu = new DateTime(2025, 08, 08), SoTien = 400000 },
                new PhieuThuTien { MaPT = 11, MaKH = 11, NgayThu = new DateTime(2025, 08, 17), SoTien = 150000 }
            );

            modelBuilder.Entity<PhieuNhapSach>().HasData(
                new PhieuNhapSach { MaPN = 1, MaSach = 1, GiaNhap = 50000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 151, NhaCungCap = "NCC1" },
                new PhieuNhapSach { MaPN = 12, MaSach = 1, GiaNhap = 51000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC1" },
                new PhieuNhapSach { MaPN = 2, MaSach = 2, GiaNhap = 60000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 154, NhaCungCap = "NCC2" },
                new PhieuNhapSach { MaPN = 13, MaSach = 2, GiaNhap = 61000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC2" },
                new PhieuNhapSach { MaPN = 3, MaSach = 3, GiaNhap = 45000, NgayNhap = new DateTime(2025, 05, 09), SoLuong = 160, NhaCungCap = "NCC3" },
                new PhieuNhapSach { MaPN = 14, MaSach = 3, GiaNhap = 46000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC3" },
                new PhieuNhapSach { MaPN = 4, MaSach = 4, GiaNhap = 70000, NgayNhap = new DateTime(2025, 06, 07), SoLuong = 159, NhaCungCap = "NCC4" },
                new PhieuNhapSach { MaPN = 15, MaSach = 4, GiaNhap = 71000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC4" },
                new PhieuNhapSach { MaPN = 5, MaSach = 5, GiaNhap = 52000, NgayNhap = new DateTime(2025, 06, 17), SoLuong = 160, NhaCungCap = "NCC5" },
                new PhieuNhapSach { MaPN = 16, MaSach = 5, GiaNhap = 53000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC5" },
                new PhieuNhapSach { MaPN = 6, MaSach = 6, GiaNhap = 48000, NgayNhap = new DateTime(2025, 06, 27), SoLuong = 168, NhaCungCap = "NCC6" },
                new PhieuNhapSach { MaPN = 17, MaSach = 6, GiaNhap = 49000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC6" },
                new PhieuNhapSach { MaPN = 7, MaSach = 7, GiaNhap = 55000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 169, NhaCungCap = "NCC7" },
                new PhieuNhapSach { MaPN = 18, MaSach = 7, GiaNhap = 56000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC7" },
                new PhieuNhapSach { MaPN = 8, MaSach = 8, GiaNhap = 63000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 180, NhaCungCap = "NCC8" },
                new PhieuNhapSach { MaPN = 19, MaSach = 8, GiaNhap = 64000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC8" },
                new PhieuNhapSach { MaPN = 9, MaSach = 9, GiaNhap = 47000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 180, NhaCungCap = "NCC9" },
                new PhieuNhapSach { MaPN = 20, MaSach = 9, GiaNhap = 48000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC9" },
                new PhieuNhapSach { MaPN = 10, MaSach = 10, GiaNhap = 51000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 190, NhaCungCap = "NCC10" },
                new PhieuNhapSach { MaPN = 21, MaSach = 10, GiaNhap = 52000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC10" },
                new PhieuNhapSach { MaPN = 11, MaSach = 11, GiaNhap = 59000, NgayNhap = new DateTime(2025, 05, 08), SoLuong = 181, NhaCungCap = "NCC11" },
                new PhieuNhapSach { MaPN = 22, MaSach = 11, GiaNhap = 60000, NgayNhap = new DateTime(2025, 08, 17), SoLuong = 150, NhaCungCap = "NCC11" }
            );

            modelBuilder.Entity<HoaDonBanSach>().HasData(
                new HoaDonBanSach { MaHD = 1, MaKH = 1, MaSach = 1, GiaBan = 50000, SoLuong = 1, TongTien = 50000, SoTienTra = 48000, ConLai = 2000, NgayHD = new DateTime(2025, 05, 08) },
                new HoaDonBanSach { MaHD = 2, MaKH = 2, MaSach = 2, GiaBan = 60000, SoLuong = 2, TongTien = 120000, SoTienTra = 100000, ConLai = 20000, NgayHD = new DateTime(2025, 05, 09) },
                new HoaDonBanSach { MaHD = 3, MaKH = 3, MaSach = 3, GiaBan = 70000, SoLuong = 3, TongTien = 210000, SoTienTra = 200000, ConLai = 10000, NgayHD = new DateTime(2025, 05, 10) },
                new HoaDonBanSach { MaHD = 4, MaKH = 4, MaSach = 4, GiaBan = 80000, SoLuong = 4, TongTien = 320000, SoTienTra = 0, ConLai = 320000, NgayHD = new DateTime(2025, 06, 08) },
                new HoaDonBanSach { MaHD = 5, MaKH = 5, MaSach = 5, GiaBan = 90000, SoLuong = 5, TongTien = 450000, SoTienTra = 400000, ConLai = 50000, NgayHD = new DateTime(2025, 06, 20) },
                new HoaDonBanSach { MaHD = 6, MaKH = 6, MaSach = 6, GiaBan = 100000, SoLuong = 6, TongTien = 600000, SoTienTra = 500000, ConLai = 100000, NgayHD = new DateTime(2025, 06, 30) },
                new HoaDonBanSach { MaHD = 7, MaKH = 7, MaSach = 7, GiaBan = 110000, SoLuong = 7, TongTien = 770000, SoTienTra = 700000, ConLai = 70000, NgayHD = new DateTime(2025, 07, 10) },
                new HoaDonBanSach { MaHD = 8, MaKH = 8, MaSach = 8, GiaBan = 120000, SoLuong = 8, TongTien = 960000, SoTienTra = 800000, ConLai = 160000, NgayHD = new DateTime(2025, 07, 20) },
                new HoaDonBanSach { MaHD = 9, MaKH = 9, MaSach = 9, GiaBan = 130000, SoLuong = 9, TongTien = 1170000, SoTienTra = 1000000, ConLai = 170000, NgayHD = new DateTime(2025, 07, 29) },
                new HoaDonBanSach { MaHD = 10, MaKH = 10, MaSach = 10, GiaBan = 140000, SoLuong = 10, TongTien = 1400000, SoTienTra = 1000000, ConLai = 400000, NgayHD = new DateTime(2025, 08, 08) },
                new HoaDonBanSach { MaHD = 11, MaKH = 11, MaSach = 11, GiaBan = 150000, SoLuong = 11, TongTien = 1650000, SoTienTra = 1500000, ConLai = 150000, NgayHD = new DateTime(2025, 08, 17) },
                new HoaDonBanSach { MaHD = 12, MaKH = 1, MaSach = 1, GiaBan = 50000, SoLuong = 1, TongTien = 50000, SoTienTra = 50000, ConLai = 0, NgayHD = new DateTime(2025, 06, 08) },
                new HoaDonBanSach { MaHD = 13, MaKH = 1, MaSach = 1, GiaBan = 50000, SoLuong = 1, TongTien = 50000, SoTienTra = 50000, ConLai = 0, NgayHD = new DateTime(2025, 07, 08) },
                new HoaDonBanSach { MaHD = 14, MaKH = 1, MaSach = 1, GiaBan = 50000, SoLuong = 1, TongTien = 50000, SoTienTra = 50000, ConLai = 0, NgayHD = new DateTime(2025, 08, 08) },
                new HoaDonBanSach { MaHD = 15, MaKH = 2, MaSach = 2, GiaBan = 60000, SoLuong = 2, TongTien = 120000, SoTienTra = 120000, ConLai = 0, NgayHD = new DateTime(2025, 06, 09) },
                new HoaDonBanSach { MaHD = 16, MaKH = 2, MaSach = 2, GiaBan = 60000, SoLuong = 2, TongTien = 120000, SoTienTra = 120000, ConLai = 0, NgayHD = new DateTime(2025, 07, 09) },
                new HoaDonBanSach { MaHD = 17, MaKH = 2, MaSach = 2, GiaBan = 60000, SoLuong = 2, TongTien = 120000, SoTienTra = 120000, ConLai = 0, NgayHD = new DateTime(2025, 08, 09) },
                new HoaDonBanSach { MaHD = 18, MaKH = 3, MaSach = 3, GiaBan = 70000, SoLuong = 3, TongTien = 210000, SoTienTra = 210000, ConLai = 0, NgayHD = new DateTime(2025, 06, 10) },
                new HoaDonBanSach { MaHD = 19, MaKH = 3, MaSach = 3, GiaBan = 70000, SoLuong = 3, TongTien = 210000, SoTienTra = 210000, ConLai = 0, NgayHD = new DateTime(2025, 07, 10) },
                new HoaDonBanSach { MaHD = 20, MaKH = 3, MaSach = 3, GiaBan = 70000, SoLuong = 3, TongTien = 210000, SoTienTra = 210000, ConLai = 0, NgayHD = new DateTime(2025, 08, 10) },
                new HoaDonBanSach { MaHD = 21, MaKH = 4, MaSach = 4, GiaBan = 80000, SoLuong = 4, TongTien = 320000, SoTienTra = 320000, ConLai = 0, NgayHD = new DateTime(2025, 06, 11) },
                new HoaDonBanSach { MaHD = 22, MaKH = 4, MaSach = 4, GiaBan = 80000, SoLuong = 4, TongTien = 320000, SoTienTra = 320000, ConLai = 0, NgayHD = new DateTime(2025, 07, 11) },
                new HoaDonBanSach { MaHD = 23, MaKH = 4, MaSach = 4, GiaBan = 80000, SoLuong = 4, TongTien = 320000, SoTienTra = 320000, ConLai = 0, NgayHD = new DateTime(2025, 08, 11) },
                new HoaDonBanSach { MaHD = 24, MaKH = 5, MaSach = 5, GiaBan = 90000, SoLuong = 5, TongTien = 450000, SoTienTra = 450000, ConLai = 0, NgayHD = new DateTime(2025, 06, 12) },
                new HoaDonBanSach { MaHD = 25, MaKH = 5, MaSach = 5, GiaBan = 90000, SoLuong = 5, TongTien = 450000, SoTienTra = 450000, ConLai = 0, NgayHD = new DateTime(2025, 07, 12) },
                new HoaDonBanSach { MaHD = 26, MaKH = 5, MaSach = 5, GiaBan = 90000, SoLuong = 5, TongTien = 450000, SoTienTra = 450000, ConLai = 0, NgayHD = new DateTime(2025, 08, 12) },
                new HoaDonBanSach { MaHD = 27, MaKH = 6, MaSach = 6, GiaBan = 100000, SoLuong = 6, TongTien = 600000, SoTienTra = 600000, ConLai = 0, NgayHD = new DateTime(2025, 06, 13) },
                new HoaDonBanSach { MaHD = 28, MaKH = 6, MaSach = 6, GiaBan = 100000, SoLuong = 6, TongTien = 600000, SoTienTra = 600000, ConLai = 0, NgayHD = new DateTime(2025, 07, 13) },
                new HoaDonBanSach { MaHD = 29, MaKH = 6, MaSach = 6, GiaBan = 100000, SoLuong = 6, TongTien = 600000, SoTienTra = 600000, ConLai = 0, NgayHD = new DateTime(2025, 08, 13) },
                new HoaDonBanSach { MaHD = 30, MaKH = 7, MaSach = 7, GiaBan = 110000, SoLuong = 7, TongTien = 770000, SoTienTra = 770000, ConLai = 0, NgayHD = new DateTime(2025, 06, 14) },
                new HoaDonBanSach { MaHD = 31, MaKH = 7, MaSach = 7, GiaBan = 110000, SoLuong = 7, TongTien = 770000, SoTienTra = 770000, ConLai = 0, NgayHD = new DateTime(2025, 07, 14) },
                new HoaDonBanSach { MaHD = 32, MaKH = 7, MaSach = 7, GiaBan = 110000, SoLuong = 7, TongTien = 770000, SoTienTra = 770000, ConLai = 0, NgayHD = new DateTime(2025, 08, 14) },
                new HoaDonBanSach { MaHD = 33, MaKH = 8, MaSach = 8, GiaBan = 120000, SoLuong = 8, TongTien = 960000, SoTienTra = 960000, ConLai = 0, NgayHD = new DateTime(2025, 06, 15) },
                new HoaDonBanSach { MaHD = 34, MaKH = 8, MaSach = 8, GiaBan = 120000, SoLuong = 8, TongTien = 960000, SoTienTra = 960000, ConLai = 0, NgayHD = new DateTime(2025, 07, 15) },
                new HoaDonBanSach { MaHD = 35, MaKH = 8, MaSach = 8, GiaBan = 120000, SoLuong = 8, TongTien = 960000, SoTienTra = 960000, ConLai = 0, NgayHD = new DateTime(2025, 08, 15) },
                new HoaDonBanSach { MaHD = 36, MaKH = 9, MaSach = 9, GiaBan = 130000, SoLuong = 9, TongTien = 1170000, SoTienTra = 1170000, ConLai = 0, NgayHD = new DateTime(2025, 06, 16) },
                new HoaDonBanSach { MaHD = 37, MaKH = 9, MaSach = 9, GiaBan = 130000, SoLuong = 9, TongTien = 1170000, SoTienTra = 1170000, ConLai = 0, NgayHD = new DateTime(2025, 07, 16) },
                new HoaDonBanSach { MaHD = 38, MaKH = 9, MaSach = 9, GiaBan = 130000, SoLuong = 9, TongTien = 1170000, SoTienTra = 1170000, ConLai = 0, NgayHD = new DateTime(2025, 08, 16) },
                new HoaDonBanSach { MaHD = 39, MaKH = 10, MaSach = 10, GiaBan = 140000, SoLuong = 10, TongTien = 1400000, SoTienTra = 1400000, ConLai = 0, NgayHD = new DateTime(2025, 06, 17) },
                new HoaDonBanSach { MaHD = 40, MaKH = 10, MaSach = 10, GiaBan = 140000, SoLuong = 10, TongTien = 1400000, SoTienTra = 1400000, ConLai = 0, NgayHD = new DateTime(2025, 07, 17) },
                new HoaDonBanSach { MaHD = 41, MaKH = 10, MaSach = 10, GiaBan = 140000, SoLuong = 10, TongTien = 1400000, SoTienTra = 1400000, ConLai = 0, NgayHD = new DateTime(2025, 08, 17) },
                new HoaDonBanSach { MaHD = 42, MaKH = 11, MaSach = 11, GiaBan = 150000, SoLuong = 11, TongTien = 1650000, SoTienTra = 1650000, ConLai = 0, NgayHD = new DateTime(2025, 06, 18) },
                new HoaDonBanSach { MaHD = 43, MaKH = 11, MaSach = 11, GiaBan = 150000, SoLuong = 11, TongTien = 1650000, SoTienTra = 1650000, ConLai = 0, NgayHD = new DateTime(2025, 07, 18) },
                new HoaDonBanSach { MaHD = 44, MaKH = 11, MaSach = 11, GiaBan = 150000, SoLuong = 11, TongTien = 1650000, SoTienTra = 1650000, ConLai = 0, NgayHD = new DateTime(2025, 08, 18) }
            );
        }
    }
}