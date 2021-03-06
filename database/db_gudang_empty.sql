USE [master]
GO
/****** Object:  Database [db_gudang]    Script Date: 13/12/2021 17.08.47 ******/
CREATE DATABASE [db_gudang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_gudang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQL2016\MSSQL\DATA\db_gudang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_gudang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQL2016\MSSQL\DATA\db_gudang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [db_gudang] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_gudang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_gudang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_gudang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_gudang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_gudang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_gudang] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_gudang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_gudang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_gudang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_gudang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_gudang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_gudang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_gudang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_gudang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_gudang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_gudang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_gudang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_gudang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_gudang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_gudang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_gudang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_gudang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_gudang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_gudang] SET RECOVERY FULL 
GO
ALTER DATABASE [db_gudang] SET  MULTI_USER 
GO
ALTER DATABASE [db_gudang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_gudang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_gudang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_gudang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_gudang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_gudang] SET QUERY_STORE = OFF
GO
USE [db_gudang]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [db_gudang]
GO
/****** Object:  Table [dbo].[tbl_gudang]    Script Date: 13/12/2021 17.08.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_gudang](
	[id_gudang] [int] IDENTITY(1,1) NOT NULL,
	[nama_gudang] [varchar](255) NOT NULL,
	[alamat] [varchar](255) NOT NULL,
	[create_date] [datetime] NOT NULL,
	[create_user] [varchar](255) NOT NULL,
 CONSTRAINT [PK_tbl_gudang] PRIMARY KEY CLUSTERED 
(
	[id_gudang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_inventory]    Script Date: 13/12/2021 17.08.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_inventory](
	[id_barang] [int] IDENTITY(1,1) NOT NULL,
	[id_gudang] [int] NOT NULL,
	[nama_barang] [varchar](255) NOT NULL,
	[jumlah] [int] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[create_user] [varchar](255) NOT NULL,
 CONSTRAINT [PK_tbl_inventory] PRIMARY KEY CLUSTERED 
(
	[id_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_index_gudang]    Script Date: 13/12/2021 17.08.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_index_gudang] as
SELECT
	g.id_gudang,
	g.nama_gudang,
	g.alamat,
	g.create_date,
	COUNT(i.id_barang) as total_barang
FROM
	tbl_gudang as g
INNER JOIN
	tbl_inventory as i
ON 
	g.id_gudang = i.id_gudang
GROUP BY 
	g.id_gudang,
	g.nama_gudang,
	g.alamat,
	g.create_date
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 13/12/2021 17.08.47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[username] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[gender] [varchar](6) NOT NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_gudang] ADD  CONSTRAINT [DF_tbl_gudang_create_date]  DEFAULT (getdate()) FOR [create_date]
GO
ALTER TABLE [dbo].[tbl_inventory] ADD  CONSTRAINT [DF_tbl_inventory_create_date]  DEFAULT (getdate()) FOR [create_date]
GO
USE [master]
GO
ALTER DATABASE [db_gudang] SET  READ_WRITE 
GO
