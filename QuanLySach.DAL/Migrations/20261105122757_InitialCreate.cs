using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLySach.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TheLoais",
                columns: table => new
                {
                    MaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoais", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    MaSach = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sachs_TheLoais_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "TheLoais",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TheLoais",
                columns: new[] { "MaLoai", "TenLoai" },
                values: new object[,]
                {
                    { "NN", "Ngoại ngữ" },
                    { "TH", "Tin học" },
                    { "TOAN", "Toán học" }
                });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "DonGia", "MaLoai", "NgayNhap", "SoLuong", "TenSach" },
                values: new object[,]
                {
                    { "S001", 150000m, "TH", new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Lập trình C# cơ bản" },
                    { "S002", 120000m, "TH", new DateTime(2026, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Cơ sở dữ liệu" },
                    { "S003", 95000m, "TOAN", new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Giải tích 1" },
                    { "S004", 110000m, "NN", new DateTime(2026, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Tiếng Anh giao tiếp" },
                    { "S005", 85000m, "TOAN", new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Đại số tuyến tính" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_MaLoai",
                table: "Sachs",
                column: "MaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "TheLoais");
        }
    }
}
