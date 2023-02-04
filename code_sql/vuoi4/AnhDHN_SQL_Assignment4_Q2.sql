USE master;
GO

-- Drop the database if it already exists
IF EXISTS (
	SELECT	name
	FROM	sys.databases
	WHERE name = N'EmployeeManagement'
)
	DROP DATABASE EmployeeManagement;
GO

--Create Database EmployeeManagement
CREATE DATABASE EmployeeManagement;
GO
--Use Database EmployeeManagement
USE EmployeeManagement;
GO

-----------------------Question 2----------------------------

--1. Create the tables (with the most appropriate field/column constraints & types) and add at least 3
--records into each created table.
CREATE TABLE Department (
	DepartmentNumber	INT NOT NULL PRIMARY KEY,
	DepartmentName		NVARCHAR(100)
);
GO
CREATE	TABLE Employee (
	EmployeeNumber		INT NOT NULL PRIMARY KEY,
	EmployeeName		NVARCHAR(100),
	DepartmentNumber	INT NOT NULL
		FOREIGN KEY REFERENCES Department (DepartmentNumber)
);
GO
CREATE	TABLE Skill (
	SkillCode INT NOT NULL PRIMARY KEY,
	SkillName NVARCHAR(100)
);
GO
CREATE	TABLE EmployeeSkill (
	EmployeeNumber		INT NOT NULL,
	SkillCode			INT NOT NULL,
	DateRegistered		DATE,
	PRIMARY KEY (EmployeeNumber, SkillCode)
);
GO

-- Add 3 records into each created table

INSERT	INTO Department (DepartmentNumber, DepartmentName)
VALUES (1, 'Phong IT')
	,(2, 'Phong TESTER')
	,(3, 'Phong DATA');
GO
INSERT	INTO EmployeeSkill (EmployeeNumber, SkillCode, DateRegistered)
VALUES (3,1,'2019-08-15')
	   ,(1,2,'2020-03-12')
	   ,(3,3,'2018-04-04')
	   ,(2,3,'2020-05-12')
	   ,(2,1,'2018-06-04')

GO
INSERT	INTO Skill (SkillCode, SkillName)
VALUES (1, 'Java')
	,(2, 'Tester')
	,(3, 'System');
GO
INSERT	INTO Employee (EmployeeNumber, EmployeeName, DepartmentNumber)
VALUES (1,'Nguyen Van A',2)
	   ,(2,'Le Van B',3)
	   ,(3,'Tran Van C',1)
	   ,(4,'Le Van D',1)
	   ,(5,'Tran Van F',1)
GO

--2. Specify the names of the employees whore have skill of ‘Java’ – give >=2 solutions:
--a. Use JOIN selection

SELECT	e.EmployeeName AS 'Names of the employees whose have skill of ‘Java’'
FROM	Employee e
	JOIN EmployeeSkill es
		ON e.EmployeeNumber = es.EmployeeNumber
	JOIN Skill s
		ON es.SkillCode		= s.SkillCode
WHERE s.SkillName = 'Java';
GO

--b. Use sub query
SELECT	e.EmployeeName AS 'Names of the employees whose have skill of ‘Java’'
FROM	Employee e,
		EmployeeSkill es
WHERE e.EmployeeNumber	= es.EmployeeNumber
	AND es.SkillCode IN (
			SELECT s.SkillCode 
			FROM Skill s 
			WHERE s.SkillName = 'Java'
		);
GO

--3. Specify the departments which have >=3 employees, print out the list of departments’
--employees right after each department.
SELECT	d.DepartmentName,
		STRING_AGG( e.EmployeeName, ', ' ) AS 'Employees working in the same department'
FROM	Employee e
	INNER JOIN Department d
		ON e.DepartmentNumber = d.DepartmentNumber
GROUP BY d.DepartmentName,
		e.DepartmentNumber
HAVING COUNT( e.DepartmentNumber ) >= 3;
GO

--4. Use SUB-QUERY technique to list out the different employees (include employee number and
--employee names) who have multiple skills.

SELECT	e.EmployeeNumber,
		e.EmployeeName
FROM	Employee e
WHERE e.EmployeeNumber IN (
		SELECT	EmployeeNumber
		FROM	EmployeeSkill
		GROUP BY EmployeeNumber
		HAVING COUNT( EmployeeNumber ) > 1
	);
GO
--5. Create a view to show different employees (with following information: employee number and
--employee name, department name) who have multiple skills.

CREATE VIEW vwEmployees
AS
SELECT	e.EmployeeNumber,
		e.EmployeeName,
		d.DepartmentName
FROM	Employee e
	INNER JOIN Department d
		ON e.DepartmentNumber = d.DepartmentNumber
WHERE e.EmployeeNumber IN (
		SELECT	EmployeeNumber
		FROM	EmployeeSkill
		GROUP BY EmployeeNumber
		HAVING COUNT( EmployeeNumber ) > 1
	);
GO
SELECT * FROM vwEmployees