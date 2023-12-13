use master
go 

CREATE DATABASE DEV2311LM_SQL_04
GO
USE DEV2311LM_SQL_04
GO

-- TRUY VẤN DỮ LIỆU TỪ 1 HAY NHIỀU BẢNG VỚI CÁC ĐIỀU KIỆN LỌC,..

--1. TRUY VẤN VỚI SELCET ĐƠN GIẢN(KHÔNG CÓ FROM)
SELECT 'Devmaster Academy'
GO
--2. ĐẶT TÊN CỘT CHO DỮ LIỆU TRONG TẬP KẾT QUẢ
SELECT 'Devmaster Academy' AS [COMPANY]
GO
SELECT 'Devmaster Academy' AS 'COMPANY'
GO
SELECT 'Devmaster Academy' 'COMPANY'
GO
SELECT 'COMPANY' = 'Devmaster Academy'
GO
--3. TRUY VẤN DỮ LIỆU TỪ MỘT BẢNG SỬ DỤNG DẤU *
-- LIỆT KÊ TẤT CẢ CÁC DỮ LIỆU TRONG BẢNG KHOA
--(*)
SELECT * FROM Khoa
GO
--4. LỰA CHỌN CÁC CỘT TRONG TẬP KẾT QUẢ
SELECT MaKH,TenKH
FROM KHOA
GO
-- liệt kê các thông tin masv, hosv,tensv,ngaysinh.
SELECT *FROM SinhVien
GO
SELECT MASV,HOSV,TENSV,NGAYSINH
FROM SinhVien
GO
--5. SỬ DỤNG BIỂU THỨC TRONG SELECT
-- liệt kê các thông tin masv,hoten,ngày sinh trong đó cột hoten được gộp từ hosv,tensv
SELECT MASV,HOSV+''+TenSV as[họ tên] ,NgaySinh
FROM SinhVien
GO
-- Liệt kê các thông tin điểm thi của sinh viên,thêm cột điểm tăng 10%
SELECT * , [DIEM TANG] = DIEM*110/100 
FROM Ketqua
GO
--6. Sử dụng mệnh đề where để giới hạn dữ liệu trong tập kết quả(lọc,tìm kiếm)
--WHERE <biểu thức điều kiện>
/*
	- Điều kiển sử dụng các phép toán so sánh
		(>,=<,>=,=,!=) => thường dùng với cột dữ liệu kiểu số
	- Điều kiện sử dụng phép toán tương đối ( áp dụng dữ liệu kiểu chuỗi)
		Like/not like
			+ các ký tự đại diện
				++ dấu % ~đại diện cho chuỗi kí tự bất kỳ có thể rỗng
				++ dấu _ đại diện cho một kí tự bất kì
				++ [a-m] : khoảng ký tự từ a => m bao gồm cả hai ký tự cận biên
	- Sử dụng toán tử quan hệ and ,or,not trong biểu thức điều kiện
	- Điều kiện so sanh tập hợp IN / NOT IN
*/
/*
	SECLECT 
	FROM
	WHERE
*/
-- Liệt kê sinh viên có học bổng lơn hơn hoặc bằng 100k

SELECT *
FROM SinhVien
WHERE HocBong>=100000
GO

-- Liệt kê sinh viên có học bổng trong khoảng từ 10000 đến 100000
SELECT *
FROM SinhVien
WHERE HocBong >=10000 and HocBong<=100000
GO

SELECT *
FROM SinhVien
WHERE HocBong between 10000 and 100000
GO
-- so sánh tương đối ( Like hoặc not like)
-- Liệt kê sinh viên có tên bắt đầu bằng T
SELECT *
FROM SinhVien
WHERE TenSV LIKE N'T%'
GO
-- Liệt kê sinh viên có tên có chứa ký tự U
SELECT *
FROM SinhVien
WHERE TenSV LIKE N'%U%'
GO

-- liệt kê sinh viên có tên mà ký tự thứ 2 là U

SELECT *
FROM SinhVien
WHERE TenSV LIKE N'_U%'
GO
-- Liệt kê sinh viên có tên chứa 3 kí tự
SELECT *
FROM SinhVien
WHERE TenSV LIKE N'___'
GO
--
SELECT *
FROM SinhVien
WHERE len(TenSV)='3'
GO
-- Liệt kê sinh viên có tên có chưa ký tự đầu tiên trong khoảng từ a-m
SELECT *
FROM SinhVien
WHERE TenSV LIKE N'[A-M]%'
--
SELECT *
FROM SinhVien
WHERE TenSV NOT LIKE N'[A-M]%'
--
SELECT *
FROM SinhVien
WHERE TenSV NOT LIKE N'[^A-M]%'

