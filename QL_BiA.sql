﻿USE MASTER
GO
CREATE DATABASE QLPHONGBIA
GO
USE QLPHONGBIA


--============================================================================================================
--1. tạo bảng khách hàng và insert dữ liệu các câu lệnh update truy vấn
-----------------------------------------------------------------
CREATE TABLE KHACHHANG
(
	MAKH NCHAR(10) NOT NULL PRIMARY KEY,
	TENKH NVARCHAR(50),
	SDT NVARCHAR(12),
	GIOVAO TIME,
	GIARA TIME,
	TONGTG TIME
)
-----------------------------------------------------------------
-- Thêm 10 dòng dữ liệu vào bảng KHACHHANG với giá trị cho GIOVAO và GIARA
INSERT INTO KHACHHANG (MAKH, TENKH, SDT, GIOVAO, GIARA) VALUES
    ('KH01', N'Nguyễn Văn Anh', '0123456789', '08:00:00', '16:00:00'),
    ('KH02', N'Trần Thị Bình', '0987654321', '09:15:00', '17:30:00'),
    ('KH03', N'Lê Văn Cao', '0369847201', '10:30:00', '18:45:00'),
    ('KH04', N'Phạm Thị Dương', '0765432198', '11:45:00', '20:00:00'),
    ('KH05', N'Hoàng Văn Em', '0897654321', '08:30:00', '17:00:00'),
    ('KH06', N'Nguyễn Thị Phương', '0765432987', '09:00:00', '18:30:00'),
    ('KH07', N'Trần Văn Kiệt', '0123456789', '10:15:00', '20:45:00'),
    ('KH08', N'Lê Thị Thương', '0987654321', '08:45:00', '16:15:00'),
    ('KH09', N'Phạm Văn Ái', '0369847201', '09:30:00', '17:45:00'),
    ('KH10', N'Hoàng Thị Kiều Linh', '0765432198', '11:00:00', '19:30:00');
SELECT*FROM KHACHHANG

------------------------------------------------------------------
SELECT KHACHHANG.MAKH,
       BANBIA.MABAN,
       KHACHHANG.GIOVAO,
       CONVERT(TIME, GETDATE()) AS GIARA,
        CONVERT(TIME, DATEADD(MINUTE,
           DATEDIFF(MINUTE, GIOVAO, GETDATE()),
           '00:00:00')) AS TONGTG
FROM DANGKY
INNER JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
INNER JOIN BANBIA ON DANGKY.MABAN = BANBIA.MABAN;

update KHACHHANG
set TONGTG= CONVERT(TIME, DATEADD(MINUTE,
           DATEDIFF(MINUTE, GIOVAO, GETDATE()),
           '00:00:00'))
GO
CREATE TRIGGER tr_AutoUpdateGioRa
ON KHACHHANG
AFTER UPDATE
AS
BEGIN
    UPDATE KHACHHANG
    SET GIARA = CONVERT(TIME, GETDATE())
    FROM KHACHHANG
    INNER JOIN inserted ON KHACHHANG.MAKH = inserted.MAKH;
END;

