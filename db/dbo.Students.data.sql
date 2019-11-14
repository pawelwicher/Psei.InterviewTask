SET IDENTITY_INSERT [dbo].[Students] ON
INSERT INTO [dbo].[Students] ([Id], [FirstName], [LastName], [IndexNumber], [DepartmentId]) VALUES (1, N'Jan', N'Kowalski', 112233, 1)
INSERT INTO [dbo].[Students] ([Id], [FirstName], [LastName], [IndexNumber], [DepartmentId]) VALUES (3, N'Piotr', N'Nowak', 556677, 2)
INSERT INTO [dbo].[Students] ([Id], [FirstName], [LastName], [IndexNumber], [DepartmentId]) VALUES (7, N'Bob', N'Smith', 443322, 2)
INSERT INTO [dbo].[Students] ([Id], [FirstName], [LastName], [IndexNumber], [DepartmentId]) VALUES (8, N'John', N'Doe', 554411, 3)
SET IDENTITY_INSERT [dbo].[Students] OFF
