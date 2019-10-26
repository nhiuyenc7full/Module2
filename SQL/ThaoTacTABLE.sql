USE QUANLY;
SELECT COUNT(DISTINCT NhanVienID) FROM NhanVien;
-- DELETE TABLE: xóa dữ liệu dữ lại lịch sử;
-- TRUNCATE TABLE table: xóa toàn bộ dữ liệu (xóa lịch sử);
-- DROP TABLE table: xóa toàn bộ bảng;
-- ON DELETE SET NULL: nếu bị xóa thì trở thành NULL;
-- 
-- Các quan hệ:
-- one - to - one
-- one - to - many
-- many - to - many

--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:
SELECT* FROM ChiNhanh WHERE TenChiNhanh LIKE 'q%';
SELECT* FROM KhachHang;
-- Lấy tất cả thông tin nhân viên của công ty; chi nhánh
SELECT* FROM NhanVien;

SELECT cn.TenChiNhanh, nv.TenNV FROM ChiNhanh cn, NhanVien nv
Where cn.ChiNhanhID = nv.ChiNhanhID;

SELECT cn.TenChiNhanh AS 'tên chi nhánh', nv.TenNV AS 'Name' FROM ChiNhanh cn inner join NhanVien nv ON cn.ChiNhanhID = nv.ChiNhanhID;
-- AS tạo tên hiển thị cho cột, ChiNhanh cn: viết tắt--

-- sắp xếp tăng dần lương của nhân viên; giảm dần
SELECT NhanVien.TenNV, NhanVien.Luong FROM NhanVien ORDER BY Luong ASC;
SELECT NhanVien.TenNV, NhanVien.Luong FROM NhanVien ORDER BY Luong DESC;

-- sắp xếp theo giới tính, name;
SELECT * FROM NhanVien ORDER BY GioiTinh DESC, TenNV ASC;
-- lấy 5 nhân viên đầu tiên trong bảng;
SELECT TOP 5 TenNV FROM NhanVien;
-- chỉ xuất ra họ, tên nhân viên;
SELECT HoNV AS 'HỌ NV', TenNV AS 'TÊN NV' FROM NhanVien;
-- kiểm tra trong công ty có mấy giới tính, xuất ra (xuất Nam, Nữ);
SELECT DISTINCT GioiTinh FROM NhanVien;
-- lấy những nhân viên có giới tính Nam;
SELECT* FROM NhanVien WHERE GioiTinh = 'Nam';
-- lấy những nhân viên có năm sinh lớn hơn 1990;
SELECT * FROM NhanVien WHERE YEAR(NgaySinh)  > 1990;
-- lấy những nhân viên có tuổi lớn hơn 30, hiện ra tuổi ở một cột mới TUOI;
SELECT YEAR(GETDATE()) - YEAR(NgaySinh) AS TUOI, * FROM NhanVien WHERE YEAR(GETDATE()) - YEAR(NgaySinh)  > 30;
-- lấy thông tin của nhân viên thuộc chi nhánh Quảng Bình;
SELECT NhanVien.TenNV, ChiNhanh.TenChiNhanh FROM NhanVien inner join ChiNhanh on TenChiNhanh = 'Quang Binh' AND NhanVien.ChiNhanhID = ChiNhanh.ChiNhanhID;
-- lấy những nhân viên có giới tính là Nữ hoặc lương > 8tr;
SELECT* FROM NhanVien WHERE GioiTinh = 'Nu' OR Luong > 8000000;
--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:--BÀI TẬP ANH KHÁNH:

-- hiển thi 5 dòng đầu, 50% dòng đầu thỏa điều kiện
SELECT top(50) percent TenNV, Luong FROM NhanVien where Luong > 5000000;
select top 5 TenNV, Luong from NhanVien where Luong > 5000000;

-- xóa top 5 dòng đầu/ 5% đầu thỏa điều kiện where
delete top (5) from NhanVien where Luong < 5000000;
delete top (5) percent from NhanVien where Luong < 5000000;

use AnhMy;
-- HIỂN THỊ GIÁO VIÊN DẠY CÙNG MỘT MÔN VỚI 002

SELECT GV2.HOTEN, GV2.MABM
FROM GIAOVIEN GV1
INNER JOIN GIAOVIEN GV2
ON GV1.MAGV = 002
AND GV2.MABM = GV1.MABM

SELECT * FROM GIAOVIEN;

ALTER TABLE GIAOVIEN
ADD NHIUYEN VARCHAR(10);

ALTER TABLE GIAOVIEN
DROP COLUMN NHIUYEN;

-- Xuất ra thông tin giáo viên và Giáo viên quản lý chủ nhiệm của người đó
SELECT GV1.MAGV, GV1.HOTEN, GV2.MAGV AS GVQLCN
FROM GIAOVIEN GV1 -- GV
LEFT JOIN GIAOVIEN GV2 -- GVQLCN
ON  GV1.GVQLCM = GV2.MAGV;
 
SELECT * FROM GIAOVIEN;




-- Hiển thị thông tin giáo viên và các giáo viên được quản lý
SELECT GV1.HOTEN AS QUANLY, GV2.HOTEN AS GIAOVIEN
FROM GIAOVIEN GV1
RIGHT JOIN GIAOVIEN GV2
ON GV1.MAGV = GV2.GVQLCM;

SELECT * FROM GIAOVIEN;

-- Xuất ra số lượng giáo viên của khoa CNTT

SELECT * FROM GIAOVIEN;
SELECT * FROM KHOA;
SELECT * FROM BOMON;

SELECT COUNT(GV.MAGV) 
FROM KHOA K
INNER JOIN BOMON BM
ON K.TENKHOA = N'Công nghệ thông tin'
AND BM.MAKHOA = K.MAKHOA
INNER JOIN GIAOVIEN GV
ON GV.MABM = BM.MABM;

SELECT COUNT(GV.MAGV) AS [SL GV] 
FROM BOMON BM
INNER JOIN GIAOVIEN GV
ON BM.MAKHOA = 'CNTT'
AND GV.MABM = BM.MABM;


-- Xuất ra thông tin giáo viên và đề tài người đó tham gia khi mà kết quả là đạt
SELECT * FROM DETAI;
SELECT * FROM THAMGIADT;

SELECT DISTINCT(GV.MAGV), GV.HOTEN, GV.DIACHI, DT.TENDT
FROM DETAI DT
INNER JOIN THAMGIADT TGDT
ON DT.MADT = TGDT.MADT
AND TGDT.KETQUA = N'Đạt'
INNER JOIN GIAOVIEN GV
ON GV.MAGV = TGDT.MAGV
