
USE [master]
GO
drop DATABASE [Budget_WinApp_PRN391]

CREATE DATABASE [Budget_WinApp_PRN391]
GO
USE [Budget_WinApp_PRN391]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Budgets](
	[BudgetID] [int] IDENTITY(1,1) NOT NULL,
	[UnitPrice] [money] NULL,
	[Status] [nvarchar](200) NULL,
	[ExpenseID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BudgetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NULL,
	[Name] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](100) NULL,	
	[DateOfBith] [varchar](50) NULL,	
	[Password] [varchar](100) NULL,
	[BudgetID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseID] [int] IDENTITY(1,1) NOT NULL,
	[BudgetID] [int]  NULL,
	[ExpenseName] [nvarchar](100) NULL,
	[Description] [nvarchar](max) NULL,
	[ExpensePrice] [money] NULL,
	[Date] [varchar](50) NULL,
	[Invoice] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banks](    
	[BankID] [int] IDENTITY(1,1) NOT NULL,
	[BudgetID] [int]  NULL,
	[BankName] [nvarchar](100) NULL,
	[BankPrice] [money] NULL,
	[Status] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incomes](    
	[IncomeID] [int] IDENTITY(1,1) NOT NULL,
	[BudgetID] [int]  NULL,
	[IncomeName] [nvarchar](100) NULL,
	[DateStart] [varchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[IncomePrice] [money] NULL,
	[Status] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IncomeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Savings](    
	[SaveID] [int] IDENTITY(1,1) NOT NULL,
	[BankID] [int]  NULL,
	[SaveName] [nvarchar](100) NULL,
	[DateStart] [varchar](50) NULL,
	[Interest] [nvarchar](100) NULL,
	[Description] [nvarchar](max) NULL,
	[SavePrice] [money] NULL,
	[Status] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SaveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

GO
SET IDENTITY_INSERT [dbo].[Users] ON 
INSERT [dbo].[Users] ([UserID], [UserName], [Name],[Address], [Phone], [Email], [DateOfBith], [Password], [BudgetID]) VALUES (1, N'user1', N'Nguyễn Quang Vinh',N'499 Trần Khát Chân, Thanh Nhàn, Hai Bà Trưng, Hà Nội', N'0978612006', N'vinh1122k2@gmail.com',N'2002-02-11' , N'111111', 1)
INSERT [dbo].[Users] ([UserID], [UserName], [Name],[Address], [Phone], [Email], [DateOfBith], [Password], [BudgetID]) VALUES (2, N'user2',  N'Nguyễn Văn C', N'Bãi đỗ xe, 20 Phạm Hùng, Mỹ Đình 2, Từ Liêm, Hà Nộii', N'0981620906', N'nguyenvanb@gmail.com',N'2002-02-11', N'111111', 2)
INSERT [dbo].[Users] ([UserID], [UserName], [Name],[Address], [Phone], [Email], [DateOfBith], [Password], [BudgetID]) VALUES (3, N'user3', N'Nguyễn Văn B',N'18 Phạm Hùng, Mỹ Đình 2, Cầu Giấy, Hà Nội', N'0981620906', N'nguyenvanc@gmail.com',N'2002-02-11', N'111111', 3)
INSERT [dbo].[Users] ([UserID], [UserName], [Name],[Address], [Phone], [Email], [DateOfBith], [Password], [BudgetID]) VALUES (1, N'user1', N'Nguyễn Quang Vinh',N'499 Trần Khát Chân, Thanh Nhàn, Hai Bà Trưng, Hà Nội', N'0978612006', N'vinh1122k2@gmail.com',N'2002-02-11' , N'111111', 4)

SET IDENTITY_INSERT [dbo].[Users] OFF

GO
SET IDENTITY_INSERT [dbo].[Budgets] ON 
INSERT [dbo].[Budgets] ([BudgetID], [UnitPrice], [Status],[ExpenseID]) VALUES (1, 80000000,N'on',1)
INSERT [dbo].[Budgets] ([BudgetID], [UnitPrice], [Status],[ExpenseID]) VALUES (2, 30000000,N'on',2)
INSERT [dbo].[Budgets] ([BudgetID], [UnitPrice], [Status],[ExpenseID]) VALUES (3, 50000000,N'on',3)
SET IDENTITY_INSERT [dbo].[Budgets] OFF

GO
SET IDENTITY_INSERT [dbo].[Expenses] ON 
INSERT [dbo].[Expenses] ([ExpenseID], [BudgetID], [ExpenseName],[Description], [ExpensePrice], [Date], [Invoice]) VALUES (1,1, N'Tháng 1, 2',N'Siêu thị thực phẩm',23000000,N'2023-07-02',N'MHD111')
INSERT [dbo].[Expenses] ([ExpenseID], [BudgetID], [ExpenseName],[Description], [ExpensePrice], [Date], [Invoice]) VALUES (2,1, N'Tháng 1, 3',N'Siêu thị thực phẩm',23000000,N'2023-07-02',N'MHD111')
INSERT [dbo].[Expenses] ([ExpenseID], [BudgetID], [ExpenseName],[Description], [ExpensePrice], [Date], [Invoice]) VALUES (3,2, N'Tháng 1, 2',N'Siêu thị thực phẩm',23000000,N'2023-07-02',N'MHD111')
INSERT [dbo].[Expenses] ([ExpenseID], [BudgetID], [ExpenseName],[Description], [ExpensePrice], [Date], [Invoice]) VALUES (4,3, N'Tháng 1, 2',N'Siêu thị thực phẩm',23000000,N'2023-07-02',N'MHD111')
INSERT [dbo].[Expenses] ([ExpenseID], [BudgetID], [ExpenseName],[Description], [ExpensePrice], [Date], [Invoice]) VALUES (5,2, N'Tháng 1, 2',N'Siêu thị thực phẩm',23000000,N'2023-07-02',N'MHD111')
SET IDENTITY_INSERT [dbo].[Expenses] OFF

GO
SET IDENTITY_INSERT [dbo].[Banks] ON 
INSERT [dbo].[Banks] ([BankID], [BudgetID], [BankName],[BankPrice], [Status]) VALUES (1,1, N'Techcombank',300000000,N'on')
INSERT [dbo].[Banks] ([BankID], [BudgetID], [BankName],[BankPrice], [Status]) VALUES (2,2, N'Sacombank',200000000,N'on')
INSERT [dbo].[Banks] ([BankID], [BudgetID], [BankName],[BankPrice], [Status]) VALUES (3,1, N'Sacombank',200000000,N'on')
SET IDENTITY_INSERT [dbo].[Banks] OFF

GO
SET IDENTITY_INSERT [dbo].[Savings] ON 
INSERT [dbo].[Savings] ([SaveID], [BankID], [SaveName],[DateStart], [Interest], [Description], [SavePrice], [Status]) VALUES (1,1, N'Tiền Tiết kiệm',N'2023-01-02',N'8',N'Thời hạn 12 năm với lãi suất 8%/Tháng',2000000,N'on')
INSERT [dbo].[Savings] ([SaveID], [BankID], [SaveName],[DateStart], [Interest], [Description], [SavePrice], [Status]) VALUES (2,1, N'Tiền Tiết kiệm',N'2023-01-02',N'8',N'Thời hạn 12 năm với lãi suất 8%/Tháng',2000000,N'on')
INSERT [dbo].[Savings] ([SaveID], [BankID], [SaveName],[DateStart], [Interest], [Description], [SavePrice], [Status]) VALUES (3,2, N'Tiền Tiết kiệm',N'2023-01-02',N'8',N'Thời hạn 12 năm với lãi suất 8%/Tháng',2000000,N'on')
INSERT [dbo].[Savings] ([SaveID], [BankID], [SaveName],[DateStart], [Interest], [Description], [SavePrice], [Status]) VALUES (4,2, N'Tiền Tiết kiệm',N'2023-01-02',N'8',N'Thời hạn 12 năm với lãi suất 8%/Tháng',2000000,N'on')
INSERT [dbo].[Savings] ([SaveID], [BankID], [SaveName],[DateStart], [Interest], [Description], [SavePrice], [Status]) VALUES (5,3, N'Tiền Tiết kiệm',N'2023-01-02',N'8',N'Thời hạn 12 năm với lãi suất 8%/Tháng',2000000,N'on')
SET IDENTITY_INSERT [dbo].[Savings] OFF

GO
SET IDENTITY_INSERT [dbo].[Incomes] ON 
INSERT [dbo].[Incomes] ([IncomeID], [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (1,1, N'Đi làm thêm',N'2023-07-02',N'Đi làm tháng 6',5000000,N'on')
INSERT [dbo].[Incomes] ([IncomeID], [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (2,1, N'Tiền tiết kiệm',N'2023-01-02',N'Tiết kiệm hàng tháng',1000000,N'on')
INSERT [dbo].[Incomes] ([IncomeID], [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (3,1, N'Tiền thưởng',N'2023-07-02',N'Làm thêm tháng 6',2000000,N'on')
INSERT [dbo].[Incomes] ([IncomeID], [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (4,2, N'Đi làm thêm',N'2023-05-02',N'Làm thêm tháng 6',6000000,N'on')
INSERT [dbo].[Incomes] ([IncomeID], [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (5,1, N'Trúng thưởng',N'2023-05-02',N'Quay vé trúng thưởn',500000,N'on')
INSERT [dbo].[Incomes] ([IncomeID], [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (6,3, N'Đi làm thêm',N'2023-05-02',N'Làm thêm tháng 6',3000000,N'on')
INSERT [dbo].[Incomes] ([IncomeID], [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (7,2, N'Đi làm thêm',N'2023-05-02',N'Làm thêm tháng 6',3000000,N'on')
SET IDENTITY_INSERT [dbo].[Incomes] OFF

GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([BudgetID])
REFERENCES [dbo].[Budgets] ([BudgetID])
GO

GO
ALTER TABLE [dbo].[Savings]  WITH CHECK ADD FOREIGN KEY([BankID])
REFERENCES [dbo].[Banks] ([BankID])
GO

GO
ALTER TABLE [dbo].[Banks]  WITH CHECK ADD FOREIGN KEY([BudgetID])
REFERENCES [dbo].[Budgets] ([BudgetID])
GO

GO
ALTER TABLE [dbo].[Incomes]  WITH CHECK ADD FOREIGN KEY([BudgetID])
REFERENCES [dbo].[Budgets] ([BudgetID])
GO

GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD FOREIGN KEY([BudgetID])
REFERENCES [dbo].[Budgets] ([BudgetID])
GO

INSERT [dbo].[Incomes] ( [BudgetID], [IncomeName],[DateStart], [Description], [IncomePrice], [Status]) VALUES (4, N'Đi làm thêm',N'2023-07-02',N'Đi làm tháng 6',5000000,N'on')

SELECT * FROM Incomes where BudgetID= 3