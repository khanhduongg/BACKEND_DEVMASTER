-- 1 .Tạo csdl bằng lệnh T-SQL
	--syntax : CREATe DATABASE
	-- tạo csdl cơ đơn giản :
		Use master
		Go
		CREATE DATABASE DEV2311LM_SQL24_03
		GO
	-- Xóa 
		DROP DATABASE 
	-- TẠO CƠ SỞ DỮ LIỆU VỚI CÁC THUỘC TÍNH CƠ BẢN
		CREATE DATABASE DEV2311LM_SQL24_031
		ON
		(NAME = DEV2311LM_SQL24_03,
		FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\DEV2311LM_SQL24_031.mdf',
		SIZE = 10,
		MAXSIZE = 50,
		FILEGROWTH = 5)
	LOG ON
	(NAME = DEV2311LM_SQL24_031_log,
		FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\DEV2311LM_SQL24_031log.ldf',
		SIZE = 5 MB,
		MAXSIZE = 25 MB,
		FILEGROWTH = 5 MB);
	GO

-- 2 .Tại bảng và các ràng buộc dữ liệu trên bảng
	-- các kiểu dữ liệu thường dùng
	/*
	--Kiểu số :( số nguyên / số thực )
		++ Số nguyên : tinyint / smallInt/ int/bigInt
		++ Số thực : float /duoble /decimal
	--Kiểu chuỗi :(non unicode/uni code)
		++non unicode :char/ varchar /text
		++unicode : nchar/nvarchar/ntext

		++ fixed length :char/nchar (cấp phát theo khai báo )
		++ dynamic length : varchar/ nvarchar(cấp phát khi nhập)
	--Kiểu ngày giờ: smallDateTime/ Datetime /date/time ...
	--Kiểu logic : bit
	--Kiểu nhị phân : binary 

	-- Tham khảo thêm : Keyword datatype in slq server


*/
/*
	Các ràng buộc dữ liệu trên đối tượng table(column)
	-- null/ not null
	-- Duy nhất : primary key / unique / thuộc tính indentity / kiểu dữ liệu uniqueidentifier
	-- Ràng buộc tham chiếu ( khóa ngoại) :foreign key
	-- Ràng buộc miền giá trị(Domain) : DataType / check constraint
	-- Thuộc tính Default : 
	* ràng buộc phức tạp : trigger

	*/
-- Tạo cấu trúc bảng dữ liệu :
	--syntax : CREATE TABLE
--2.1 Tạo bảng đơn giản
use DEV2311LM_SQL24_03
CREATE TABLE TABLE1
(
 COL1 INT
 ,COL VARCHAR(100)
 )
 GO
 --2.2 Tạo bảng với ràng buộc khóa chính(PRIMARY KEY)
 --VAT TU(MAVTU,TENVTU,DVITINH,PHANTRAM)
 CREATE TABLE VATTU
 (
  MAVATU CHAR(4) PRIMARY KEY
  ,TENVATU NVARCHAR(200) NOT NULL
  ,DVITINH NVARCHAR(20)
  ,PHANTRAM REAL
 )
 GO
 --XÓA BẢNG
 DROP TABLE VATTU
 GO
 -- ĐẶT TÊN CONSTRAINT
 CREATE TABLE VATTU
 (
   MAVATU CHAR(4) CONSTRAINT PK_VATTU PRIMARY KEY
  ,TENVATU NVARCHAR(200) NOT NULL
  ,DVITINH NVARCHAR(20)
  ,PHANTRAM REAL
  )
  GO
