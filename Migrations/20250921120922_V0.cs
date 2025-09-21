using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class V0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NXBList",
                columns: table => new
                {
                    IdNXB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenNXB = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Diachi = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SDT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXBList", x => x.IdNXB);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TacGiaList",
                columns: table => new
                {
                    IdTacGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenTacGia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NgaySinh = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NoiSinh = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SDT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGiaList", x => x.IdTacGia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TheLoaiList",
                columns: table => new
                {
                    IdTheLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenTheloai = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoaiList", x => x.IdTheLoai);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SachList",
                columns: table => new
                {
                    IdSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdNXB = table.Column<int>(type: "int", nullable: false),
                    NamXuatBan = table.Column<int>(type: "int", nullable: false),
                    TenSach = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MoTa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SoTrang = table.Column<int>(type: "int", nullable: false),
                    SoLuongBanSao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SachList", x => x.IdSach);
                    table.ForeignKey(
                        name: "FK_SachList_NXBList_IdNXB",
                        column: x => x.IdNXB,
                        principalTable: "NXBList",
                        principalColumn: "IdNXB",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sach_TacGia",
                columns: table => new
                {
                    SachListIdSach = table.Column<int>(type: "int", nullable: false),
                    TacGiaListIdTacGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach_TacGia", x => new { x.SachListIdSach, x.TacGiaListIdTacGia });
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_SachList_SachListIdSach",
                        column: x => x.SachListIdSach,
                        principalTable: "SachList",
                        principalColumn: "IdSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_TacGiaList_TacGiaListIdTacGia",
                        column: x => x.TacGiaListIdTacGia,
                        principalTable: "TacGiaList",
                        principalColumn: "IdTacGia",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sach_TheLoai",
                columns: table => new
                {
                    SachListIdSach = table.Column<int>(type: "int", nullable: false),
                    TheLoaiListIdTheLoai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach_TheLoai", x => new { x.SachListIdSach, x.TheLoaiListIdTheLoai });
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_SachList_SachListIdSach",
                        column: x => x.SachListIdSach,
                        principalTable: "SachList",
                        principalColumn: "IdSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_TheLoaiList_TheLoaiListIdTheLoai",
                        column: x => x.TheLoaiListIdTheLoai,
                        principalTable: "TheLoaiList",
                        principalColumn: "IdTheLoai",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TacGia_TacGiaListIdTacGia",
                table: "Sach_TacGia",
                column: "TacGiaListIdTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TheLoai_TheLoaiListIdTheLoai",
                table: "Sach_TheLoai",
                column: "TheLoaiListIdTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_SachList_IdNXB",
                table: "SachList",
                column: "IdNXB");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sach_TacGia");

            migrationBuilder.DropTable(
                name: "Sach_TheLoai");

            migrationBuilder.DropTable(
                name: "TacGiaList");

            migrationBuilder.DropTable(
                name: "SachList");

            migrationBuilder.DropTable(
                name: "TheLoaiList");

            migrationBuilder.DropTable(
                name: "NXBList");
        }
    }
}
