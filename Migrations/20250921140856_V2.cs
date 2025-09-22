using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_SachList_NXBList_IdNXB",
                table: "SachList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoaiList",
                table: "TheLoaiList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TacGiaList",
                table: "TacGiaList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SachList",
                table: "SachList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NXBList",
                table: "NXBList");

            migrationBuilder.RenameTable(
                name: "TheLoaiList",
                newName: "TheLoai");

            migrationBuilder.RenameTable(
                name: "TacGiaList",
                newName: "TacGia");

            migrationBuilder.RenameTable(
                name: "SachList",
                newName: "Sach");

            migrationBuilder.RenameTable(
                name: "NXBList",
                newName: "NXB");

            migrationBuilder.RenameIndex(
                name: "IX_SachList_IdNXB",
                table: "Sach",
                newName: "IX_Sach_IdNXB");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai",
                column: "IdTheLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TacGia",
                table: "TacGia",
                column: "IdTacGia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sach",
                table: "Sach",
                column: "IdSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NXB",
                table: "NXB",
                column: "IdNXB");

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_NXB_IdNXB",
                table: "Sach",
                column: "IdNXB",
                principalTable: "NXB",
                principalColumn: "IdNXB",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_Sach_IdSach",
                table: "Sach_TacGia",
                column: "IdSach",
                principalTable: "Sach",
                principalColumn: "IdSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_TacGia_IdTacGia",
                table: "Sach_TacGia",
                column: "IdTacGia",
                principalTable: "TacGia",
                principalColumn: "IdTacGia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_Sach_IdSach",
                table: "Sach_TheLoai",
                column: "IdSach",
                principalTable: "Sach",
                principalColumn: "IdSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_TheLoai_IdTheLoai",
                table: "Sach_TheLoai",
                column: "IdTheLoai",
                principalTable: "TheLoai",
                principalColumn: "IdTheLoai",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sach_NXB_IdNXB",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_Sach_IdSach",
                table: "Sach_TacGia");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_TacGia_IdTacGia",
                table: "Sach_TacGia");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_Sach_IdSach",
                table: "Sach_TheLoai");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_TheLoai_IdTheLoai",
                table: "Sach_TheLoai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TacGia",
                table: "TacGia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sach",
                table: "Sach");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NXB",
                table: "NXB");

            migrationBuilder.RenameTable(
                name: "TheLoai",
                newName: "TheLoaiList");

            migrationBuilder.RenameTable(
                name: "TacGia",
                newName: "TacGiaList");

            migrationBuilder.RenameTable(
                name: "Sach",
                newName: "SachList");

            migrationBuilder.RenameTable(
                name: "NXB",
                newName: "NXBList");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_IdNXB",
                table: "SachList",
                newName: "IX_SachList_IdNXB");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoaiList",
                table: "TheLoaiList",
                column: "IdTheLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TacGiaList",
                table: "TacGiaList",
                column: "IdTacGia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SachList",
                table: "SachList",
                column: "IdSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NXBList",
                table: "NXBList",
                column: "IdNXB");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SachList_NXBList_IdNXB",
                table: "SachList",
                column: "IdNXB",
                principalTable: "NXBList",
                principalColumn: "IdNXB",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
