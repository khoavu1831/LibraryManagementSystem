https://www.drawdb.app/editor?shareId=5bd00b421e07764f9c3fa0495f839703
 - Cấu trúc (n-tier): UI (Forms) → Services → Data (Repository/DbContext) → Database
- Các lệnh chạy vói migration:
+ dotnet ef migrations add MigrationName: tạo migration mới
+ dotnet ef migrations list: kiểm tra danh danh sách migration
+ dotnet ef migrations remove [MigrationName]: xóa migration vừa tạo [migrationName nếu muốn chỉ định xóa]
- Các lệnh database:
+ dotnet ef database update: tạo database nếu chưa có hoặc thêm migration mới nhất vào database
+ dotnet ef database update [MigrationName]: cập nhật chỉ định migration (trước/sau)
+ dotnet ef database drop: xóa database
