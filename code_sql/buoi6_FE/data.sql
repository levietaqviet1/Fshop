USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT NAME
FROM sys.databases
WHERE NAME = N'GuitarShopManager'
)
DROP DATABASE [GuitarShopManager]
GO

CREATE DATABASE [GuitarShopManager]
GO

USE [GuitarShopManager]
GO 
CREATE TABLE Categories -- Tạo [Categories]
(
	[CategoryId] INT PRIMARY KEY IDENTITY(1,1)
	,[CategoryName] NVARCHAR(50) UNIQUE NOT NULL
 )  
GO  
CREATE TABLE Products -- Tạo [Products]
(
	[ProductId] INT PRIMARY KEY IDENTITY(1,1)
	,[ProductCode] NVARCHAR(10) UNIQUE NOT NULL CHECK(LEN(ProductCode)<=10)
	,[ProductName] NVARCHAR(200) NOT NULL
	,[Description] TEXT NOT NULL
	,[UnitPrice] MONEY NOT NULL
	,[DiscountPercent] DECIMAL DEFAULT 0.00
	,[DateAdded] DATETIME DEFAULT GETDATE()
	,[CategoryId] INT NOT NULL
	,CONSTRAINT [FK_Products_Categories] FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
)
GO
CREATE TABLE Customers -- Tạo [Customers]
(
	[CustomerId] INT PRIMARY KEY IDENTITY(1,1)
	,[Email] VARCHAR(200) UNIQUE NOT NULL
	,[Password] VARCHAR(200) NOT NULL
	,[FirstName] NVARCHAR(200) NOT NULL
	,[LastName] NVARCHAR(200) NOT NULL
	,[Address] NVARCHAR(MAX) NOT NULL
	,[IsPasswordChanged] BIT DEFAULT 0
) 
GO
CREATE TABLE Orders -- Tạo [Orders]
(
	[OrderId] INT PRIMARY KEY IDENTITY(1,1)
	,[CustomerId] INT NOT NULL
	,[OrderDate] DATETIME NOT NULL
	,[ShipAddress] TEXT NOT NULL
	,CONSTRAINT [FK_Orders_Customers] FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
)
GO

CREATE TABLE OrderItems -- Tạo [OrderItems]
(
	[OrderId] INT
	,[ProductId] INT
	,[Quantity] INT NOT NULL
	,[UnitPrice] MONEY NOT NULL
	,[DiscountPercent] DECIMAL NOT NULL
	,PRIMARY KEY (OrderId, ProductId)
	,CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
    ,CONSTRAINT [FK_OrderItems_Products] FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
) 
GO

