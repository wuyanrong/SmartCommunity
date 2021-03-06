USE [master]
GO
/****** Object:  Database [SmartCommunity]    Script Date: 2013/9/15 23:41:33 ******/
CREATE DATABASE [SmartCommunity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SmartCommunity', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER12\MSSQL\DATA\SmartCommunity.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SmartCommunity_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER12\MSSQL\DATA\SmartCommunity_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SmartCommunity] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmartCommunity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmartCommunity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SmartCommunity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SmartCommunity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SmartCommunity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SmartCommunity] SET ARITHABORT OFF 
GO
ALTER DATABASE [SmartCommunity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SmartCommunity] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SmartCommunity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SmartCommunity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SmartCommunity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SmartCommunity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SmartCommunity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SmartCommunity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SmartCommunity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SmartCommunity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SmartCommunity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SmartCommunity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SmartCommunity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SmartCommunity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SmartCommunity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SmartCommunity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SmartCommunity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SmartCommunity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SmartCommunity] SET RECOVERY FULL 
GO
ALTER DATABASE [SmartCommunity] SET  MULTI_USER 
GO
ALTER DATABASE [SmartCommunity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SmartCommunity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SmartCommunity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SmartCommunity] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SmartCommunity', N'ON'
GO
USE [SmartCommunity]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2013/9/15 23:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MobPhone] [varchar](15) NULL,
	[NikeName] [nvarchar](50) NULL,
	[Email] [varchar](120) NOT NULL,
	[Passsword] [nvarchar](20) NOT NULL,
	[PotoPath] [nvarchar](100) NULL,
	[CreateTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Community]    Script Date: 2013/9/15 23:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Community](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[City] [nvarchar](10) NOT NULL,
	[Pinyin] [varchar](10) NOT NULL,
	[ServiceCategoryIds] [varchar](100) NOT NULL,
	[CreatTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Merchant]    Script Date: 2013/9/15 23:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Merchant](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[City] [nvarchar](10) NOT NULL,
	[CommunityIds] [nvarchar](10) NOT NULL,
	[ServiceCategoryName] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](180) NOT NULL,
	[MobPhone] [varchar](15) NOT NULL,
	[TelPhone] [varchar](15) NOT NULL,
	[ServiceRadius] [int] NULL,
	[IsDoorService] [bit] NULL,
	[ServiceDes] [nvarchar](100) NOT NULL,
	[CertificatePath] [nvarchar](100) NULL,
	[ShopPicPath] [nvarchar](100) NULL,
	[ServicePricePath] [nvarchar](100) NULL,
	[CreateTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServiceCategory]    Script Date: 2013/9/15 23:41:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[IconPath] [nvarchar](100) NOT NULL,
	[CreateTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF__Account__CreateT__145C0A3F]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Community] ADD  DEFAULT (getdate()) FOR [CreatTime]
GO
ALTER TABLE [dbo].[Merchant] ADD  DEFAULT ((500)) FOR [ServiceRadius]
GO
ALTER TABLE [dbo].[Merchant] ADD  DEFAULT ((0)) FOR [IsDoorService]
GO
ALTER TABLE [dbo].[Merchant] ADD  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[ServiceCategory] ADD  DEFAULT (getdate()) FOR [CreateTime]
GO
USE [master]
GO
ALTER DATABASE [SmartCommunity] SET  READ_WRITE 
GO
