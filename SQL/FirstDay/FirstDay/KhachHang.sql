CREATE TABLE KhachHang
(
	KhachHangID INT PRIMARY KEY IDENTITY(400, 1),
	TenKhachHang VARCHAR(50),
	ChiNhanhID INT,
);

ALTER TABLE KhachHang 
ADD CONSTRAINT FK_KhachHang
FOREIGN KEY (ChiNhanhID) 
REFERENCES ChiNhanh(ChiNhanhID);

INSERT KhachHang(TenKhachHang, ChiNhanhID)
VALUES ('Cong ty Sua Ong Chua', 2);
INSERT KhachHang(TenKhachHang, ChiNhanhID)
VALUES ('Cong ty Giay BCC', 2);
INSERT KhachHang(TenKhachHang, ChiNhanhID)
VALUES ('Cong ty Gom LCD', 3);
INSERT KhachHang(TenKhachHang, ChiNhanhID)
VALUES ('Cong ty Nhua Silili', 3);
INSERT KhachHang(TenKhachHang, ChiNhanhID)
VALUES ('Cong ty Banh Keo Hai Lua', 2);
INSERT KhachHang(TenKhachHang, ChiNhanhID)
VALUES ('Cong ty BDS Hau An', 3);
INSERT KhachHang(TenKhachHang, ChiNhanhID)
VALUES ('Cong ty Hai San 3X', 2);


SELECT * FROM KhachHang;
--DROP TABLE KhachHang;