-- NOTE : TẠO BẢNG DỮ LIỆU VỚI KHÓA CHÍNH TRÊN 2 BẢNG HAY NHIỀU CỘT
CREATE TABLE TABLE2
(
	COL1 INT
	,COL2 INT
	,COL3 NVARCHAR(100)
	,CONSTRAINT PK_TABLE1 PRIMARY KEY (COL1,COL2)
)
GO
--2.3 TẠO BẢNG VỚI RÀNG BUỘC KHÓA CHÍNH VỚI DỮ LIỆU TỰ ĐỘNG TĂNG (IDENTITY)
-- TABLE3(COL1,COL2,COL3)
CREATE TABLE TABLE3
(
	COL1 INT IDENTITY(1,1) CONSTRAINT PK_TABLE3 PRIMARY KEY
	,COL2 NVARCHAR(100)
	,COL3 TINYINT
)
GO
--2.4 Tạo bảng với ràng buộc duy nhất
-- NHACC(MANCC,TENNCC,DIACHI,DIENTHOAI)
-- PK [MANCC]
-- UQ[TENNCC]
CREATE TABLE NHACC
(
	MANCC CHAR(3) CONSTRAINT PK_NHACC PRIMARY KEY
	,TENNCC NVARCHAR(200) CONSTRAINT UQ_NHACC_TENNCC UNIQUE
	,DIACHI NVARCHAR(250)
	,DIENTHOAI VARCHAR(50) NOT NULL CONSTRAINT UQ_DIENTHOAI_TENNCC UNIQUE
)
GO
--2.5:TẠO BẢNG VỚI THUỘC TÍNH DEFAULT
-- NHACC(MANCC,TENNCC,DIACHI,DIENTHOAI)
-- PK [MANCC]
-- UQ[TENNCC]
-- DF[DIACHI] = '25 VU NGOC PHAN'
CREATE TABLE NHACC
(
	MANCC CHAR(3) CONSTRAINT PK_NHACC PRIMARY KEY
	,TENNCC NVARCHAR(200) CONSTRAINT UQ_NHACC_TENNCC UNIQUE
	,DIACHI NVARCHAR(250) CONSTRAINT DF_NHACC_DIACHI DEFAULT '25 VŨ NGỌC PHAN'
	,DIENTHOAI VARCHAR(50) NOT NULL CONSTRAINT UQ_DIENTHOAI_TENNCC UNIQUE
)
GO
--2.6: Ràng buộc miền giá trị check CONSTRAINT
-- CTDONDH( SODH,MAVTU,SLDAT)
-- PK[SODH,MAVATU]
-- CK[SLDAT] > 0
CREATE TABLE CTDONDH
(
	SODH CHAR(4)
	,MAVATU CHAR(4)
	,SLDAT TINYINT CONSTRAINT CK_CTDONDH_SLDATE CHECK (SLDAT>0 AND SLDAT<150)
	,CONSTRAINT PK_CTDONHH PRIMARY KEY (SODH,MAVATU)
)
GO

--DONDH(SODH,NGAYDH,MANHACC)
-- PK[SODH]
-- DF[NGAYDH] = GETDATE()

CREATE TABLE DONDH
(
	SODH CHAR(4) NOT NULL CONSTRAINT PK_DONDH PRIMARY KEY 
	,NGAYDH DATETIME CONSTRAINT DF_DONDH_NGAYDH  DEFAULT GETDATE()
	,MANHACC CHAR(3) NOT NULL
)
GO

--2.7 TẠO BẢNG VỚI RÀNG BUỘC KHÓA NGOẠI
-- CTDONDH( SODH,MAVTU,SLDAT)
-- PK[SODH,MAVATU]
-- CK[SLDAT] > 0 VÀ SLDAT<150
-- FK[SODH] REFERENCES DONDH
-- FK[MAVATU] REFERENCES MAVATU

DROP TABLE CTDONDH
GO
CREATE TABLE CTDONDH
(
	SODH CHAR(4) CONSTRAINT FK_CTDONDH_DONDH_SODH FOREIGN KEY REFERENCES DONDH
	,MAVATU CHAR(4) --CONSTRAINT FK_CTDONDH_VATTU_SODH FOREIGN KEY REFERENCES VATTU
	,SLDAT TINYINT CONSTRAINT CK_CTDONDH_SLDATE CHECK (SLDAT>0 AND SLDAT<150)
	,CONSTRAINT PK_CTDONHH PRIMARY KEY (SODH,MAVATU)
	,CONSTRAINT FK_CTDONDH_VATTU_MAVATU FOREIGN KEY (MAVATU) REFERENCES VATTU
						ON UPDATE CASCADE --NO ACTION/SET NULL/SET DEFAULT
						ON DELETE NO ACTION-- CASCADE /SET NULL /SET DEFAULT
)
GO
--2.8 SỬA ĐỔI BẢNG ĐƠN DH
-- BỔ SUNG KHÓA NGOẠI (MANHACC) THAM CHIẾU ĐẾN BẢNG NHACC
-- FK[MANHACC] ~ NHACC
-- SỬA ĐỔI THÊM RÀNG BUỘC :
	ALTER TABLE DONDH
			ADD CONSTRAINT FK_DONDH_NHACC FOREIGN KEY(MANHACC) REFERENCES NHACC(MANCC)
			ON UPDATE CASCADE
			ON DELETE NO ACTION
	GO
-- THÊM CỘT
	ALTER TABLE DONDH
			ADD  TONGTRIGIA NUMERIC(18,2)	
	GO
-- XÓA CỘT
	ALTER TABLE DONDH
			DROP COLUMN TONGTRIGIA
	GO
-- SỬA CỘT
	EXEC sp_rename 'dbo.DONDH.TONGTRIGIA', 'TONGTRIGIA', 'COLUMN';
-- 3 .Làm việc với các câu lệnh DML (Select/insert/update/delete)
--3.1 SELCET -> LỌC /DUYỆT CÁC BẢNG GHI TỪ NGUỒN DỮ LIỆU
	SELECT* FROM VATTU
	GO
