USE [master]
GO
/****** Object:  Database [ARB]    Script Date: 26.12.2022 01:12:39 ******/
CREATE DATABASE [ARB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ARB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ARB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ARB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ARB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ARB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ARB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ARB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ARB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ARB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ARB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ARB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ARB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ARB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ARB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ARB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ARB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ARB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ARB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ARB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ARB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ARB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ARB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ARB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ARB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ARB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ARB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ARB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ARB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ARB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ARB] SET  MULTI_USER 
GO
ALTER DATABASE [ARB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ARB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ARB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ARB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ARB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ARB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ARB', N'ON'
GO
ALTER DATABASE [ARB] SET QUERY_STORE = OFF
GO
USE [ARB]
GO
/****** Object:  Table [dbo].[Araclar]    Script Date: 26.12.2022 01:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Araclar](
	[AracNo] [int] IDENTITY(1,1) NOT NULL,
	[AracFiyat] [money] NULL,
	[AracAdet] [int] NULL,
	[AracMarka] [varchar](50) NULL,
	[AracModel] [varchar](50) NULL,
	[AracYil] [int] NULL,
	[AracOzellik] [varchar](50) NULL,
	[AracMotor] [varchar](50) NULL,
	[AracPaket] [varchar](50) NULL,
	[AracRenk] [varchar](50) NULL,
	[SubeNo] [int] NULL,
 CONSTRAINT [PK_Araclar] PRIMARY KEY CLUSTERED 
(
	[AracNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kayit]    Script Date: 26.12.2022 01:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kayit](
	[KullaniciAdi] [varchar](50) NOT NULL,
	[Sifre] [nchar](10) NULL,
	[Mail] [varchar](50) NULL,
	[Telefon] [varchar](50) NULL,
 CONSTRAINT [PK_Kayit_1] PRIMARY KEY CLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 26.12.2022 01:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriNo] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdSoyad] [varchar](50) NULL,
	[MusteriTelefon] [varchar](50) NULL,
	[MusteriYas] [int] NULL,
	[MusteriBakiye] [money] NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subeler]    Script Date: 26.12.2022 01:12:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subeler](
	[SubeNo] [int] IDENTITY(1,1) NOT NULL,
	[SubeAdi] [varchar](50) NULL,
	[CalisanSayisi] [int] NULL,
	[SubeCiro] [money] NULL,
	[MusteriNo] [int] NULL,
 CONSTRAINT [PK_Subeler] PRIMARY KEY CLUSTERED 
(
	[SubeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Araclar] ON 

INSERT [dbo].[Araclar] ([AracNo], [AracFiyat], [AracAdet], [AracMarka], [AracModel], [AracYil], [AracOzellik], [AracMotor], [AracPaket], [AracRenk], [SubeNo]) VALUES (1, 50000.0000, 50, N'range', N'2022', 2022, N'Klimalı', N'V', N'A', N'Beyaz', 2)
INSERT [dbo].[Araclar] ([AracNo], [AracFiyat], [AracAdet], [AracMarka], [AracModel], [AracYil], [AracOzellik], [AracMotor], [AracPaket], [AracRenk], [SubeNo]) VALUES (2, 50000.0000, 50, N'lamborgini', N'2021', 2022, N'Klimalı', N'W', N'A', N'siyah', 1)
INSERT [dbo].[Araclar] ([AracNo], [AracFiyat], [AracAdet], [AracMarka], [AracModel], [AracYil], [AracOzellik], [AracMotor], [AracPaket], [AracRenk], [SubeNo]) VALUES (3, 50000.0000, 50, N'lamborgini', N'2021', 2022, N'Klimalı', N'W', N'A', N'siyah', 1)
INSERT [dbo].[Araclar] ([AracNo], [AracFiyat], [AracAdet], [AracMarka], [AracModel], [AracYil], [AracOzellik], [AracMotor], [AracPaket], [AracRenk], [SubeNo]) VALUES (8, 50000.0000, 50, N'lamborgini', N'2021', 2022, N'Klimalı', N'W', N'A', N'siyah', 1)
SET IDENTITY_INSERT [dbo].[Araclar] OFF
GO
INSERT [dbo].[Kayit] ([KullaniciAdi], [Sifre], [Mail], [Telefon]) VALUES (N'aa', N'123       ', N'dfsdgfkds', N'(538) 456-7534')
GO
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAdSoyad], [MusteriTelefon], [MusteriYas], [MusteriBakiye]) VALUES (1, N'Fatma Sarı', N'(652) 365-4525', 30, 70000.0000)
INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAdSoyad], [MusteriTelefon], [MusteriYas], [MusteriBakiye]) VALUES (2, N'Mahmut Sarı', N'(985) 642-3512', 32, 70000.0000)
INSERT [dbo].[Musteriler] ([MusteriNo], [MusteriAdSoyad], [MusteriTelefon], [MusteriYas], [MusteriBakiye]) VALUES (8, N'Şeyma Alpaslan', N'(645) 865-3154', 34, 85000.0000)
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
GO
SET IDENTITY_INSERT [dbo].[Subeler] ON 

INSERT [dbo].[Subeler] ([SubeNo], [SubeAdi], [CalisanSayisi], [SubeCiro], [MusteriNo]) VALUES (1, N'Çankaya', 25, 2500.0000, 1)
INSERT [dbo].[Subeler] ([SubeNo], [SubeAdi], [CalisanSayisi], [SubeCiro], [MusteriNo]) VALUES (2, N'Üsküdar', 30, 2500.0000, 2)
INSERT [dbo].[Subeler] ([SubeNo], [SubeAdi], [CalisanSayisi], [SubeCiro], [MusteriNo]) VALUES (4, N'Pendik', 50, 50000.0000, 1)
INSERT [dbo].[Subeler] ([SubeNo], [SubeAdi], [CalisanSayisi], [SubeCiro], [MusteriNo]) VALUES (5, N'Ataşehir', 60, 30000.0000, 2)
SET IDENTITY_INSERT [dbo].[Subeler] OFF
GO
ALTER TABLE [dbo].[Araclar]  WITH CHECK ADD  CONSTRAINT [FK_Araclar_Subeler] FOREIGN KEY([SubeNo])
REFERENCES [dbo].[Subeler] ([SubeNo])
GO
ALTER TABLE [dbo].[Araclar] CHECK CONSTRAINT [FK_Araclar_Subeler]
GO
ALTER TABLE [dbo].[Subeler]  WITH CHECK ADD  CONSTRAINT [FK_Subeler_Musteriler] FOREIGN KEY([MusteriNo])
REFERENCES [dbo].[Musteriler] ([MusteriNo])
GO
ALTER TABLE [dbo].[Subeler] CHECK CONSTRAINT [FK_Subeler_Musteriler]
GO
USE [master]
GO
ALTER DATABASE [ARB] SET  READ_WRITE 
GO
