using System.ComponentModel.DataAnnotations;

namespace Show10.Models {
    public class TaiKhoan {
        [Key]
        public required string TenTK { get; set; }
        public required string MatKhau { get; set; }
        public required string HoTen { get; set; }
        public required string VaiTro { get; set; }
    }
}
