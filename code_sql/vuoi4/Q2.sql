USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT name
FROM sys.databases
WHERE name = N'EmployeeManagement'
)
DROP DATABASE EmployeeManagement
GO

CREATE DATABASE EmployeeManagement
GO

USE EmployeeManagement
GO
CREATE TABLE [Department](
	[DepartmentNumber] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID()
	,[DepartmentName] NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE [dbo].[Skill](
	[SkillCode] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID()
	,[SkillName] NVARCHAR(50) NOT NULL,
)
GO
CREATE TABLE [Employee](
	[EmployeeNumber] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID()
	,[EmployeeName] NVARCHAR(50) NOT NULL
	,[DepartmentNumber] UNIQUEIDENTIFIER NOT NULL
	,CONSTRAINT [FK_Employee_Department] FOREIGN KEY (DepartmentNumber) REFERENCES Department(DepartmentNumber)
)
GO
CREATE TABLE [EmployeeSkill](
	[EmployeeNumber] UNIQUEIDENTIFIER
	,[SkillCode] UNIQUEIDENTIFIER
	,[DateRegistered] DATETIME NOT NULL
	,PRIMARY KEY ([EmployeeNumber], [SkillCode])
	,CONSTRAINT [FK_EmployeeSkill_Employee] FOREIGN KEY (EmployeeNumber) REFERENCES Employee(EmployeeNumber)
    ,CONSTRAINT [FK_EmployeeSkill_Skill] FOREIGN KEY (SkillCode) REFERENCES Skill(SkillCode)
)
-- 1
GO 
INSERT INTO [Skill] ([SkillCode], [SkillName]) 
	VALUES	(N'5ac46427-5307-4bb7-98bf-095ff3d7449e', N'Kiss')
			,(N'3c1c88de-b662-4e31-a831-5faeb90318ad', N'10d')
			,(N'0a5428c9-99b2-45a8-a234-61634b258fd4', N'.NET')
			,(N'eb08b69e-cd56-4f96-af0a-b56a0509a69c', N'LOL')
			,(N'87ba8c7f-76a7-4608-94de-d886f71f0123', N'Java');
GO
INSERT INTO [Department] ([DepartmentNumber], [DepartmentName]) 
	VALUES	(N'5b9cf174-96b8-4d6f-94ed-3c985238bb0d', N'C ROOM')
			,(N'ca0a0646-84ac-4c9e-b437-690a4088baff', N'Pyhon Room')
			,(N'48ce8e38-b54b-4124-a275-e3aebb06a1c0', N'Java Room');
GO
INSERT INTO [Employee] ([EmployeeNumber], [EmployeeName], [DepartmentNumber]) 
	VALUES	(N'56731315-f430-435c-a0f8-1677880c088e', N'nguyen b', N'5b9cf174-96b8-4d6f-94ed-3c985238bb0d')
			,(N'ffbed1a6-80bd-4eba-841d-68a94d93e2ff', N'nguyen d', N'ca0a0646-84ac-4c9e-b437-690a4088baff')
			,(N'869e25f9-0580-4a83-a362-d98364bf181d', N'nguyen e', N'ca0a0646-84ac-4c9e-b437-690a4088baff')
			,(N'ede9697c-0f34-4da6-bde0-db23d3e9c910', N'nguyen a', N'ca0a0646-84ac-4c9e-b437-690a4088baff')
			,(N'9be6a419-d0ce-4665-b732-f57a1a5b499b', N'nguyen c', N'48ce8e38-b54b-4124-a275-e3aebb06a1c0');
GO
INSERT INTO [EmployeeSkill] ([EmployeeNumber], [SkillCode], [DateRegistered]) 
	VALUES	(N'ffbed1a6-80bd-4eba-841d-68a94d93e2ff', N'3c1c88de-b662-4e31-a831-5faeb90318ad', CAST(N'2022-02-02T00:00:00.000' AS DateTime))
			,(N'ede9697c-0f34-4da6-bde0-db23d3e9c910', N'87ba8c7f-76a7-4608-94de-d886f71f0123', CAST(N'2021-04-05T00:00:00.000' AS DateTime))
			,(N'9be6a419-d0ce-4665-b732-f57a1a5b499b', N'87ba8c7f-76a7-4608-94de-d886f71f0123', CAST(N'2022-05-08T00:00:00.000' AS DateTime))
			,(N'9be6a419-d0ce-4665-b732-f57a1a5b499b', N'3c1c88de-b662-4e31-a831-5faeb90318ad', CAST(N'2022-05-08T00:00:00.000' AS DateTime));
GO
-- 2 Specify the names of the employees whore have skill of ‘Java’ – give >=2 solutions:
-- a, Use JOIN
SELECT	e.EmployeeName -- lấy tên nhân viên
		, s.SkillName  -- lấy tên kỹ năng
FROM EmployeeSkill es  -- lấy dữ liệu từ bảng trung gian EmployeeSkill
	JOIN Skill s ON es.SkillCode = s.SkillCode -- lấy thêm dữ liệu từ bảng Skill qua khóa SkillCode
	JOIN Employee e ON es.EmployeeNumber = e.EmployeeNumber -- lấy thêm dữ liệu từ bảng Employee qua khóa EmployeeNumber
WHERE s.SkillName = 'Java' -- Lấy ra những kỹ năng có tên Java
GO
-- b, Use sub query
SELECT e.EmployeeName  -- lấy tên nhân viên
FROM Employee e -- lấy dữ liệu từ bảng Employee
WHERE e.EmployeeNumber IN	( -- Lấy ra những nhân viên theo mã bảng truy vấn con
							SELECT es.EmployeeNumber -- lấy ra mã nhân viên
							FROM EmployeeSkill es -- lấy dữ liệu từ bảng EmployeeSkill
							WHERE es.SkillCode IN	( -- Lấy ra những mã ký năng theo mã bảng truy vấn con
													SELECT s.SkillCode -- lấy ra mã ký năng
													FROM Skill s -- lấy dữ liệu từ bảng Skill
													WHERE s.SkillName = 'Java' -- Lấy ra những kỹ năng có tên Java
													)
							)
GO
-- 3 Specify the departments which have >=3 employees, print out the list of departments’ employees right after each department.
SELECT d.DepartmentName -- lấy tên phòng ban
		,STRING_AGG( e.EmployeeName, ', ' ) AS 'departments employees' -- lấy ra 1 loạt tên các nhân viên 
FROM Department d -- lấy dữ liệu từ bảng Department
	JOIN Employee e ON d.DepartmentNumber = e.DepartmentNumber -- lấy thêm dữ liệu từ bảng Employee qua khóa DepartmentNumber
GROUP BY e.DepartmentNumber  
		,d.DepartmentName
HAVING COUNT(e.DepartmentNumber) >= 3 -- lấy ra những phong ban có từ 3 nhân viên trở lên
GO
-- 4 Use SUB-QUERY technique to list out the different employees (include employee number and employee names) who have multiple skills.
SELECT	e.EmployeeNumber
		,e.EmployeeName
FROM Employee e
WHERE e.EmployeeNumber IN	(
								SELECT es.EmployeeNumber 
								FROM EmployeeSkill es
								GROUP BY es.EmployeeNumber
								HAVING COUNT(es.EmployeeNumber) >1
							)
GO
-- 5, Create a view to show different employees (with following information: employee number and
-- employee name, department name) who have multiple skills.
GO
CREATE VIEW vwShowDifferentEmployees
AS
	SELECT	e.EmployeeNumber
			,e.EmployeeName
			,d.DepartmentName
	FROM Employee e 
		JOIN Department d ON e.DepartmentNumber = d.DepartmentNumber
	WHERE e.EmployeeNumber IN	(
									SELECT es.EmployeeNumber 
									FROM EmployeeSkill es
									GROUP BY es.EmployeeNumber
									HAVING COUNT(es.EmployeeNumber) >1
								)
GO

