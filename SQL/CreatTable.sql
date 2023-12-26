USE [d75]
GO

/****** Object:  Table [dbo].[tbl_CTH]    Script Date: 12/26/2023 1:53:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_CTH](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenDiemCau] [nvarchar](50) NULL,
	[DonViQL] [nvarchar](50) NULL,
	[TTTH] [nvarchar](50) NULL,
	[IP] [nvarchar](max) NULL,
	[SubNet] [nvarchar](50) NULL,
	[GetWay] [nvarchar](50) NULL,
	[Vlan] [nvarchar](50) NULL,
	[PortTD_CTH] [nvarchar](50) NULL,
	[PortTD_TTTH] [nvarchar](50) NULL,
	[SwL2_TD] [nvarchar](50) NULL,
	[SwL2_BM] [nvarchar](50) NULL,
	[SwL3] [nvarchar](50) NULL,
	[PatchL2] [nvarchar](50) NULL,
	[PatchL3] [nvarchar](50) NULL,
	[TBTC] [nvarchar](50) NULL,
	[DTDD] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TenTrangBi] [nvarchar](50) NULL,
	[Serial] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Micro] [nvarchar](50) NULL,
	[Loa] [nvarchar](50) NULL,
	[UPS] [nvarchar](50) NULL,
	[HienThi] [nvarchar](50) NULL,
	[ThietBiDuPhong] [nvarchar](max) NULL,
	[HinhAnh1] [varbinary](max) NULL,
	[HinhAnh2] [varbinary](max) NULL,
	[HinhAnh3] [varbinary](max) NULL,
	[HinhAnh4] [varbinary](max) NULL,
 CONSTRAINT [PK_DiemCauTruyenHinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

