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
}
