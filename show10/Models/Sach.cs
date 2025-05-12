using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Show10.Models {
    internal class Sach {
        [Key]
        public required int MaSach { get; set; }
        public required string TenSach { get; set; }
        public required string TacGia { get; set; }
        public required int SoLuong { get; set; }
        public required string TheLoai { get; set; }
    }

    internal class SachContext : DbContext {
        public DbSet<Sach> Sachs { get; set; }

        public string DbPath { get; }

        public SachContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
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
        }

    }

}
