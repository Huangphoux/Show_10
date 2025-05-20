using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Show10.Models {
    internal class BaoCaoNo {
        [Key]
        public required string MaKH { get; set; }
        [Column(TypeName = "money")]
        public required double NoDau { get; set; }
        [Column(TypeName = "money")]
        public required double PhatSinh { get; set; }
        [Column(TypeName = "money")]
        public required double NoCuoi { get; set; }
    }
}
