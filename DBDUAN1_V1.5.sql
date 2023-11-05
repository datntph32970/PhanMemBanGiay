USE MASTER
GO

CREATE DATABASE DBGIAY_DUAN1
GO

USE DBGIAY_DUAN1
GO

CREATE TABLE CHUCVU
(
	MACHUCVU INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    TENCHUCVU NVARCHAR(50),
	MOTACHUCVU NVARCHAR(200)
)

CREATE TABLE TAIKHOAN
(
	MATAIKHOAN INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    USERNAME VARCHAR(30),
	PASWORD VARCHAR(30),
	HOVATEN NVARCHAR(50),
	GIOITINH BIT,
	SODIENTHOAI VARCHAR(10),
	DIACHI NVARCHAR(200),
	EMAIL VARCHAR(50),
	NGAYTHANGNAMSINH DATE,
	NGAYTAOTAIKHOAN DATE,
	MACHUCVU INT,
	Locked bit,
	FOREIGN KEY (MACHUCVU) REFERENCES CHUCVU(MACHUCVU)
)

CREATE TABLE KHACHHANG
(
	MAKHACHHANG INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    TENKHACHHANG NVARCHAR(50),
	SDT VARCHAR(10),
	DIEMKHACHHANG INT,
	Locked bit
)

CREATE TABLE UUDAI
(
	MAUUDAI INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    TENUUDAI NVARCHAR(50),
	NGAYBATDAU DATETIME,
	NGAYKETTHUC DATETIME,
	PHANTRAM int,
	TRANGTHAI BIT,
	SOLUONG INT
)
CREATE TABLE HINHTHUCTHANHTOAN
(
	MAHINHTHUCTHANHTOAN INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENHINHTHUC NVARCHAR(50),
	MOTA NVARCHAR(200)
)
CREATE TABLE HOADON
(
	MAHOADON INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MATAIKHOAN INT,
	MAUUDAI INT,
	MAKHACHHANG INT,
	NGAYTAO DATETIME,
	TONGTIEN FLOAT,
	TRANGTHAI BIT,
	GHICHU NVARCHAR(200),
	MAHINHTHUCTHANHTOAN int,
	FOREIGN KEY (MATAIKHOAN) REFERENCES TAIKHOAN(MATAIKHOAN),
	FOREIGN KEY (MAUUDAI) REFERENCES UUDAI(MAUUDAI),
	FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
	FOREIGN KEY (MAHINHTHUCTHANHTOAN) REFERENCES HINHTHUCTHANHTOAN(MAHINHTHUCTHANHTOAN)
)

CREATE TABLE THUONGHIEU
(
	MATHUONGHIEU INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENTHUONGHIEU NVARCHAR(50),
	EMAIL VARCHAR(50),
	SDT VARCHAR(10),
	Locked bit
)
CREATE TABLE CHATLIEU
(
	MACHATLIEU INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENCHATLIEU NVARCHAR(50),
	MOTA NVARCHAR(200),
	Locked bit
)
CREATE TABLE MAUSAC 
(
	MAMAUSAC INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENMAUSAC NVARCHAR(50),
	MOTA NVARCHAR(200),
	Locked bit
)
CREATE TABLE KICHCO 
(
	MAKICHCO INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENKICHCO NVARCHAR(50),
	MOTA NVARCHAR(200),
	Locked bit
)
CREATE TABLE GIAY 
(
	MAGIAY INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENGIAY NVARCHAR(50),
	MATHUONGHIEU INT,
	TRANGTHAI BIT,
	GIA FLOAT,
	MOTA NVARCHAR(200),
	Locked bit,
	FOREIGN KEY (MATHUONGHIEU) REFERENCES THUONGHIEU(MATHUONGHIEU)
)
CREATE TABLE HoaDonChiTiet 
(
	MaHoaDonChiTiet INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MaGiay INT,
	MaHoaDon INT,
	SoLuongMua INT,
	Gia FLOAT,
	FOREIGN KEY (MAGIAY) REFERENCES GIAY(MAGIAY),
	FOREIGN KEY (MAHOADON) REFERENCES HOADON(MAHOADON)
)
CREATE TABLE Giay_ChiTiet
(
	Ma_Giay_ChiTiet INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MaGiay INT,
	MaChatLieu  INT,
	MaMauSac  INT,
	MaKichCo INT,
	SoLuongCon INT,
	FOREIGN KEY (MAGIAY) REFERENCES GIAY(MAGIAY),
	FOREIGN KEY (MACHATLIEU) REFERENCES CHATLIEU(MACHATLIEU),
	FOREIGN KEY (MaMauSac) REFERENCES MauSac(MaMauSac),
	FOREIGN KEY (MaKichCo) REFERENCES KichCo(MaKichCo)
)
