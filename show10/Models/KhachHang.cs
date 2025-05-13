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
}
