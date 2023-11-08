﻿USE MASTER
GO
CREATE DATABASE QLPHONGBIA
GO
USE QLPHONGBIA

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
-----------------------------------------------------------------
GO
CREATE TABLE NHANVIEN
(
	MANV NCHAR(10) NOT NULL PRIMARY KEY,
	TENNV NVARCHAR(50),
	TUOI INT,
	DIACHI NVARCHAR(50),
	SDT NCHAR(10),
	GIOITINH NCHAR(10)
)
-----------------------------------------------------------------
-- Thêm 10 dòng dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANV, TENNV, TUOI, DIACHI, SDT, GIOITINH) VALUES
    ('NV01', N'Nguyễn Văn An', 28, N'Hà Nội', '0123456789', N'Nam'),
    ('NV02', N'Trần Thị Bình', 35, N'Hồ Chí Minh', '0987654321', N'Nữ'),
    ('NV03', N'Lê Minh Cường', 30, N'Đà Nẵng', '0369847201', N'Nam'),
    ('NV04', N'Phạm Thanh Duy', 24, N'Hải Phòng', '0765432198', N'Nam'),
    ('NV05', N'Hoàng Thị Ngọc', 29, N'Cần Thơ', '0897654321', N'Nữ'),
    ('NV06', N'Nguyễn Văn Đức', 26, N'Hà Tĩnh', '0765432987', N'Nam'),
    ('NV07', N'Trần Thị Lan', 32, N'Nghệ An', '0123456789', N'Nữ'),
    ('NV08', N'Lê Minh Hà', 40, N'Quảng Ninh', '0987654321', N'Nữ'),
    ('NV09', N'Phạm Văn Tùng', 27, N'Quảng Bình', '0369847201', N'Nam'),
    ('NV10', N'Hoàng Thị Hương', 33, N'Bắc Giang', '0765432198', N'Nữ');
SELECT*FROM NHANVIEN
-----------------------------------------------------------------
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
    ('BB02', N'Bàn Carom 1', N'Bi-a không lỗ', 12000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB03', N'Bàn Snooker 1', N'Bi-a không lỗ', 15000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB04', N'Bàn pool 7', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB05', N'Bàn Carom 7', N'Bi-a lỗ', 22000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB06', N'Bàn Snooker 7', N'Bi-a lỗ', 25000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB07', N'Bàn Carom 2', N'Bi-a không lỗ', 12000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB08', N'Bàn pool 2', N'Bi-a lỗ', 20000, N'Đang sử dụng', N'Thanh toán đủ'),
    ('BB09', N'Bàn Snooker 2', N'Bi-a lỗ', 25000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB10', N'Bàn pool 3', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB11', N'Bàn Snooker 3', N'Bi-a không lỗ', 15000, N'Đang sử dụng', N'Thanh toán đủ'),
    ('BB12', N'Bàn pool 4', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB13', N'Bàn Snooker 4', N'Bi-a không lỗ', 15000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB14', N'Bàn pool 5', N'Bi-a lỗ', 20000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB15', N'Bàn Carom 3', N'Bi-a không lỗ', 12000, N'Trống', N'Thanh toán chưa đủ'),
    ('BB16', N'Bàn pool 6', N'Bi-a lỗ', 20000, N'Đang sử dụng', N'Thanh toán đủ');

SELECT*FROM BANBIA
-----------------------------------------------------------------
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
	SELECT*FROM DICHVU
-----------------------------------------------------------------
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
    ('KH03', 'DV03', 'BB03', GETDATE(), 1), -- Example with current date and quantity
    ('KH04', 'DV04', 'BB04', GETDATE(), 4), -- Example with current date and quantity
    ('KH05', 'DV03', 'BB05', GETDATE(), 2), -- Example with current date and quantity
    ('KH06', 'DV06', 'BB06', GETDATE(), 3), -- Example with current date and quantity
    ('KH07', 'DV01', 'BB07', GETDATE(), 2), -- Example with current date and quantity
    ('KH08', 'DV03', 'BB08', GETDATE(), 1), -- Example with current date and quantity
    ('KH09', 'DV05', 'BB09', GETDATE(), 4); -- Example with current date and quantity

SELECT*FROM DANGKY
-----------------------------------------------------------------
SELECT KHACHHANG.MAKH, BANBIA.MABAN, TENKH, SDT, GIOVAO, TENBAN, TINHTRANG FROM DANGKY, KHACHHANG, BANBIA WHERE DANGKY.MABAN = BANBIA.MABAN  and KHACHHANG.MAKH=DANGKY.MAKH
-----------------------------------------------------------------
CREATE TABLE GAYBIA
(
	MAGAY NCHAR(10) NOT NULL  PRIMARY KEY,
	TENGAY NVARCHAR(100),
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
-----------------------------------------------------------------
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


SELECT*FROM KHACHHANG
SELECT*FROM NHANVIEN
SELECT*FROM DANGKY 
SELECT*FROM BANBIA
SELECT*FROM DICHVU


SELECT*FROM DANGKY,KHACHHANG,BANBIA

SELECT MAKH,DICHVU.MADV,MABAN,TENDV,SOLUONG,NGAYDANGKY FROM DANGKY,DICHVU WHERE  DANGKY.MADV =DICHVU.MADV