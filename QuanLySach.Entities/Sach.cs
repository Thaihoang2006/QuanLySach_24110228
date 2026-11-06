using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySach.Entities
{
    public class Sach
    {
        [Key]
        [StringLength(20)]
        public string MaSach { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string TenSach { get; set; } = string.Empty;

        public DateTime NgayNhap { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGia { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoai { get; set; } = string.Empty;

        // Khóa ngoại liên kết tới Thể loại
        [ForeignKey("MaLoai")]
        public virtual TheLoai? TheLoai { get; set; }
    }
}