--============================================================================================================
-----------------------------------------------------------------
--2.chỉ có tạo bảng nhân viên và insert dữ liệu cho bảng 
GO
CREATE TABLE NHANVIEN
(
	MANV NCHAR(10) NOT NULL PRIMARY KEY,
	TENNV NVARCHAR(50),
	TUOI INT,
	DIACHI NVARCHAR(50),
	SDT NCHAR(10),
	GIOITINH NCHAR(10),
	CHUCVU NVARCHAR(10),
	CALAM NVARCHAR(10),
	LUONG INT
)
-----------------------------------------------------------------
-- Thêm 10 dòng dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANV, TENNV, TUOI, DIACHI, SDT, GIOITINH, CHUCVU, CALAM, LUONG) VALUES
    ('NV01', N'Nguyễn Văn An', 28, N'Hà Nội', '0123456789', N'Nam', N'Quản lý', N'Ca sáng', 5000000),
    ('NV02', N'Trần Thị Bình', 35, N'Hồ Chí Minh', '0987654321', N'Nữ', N'Nhân viên', N'Ca chiều', 4000000),
    ('NV03', N'Lê Minh Cường', 30, N'Đà Nẵng', '0369847201', N'Nam', N'Nhân viên', N'Ca sáng', 4500000),
    ('NV04', N'Phạm Thanh Duy', 24, N'Hải Phòng', '0765432198', N'Nam', N'Nhân viên', N'Ca chiều', 4300000),
    ('NV05', N'Hoàng Thị Ngọc', 29, N'Cần Thơ', '0897654321', N'Nữ', N'Nhân viên', N'Ca sáng', 4200000),
    ('NV06', N'Nguyễn Văn Đức', 26, N'Hà Tĩnh', '0765432987', N'Nam', N'Nhân viên', N'Ca sáng', 4400000),
    ('NV07', N'Trần Thị Lan', 32, N'Nghệ An', '0123456789', N'Nữ', N'Nhân viên', N'Ca chiều', 4100000),
    ('NV08', N'Lê Minh Hà', 40, N'Quảng Ninh', '0987654321', N'Nữ', N'Quản lý', N'Ca sáng', 5200000),
    ('NV09', N'Phạm Văn Tùng', 27, N'Quảng Bình', '0369847201', N'Nam', N'Nhân viên', N'Ca chiều', 4700000),
    ('NV10', N'Hoàng Thị Hương', 33, N'Bắc Giang', '0765432198', N'Nữ', N'Nhân viên', N'Ca chiều', 4800000);

