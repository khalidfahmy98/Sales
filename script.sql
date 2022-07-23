USE [Sales]
GO
/****** Object:  Table [dbo].[Areas]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Areas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Area] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Color] [varchar](max) NULL,
	[Hexa] [varchar](max) NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerBridgeGrade]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerBridgeGrade](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[GradeId] [int] NULL,
	[ManEmpId] [int] NULL,
	[Status] [int] NULL CONSTRAINT [DF_CustomerBridgeGrade_Status]  DEFAULT ((0)),
	[Leader] [int] NULL,
 CONSTRAINT [PK_CustomerBridgeGrade] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[Phone] [varchar](max) NULL,
	[MobileP] [varchar](max) NULL,
	[MobileS] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[Lang] [varchar](max) NULL,
	[Lat] [varchar](max) NULL,
	[NearestPharmacyP] [varchar](max) NULL,
	[NearestPharmacyS] [varchar](max) NULL,
	[TypeId] [int] NULL,
	[SpecialId] [int] NULL,
	[Comment] [varchar](max) NULL,
	[AreaId] [int] NULL,
	[ManEmpId] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CusWork]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CusWork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Day] [int] NULL,
	[Time] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [PK_CusWork] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpList]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[CustomerId] [int] NULL,
	[Status] [int] NULL CONSTRAINT [DF_EmpList_Status]  DEFAULT ((0)),
 CONSTRAINT [PK_EmpList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Grades]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Grades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [varchar](max) NULL,
	[Quote] [int] NULL,
 CONSTRAINT [PK_Grades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ManEmp]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ManEmp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[Username] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[NationalId] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[Phone] [int] NULL,
	[Password] [varchar](max) NULL,
	[Lead] [int] NULL CONSTRAINT [DF_ManEmp_Lead]  DEFAULT ((1)),
	[Rule] [int] NULL CONSTRAINT [DF_ManEmp_Rule]  DEFAULT ((0)),
	[Status] [int] NULL CONSTRAINT [DF_ManEmp_Status]  DEFAULT ((0)),
 CONSTRAINT [PK_ManEmp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Scheduale]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scheduale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManEmpId] [int] NULL,
	[CustomerId] [int] NULL,
	[Month] [int] NULL,
	[VisitDate] [date] NULL,
	[Leader] [int] NULL CONSTRAINT [DF_Scheduale_Leader]  DEFAULT ((1)),
	[Status] [int] NULL CONSTRAINT [DF_Scheduale_Status]  DEFAULT ((0)),
 CONSTRAINT [PK_Scheduale] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Specials]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Specials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_Specials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Types]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Types](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](max) NULL,
	[NoVisits] [int] NULL CONSTRAINT [DF_Types_NoVisits]  DEFAULT ((0)),
	[ColorId] [int] NULL,
 CONSTRAINT [PK_Types] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vacations]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vacations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VacationTypeId] [int] NULL,
	[FromDate] [date] NULL,
	[ToDate] [date] NULL,
	[Deputy] [varchar](max) NULL,
	[Reason] [varchar](max) NULL,
	[RemoveId] [int] NULL,
	[EmployeeId] [int] NULL,
	[Status] [int] NULL CONSTRAINT [DF_Vacations_Status]  DEFAULT ((0)),
	[Leader] [int] NULL,
 CONSTRAINT [PK_Vacations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VacationTypes]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VacationTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
 CONSTRAINT [PK_VacationTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VisitReports]    Script Date: 23/07/2022 09:08:44 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VisitReports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlanId] [int] NULL,
	[Report] [varchar](max) NULL,
 CONSTRAINT [PK_VisitReports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CustomerBridgeGrade]  WITH CHECK ADD  CONSTRAINT [FK_CustomerBridgeGrade_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[CustomerBridgeGrade] CHECK CONSTRAINT [FK_CustomerBridgeGrade_Customers]
GO
ALTER TABLE [dbo].[CustomerBridgeGrade]  WITH CHECK ADD  CONSTRAINT [FK_CustomerBridgeGrade_Grades] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grades] ([Id])
GO
ALTER TABLE [dbo].[CustomerBridgeGrade] CHECK CONSTRAINT [FK_CustomerBridgeGrade_Grades]
GO
ALTER TABLE [dbo].[CustomerBridgeGrade]  WITH CHECK ADD  CONSTRAINT [FK_CustomerBridgeGrade_ManEmp] FOREIGN KEY([ManEmpId])
REFERENCES [dbo].[ManEmp] ([Id])
GO
ALTER TABLE [dbo].[CustomerBridgeGrade] CHECK CONSTRAINT [FK_CustomerBridgeGrade_ManEmp]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Areas] FOREIGN KEY([AreaId])
REFERENCES [dbo].[Areas] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Areas]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_ManEmp] FOREIGN KEY([ManEmpId])
REFERENCES [dbo].[ManEmp] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_ManEmp]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Specials] FOREIGN KEY([SpecialId])
REFERENCES [dbo].[Specials] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Specials]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Types] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Types] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Types]
GO
ALTER TABLE [dbo].[CusWork]  WITH CHECK ADD  CONSTRAINT [FK_CusWork_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[CusWork] CHECK CONSTRAINT [FK_CusWork_Customers]
GO
ALTER TABLE [dbo].[ManEmp]  WITH CHECK ADD  CONSTRAINT [FK_ManEmp_ManEmp] FOREIGN KEY([Lead])
REFERENCES [dbo].[ManEmp] ([Id])
GO
ALTER TABLE [dbo].[ManEmp] CHECK CONSTRAINT [FK_ManEmp_ManEmp]
GO
ALTER TABLE [dbo].[Scheduale]  WITH CHECK ADD  CONSTRAINT [FK_Scheduale_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Scheduale] CHECK CONSTRAINT [FK_Scheduale_Customers]
GO
ALTER TABLE [dbo].[Scheduale]  WITH CHECK ADD  CONSTRAINT [FK_Scheduale_ManEmp] FOREIGN KEY([ManEmpId])
REFERENCES [dbo].[ManEmp] ([Id])
GO
ALTER TABLE [dbo].[Scheduale] CHECK CONSTRAINT [FK_Scheduale_ManEmp]
GO
ALTER TABLE [dbo].[Types]  WITH CHECK ADD  CONSTRAINT [FK_Types_Colors] FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Types] CHECK CONSTRAINT [FK_Types_Colors]
GO
ALTER TABLE [dbo].[Vacations]  WITH CHECK ADD  CONSTRAINT [FK_Vacations_ManEmp] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[ManEmp] ([Id])
GO
ALTER TABLE [dbo].[Vacations] CHECK CONSTRAINT [FK_Vacations_ManEmp]
GO
ALTER TABLE [dbo].[Vacations]  WITH CHECK ADD  CONSTRAINT [FK_Vacations_Types] FOREIGN KEY([RemoveId])
REFERENCES [dbo].[Types] ([Id])
GO
ALTER TABLE [dbo].[Vacations] CHECK CONSTRAINT [FK_Vacations_Types]
GO
ALTER TABLE [dbo].[Vacations]  WITH CHECK ADD  CONSTRAINT [FK_Vacations_VacationTypes] FOREIGN KEY([VacationTypeId])
REFERENCES [dbo].[VacationTypes] ([Id])
GO
ALTER TABLE [dbo].[Vacations] CHECK CONSTRAINT [FK_Vacations_VacationTypes]
GO
ALTER TABLE [dbo].[VisitReports]  WITH CHECK ADD  CONSTRAINT [FK_VisitReports_Scheduale] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Scheduale] ([Id])
GO
ALTER TABLE [dbo].[VisitReports] CHECK CONSTRAINT [FK_VisitReports_Scheduale]
GO
