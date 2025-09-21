using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_SachList_SachListIdSach",
                table: "Sach_TacGia");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_TacGiaList_TacGiaListIdTacGia",
                table: "Sach_TacGia");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_SachList_SachListIdSach",
                table: "Sach_TheLoai");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_TheLoaiList_TheLoaiListIdTheLoai",
                table: "Sach_TheLoai");

            migrationBuilder.RenameColumn(
                name: "TheLoaiListIdTheLoai",
                table: "Sach_TheLoai",
                newName: "IdTheLoai");

            migrationBuilder.RenameColumn(
                name: "SachListIdSach",
                table: "Sach_TheLoai",
                newName: "IdSach");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_TheLoai_TheLoaiListIdTheLoai",
                table: "Sach_TheLoai",
                newName: "IX_Sach_TheLoai_IdTheLoai");

            migrationBuilder.RenameColumn(
                name: "TacGiaListIdTacGia",
                table: "Sach_TacGia",
                newName: "IdTacGia");

            migrationBuilder.RenameColumn(
                name: "SachListIdSach",
                table: "Sach_TacGia",
                newName: "IdSach");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_TacGia_TacGiaListIdTacGia",
                table: "Sach_TacGia",
                newName: "IX_Sach_TacGia_IdTacGia");

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_SachList_IdSach",
                table: "Sach_TacGia",
                column: "IdSach",
                principalTable: "SachList",
                principalColumn: "IdSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_TacGiaList_IdTacGia",
                table: "Sach_TacGia",
                column: "IdTacGia",
                principalTable: "TacGiaList",
                principalColumn: "IdTacGia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_SachList_IdSach",
                table: "Sach_TheLoai",
                column: "IdSach",
                principalTable: "SachList",
                principalColumn: "IdSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_TheLoaiList_IdTheLoai",
                table: "Sach_TheLoai",
                column: "IdTheLoai",
                principalTable: "TheLoaiList",
                principalColumn: "IdTheLoai",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_SachList_IdSach",
                table: "Sach_TacGia");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_TacGiaList_IdTacGia",
                table: "Sach_TacGia");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_SachList_IdSach",
                table: "Sach_TheLoai");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_TheLoaiList_IdTheLoai",
                table: "Sach_TheLoai");

            migrationBuilder.RenameColumn(
                name: "IdTheLoai",
                table: "Sach_TheLoai",
                newName: "TheLoaiListIdTheLoai");

            migrationBuilder.RenameColumn(
                name: "IdSach",
                table: "Sach_TheLoai",
                newName: "SachListIdSach");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_TheLoai_IdTheLoai",
                table: "Sach_TheLoai",
                newName: "IX_Sach_TheLoai_TheLoaiListIdTheLoai");

            migrationBuilder.RenameColumn(
                name: "IdTacGia",
                table: "Sach_TacGia",
                newName: "TacGiaListIdTacGia");

            migrationBuilder.RenameColumn(
                name: "IdSach",
                table: "Sach_TacGia",
                newName: "SachListIdSach");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_TacGia_IdTacGia",
                table: "Sach_TacGia",
                newName: "IX_Sach_TacGia_TacGiaListIdTacGia");

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_SachList_SachListIdSach",
                table: "Sach_TacGia",
                column: "SachListIdSach",
                principalTable: "SachList",
                principalColumn: "IdSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_TacGiaList_TacGiaListIdTacGia",
                table: "Sach_TacGia",
                column: "TacGiaListIdTacGia",
                principalTable: "TacGiaList",
                principalColumn: "IdTacGia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_SachList_SachListIdSach",
                table: "Sach_TheLoai",
                column: "SachListIdSach",
                principalTable: "SachList",
                principalColumn: "IdSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_TheLoaiList_TheLoaiListIdTheLoai",
                table: "Sach_TheLoai",
                column: "TheLoaiListIdTheLoai",
                principalTable: "TheLoaiList",
                principalColumn: "IdTheLoai",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
