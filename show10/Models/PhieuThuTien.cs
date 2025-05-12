using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Show10.Models {
    internal class PhieuThuTien {
        [Key]
        public required int MaPT { get; set; }
        public required int MaKH { get; set; }
        [Column(TypeName = "smalldatetime")]
        public required DateTime NgayThu { get; set; }
        [Column(TypeName = "money")]
        public required double SoTien { get; set; }
    }

    internal class PhieuThuTienContext : DbContext {
        public DbSet<PhieuThuTien> PhieuThuTiens { get; set; }

        public string DbPath { get; }

        public PhieuThuTienContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
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
        }
    }
}
