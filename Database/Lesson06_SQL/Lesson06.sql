use DEV2311LM_SQL_04
--==========================

--1.View
	--1.1 T?o view
/*
	SYNTAX
	CREATE VIEW vw_ViewName
		[option]
	as
		SELECT ....
		[OPTION]
GO
*/

-- T?o view th? thông tin t?ng h?p t? b?ng khoa , sinh vien
CREATE VIEW vw_KHOASINHVIEN
AS
	SELECT K.*,[MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [HocBong], [DiemTrungBinh]
	FROM Khoa AS K
			FULL JOIN SinhVien AS S ON K.MaKH=S.MAKH
GO
SELECT * FROM vw_KHOASINHVIEN
go
--1.2 S?a ??i 
-- thêm tùy ch?n encryption - che d?u n?i dung trong view
sp_helptext vw_KHOASINHVIEN
ALTER VIEW vw_KHOASINHVIEN
	WITH ENCRYPTION,SCHEMABINDING
AS
		SELECT K.*,[MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [HocBong], [DiemTrungBinh]
	FROM Khoa AS K
			FULL JOIN SinhVien AS S ON K.MaKH=S.MAKH
GO
-- Syntax '*' is not allowed in schema-bound objects.
ALTER VIEW vw_KHOASINHVIEN
	WITH ENCRYPTION,SCHEMABINDING
AS
		SELECT  [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [HocBong], [DiemTrungBinh]
	FROM dbo.Khoa AS K
			FULL  JOIN dbo.SinhVien AS S ON K.MaKH=S.MAKH
GO
--

sp_depends vw_KHOASINHVIEN
GO

sp_rename 'dbo.SinhVien.DiemTrungBinh','DTB','CLOUMN';

ALTER VIEW vw_KHOASINHVIEN
	WITH ENCRYPTION,SCHEMABINDING
AS
		SELECT  [MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [HocBong], [DiemTrungBinh]*10 as DTB
	FROM dbo.Khoa AS K
			FULL  JOIN dbo.SinhVien AS S ON K.MaKH=S.MAKH
GO
--1.3 Xóa
DROP VIEW vw_KHOASINHVIEN
GO

--2. PROCEDURE : CREATE,ALTER,DROP


--2.1 T?O TH? T?C NG??I DÙNG
	-- SYNTAX : TH? T?C ??N GI?N
	CREATE PROC Squd_KHOA
		AS
			SELECT *FROM KHOA
		GO
	--TH?C THI
	Squd_KHOA
	GO
	EXEC Squd_KHOA
	GO
	EXECUTE Squd_KHOA
	GO
--2.2 TH? T?C V?I CÁC TÙY CH?N : ENCRYPTION/RECOMPILE
sp_helptext Squd_KHOA
GO
ALTER PROC Squd_KHOA
	WITH ENCRYPTION
AS
SELECT *FROM Khoa
GO
ALTER PROC Squd_KHOA
	WITH ENCRYPTION,RECOMPILE
AS
SELECT *FROM Khoa
GO
exec Squd_KHOA with recompile
--2.3 Th? t?c v?i tham s? ??u vào
-- Vi?t th? t?c hi?n t?t c? sinh viên theo tham s? mã khoa
	CREATE PROC squd_SINHVIENBYMAKH
		@MaKH char(2)
	--WITH ENCRYPTION,RECOMPILE
	AS
		SELECT *FROM SinhVien
			WHERE MaKH = @MaKH
	GO
-- TH?C THI
 EXEC squd_SINHVIENBYMAKH 'av'

 --
 Exec squd_SINHVIENBYMAKH @MaKH = 'TH'
 --2.4 Th? t?c v?i tham s? tùy ??u vào tùy ch?n (m?c ??nh)
 -- Vi?t th? t?c hi?n t?t c? sinh viên theo tham s? mã khoa n?u ng??i dùng không truy?n giá tr? thì hi?n th? t?t c?

 	ALTER PROC squd_SINHVIENBYMAKH
		@MaKH char(2) = NULL
	--WITH ENCRYPTION,RECOMPILE
	AS
	/*
		IF @MaKH IS NULL
			BEGIN
				SELECT *FROM SinhVien
			END
		ELSE
			SELECT *FROM SinhVien
				WHERE MaKH = @MaKH
	GO 
	*/
		SELECT *FROM SinhVien
		WHERE MaKH = ISNULL(@MAKH,MAKH)

 EXEC squd_SINHVIENBYMAKH
 EXEC squd_SINHVIENBYMAKH 'av'
 --2.5 S? D?NG L?NH RETURN TRONG TH? T?C

CREATE PROC squd_CAL
	@a int , @b int
as
	declare @c int
	set @c =@a+@b
	return @c
Go

-- Th?c Thi
squd_CAL 10,20
-- 
--print squd_CAL 10,20 -error

declare @kq int
exec @kq=squd_CAL 10,20
print N'k?t qu? : ' + cast (@kq as varchar)
--
declare @kq int
exec @kq=squd_CAL @a=10,@b=20
print N'k?t qu? : ' + cast (@kq as varchar)
--2.6 Vi?t th? t?c th?c hi?n vi?c thêm m?i d? li?u vào b?ng khoa

-- tham s? vào makh,tenkh
-- ki?m tra : n?u mã khoa trùng thì tr? v?  mã l?i là -1

	CREATE PROC squd_CHECKTRUNG
		@MaKH VARCHAR(2) , @TenKH VARCHAR(2)
	as
	BEGIN
		IF EXISTS 
		( SELECT * FROM Khoa WHERE MaKH = @MaKH  or TenKH=@TenKH)
		return -1
		ELSE
		BEGIN INSERT INTO Khoa(MaKH,TenKH) Values (@MaKH,@TenKH)
		return 0
		END
	END
	Go
	SELECT *FROM Khoa
	declare @xq int
	exec @xq =squd_CHECKTRUNG @MaKH ='XM',@TenKH='L?p trình'
	print N'k?t qu? : ' + cast (@xq as varchar)


--

	CREATE PROC spud_KHOA_Insert
		@MaKH char(2),@TenKH nvarchar(50)
	AS
		-- ki?m tra khóa chính trùng
		IF EXISTS (SELECT MAKH FROM Khoa WHERE MaKH=@MaKH)
			BEGIN
				RAISERROR ('TRÙNG KHÓA CHÍNH',16,1)
			END
		--Thêm
		INSERT Khoa(MaKH,TenKH) VALUES(@MaKH,@TenKH)
		RETURN 1
	GO
declare @res int
EXEC spud_KHOA_Insert @MaKH ='AV' ,@TenKH = N'Ngo?i Ng?a Anh V?n'
print @res
GO
declare @res int
EXEC spud_KHOA_Insert @MaKH ='VA' ,@TenKH = N'VA'
print @res
GO

--2.6 TH? T?C THAM S? ??U RA 
-- OUTPUT
-- VI?T TH? T?C V?I YÊU C?U :
-- TH? T?C TH?C HI?N V?I TÍNH TOÁN VÀ TR? V? T?NG S? SINH VIÊN THEO THAM S? ??U VÀO LÀ MAKH
-- N?U KHÔNG CÓ MÃ KHOA THÌ TÍNH T?NG TOÀN B? SINH VIÊN
-- INPUT @MAKH
-- OUTPUT @TONGSV

ALTER PROC Spud_Tongsv
	@MaKH char(2) = null
	,@tongsv int output
AS
	SELECT @tongsv =COUNT (MaSV) FROM SinhVien WHERE MaKH = ISNULL(@MaKH,MaKH) OR MaKH IS NULL
GO
DECLARE @TONG INT
EXEC Spud_Tongsv @MaKH ='AV', @tongsv=@tong output
Print @TONG
GO
DECLARE @TONG INT
EXEC Spud_Tongsv  @tongsv=@tong output
Print @TONG
GO


use DEV2311LM_SQL_04


-- Lab view 

-- 1 LI?T KÊ CÁC SINH VIÊN CÓ H?C B?NG L?N H?N 100000 VÀ SINH ? TP HCM, G?M CÁC THÔNG TIN,H? TÊN ,MÃ KHOA,N?I SINH , H?C B?NG

CREATE VIEW vw_hocbongsv
	as
		select *from SinhVien
			WHERE HocBong > 100000 and NoiSinh like N'Tp.HCM'
GO
select * from vw_hocbongsv
GO
-- 2 DANH SÁCH SINH VIÊN C?A KHOA ANH V?N VÀ KHOA TRI?T G?M THÔNG TIN : MASV , MAKHOA,PHAI
	CREATE VIEW vw_lab2
		AS
			SELECT MaSV,MaKH,Phai
				FROM SinhVien
				WHERE MaKH LIKE 'AV' OR MaKH LIKE 'TH'
	GO
-- 3 CHO BI?T NH?NG SINH VIÊN SINH T? NGÀY 01/01/1986 ??N NGÀY 05/06/1992 G?M NGAYSINH,NOIWSSINH,HOCBONG
	CREATE VIEW vw_lab3
	AS
			SELECT MaSV,NgaySinh,NoiSinh,HocBong
				FROM SinhVien
				WHERE NgaySinh >'1986/01/01' AND NgaySinh < '1992/06/05'
	GO
-- 4 DANH SÁCH NH?NG SINH VIEN CÓ H?C B?NG T? 150000 ??N 800000 G?M MASV,NGAYSINH,PHAI,MAKH
	CREATE VIEW vw_lab4
		AS
			SELECT MaSV,NgaySinh,Phai,MaKH,HocBong
				FROM SinhVien
				WHERE HocBong>150000 AND HocBong <800000
	GO
-- 5 CHO BI?T NH?NG MÔN H?C CÓ S? TI?T L?N H?N 40 VÀ NH? H?N 60 G?M MÃ MÔN H?C ,TÊN MÔN H?C,S? TI?T
	CREATE VIEW vw_lab5
		AS
			SELECT MaMH,TenMH,Sotiet
				FROM MonHoc
				WHERE Sotiet > 40 AND Sotiet <60
		GO
-- 6 LI?T KÊ NH?NG SINH VIÊN NAM C?A KHOA ANH V?N G?M MASV,HOTENSV,PHAI
	CREATE VIEW vw_lab6
		AS
			SELECT  MaSV,HoSV,TenSV,CASE 
									WHEN Phai = 1 THEN N'N?'
									WhEN PHai = 0 THEN N'NAM' 
									END AS [GIOI TINH]
				FROM SinhVien
				WHERE Phai = 0
		GO
-- 7 DANH SÁCH SINH VIEN CÓ N?I SINH ? HÀ N?I VÀ NGÀY SINH SAU 01/01/1990 G?M HOTEN,NOISINH,NGAYSINH
	CREATE VIEW vw_lab7
		AS
			SELECT  MaSV,HoSV,TenSV,NgaySinh
				FROM SinhVien
				WHERE NgaySinh >'1990/01/01'
		GO
-- 8 LI?T KÊ NH?NG SINH VIÊN N? , TÊN CÓ CH? N
	CREATE VIEW vw_lab8
		AS
			SELECT  MaSV,HoSV,TenSV,CASE 
									WHEN Phai = 1 THEN N'N?'
									WhEN PHai = 0 THEN N'NAM' 
									END AS [GIOI TINH]
				FROM SinhVien
				WHERE Phai = 1 AND TenSV LIKE N'%N'
		GO
-- 9 DANH SÁCH SINH VIÊN KHOA TIN H?C CÓ NGÀY SINH SAY NGÀY 30/5/1986
		CREATE VIEW vw_lab9
		AS
			SELECT  MaSV,HoSV,TenSV,NgaySinh
				FROM SinhVien
				WHERE MaKH LIKE 'TH' AND NgaySinh > '1986/05/30'
		GO
--10 DANH SÁCH SINH VIÊN H? VÀ TÊN SINH VIÊN , GI?I TÍNH HI?N TH? ? D?NG TRUE FALSE
	CREATE VIEW vw_lab10
		AS
			SELECT  MaSV,HoSV,TenSV,CASE 
									WHEN Phai = 1 THEN N'FALSE'
									WhEN PHai = 0 THEN N'TRUE' 
									END AS [GIOI TINH]
				FROM SinhVien
		GO


SELECT *FROM SinhVien
SELECT *FROM Khoa
SELECT *FROM Mon
--===========================================--

-- XÂY D?NG TH? T?C

-- I XÂY D?NG TH? T?C QU?N LÝ BÁN HÀNG

-- 1 XÂY D?NG 

	CREATE PROC Spud_LayDanhSachVATTU
		AS
			SELECT *FROM VATTU
