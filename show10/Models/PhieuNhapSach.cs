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
}