SELECT*FROM NHANVIEN
--============================================================================================================
-----------------------------------------------------------------
--3. chỉ có tạo bảng và insert dữ liệu vào bảng
GO
CREATE TABLE BANBIA
(
	MABAN NCHAR(10) NOT NULL PRIMARY KEY,
	TENBAN NVARCHAR(50),
	LOAIBAN NVARCHAR(50),
	GIATIEN INT,
	TINHTRANG NVARCHAR(30),
	TINHTRANGTT NVARCHAR(50)
)
-----------------------------------------------------------------
-- Thêm dữ liệu vào bảng BANBIA cho các loại bàn bi-a
INSERT INTO BANBIA (MABAN, TENBAN, LOAIBAN, GIATIEN, TINHTRANG, TINHTRANGTT) VALUES
    ('BB01', N'Bàn pool 1', N'Bi-a không lỗ', 10000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB02', N'Bàn pool 2', N'Bi-a không lỗ', 12000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB03', N'Bàn pool 3', N'Bi-a không lỗ', 15000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB04', N'Bàn pool 4', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB05', N'Bàn pool 5', N'Bi-a lỗ', 22000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB06', N'Bàn pool 6', N'Bi-a lỗ', 25000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB07', N'Bàn pool 7', N'Bi-a không lỗ', 12000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB08', N'Bàn pool 8', N'Bi-a lỗ', 20000, N'Đang sử dụng', N'Thanh toán đủ'),
    ('BB09', N'Bàn Snooker 1', N'Bi-a lỗ', 25000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB10', N'Bàn Snooker 2', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB11', N'Bàn Snooker 3', N'Bi-a không lỗ', 15000, N'Đang sử dụng', N'Thanh toán đủ'),
    ('BB12', N'Bàn Snooker 4', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB13', N'Bàn Snooker 5', N'Bi-a không lỗ', 15000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB14', N'Bàn Snooker 6', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB15', N'Bàn Snooker 7', N'Bi-a không lỗ', 12000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB16', N'Bàn Snooker 8', N'Bi-a lỗ', 20000, N'Đang sử dụng', N'Thanh toán đủ');

SELECT*FROM BANBIA
UPDATE BANBIA
SET TINHTRANG=N'Trống'

--============================================================================================================
-----------------------------------------------------------------
--3. tạo bảng và insert dữ liệu cho bảng
GO
CREATE TABLE DICHVU
(
	MADV NCHAR(10) NOT NULL PRIMARY KEY,
	TENDV NVARCHAR(100),
	GIA INT,
	SLKHO INT
)
-----------------------------------------------------------------
-- Thêm các dịch vụ nước ngọt vào bảng DICHVU
INSERT INTO DICHVU (MADV, TENDV, GIA, SLKHO) VALUES
    ('DV01', N'Nước ngọt Coca-Cola', 20000, 100),
    ('DV02', N'Nước ngọt Pepsi', 18000, 120),
    ('DV03', N'Nước ngọt 7Up', 16000, 80),
    ('DV04', N'Nước ngọt Fanta', 17000, 90),
    ('DV05', N'Nước ngọt Mirinda', 19000, 110),
    ('DV06', N'Nước ngọt Sprite', 15000, 70),
    ('DV07', N'Nước ngọt sting', 20000, 100),
    ('DV08', N'Trà đá', 18000, 120),
    ('DV09', N'Cafe sữa ', 16000, 80),
    ('DV010', N'Bạc xĩu', 16000, 80)
INSERT INTO DICHVU (MADV, TENDV, GIA, SLKHO) VALUES
    ('DV011', N'Không dùng nước', 0, 100)

	SELECT*FROM DICHVU
--============================================================================================================
-----------------------------------------------------------------
--4. Tạo bảng và các câu lệnh truy vấn trên bảng
GO
CREATE TABLE DANGKY
(
	MAKH NCHAR(10) NOT NULL,
	MADV NCHAR(10)NOT NULL,
	MABAN NCHAR(10)NOT NULL,
	NGAYDANGKY DATETIME,
	SOLUONG INT,
)
ALTER TABLE DANGKY
ADD CONSTRAINT PK_DK PRIMARY KEY(MAKH,MADV,MABAN)

GO
ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_KHACHHANG FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_DICHVU FOREIGN KEY(MADV) REFERENCES DICHVU(MADV)

GO
ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_BANBIA FOREIGN KEY(MABAN) REFERENCES BANBIA(MABAN)
GO
-----------------------------------------------------------------
-- Thêm dữ liệu vào bảng DANGKY
INSERT INTO DANGKY (MAKH, MADV, MABAN, NGAYDANGKY, SOLUONG) VALUES
    ('KH01', 'DV01', 'BB01', GETDATE(), 2), -- Example with current date and quantity
    ('KH02', 'DV02', 'BB02', GETDATE(), 3), -- Example with current date and quantity
    ('KH03', 'DV03', 'BB03', GETDATE(), 1) -- Example with current date and quantity

go
SELECT*FROM DANGKY


SELECT KHACHHANG.MAKH, BANBIA.MABAN, TENKH, SDT, GIOVAO, TENBAN, TINHTRANG FROM DANGKY, KHACHHANG, BANBIA WHERE DANGKY.MABAN = BANBIA.MABAN  and KHACHHANG.MAKH=DANGKY.MAKH

--============================================================================================================
-----------------------------------------------------------------
--5. Tạo bảng hóa đơn và insert dữ liệu cho bảng
go
CREATE TABLE HOADON
(
	MAKH NCHAR(10) NOT NULL,
	MABAN NCHAR(10)NOT NULL,
	NGAYTT DATETIME,
	TONGTIENDV INT,
	TONGTIENBAN INT,
	THANHTIEN INT
)
ALTER TABLE HOADON
ADD CONSTRAINT PK_HD PRIMARY KEY(MAKH,MABAN)

GO
ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_DICHVU FOREIGN KEY(MABAN) REFERENCES BANBIA(MABAN)

DECLARE @TONGTG TIME = '03:50:00';



Select*from HOADON

UPDATE HOADON
SET NGAYTT = DANGKY.NGAYDANGKY
FROM HOADON
INNER JOIN DANGKY ON HOADON.MABAN = DANGKY.MABAN;

--trigger update hoadon
-- Cập nhật tổng tiền dịch vụ cho các hóa đơn đã thay đổi
-- Thay đổi kiểu dữ liệu của cột TONGTIENBAN sang DECIMAL
ALTER TABLE HOADON
ALTER COLUMN THANHTIEN DECIMAL(18, 2);


go
-- Tạo trigger cho việc tự động cập nhật hóa đơn
CREATE TRIGGER tr_AutoUpdateHoaDon
ON DANGKY
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- Cập nhật tiền dịch vụ cho hóa đơn
UPDATE HOADON
SET TONGTIENDV = (
    SELECT
        ISNULL(SUM(DICHVU.GIA * DANGKY.SOLUONG), 0)
    FROM
        BANBIA
        LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
        LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
        LEFT JOIN DICHVU ON DICHVU.MADV = DANGKY.MADV
    WHERE
        HOADON.MAKH = DANGKY.MAKH
        AND HOADON.MABAN = BANBIA.MABAN
	Group by  BANBIA.MABAN
);

UPDATE HOADON
SET TONGTIENBAN =(
SELECT TOP 1
    (CAST(DATEDIFF(MINUTE, '00:00:00', TONGTG) AS FLOAT) / 60.0) * CAST(GIATIEN AS DECIMAL(10, 2)) AS TONGTIENBAN
FROM
    BANBIA
INNER JOIN 
    DANGKY ON BANBIA.MABAN = DANGKY.MABAN
INNER JOIN 
    KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
INNER JOIN 
    HOADON ON HOADON.MAKH = KHACHHANG.MAKH AND HOADON.MABAN = BANBIA.MABAN
WHERE
    BANBIA.MABAN = 'BB04'
);

-- Cập nhật tổng thành tiền cho hóa đơn
UPDATE HOADON
SET THANHTIEN = TONGTIENDV + TONGTIENBAN;
END;

select sum(thanhtien) from HOADON

select*from HOADON
select*from DANGKY
select*from DICHVU
select*from KHACHHANG
select*from BANBIA

--============================================================================================================
-----------------------------------------------------------------
--6. tạo bảng gậy bia lưu thông tin gậy
CREATE TABLE GAYBIA
(
	MAGAY NCHAR(10) NOT NULL  PRIMARY KEY,
	TENGAY NVARCHAR(100),
	NGAY DATE,
	DODAI INT ,
	SOLUONG  INT ,
)
-----------------------------------------------------------------
-- Thêm dữ liệu vào bảng GAYBIA
INSERT INTO GAYBIA (MAGAY, TENGAY, DODAI, SOLUONG) VALUES
    ('G01', 'Gay 1', 150, 10),
    ('G02', 'Gay 2', 180, 15),
    ('G03', 'Gay 3', 160, 12),
    ('G04', 'Gay 4', 170, 9);
SELECT*FROM GAYBIA 

--============================================================================================================
-----------------------------------------------------------------
--7.TẠO BẢNG BI-A
GO
CREATE TABLE BIA
(
	MABI NCHAR(10) NOT NULL PRIMARY KEY,
	TENBIA NVARCHAR(50) ,
	SOLUONG INT
)
----------------------------------------------------------------
-- Thêm dữ liệu vào bảng BIA
INSERT INTO BIA (MABI, TENBIA, SOLUONG) VALUES
    ('B01', 'Bia 3', 100),
    ('B02', 'Bia 4', 120),
    ('B03', 'Bia 9', 110),
    ('B04', 'Bia 18', 90);
SELECT*FROM BIA

--============================================================================================================
-----------------------------------------------------------------
GO
CREATE TABLE AUTHENTION
(
	USERNAME NCHAR(10) NOT NULL PRIMARY KEY,
	PASS NVARCHAR(20),
)

-- Thêm dữ liệu vào bảng AUTHENTICATION
INSERT INTO AUTHENTION(USERNAME, PASS) VALUES
    ('User01', 'Pass01'),
    ('User02', 'Pass02'),
    ('User03', 'Pass03'),
    ('User04', 'Pass04');

SELECT*FROM AUTHENTION

go
-- Tạo bảng mới coppy dữ liệu bảng hd
CREATE TABLE HoaDonCopy (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MAKH NCHAR(10),
    MABAN NCHAR(10),
    TENKH NVARCHAR(50),
    SDT NCHAR(12),
    TONGTIENDV DECIMAL(18, 2),
    TONGTIENBAN DECIMAL(18, 2),
    THANHTIEN DECIMAL(18, 2),
	NGAYTT datetime
);

-- Sao chép dữ liệu từ bảng HoaDon và KHACHHANG vào bảng HoaDonCopy
INSERT INTO HoaDonCopy (MAKH, MABAN, TENKH, SDT, TONGTIENDV, TONGTIENBAN, THANHTIEN,NGAYTT)
SELECT HD.MAKH, HD.MABAN, KH.TENKH, KH.SDT, HD.TONGTIENDV, HD.TONGTIENBAN, HD.THANHTIEN,HD.NGAYTT
FROM HoaDon HD
INNER JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH;


select*from HoaDonCopy

-- Tạo bảng DangKyCopy
CREATE TABLE DangKyCopy (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MABAN NVARCHAR(50),
    MAKH NVARCHAR(50),
    TENKH NVARCHAR(50),
    SDT NCHAR(12),
    MADV NVARCHAR(50),
    NGAYDANGKY DATETIME,
    SOLUONG INT
);

-- Sao chép dữ liệu từ bảng DangKy vào bảng DangKyCopy
INSERT INTO DangKyCopy (MABAN, MAKH, TENKH, SDT, MADV, NGAYDANGKY, SOLUONG)
SELECT DK.MABAN, DK.MAKH, KH.TENKH, KH.SDT, DK.MADV, DK.NGAYDANGKY, DK.SOLUONG
FROM DangKy DK
INNER JOIN KHACHHANG KH ON DK.MAKH = KH.MAKH;


select*from DangKyCopy

DELETE FROM DangKyCopy


SELECT*FROM KHACHHANG
SELECT*FROM NHANVIEN
SELECT*FROM DANGKY 
SELECT*FROM BANBIA
SELECT*FROM DICHVU

SELECT*FROM NHANVIEN
--============================================================================================================

--các câu truy vấn 
SELECT*FROM DANGKY,KHACHHANG,BANBIA

SELECT MAKH,DICHVU.MADV,MABAN,TENDV,SOLUONG,NGAYDANGKY FROM DANGKY,DICHVU WHERE  DANGKY.MADV =DICHVU.MADV


SELECT SUM(T.THANHTIEN) AS TONG_THANHTIEN
FROM (
    SELECT KHACHHANG.MAKH, SUM(SOLUONG * GIA) AS THANHTIEN
    FROM DANGKY
    JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
    JOIN BANBIA ON DANGKY.MABAN = BANBIA.MABAN
    JOIN DICHVU ON DANGKY.MADV = DICHVU.MADV
    GROUP BY KHACHHANG.MAKH
) AS T;



SELECT BANBIA.MABAN,TENBAN,GIATIEN,TINHTRANG,TINHTRANGTT,KHACHHANG.MAKH,SDT,GIOVAO,TENKH FROM BANBIA,KHACHHANG,DANGKY WHERE DANGKY.MAKH =KHACHHANG.MAKH AND DANGKY.MABAN=BANBIA.MABAN

UPDATE BANBIA
SET TINHTRANG=N'Trống'

UPDATE BANBIA
SET TINHTRANGTT=N'chưa thanh toán'


SELECT BANBIA.MABAN, TENBAN, GIATIEN, TINHTRANG, TINHTRANGTT, KHACHHANG.MAKH, SDT, GIOVAO, TENKH,
       CONVERT(TIME, DATEADD(MINUTE,
           DATEDIFF(MINUTE, GIOVAO, GETDATE()),
           '00:00:00')) AS TONGTG
FROM BANBIA
LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH;



SELECT BANBIA.MABAN, TENBAN, GIATIEN, TINHTRANG, TINHTRANGTT, KHACHHANG.MAKH, SDT, GIOVAO, TENKH,
       CONVERT(TIME, DATEADD(MINUTE, DATEDIFF(MINUTE, GIOVAO, GETDATE()), '00:00:00')) AS TONGTG
FROM BANBIA
LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
WHERE BANBIA.TINHTRANG = N'Đang sử dụng';

SELECT BANBIA.MABAN, TENBAN, GIATIEN, TINHTRANG, TINHTRANGTT, KHACHHANG.MAKH, SDT, GIOVAO, TENKH,
       CONVERT(TIME, DATEADD(MINUTE, DATEDIFF(MINUTE, GIOVAO, GETDATE()), '00:00:00')) AS TONGTG
FROM BANBIA
LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
WHERE BANBIA.TINHTRANG = N'Đang sử dụng' ;


SELECT BANBIA.MABAN, TENBAN, GIATIEN, DICHVU.GIA,DICHVU.MADV,TENDV AS GIA_DICHVU, DANGKY.SOLUONG, GIOVAO, TENKH, 
       CONVERT(TIME, DATEADD(MINUTE, DATEDIFF(MINUTE, GIOVAO, GETDATE()), '00:00:00')) AS TONGTG
FROM BANBIA
LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
LEFT JOIN DICHVU ON DICHVU.MADV = DANGKY.MADV  -- Kết nối bảng DICHVU với DANGKY
WHERE BANBIA.TINHTRANG = N'Đang sử dụng'
  AND BANBIA.MABAN = 'bb16';


  SELECT
       *
    FROM BANBIA
    LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
    LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
    LEFT JOIN DICHVU ON DICHVU.MADV = DANGKY.MADV

-- Đảm bảo rằng kiểu dữ liệu của GIATIEN và DATEDIFF phù hợp, ví dụ kiểu decimal(10, 2)
ALTER TABLE BANBIA
ALTER COLUMN GIATIEN DECIMAL(10, 2);

SELECT
    BANBIA.MABAN,
    TENBAN,
    GIATIEN,
    SUM(DICHVU.GIA * DANGKY.SOLUONG) AS GIA_DICHVU_TONG,
    GIOVAO,
    MIN(TENKH) AS TENKH,
    DATEDIFF(MINUTE, GIOVAO, GETDATE()) / 60.0 AS sogiochoi, -- Số giờ chơi
    GIATIEN * (DATEDIFF(MINUTE, GIOVAO, GETDATE()) / 60.0) AS TienBan -- Tiền bàn
FROM
    BANBIA
    LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
    LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
    LEFT JOIN DICHVU ON DICHVU.MADV = DANGKY.MADV
WHERE
    BANBIA.TINHTRANG = N'Đang sử dụng'
    AND BANBIA.MABAN = 'BB03'
GROUP BY
    BANBIA.MABAN, TENBAN, GIATIEN, GIOVAO;



 SELECT
     TENDV ,SOLUONG, GIA * SOLUONG AS TotalCost
     FROM BANBIA
     LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
     LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
     LEFT JOIN DICHVU ON DICHVU.MADV = DANGKY.MADV
     WHERE BANBIA.TINHTRANG = N'Đang sử dụng'
         AND BANBIA.MABAN ='BB03'
--============================================================================================================
