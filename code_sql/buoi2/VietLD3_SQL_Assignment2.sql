USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT name
FROM sys.databases
WHERE name = N'FSOFTCompany'
)
DROP DATABASE FSOFTCompany
GO

CREATE DATABASE FSOFTCompany
GO
USE [FSOFTCompany]
GO
CREATE TABLE [Department](
	[DeptNo] INT IDENTITY(1,1) PRIMARY KEY
	,[DeptName] NVARCHAR(50) NOT NULL
	,[Note] NVARCHAR(MAX) NULL
 );
GO
CREATE TABLE [Skill](
	[SkillNo] INT IDENTITY(1,1) PRIMARY KEY
	,[SkillName] NVARCHAR(50) NOT NULL
	,[Note] NVARCHAR(MAX) NULL
);
GO
CREATE TABLE [Employee](
	[EmpNo] NVARCHAR(50) PRIMARY KEY
	,[EmpName] NVARCHAR(50) NULL
	,[BirthDay] DATETIME NOT NULL
	,[DeptNo] INT NOT NULL
	,[MgrNo] INT NOT NULL
	,[StartDate] DATE NULL
	,[Salary] MONEY NULL
	,[Level] TINYINT  NULL  CHECK(Level BETWEEN 1 AND 7)
	,[Status] TINYINT  NULL CHECK(Status BETWEEN 0 AND 2)
	,[Note] NVARCHAR(MAX) NULL
);
GO
CREATE TABLE [EmployeeSkill](
	[SkillNo] INT NOT NULL
	,[EmpNo] NVARCHAR(50) NOT NULL
	,[SkillLevel] TINYINT NOT NULL CHECK(SkillLevel BETWEEN 1 AND 3)
	,[RegDate] DATETIME  NULL DEFAULT GETDATE()
	,[Description] NVARCHAR(MAX) NULL
	,PRIMARY KEY (SkillNo, EmpNo)
    ,CONSTRAINT [FK_EmployeeSkill_Skill] FOREIGN KEY (SkillNo) REFERENCES Skill(SkillNo)
    ,CONSTRAINT [FK_EmployeeSkill_Employee] FOREIGN KEY (EmpNo) REFERENCES Employee(EmpNo)
);
GO 
/* Q2 */
ALTER TABLE EMPLOYEE
ADD Email NVARCHAR(100) NOT NULL UNIQUE;
GO 
ALTER TABLE EMPLOYEE add constraint df1 default  '0' for MgrNo;
ALTER TABLE EMPLOYEE add constraint df2 default  0 for [Status];
/* Q3 */
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DeptNo])
REFERENCES [dbo].[Department] ([DeptNo])

ALTER TABLE [EmployeeSkill] DROP COLUMN [Description]
GO
/* Q4  */
SET IDENTITY_INSERT [dbo].[Department] ON 
INSERT [Department] ([DeptNo], [DeptName], [Note]) 
VALUES	(1, N'fpt', NULL),
		(2, N'rmit', NULL),
		(3, N'congnghiep', NULL),
		(4, N'xuly', NULL),
		(5, N'quytrinh', NULL); 
GO
SET IDENTITY_INSERT [dbo].[Department] OFF 
GO
INSERT [Employee] ([EmpNo], [EmpName], [BirthDay], [DeptNo], [StartDate], [Salary], [Level], [Note], [Email])
VALUES (N'd22', N'd', CAST(N'2022-02-02T00:00:00.000' AS DateTime), 2, NULL, NULL, 4, NULL, 'N@gmail.com'),
		(N'd23', N'd', CAST(N'2022-02-02T00:00:00.000' AS DateTime), 1, NULL, NULL, 7, NULL, 'le vier2@gmail.com'),
		(N'd24', N'd', CAST(N'2022-02-02T00:00:00.000' AS DateTime), 3, NULL, NULL, 1, NULL, 'B@gmail.com'),
		(N'd25', N'd', CAST(N'2022-02-02T00:00:00.000' AS DateTime), 2, NULL, NULL, 2, NULL, 'le vier21@gmail.com'),
		(N'd26', N'd', CAST(N'2022-02-02T00:00:00.000' AS DateTime), 1, NULL, NULL, 3, NULL, 'A@gmail.com');
GO
SET IDENTITY_INSERT [dbo].[Skill] ON 
INSERT [Skill] ([SkillNo], [SkillName], [Note]) 
VALUES	(1, N'java', NULL),
		(2, N'.Net', NULL),
		(3, N'python', NULL),
		(4, N'vue', NULL),
		(5, N'js', NULL);
SET IDENTITY_INSERT [dbo].[Skill] OFF
GO
INSERT [EmployeeSkill] ([SkillNo], [EmpNo], [SkillLevel], [RegDate]) 
VALUES	(1, N'd22', 2, CAST(N'2022-01-12' AS Date)),
		(2, N'd22', 3, CAST(N'2023-01-11' AS Date)),
		(3, N'd23', 1, CAST(N'2023-01-11' AS Date)),
		(4, N'd24', 2, CAST(N'2023-01-11' AS Date)),
		(5, N'd22', 3, CAST(N'2023-01-11' AS Date));
GO


CREATE VIEW vwEMPLOYEETRACKING
AS
	SELECT EmpNo, [EmpName], [Level]
	FROM Employee
	WHERE [Level] >= 3 AND [Level] <= 5
