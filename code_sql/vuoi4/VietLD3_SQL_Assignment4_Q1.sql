USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT NAME
FROM sys.databases
WHERE NAME = N'OrderManagement'
)
DROP DATABASE OrderManagement
GO

CREATE DATABASE OrderManagement
GO

USE OrderManagement
GO
CREATE TABLE [KhachHang]
(
    [MaKhachHang] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID()
    , [TenKhachHang] NVARCHAR(100) NOT NULL
    , [PhoneNo] NVARCHAR(15) NOT NULL
    , [GhiChu] NVARCHAR(MAX) NULL
) 

GO
CREATE TABLE [SanPham]
(
    [MaSanPham] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID()
    , [TenSanPham] NVARCHAR(200) NOT NULL
    , [DonGia] DECIMAL NOT NULL
)
GO
CREATE TABLE [DonHang]
(
    [MaDonHang] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID()
    , [NgayDonHang] DATETIME NOT NULL
    , [MaSanPham] UNIQUEIDENTIFIER NOT NULL
    , [SoLuong] INT NOT NULL
    , [MaKhachHang] UNIQUEIDENTIFIER NOT NULL
    , CONSTRAINT [FK_DonHang_SanPham] FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
    , CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
)
GO
INSERT INTO [KhachHang]
    ([MaKhachHang], [TenKhachHang], [PhoneNo], [GhiChu])
VALUES
    (N'767c36bd-e4f5-4927-921b-22cf171a976f', N'nguyen e', N'069325687', N'ko')
    ,(N'0d3edd59-8b88-431c-a469-8aad2e3e4a28', N'nguyen a', N'0123456987', N'ko')
    ,(N'a680a305-0c8a-434b-b26c-99582bb8ceca', N'nguyen b', N'0256986515', N'ko')
    ,(N'0d532397-8432-4c1a-9970-b526a7258429', N'nguyen d', N'025478963', N'ko')
    ,(N'8434f33d-d541-4929-8f0a-cb939c35f716', N'nguyen c', N'025693265', N'ko');
GO
INSERT INTO [SanPham]
    ([MaSanPham], [TenSanPham], [DonGia])
VALUES
    (N'fb0cfe1b-0438-4212-97e7-5e107f421d9e', N'Java', 1000.0000)
    ,(N'99b3b07c-3182-43c0-81ea-647877fe2c87', N'.NET', 2000.0000)
    ,(N'f66816bb-53ed-434e-9e73-dfd457e0abfc', N'HTML', 1200.0000)
    ,(N'eabe0bb9-c6b6-43d0-bd0c-f0264de58c24', N'CSS', 1500.0000);
GO
INSERT INTO [DonHang]
    ([MaDonHang], [NgayDonHang], [MaSanPham], [SoLuong], [MaKhachHang])
VALUES
    (N'24d898db-e488-4e90-ab63-1e1079156d92', CAST(N'2022-10-02T00:00:00.000' AS DateTime), N'eabe0bb9-c6b6-43d0-bd0c-f0264de58c24', 5, N'8434f33d-d541-4929-8f0a-cb939c35f716')
    ,(N'cab09ced-913b-460f-bb6e-8ddd1bf99ffb', CAST(N'2022-10-02T00:00:00.000' AS DateTime), N'fb0cfe1b-0438-4212-97e7-5e107f421d9e', 10, N'0d3edd59-8b88-431c-a469-8aad2e3e4a28')
    ,(N'80fc1bd8-e963-4752-9799-9a29bd807c45', CAST(N'2022-12-12T00:00:00.000' AS DateTime), N'99b3b07c-3182-43c0-81ea-647877fe2c87', 5, N'767c36bd-e4f5-4927-921b-22cf171a976f')
    ,(N'09bae8ab-2a9d-48fa-91c9-a06c03dc1b82', CAST(N'2022-10-02T00:00:00.000' AS DateTime), N'eabe0bb9-c6b6-43d0-bd0c-f0264de58c24', 6, N'a680a305-0c8a-434b-b26c-99582bb8ceca');
GO

CREATE VIEW vwOrderSlip
AS
    SELECT kh.TenKhachHang
	, CAST(dh.NgayDonHang AS Date) NgayDonHang
	, sp.TenSanPham, dh.SoLuong
	, (dh.SoLuong*sp.DonGia) ThanhTien
    from DonHang dh
        JOIN SanPham sp ON dh.MaSanPham = sp.MaSanPham
        JOIN KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang  

