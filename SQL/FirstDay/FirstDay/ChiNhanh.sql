CREATE TABLE ChiNhanh
(
	ChiNhanhID INT PRIMARY KEY IDENTITY(1, 1),
	TenChiNhanh VARCHAR(20),
	QuanLyID INT,
	NgayBatDau DATE,
	CONSTRAINT FK_ChiNhanh FOREIGN KEY (QuanLyID)
    REFERENCES NhanVien(NhanVienID)
);

INSERT ChiNhanh(TenChiNhanh, QuanLyID, NgayBatDau) 
VALUES('Hue', 100, '20100502');
INSERT ChiNhanh(TenChiNhanh, QuanLyID, NgayBatDau) 
VALUES('Quang Binh', 102, '20120502');
INSERT ChiNhanh(TenChiNhanh, QuanLyID, NgayBatDau) 
VALUES('Quang Tri', 106, '20110502');


SELECT * FROM ChiNhanh;
DROP TABLE ChiNhanh;