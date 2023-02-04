USE [GuitarShopManager]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'.NET')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'JAVA')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'PHP')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Python')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (1, N'nhjkloikjy', N'dao', N'ok', 10.0000, CAST(2 AS Decimal(18, 0)), CAST(N'2023-01-31T14:32:18.473' AS DateTime), 1)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (2, N'nhjkloikj2', N'shop', N'ok', 20.0000, CAST(5 AS Decimal(18, 0)), CAST(N'2023-01-31T14:32:55.053' AS DateTime), 2)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (3, N'nhjkloikj3', N'shop1', N'ok', 22.0000, CAST(2 AS Decimal(18, 0)), CAST(N'2023-01-31T14:33:19.400' AS DateTime), 3)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (4, N'nhjkloikj4', N'sj', N'ok', 25.0000, CAST(1 AS Decimal(18, 0)), CAST(N'2023-01-31T14:33:43.107' AS DateTime), 1)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (5, N'nhjkloikj5', N'aaaa', N'ok', 26.0000, CAST(3 AS Decimal(18, 0)), CAST(N'2023-01-31T14:33:58.177' AS DateTime), 2)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (6, N'nhjkloikj6', N'bbbb', N'ok', 28.0000, CAST(6 AS Decimal(18, 0)), CAST(N'2023-01-31T14:34:12.270' AS DateTime), 2)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (7, N'nhjkloikj7', N'ddddd', N'ssss', 56.0000, CAST(8 AS Decimal(18, 0)), CAST(N'2023-01-31T14:34:23.403' AS DateTime), 1)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (8, N'nhjkloikj8', N'eee', N'ss', 2.0000, CAST(6 AS Decimal(18, 0)), CAST(N'2023-01-31T14:34:33.600' AS DateTime), 1)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (9, N'nhjkloikj9', N'ee', N'dd', 2.0000, CAST(3 AS Decimal(18, 0)), CAST(N'2023-01-31T14:34:45.570' AS DateTime), 1)
INSERT [dbo].[Products] ([ProductId], [ProductCode], [ProductName], [Description], [UnitPrice], [DiscountPercent], [DateAdded], [CategoryId]) VALUES (10, N'nhjkloik10', N'ddddd', N'dede', 3.0000, CAST(5 AS Decimal(18, 0)), CAST(N'2023-01-31T14:35:07.440' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (1, N'fpt@gmail.com', N'123', N'f', N'f', N'ha noi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (3, N'fpt2@gmail.com', N'123', N'f', N'd', N'ha noi 2', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (4, N'fpt3@gmail.com', N'123', N'd', N'dd', N'hichi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (5, N'fpt4@gmail.com', N'123', N'a', N'b', N'ha noi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (7, N'fpt5@gmail.com', N'123', N'b', N'c', N'ha noi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (8, N'fpt6@gmail.com', N'123', N'v', N'd', N'ha noi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (9, N'fpt7@gmail.com', N'123', N'b', N'c', N'ha noi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (11, N'fpt8@gmail.com', N'123', N's', N's', N'ha noi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (12, N'fpt9@gmail.com', N'123', N'k', N'k', N'ha noi', 0)
INSERT [dbo].[Customers] ([CustomerId], [Email], [Password], [FirstName], [LastName], [Address], [IsPasswordChanged]) VALUES (13, N'fpt10@gmail.com', N'123', N'k', N'kk', N'ha noi', 0)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (2, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (3, 3, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (4, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (5, 4, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (6, 5, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (7, 4, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (8, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (9, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (10, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (11, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [OrderDate], [ShipAddress]) VALUES (12, 1, CAST(N'2023-01-31T14:32:55.053' AS DateTime), N'ha noi')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (2, 1, 8, 2.0000, CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (2, 2, 2, 12.0000, CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (2, 4, 2, 2.0000, CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (2, 6, 5, 8.0000, CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (3, 2, 2, 2.0000, CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (3, 3, 3, 56.0000, CAST(42 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (3, 5, 2, 1.0000, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (4, 1, 5, 3.0000, CAST(56 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (4, 2, 2, 3.0000, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [UnitPrice], [DiscountPercent]) VALUES (5, 6, 2, 1.0000, CAST(4 AS Decimal(18, 0)))
GO
