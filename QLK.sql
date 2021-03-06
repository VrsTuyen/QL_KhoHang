USE [QuanLyKho]
GO
/****** Object:  Table [dbo].[tbl_HangHoa]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HangHoa](
	[Mahang] [char](10) NOT NULL,
	[Tenhang] [nvarchar](50) NULL,
	[Dongia] [int] NULL,
	[Soluong] [int] NULL,
	[DVT] [nchar](20) NULL,
	[Makho] [char](10) NULL,
 CONSTRAINT [PK_tbl_HangHoa] PRIMARY KEY CLUSTERED 
(
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[Mahoadon] [char](15) NOT NULL,
	[Makhach] [char](10) NULL,
	[Manhanvien] [char](10) NULL,
	[Ngaymua] [date] NULL,
	[Tongtien] [int] NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_HoaDonChiTiet]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDonChiTiet](
	[Mahoadon] [char](15) NOT NULL,
	[Mahang] [char](10) NULL,
	[Soluong] [int] NULL,
	[Dongia] [int] NULL,
	[Thanhtien] [int] NULL,
 CONSTRAINT [PK_tbl_HoaDonChiTiet] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[Makhach] [char](10) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[Dienthoai] [char](20) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Makhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_KhoHang]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhoHang](
	[Makho] [char](10) NOT NULL,
	[Tenkho] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_KhoHang] PRIMARY KEY CLUSTERED 
(
	[Makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[Manhanvien] [char](10) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [nchar](10) NULL,
	[Quequan] [nvarchar](50) NULL,
	[Sodienthoai] [char](15) NULL,
	[CMTND] [char](15) NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuNhap]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuNhap](
	[Maphieu] [char](15) NOT NULL,
	[Manhanvien] [char](10) NULL,
	[Ngaynhap] [date] NULL,
	[Tongtien] [int] NULL,
 CONSTRAINT [PK_tbl_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[Maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuNhapChiTiet]    Script Date: 3/14/2022 1:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuNhapChiTiet](
	[Maphieu] [char](15) NOT NULL,
	[Mahang] [char](10) NOT NULL,
	[Soluong] [int] NULL,
	[Dongia] [int] NULL,
	[Thanhtien] [int] NULL,
 CONSTRAINT [PK_PhieuNhapChiTiet] PRIMARY KEY CLUSTERED 
(
	[Maphieu] ASC,
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HangHoa_tbl_KhoHang] FOREIGN KEY([Makho])
REFERENCES [dbo].[tbl_KhoHang] ([Makho])
GO
ALTER TABLE [dbo].[tbl_HangHoa] CHECK CONSTRAINT [FK_tbl_HangHoa_tbl_KhoHang]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang] FOREIGN KEY([Makhach])
REFERENCES [dbo].[tbl_KhachHang] ([Makhach])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_NhanVien] FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[tbl_NhanVien] ([Manhanvien])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_HoaDonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDonChiTiet_tbl_HangHoa] FOREIGN KEY([Mahang])
REFERENCES [dbo].[tbl_HangHoa] ([Mahang])
GO
ALTER TABLE [dbo].[tbl_HoaDonChiTiet] CHECK CONSTRAINT [FK_tbl_HoaDonChiTiet_tbl_HangHoa]
GO
ALTER TABLE [dbo].[tbl_HoaDonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDonChiTiet_tbl_HoaDon] FOREIGN KEY([Mahoadon])
REFERENCES [dbo].[tbl_HoaDon] ([Mahoadon])
GO
ALTER TABLE [dbo].[tbl_HoaDonChiTiet] CHECK CONSTRAINT [FK_tbl_HoaDonChiTiet_tbl_HoaDon]
GO
ALTER TABLE [dbo].[tbl_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuNhap_tbl_NhanVien] FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[tbl_NhanVien] ([Manhanvien])
GO
ALTER TABLE [dbo].[tbl_PhieuNhap] CHECK CONSTRAINT [FK_tbl_PhieuNhap_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuNhapChiTiet_tbl_HangHoa] FOREIGN KEY([Mahang])
REFERENCES [dbo].[tbl_HangHoa] ([Mahang])
GO
ALTER TABLE [dbo].[tbl_PhieuNhapChiTiet] CHECK CONSTRAINT [FK_tbl_PhieuNhapChiTiet_tbl_HangHoa]
GO
ALTER TABLE [dbo].[tbl_PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuNhapChiTiet_tbl_PhieuNhap] FOREIGN KEY([Maphieu])
REFERENCES [dbo].[tbl_PhieuNhap] ([Maphieu])
GO
ALTER TABLE [dbo].[tbl_PhieuNhapChiTiet] CHECK CONSTRAINT [FK_tbl_PhieuNhapChiTiet_tbl_PhieuNhap]
GO
