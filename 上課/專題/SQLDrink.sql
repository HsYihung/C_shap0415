USE [master]
GO
/****** Object:  Database [drinkDB]    Script Date: 2022/5/20 下午 05:53:05 ******/
CREATE DATABASE [drinkDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'drinkDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\drinkDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'drinkDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\drinkDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [drinkDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [drinkDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [drinkDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [drinkDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [drinkDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [drinkDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [drinkDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [drinkDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [drinkDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [drinkDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [drinkDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [drinkDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [drinkDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [drinkDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [drinkDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [drinkDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [drinkDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [drinkDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [drinkDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [drinkDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [drinkDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [drinkDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [drinkDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [drinkDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [drinkDB] SET RECOVERY FULL 
GO
ALTER DATABASE [drinkDB] SET  MULTI_USER 
GO
ALTER DATABASE [drinkDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [drinkDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [drinkDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [drinkDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [drinkDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [drinkDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'drinkDB', N'ON'
GO
ALTER DATABASE [drinkDB] SET QUERY_STORE = OFF
GO
USE [drinkDB]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 2022/5/20 下午 05:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[DrinkID] [int] IDENTITY(1000,1) NOT NULL,
	[ShopID] [int] NOT NULL,
	[DrinkName] [nvarchar](30) NULL,
	[Price] [int] NOT NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DrinkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feed]    Script Date: 2022/5/20 下午 05:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feed](
	[FeedID] [int] IDENTITY(1000,1) NOT NULL,
	[ShopID] [int] NOT NULL,
	[FeedName] [nvarchar](30) NULL,
	[Price] [int] NOT NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FeedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2022/5/20 下午 05:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(100001,1) NOT NULL,
	[ShopID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DrinkID] [int] NULL,
	[FeedID] [int] NULL,
	[Quantity] [int] NULL,
	[ice] [nvarchar](10) NULL,
	[surgar] [nvarchar](10) NULL,
	[OrderConfirm] [bit] NULL,
	[OrderMessage] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 2022/5/20 下午 05:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop](
	[ShopID] [int] IDENTITY(100,1) NOT NULL,
	[ShopName] [nvarchar](30) NOT NULL,
	[Account] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[ShopPhone] [nvarchar](30) NOT NULL,
	[enable] [bit] NOT NULL,
	[Address] [nvarchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2022/5/20 下午 05:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserID] [int] IDENTITY(10000,1) NOT NULL,
	[Account] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[PhoneNumber] [nvarchar](30) NOT NULL,
	[enable] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Drink] ON 

INSERT [dbo].[Drink] ([DrinkID], [ShopID], [DrinkName], [Price], [Stock]) VALUES (1000, 100, N'綠茶', 30, 100)
INSERT [dbo].[Drink] ([DrinkID], [ShopID], [DrinkName], [Price], [Stock]) VALUES (1001, 100, N'紅茶', 30, 110)
INSERT [dbo].[Drink] ([DrinkID], [ShopID], [DrinkName], [Price], [Stock]) VALUES (1002, 100, N'奶茶', 50, 90)
INSERT [dbo].[Drink] ([DrinkID], [ShopID], [DrinkName], [Price], [Stock]) VALUES (1003, 100, N'2', 2, 0)
SET IDENTITY_INSERT [dbo].[Drink] OFF
GO
SET IDENTITY_INSERT [dbo].[Feed] ON 

INSERT [dbo].[Feed] ([FeedID], [ShopID], [FeedName], [Price], [Stock]) VALUES (1000, 100, N'珍珠', 5, 60)
INSERT [dbo].[Feed] ([FeedID], [ShopID], [FeedName], [Price], [Stock]) VALUES (1001, 100, N'芋圓', 10, 60)
INSERT [dbo].[Feed] ([FeedID], [ShopID], [FeedName], [Price], [Stock]) VALUES (1003, 100, N'波霸', 5, 60)
INSERT [dbo].[Feed] ([FeedID], [ShopID], [FeedName], [Price], [Stock]) VALUES (1004, 100, N'布丁', 15, 60)
SET IDENTITY_INSERT [dbo].[Feed] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID], [ShopID], [UserID], [OrderDate], [DrinkID], [FeedID], [Quantity], [ice], [surgar], [OrderConfirm], [OrderMessage]) VALUES (100025, 100, 10000, CAST(N'2022-05-20T16:07:06.617' AS DateTime), 1001, 1003, 1, N'正常', N'正常', 0, NULL)
INSERT [dbo].[Order] ([ID], [ShopID], [UserID], [OrderDate], [DrinkID], [FeedID], [Quantity], [ice], [surgar], [OrderConfirm], [OrderMessage]) VALUES (100026, 100, 10000, CAST(N'2022-05-20T16:07:06.620' AS DateTime), 1000, 1003, 1, N'正常', N'正常', 0, NULL)
INSERT [dbo].[Order] ([ID], [ShopID], [UserID], [OrderDate], [DrinkID], [FeedID], [Quantity], [ice], [surgar], [OrderConfirm], [OrderMessage]) VALUES (100027, 100, 10000, CAST(N'2022-05-20T16:07:06.620' AS DateTime), 1002, 1004, 1, N'正常', N'正常', 0, NULL)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Shop] ON 

INSERT [dbo].[Shop] ([ShopID], [ShopName], [Account], [Password], [ShopPhone], [enable], [Address]) VALUES (100, N'五十嵐', N'test123@123.com', N'test1234', N'0773745133', 1, N'高雄市苓雅區鼓山一路350號')
INSERT [dbo].[Shop] ([ShopID], [ShopName], [Account], [Password], [ShopPhone], [enable], [Address]) VALUES (101, N'麻古茶坊', N'test321@eee.com', N'test1234', N'0421157112', 1, N'高雄市鹽埕區鼓山一路300號')
SET IDENTITY_INSERT [dbo].[Shop] OFF
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON 

INSERT [dbo].[UserInfo] ([UserID], [Account], [Password], [Name], [PhoneNumber], [enable]) VALUES (10000, N'test1@test.com', N'test1234', N'王小明', N'0933221111', 1)
INSERT [dbo].[UserInfo] ([UserID], [Account], [Password], [Name], [PhoneNumber], [enable]) VALUES (10001, N'test2@test.com', N'test1234', N'陳大貓', N'0922113333', 1)
INSERT [dbo].[UserInfo] ([UserID], [Account], [Password], [Name], [PhoneNumber], [enable]) VALUES (10002, N'test3', N'321', N'11111', N'11111', 1)
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_OrderDate]  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT ((0)) FOR [OrderConfirm]
GO
ALTER TABLE [dbo].[Shop] ADD  CONSTRAINT [DF_MemEnable]  DEFAULT ((0)) FOR [enable]
GO
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF_UserEnable]  DEFAULT ((1)) FOR [enable]
GO
USE [master]
GO
ALTER DATABASE [drinkDB] SET  READ_WRITE 
GO
