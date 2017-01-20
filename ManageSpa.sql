USE [master]
GO
/****** Object:  Database [ManageSpa]    Script Date: 20/01/2017 7:11:07 CH ******/
CREATE DATABASE [ManageSpa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManageSpa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ManageSpa.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ManageSpa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ManageSpa_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ManageSpa] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManageSpa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ManageSpa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ManageSpa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ManageSpa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ManageSpa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ManageSpa] SET ARITHABORT OFF 
GO
ALTER DATABASE [ManageSpa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ManageSpa] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ManageSpa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ManageSpa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ManageSpa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ManageSpa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ManageSpa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ManageSpa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ManageSpa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ManageSpa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ManageSpa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ManageSpa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ManageSpa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ManageSpa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ManageSpa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ManageSpa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ManageSpa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ManageSpa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ManageSpa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ManageSpa] SET  MULTI_USER 
GO
ALTER DATABASE [ManageSpa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ManageSpa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ManageSpa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ManageSpa] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ManageSpa', N'ON'
GO
USE [ManageSpa]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 20/01/2017 7:11:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHD] [nchar](5) NOT NULL,
	[MaDV] [nchar](5) NOT NULL,
	[ThoiGian] [datetime] NULL,
	[DonGia] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DatCho]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatCho](
	[MaDC] [nchar](5) NOT NULL,
	[MaGiuong] [nchar](5) NULL,
	[SDT] [nchar](11) NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
 CONSTRAINT [PK_DatCho] PRIMARY KEY CLUSTERED 
(
	[MaDC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [nchar](5) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[ThoiGianSuDung] [int] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiuongDat]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiuongDat](
	[MaGiuong] [nchar](5) NOT NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiuongSpa]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiuongSpa](
	[MaGiuong] [nchar](5) NOT NULL,
 CONSTRAINT [PK_GiuongSpa] PRIMARY KEY CLUSTERED 
(
	[MaGiuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](5) NOT NULL,
	[ThoiGian] [datetime] NULL,
	[TongTien] [int] NULL,
	[MaKH] [nchar](5) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](5) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](11) NULL,
	[SoLan] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[ID] [nchar](50) NOT NULL,
	[LoaiTK] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Luong]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[MaNV] [nchar](5) NOT NULL,
	[HeSoLuong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](5) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](11) NULL,
	[CMND] [nchar](20) NULL,
	[HinhNV] [nchar](400) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [nchar](50) NOT NULL,
	[Pass] [nchar](50) NULL,
	[MaNV] [nchar](5) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThoiGianDangNhap]    Script Date: 20/01/2017 7:11:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiGianDangNhap](
	[ID] [nchar](50) NOT NULL,
	[MaNV] [nchar](5) NULL,
	[ThoiGianDangNhap] [datetime] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_DichVu1] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_DichVu1]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon]
GO
ALTER TABLE [dbo].[DatCho]  WITH CHECK ADD  CONSTRAINT [FK_DatCho_GiuongSpa] FOREIGN KEY([MaGiuong])
REFERENCES [dbo].[GiuongSpa] ([MaGiuong])
GO
ALTER TABLE [dbo].[DatCho] CHECK CONSTRAINT [FK_DatCho_GiuongSpa]
GO
ALTER TABLE [dbo].[GiuongDat]  WITH CHECK ADD  CONSTRAINT [FK_GiuongDat_GiuongSpa] FOREIGN KEY([MaGiuong])
REFERENCES [dbo].[GiuongSpa] ([MaGiuong])
GO
ALTER TABLE [dbo].[GiuongDat] CHECK CONSTRAINT [FK_GiuongDat_GiuongSpa]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[LoaiTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_LoaiTaiKhoan_TaiKhoan] FOREIGN KEY([ID])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[LoaiTaiKhoan] CHECK CONSTRAINT [FK_LoaiTaiKhoan_TaiKhoan]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_NhanVien]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[ThoiGianDangNhap]  WITH CHECK ADD  CONSTRAINT [FK_ThoiGianDangNhap_TaiKhoan] FOREIGN KEY([ID])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[ThoiGianDangNhap] CHECK CONSTRAINT [FK_ThoiGianDangNhap_TaiKhoan]
GO
USE [master]
GO
ALTER DATABASE [ManageSpa] SET  READ_WRITE 
GO
