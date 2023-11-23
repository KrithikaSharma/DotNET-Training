USE [G:\@@@@@@@@@@@@TOTALPROJECTS2017\TALENT MANAGEMENT SYSTEM\TALENT MANAGEMENT SYSTEM\TALENTMANEGEMENT\APP_DATA\TALENT.MDF]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 05-02-2021 09:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssignDept]    Script Date: 05-02-2021 09:04:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssignDept](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Emp] [nvarchar](50) NULL,
	[Dept] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssignToTrainer]    Script Date: 05-02-2021 09:04:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssignToTrainer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TrainerName] [varchar](50) NOT NULL,
	[ClassName] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 05-02-2021 09:04:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Dept] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 05-02-2021 09:04:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[DateOfBirth] [nvarchar](50) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[EMail] [varchar](50) NOT NULL,
	[Resume] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScheduleAndOrganize]    Script Date: 05-02-2021 09:04:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleAndOrganize](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Trainer] [nvarchar](50) NULL,
	[Subject] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[Timings] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 05-02-2021 09:04:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraineDetails]    Script Date: 05-02-2021 09:04:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraineDetails](
	[TraineeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[DateOfBirth] [nvarchar](50) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](13) NOT NULL,
	[Email] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([UserName], [Password], [Email]) VALUES (N'admin', N'123', N'kamal.coign@gmail.com')
SET IDENTITY_INSERT [dbo].[AssignDept] ON 

INSERT [dbo].[AssignDept] ([Id], [Emp], [Dept]) VALUES (3, N'kamal', N'Accounting')
SET IDENTITY_INSERT [dbo].[AssignDept] OFF
SET IDENTITY_INSERT [dbo].[AssignToTrainer] ON 

INSERT [dbo].[AssignToTrainer] ([Id], [TrainerName], [ClassName]) VALUES (1, N'ramu', N'.Net')
INSERT [dbo].[AssignToTrainer] ([Id], [TrainerName], [ClassName]) VALUES (2, N'ramu', N'C')
INSERT [dbo].[AssignToTrainer] ([Id], [TrainerName], [ClassName]) VALUES (3, N'ramu', N'C++')
INSERT [dbo].[AssignToTrainer] ([Id], [TrainerName], [ClassName]) VALUES (4, N'ramu', N'JAVA')
INSERT [dbo].[AssignToTrainer] ([Id], [TrainerName], [ClassName]) VALUES (5, N'yy', N'.Net')
SET IDENTITY_INSERT [dbo].[AssignToTrainer] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Dept]) VALUES (1, N'Accounting')
INSERT [dbo].[Departments] ([Id], [Dept]) VALUES (2, N'Sales')
INSERT [dbo].[Departments] ([Id], [Dept]) VALUES (3, N'Marketing')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[EmployeeDetails] ON 

INSERT [dbo].[EmployeeDetails] ([EmployeeId], [FirstName], [LastName], [UserName], [Password], [DateOfBirth], [Gender], [Address], [PhoneNumber], [EMail], [Resume]) VALUES (4, N'a', N'a', N'kamal', N'SE3MNRxKFt', N'17-11-2016', N'Male', N'knr', N'8801807167', N'kamal.coign@gmail.com', N'10428703_669743799813460_9072554765441575138_n.jpg')
SET IDENTITY_INSERT [dbo].[EmployeeDetails] OFF
SET IDENTITY_INSERT [dbo].[ScheduleAndOrganize] ON 

INSERT [dbo].[ScheduleAndOrganize] ([ID], [Trainer], [Subject], [Date], [Timings]) VALUES (2, N'ramu', N'.Net', N'09-11-2016', N'10:12 AM')
INSERT [dbo].[ScheduleAndOrganize] ([ID], [Trainer], [Subject], [Date], [Timings]) VALUES (3, N'ramu', N'C', N'22-11-2016', N'2:00 PM')
SET IDENTITY_INSERT [dbo].[ScheduleAndOrganize] OFF
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([ID], [SubjectName]) VALUES (7, N'.Net')
INSERT [dbo].[Subject] ([ID], [SubjectName]) VALUES (4, N'C')
INSERT [dbo].[Subject] ([ID], [SubjectName]) VALUES (5, N'C++')
INSERT [dbo].[Subject] ([ID], [SubjectName]) VALUES (6, N'JAVA')
SET IDENTITY_INSERT [dbo].[Subject] OFF
SET IDENTITY_INSERT [dbo].[TraineDetails] ON 

INSERT [dbo].[TraineDetails] ([TraineeId], [FirstName], [LastName], [UserName], [Password], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email]) VALUES (5, N'kkk', N'kkk', N'ramu', N'123', N'12-09-1989', N'Male', N'karimagar', N'9505513010', N'kamal4554@gmail.com')
INSERT [dbo].[TraineDetails] ([TraineeId], [FirstName], [LastName], [UserName], [Password], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email]) VALUES (6, N'k', N'k', N'yy', N'JGwpL1TubE', N'12-09-1989', N'Male', N'knr', N'9505513010', N'kamal.coign@gmail.com')
SET IDENTITY_INSERT [dbo].[TraineDetails] OFF