-- Sử dụng liệt kê sinh viên có tháng sinh là tháng 2 và tháng 8

SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]
FROM SinhVien
WHERE MONTH(NGAYSINH) = 2 OR MONTH(NGAYSINH) =8
GO
--
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]
FROM SinhVien
WHERE MONTH(NGAYSINH) IN (2,8)
GO
-- NOT IN
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]
FROM SinhVien
WHERE MONTH(NGAYSINH) NOT IN (2,8)
GO
--=============================
--7.Sắp sếp dữ liệu trong tập dữ liệu
--- sắp tăng : ODER BY <Cloumn _Name> |<index> | <alise name> ASC (MẶC ĐỊNH)
--- sắp giảm : ODER BY DESC
--Liệt kê sinh viên dữ liệu sắp theo tên sinh viên tăng dần

SELECT [MaSV], [HoSV] AS [HO SINH VIEN], [TenSV] AS [TEN SINH VIEN]
FROM SinhVien
ORDER BY TENSV ASC
--
SELECT [MaSV], [HoSV] AS [HO SINH VIEN], [TenSV] AS [TEN SINH VIEN]
FROM SinhVien
ORDER BY 3 ASC
--
SELECT [MaSV], [HoSV] AS [HO SINH VIEN], [TenSV] AS [TEN SINH VIEN]
FROM SinhVien
ORDER BY [TEN SINH VIEN]ASC
-----
-- Liệt kê sinh viên , dữ liệu sắp theo tên tăng dần , nếu trùng thì sắp theo HOSV tăng dần
SELECT [MaSV], [HoSV] AS [HO SINH VIEN], [TenSV] AS [TEN SINH VIEN]
FROM SinhVien
ORDER BY TENSV ASC, HoSV ASC
GO
---- LUYỆN TẬP LAB TỪ CÂU 1 ĐẾN CÂU 10------

-- CHO BIẾT DANH SÁCH MÔN HỌC, GỒM CÁC THÔNG TIN: MÃ MÔN HỌC, TÊN HỌC,SỐ TIẾT
SELECT * FROM MonHoc
--
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]
FROM SinhVien
ORDER BY MaSV ASC
GO
--
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh]
FROM SinhVien
ORDER BY TenSV ASC
GO
--
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh]
FROM SinhVien
ORDER BY NgaySinh ASC, HocBong ASC
GO
--
SELECT [MaMH], [TenMH], [Sotiet]
FROM MonHoc
 WHERE TENMH LIKE N'T%'
 --
 SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh]
FROM SinhVien
WHERE TenSV LIKE N'%I'
--
SELECT [MaKH], [TenKH]
FROM Khoa
WHERE TenKH  LIKE '_N%'
--
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh]
FROM SinhVien
WHERE HoSV LIKE N'%[THI]%'
--
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh]
FROM SinhVien
WHERE TenSV LIKE N'[A-M]%'
--
SELECT [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh],[NOISINH],[HocBong]
FROM SinhVien
WHERE TenSV LIKE N'%[A-M]%'
--- CÂU 15---
SELECT [MaSV], [HoSV], [TenSV], [Phai], CONVERT(VARCHAR(10),NgaySinh,103) as 'NGAYSINH',[NOISINH],[HocBong]
FROM SinhVien
WHERE NgaySinh >'1988/12/20'
ORDER BY NGAYSINH DESC
--
--8. Sử dụng từ khóa top trong select
-- Top :trích ra số bản ghi đầu tiên trong tập kết quả

SELECT *
FROM SinhVien
GO
--
SELECT TOP 1*
FROM SinhVien
GO
SELECT TOP 10 PERCENT *
FROM SinhVien
GO
-- Lấy ra sinh viên có học bổng cao nhất

SELECT TOP 1*
FROM SinhVien
ORDER BY HocBong DESC
GO
-- Lấy ra những sinh viên có học bổng cao nhất
SELECT TOP 1 WITH TIES*
FROM SinhVien
ORDER BY HocBong DESC
GO
--9. Sử dụng từ khóa DISTINTCT trong select

--DISTINTCT loại bỏ bỏ dòng trùng lặp (giữ lại 1)
SELECT *
FROM SinhVien
GO -- CÁC BẢN GHI LÀ DUY NHẤT (PK)

SELECT MAKH
FROM SinhVien --LẶP ->15 BẢN GHI
GO
--
SELECT DISTINCT MAKH
FROM SinhVien
GO
--
--10. Case ... When then trong select
-- liệt kê sinh viên , trong phái hiển thị là : 1 ~ Nam ,0 ~ Nữ ;Null ~ Khác

