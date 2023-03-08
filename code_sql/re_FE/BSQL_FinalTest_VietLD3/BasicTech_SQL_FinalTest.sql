USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT NAME
FROM sys.databases
WHERE NAME = N'BasicTech_SQL_FinalTest'
)
DROP DATABASE BasicTech_SQL_FinalTest
GO

CREATE DATABASE BasicTech_SQL_FinalTest
GO
USE BasicTech_SQL_FinalTest
GO  
CREATE TABLE Department -- Tạo [Department]
(
	[DepartmentId] INT PRIMARY KEY IDENTITY(1,1)
	,[DepartmentName] NVARCHAR(50) NOT NULL
)
GO 
CREATE TABLE Employee -- Tạo [Employee]
(
	[EmployeeId] INT PRIMARY KEY IDENTITY(1,1)
	,[SSN] CHAR(9) NOT NULL CHECK(LEN(SSN)=9)
    ,[FirstName] NVARCHAR(50) NOT NULL
    ,[LastName] NVARCHAR(50) NOT NULL
    ,[BirthDate] DATETIME NOT NULL
    ,[HireDate] DATETIME NULL CHECK (HireDate < GETDATE())
    ,[HourlyWage] DECIMAL NULL
	,[EmployeeManagerId] INT NULL
	,[DepartmentId] INT
	,CONSTRAINT [FK_Employee_Employee] FOREIGN KEY (EmployeeManagerId) REFERENCES Employee(EmployeeId)
	,CONSTRAINT [FK_Employee_Department] FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId) 
)  
GO 
CREATE TABLE Timesheet -- Tạo [Timesheet]
(
	[TimesheetId] INT PRIMARY KEY IDENTITY(1,1)
	,[PayrollDate] DATETIME NOT NULL 
	,[WorkingHours] DECIMAL NOT NULL 
	,[EmployeeId] INT NOT NULL 
	,CONSTRAINT [FK_Timesheet_Employee] FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId) ON DELETE CASCADE
)  
GO  
CREATE TABLE Product -- Tạo [Product]
(
	[ProductId] INT PRIMARY KEY IDENTITY(1,1)
	,[ProductName] NVARCHAR(50) NOT NULL
	,[Description] NVARCHAR(50) NOT NULL
	,[RetailPrice] DECIMAL NOT NULL 
	,[WholeSalePrice] DECIMAL NOT NULL 
	,[DepartmentId] INT
	,CONSTRAINT [FK_Product_Department] FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId)
)
GO  
CREATE TABLE Vendor -- Tạo [Vendor]
(
	[VendorId] INT PRIMARY KEY IDENTITY(1,1)
	,[SSN] CHAR(9) NOT NULL CHECK(LEN(SSN)=9)
	,[VendorName] NVARCHAR(50) NOT NULL
	,[Phone] VARCHAR(13) NOT NULL
	,[Website] VARCHAR(MAX) NOT NULL
	,[ProductId] INT
	,CONSTRAINT [FK_Vendor_Department] FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
)
GO
-- Q1 Add records
SET IDENTITY_INSERT [Department] ON 
GO
INSERT  [Department] ([DepartmentId], [DepartmentName]) 
	VALUES	(1, N'PO'),
			(2, N'PA'),
			(3, N'OP'),
			(4, N'BA');
SET IDENTITY_INSERT [Department] OFF
GO
SET IDENTITY_INSERT [Employee] ON 
GO
INSERT [Employee] ([EmployeeId], [SSN], [FirstName], [LastName], [BirthDate], [HireDate], [HourlyWage], [EmployeeManagerId], [DepartmentId]) 
	VALUES 
	(1, N'a123a4561', N'nguyen a', N'duc', '2003-01-02', '2013-01-02', 180, NULL, 1),
	(2, N'a123a4562', N'nguyen b', N'duc', '2003-01-03', '2013-01-02', 280, NULL, 2),
	(3, N'a123a4563', N'nguyen c', N'duc', '2003-01-04', '2013-01-02', 80, 1, 2),
	(4, N'a123a4564', N'nguyen d', N'duc', '2003-01-05', '2013-01-02', 80, 2, 1),
	(5, N'a123a4565', N'nguyen q', N'duc', '2003-01-06', '2013-01-02', 80, 1, 2),
	(6, N'a123a4566', N'nguyen w', N'duc', '2003-01-06', '2013-01-02', 80, 2, 1),
	(7, N'a123a4567', N'nguyen e', N'duc', '2003-01-07', '2013-01-02', 80, 1, 2),
	(8, N'a123a4568', N'nguyen r', N'duc', '2003-01-08', '2013-01-02', 80, 2, 3),
	(9, N'a123a4569', N'nguyen t', N'duc', '2003-07-07', '2013-01-02', 80, 1, 4),
	(10, N'a123a4560', N'nguyen y', N'duc','2007-01-02', '2013-01-02', 80, 2, 1);
