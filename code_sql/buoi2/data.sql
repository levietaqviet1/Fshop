USE [FSOFTCompany]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DeptNo], [DeptName], [Note]) VALUES (1, N'fpt', NULL)
INSERT [dbo].[Department] ([DeptNo], [DeptName], [Note]) VALUES (2, N'rmit', NULL)
INSERT [dbo].[Department] ([DeptNo], [DeptName], [Note]) VALUES (3, N'congnghiep', NULL)
INSERT [dbo].[Department] ([DeptNo], [DeptName], [Note]) VALUES (4, N'xuly', NULL)
INSERT [dbo].[Department] ([DeptNo], [DeptName], [Note]) VALUES (5, N'quytrinh', NULL)
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
INSERT [dbo].[Employee] ([EmpNo], [EmpName], [BirthDay], [DeptNo], [MgrNo], [StartDate], [Salary], [Level], [Status], [Note], [Email]) VALUES (N'd22', N'd', NULL, NULL, 0, NULL, 2.0000, 1, 0, NULL, N'N@gmail.com')
INSERT [dbo].[Employee] ([EmpNo], [EmpName], [BirthDay], [DeptNo], [MgrNo], [StartDate], [Salary], [Level], [Status], [Note], [Email]) VALUES (N'd23', N'd', NULL, NULL, 0, NULL, 5.0000, 2, 0, NULL, N'le vier2@gmail.com')
INSERT [dbo].[Employee] ([EmpNo], [EmpName], [BirthDay], [DeptNo], [MgrNo], [StartDate], [Salary], [Level], [Status], [Note], [Email]) VALUES (N'd24', N'd', NULL, NULL, 0, NULL, 4.0000, 3, 0, NULL, N'B@gmail.com')
INSERT [dbo].[Employee] ([EmpNo], [EmpName], [BirthDay], [DeptNo], [MgrNo], [StartDate], [Salary], [Level], [Status], [Note], [Email]) VALUES (N'd25', N'd', NULL, NULL, 0, NULL, 6.0000, 5, 0, NULL, N'le vier21@gmail.com')
INSERT [dbo].[Employee] ([EmpNo], [EmpName], [BirthDay], [DeptNo], [MgrNo], [StartDate], [Salary], [Level], [Status], [Note], [Email]) VALUES (N'd26', N'd', NULL, NULL, 0, NULL, 1.0000, 4, 0, NULL, N'A@gmail.com')
GO
INSERT [dbo].[Emp_skill] ([SkillNo], [EmpNo], [SkillLevel], [RegDate]) VALUES (1, N'd22', 2, CAST(N'2022-01-12' AS Date))
INSERT [dbo].[Emp_skill] ([SkillNo], [EmpNo], [SkillLevel], [RegDate]) VALUES (2, N'd22', 3, CAST(N'2023-01-11' AS Date))
INSERT [dbo].[Emp_skill] ([SkillNo], [EmpNo], [SkillLevel], [RegDate]) VALUES (3, N'd23', 1, CAST(N'2023-01-11' AS Date))
INSERT [dbo].[Emp_skill] ([SkillNo], [EmpNo], [SkillLevel], [RegDate]) VALUES (4, N'd24', 2, CAST(N'2023-01-11' AS Date))
INSERT [dbo].[Emp_skill] ([SkillNo], [EmpNo], [SkillLevel], [RegDate]) VALUES (5, N'd22', 3, CAST(N'2023-01-11' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Skill] ON 

INSERT [dbo].[Skill] ([SkillNo], [SkillName], [Note]) VALUES (1, N'java', NULL)
INSERT [dbo].[Skill] ([SkillNo], [SkillName], [Note]) VALUES (2, N'.Net', NULL)
INSERT [dbo].[Skill] ([SkillNo], [SkillName], [Note]) VALUES (3, N'python', NULL)
INSERT [dbo].[Skill] ([SkillNo], [SkillName], [Note]) VALUES (4, N'vue', NULL)
INSERT [dbo].[Skill] ([SkillNo], [SkillName], [Note]) VALUES (5, N'js', NULL)
SET IDENTITY_INSERT [dbo].[Skill] OFF
GO
