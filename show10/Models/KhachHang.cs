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
                new KhachHang { MaKH = 1, TenKH = "Trương Hoàng Phúc", GioiTinh = "nam", DiaChi = "57A", Email = "12345@gmail.com", TienNo = 100000 }
            );
        }
    }
}
