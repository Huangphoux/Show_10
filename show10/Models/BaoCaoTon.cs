using System.ComponentModel.DataAnnotations;

namespace Show10.Models {
    internal class BaoCaoTon {
        [Key]
        public required string MaSach { get; set; }
        public required int TonDau { get; set; }
        public required int PhatSinh { get; set; }
        public required int TonCuoi { get; set; }
    }
}
