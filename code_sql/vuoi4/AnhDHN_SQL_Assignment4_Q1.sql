USE master;
GO

-- Drop the database if it already exists
IF EXISTS (SELECT name FROM		sys.databases WHERE name = N'OrderManagement')
	DROP DATABASE OrderManagement;
GO

--Create Database OrderManagement
CREATE DATABASE OrderManagement;
GO
--Use Database OrderManagement
USE OrderManagement;
GO

-----------------------Question 1----------------------------

--1. Create the tables (with the most appropriate field/column constraints & types) and add at least 3
--records into each created table.

CREATE	TABLE SanPham (
	MaSanPham INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	TenSanPham NVARCHAR(100),
	DonGia MONEY
);
GO

CREATE	TABLE KhachHang (
	MaKhachHang INT NOT NULL PRIMARY KEY,
	TenKhachHang NVARCHAR(100),
	PhoneNo INT,
	GhiChu NVARCHAR(255)
);
GO

CREATE	TABLE DonHang (
	MaDonHang INT NOT NULL PRIMARY KEY,
	NgayDatHang DATE,
	MaSanPham INT NOT NULL
		FOREIGN KEY REFERENCES SanPham (MaSanPham),
	SoLuong INT,
	MaKhachHang INT NOT NULL
		FOREIGN KEY REFERENCES KhachHang (MaKhachHang)
);
GO

-- Add 3 records into each created table

INSERT	INTO SanPham (TenSanPham, DonGia)
VALUES (N'Lap Top', 60000000),
	(N'Điện Thoại', 8000000),
	(N'Đồng Hồ', 100000000);
GO

INSERT	INTO KhachHang (MaKhachHang, TenKhachHang, PhoneNo, GhiChu)
VALUES (1, N'Nguyễn Văn A', 624862394, 'No'),
	(2, N'Nguyễn Thị B', 274623743, 'No'),
	(3, N'Nguyễn Văn C', 294875293, 'No');
GO

INSERT	INTO DonHang (MaDonHang, NgayDatHang, MaSanPham, SoLuong, MaKhachHang)
VALUES (1, '2022-06-15', 2, 5, 3),
	(2, '2022-03-05', 1, 3, 1),
	(3, '2022-01-10', 2, 6, 2);
GO

--2. Create an order slip VIEW which has the same number of lines as the Don_Hang, with the
--following information: Ten_KH, Ngay_DH, Ten_SP, So_Luong, Thanh_Tien

CREATE	VIEW vwDonHang
AS
SELECT	kh.TenKhachHang,
		dh.NgayDatHang,
		sp.TenSanPham,
		dh.SoLuong,
		SUM( dh.SoLuong * sp.DonGia ) AS ThanhTien
FROM	KhachHang kh
	INNER JOIN DonHang dh
		ON kh.MaKhachHang	= dh.MaKhachHang
	INNER JOIN SanPham sp
		ON dh.MaSanPham	= sp.MaSanPham
GROUP BY kh.TenKhachHang,
		dh.NgayDatHang,
		sp.TenSanPham,
		dh.SoLuong;
GO
----------------------------
--SELECT	*
--FROM	SanPham;
--SELECT	*
--FROM	KhachHang;
--SELECT	*
--FROM	DonHang;
--SELECT	*
--FROM	vwDonHang;