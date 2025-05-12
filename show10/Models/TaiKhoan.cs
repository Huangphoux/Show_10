using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Show10.Data_Access {
    public class TaiKhoan {
        [Key]
        public required string TenTK { get; set; }
        public required string MatKhau { get; set; }
        public required string HoTen { get; set; }
        public required string VaiTro { get; set; }
    }

    internal class TaiKhoanContext : DbContext {
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        public string DbPath { get; }

        public TaiKhoanContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

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
        }
    }


}
