using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Show10.Models {
    internal class HoaDonBanSach {
        [Key]
        public required int SoHD { get; set; }
        public required int MaSach { get; set; }
        public required int MaKH { get; set; }
        public required int SoLuong { get; set; }
        [Column(TypeName = "money")]
        public required double GiaBan { get; set; }
        public required DateTime NgayHD { get; set; }
    }

    internal class HoaDonBanSachContext : DbContext {
        public DbSet<HoaDonBanSach> HoaDonBanSachs { get; set; }

        public string DbPath { get; }

        public HoaDonBanSachContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<HoaDonBanSach>().HasData(
                new HoaDonBanSach { SoHD = 1, MaKH = 1, MaSach = 1, GiaBan = 50000, NgayHD = new DateTime(2025, 05, 08), SoLuong = 1 },
                new HoaDonBanSach { SoHD = 2, MaKH = 2, MaSach = 2, GiaBan = 60000, NgayHD = new DateTime(2025, 05, 09), SoLuong = 2 },
                new HoaDonBanSach { SoHD = 3, MaKH = 3, MaSach = 3, GiaBan = 70000, NgayHD = new DateTime(2025, 05, 10), SoLuong = 3 },
                new HoaDonBanSach { SoHD = 4, MaKH = 4, MaSach = 4, GiaBan = 80000, NgayHD = new DateTime(2025, 05, 11), SoLuong = 4 },
                new HoaDonBanSach { SoHD = 5, MaKH = 5, MaSach = 5, GiaBan = 90000, NgayHD = new DateTime(2025, 05, 12), SoLuong = 5 },
                new HoaDonBanSach { SoHD = 6, MaKH = 6, MaSach = 6, GiaBan = 100000, NgayHD = new DateTime(2025, 05, 13), SoLuong = 6 },
                new HoaDonBanSach { SoHD = 7, MaKH = 7, MaSach = 7, GiaBan = 110000, NgayHD = new DateTime(2025, 05, 14), SoLuong = 7 },
                new HoaDonBanSach { SoHD = 8, MaKH = 8, MaSach = 8, GiaBan = 120000, NgayHD = new DateTime(2025, 05, 15), SoLuong = 8 },
                new HoaDonBanSach { SoHD = 9, MaKH = 9, MaSach = 9, GiaBan = 130000, NgayHD = new DateTime(2025, 05, 16), SoLuong = 9 },
                new HoaDonBanSach { SoHD = 10, MaKH = 10, MaSach = 10, GiaBan = 140000, NgayHD = new DateTime(2025, 05, 17), SoLuong = 10 },
                new HoaDonBanSach { SoHD = 11, MaKH = 11, MaSach = 11, GiaBan = 150000, NgayHD = new DateTime(2025, 05, 18), SoLuong = 11 }
            );
        }

    }
}
