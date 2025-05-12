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

}
