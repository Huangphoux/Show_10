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
}
