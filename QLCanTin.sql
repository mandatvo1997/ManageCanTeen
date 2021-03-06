USE [master]
GO
/****** Object:  Database [QuanLyCanTin]    Script Date: 08/17/2018 00:23:47 ******/
CREATE DATABASE [QuanLyCanTin] ON  PRIMARY 
( NAME = N'Login', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Login.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Login_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Login_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyCanTin] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyCanTin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyCanTin] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLyCanTin] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLyCanTin] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLyCanTin] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLyCanTin] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLyCanTin] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QuanLyCanTin] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyCanTin] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLyCanTin] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyCanTin] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLyCanTin] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLyCanTin] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLyCanTin] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLyCanTin] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLyCanTin] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLyCanTin] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanLyCanTin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLyCanTin] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLyCanTin] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLyCanTin] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLyCanTin] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLyCanTin] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLyCanTin] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLyCanTin] SET  READ_WRITE
GO
ALTER DATABASE [QuanLyCanTin] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanLyCanTin] SET  MULTI_USER
GO
ALTER DATABASE [QuanLyCanTin] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLyCanTin] SET DB_CHAINING OFF
GO
USE [QuanLyCanTin]
GO
/****** Object:  Table [dbo].[SellingInfo]    Script Date: 08/17/2018 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellingInfo](
	[MaPhieu] [nvarchar](50) NOT NULL,
	[FoodName] [nvarchar](50) NOT NULL,
	[SLFood] [int] NOT NULL,
	[DrinkName] [nvarchar](50) NOT NULL,
	[SLDrink] [int] NOT NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK_SellInfo] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SellingInfo] ([MaPhieu], [FoodName], [SLFood], [DrinkName], [SLDrink], [TongTien]) VALUES (N'003', N'Bún Riêu', 1, N'Trà Đào', 1, 25000)
/****** Object:  Table [dbo].[LoginInfo]    Script Date: 08/17/2018 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginInfo](
	[ID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoginInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoginInfo] ([ID], [Password]) VALUES (N'admin', N'123456')
INSERT [dbo].[LoginInfo] ([ID], [Password]) VALUES (N'admin2', N'2222')
INSERT [dbo].[LoginInfo] ([ID], [Password]) VALUES (N'admin3', N'1')
/****** Object:  Table [dbo].[FoodInfo]    Script Date: 08/17/2018 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodInfo](
	[FoodID] [nvarchar](50) NOT NULL,
	[FoodName] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_FoodInfo] PRIMARY KEY CLUSTERED 
(
	[FoodID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[FoodInfo] ([FoodID], [FoodName], [DonGia]) VALUES (N'BB', N'Bun Bo', 20000)
INSERT [dbo].[FoodInfo] ([FoodID], [FoodName], [DonGia]) VALUES (N'BR', N'Bun Rieu', 15000)
INSERT [dbo].[FoodInfo] ([FoodID], [FoodName], [DonGia]) VALUES (N'CS', N'Com Suon', 20000)
INSERT [dbo].[FoodInfo] ([FoodID], [FoodName], [DonGia]) VALUES (N'MG', N'Mi Goi', 15000)
INSERT [dbo].[FoodInfo] ([FoodID], [FoodName], [DonGia]) VALUES (N'Ph', N'Pho', 30000)
/****** Object:  Table [dbo].[DrinkInfo]    Script Date: 08/17/2018 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrinkInfo](
	[DrinkID] [nvarchar](50) NOT NULL,
	[DrinkName] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_DrinkInfo] PRIMARY KEY CLUSTERED 
(
	[DrinkID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DrinkInfo] ([DrinkID], [DrinkName], [DonGia]) VALUES (N'CF', N' Ca Phe', 10000)
INSERT [dbo].[DrinkInfo] ([DrinkID], [DrinkName], [DonGia]) VALUES (N'NN', N'Nuoc Ngot', 10000)
INSERT [dbo].[DrinkInfo] ([DrinkID], [DrinkName], [DonGia]) VALUES (N'SDN', N'Sua Dau Nanh', 10000)
INSERT [dbo].[DrinkInfo] ([DrinkID], [DrinkName], [DonGia]) VALUES (N'TD', N'Tra Dao', 10000)
INSERT [dbo].[DrinkInfo] ([DrinkID], [DrinkName], [DonGia]) VALUES (N'TS', N'Tra Sua', 10000)
