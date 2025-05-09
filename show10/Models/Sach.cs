using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Show10.Models
{
    internal class Sach
    {
        [Key]
        public required int MaSach { get; set; }
        public required string TenSach { get; set; }
        public required string TacGia { get; set; }
        public required int SoLuong { get; set; }
        public required string TheLoai { get; set; }
    }

    internal class SachContext : DbContext
    {
        public DbSet<Sach> Sachs { get; set; }

        public string DbPath { get; }

        public SachContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sach>().HasData(
                new Sach { MaSach=1, TenSach="Minna", SoLuong=123, TacGia="Minna", TheLoai="SGK"}
            );
        }

    }

}
