USE [QLTX]
GO
/****** Object:  Table [dbo].[ThongTinBanVe]    Script Date: 05/02/2018 06:22:30 ******/
DROP TABLE [dbo].[ThongTinBanVe]
GO
/****** Object:  Table [dbo].[ThongTinBanVe]    Script Date: 05/02/2018 06:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinBanVe](
	[MaGD] [nvarchar](10) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[MaTX] [nvarchar](10) NOT NULL,
	[TenTX] [nvarchar](50) NOT NULL,
	[MaVeNgay] [nvarchar](10) NOT NULL,
	[DG] [int] NOT NULL,
	[VePhatRa] [int] NOT NULL,
	[VeThuVao] [int] NOT NULL,
	[VeBanDuoc] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_ThongTinBanVe] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ThongTinBanVe] ([MaGD], [Ngay], [MaTX], [TenTX], [MaVeNgay], [DG], [VePhatRa], [VeThuVao], [VeBanDuoc], [ThanhTien]) VALUES (N'1212', CAST(0x00025B8100000000 AS DateTime), N'343434', N'NChó', N'1212', 333, 2354, 123, 2231, 742923)
INSERT [dbo].[ThongTinBanVe] ([MaGD], [Ngay], [MaTX], [TenTX], [MaVeNgay], [DG], [VePhatRa], [VeThuVao], [VeBanDuoc], [ThanhTien]) VALUES (N'121212', CAST(0x00009FEB00000000 AS DateTime), N'23T', N'Ð?c', N'12', 300, 100, 2, 98, 29400)
INSERT [dbo].[ThongTinBanVe] ([MaGD], [Ngay], [MaTX], [TenTX], [MaVeNgay], [DG], [VePhatRa], [VeThuVao], [VeBanDuoc], [ThanhTien]) VALUES (N'30', CAST(0x00009E5E00000000 AS DateTime), N'11', N'Kiểm', N'12', 100, 100, 20, 80, 8000)
INSERT [dbo].[ThongTinBanVe] ([MaGD], [Ngay], [MaTX], [TenTX], [MaVeNgay], [DG], [VePhatRa], [VeThuVao], [VeBanDuoc], [ThanhTien]) VALUES (N'GD1', CAST(0x0000A8CC00000000 AS DateTime), N'TX1', N'võ thành d?c', N'NO1', 3000, 5000, 2000, 3000, 9000000)
INSERT [dbo].[ThongTinBanVe] ([MaGD], [Ngay], [MaTX], [TenTX], [MaVeNgay], [DG], [VePhatRa], [VeThuVao], [VeBanDuoc], [ThanhTien]) VALUES (N'GD3', CAST(0x0000A00900000000 AS DateTime), N'TX1', N'NKi?m Toán', N'12', 23, 33, 12, 21, 483)
