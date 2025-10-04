-- Thêm NXB
INSERT INTO NXB (TenNXB, DiaChi, SDT) VALUES
('NXB Kim Đồng', 'Hà Nội', '0123456789'),
('NXB Trẻ', 'TP. HCM', '0987654321');

-- Thêm Thể loại
INSERT INTO TheLoai (TenTheLoai) VALUES
('Văn học'),
('Khoa học'),
('Thiếu nhi');

-- Thêm Tác giả
INSERT INTO TacGia (TenTacGia, NgaySinh, NoiSinh, SDT) VALUES
('Nguyễn Nhật Ánh', '1955-05-07', 'Quảng Nam', '0901234567'),
('J.K. Rowling', '1965-07-31', 'Yate, Anh', '0912345678');

-- Thêm Sách
INSERT INTO Sach (IdSach, IdNXB, NamXuatBan, TenSach, MoTa, SoTrang, SoLuongBanSao) VALUES
('1', 1, 2010, 'Kính vạn hoa', 'Truyện dài nhiều tập', 200, 5),
('2', 2, 1997, 'Harry Potter and the Philosopher''s Stone', 'Tập 1 Harry Potter', 350, 10);

-- Mapping sách - thể loại
INSERT INTO Sach_TheLoai (IdSach, IdTheLoai) VALUES
('1', 1),
('2', 2);

-- Mapping sách - tác giả
INSERT INTO Sach_TacGia (IdSach, IdTacGia) VALUES
('1', 1),
('2', 2);

-- Thêm Bản sao sách (IdBanSaoSach là string)
INSERT INTO BanSaoSach (IdBanSaoSach, IdSach, TinhTrangSach) VALUES
('S1_1', '1', 'Tot'),
('S1_2', '1', 'Tot'),
('S2_1', '2', 'Tot'),
('S2_2', '2', 'ChoMuon');

-- Thêm độc giả
INSERT INTO DocGia (TenDocGia, DiaChi, NgaySinh, SDT, Email) VALUES
('Trần Văn A', 'Hà Nội', '2000-01-01', '0900000001', 'a@gmail.com'),
('Nguyễn Thị B', 'Đà Nẵng', '1999-02-02', '0900000002', 'b@gmail.com');

-- Thêm thẻ thành viên
INSERT INTO TheThanhVien (IdDocGia, NgayCap, NgayHetHan, TrangThai) VALUES
(1, '2025-01-01', '2026-01-01', 'HoatDong'),
(2, '2025-01-01', '2026-01-01', 'HoatDong');

-- Thêm nhân viên + tài khoản
INSERT INTO VaiTro (TenVaiTro) VALUES ('Admin'), ('Thủ thư');
INSERT INTO Quyen (TenQuyen) VALUES ('QuanLySach'), ('QuanLyDocGia');

INSERT INTO VaiTro_Quyen (IdVaiTro, IdQuyen) VALUES
(1,1),(1,2),(2,1);

INSERT INTO TaiKhoan (IdVaiTro, TenTaiKhoan, MatKhau) VALUES
(1, 'admin', '123456'),
(2, 'thuthu', '123456');

INSERT INTO NhanVien (IdTaiKhoan, TenNhanVien, NgaySinh, DiaChi, SDT, Email) VALUES
(1, 'Nguyễn Văn C', '1990-03-03', 'Hà Nội', '0900000003', 'c@gmail.com');