--3.2 INSERT -> THÊM MỘT HAY NHIỀU BẢNG GHI VÀO BẢNG
-- SYNTAX : (ĐƠN GIẢN)
-- THÊM MỘT BẢN GHI VÀO BẢNG
INSERT VATTU(MAVATU,TENVATU,DVITINH,PHANTRAM)
	VALUES('VT01',N'Tủ Lạnh LG 204',N'Chiếc',40)
GO
-- Note : cột identity -> mặc định không thực hiện thêm giá trị cho cột này.
--		  cột có giá trị mặc định hoặc null có thể không cần thêm giá trị
--		  mặc định: khi thêm giá trị trên cột kháo ngoại,thì giá trị đó phải tồn tại trên cột tham chiếu tương ứng
--THÊM NHIỀU BẢN GHI VÀO BẢNG CÙNG LÚC VÀO BẢNG
INSERT VATTU(MAVATU,TENVATU,DVITINH,PHANTRAM) VALUES
('VT03',N'TỦ LẠNH TOSIBA',N'CHIẾC',10),
('VT04',N'TỦ LẠNH TOSIBA1',N'CHIẾC',20),
('VT05',N'TỦ LẠNH TOSIBA2',N'CHIẾC',30),
('VT03',N'TỦ LẠNH TOSIBA',N'CHIẾC',10)
GO --ERROR
INSERT VATTU(MAVATU,TENVATU,DVITINH,PHANTRAM) VALUES
('VT03',N'TỦ LẠNH TOSIBA',N'CHIẾC',10),
('VT04',N'TỦ LẠNH TOSIBA1',N'CHIẾC',20),
('VT05',N'TỦ LẠNH TOSIBA2',N'CHIẾC',30),
('VT06',N'TỦ LẠNH TOSIBA3',N'CHIẾC',40)
GO --OK
-- INSERT SELECT
INSERT VATTU(MAVATU,TENVATU,DVITINH,PHANTRAM)
SELECT 'VT07',N'TỦ LẠNH TOSIBA4',N'CHIẾC',50
---
INSERT VATTU(MAVATU,TENVATU,DVITINH,PHANTRAM)
SELECT 'VT07',N'TỦ LẠNH TOSIBA4',N'CHIẾC',50 UNION
SELECT 'VT07',N'TỦ LẠNH TOSIBA4',N'CHIẾC',50
--NOTE--
/*
	- Dữ liệu chuỗi non unicode: đặt trong cặp nháy đơn ''
	- Dữ liệu chuối unicode :đặt trong cặp nháy đơn N''
	- Dữ liệu kiểu ngày(mặc định): -> đặt trong cặp dấu nháy đơn'',theo định dạng mm/dd/yyyy | yyyy/mm/dd
	==> set datefomat dmy?
*/
--3.3 update -> sửa đổi dữ liệu trên cột trong bảng
-- xóa cũ,thêm mới
-- syntax:
/*
	Update <table_name> [source]
	Set <column_name >= <giá trị> /<Column_source>][,...]
	[where <condition>]

*/
--Cập nhật cột phần trăm trong bảng vật tư tăng lên 10
SELECT*FROM VATTU
--
UPDATE VATTU SET PHANTRAM =PHANTRAM + 10
GO
-- CẬP NHẬT CỘT PHẦN TRĂM TRONG CỘT VẬT TƯ,TỈ LỆ GIẢM ĐI 10 CHO NHỮNG VẬT TƯ CÓ PHẦN TRĂM >= 50
UPDATE VATTU SET PHANTRAM = PHANTRAM - 10 WHERE PHANTRAM >= 50

---3.4 Delete
--SYNTAX :DELETE [FROM] <TABLE_NAME> [WHERE <CONDITION>]
DELETE VATTU WHERE MAVATU ='VT07'
GO
-- XÓA CÁC BẢN GHI VẬT TƯ CÓ PHẦN TRĂM NHỎ HƠN 50
DELETE VATTU WHERE PHANTRAM <50
GO
--GHI CHÚ--
--KHI XÓA DỮ LIỆU TRÊN BẢNG MÀ CÓ LIÊN KẾT ĐẾN BẢNG BÊN NHIỀU THÌ CHÚ Ý ĐẾN ĐIỀU KIỆN THAM CHIẾU(ON DELETE NO ACTION)
--3.5 XÓA SẠCH(LÀM SẠCH VÙNG NHỚ)
-- SYNTAX : TRUNCATE TABLE <TABLE_NAME>
TRUNCATE TABLE VATTU
GO
--Cannot truncate table 'VATTU' because it is being referenced by a FOREIGN KEY constraint.
TRUNCATE TABLE [dbo].[TABLE3]
GO

---Next :Select.
