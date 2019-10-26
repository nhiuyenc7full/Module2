CREATE TABLE NhanVien
(
	NhanVienID INT PRIMARY KEY IDENTITY(100, 1),
	HoNV VARCHAR(20) NOT NULL,
	TenNV VARCHAR(20) NOT NULL,
	NgaySinh DATE,
	GioiTinh VARCHAR(5),
	Luong INT NOT NULL,
	NguoiPhuTrachID INT DEFAULT NULL,
	ChiNhanhID INT
);

ALTER TABLE NhanVien 
ADD CONSTRAINT FK_NhanVien1
FOREIGN KEY (ChiNhanhID) 
REFERENCES ChiNhanh(ChiNhanhID);

ALTER TABLE NhanVien 
ADD CONSTRAINT FK_NhanVien
FOREIGN KEY (NhanVienID) 
REFERENCES NhanVien(NhanVienID);

SELECT * FROM NhanVien;

INSERT NhanVien (HoNV, TenNV, NgaySinh, GioiTinh, Luong)
VALUES('Phan Dinh', 'Tung', '19950523', 'Nam', 30000000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Le Van','Lang','19900212','Nu',12000000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Dinh Van','Hoang','19850124','Nam',10000000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Hoang','Buoi','19910821','Nu',11000000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Dao Dinh','Phong','19920812','Nam',8000000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Mai Van','An','19860101','Nam',6500000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Nguyen Van','Sung','19990202','Nu',5000000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Cao Ba','Thong','19930303','Nam',3000000);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong)
VALUES('Nguyen Van','Balo','19860101','Nam',8500000);

UPDATE NhanVien SET ChiNhanhID = 1 WHERE NhanVienID = 100;
UPDATE NhanVien SET NguoiPhuTrachID = 100 WHERE NhanVienID IN (101, 102, 106);
UPDATE NhanVien SET NguoiPhuTrachID = 102 WHERE NhanVienID BETWEEN 103 AND 105;
UPDATE NhanVien SET NguoiPhuTrachID = 106 WHERE NhanVienID IN (107, 108);
UPDATE NhanVien SET ChiNhanhID = 1 WHERE NhanVienID = 101;
UPDATE NhanVien SET ChiNhanhID = 2 WHERE NhanVienID BETWEEN 102 AND 105;
UPDATE NhanVien SET ChiNhanhID = 3 WHERE NhanVienID BETWEEN 106 AND 108;


SELECT * FROM NhanVien;
-- TRUNCATE TABLE NhanVien; 
