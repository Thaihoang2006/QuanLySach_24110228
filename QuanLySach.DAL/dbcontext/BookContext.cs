using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using QuanLySach.Entities;

namespace QuanLySach.DAL.dbcontext
{
    public class BookContext : DbContext
    {
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<Sach> Sachs { get; set; }

        public BookContext()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch
            {
                // Bỏ qua nếu CSDL chưa sẵn sàng hoặc đang chạy migration
            }
        }

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conStr = ConfigurationManager.ConnectionStrings["BookDB"]?.ConnectionString ?? "";
                if (string.IsNullOrWhiteSpace(conStr))
                {
                    conStr = @"Server=localhost;Port=3306;Database=QuanLySachDB;User=root;Password=root;";
                }

                // Tự động nhận diện: Nếu chuỗi kết nối là MySQL (có chứa 3306, User, Uid...) thì dùng Pomelo MySQL
                // Ngược lại dùng SQL Server (nếu chuỗi kết nối chứa Trusted_Connection, Initial Catalog...)
                if (conStr.Contains("3306", StringComparison.OrdinalIgnoreCase) ||
                    conStr.Contains("User=", StringComparison.OrdinalIgnoreCase) ||
                    conStr.Contains("Uid=", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        var serverVersion = ServerVersion.AutoDetect(conStr);
                        optionsBuilder.UseMySql(conStr, serverVersion);
                    }
                    catch
                    {
                        optionsBuilder.UseMySql(conStr, new MySqlServerVersion(new Version(8, 0, 36)));
                    }
                }
                else
                {
                    optionsBuilder.UseSqlServer(conStr);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình Seed Data: 3 thể loại & 5 sách như trong đề bài
            modelBuilder.Entity<TheLoai>().HasData(
                new TheLoai { MaLoai = "TH", TenLoai = "Tin học" },
                new TheLoai { MaLoai = "TOAN", TenLoai = "Toán học" },
                new TheLoai { MaLoai = "NN", TenLoai = "Ngoại ngữ" }
            );

            modelBuilder.Entity<Sach>().HasData(
                new Sach { MaSach = "S001", TenSach = "Lập trình C# cơ bản", NgayNhap = new DateTime(2026, 10, 1), SoLuong = 10, DonGia = 150000m, MaLoai = "TH" },
                new Sach { MaSach = "S002", TenSach = "Cơ sở dữ liệu", NgayNhap = new DateTime(2026, 10, 5), SoLuong = 15, DonGia = 120000m, MaLoai = "TH" },
                new Sach { MaSach = "S003", TenSach = "Giải tích 1", NgayNhap = new DateTime(2026, 10, 10), SoLuong = 12, DonGia = 95000m, MaLoai = "TOAN" },
                new Sach { MaSach = "S004", TenSach = "Tiếng Anh giao tiếp", NgayNhap = new DateTime(2026, 10, 15), SoLuong = 20, DonGia = 110000m, MaLoai = "NN" },
                new Sach { MaSach = "S005", TenSach = "Đại số tuyến tính", NgayNhap = new DateTime(2026, 10, 20), SoLuong = 8, DonGia = 85000m, MaLoai = "TOAN" }
            );
        }
    }
}
