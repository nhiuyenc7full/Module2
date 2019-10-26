CREATE TABLE NhaCungCap
(
	ChiNhanhID INT,
	TenNhaCungCap VARCHAR(20),
	LoaiSanPhamCC VARCHAR(15),
	PRIMARY KEY(ChiNhanhID, TenNhaCungCap)
);

ALTER TABLE NhaCungCap 
ADD CONSTRAINT FK_NhaCungCap
FOREIGN KEY (ChiNhanhID) 
REFERENCES ChiNhanh(ChiNhanhID);

INSERT NhaCungCap(ChiNhanhID, TenNhaCungCap, LoaiSanPhamCC)
VALUES (2, 'Hong Van', 'Sua');
INSERT NhaCungCap(ChiNhanhID, TenNhaCungCap, LoaiSanPhamCC)
VALUES (2, 'Chien Thang', 'Giay');
INSERT NhaCungCap(ChiNhanhID, TenNhaCungCap, LoaiSanPhamCC)
VALUES (3, 'Huda Hue', 'Gom');
INSERT NhaCungCap(ChiNhanhID, TenNhaCungCap, LoaiSanPhamCC)
VALUES (2, 'CodeGym', 'Banh Keo');
INSERT NhaCungCap(ChiNhanhID, TenNhaCungCap, LoaiSanPhamCC)
VALUES (3, 'CodeGym', 'Banh Keo');
INSERT NhaCungCap(ChiNhanhID, TenNhaCungCap, LoaiSanPhamCC)
VALUES (3, 'Chien Thang', 'Giay');
INSERT NhaCungCap(ChiNhanhID, TenNhaCungCap, LoaiSanPhamCC)
VALUES (3, '3S', 'Hai San');

SELECT * FROM NhaCungCap;
