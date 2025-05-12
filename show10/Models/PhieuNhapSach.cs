using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Show10.Models {
    internal class PhieuNhapSach {
        [Key]
        public required int MaPN { get; set; }
        public required int MaSach { get; set; }
        public required int SoLuong { get; set; }
        [Column(TypeName = "money")]
        public required double GiaNhap { get; set; }
        public required DateTime NgayNhap { get; set; }
    }

    internal class PhieuNhapSachContext : DbContext {
        public DbSet<PhieuNhapSach> PhieuNhapSachs { get; set; }

        public string DbPath { get; }

        public PhieuNhapSachContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
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
        }

    }
}