GO
SET IDENTITY_INSERT [Employee] OFF
GO
 
SET IDENTITY_INSERT [Product] ON 
GO
INSERT [Product] ([ProductId], [ProductName], [Description], [RetailPrice], [WholeSalePrice], [DepartmentId]) 
	VALUES	(1, N'web a1', N'abc1', 5, 2, 1),
			(2, N'web a2', N'abc2', 5, 2, 2),
			(3, N'web a3', N'abc3', 5, 2, 1),
			(4, N'web a4', N'abc4', 5, 2, 2),
			(5, N'web a5', N'abc5', 5, 2, 4),
			(6, N'web a6', N'abc6', 5, 2, 1),
			(7, N'web a7', N'abc7', 5, 2, 2),
			(8, N'web a8', N'abc8', 5, 2, 1),
			(9, N'web a9', N'abc9', 5, 2, 3),
			(10, N'web a', N'abcc', 5, 2, 2);
GO
SET IDENTITY_INSERT [Product] OFF
GO

SET IDENTITY_INSERT [Vendor] ON 
GO
INSERT [Vendor] ([VendorId], [SSN], [VendorName], [Phone], [Website], [ProductId]) 
	VALUES	(1, N'123456791', N've1', N'056965321', N'abc1', 1),
			(2, N'123456792', N've2', N'056965322', N'abc2', 2),
			(3, N'123456793', N've3', N'056965323', N'abc3', 1),
			(4, N'123456794', N've4', N'056965324', N'abc4', 3),
			(5, N'123456795', N've5', N'056965325', N'abc5', 1),
			(6, N'123456796', N've6', N'056965326', N'abc6', 4),
			(7, N'123456797', N've7', N'056965327', N'abc7', 1),
			(8, N'123456798', N've8', N'056965328', N'abc8', 8),
			(9, N'123456799', N've9', N'056965329', N'abc9', 9),
			(10, N'123456798', N've', N'056965326', N'abc', 10);
SET IDENTITY_INSERT [Vendor] OFF
GO

SET IDENTITY_INSERT [Timesheet] ON 
GO
INSERT [Timesheet] ([TimesheetId], [PayrollDate], [WorkingHours], [EmployeeId]) 
	VALUES	(1, '2006-03-02', 5, 1),
			(2, '2021-02-02', 5, 1),
			(3, '2006-02-02', 5, 2),
			(4, '2006-02-02', 5, 2),
			(5, '2006-02-02', 5, 3),
			(6, '2006-02-02', 5, 4),
			(7, '2021-02-02', 5, 5),
			(8, '2021-02-02', 5, 6),
			(9, '2021-02-02', 5, 7),
			(10, '2021-02-02', 5, 8);
SET IDENTITY_INSERT [Timesheet] OFF
GO
USE BasicTech_SQL_FinalTest
-- Q2 Show Employees whose Hourly Wages are less than Average Hourly Wages
SELECT e.FirstName
	, e.LastName
	, e.SSN
	, e.HourlyWage
FROM Employee e
WHERE e.HourlyWage < (
                    SELECT AVG(e.HourlyWage)
                    FROM Employee e
)
GO
-- Q3  Show Department have  >= 3 employee
SELECT 
	d.DepartmentId
	, d.DepartmentName
FROM Department d
WHERE d.DepartmentId IN (
                            SELECT e.DepartmentId
                            FROM Employee e
                            GROUP BY e.DepartmentId
                            HAVING COUNT(e.DepartmentId) >=3
)
--Q4 Show total working hours for each month of 2006
SELECT 
	MONTH(PayrollDate) AS 'Month'
	, SUM(WorkingHours) AS 'WorkingHours'
FROM Timesheet
WHERE YEAR(PayrollDate) = 2006
GROUP BY MONTH(PayrollDate)
ORDER BY 'Month' DESC;
GO 

--Q5 Delete managers who has HourlyWage > 100 
--DROP  TRIGGER trg_Delete_EmployeeManagerId322 
-- Use to service delete the manager
CREATE TRIGGER trg_Delete_EmployeeManagerId322 ON Employee
INSTEAD OF DELETE AS 
BEGIN 
SET NOCOUNT ON;
	UPDATE Employee  
	SET EmployeeManagerId = NULL
	WHERE EmployeeId IN (
							SELECT e.EmployeeId
							FROM Employee e
							WHERE e.EmployeeManagerId IN (	
															SELECT EmployeeId 
															FROM deleted
															)
						) 
	DELETE FROM Employee
	WHERE EmployeeId IN (
	SELECT EmployeeId
	FROM deleted
	);
END;
GO
-- Run TRIGGER before DELETE 
DELETE 
FROM Employee -- delete in table Employee
WHERE EmployeeManagerId IS NULL -- Only delete the managers
AND HourlyWage > 100; 
GO  
 