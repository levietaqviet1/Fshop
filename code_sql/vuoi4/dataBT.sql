USE [EmployeeManagement]
GO
INSERT [dbo].[Skill] ([SkillCode], [SkillName]) VALUES (N'5ac46427-5307-4bb7-98bf-095ff3d7449e', N'Kiss')
INSERT [dbo].[Skill] ([SkillCode], [SkillName]) VALUES (N'3c1c88de-b662-4e31-a831-5faeb90318ad', N'10d')
INSERT [dbo].[Skill] ([SkillCode], [SkillName]) VALUES (N'0a5428c9-99b2-45a8-a234-61634b258fd4', N'.NET')
INSERT [dbo].[Skill] ([SkillCode], [SkillName]) VALUES (N'eb08b69e-cd56-4f96-af0a-b56a0509a69c', N'LOL')
INSERT [dbo].[Skill] ([SkillCode], [SkillName]) VALUES (N'87ba8c7f-76a7-4608-94de-d886f71f0123', N'Java')
GO
INSERT [dbo].[Employee] ([EmployeeNumber], [EmployeeName], [DepartmentNumber]) VALUES (N'56731315-f430-435c-a0f8-1677880c088e', N'nguyen b', N'5b9cf174-96b8-4d6f-94ed-3c985238bb0d')
INSERT [dbo].[Employee] ([EmployeeNumber], [EmployeeName], [DepartmentNumber]) VALUES (N'ffbed1a6-80bd-4eba-841d-68a94d93e2ff', N'nguyen d', N'ca0a0646-84ac-4c9e-b437-690a4088baff')
INSERT [dbo].[Employee] ([EmployeeNumber], [EmployeeName], [DepartmentNumber]) VALUES (N'869e25f9-0580-4a83-a362-d98364bf181d', N'nguyen e', N'ca0a0646-84ac-4c9e-b437-690a4088baff')
INSERT [dbo].[Employee] ([EmployeeNumber], [EmployeeName], [DepartmentNumber]) VALUES (N'ede9697c-0f34-4da6-bde0-db23d3e9c910', N'nguyen a', N'5b9cf174-96b8-4d6f-94ed-3c985238bb0d')
INSERT [dbo].[Employee] ([EmployeeNumber], [EmployeeName], [DepartmentNumber]) VALUES (N'9be6a419-d0ce-4665-b732-f57a1a5b499b', N'nguyen c', N'48ce8e38-b54b-4124-a275-e3aebb06a1c0')
GO
INSERT [dbo].[EmployeeSkill] ([EmployeeNumber], [SkillCode], [DateRegistered]) VALUES (N'ffbed1a6-80bd-4eba-841d-68a94d93e2ff', N'3c1c88de-b662-4e31-a831-5faeb90318ad', CAST(N'2022-02-02T00:00:00.000' AS DateTime))
INSERT [dbo].[EmployeeSkill] ([EmployeeNumber], [SkillCode], [DateRegistered]) VALUES (N'ede9697c-0f34-4da6-bde0-db23d3e9c910', N'0a5428c9-99b2-45a8-a234-61634b258fd4', CAST(N'2021-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[EmployeeSkill] ([EmployeeNumber], [SkillCode], [DateRegistered]) VALUES (N'9be6a419-d0ce-4665-b732-f57a1a5b499b', N'87ba8c7f-76a7-4608-94de-d886f71f0123', CAST(N'2022-05-08T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName]) VALUES (N'5b9cf174-96b8-4d6f-94ed-3c985238bb0d', N'C ROOM')
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName]) VALUES (N'ca0a0646-84ac-4c9e-b437-690a4088baff', N'Pyhon Room')
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName]) VALUES (N'48ce8e38-b54b-4124-a275-e3aebb06a1c0', N'Java Room')
GO
