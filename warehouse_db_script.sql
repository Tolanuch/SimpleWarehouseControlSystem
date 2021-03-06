USE [master]
GO
/****** Object:  Database [warehouse_db]    Script Date: 5/11/2016 12:33:02 PM ******/
CREATE DATABASE [warehouse_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'warehouse_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\warehouse_db.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'warehouse_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\warehouse_db_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [warehouse_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [warehouse_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [warehouse_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [warehouse_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [warehouse_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [warehouse_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [warehouse_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [warehouse_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [warehouse_db] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [warehouse_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [warehouse_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [warehouse_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [warehouse_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [warehouse_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [warehouse_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [warehouse_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [warehouse_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [warehouse_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [warehouse_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [warehouse_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [warehouse_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [warehouse_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [warehouse_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [warehouse_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [warehouse_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [warehouse_db] SET RECOVERY FULL 
GO
ALTER DATABASE [warehouse_db] SET  MULTI_USER 
GO
ALTER DATABASE [warehouse_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [warehouse_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [warehouse_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [warehouse_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'warehouse_db', N'ON'
GO
USE [warehouse_db]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 5/11/2016 12:33:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nchar](10) NOT NULL,
	[Name] [nchar](45) NOT NULL,
	[Garantee_expiry_date] [date] NOT NULL,
	[Type] [nchar](20) NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/11/2016 12:33:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Name] [nchar](30) NOT NULL,
	[Surname] [nchar](30) NOT NULL,
	[Address] [nchar](40) NOT NULL,
	[ArticleID] [int] NOT NULL,
	[Article_amount] [int] NOT NULL,
	[Delivery_way] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Articles] ADD  CONSTRAINT [DF_Articles_Amount]  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Articles] FOREIGN KEY([ArticleID])
REFERENCES [dbo].[Articles] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Articles]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'the expiry date of the guarantee.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articles', @level2type=N'COLUMN',@level2name=N'Garantee_expiry_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Type of the article' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articles', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Current amount. Default amount = 0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Articles', @level2type=N'COLUMN',@level2name=N'Amount'
GO
USE [master]
GO
ALTER DATABASE [warehouse_db] SET  READ_WRITE 
GO
