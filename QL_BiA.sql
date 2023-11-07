USE MASTER
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
)
-----------------------------------------------------------------
-- Thêm dữ liệu vào bảng BANBIA cho các loại bàn bi-a
INSERT INTO BANBIA (MABAN, TENBAN, LOAIBAN, GIATIEN, TINHTRANG) VALUES
    ('BB01', N'Bàn pool 1', N'Bi-a không lỗ', 10000, N'Trống'),
    ('BB02', N'Bàn Carom 1', N'Bi-a không lỗ', 12000, N'Trống'),
    ('BB03', N'Bàn Snooker 1', N'Bi-a không lỗ', 15000, N'Trống'),
    ('BB04', N'Bàn pool 7', N'Bi-a lỗ', 20000, N'Trống'),
    ('BB05', N'Bàn Carom 7', N'Bi-a lỗ', 22000, N'Trống'),
    ('BB06', N'Bàn Snooker 7', N'Bi-a lỗ', 25000, N'Trống'),
    ('BB07', N'Bàn Carom 2', N'Bi-a không lỗ', 12000, N'Trống'),
    ('BB08', N'Bàn pool 2', N'Bi-a lỗ', 20000, N'Đang sử dụng'),
    ('BB09', N'Bàn Snooker 2', N'Bi-a lỗ', 25000, N'Trống'),
    ('BB10', N'Bàn pool 3', N'Bi-a lỗ', 20000, N'Trống'),
    ('BB11', N'Bàn Snooker 3', N'Bi-a không lỗ', 15000, N'Đang sử dụng'),
    ('BB12', N'Bàn pool 4', N'Bi-a lỗ', 20000, N'Trống'),
    ('BB13', N'Bàn Snooker 4', N'Bi-a không lỗ', 15000, N'Trống'),
    ('BB14', N'Bàn pool 5', N'Bi-a lỗ', 20000, N'Trống'),
    ('BB15', N'Bàn Carom 3', N'Bi-a không lỗ', 12000, N'Trống'),
    ('BB16', N'Bàn pool 6', N'Bi-a lỗ', 20000, N'Đang sử dụng');

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
	MADON NCHAR(10) NOT NULL PRIMARY KEY,
	MAKH NCHAR(10),
	MADV NCHAR(10),
	MABAN NCHAR(10),
	SOLUONG INT
)

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
INSERT INTO DANGKY (MADON, MAKH, MADV, MABAN) VALUES
    ('DK01', 'KH01', 'DV01', 'BB01'),
    ('DK02', 'KH02', 'DV02', 'BB02'),
    ('DK03', 'KH03', 'DV03', 'BB03'),
    ('DK04', 'KH04', 'DV04', 'BB04'),
    ('DK05', 'KH05', 'DV03', 'BB05'),
    ('DK06', 'KH06', 'DV06', 'BB06'),
    ('DK07', 'KH07', 'DV01', 'BB07'),
    ('DK08', 'KH08', 'DV03', 'BB08'),
    ('DK09', 'KH09', 'DV05', 'BB09'),
    ('DK10', 'KH10', 'DV05', 'BB10');

SELECT*FROM DANGKY
-----------------------------------------------------------------

CREATE TABLE CTHOADON
(
	MACTHD NCHAR(10) NOT NULL PRIMARY KEY,
	MADON NCHAR(10),
	TIENBAN INT,
)

ALTER TABLE CTHOADON
ADD CONSTRAINT FK_CTHD_DK FOREIGN KEY(MADON) REFERENCES DANGKY(MADON)
-----------------------------------------------------------------
-- Insert data into the CTHOADON table
INSERT INTO CTHOADON (MACTHD, MADON, TIENBAN) VALUES
    ('CTHD01', 'DK01', 25000),
    ('CTHD02', 'DK02', 30000),
    ('CTHD03', 'DK03', 35000),
    ('CTHD04', 'DK04', 40000),
    ('CTHD05', 'DK05', 45000);

-----------------------------------------------------------------
CREATE TABLE HOADON
(
	MAHD NCHAR(10) NOT NULL PRIMARY KEY,
	MACTHD NCHAR(10),
	MAKH NCHAR(10),
	TONGTIEN INT ,
	TINHTRANGTT NVARCHAR(20)
)
ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_DK FOREIGN KEY(MACTHD) REFERENCES CTHOADON(MACTHD)
-----------------------------------------------------------------
INSERT INTO HOADON (MAHD, MACTHD, MAKH, TONGTIEN, TINHTRANGTT) VALUES
    ('HD01', 'CTHD01', 'KH01', 50000, N'Đã thanh toán'),
    ('HD02', 'CTHD02', 'KH02', 60000, N'Chưa thanh toán'),
    ('HD03', 'CTHD03', 'KH03', 70000, N'Đã thanh toán'),
    ('HD04', 'CTHD04', 'KH04', 80000, N'Chưa thanh toán'),
    ('HD05', 'CTHD05', 'KH05', 90000, N'Đã thanh toán');
-----------------------------------------------------------------

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

SELECT SUM(TONGTIEN) AS TONGTIENNGAY 
FROM HOADON


SELECT*FROM KHACHHANG
SELECT*FROM NHANVIEN
SELECT*FROM DANGKY 
SELECT*FROM BANBIA
SELECT*FROM DICHVU
SELECT*FROM HOADON


SELECT*FROM DANGKY,KHACHHANG,BANBIA

SELECT MADON,KHACHHANG.MAKH,BANBIA.MABAN,TENKH,SDT,GIOVAO,TENBAN,TINHTRANG FROM DANGKY,KHACHHANG,BANBIA WHERE DANGKY.MABAN=BANBIA.MABAN AND DANGKY.MAKH=KHACHHANG.MAKH

SELECT MACTHD,CTHOADON.MADON,MAKH,DICHVU.MADV,MABAN,TENDV,SOLUONG FROM CTHOADON,DANGKY,DICHVU WHERE CTHOADON.MADON = DANGKY.MADON AND DICHVU.MADV=DANGKY.MADV