USE [master]
GO
/****** Object:  Database [Sales]    Script Date: 05/07/2022 07:49:15 م ******/
CREATE DATABASE [Sales]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sales', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Sales.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Sales_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Sales_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Sales] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sales].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sales] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sales] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sales] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sales] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sales] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sales] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sales] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sales] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sales] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sales] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sales] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sales] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sales] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sales] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sales] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sales] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sales] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sales] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sales] SET RECOVERY FULL 
GO
ALTER DATABASE [Sales] SET  MULTI_USER 
GO
ALTER DATABASE [Sales] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sales] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sales] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sales] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Sales] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Sales', N'ON'
GO
USE [Sales]
GO
/****** Object:  Table [dbo].[Areas]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[Colors]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[CustomerBridgeGrade]    Script Date: 05/07/2022 07:49:16 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerBridgeGrade](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[GradeId] [int] NULL,
	[ManEmpId] [int] NULL,
 CONSTRAINT [PK_CustomerBridgeGrade] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[CusWork]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[EmpList]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[Grades]    Script Date: 05/07/2022 07:49:16 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Grades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [varchar](max) NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_Grades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ManEmp]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[Products]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[Scheduale]    Script Date: 05/07/2022 07:49:16 م ******/
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
 CONSTRAINT [PK_Scheduale] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Specials]    Script Date: 05/07/2022 07:49:16 م ******/
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
/****** Object:  Table [dbo].[Types]    Script Date: 05/07/2022 07:49:16 م ******/
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
USE [master]
GO
ALTER DATABASE [Sales] SET  READ_WRITE 
GO
