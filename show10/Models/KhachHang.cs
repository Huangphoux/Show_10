using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Show10.Models {
    internal class KhachHang {
        [Key]
        public required int MaKH { get; set; }
        public required string TenKH { get; set; }
        public required string GioiTinh { get; set; }
        public required string Email { get; set; }
        public required string DiaChi { get; set; }
        [Column(TypeName = "money")]
        public required double TienNo { get; set; }

    }

    internal class KhachHangContext : DbContext {
        public DbSet<KhachHang> KhachHangs { get; set; }

        public string DbPath { get; }

        public KhachHangContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
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
        }
    }
}