-- a  
SET IDENTITY_INSERT [dbo].[Categories] ON 
INSERT INTO [Categories] ([CategoryId], [CategoryName]) 
	VALUES	(1, '.SQL')
			,(2, 'JAVA')
			,(3, 'PHP')
			,(4, '.NET');
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF 
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
INSERT INTO [Products] 
	([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) 
VALUES	 (1, 'mahonhoppl', 'dao1', N'ok', 100, 2, CAST(N'2023-01-31T14:32:18.473' AS DateTime), 1)
		,(2, 'mahonhopp2', 'dao2', N'ok', 2000, 5, CAST(N'2023-01-30T14:32:55.053' AS DateTime), 2)
		,(3, 'mahonhopp3', 'dao3', N'ok', 2200, 2, CAST(N'2023-01-29T14:33:19.400' AS DateTime), 3)
		,(4, 'mahonhopp4', 'dao4', N'ok', 250, 1, CAST(N'2023-01-30T14:33:43.107' AS DateTime), 1)
		,(5, 'mahonhopp5', 'dao5', N'ok', 2600, 3, CAST(N'2023-01-16T14:33:58.177' AS DateTime), 1)
		,(6, 'mahonhopp6', 'dao6', N'ok', 280, 6, CAST(N'2023-01-15T14:34:12.270' AS DateTime), 2)
		,(7, 'mahonhopp7', 'dao7', N'good', 560, 8, CAST(N'2023-01-14T14:34:23.403' AS DateTime), 1)
		,(8, 'mahonhopp8', 'dao8', N'good', 20, 6, CAST(N'2023-01-16T14:34:33.600' AS DateTime), 1)
		,(9, 'mahonhopp9', 'dao9', N'good', 500, 3, CAST(N'2023-01-16T14:34:45.570' AS DateTime), 1)
		,(10,'mahonhop10', 'dao10', N'good', 300, 5, CAST(N'2023-01-15T14:35:07.440' AS DateTime), 2);
GO
SET IDENTITY_INSERT [dbo].[Products] OFF 
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
INSERT INTO [Customers] 
	([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged])
	VALUES	(1, N'fshop@gmail.com', N'123', N'viet', N'f', N'ha noi', 0)
			,(3, N'fpt2@gmail.com', N'123', N'f', N'd', N'ha noi 2', 0)
			,(4, N'fshop3@gmail.com', N'1234', N'd', N'le', N'hichi', 0)
			,(5, N'fpt4@gmail.com', N'123', N'a', N'b', N'ha noi', 0)
			,(7, N'fshop5@gmail.com', N'123', N'b', N'c', N'ha noi', 0)
			,(8, N'fpt6@gmail.com', N'123', N'v', N'd', N'ha noi', 0)
			,(9, N'fshop7@gmail.com', N'1234', N'b', N'c', N'ha noi', 0)
			,(11, N'fpt8@gmail.com', N'123', N's', N's', N'ha noi', 0)
			,(12, N'fshop9@gmail.com', N'123', N'k', N'k', N'ha noi', 0)
			,(13, N'fpt10@gmail.com', N'123', N'k', N'kk', N'ha noi', 0);
GO 
SET IDENTITY_INSERT [dbo].[Customers] OFF 
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
INSERT INTO [Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) 
VALUES	(2, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
		,(3, 3, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
		,(4, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
		,(5, 4, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
		,(6, 5, CAST(N'2023-01-30T14:32:55.053' AS DateTime), N'ha noi')
		,(7, 4, CAST(N'2023-01-19T14:32:55.053' AS DateTime), N'ha noi')
		,(8, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
		,(9, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
		,(10, 1, CAST(N'2023-01-28T14:32:55.053' AS DateTime), N'ha noi')
		,(11, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
		,(12, 1, CAST(N'2023-01-30T14:32:55.053' AS DateTime), N'ha noi'); 
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT INTO [OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) 
VALUES	(2, 1, 8, 2.0000, 2)
		,(2, 2, 2, 12.0000, 2)
		,(2, 4, 2, 2.0000, 3)
		,(2, 6, 5, 8.0000, 2)
		,(3, 2, 2, 2.0000, 5)
		,(3, 3, 3, 56.0000, 42)
		,(3, 5, 2, 1.0000, 5)
		,(4, 1, 5, 3.0000, 56)
		,(4, 2, 2, 3.0000, 5)
		,(5, 6, 2, 1.0000, 4);
-- b
GO
UPDATE Products -- update cho bảng Products
SET DiscountPercent = 35 -- thay DiscountPercent = 35%
WHERE DateAdded <= DATEADD(MONTH, -12, GETDATE()); -- Update những date nào từ 12 tháng trước
-- c
GO
UPDATE Customers -- update cho bảng Customers
SET Password = 'Secret@12341*', IsPasswordChanged = 1 -- thay Password thành 'Secret@12341*' và sửa IsPasswordChanged = 1
WHERE Email = 'rick@raven.com' AND IsPasswordChanged = 0; -- Update những Email nào tên là rick@raven.com và có IsPasswordChanged = 0
-- d
GO
SELECT (LastName + ', ' + FirstName) AS FullName -- hiện thị tên cột là FullName
FROM Customers -- lấy dữ liệu từ Customers
WHERE LastName BETWEEN 'M' AND 'Z' -- lấy từ điều kiện LastName là M đến  Z
ORDER BY LastName ASC; -- sắp sếp tăng dần theo LastName
-- e
GO
SELECT ProductName
	, UnitPrice
	, DateAdded -- hiện thị cột tên,giá,thời gian
FROM Products -- lấy dữ liệu từ Products
WHERE UnitPrice BETWEEN 500 AND 2000 -- lấy từ điều kiện giá trong phạm vi từ 500 đến 2000
ORDER BY DateAdded DESC; -- sắp sếp giảm dần theo DateAdded
-- f
SELECT Customers.CustomerId -- hiện thị id
	, (Customers.LastName + ', ' + Customers.FirstName) AS Name -- hiện thị tên
	, Customers.Email, Customers.Address -- hiện thị địa chỉ
	, SUM((OrderItems.Quantity * OrderItems.UnitPrice) * (1 - OrderItems.DiscountPercent / 100)) AS TotalAmount -- tính tổng khách hàng đã chi
FROM Customers -- lấy dữ liệu từ bảng Customers
 JOIN Orders ON Customers.CustomerId = Orders.CustomerId -- lấy thêm dữ liệu từ bảng Orders qua khóa CustomerId
 JOIN OrderItems ON Orders.OrderId = OrderItems.OrderId -- lấy thêm dữ liệu từ bảng OrderItems qua khóa OrderId
GROUP BY Customers.CustomerId, Customers.LastName, Customers.FirstName, Customers.Email, Customers.Address; -- nhóm theo id,name,email