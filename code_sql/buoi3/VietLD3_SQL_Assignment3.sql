USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT name
FROM sys.databases
WHERE name = N'MovieManagement'
)
DROP DATABASE MovieManagement
GO

CREATE DATABASE MovieManagement
GO
USE MovieManagement
GO 
CREATE TABLE [Actor](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL
	,[Name] NVARCHAR(50) NOT NULL
	,[Age] TINYINT NOT NULL
	,[AverageMovieSalary] DECIMAL NOT NULL
	,[Nationality] NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE [Movie](
	[Id] INT PRIMARY KEY IDENTITY(1,1)
	,[Name] NVARCHAR(50) NOT NULL
	,[Duration] FLOAT NOT NULL CHECK(Duration >= 1)
	,[Genre] TINYINT NOT NULL CHECK([Genre] BETWEEN 1 AND 8)
	,[Director] NVARCHAR(50) NOT NULL
	,[AmountOfMoney] MONEY NOT NULL
	,[Comments] NVARCHAR(200) NOT NULL
)
GO
CREATE TABLE ActedIn(
	IdMovie INT
	,IdActor INT
	,[Date] DATETIME NOT NULL
	,PRIMARY KEY (IdMovie, IdActor)
	,Comments NVARCHAR(200) NULL
	,CONSTRAINT [FK_ActedIn_Movie] FOREIGN KEY (IdMovie) REFERENCES Movie(Id)
    ,CONSTRAINT [FK_ActedIn_Actor] FOREIGN KEY (IdActor) REFERENCES Actor(Id)
)
GO
-- Q2 Add an ImageLink field to Movie table and make sure that the database will not allow the value for
--ImageLink to be inserted into a new row if that value has already been used in another row.
ALTER TABLE Movie
ADD ImageLink NVARCHAR(200) UNIQUE;
GO   
INSERT INTO [Actor] ([Name], [Age], [AverageMovieSalary], [Nationality]) 
	VALUES	 (N'viet', 22, 100.0000, N'VN'),
			 (N'dung', 20, 200.0000, N'US'),
			 (N'Tho', 21, 333.0000, N'UK'),
			 (N'Tien', 22, 412.0000, N'VN'),
			 (N'Vuong', 22, 214.0000, N'VN');
GO
INSERT INTO [Movie] ([Name], [Duration], [Genre], [Director], [AmountOfMoney], [comments], [ImageLink])
	VALUES	(N'7 viên ngọc rồng', 2, 1, N'viet', 100.0000, N'hay', N'abc.jpg'),
			(N'film A', 1, 3, N'gg', 2.0000, N'so', N'gfl.jpg'),
			(N'film B',2, 2, N'g', 200.0000, N'hay', N'bcd.jpg'),
			(N'film C', 3, 4, N'ha', 500.0000, N'ok', N'klp.jpg'),
			(N'film D', 4, 7, N'fa', 100000.0000, N'o', N'qwert.jpg');
GO
INSERT INTO [dbo].[ActedIn] (IdMovie, IdActor, [Date]) 
	VALUES	(1, 1, CAST(N'2022-12-12T00:00:00.000' AS DateTime)),
			(1, 2, CAST(N'2022-12-12T00:00:00.000' AS DateTime)),
			(1, 3, CAST(N'2022-12-12T00:00:00.000' AS DateTime)),
			(2, 1, CAST(N'2022-12-12T00:00:00.000' AS DateTime)),
			(2, 2, CAST(N'2022-12-13T00:00:00.000' AS DateTime));
-- Q3
--c Write a query to retrieve all the data in the Actor table for actors that are older than 50.
GO
SELECT a.Id
		,a.Name
		,a.Age
		,a.Nationality
		,a.AverageMovieSalary 
FROM Actor a
WHERE Age > 50
--d Write a query to retrieve all actor names and average salaries from ACTOR and sort the results by
--average salary.
GO
SELECT a.Name
		, a.AverageMovieSalary
FROM Actor a 
ORDER BY a.AverageMovieSalary ASC -- so sánh theo mức lương trung bình theo thứ tự tăng dần
--e Using an actor name from your table, write a query to retrieve the names of all the movies that actor
--has acted in.
GO
SELECT a.Name
		, m.Name AS Movie
FROM ActedIn ai 
	JOIN Actor a ON ai.IdActor= a.Id 
	JOIN Movie m ON m.Id= ai.IdMovie -- bảng ActedIn là bảng chứa dữ liệu diễn viên và film
WHERE a.Name = 'viet'
--f Write a view to retrieve the names of all the action movies that amount of actor be greater than 3
GO
CREATE VIEW vwViewFind
AS
	SELECT m.Name
    FROM ActedIn ai JOIN Actor a ON ai.IdActor= a.Id JOIN Movie m ON m.Id= ai.IdMovie
    WHERE ai.IdMovie IN (
        SELECT ai.IdMovie
        FROM ActedIn ai
        GROUP BY ai.IdMovie
        HAVING COUNT(ai.IdActor) >3
    ) 