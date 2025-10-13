using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class IntiDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DocGia",
                columns: table => new
                {
                    IdDocGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenDocGia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiaChi = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NgaySinh = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SDT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGia", x => x.IdDocGia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MucPhat",
                columns: table => new
                {
                    IdMucPhat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenMucPhat = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SoTienPhat = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    MoTa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoaiPhat = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MucPhat", x => x.IdMucPhat);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NCC",
                columns: table => new
                {
                    IdNCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenNCC = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiaChi = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SDT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCC", x => x.IdNCC);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NXB",
                columns: table => new
                {
                    IdNXB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenNXB = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiaChi = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SDT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXB", x => x.IdNXB);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuPhat",
                columns: table => new
                {
                    IdPhieuPhat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NgayLap = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TienPhatPhaiNop = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    LyDoPhat = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrangThai = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuPhat", x => x.IdPhieuPhat);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    IdQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenQuyen = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.IdQuyen);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TacGia",
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
                    table.PrimaryKey("PK_TacGia", x => x.IdTacGia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    IdTheLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenTheloai = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.IdTheLoai);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    IdVaiTro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenVaiTro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.IdVaiTro);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TheThanhVien",
                columns: table => new
                {
                    IdTheThanhVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDocGia = table.Column<int>(type: "int", nullable: false),
                    NgayCap = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TrangThai = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheThanhVien", x => x.IdTheThanhVien);
                    table.ForeignKey(
                        name: "FK_TheThanhVien_DocGia_IdDocGia",
                        column: x => x.IdDocGia,
                        principalTable: "DocGia",
                        principalColumn: "IdDocGia",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sach",
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
                    SoLuongBanSao = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.IdSach);
                    table.ForeignKey(
                        name: "FK_Sach_NXB_IdNXB",
                        column: x => x.IdNXB,
                        principalTable: "NXB",
                        principalColumn: "IdNXB",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    IdTaiKhoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVaiTro = table.Column<int>(type: "int", nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MatKhau = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.IdTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_VaiTro_IdVaiTro",
                        column: x => x.IdVaiTro,
                        principalTable: "VaiTro",
                        principalColumn: "IdVaiTro",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VaiTro_Quyen",
                columns: table => new
                {
                    IdVaiTro = table.Column<int>(type: "int", nullable: false),
                    IdQuyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro_Quyen", x => new { x.IdVaiTro, x.IdQuyen });
                    table.ForeignKey(
                        name: "FK_VaiTro_Quyen_Quyen_IdQuyen",
                        column: x => x.IdQuyen,
                        principalTable: "Quyen",
                        principalColumn: "IdQuyen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaiTro_Quyen_VaiTro_IdVaiTro",
                        column: x => x.IdVaiTro,
                        principalTable: "VaiTro",
                        principalColumn: "IdVaiTro",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BanSaoSach",
                columns: table => new
                {
                    IdBanSaoSach = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                name: "Sach_TacGia",
                columns: table => new
                {
                    IdSach = table.Column<int>(type: "int", nullable: false),
                    IdTacGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach_TacGia", x => new { x.IdSach, x.IdTacGia });
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_Sach_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sach",
                        principalColumn: "IdSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_TacGia_IdTacGia",
                        column: x => x.IdTacGia,
                        principalTable: "TacGia",
                        principalColumn: "IdTacGia",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sach_TheLoai",
                columns: table => new
                {
                    IdSach = table.Column<int>(type: "int", nullable: false),
                    IdTheLoai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach_TheLoai", x => new { x.IdSach, x.IdTheLoai });
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_Sach_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sach",
                        principalColumn: "IdSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "IdTheLoai",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    IdNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdTaiKhoan = table.Column<int>(type: "int", nullable: false),
                    TenNhanVien = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NgaySinh = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DiaChi = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SDT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.IdNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_TaiKhoan_IdTaiKhoan",
                        column: x => x.IdTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "IdTaiKhoan",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuMuon",
                columns: table => new
                {
                    IdPhieuMuon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdNhanVien = table.Column<int>(type: "int", nullable: false),
                    IdTheThanhVien = table.Column<int>(type: "int", nullable: false),
                    NgayMuon = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NgayHenTra = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TrangThai = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuon", x => x.IdPhieuMuon);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_TheThanhVien_IdTheThanhVien",
                        column: x => x.IdTheThanhVien,
                        principalTable: "TheThanhVien",
                        principalColumn: "IdTheThanhVien",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    IdPhieuNhap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdNCC = table.Column<int>(type: "int", nullable: false),
                    IdNhanVien = table.Column<int>(type: "int", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SoLuongSach = table.Column<int>(type: "int", nullable: false),
                    TongTienNhap = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    LoaiPhieuNhap = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap", x => x.IdPhieuNhap);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NCC_IdNCC",
                        column: x => x.IdNCC,
                        principalTable: "NCC",
                        principalColumn: "IdNCC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuon",
                columns: table => new
                {
                    IdChiTietPhieuMuon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPhieuMuon = table.Column<int>(type: "int", nullable: false),
                    IdBanSaoSach = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NgayTra = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TinhTrangTra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuon", x => x.IdChiTietPhieuMuon);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_BanSaoSach_IdBanSaoSach",
                        column: x => x.IdBanSaoSach,
                        principalTable: "BanSaoSach",
                        principalColumn: "IdBanSaoSach");
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_PhieuMuon_IdPhieuMuon",
                        column: x => x.IdPhieuMuon,
                        principalTable: "PhieuMuon",
                        principalColumn: "IdPhieuMuon",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhap",
                columns: table => new
                {
                    IdChiTietPhieuNhap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPhieuNhap = table.Column<int>(type: "int", nullable: false),
                    IdSach = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhap", x => x.IdChiTietPhieuNhap);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_PhieuNhap_IdPhieuNhap",
                        column: x => x.IdPhieuNhap,
                        principalTable: "PhieuNhap",
                        principalColumn: "IdPhieuNhap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_Sach_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sach",
                        principalColumn: "IdSach",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuPhat",
                columns: table => new
                {
                    IdChiTietPhieuPhat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPhieuPhat = table.Column<int>(type: "int", nullable: false),
                    IdChiTietPhieuMuon = table.Column<int>(type: "int", nullable: false),
                    IdMucPhat = table.Column<int>(type: "int", nullable: false),
                    SoNgayTreHen = table.Column<int>(type: "int", nullable: false),
                    TienPhatTra = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuPhat", x => x.IdChiTietPhieuPhat);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuPhat_ChiTietPhieuMuon_IdChiTietPhieuMuon",
                        column: x => x.IdChiTietPhieuMuon,
                        principalTable: "ChiTietPhieuMuon",
                        principalColumn: "IdChiTietPhieuMuon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuPhat_MucPhat_IdMucPhat",
                        column: x => x.IdMucPhat,
                        principalTable: "MucPhat",
                        principalColumn: "IdMucPhat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuPhat_PhieuPhat_IdPhieuPhat",
                        column: x => x.IdPhieuPhat,
                        principalTable: "PhieuPhat",
                        principalColumn: "IdPhieuPhat",
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

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_IdPhieuNhap",
                table: "ChiTietPhieuNhap",
                column: "IdPhieuNhap");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_IdSach",
                table: "ChiTietPhieuNhap",
                column: "IdSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuPhat_IdChiTietPhieuMuon",
                table: "ChiTietPhieuPhat",
                column: "IdChiTietPhieuMuon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuPhat_IdMucPhat",
                table: "ChiTietPhieuPhat",
                column: "IdMucPhat");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuPhat_IdPhieuPhat",
                table: "ChiTietPhieuPhat",
                column: "IdPhieuPhat");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdTaiKhoan",
                table: "NhanVien",
                column: "IdTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_IdNhanVien",
                table: "PhieuMuon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_IdTheThanhVien",
                table: "PhieuMuon",
                column: "IdTheThanhVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_IdNCC",
                table: "PhieuNhap",
                column: "IdNCC");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_IdNhanVien",
                table: "PhieuNhap",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_IdNXB",
                table: "Sach",
                column: "IdNXB");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TacGia_IdTacGia",
                table: "Sach_TacGia",
                column: "IdTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TheLoai_IdTheLoai",
                table: "Sach_TheLoai",
                column: "IdTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IdVaiTro",
                table: "TaiKhoan",
                column: "IdVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_TheThanhVien_IdDocGia",
                table: "TheThanhVien",
                column: "IdDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_VaiTro_Quyen_IdQuyen",
                table: "VaiTro_Quyen",
                column: "IdQuyen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhap");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuPhat");

            migrationBuilder.DropTable(
                name: "Sach_TacGia");

            migrationBuilder.DropTable(
                name: "Sach_TheLoai");

            migrationBuilder.DropTable(
                name: "VaiTro_Quyen");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuon");

            migrationBuilder.DropTable(
                name: "MucPhat");

            migrationBuilder.DropTable(
                name: "PhieuPhat");

            migrationBuilder.DropTable(
                name: "TacGia");

            migrationBuilder.DropTable(
                name: "TheLoai");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "NCC");

            migrationBuilder.DropTable(
                name: "BanSaoSach");

            migrationBuilder.DropTable(
                name: "PhieuMuon");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "TheThanhVien");

            migrationBuilder.DropTable(
                name: "NXB");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "DocGia");

            migrationBuilder.DropTable(
                name: "VaiTro");
        }
    }
}