SELECT [MaSV], [HoSV], [TenSV],
[Phai]= CASE Phai
WHEN 1 THEN N'NAM'
WHEN 0 THEN N'NỮ'
ELSE N'KHAC'
END,[NgaySinh]
FROM SinhVien
GO
---10. IIF TRONG SQL SERVER
SELECT [MaSV], [HoSV], [TenSV],
[Phai]= IIF (Phai=1,N'NAM',IIF(PHAI=0,N'NỮ',N'KHAC')),[NgaySinh]
FROM SinhVien
GO
---11. Truy vấn kết hợp 2 hay nhiều bảng (join)
/*
	Inner join
		left join/ left outer join
		right join/ right outer join
		full join/ full outer join
*/
SELECT *FROM KHOA ORDER BY MaKH
SELECT *FROM SINHVIEN ORDER BY MAKH 

--Inner join
SELECT  *
FROM KHOA AS K
	JOIN SINHVIEN S ON K.MAKH =S.MAKH
GO
--
SELECT  *
FROM KHOA AS K,SinhVien AS S
	WHERE K.MAKH =S.MAKH
GO -- SO SÁNH

-- LEFT JOIN / LEFT OUTER JOIN

SELECT  *
FROM KHOA AS K
	LEFT JOIN SINHVIEN S ON K.MAKH =S.MAKH
GO

-- RIGHT JOIN / RIGHT OUTER JOIN
SELECT  *
FROM KHOA AS K
	RIGHT JOIN SINHVIEN S ON K.MAKH =S.MAKH
GO
--FULL JOIN
SELECT  *
FROM KHOA AS K
	FULL JOIN SINHVIEN S ON K.MAKH =S.MAKH
GO
-- Liệt kê các thông tin :MAKH ,TENKH,HOTEN,NGAYSINH,PHAI,HOCBONG

SELECT  MAKH ,TENKH,HOTEN= HoSV +' ',NGAYSINH,PHAI,HOCBONG
FROM Khoa AS K
		JOIN SinhVien AS S ON K.MaKH=S.MaKH
	GO ---Ambiguous column name 'MAKH'.

SELECT  KHOA.MAKH ,TENKH,HOTEN= HoSV +' ',NGAYSINH,PHAI,HOCBONG
FROM Khoa AS K
		JOIN SinhVien AS S ON K.MaKH=S.MaKH
GO ---The multi-part identifier "KHOA.MAKH" could not be bound.

SELECT  K.MAKH ,TENKH,HOTEN= HoSV +' ',NGAYSINH,PHAI,HOCBONG
FROM Khoa AS K
		JOIN SinhVien AS S ON K.MaKH=S.MaKH
GO
SELECT  S.MAKH ,TENKH,HOTEN= HoSV +' ',NGAYSINH,PHAI,HOCBONG
FROM Khoa AS K
		JOIN SinhVien AS S ON K.MaKH=S.MaKH
GO


-- LIỆT KÊ CÁC THÔNG TIN : MAKH,TENKH,HOSV,TENSV,PHAI,DIEM
-- KHOA ,SINHVIEN ,KETQUA
SELECT K.MAKH,S.MASV,TENKH,HOSV,TENSV,PHAI,DIEM
FROM KHOA AS K
		JOIN SinhVien AS S ON K.MaKH=S.MaKH
		JOIN Ketqua AS Q ON S.MaSV =Q.MaSV
	
--DESIGNER

SELECT Ketqua.MaSV, Ketqua.MaMH, SinhVien.MaSV AS Expr1, SinhVien.HoSV, SinhVien.TenSV, SinhVien.Phai
FROM     Ketqua INNER JOIN
                  MonHoc ON Ketqua.MaMH = MonHoc.MaMH INNER JOIN
                  SinhVien ON Ketqua.MaSV = SinhVien.MaSV INNER JOIN
                  Khoa ON SinhVien.MaKH = Khoa.MaKH
GO

SELECT Khoa.MaKH, Khoa.TenKH, Ketqua.Diem, SinhVien.MaSV, SinhVien.HoSV, SinhVien.TenSV, SinhVien.Phai, SinhVien.NgaySinh, SinhVien.NoiSinh, MonHoc.TenMH, MonHoc.Sotiet, SinhVien.MaKH AS Expr1
FROM     Ketqua INNER JOIN
                  MonHoc ON Ketqua.MaMH = MonHoc.MaMH INNER JOIN
                  SinhVien ON Ketqua.MaSV = SinhVien.MaSV INNER JOIN
                  Khoa ON SinhVien.MaKH = Khoa.MaKH

-- LUYỆN TẬP LAP04 -- NGUYÊN CỨU TRUY VẤN GỘP NHÓM / ĐIỀU KIỆN GỘP NHÓM
-- Truy vấn con
-- Truy vấn tham chiếu
