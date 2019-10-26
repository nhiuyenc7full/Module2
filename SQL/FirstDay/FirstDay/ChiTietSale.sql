CREATE TABLE ChiTietSale
(
	NhanVienID INT,
	KhachHangID INT,
	TongTien INT,
	PRIMARY KEY(NhanVienID, KhachHangID),
);

ALTER TABLE ChiTietSale
ADD CONSTRAINT FK_ChiTietSale 
FOREIGN KEY (NhanVienID)
REFERENCES NhanVien(NhanVienID);

ALTER TABLE ChiTietSale
ADD CONSTRAINT FK_ChiTietSale1
FOREIGN KEY (KhachHangID)
REFERENCES KhachHang(KhachHangID);

INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(105, 400, 85000);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(102, 401, 320000);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(108, 402, 25500);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(107, 403, 4000);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(108, 403, 11000);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(105, 404, 32000);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(107, 405, 26000);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(102, 406, 12000);
INSERT ChiTietSale(NhanVienID, KhachHangID, TongTien)
VALUES(105, 406, 250000);

SELECT * FROM ChiTietSale;