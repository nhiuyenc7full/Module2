-- lấy lương trung bình của công ty
SELECT AVG(NV.Luong) AS 'LƯƠNG'
FROM NhanVien NV;

-- lấy người nhân viên có lương cao nhất của công ty
SELECT TOP 1 MAX(NV.Luong) AS LUONG, NV.TenNV 
FROM NhanVien NV
GROUP BY NV.Luong, NV.TenNV
ORDER BY NV.Luong DESC;

SELECT *
FROM NhanVien NV
WHERE NV.Luong IN 
(SELECT MAX(Luong) FROM NhanVien);

-- lấy top 3 nhân viên có lương cao nhất của cty
SELECT TOP 3 nv.TenNV, MAX(nv.Luong) AS LUONG
FROM NhanVien nv 
GROUP BY NV.TenNV, nv.Luong
ORDER BY NV.Luong DESC;

SELECT TOP 3 nv.TenNV
FROM NhanVien nv
ORDER BY NV.Luong DESC;

-- lấy những nhân viên là nữ và trên 20
SELECT *
FROM NhanVien NV
WHERE YEAR(GETDATE()) - YEAR(NgaySinh) > 20
AND GioiTinh = 'NU';

-- tổng tiền sale đối với từng khách hàng
SELECT CTS.KhachHangID, SUM(CTS.TongTien) AS [TONG TIEN]
FROM ChiTietSale CTS
GROUP BY CTS.KhachHangID

-- lấy thông tin nhân viên và tổng tiền sale của những nhân viên đó
SELECT NV.TenNV, SUM(CTS.TongTien)
FROM NhanVien NV
INNER JOIN ChiTietSale CTS
ON NV.NhanVienID = CTS.NhanVienID
GROUP BY NV.TenNV;

-- lấy thông tin những nhà cung cấp có tên bắt đầu bằng 'hu'
SELECT NCC.TenNhaCungCap
FROM NhaCungCap NCC
WHERE NCC.TenNhaCungCap LIKE 'HU%';

-- lấy những nhân viên có tháng sinh nhật là 1
SELECT NV.TenNV, NV.NgaySinh
FROM NhanVien NV
WHERE MONTH(NgaySinh) = 1;

-- lấy tất cả thông tin của nhân viên mà có tiền sale > 3 trăm
SELECT nv.TenNV, SUM(cts.TongTien) AS 'tổng tiền' 
FROM ChiTietSale cts 
INNER JOIN NhanVien nv
ON nv.NhanVienID = cts.NhanVienID
GROUP BY nv.TenNV
HAVING SUM(cts.TongTien) > 300000;

-- lấy thông tin khách hàng mà người quản lý có id 102
SELECT KH.KhachHangID, KH.TenKhachHang, CN.QuanLyID
FROM KhachHang KH
INNER JOIN ChiNhanh CN
ON CN.QuanLyID = 102
AND CN.ChiNhanhID = KH.ChiNhanhID

-- lấy thông tin khách hàng mà người quản lý có tên là 'Sung'
SELECT NV.TenNV, KH.KhachHangID, KH.TenKhachHang
FROM NhanVien NV
INNER JOIN ChiNhanh CN
ON NV.NhanVienID = CN.QuanLyID
AND NV.TenNV = 'SUNG'
INNER JOIN KhachHang KH
ON KH.ChiNhanhID = CN.ChiNhanhID

-- lấy thông tin nhân viên đã có sale thuộc chi nhanh Quảng Trị
SELECT DISTINCT(NV.NhanVienID), NV.TenNV, NV.GioiTinh, NV.NgaySinh
FROM ChiNhanh CN
INNER JOIN NhanVien NV
ON NV.ChiNhanhID = CN.ChiNhanhID
AND CN.TenChiNhanh = 'QUANG TRI'
INNER JOIN ChiTietSale CTS
ON CTS.NhanVienID = NV.NhanVienID;

-- tìm kiếm tất cả những khách hàng có tiền sale > 200.
SELECT KH.KhachHangID, KH.TenKhachHang, SUM(CTS.TongTien)
FROM ChiTietSale CTS
JOIN KhachHang KH
ON KH.KhachHangID = CTS.KhachHangID
GROUP BY KH.KhachHangID,  KH.TenKhachHang
HAVING SUM(CTS.TongTien) > 200000;

-- nhân viên được ai phụ trách
SELECT NV2.TenNV, NV1.TenNV AS NGUOIQL
FROM NhanVien NV1
INNER JOIN NhanVien NV2
ON NV1.NhanVienID = NV2.NguoiPhuTrachID;
