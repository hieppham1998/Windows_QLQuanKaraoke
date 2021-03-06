USE [master]
GO
/****** Object:  Database [QuanLyQuanKaraoke]    Script Date: 12/18/2019 5:26:47 PM ******/
CREATE DATABASE [QuanLyQuanKaraoke]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanKaraoke', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLyQuanKaraoke.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyQuanKaraoke_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLyQuanKaraoke_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanKaraoke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyQuanKaraoke', N'ON'
GO
USE [QuanLyQuanKaraoke]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaDV] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[DVT] [nvarchar](10) NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHD_Tam]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD_Tam](
	[MaPV] [varchar](10) NOT NULL,
	[MaDV] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nvarchar](10) NULL,
 CONSTRAINT [PK_CTHD_Tam] PRIMARY KEY CLUSTERED 
(
	[MaPV] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTPN_DichVu]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPN_DichVu](
	[MaPN_DichVu] [varchar](10) NOT NULL,
	[MaDichVu] [varchar](10) NOT NULL,
	[SL_DichVuNhap] [int] NULL,
	[DG_DichVuNhap] [float] NULL,
	[DVT_DichVuNhap] [nvarchar](15) NULL,
 CONSTRAINT [PK_CTPN_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaPN_DichVu] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTPN_ThietBi]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPN_ThietBi](
	[MaPN_ThietBi] [varchar](10) NOT NULL,
	[MaTB] [varchar](10) NOT NULL,
	[SL_ThietBiNhap] [int] NULL,
	[DG_ThietBiNhap] [float] NULL,
 CONSTRAINT [PK_CTPN_ThietBi] PRIMARY KEY CLUSTERED 
(
	[MaPN_ThietBi] ASC,
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DatPhong](
	[MaDatPhong] [varchar](10) NOT NULL,
	[MaPhong] [varchar](10) NULL,
	[TenKhachDat] [nvarchar](50) NULL,
	[SDT_Khach] [char](10) NULL,
	[GioNhanPhong] [datetime] NULL,
	[TienCoc] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DatPhong] PRIMARY KEY CLUSTERED 
(
	[MaDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [varchar](10) NOT NULL,
	[TenDichVu] [nvarchar](30) NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [float] NULL,
	[DonGiaBan] [float] NULL,
	[DVT] [nvarchar](15) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoThatLac]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoThatLac](
	[MaPhong] [varchar](10) NOT NULL,
	[NgayGio] [datetime] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_DoThatLac] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[NgayGio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[SDT_KhachHang] [char](10) NULL,
	[MaPhong] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[GioBatDau] [datetime] NULL,
	[GioKetThuc] [datetime] NULL,
	[MaPhuThu] [varchar](10) NULL,
	[TienCoc] [int] NULL,
	[KhuyenMai] [int] NULL,
	[TienDenBu] [float] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_Hoa_Don] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon_Tam]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon_Tam](
	[MaPhucVu] [varchar](10) NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
	[SDT_KH] [char](10) NOT NULL,
	[GioBD] [datetime] NOT NULL,
	[TienDatCoc] [int] NULL,
 CONSTRAINT [PK_HoaDon_Tam_1] PRIMARY KEY CLUSTERED 
(
	[MaPhucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[TenKH] [nvarchar](50) NULL,
	[SDT] [char](10) NOT NULL,
	[TichDiem] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [varchar](10) NOT NULL,
	[TenLoaiPhong] [nvarchar](10) NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[CMND] [char](10) NULL,
	[NgayVaoLam] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieNhap] [varchar](10) NOT NULL,
	[MaNhanVien] [varchar](10) NULL,
	[NgayNhap] [date] NULL,
	[TongPN] [float] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](10) NOT NULL,
	[MaLoaiPhong] [varchar](10) NULL,
	[GiaPhong] [float] NULL,
	[TinhTrang] [nvarchar](20) NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhuThu]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhuThu](
	[MaPhuThu] [varchar](10) NOT NULL,
	[TenPhuThu] [nvarchar](30) NULL,
	[SoTien] [int] NULL,
 CONSTRAINT [PK_PhuThu] PRIMARY KEY CLUSTERED 
(
	[MaPhuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_ChucNang]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_ChucNang](
	[MaChucNang] [varchar](10) NOT NULL,
	[TenChucNang] [nvarchar](40) NULL,
 CONSTRAINT [PK_QL_ChucNang] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_NhomNguoiDung]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_NhomNguoiDung](
	[MaNhom] [varchar](10) NOT NULL,
	[TenNhom] [nvarchar](15) NULL,
	[GhiChu] [nvarchar](30) NULL,
 CONSTRAINT [PK_QL_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_PhanQuyen]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_PhanQuyen](
	[MaNhomNguoiDung] [varchar](10) NOT NULL,
	[MaChucNang] [varchar](10) NOT NULL,
	[CoQuyen] [bit] NOT NULL,
 CONSTRAINT [PK_QL_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_PhanQuyenTaiKhoan]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_PhanQuyenTaiKhoan](
	[TenDN] [varchar](10) NOT NULL,
	[MaCN] [varchar](10) NOT NULL,
	[Quyen] [bit] NOT NULL,
 CONSTRAINT [PK_QL_PhanQuyenTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC,
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_TaiKhoan]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_TaiKhoan](
	[TenDangNhap] [varchar](10) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[MaNV] [varchar](10) NULL,
	[HoatDong] [bit] NOT NULL,
	[NhomNguoiDung] [varchar](10) NULL,
 CONSTRAINT [PK_QL_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThietBi](
	[MaThietBi] [varchar](10) NOT NULL,
	[TenThietBi] [nvarchar](40) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ThietBi] PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThietBi_Phong]    Script Date: 12/18/2019 5:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThietBi_Phong](
	[MaPhong] [varchar](10) NOT NULL,
	[MaThietBi] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ThietBi_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV004', 1, 10000, N'Chai', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV007', 2, 10000, N'Bịch', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV009', 1, 17000, N'Chai', 17000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV013', 1, 15000, N'Lon', 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'04fFCC9g', N'DV015', 1, 12000, N'Chai', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV001', 1, 50000, N'Đĩa', 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV002', 5, 14000, N'Lon', 70000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV003', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV004', 12, 10000, N'Chai', 120000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV009', 1, 17000, N'Chai', 17000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'0YvOR921', N'DV012', 2, 12000, N'Lon', 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV002', 2, 14000, N'Lon', 28000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV004', 4, 10000, N'Chai', 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV011', 1, 16000, N'Lon', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV012', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV013', 1, 15000, N'Lon', 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'3vX5781M', N'DV017', 5, 18000, N'Chai', 90000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'4syeAroe', N'DV002', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'4syeAroe', N'DV004', 2, 10000, N'Chai', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'56v6tRFi', N'DV001', 1, 50000, N'Đĩa', 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'56v6tRFi', N'DV002', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'56v6tRFi', N'DV004', 2, 10000, N'Chai', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'56v6tRFi', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'56v6tRFi', N'DV007', 2, 10000, N'Bịch', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'56v6tRFi', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'5W41NBl9', N'DV002', 3, 14000, N'Lon', 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'5W41NBl9', N'DV003', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'5W41NBl9', N'DV004', 4, 10000, N'Chai', 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'5W41NBl9', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV006', 3, 10000, N'Bịch', 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV007', 3, 10000, N'Bịch', 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV008', 4, 16000, N'Chai', 64000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV009', 1, 17000, N'Chai', 17000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV011', 2, 16000, N'Lon', 32000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV014', 2, 14000, N'Chai', 28000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'62aLnK3Z', N'DV015', 2, 12000, N'Chai', 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'7399xKZQ', N'DV001', 2, 50000, N'Đĩa', 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV006', 3, 10000, N'Bịch', 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV007', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV009', 3, 17000, N'Chai', 51000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV011', 1, 16000, N'Lon', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV012', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV014', 1, 14000, N'Chai', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'8TDUGHbd', N'DV016', 1, 18000, N'Lon', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'AbfT5oP3', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'AbfT5oP3', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'AbfT5oP3', N'DV007', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'AbfT5oP3', N'DV008', 2, 16000, N'Chai', 32000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'AbfT5oP3', N'DV009', 2, 17000, N'Chai', 34000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'AbfT5oP3', N'DV013', 1, 15000, N'Lon', 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'b6d59JrN', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'b6d59JrN', N'DV008', 2, 16000, N'Chai', 32000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'b6d59JrN', N'DV009', 1, 17000, N'Chai', 17000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'b6d59JrN', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'b6d59JrN', N'DV014', 1, 14000, N'Chai', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Bmpy56K5', N'DV007', 2, 10000, N'Bịch', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Bmpy56K5', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Bmpy56K5', N'DV009', 2, 17000, N'Chai', 34000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Bmpy56K5', N'DV012', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'coFtf33a', N'DV004', 4, 10000, N'Chai', 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'eP976LE6', N'DV001', 1, 50000, N'Đĩa', 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'eP976LE6', N'DV002', 2, 14000, N'Lon', 28000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'hLXQ8YQE', N'DV001', 1, 50000, N'Đĩa', 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'hLXQ8YQE', N'DV003', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'hLXQ8YQE', N'DV004', 2, 10000, N'Chai', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'hLXQ8YQE', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'hLXQ8YQE', N'DV006', 2, 10000, N'Bịch', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'hLXQ8YQE', N'DV007', 2, 10000, N'Bịch', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'hLXQ8YQE', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'if9BwL9h', N'DV001', 2, 50000, N'Đĩa', 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'if9BwL9h', N'DV002', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'if9BwL9h', N'DV003', 2, 14000, N'Lon', 28000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'if9BwL9h', N'DV004', 3, 10000, N'Chai', 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'if9BwL9h', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'if9BwL9h', N'DV013', 1, 15000, N'Lon', 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Jd885tbj', N'DV002', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Jd885tbj', N'DV003', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Jd885tbj', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Jd885tbj', N'DV009', 1, 17000, N'Chai', 17000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Jd885tbj', N'DV012', 4, 12000, N'Lon', 48000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Jd885tbj', N'DV013', 2, 15000, N'Lon', 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'r547166H', N'DV004', 4, 10000, N'Chai', 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'r547166H', N'DV016', 1, 18000, N'Lon', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'r547166H', N'DV017', 2, 18000, N'Chai', 36000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'T0NT5Dhx', N'DV003', 3, 14000, N'Lon', 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'T0NT5Dhx', N'DV004', 6, 10000, N'Chai', 60000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'T0NT5Dhx', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'T0NT5Dhx', N'DV017', 4, 18000, N'Chai', 72000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'uTq4o4OA', N'DV001', 3, 50000, N'Đĩa', 150000)
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Vc6A37z6', N'DV002', 3, 14000, N'Lon', 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Vc6A37z6', N'DV004', 4, 10000, N'Chai', 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Vc6A37z6', N'DV009', 1, 17000, N'Chai', 17000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Vc6A37z6', N'DV012', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'wCgw2sT8', N'DV001', 1, 50000, N'Đĩa', 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'wCgw2sT8', N'DV002', 4, 14000, N'Lon', 56000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'wCgw2sT8', N'DV004', 2, 10000, N'Chai', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'WkV41W4S', N'DV012', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'WkV41W4S', N'DV013', 2, 15000, N'Lon', 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'WkV41W4S', N'DV014', 1, 14000, N'Chai', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'WkV41W4S', N'DV015', 3, 12000, N'Chai', 36000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'WkV41W4S', N'DV016', 2, 18000, N'Lon', 36000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'WkV41W4S', N'DV017', 3, 18000, N'Chai', 54000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV004', 2, 10000, N'Chai', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV007', 4, 10000, N'Bịch', 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV008', 2, 16000, N'Chai', 32000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV009', 4, 17000, N'Chai', 68000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV015', 1, 12000, N'Chai', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'X605A9C5', N'DV016', 1, 18000, N'Lon', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Y6sJx0KX', N'DV001', 1, 50000, N'Đĩa', 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Y6sJx0KX', N'DV002', 1, 14000, N'Lon', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Y6sJx0KX', N'DV012', 2, 12000, N'Lon', 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Y6sJx0KX', N'DV013', 1, 15000, N'Lon', 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Y6sJx0KX', N'DV014', 1, 14000, N'Chai', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Y6sJx0KX', N'DV016', 3, 18000, N'Lon', 54000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Y6sJx0KX', N'DV017', 4, 18000, N'Chai', 72000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Z447b1Su', N'DV001', 2, 50000, N'Đĩa', 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Z447b1Su', N'DV004', 1, 10000, N'Chai', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Z447b1Su', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Z447b1Su', N'DV007', 2, 10000, N'Bịch', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Z447b1Su', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Z447b1Su', N'DV011', 1, 16000, N'Lon', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV002', 3, 14000, N'Lon', 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV005', 1, 12000, N'Lon', 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV007', 2, 10000, N'Bịch', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV010', 1, 18000, N'Chai', 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV011', 1, 16000, N'Lon', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV014', 1, 14000, N'Chai', 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'ZFLh6kO2', N'DV017', 4, 18000, N'Chai', 72000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Zmj4qit6', N'DV004', 2, 10000, N'Chai', 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Zmj4qit6', N'DV005', 2, 12000, N'Lon', 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Zmj4qit6', N'DV006', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Zmj4qit6', N'DV007', 1, 10000, N'Bịch', 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Zmj4qit6', N'DV008', 1, 16000, N'Chai', 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaDV], [SoLuong], [DonGia], [DVT], [ThanhTien]) VALUES (N'Zmj4qit6', N'DV009', 1, 17000, N'Chai', 17000)
INSERT [dbo].[CTHD_Tam] ([MaPV], [MaDV], [SoLuong], [DonViTinh]) VALUES (N'g0v2mIWH', N'DV001', 2, N'Đĩa')
INSERT [dbo].[CTHD_Tam] ([MaPV], [MaDV], [SoLuong], [DonViTinh]) VALUES (N'g0v2mIWH', N'DV003', 1, N'Lon')
INSERT [dbo].[CTHD_Tam] ([MaPV], [MaDV], [SoLuong], [DonViTinh]) VALUES (N'g0v2mIWH', N'DV004', 1, N'Chai')
INSERT [dbo].[CTHD_Tam] ([MaPV], [MaDV], [SoLuong], [DonViTinh]) VALUES (N'g0v2mIWH', N'DV005', 3, N'Lon')
INSERT [dbo].[CTHD_Tam] ([MaPV], [MaDV], [SoLuong], [DonViTinh]) VALUES (N'g0v2mIWH', N'DV006', 2, N'Bịch')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV06t9K1CR', N'DV016', 15, 21000, N'Chai')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV0vs5MYht', N'DV001', 5, 500000, N'Đĩa')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV0vs5MYht', N'DV004', 10, 10, N'10')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV4lPUO4VI', N'DV007', 10, 12000, N'Bịch')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV4lPUO4VI', N'DV016', 100, 10000, N'Lon')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV4tVv0434', N'DV001', 10, 50000, N'Đĩa')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV4tVv0434', N'DV002', 20, 10000, N'lon')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV4tVv0434', N'DV018', 20, 10000, N'lon')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DV91YMQMAn', N'DV001', 20, 60000, N'đĩa')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DVb4mOL6fA', N'DV004', 10, 10, N'10')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DVInC4H6Zo', N'DV017', 10, 15000, N'Chai')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DVK59RG5AC', N'DV004', 10, 50000, N'chai')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DVXlPqc0W3', N'DV002', 10, 10000, N'Lon')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DVXlPqc0W3', N'DV004', 10, 8000, N'Chai')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DVYM8eJ652', N'DV002', 50, 11000, N'Lon')
INSERT [dbo].[CTPN_DichVu] ([MaPN_DichVu], [MaDichVu], [SL_DichVuNhap], [DG_DichVuNhap], [DVT_DichVuNhap]) VALUES (N'DVYM8eJ652', N'DV004', 100, 8000, N'Chai')
INSERT [dbo].[CTPN_ThietBi] ([MaPN_ThietBi], [MaTB], [SL_ThietBiNhap], [DG_ThietBiNhap]) VALUES (N'PN001', N'TB01', 1, 1000000)
INSERT [dbo].[CTPN_ThietBi] ([MaPN_ThietBi], [MaTB], [SL_ThietBiNhap], [DG_ThietBiNhap]) VALUES (N'TBrt8jAttE', N'TB01', 10, 100)
INSERT [dbo].[CTPN_ThietBi] ([MaPN_ThietBi], [MaTB], [SL_ThietBiNhap], [DG_ThietBiNhap]) VALUES (N'TBV9nRv5ue', N'TB01', 2, 500000)
INSERT [dbo].[CTPN_ThietBi] ([MaPN_ThietBi], [MaTB], [SL_ThietBiNhap], [DG_ThietBiNhap]) VALUES (N'TBV9nRv5ue', N'TB02', 3, 800000)
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [TenKhachDat], [SDT_Khach], [GioNhanPhong], [TienCoc], [GhiChu]) VALUES (N'3sL41g9I', N'103', N'Hiệp', N'0987627918', CAST(0x0000AB2700CF912F AS DateTime), 50000, N'5h')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV001', N'Đĩa Trái Cây', 32, 60000, 50000, N'Đĩa')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV002', N'Sting', 94, 10000, 14000, N'Lon')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV003', N'Cocacola', 42, 10000, 14000, N'Lon')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV004', N'Nước Suối', 84, 50000, 10000, N'Chai')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV005', N'7up', 31, 10000, 12000, N'Lon')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV006', N'Snack', 17, 8000, 10000, N'Bịch')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV007', N'Đậu Phộng', 14, 7000, 10000, N'Bịch')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV008', N'Bia Sài Gòn', 25, 14000, 16000, N'Chai')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV009', N'Bia Heniken', 58, 15000, 17000, N'Chai')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV010', N'Bia Tiger', 44, 16000, 18000, N'Chai')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV011', N'Bia 333', 48, 14000, 16000, N'Lon')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV012', N'Pepsi', 47, 10000, 12000, N'Lon')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV013', N'Redbull', 78, 13000, 15000, N'Lon')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV014', N'Trà ô long', 73, 12000, 14000, N'Chai')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV015', N'Trà C2', 83, 10000, 12000, N'Chai')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV016', N'Bia Hà Nội', 31, 14000, 18000, N'Lon')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV017', N'Ô Long', 78, 15000, 18000, N'Chai')
INSERT [dbo].[DichVu] ([MaDV], [TenDichVu], [SoLuong], [DonGiaNhap], [DonGiaBan], [DVT]) VALUES (N'DV018', N'abc', 20, 10000, 15000, N'bịch')
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'04fFCC9g', N'0368728719', N'205', N'NV002', CAST(0x0000AB0700E75964 AS DateTime), CAST(0x0000AB0700E96D1C AS DateTime), N'PT03', 0, 0, 0, 235500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'0YvOR921', N'0965564533', N'104', N'NV002', CAST(0x0000AB2600A7B854 AS DateTime), CAST(0x0000AB2600A8F542 AS DateTime), N'PT01', 0, 0, 0, 351500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'3vX5781M', N'0936173671', N'202', N'NV002', CAST(0x0000AB2500EA6A8C AS DateTime), CAST(0x0000AB2500EB611B AS DateTime), N'PT01', 0, 0, 0, 230500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'4syeAroe', N'1432433333', N'101', N'NV002', CAST(0x0000AB2600A9EF84 AS DateTime), CAST(0x0000AB2600AA1081 AS DateTime), N'PT02', 10000, 0, 0, 74000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'56v6tRFi', N'0928157287', N'102', N'NV002', CAST(0x0000AB2600B2CE9C AS DateTime), CAST(0x0000AB2700B9D8AA AS DateTime), N'PT01', 0, 0, 0, 3792500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'5W41NBl9', N'0928157287', N'105', N'NV002', CAST(0x0000AB2500ED3690 AS DateTime), CAST(0x0000AB2500ED83BA AS DateTime), N'PT01', 40000, 0, 0, 70500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'62aLnK3Z', N'0977826513', N'203', N'NV002', CAST(0x0000AB2500E79078 AS DateTime), CAST(0x0000AB2500E9B8F6 AS DateTime), N'PT01', 0, 100000, 0, 160500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'7399xKZQ', N'0927121821', N'103', N'NV002', CAST(0x0000AB2600ACAD78 AS DateTime), CAST(0x0000AB2600ACD690 AS DateTime), N'PT01', 0, 0, 0, 102500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'8TDUGHbd', N'0928157287', N'305', N'NV002', CAST(0x0000AB2500E89374 AS DateTime), CAST(0x0000AB2500E97E2D AS DateTime), N'PT01', 40000, 0, 0, 161000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'AbfT5oP3', N'0368728719', N'103', N'NV002', CAST(0x0000AB2500E6D174 AS DateTime), CAST(0x0000AB2500E94C1B AS DateTime), N'PT01', 0, 0, 0, 135500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'b6d59JrN', N'0928157287', N'305', N'NV002', CAST(0x0000AB2500E98D10 AS DateTime), CAST(0x0000AB2500EA57F4 AS DateTime), N'PT01', 40000, 0, 0, 63000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'Bmpy56K5', N'0834288442', N'203', N'NV002', CAST(0x0000AB2500EB9C68 AS DateTime), CAST(0x0000AB2500ED423A AS DateTime), N'PT01', 0, 0, 0, 97000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'coFtf33a', N'0928157287', N'105', N'NV002', CAST(0x0000AB2500EC3F4C AS DateTime), CAST(0x0000AB2500ECD981 AS DateTime), N'PT01', 40000, 0, 0, 5000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'eP976LE6', N'0367298988', N'103', N'NV002', CAST(0x0000AB2500EE3284 AS DateTime), CAST(0x0000AB2500FEC837 AS DateTime), N'PT01', 0, 100000, 0, 128000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'hLXQ8YQE', N'0129689245', N'102', N'NV002', CAST(0x0000AB250105B418 AS DateTime), CAST(0x0000AB250166B8F5 AS DateTime), N'PT01', 0, 0, 0, 1037000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'if9BwL9h', N'0367298988', N'203', N'NV002', CAST(0x0000AB2500EA7C20 AS DateTime), CAST(0x0000AB2500EB4DD4 AS DateTime), N'PT01', 0, 0, 0, 212500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'Jd885tbj', N'0928157287', N'305', N'NV002', CAST(0x0000AB2500EB4808 AS DateTime), CAST(0x0000AB2500EBDF75 AS DateTime), N'PT01', 40000, 0, 0, 101000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'r547166H', N'0928157287', N'105', N'NV002', CAST(0x0000AB2500ECE6E0 AS DateTime), CAST(0x0000AB2500ED2B53 AS DateTime), N'PT01', 40000, 0, 0, 56500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'T0NT5Dhx', N'0834288442', N'103', N'NV002', CAST(0x0000AB2500EA0114 AS DateTime), CAST(0x0000AB2500EB541D AS DateTime), N'PT03', 0, 0, 0, 298500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'uTq4o4OA', N'0129689245', N'104', N'NV002', CAST(0x0000AB2600A96D70 AS DateTime), CAST(0x0000AB2600A9A5B5 AS DateTime), N'PT03', 0, 0, 0, 252500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'Vc6A37z6', N'0799746176', N'202', N'NV002', CAST(0x0000AB2500EE1FC4 AS DateTime), CAST(0x0000AB250166C883 AS DateTime), N'PT02', 0, 0, 0, 1261000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'wCgw2sT8', N'0986564967', N'203', N'NV002', CAST(0x0000AB25010B9978 AS DateTime), CAST(0x0000AB2501668A08 AS DateTime), N'PT01', 50000, 0, 0, 903500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'WkV41W4S', N'0367298988', N'104', N'NV002', CAST(0x0000AAE800EA94BC AS DateTime), CAST(0x0000AAE800EB5A6D AS DateTime), N'PT02', 0, 0, 0, 237000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'X605A9C5', N'0927121821', N'303', N'NV002', CAST(0x0000AB0700E6DF84 AS DateTime), CAST(0x0000AB0700E9730E AS DateTime), N'PT01', 0, 100000, 0, 166000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'Y6sJx0KX', N'0834288442', N'301', N'NV002', CAST(0x0000AB2500E77EE4 AS DateTime), CAST(0x0000AB2500E978FB AS DateTime), N'PT02', 0, 100000, 0, 221000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'Z447b1Su', N'0367298988', N'101', N'NV002', CAST(0x0000AB0700E6C5BC AS DateTime), CAST(0x0000AB0700E962F4 AS DateTime), N'PT01', 0, 100000, 0, 96500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'ZFLh6kO2', N'0367298988', N'201', N'NV002', CAST(0x0000AAE800E9DCC0 AS DateTime), CAST(0x0000AAE800EB5DBA AS DateTime), N'PT01', 0, 0, 0, 222500)
INSERT [dbo].[HoaDon] ([MaHD], [SDT_KhachHang], [MaPhong], [MaNV], [GioBatDau], [GioKetThuc], [MaPhuThu], [TienCoc], [KhuyenMai], [TienDenBu], [TongTien]) VALUES (N'Zmj4qit6', N'0834288442', N'105', N'NV002', CAST(0x0000AAE800E6EC68 AS DateTime), CAST(0x0000AAE800E954E5 AS DateTime), N'PT02', 0, 0, 0, 169500)
INSERT [dbo].[HoaDon_Tam] ([MaPhucVu], [MaPhong], [SDT_KH], [GioBD], [TienDatCoc]) VALUES (N'g0v2mIWH', N'103', N'0794881672', CAST(0x0000AB2700CF8CFF AS DateTime), 0)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Khâu Tấn Đạt', N'0129689245', 2)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Tiến', N'0367298988', 0)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Phương', N'0368728719', 2)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Long', N'0783482688', 2)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Nhất', N'0794881672', 3)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Lâm', N'0799746176', 2)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Thắng', N'0834288442', 2)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Bi', N'0927121821', 1)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Phú', N'0928157287', 3)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Hiệp gà', N'0936173671', 2)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Hiệp', N'0953787628', 3)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Phức', N'0965564533', 1)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Thắng', N'0973645726', 3)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Hiền', N'0977826513', 0)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Phúc', N'0981367261', 1)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Hiệp', N'0986564967', 1)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'Hiệp', N'0987625671', 0)
INSERT [dbo].[KhachHang] ([TenKH], [SDT], [TichDiem]) VALUES (N'nguyen thanh hoang', N'1432433333', 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (N'LP01', N'VIP')
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (N'LP02', N'Thường')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV001', N'Phan Văn Thắng', N'Nam', CAST(0x94210B00 AS Date), N'Quảng Trị', N'0373388698', N'2511482987', CAST(0x2A3F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV002', N'Phạm Văn Hiệp', N'Nam', CAST(0x71210B00 AS Date), N'TP.HCM', N'0363789978', N'2511647893', CAST(0x603F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV003', N'Trần Thị Lan', N'Nữ', CAST(0x97240B00 AS Date), N'TP.HCM', N'0986725481', N'2178390361', CAST(0x373F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV004', N'Nguyễn Trần Lan Anh', N'Nữ', CAST(0x16230B00 AS Date), N'TP.HCM', N'0749263718', N'2017874263', CAST(0x573F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV005', N'Lê Vũ Linh', N'Nam', CAST(0xB4230B00 AS Date), N'TP.HCM', N'0973682369', N'308672819 ', CAST(0x6F3F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV006', N'Khâu Tấn Đạt', N'Nam', CAST(0x07240B00 AS Date), N'TP.HCM', N'0987378167', N'6736123619', CAST(0x2A3F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV007', N'Nguyễn Thị Hương', N'Nữ', CAST(0x07240B00 AS Date), N'Quảng Trị', N'0989371623', N'6786131638', CAST(0x2B3F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV008', N'Lê Trọng Hiếu', N'Nam', CAST(0x87210B00 AS Date), N'Long An', N'0938137789', N'7917329879', CAST(0x2B3F0B00 AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [CMND], [NgayVaoLam]) VALUES (N'NV009', N'le huynh thach', N'Nam', CAST(0x94210B00 AS Date), N'khanh hoa', N'3         ', N'3         ', CAST(0x2A3F0B00 AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DV06t9K1CR', N'NV001', CAST(0x4F400B00 AS Date), 315000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DV0vs5MYht', N'NV001', CAST(0x4D400B00 AS Date), 110)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DV4lPUO4VI', N'NV001', CAST(0x6C400B00 AS Date), 1120000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DV4tVv0434', N'NV002', CAST(0x81400B00 AS Date), 900000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DV91YMQMAn', N'NV002', CAST(0x81400B00 AS Date), 1200000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DVb4mOL6fA', N'NV001', CAST(0x5D400B00 AS Date), 100)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DVInC4H6Zo', N'NV001', CAST(0x5D400B00 AS Date), 150000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DVK59RG5AC', N'NV002', CAST(0x82400B00 AS Date), 500000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DVXlPqc0W3', N'NV001', CAST(0x50400B00 AS Date), 180000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'DVYM8eJ652', N'NV002', CAST(0x80400B00 AS Date), 1350000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'PN001', N'NV001', CAST(0x2B3F0B00 AS Date), 1000000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'PN002', N'NV001', CAST(0x2A3F0B00 AS Date), 500000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'TBrt8jAttE', N'NV001', CAST(0x4F400B00 AS Date), 1000)
INSERT [dbo].[PhieuNhap] ([MaPhieNhap], [MaNhanVien], [NgayNhap], [TongPN]) VALUES (N'TBV9nRv5ue', N'NV001', CAST(0x4E400B00 AS Date), 3900000)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'101', N'LP02', 2500, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'102', N'LP02', 2500, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'103', N'LP02', 2500, N'Đang Hát')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'104', N'LP02', 2500, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'105', N'LP02', 2500, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'201', N'LP02', 2500, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'202', N'LP02', 2500, N'Đang Dọn')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'203', N'LP02', 2500, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'204', N'LP02', 2500, N'Bảo Trì')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'205', N'LP02', 2500, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'301', N'LP01', 4000, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'302', N'LP01', 4000, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'303', N'LP01', 4000, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'304', N'LP01', 4000, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'305', N'LP01', 4000, N'Trống')
INSERT [dbo].[PhuThu] ([MaPhuThu], [TenPhuThu], [SoTien]) VALUES (N'PT01', N'Thứ 2 -Thứ 6', 0)
INSERT [dbo].[PhuThu] ([MaPhuThu], [TenPhuThu], [SoTien]) VALUES (N'PT02', N'Thứ 7, Chủ Nhật', 50000)
INSERT [dbo].[PhuThu] ([MaPhuThu], [TenPhuThu], [SoTien]) VALUES (N'PT03', N'Ngày Lễ', 100000)
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN01', N'Giao diện làm việc chính')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN02', N'Sắp xếp')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN03', N'Quản lý khách hàng - đồ thất lạc')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN04', N'Quản lý khách hàng - QL khách hàng')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN05', N'Quản lý phòng - thông tin phòng')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN06', N'Quản lý phòng - thiết bị phòng')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN07', N'Quản lý phòng - lịch đặt phòng')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN08', N'Quản lý kho - kho thiết bị')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN09', N'Quản lý kho - đồ ăn thức uống')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN10', N'Quản lý nhân viên - QL tài khoản')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN11', N'Quản lý nhân viên - QL nhân viên')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN12', N'Quản lý nhập kho - nhập kho')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN13', N'Quản lý nhập kho - nhập thiết bị')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN14', N'Báo cáo thống kê - khoản thu')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN15', N'Báo cáo thống kê - khoản chi')
INSERT [dbo].[QL_ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN16', N'Báo cáo thống kê - chi tiết phiếu nhập')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHOM01', N'Quản Lý', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHOM02', N'Tiếp Tân', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHOM03', N'Nhân Viên Kho', N'Kho')
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN04', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN09', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN10', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN11', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN15', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM01', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN04', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN10', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN11', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN15', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM02', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN01', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN02', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN03', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN04', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN05', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN07', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN08', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN10', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN11', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN12', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN13', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN14', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN15', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaChucNang], [CoQuyen]) VALUES (N'NHOM03', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN04', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN08', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN10', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN11', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN12', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN13', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN15', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN04', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN09', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN10', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN11', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN15', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'admin1', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN04', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN10', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN11', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN15', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN04', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN10', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN11', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN15', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien1', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN01', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN02', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN03', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN04', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN05', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN07', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN08', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN10', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN11', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN12', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN13', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN14', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN15', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien2', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN01', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN02', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN03', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN04', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN05', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN07', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN08', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN10', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN11', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN12', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN13', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN14', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN15', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien3', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN04', 1)
GO
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN09', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN10', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN11', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN15', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien4', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN01', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN02', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN03', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN04', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN05', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN06', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN07', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN09', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN10', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN11', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN14', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN15', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'nhanvien5', N'CN16', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN01', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN02', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN03', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN04', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN05', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN06', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN07', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN08', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN09', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN10', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN11', 1)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN12', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN13', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN14', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN15', 0)
INSERT [dbo].[QL_PhanQuyenTaiKhoan] ([TenDN], [MaCN], [Quyen]) VALUES (N'thach123', N'CN16', 0)
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'admin', N'1', N'NV002', 1, N'NHOM02')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'admin1', N'11111', N'NV001', 1, N'NHOM01')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'nhanvien', N'11111', N'NV003', 1, N'NHOM02')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'nhanvien1', N'11111', N'NV004', 1, N'NHOM02')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'nhanvien2', N'11111', N'NV005', 1, N'NHOM03')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'nhanvien3', N'11111', N'NV006', 1, N'NHOM03')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'nhanvien4', N'11111', N'NV007', 1, N'NHOM02')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'nhanvien5', N'11111', N'NV008', 1, N'NHOM01')
INSERT [dbo].[QL_TaiKhoan] ([TenDangNhap], [MatKhau], [MaNV], [HoatDong], [NhomNguoiDung]) VALUES (N'thach123', N'11111', N'NV009', 1, N'NHOM01')
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB01', N'TIVI 40 inch', 35)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB02', N'TIVI 50 inch', 10)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB03', N'Máy Lạnh', 19)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB04', N'Bàn', 28)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB05', N'Ghế sofa dài', 44)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB06', N'Ghế sofa đơn', 40)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB07', N'Mic có dây', 30)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB08 ', N'Mic không dây', 30)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB09', N'Quạt Trần', 15)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB10', N'Loa', 40)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB11', N'Đầu Hát Karaoke', 20)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB12', N'Màn Hình Cảm Ứng', 20)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB13', N'Máy Tính Bảng', 20)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB14', N'Đèn Trang Trí', 50)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB01', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB03', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB05', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB06', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB07', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB10', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'101', N'TB14', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB01', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB03', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB05', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB06', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB07', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB10', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'102', N'TB14', 4)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB01', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB03', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB05', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB07', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB08', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB10', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'103', N'TB14', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB01', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB03', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB05', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB06', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB07', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB10', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'104', N'TB14', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB01', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB03', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB05', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB07', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB10', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'105', N'TB14', 4)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'201', N'TB02', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'201', N'TB04', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'203', N'TB03', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'203', N'TB04', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'203', N'TB05', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB01', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB02', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB03', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB04', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB05', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB08', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB10', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'301', N'TB14', 5)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB02', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB03', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB05', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB06', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB08', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB10', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'302', N'TB14', 5)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB02', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB03', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB05', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB06', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB08', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB10', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'303', N'TB14', 5)
GO
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB02', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB03', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB05', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB08', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB10', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'304', N'TB14', 5)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB02', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB03', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB04', 2)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB05', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB08', 3)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB09', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB10', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB11', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB12', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB13', 1)
INSERT [dbo].[ThietBi_Phong] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'305', N'TB14', 5)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_DichVu]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Hoa_Don] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Hoa_Don]
GO
ALTER TABLE [dbo].[CTHD_Tam]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_Tam_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTHD_Tam] CHECK CONSTRAINT [FK_CTHD_Tam_DichVu]
GO
ALTER TABLE [dbo].[CTHD_Tam]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_Tam_HoaDon_Tam] FOREIGN KEY([MaPV])
REFERENCES [dbo].[HoaDon_Tam] ([MaPhucVu])
GO
ALTER TABLE [dbo].[CTHD_Tam] CHECK CONSTRAINT [FK_CTHD_Tam_HoaDon_Tam]
GO
ALTER TABLE [dbo].[CTPN_DichVu]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_DichVu_DichVu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTPN_DichVu] CHECK CONSTRAINT [FK_CTPN_DichVu_DichVu]
GO
ALTER TABLE [dbo].[CTPN_DichVu]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_DichVu_PhieuNhap] FOREIGN KEY([MaPN_DichVu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieNhap])
GO
ALTER TABLE [dbo].[CTPN_DichVu] CHECK CONSTRAINT [FK_CTPN_DichVu_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPN_ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_ThietBi_PhieuNhap] FOREIGN KEY([MaPN_ThietBi])
REFERENCES [dbo].[PhieuNhap] ([MaPhieNhap])
GO
ALTER TABLE [dbo].[CTPN_ThietBi] CHECK CONSTRAINT [FK_CTPN_ThietBi_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPN_ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_ThietBi_ThietBi] FOREIGN KEY([MaTB])
REFERENCES [dbo].[ThietBi] ([MaThietBi])
GO
ALTER TABLE [dbo].[CTPN_ThietBi] CHECK CONSTRAINT [FK_CTPN_ThietBi_ThietBi]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_Phong]
GO
ALTER TABLE [dbo].[DoThatLac]  WITH CHECK ADD  CONSTRAINT [FK_DoThatLac_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DoThatLac] CHECK CONSTRAINT [FK_DoThatLac_Phong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Hoa_Don_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_PhuThu] FOREIGN KEY([MaPhuThu])
REFERENCES [dbo].[PhuThu] ([MaPhuThu])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Hoa_Don_PhuThu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([SDT_KhachHang])
REFERENCES [dbo].[KhachHang] ([SDT])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Phong]
GO
ALTER TABLE [dbo].[HoaDon_Tam]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Tam_KhachHang] FOREIGN KEY([SDT_KH])
REFERENCES [dbo].[KhachHang] ([SDT])
GO
ALTER TABLE [dbo].[HoaDon_Tam] CHECK CONSTRAINT [FK_HoaDon_Tam_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon_Tam]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Tam_Phong1] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HoaDon_Tam] CHECK CONSTRAINT [FK_HoaDon_Tam_Phong1]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_QL_PhanQuyen_QL_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[QL_ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[QL_PhanQuyen] CHECK CONSTRAINT [FK_QL_PhanQuyen_QL_ChucNang]
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_QL_PhanQuyen_QL_NhomNguoiDung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[QL_PhanQuyen] CHECK CONSTRAINT [FK_QL_PhanQuyen_QL_NhomNguoiDung]
GO
ALTER TABLE [dbo].[QL_PhanQuyenTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_QL_PhanQuyenTaiKhoan_QL_ChucNang] FOREIGN KEY([MaCN])
REFERENCES [dbo].[QL_ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[QL_PhanQuyenTaiKhoan] CHECK CONSTRAINT [FK_QL_PhanQuyenTaiKhoan_QL_ChucNang]
GO
ALTER TABLE [dbo].[QL_PhanQuyenTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_QL_PhanQuyenTaiKhoan_QL_TaiKhoan] FOREIGN KEY([TenDN])
REFERENCES [dbo].[QL_TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[QL_PhanQuyenTaiKhoan] CHECK CONSTRAINT [FK_QL_PhanQuyenTaiKhoan_QL_TaiKhoan]
GO
ALTER TABLE [dbo].[QL_TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_QL_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[QL_TaiKhoan] CHECK CONSTRAINT [FK_QL_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[QL_TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_QL_TaiKhoan_QL_NhomNguoiDung] FOREIGN KEY([NhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[QL_TaiKhoan] CHECK CONSTRAINT [FK_QL_TaiKhoan_QL_NhomNguoiDung]
GO
ALTER TABLE [dbo].[ThietBi_Phong]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_Phong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[ThietBi_Phong] CHECK CONSTRAINT [FK_ThietBi_Phong_Phong]
GO
ALTER TABLE [dbo].[ThietBi_Phong]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_Phong_ThietBi] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[ThietBi] ([MaThietBi])
GO
ALTER TABLE [dbo].[ThietBi_Phong] CHECK CONSTRAINT [FK_ThietBi_Phong_ThietBi]
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanKaraoke] SET  READ_WRITE 
GO
