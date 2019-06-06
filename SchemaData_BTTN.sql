USE [master]
GO
/****** Object:  Database [QLyVVP]    Script Date: 6/6/2019 12:33:13 PM ******/
CREATE DATABASE [QLyVVP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLyVVP', FILENAME = N'E:\ĐH\Đồ án tốt nghiệp\Database\QLyVVP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLyVVP_log', FILENAME = N'E:\ĐH\Đồ án tốt nghiệp\Database\QLyVVP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLyVVP] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLyVVP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLyVVP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLyVVP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLyVVP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLyVVP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLyVVP] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLyVVP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLyVVP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLyVVP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLyVVP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLyVVP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLyVVP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLyVVP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLyVVP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLyVVP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLyVVP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLyVVP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLyVVP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLyVVP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLyVVP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLyVVP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLyVVP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLyVVP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLyVVP] SET RECOVERY FULL 
GO
ALTER DATABASE [QLyVVP] SET  MULTI_USER 
GO
ALTER DATABASE [QLyVVP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLyVVP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLyVVP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLyVVP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLyVVP] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLyVVP', N'ON'
GO
ALTER DATABASE [QLyVVP] SET QUERY_STORE = OFF
GO
USE [QLyVVP]
GO
/****** Object:  Table [dbo].[PHIEUDATHANG]    Script Date: 6/6/2019 12:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDATHANG](
	[Idpd] [varchar](12) NOT NULL,
	[Idsp] [varchar](10) NOT NULL,
	[Idncc] [varchar](10) NULL,
	[Tennv] [varchar](10) NULL,
	[Tensp] [nvarchar](30) NULL,
	[Dvt] [nvarchar](10) NULL,
	[Soluongdat] [int] NULL,
	[Thoigian] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_PHIEUDATHANG] PRIMARY KEY CLUSTERED 
(
	[Idpd] ASC,
	[Idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Idphieudat]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Idphieudat]
AS
SELECT DISTINCT Idpd
FROM            dbo.PHIEUDATHANG
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[Idpn] [varchar](12) NOT NULL,
	[Idsp] [varchar](10) NOT NULL,
	[Idncc] [varchar](10) NULL,
	[Tenngdung] [nvarchar](30) NULL,
	[Nguoigiao] [nvarchar](30) NULL,
	[Tensp] [nvarchar](30) NULL,
	[Dvt] [nvarchar](10) NULL,
	[Soluonggiao] [int] NULL,
	[Soluongnhap] [int] NULL,
	[Gianhap] [int] NULL,
	[Thanhtien] [int] NULL,
	[Thoigian] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[Idpn] ASC,
	[Idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Idpn]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Idpn]
AS
SELECT DISTINCT Idpn
FROM            dbo.PHIEUNHAP
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[Idhd] [varchar](12) NOT NULL,
	[Idsp] [varchar](10) NOT NULL,
	[Tenngdung] [nvarchar](30) NULL,
	[Idkh] [varchar](10) NULL,
	[Tensp] [nvarchar](30) NULL,
	[Dvt] [nvarchar](10) NULL,
	[Soluong] [int] NULL,
	[Giaxuat] [int] NULL,
	[Thanhtien] [int] NULL,
	[Thoigian] [datetimeoffset](7) NULL,
	[Hinhthuc] [nvarchar](10) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[Idhd] ASC,
	[Idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_IdHD]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_IdHD]
AS
SELECT DISTINCT Idhd
FROM            dbo.HOADON
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[Idncc] [varchar](10) NOT NULL,
	[Tenncc] [nvarchar](30) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sdt] [varchar](11) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[Idncc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAMNCC]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAMNCC](
	[Idncc] [varchar](10) NOT NULL,
	[Idsp] [varchar](10) NOT NULL,
	[Giacc] [int] NULL,
 CONSTRAINT [PK_SANPHAMNCC] PRIMARY KEY CLUSTERED 
(
	[Idsp] ASC,
	[Idncc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ReportPhieuDat]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ReportPhieuDat]
AS
SELECT        dbo.NCC.Tenncc, dbo.PHIEUDATHANG.Idsp, dbo.PHIEUDATHANG.Tensp, dbo.PHIEUDATHANG.Dvt, dbo.PHIEUDATHANG.Soluongdat, dbo.SANPHAMNCC.Giacc, dbo.PHIEUDATHANG.Idpd
FROM            dbo.NCC INNER JOIN
                         dbo.PHIEUDATHANG ON dbo.NCC.Idncc = dbo.PHIEUDATHANG.Idncc INNER JOIN
                         dbo.SANPHAMNCC ON dbo.NCC.Idncc = dbo.SANPHAMNCC.Idncc
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[Idkh] [varchar](10) NOT NULL,
	[Tenkh] [nvarchar](30) NULL,
	[Diachi] [nvarchar](30) NULL,
	[Sdt] [varchar](11) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[Idkh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISP]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISP](
	[Idloaisp] [varchar](10) NOT NULL,
	[Tenloaisp] [nvarchar](30) NULL,
 CONSTRAINT [PK_LOAISP] PRIMARY KEY CLUSTERED 
(
	[Idloaisp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[Idngdung] [varchar](10) NOT NULL,
	[Tenngdung] [nvarchar](30) NULL,
	[Chucvu] [nvarchar](20) NULL,
	[Tendn] [varchar](10) NULL,
	[Matkhau] [varchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[Idngdung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHOMNGDUNG]    Script Date: 6/6/2019 12:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMNGDUNG](
	[Idnhomngdung] [varchar](10) NOT NULL,
	[Quyendn] [nvarchar](20) NULL,
	[Idngdung] [varchar](10) NULL,
 CONSTRAINT [PK_NHOMNGDUNG] PRIMARY KEY CLUSTERED 
(
	[Idnhomngdung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[Idloaisp] [varchar](10) NOT NULL,
	[Idsp] [varchar](10) NOT NULL,
	[Tensp] [nvarchar](30) NULL,
	[Dvt] [nvarchar](10) NULL,
	[Soluong] [int] NULL,
	[Gianhap] [int] NULL,
	[Giaxuat] [int] NULL,
 CONSTRAINT [PK_SANPHAM_1] PRIMARY KEY CLUSTERED 
(
	[Idsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'001', N'001', N'Nguyễn Hồ Tuấn Trung', N'006', N'Giấy  A0 ', N'Tập', 10, 80000, 800000, CAST(N'1998-01-01T00:00:00.0000000+06:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'001', N'002', N'', N'006', N'Giấy A3', N'Tập', 9, 80000, 720000, CAST(N'1998-01-01T00:00:00.0000000+06:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'001', N'003', N'', N'006', N'Giấy A4', N'Tập', 10, 80000, 800000, CAST(N'1998-01-01T00:00:00.0000000+06:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'001', N'004', N'', N'006', N'Giấy note Unicorn', N'Tập', 6, 65000, 390000, CAST(N'1998-01-01T00:00:00.0000000+06:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'001', N'005', N'', N'006', N'Giấy than đen', N'Tập', 11, 80000, 880000, CAST(N'1998-01-01T00:00:00.0000000+06:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'002', N'001', N'', N'001', N'Giấy  A0', N'Tập', 5, 80000, 400000, CAST(N'2019-05-31T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'002', N'002', N'', N'001', N'Giấy  A0 ', N'Tập', 5, 80000, 400000, CAST(N'2019-05-31T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'002', N'004', N'', N'001', N'Giấy  A0 ', N'Tập', 5, 80000, 400000, CAST(N'2019-05-31T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'003', N'001', N'', N'002', N'Giấy  A0', N'Tập', 100, 80000, 8000000, CAST(N'2019-05-31T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'003', N'002', N'', N'002', N'Giấy  A0 ', N'Tập', 100, 80000, 8000000, CAST(N'2019-05-31T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'004', N'001', N'', N'002', N'Giấy  A0', N'Tập', 50, 80000, 4000000, CAST(N'2019-05-29T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'004', N'003', N'', N'002', N'Giấy A4', N'Tập', 20, 90000, 1800000, CAST(N'2019-05-29T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'004', N'004', N'', N'002', N'Giấy note Unicorn', N'Tập', 50, 65000, 3250000, CAST(N'2019-05-29T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'004', N'005', N'', N'002', N'Giấy than đen', N'Tập', 50, 70000, 3500000, CAST(N'2019-05-29T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'005', N'001', N'', N'006', N'Giấy  A0', N'Tập', 6, 80000, 480000, CAST(N'2019-06-02T00:00:00.0000000+00:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'005', N'002', N'', N'006', N'Giấy A3', N'Tập', 11, 75000, 825000, CAST(N'2019-06-02T00:00:00.0000000+00:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'005', N'003', N'', N'006', N'Giấy A4', N'Tập', 7, 90000, 630000, CAST(N'2019-06-02T00:00:00.0000000+00:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'005', N'004', N'', N'006', N'Giấy note Unicorn', N'Tập', 4, 65000, 260000, CAST(N'2019-06-02T00:00:00.0000000+00:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'006', N'001', N'', N'001', N'Giấy  A0', N'Tập', 50, 80000, 4000000, CAST(N'2019-06-03T00:00:00.0000000+00:00' AS DateTimeOffset), N'Sỉ')
INSERT [dbo].[HOADON] ([Idhd], [Idsp], [Tenngdung], [Idkh], [Tensp], [Dvt], [Soluong], [Giaxuat], [Thanhtien], [Thoigian], [Hinhthuc]) VALUES (N'007', N'001', N'', N'006', N'Giấy  A0', N'Tập', 1, 80000, 80000, CAST(N'2019-06-03T00:00:00.0000000+00:00' AS DateTimeOffset), N'Lẻ')
INSERT [dbo].[KHACHHANG] ([Idkh], [Tenkh], [Diachi], [Sdt]) VALUES (N'001', N'Tuấn Trung', N'Hà Nội', N'0120212021')
INSERT [dbo].[KHACHHANG] ([Idkh], [Tenkh], [Diachi], [Sdt]) VALUES (N'002', N'Lương Sao', N'Hà Nội', N'0965278512')
INSERT [dbo].[KHACHHANG] ([Idkh], [Tenkh], [Diachi], [Sdt]) VALUES (N'003', N'Minh Phong', N'Hà Nội', N'0956544465')
INSERT [dbo].[KHACHHANG] ([Idkh], [Tenkh], [Diachi], [Sdt]) VALUES (N'004', N'Thanh Thư', N'Hà Nội', N'0333310333')
INSERT [dbo].[KHACHHANG] ([Idkh], [Tenkh], [Diachi], [Sdt]) VALUES (N'005', N'Thu Huyền', N'Hà Nội', N'0366855844')
INSERT [dbo].[KHACHHANG] ([Idkh], [Tenkh], [Diachi], [Sdt]) VALUES (N'006', N'Khách lẻ', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([Idkh], [Tenkh], [Diachi], [Sdt]) VALUES (N'007', N'Tiến gấu mèo', N'541 Lạc Long Quân - Tây Hồ-HN', N'0987676554')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'001', N'Giấy')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'002', N'File hồ sơ')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'003', N'Giập kim - Bấm lỗ')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'004', N'Sổ')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'005', N'Bút bi - Bút gel')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'006', N'Bút lông - Bút dạ quang')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'007', N'Bút xoá - Tẩy')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'008', N'Bút chì - Gọt bút chì')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'009', N'Mực')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'010', N'Băng dính')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'011', N'Dao - Kéo')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'012', N'Thước kẻ - compa')
INSERT [dbo].[LOAISP] ([Idloaisp], [Tenloaisp]) VALUES (N'013', N'Dây')
INSERT [dbo].[NCC] ([Idncc], [Tenncc], [Diachi], [Sdt]) VALUES (N'001', N'Hồng Hà', N'Hà Nội', N'0987656473')
INSERT [dbo].[NCC] ([Idncc], [Tenncc], [Diachi], [Sdt]) VALUES (N'002', N'Deli', N'Hà Nội', N'0978695486')
INSERT [dbo].[NCC] ([Idncc], [Tenncc], [Diachi], [Sdt]) VALUES (N'003', N'Star', N'Hà Nội', N'0974829348')
INSERT [dbo].[NCC] ([Idncc], [Tenncc], [Diachi], [Sdt]) VALUES (N'004', N'Thiên Long', N'Thái Bình', N'09889898981')
INSERT [dbo].[NCC] ([Idncc], [Tenncc], [Diachi], [Sdt]) VALUES (N'005', N'Thăng Thiên', N'Thăng Long', N'09723123123')
INSERT [dbo].[NGUOIDUNG] ([Idngdung], [Tenngdung], [Chucvu], [Tendn], [Matkhau]) VALUES (N'001', N'Nguyễn Hồ Tuấn Trung', N'Nhập hàng', N'admin', N'admin123')
INSERT [dbo].[NGUOIDUNG] ([Idngdung], [Tenngdung], [Chucvu], [Tendn], [Matkhau]) VALUES (N'002', N'Trương Hải Anh', N'Bán hàng', N'admin1', N'admin')
INSERT [dbo].[NGUOIDUNG] ([Idngdung], [Tenngdung], [Chucvu], [Tendn], [Matkhau]) VALUES (N'003', N'Lương Thị Sao', N'Quản lý', N'admin2', N'123')
INSERT [dbo].[NGUOIDUNG] ([Idngdung], [Tenngdung], [Chucvu], [Tendn], [Matkhau]) VALUES (N'004', N'Nguyễn Thị Thanh Thư', N'Xử lý hoá đơn', N'admin3', N'123')
INSERT [dbo].[NHOMNGDUNG] ([Idnhomngdung], [Quyendn], [Idngdung]) VALUES (N'1', N'Bán hàng', N'002')
INSERT [dbo].[NHOMNGDUNG] ([Idnhomngdung], [Quyendn], [Idngdung]) VALUES (N'2', N'Nhập hàng', N'001')
INSERT [dbo].[NHOMNGDUNG] ([Idnhomngdung], [Quyendn], [Idngdung]) VALUES (N'3', N'Quản lý', N'003')
INSERT [dbo].[NHOMNGDUNG] ([Idnhomngdung], [Quyendn], [Idngdung]) VALUES (N'4', N'Xử lý hoá đơn', N'004')
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'001', N'003', N'001', N' ', N'Giấy A4', N'Tập', 2, CAST(N'2019-05-28T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'002', N'001', N'001', N' ', N'Giấy  A0', N'Tập', 5, CAST(N'2019-05-14T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'002', N'002', N'001', N' ', N'Giấy A3', N'Tập', 5, CAST(N'2019-05-14T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'002', N'003', N'001', N' ', N'Giấy A4', N'Tập', 5, CAST(N'2019-05-14T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'002', N'004', N'001', N' ', N'Giấy note Unicorn', N'Tập', 5, CAST(N'2019-05-14T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'002', N'005', N'001', N' ', N'Giấy than đen', N'Tập', 5, CAST(N'2019-05-14T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'003', N'001', N'001', N' ', N'Giấy  A0', N'Tập', 5, CAST(N'2019-05-30T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'003', N'003', N'001', N' ', N'Giấy A4', N'Tập', 8, CAST(N'2019-05-30T07:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'004', N'001', N'001', N' ', N'Giấy  A0', N'Tập', 3, CAST(N'2019-06-12T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'004', N'002', N'001', N' ', N'Giấy A3', N'Tập', 6, CAST(N'2019-06-11T07:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUDATHANG] ([Idpd], [Idsp], [Idncc], [Tennv], [Tensp], [Dvt], [Soluongdat], [Thoigian]) VALUES (N'005', N'001', N'001', N' ', N'Giấy  A0', N'Tập', 5, CAST(N'2019-06-03T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUNHAP] ([Idpn], [Idsp], [Idncc], [Tenngdung], [Nguoigiao], [Tensp], [Dvt], [Soluonggiao], [Soluongnhap], [Gianhap], [Thanhtien], [Thoigian]) VALUES (N'001', N'001', N'001', N' ', N'TT', N'Giấy  A0', N'Tập', 7, 3, 10000, 30000, CAST(N'2019-06-02T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUNHAP] ([Idpn], [Idsp], [Idncc], [Tenngdung], [Nguoigiao], [Tensp], [Dvt], [Soluonggiao], [Soluongnhap], [Gianhap], [Thanhtien], [Thoigian]) VALUES (N'001', N'003', N'001', N' ', N'TT', N'Giấy A4', N'Tập', 8, 3, 10000, 30000, CAST(N'2019-06-02T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUNHAP] ([Idpn], [Idsp], [Idncc], [Tenngdung], [Nguoigiao], [Tensp], [Dvt], [Soluonggiao], [Soluongnhap], [Gianhap], [Thanhtien], [Thoigian]) VALUES (N'002', N'001', N'001', N' ', N'Tùng Lâm', N'Giấy  A0', N'Tập', 5, 4, 2000, 8000, CAST(N'2019-05-29T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUNHAP] ([Idpn], [Idsp], [Idncc], [Tenngdung], [Nguoigiao], [Tensp], [Dvt], [Soluonggiao], [Soluongnhap], [Gianhap], [Thanhtien], [Thoigian]) VALUES (N'002', N'003', N'001', N' ', N'Tùng Lâm', N'Giấy A4', N'Tập', 5, 5, 2000, 10000, CAST(N'2019-05-29T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUNHAP] ([Idpn], [Idsp], [Idncc], [Tenngdung], [Nguoigiao], [Tensp], [Dvt], [Soluonggiao], [Soluongnhap], [Gianhap], [Thanhtien], [Thoigian]) VALUES (N'002', N'004', N'001', N' ', N'Tùng Lâm', N'Giấy note Unicorn', N'Tập', 5, 4, 2000, 8000, CAST(N'2019-05-29T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUNHAP] ([Idpn], [Idsp], [Idncc], [Tenngdung], [Nguoigiao], [Tensp], [Dvt], [Soluonggiao], [Soluongnhap], [Gianhap], [Thanhtien], [Thoigian]) VALUES (N'003', N'001', N'001', N' ', N'Trung', N'Giấy  A0', N'Tập', 8, 6, 70000, 420000, CAST(N'2019-06-03T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[PHIEUNHAP] ([Idpn], [Idsp], [Idncc], [Tenngdung], [Nguoigiao], [Tensp], [Dvt], [Soluonggiao], [Soluongnhap], [Gianhap], [Thanhtien], [Thoigian]) VALUES (N'004', N'001', N'001', N' ', N'Dean', N'Giấy  A0', N'Tập', 60, 50, 70000, 3500000, CAST(N'2019-06-06T00:00:00.0000000+00:00' AS DateTimeOffset))
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'001', N'Giấy  A0', N'Tập', 106, 70000, 80000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'002', N'Giấy A3', N'Tập', 90, 65000, 75000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'003', N'Giấy A4', N'Tập', 93, 80000, 90000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'004', N'Giấy note Unicorn', N'Tập', 60, 50000, 65000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'005', N'Giấy than đen', N'Tập', 40, 60000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'006', N'Giấy than xanh', N'Tập', 50, 40000, 60000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'007', N'Giấy bìa', N'Tập', 40, 75000, 80000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'008', N'Giấy decal', N'Tập', 30, 50000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'009', N'Giấy niêm phong', N'Tập', 20, 40000, 55000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'001', N'010', N'Giấy A5', N'Tập', 20, 40000, 50000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'011', N'Bìa lá thiên long', N'Tập', 25, 80000, 90000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'012', N'Bìa lá Plus', N'Tập', 20, 85000, 95000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'013', N'Bìa kiếng A4 dày', N'Tập', 15, 70000, 85000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'014', N'Bìa phân trang', N'Tập', 50, 50000, 65000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'015', N'Bao thư trắng', N'Tập', 25, 55000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'016', N'Bao thư vàng', N'Tập', 25, 55000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'017', N'Bao thư sọc', N'Tập', 25, 55000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'018', N'Bìa kẹp thiên long', N'Tập', 25, 55000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'019', N'Bìa nút', N'Tập', 30, 60000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'002', N'020', N'Bìa hộp Simili', N'Tập', 20, 50000, 60000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'003', N'021', N'Gỡ gim Eagle', N'Chiếc', 30, 30000, 40000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'003', N'022', N'Bấm lỗ', N'Chiếc', 40, 25000, 30000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'003', N'023', N'Kẹp giấy tam giấc', N'Chiếc', 25, 33000, 40000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'003', N'024', N'Bấm kim lớn', N'Chiếc', 24, 30000, 40000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'003', N'025', N'Bấm kim nhỏ', N'Chiếc', 30, 27000, 35000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'003', N'026', N'Kim bấm 2 lỗ', N'Hộp', 20, 15000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'003', N'027', N'Đinh ghim bảng', N'Hộp', 30, 19000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'028', N'Sổ caro', N'Quyển', 50, 17000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'029', N'Sổ da', N'Quyển', 30, 30000, 40000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'030', N'Sổ lò xo', N'Quyển', 45, 35000, 45000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'031', N'Sổ da danh thiếp', N'Quyển', 30, 28000, 38000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'032', N'Hoá đơn bán lẻ', N'Quyển', 20, 18000, 24000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'033', N'Phiếu nhập kho', N'Quyển', 20, 18000, 24000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'034', N'Phiếu xuất kho', N'Quyển', 20, 18000, 24000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'035', N'Phiếu xuất kho', N'Quyển', 20, 18000, 24000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'004', N'036', N'Tập khổ lớn', N'Tập', 20, 45000, 50000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'037', N'Bút bi thiên long đen', N'Hộp', 30, 45000, 50000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'038', N'Bút bi thiên long đen', N'Chiếc', 400, 1500, 5000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'039', N'Bút bi thiên long xanh', N'Hộp', 40, 45000, 50000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'040', N'Bút bi thiên long xanh', N'Chiếc', 400, 1500, 5000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'041', N'Bút bi thiên long đỏ', N'Hộp', 25, 45000, 50000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'042', N'Bút bi thiên long đỏ', N'Chiếc', 300, 1500, 5000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'043', N'Bút máy hồng hà', N'Chiếc', 100, 55000, 70000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'044', N'Bút máy Queen', N'Chiếc', 100, 10000, 15000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'005', N'045', N'Bút gel', N'Chiếc', 100, 15000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'006', N'046', N'Bút dạ quang Toyo xanh biển', N'Chiếc', 100, 18000, 26000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'006', N'047', N'Bút dạ quang Toyo xanh lá', N'Chiếc', 100, 18000, 26000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'006', N'048', N'Bút dạ quang Toyo vàng', N'Chiếc', 100, 18000, 26000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'006', N'049', N'Bút lông bảng xanh', N'Chiếc', 100, 18000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'006', N'050', N'Bút lông bảng đen', N'Chiếc', 100, 18000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'006', N'051', N'Bút lông bảng đỏ', N'Chiếc', 100, 18000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'007', N'052', N'Bút xoá nước', N'Chiếc', 50, 25000, 30000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'007', N'053', N'Tẩy chì(Gôm)', N'Chiếc', 60, 5000, 8000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'007', N'054', N'Băng xoá to', N'Chiếc', 25, 20000, 28000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'007', N'055', N'Băng xoá nhỏ', N'Chiếc', 25, 10000, 18000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'007', N'056', N'Tẩy chì Đức', N'Chiếc', 25, 4000, 8000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'007', N'057', N'Tẩy chì Campus', N'Chiếc', 25, 3000, 6000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'058', N'Gọt bút chì quay Tôn Ngộ Không', N'Chiếc', 20, 30000, 40000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'059', N'Gọt chì Classmate', N'Chiếc', 50, 2000, 5000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'060', N'Gọt chì ống', N'Chiếc', 15, 8000, 12000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'061', N'Gọt chì deli', N'Chiếc', 15, 5000, 7000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'062', N'Gọt chì sắt', N'Chiếc', 15, 11000, 17000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'063', N'Bút chì trắc nghiệm', N'Chiếc', 10, 45000, 55000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'064', N'Bút chì gỗ Stacom', N'Chiếc', 10, 3000, 5000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'065', N'Bút chì kim Pentel', N'Chiếc', 10, 22000, 28000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'066', N'Bút chì khúc thiên long', N'Chiếc', 50, 3000, 5000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'067', N'Bút chì gỗ Staedler', N'Chiếc', 50, 5000, 8000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'068', N'Bút chì gỗ Tiệp', N'Chiếc', 50, 5000, 7000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'008', N'069', N'Bút chì gỗ Pháp có tẩy', N'Chiếc', 20, 2000, 5000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'009', N'070', N'Mực dấu Horse', N'Hộp', 20, 50000, 55000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'009', N'071', N'Mực dấu Shiny', N'Hộp', 20, 50000, 55000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'009', N'072', N'Mực bút máy thiên long', N'Hộp', 50, 30000, 35000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'009', N'073', N'Mực bút máy queen', N'Hộp', 50, 30000, 35000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'009', N'074', N'Mực dấu shiny', N'Hộp', 50, 35000, 40000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'075', N'Băng dính giấy 3M', N'Cuộn', 20, 20000, 30000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'076', N'Băng dính trong Scotch', N'Cuộn', 20, 18000, 23000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'077', N'Băng dính gáy trơn', N'Cuộn', 20, 15000, 20000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'078', N'Băng dính xốp siêu dính', N'Cuộn', 20, 10000, 12000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'079', N'Băng dính đục', N'Cuộn', 20, 10000, 15000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'080', N'Băng dính trong to', N'Cuộn', 20, 12000, 18000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'081', N'Băng dính điện', N'Cuộn', 20, 8000, 10000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'082', N'Băng dính giấy', N'Cuộn', 20, 20000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'083', N'Băng dính vải', N'Cuộn', 20, 20000, 27000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'010', N'084', N'Băng dính hai mặt', N'Cuộn', 20, 5000, 8000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'085', N'Kéo răng cưa to', N'Chiếc', 30, 9000, 12000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'086', N'Kéo học sinh', N'Chiếc', 25, 8000, 12000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'087', N'Dao rọc giấy', N'Chiếc', 25, 9000, 13000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'088', N'Lưỡi dao rọc giấy to', N'Chiếc', 10, 10000, 15000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'089', N'Lưỡi dao rọc giấy nhỏ', N'Chiếc', 10, 5000, 10000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'090', N'Dao rọc giấy SDI', N'Chiếc', 23, 18000, 22000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'091', N'Dao rọc giấy Deli', N'Chiếc', 20, 20000, 26000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'011', N'092', N'Kéo Deli', N'Chiếc', 20, 20000, 25000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'093', N'Compa giáo viên', N'Chiếc', 20, 50000, 60000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'094', N'Compa Thiên Long', N'Chiếc', 50, 15000, 18000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'095', N'Compa Deli', N'Chiếc', 50, 18000, 22000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'096', N'Compa Campus', N'Chiếc', 50, 15000, 18000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'097', N'Thước kẻ 30cm', N'Chiếc', 100, 5000, 7000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'098', N'Thước kẻ 20cm', N'Chiếc', 100, 2000, 4000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'099', N'Thước kẻ Hồng Hà', N'Chiếc', 200, 1000, 2000)
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'012', N'100', N'Bộ Eke Deli', N'Bộ', 100, 25000, 35000)
GO
INSERT [dbo].[SANPHAM] ([Idloaisp], [Idsp], [Tensp], [Dvt], [Soluong], [Gianhap], [Giaxuat]) VALUES (N'013', N'101', N'Dây nhảy', N'Chiếc', 10, 8000, 10000)
INSERT [dbo].[SANPHAMNCC] ([Idncc], [Idsp], [Giacc]) VALUES (N'001', N'001', 1000)
INSERT [dbo].[SANPHAMNCC] ([Idncc], [Idsp], [Giacc]) VALUES (N'002', N'001', 10000)
INSERT [dbo].[SANPHAMNCC] ([Idncc], [Idsp], [Giacc]) VALUES (N'001', N'002', 100000)
INSERT [dbo].[SANPHAMNCC] ([Idncc], [Idsp], [Giacc]) VALUES (N'001', N'003', 10000)
INSERT [dbo].[SANPHAMNCC] ([Idncc], [Idsp], [Giacc]) VALUES (N'001', N'004', 10000)
INSERT [dbo].[SANPHAMNCC] ([Idncc], [Idsp], [Giacc]) VALUES (N'002', N'012', 1000)
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([Idkh])
REFERENCES [dbo].[KHACHHANG] ([Idkh])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_SANPHAM] FOREIGN KEY([Idsp])
REFERENCES [dbo].[SANPHAM] ([Idsp])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_SANPHAM]
GO
ALTER TABLE [dbo].[NHOMNGDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NHOMNGDUNG_NGUOIDUNG] FOREIGN KEY([Idngdung])
REFERENCES [dbo].[NGUOIDUNG] ([Idngdung])
GO
ALTER TABLE [dbo].[NHOMNGDUNG] CHECK CONSTRAINT [FK_NHOMNGDUNG_NGUOIDUNG]
GO
ALTER TABLE [dbo].[PHIEUDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUDATHANG_NCC] FOREIGN KEY([Idncc])
REFERENCES [dbo].[NCC] ([Idncc])
GO
ALTER TABLE [dbo].[PHIEUDATHANG] CHECK CONSTRAINT [FK_PHIEUDATHANG_NCC]
GO
ALTER TABLE [dbo].[PHIEUDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUDATHANG_SANPHAM] FOREIGN KEY([Idsp])
REFERENCES [dbo].[SANPHAM] ([Idsp])
GO
ALTER TABLE [dbo].[PHIEUDATHANG] CHECK CONSTRAINT [FK_PHIEUDATHANG_SANPHAM]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NCC] FOREIGN KEY([Idncc])
REFERENCES [dbo].[NCC] ([Idncc])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NCC]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_SANPHAM] FOREIGN KEY([Idsp])
REFERENCES [dbo].[SANPHAM] ([Idsp])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_SANPHAM]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISP] FOREIGN KEY([Idloaisp])
REFERENCES [dbo].[LOAISP] ([Idloaisp])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISP]
GO
ALTER TABLE [dbo].[SANPHAMNCC]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAMNCC_NCC] FOREIGN KEY([Idncc])
REFERENCES [dbo].[NCC] ([Idncc])
GO
ALTER TABLE [dbo].[SANPHAMNCC] CHECK CONSTRAINT [FK_SANPHAMNCC_NCC]
GO
ALTER TABLE [dbo].[SANPHAMNCC]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAMNCC_SANPHAM] FOREIGN KEY([Idsp])
REFERENCES [dbo].[SANPHAM] ([Idsp])
GO
ALTER TABLE [dbo].[SANPHAMNCC] CHECK CONSTRAINT [FK_SANPHAMNCC_SANPHAM]
GO
/****** Object:  StoredProcedure [dbo].[sp_DelHD]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelHD]
@Idhd varchar(12),
@Tensp nvarchar(30)
AS
DELETE FROM [dbo].[HOADON]
      WHERE Idhd = @Idhd and Idsp =(SELECT Idsp FROM SANPHAM WHERE Tensp = @Tensp)
GO
/****** Object:  StoredProcedure [dbo].[sp_DelKH]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Del KH
CREATE PROC [dbo].[sp_DelKH]
@Idkh varchar(10)
AS
DELETE FROM KHACHHANG WHERE Idkh = @Idkh
GO
/****** Object:  StoredProcedure [dbo].[sp_DelLoaiSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelLoaiSP]
@Idloaisp varchar(10)
AS
DELETE FROM LOAISP WHERE Idloaisp = @Idloaisp
GO
/****** Object:  StoredProcedure [dbo].[sp_DelNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelNCC]
@Idncc varchar(10)
AS
DELETE FROM NCC WHERE Idncc = @Idncc
GO
/****** Object:  StoredProcedure [dbo].[sp_DelNgDung]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelNgDung]
@Idngdung varchar(10)
AS
DELETE FROM NGUOIDUNG
WHERE Idngdung = @Idngdung
GO
/****** Object:  StoredProcedure [dbo].[sp_DelPD]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelPD]
@Idpd varchar(12),
@Tensp nvarchar(30)
AS
DELETE FROM PHIEUDATHANG 
WHERE Idpd = @Idpd AND Idsp = (SELECT Idsp FROM SANPHAM WHERE Tensp = @Tensp)
GO
/****** Object:  StoredProcedure [dbo].[sp_DelPN]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelPN]
@Idpn varchar(12),
@Tensp nvarchar(30)
AS
DELETE FROM PHIEUNHAP
WHERE Idpn = @Idpn AND Idsp = (SELECT Idsp FROM SANPHAM WHERE Tensp = @Tensp)
GO
/****** Object:  StoredProcedure [dbo].[sp_DelSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelSP]
@Idsp varchar(10)
AS
DELETE FROM SANPHAM 
WHERE Idsp = @Idsp
GO
/****** Object:  StoredProcedure [dbo].[sp_DelSPNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelSPNCC]
@Idncc varchar(10),
@Idsp varchar(10)
AS
DELETE FROM SANPHAMNCC WHERE Idsp = @Idsp AND Idncc = @Idncc
GO
/****** Object:  StoredProcedure [dbo].[sp_GiamSL]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GiamSL]
@Idhd varchar(12),
@Idsp varchar(10)
AS
update SANPHAM 
set Soluong = Soluong - (select Soluong from HOADON where Idhd = @Idhd and Idsp = @Idsp)
where Idsp = @Idsp
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHD]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_InsertHD]
@Idhd varchar(12),
@Idsp varchar(10),
@Tenngdung nvarchar(30),
@Idkh varchar(10),
@Tensp nvarchar(30),
@Dvt nvarchar(10),
@Soluong int,
@Giaxuat int,
@Thanhtien int,
@Thoigian datetimeoffset(7),
@Hinhthuc nvarchar(10)
AS
INSERT INTO [dbo].[HOADON]
           ([Idhd]
           ,[Idsp]
           ,[Tenngdung]
           ,[Idkh]
           ,[Tensp]
           ,[Dvt]
           ,[Soluong]
           ,[Giaxuat]
           ,[Thanhtien]
           ,[Thoigian]
           ,[Hinhthuc])
     VALUES
           (@Idhd,@Idsp,@Tenngdung,@Idkh,@Tensp,@Dvt,@Soluong,@Giaxuat,@Thanhtien,@Thoigian,@Hinhthuc)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertKH]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertKH]
@Idkh varchar(10),
@Tenkh nvarchar(30),
@Diachi nvarchar(50),
@Sdt varchar(11)
AS
INSERT INTO KHACHHANG(Idkh,Tenkh,Diachi,Sdt) 
VALUES(@Idkh,@Tenkh,@Diachi,@Sdt)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertLoaiSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertLoaiSP]
@Idloaisp varchar(10),
@Tenloaisp nvarchar(30)
AS
insert into LOAISP(Idloaisp,Tenloaisp) 
values(@Idloaisp,@Tenloaisp)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertNCC]
@Idncc varchar(10),
@Tenncc nvarchar(30),
@Diachi nvarchar(50),
@Sdt varchar(11)
AS
INSERT INTO NCC(Idncc,Tenncc,Diachi,Sdt) 
VALUES(@Idncc,@Tenncc,@Diachi,@Sdt)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertNgDung]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertNgDung]
@Idngdung varchar(10),
@Tenngdung nvarchar(30),
@Chucvu nvarchar(20),
@Tendn varchar(10),
@Matkhau varchar(10)
AS
INSERT INTO NGUOIDUNG(Idngdung,Tenngdung,Chucvu,Tendn,Matkhau)
VALUES(@Idngdung,@Tenngdung,@Chucvu,@Tendn,@Matkhau)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPD]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertPD]
@Idpd varchar(12),
@Idsp varchar(10),
@Idncc varchar(10),
@Tennv nvarchar(10),
@Tensp nvarchar(30),
@Dvt nvarchar(10),
@Soluongdat int,
@Thoigian datetimeoffset(7)
AS
INSERT INTO PHIEUDATHANG(Idpd,Idsp,Idncc,Tennv,Tensp,Dvt,Soluongdat,Thoigian)
VALUES(
@Idpd,
@Idsp,
@Idncc,
@Tennv,
@Tensp,
@Dvt,
@Soluongdat,
@Thoigian)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPN]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertPN]
@Idpn varchar(12),
@Idsp varchar(10),
@Idncc varchar(10),
@Tenngdung nvarchar(30),
@Nguoigiao nvarchar(30),
@Tensp nvarchar(30),
@Dvt nvarchar(10),
@Soluonggiao int,
@Soluongnhap int,
@Gianhap int,
@Thanhtien int,
@Thoigian datetimeoffset(7)
AS
INSERT INTO PHIEUNHAP(Idpn,Idsp,Idncc,Tenngdung,Nguoigiao,Tensp,Dvt,Soluonggiao,Soluongnhap,Gianhap,Thanhtien,Thoigian)
VALUES(@Idpn,@Idsp,@Idncc,@Tenngdung,@Nguoigiao,@Tensp,@Dvt,@Soluonggiao,@Soluongnhap,@Gianhap,@Thanhtien,@Thoigian)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertSP]
@Idsp varchar(10),
@Idloaisp varchar(10),
@Tensp nvarchar(30),
@Dvt nvarchar(10),
@Soluong int,
@Gianhap int,
@Giaxuat int
AS
INSERT INTO SANPHAM(Idloaisp,Idsp,Tensp,Dvt,Soluong,Gianhap,Giaxuat)
VALUES(@Idloaisp,@Idsp,@Tensp,@Dvt,@Soluong,@Gianhap,@Giaxuat)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSPNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertSPNCC]
@Idncc varchar(10),
@Idsp varchar(10),
@Giacc int
AS
INSERT INTO SANPHAMNCC(Idsp,Idncc,Giacc)
VALUES(@Idsp,@Idncc,@Giacc)
GO
/****** Object:  StoredProcedure [dbo].[sp_PickIdspNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_PickIdspNCC]
@Idncc varchar(10)
AS
SELECT Idsp FROM SANPHAM 
EXCEPT SELECT Idsp FROM SANPHAMNCC
WHERE Idncc= @Idncc
GO
/****** Object:  StoredProcedure [dbo].[sp_ReportHD_Si]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ReportHD_Si]
@Idhd varchar(12)
AS
SELECT        dbo.HOADON.Tensp, dbo.HOADON.Soluong, dbo.HOADON.Giaxuat, dbo.HOADON.Thanhtien, dbo.HOADON.Hinhthuc, dbo.HOADON.Thoigian, dbo.KHACHHANG.Tenkh, dbo.KHACHHANG.Diachi
FROM            dbo.HOADON INNER JOIN
                         dbo.KHACHHANG ON dbo.HOADON.Idkh = dbo.KHACHHANG.Idkh
WHERE        (dbo.HOADON.Idhd = @Idhd)
GO
/****** Object:  StoredProcedure [dbo].[sp_ReportPhieuDat]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ReportPhieuDat]
@Idpd varchar(12)
AS
SELECT        dbo.PHIEUDATHANG.Idsp, dbo.PHIEUDATHANG.Tensp, dbo.PHIEUDATHANG.Dvt, dbo.PHIEUDATHANG.Soluongdat, dbo.SANPHAM.Gianhap
FROM            dbo.PHIEUDATHANG INNER JOIN
                         dbo.SANPHAM ON dbo.PHIEUDATHANG.Idsp = dbo.SANPHAM.Idsp
WHERE        (dbo.PHIEUDATHANG.Idpd =@Idpd)
GO
/****** Object:  StoredProcedure [dbo].[sp_ReportPhieuNhap]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ReportPhieuNhap]
@Idpn varchar(12)
AS
SELECT        dbo.PHIEUNHAP.Idsp, dbo.PHIEUNHAP.Tensp, dbo.PHIEUNHAP.Dvt, dbo.PHIEUNHAP.Soluonggiao, dbo.PHIEUNHAP.Soluongnhap, dbo.PHIEUNHAP.Gianhap, dbo.PHIEUNHAP.Thanhtien, dbo.NCC.Tenncc, dbo.NCC.Diachi, 
                         dbo.NCC.Sdt, dbo.PHIEUNHAP.Nguoigiao, dbo.PHIEUNHAP.Tenngdung
FROM            dbo.PHIEUNHAP INNER JOIN
                         dbo.NCC ON dbo.PHIEUNHAP.Idncc = dbo.NCC.Idncc
WHERE        (dbo.PHIEUNHAP.Idpn = @Idpn)
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectKH]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SelectKH]
as
select Idkh as N'Mã khách hàng',Tenkh as N'Tên khách hàng',Diachi as N'Địa chỉ',Sdt as N'Số điện thoại' from KHACHHANG
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectLoaiSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SelectLoaiSP]
as
select Idloaisp as N'Mã loại sản phẩm',Tenloaisp as N'Tên loại sản phẩm' from LOAISP
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SelectNCC]
as
select Idncc as N'Mã NCC', Tenncc as N'Tên NCC',Diachi as N'Địa chỉ', Sdt as N'Số điện thoại' from NCC
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SelectSP]
AS
SELECT 
Idloaisp AS N'Loại sản phẩm',
Idsp AS N'Mã sản phẩm',
Tensp AS N'Tên sản phẩm',
Gianhap AS N'Giá nhập',
Giaxuat AS N'Giá xuất',
Dvt AS N'Đơn vị tính',
Soluong AS N'Số lượng' 
FROM SANPHAM
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowHD]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ShowHD]
@Idhd varchar(12)
AS
SELECT        dbo.HOADON.Idsp, dbo.SANPHAM.Tensp, dbo.SANPHAM.Dvt, dbo.HOADON.Soluong, dbo.HOADON.Giaxuat, dbo.HOADON.Thanhtien, dbo.HOADON.Thoigian, dbo.HOADON.Hinhthuc, dbo.KHACHHANG.Tenkh
FROM            dbo.HOADON INNER JOIN
                         dbo.KHACHHANG ON dbo.HOADON.Idkh = dbo.KHACHHANG.Idkh INNER JOIN
                         dbo.SANPHAM ON dbo.HOADON.Idsp = dbo.SANPHAM.Idsp
WHERE        (dbo.HOADON.Idhd = @Idhd)
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowIdsp_PhieuDat]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ShowIdsp_PhieuDat]
@Idncc varchar(10),
@Idpd varchar(12)
AS
SELECT Idsp FROM SANPHAMNCC 
WHERE Idncc = @Idncc
EXCEPT ( SELECT Idsp FROM PHIEUDATHANG WHERE Idpd = @Idpd)
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowIdsp_PN]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ShowIdsp_PN]
@Idncc varchar(10),
@Idpn varchar(12)
AS
SELECT Idsp FROM SANPHAMNCC 
WHERE Idncc = @Idncc
EXCEPT ( SELECT Idsp FROM PHIEUNHAP WHERE Idpn = @Idpn)
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowPhieuDat]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ShowPhieuDat]
@Idpd varchar(12)
AS
SELECT        dbo.PHIEUDATHANG.Idsp, dbo.PHIEUDATHANG.Tensp, dbo.PHIEUDATHANG.Dvt, dbo.PHIEUDATHANG.Soluongdat, dbo.PHIEUDATHANG.Thoigian
FROM            dbo.PHIEUDATHANG INNER JOIN
                         dbo.NCC ON dbo.PHIEUDATHANG.Idncc = dbo.NCC.Idncc INNER JOIN
                         dbo.SANPHAM ON dbo.PHIEUDATHANG.Idsp = dbo.SANPHAM.Idsp
WHERE        (dbo.PHIEUDATHANG.Idpd = @Idpd)
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowPhieuNhap]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ShowPhieuNhap]
@Idpn varchar(12)
AS
SELECT        dbo.PHIEUNHAP.Idsp, dbo.PHIEUNHAP.Tensp, dbo.PHIEUNHAP.Dvt, dbo.PHIEUNHAP.Soluonggiao, dbo.PHIEUNHAP.Soluongnhap, dbo.PHIEUNHAP.Gianhap, dbo.PHIEUNHAP.Thanhtien, dbo.PHIEUNHAP.Thoigian,dbo.PHIEUNHAP.Nguoigiao
FROM            dbo.SANPHAM INNER JOIN
                         dbo.PHIEUNHAP ON dbo.SANPHAM.Idsp = dbo.PHIEUNHAP.Idsp INNER JOIN
                         dbo.NCC ON dbo.PHIEUNHAP.Idncc = dbo.NCC.Idncc
WHERE        (dbo.PHIEUNHAP.Idpn = @Idpn)
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowSPNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ShowSPNCC]
@Tenncc nvarchar(30)
AS
SELECT        dbo.NCC.Idncc, dbo.SANPHAM.Idsp, dbo.SANPHAM.Tensp, dbo.SANPHAM.Dvt, dbo.SANPHAMNCC.Giacc
FROM            dbo.NCC INNER JOIN
                         dbo.SANPHAMNCC ON dbo.NCC.Idncc = dbo.SANPHAMNCC.Idncc INNER JOIN
                         dbo.SANPHAM ON dbo.SANPHAMNCC.Idsp = dbo.SANPHAM.Idsp
WHERE        (dbo.NCC.Tenncc = @Tenncc)
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSL]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_ThemSL]
@Idpn varchar(12),
@Idsp varchar(10)
AS
update SANPHAM 
set Soluong = Soluong + (select Soluongnhap from PHIEUNHAP where Idpn = @Idpn and Idsp = @Idsp)
where Idsp = @Idsp

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdKH]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdKH]
@Idkh varchar(10),
@Tenkh nvarchar(30),
@Diachi nvarchar(50),
@Sdt varchar(11)
AS
UPDATE KHACHHANG
SET 
Tenkh = @Tenkh,
Diachi = @Diachi,
Sdt = @Sdt
WHERE Idkh =@Idkh
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdLoaiSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdLoaiSP]
@Idloaisp varchar(10),
@Tenloaisp nvarchar(30)
AS
UPDATE LOAISP
SET Tenloaisp = @Tenloaisp
WHERE Idloaisp =@Idloaisp
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdNCC]
@Idncc varchar(10),
@Tenncc nvarchar(30),
@Diachi nvarchar(50),
@Sdt varchar(11)
AS
UPDATE NCC
SET 
Tenncc = @Tenncc,
Diachi = @Diachi,
Sdt = @Sdt
WHERE Idncc =@Idncc
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdNgDung]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdNgDung]
@Idngdung varchar(10),
@Tenngdung nvarchar(30),
@Chucvu nvarchar(20),
@Tendn varchar(10),
@Matkhau varchar(10)
AS
UPDATE NGUOIDUNG
SET
Tenngdung = @Tenngdung,
Chucvu = @Chucvu,
Tendn = @Tendn,
Matkhau = @Matkhau
WHERE Idngdung = @Idngdung
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdSP]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdSP]
@Idsp varchar(10),
@Idloaisp varchar(10),
@Tensp nvarchar(30),
@Dvt nvarchar(10),
@Soluong int,
@Gianhap int,
@Giaxuat int
AS
UPDATE SANPHAM
SET 
Idloaisp = @Idloaisp,
Tensp =@Tensp,
Dvt = @Dvt,
Soluong = @Soluong,
Gianhap = @Gianhap,
Giaxuat = @Giaxuat
WHERE Idsp =@Idsp
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdSPNCC]    Script Date: 6/6/2019 12:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdSPNCC]
@Idncc varchar(10),
@Idsp varchar(10),
@Giacc int
AS
UPDATE SANPHAMNCC
SET Giacc = @Giacc
WHERE Idsp = @Idsp AND Idncc = @Idncc
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "HOADON"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_IdHD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_IdHD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PHIEUDATHANG"
            Begin Extent = 
               Top = 15
               Left = 144
               Bottom = 145
               Right = 314
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Idphieudat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Idphieudat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PHIEUNHAP"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Idpn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Idpn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[33] 4[17] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NCC"
            Begin Extent = 
               Top = 28
               Left = 473
               Bottom = 202
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PHIEUDATHANG"
            Begin Extent = 
               Top = 0
               Left = 225
               Bottom = 203
               Right = 395
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SANPHAMNCC"
            Begin Extent = 
               Top = 7
               Left = 12
               Bottom = 187
               Right = 182
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ReportPhieuDat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ReportPhieuDat'
GO
USE [master]
GO
ALTER DATABASE [QLyVVP] SET  READ_WRITE 
GO
