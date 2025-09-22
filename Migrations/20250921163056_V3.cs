using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BanSaoSach",
                columns: table => new
                {
                    IdBanSaoSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdSach = table.Column<int>(type: "int", nullable: false),
                    TinhTrangSach = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanSaoSach", x => x.IdBanSaoSach);
                    table.ForeignKey(
                        name: "FK_BanSaoSach_Sach_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sach",
                        principalColumn: "IdSach",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuMuon",
                columns: table => new
                {
                    IdPhieuMuon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuon", x => x.IdPhieuMuon);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuon",
                columns: table => new
                {
                    IdChiTietPhieuMuon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPhieuMuon = table.Column<int>(type: "int", nullable: false),
                    IdBanSaoSach = table.Column<int>(type: "int", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TinhTrangTra = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuon", x => x.IdChiTietPhieuMuon);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_BanSaoSach_IdBanSaoSach",
                        column: x => x.IdBanSaoSach,
                        principalTable: "BanSaoSach",
                        principalColumn: "IdBanSaoSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_PhieuMuon_IdPhieuMuon",
                        column: x => x.IdPhieuMuon,
                        principalTable: "PhieuMuon",
                        principalColumn: "IdPhieuMuon",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BanSaoSach_IdSach",
                table: "BanSaoSach",
                column: "IdSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuon_IdBanSaoSach",
                table: "ChiTietPhieuMuon",
                column: "IdBanSaoSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuon_IdPhieuMuon",
                table: "ChiTietPhieuMuon",
                column: "IdPhieuMuon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuon");

            migrationBuilder.DropTable(
                name: "BanSaoSach");

            migrationBuilder.DropTable(
                name: "PhieuMuon");
        }
    }
}
