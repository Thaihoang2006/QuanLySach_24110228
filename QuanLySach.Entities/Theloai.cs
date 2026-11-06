using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySach.Entities
{
    public class TheLoai
    {
        [Key]
        [StringLength(10)]
        public string MaLoai { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenLoai { get; set; } = string.Empty;

        // Quan hệ 1 - N: Một thể loại có nhiều sách
        public virtual ICollection<Sach> Sachs { get; set; } = new List<Sach>();
    }
}