CREATE DATABASE DB_KASIR

USE [DB_KASIR]
GO
/****** Object:  Table [dbo].[TBL_BARANG]    Script Date: 5/19/2025 3:45:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_BARANG](
	[KodeBarang] [nchar](6) NOT NULL,
	[NamaBarang] [nchar](150) NULL,
	[HargaJual] [numeric](18, 0) NULL,
	[HargaBeli] [numeric](18, 0) NULL,
	[JumlahBarang] [numeric](18, 0) NULL,
	[SatuanBarang] [nchar](50) NULL,
 CONSTRAINT [PK_TBL_BARANG] PRIMARY KEY CLUSTERED 
(
	[KodeBarang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_DETAILJUAL]    Script Date: 5/19/2025 3:45:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_DETAILJUAL](
	[DetailId] [int] IDENTITY(1,1) NOT NULL,
	[NoJual] [varchar](12) NULL,
	[KodeBarang] [varchar](6) NULL,
	[NamaBarang] [varchar](50) NULL,
	[HargaBarang] [numeric](18, 0) NULL,
	[JumlahJual] [numeric](18, 0) NULL,
	[SubTotal] [numeric](18, 0) NULL,
 CONSTRAINT [PK_TBL_DETAILJUAL] PRIMARY KEY CLUSTERED 
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_JUAL]    Script Date: 5/19/2025 3:45:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_JUAL](
	[NoJual] [varchar](12) NOT NULL,
	[TglJual] [datetime] NULL,
	[ItemJual] [numeric](18, 0) NULL,
	[TotalJual] [numeric](18, 0) NULL,
	[DiBayar] [numeric](18, 0) NULL,
	[Kembali] [numeric](18, 0) NULL,
	[KodeKasir] [varchar](6) NULL,
 CONSTRAINT [PK_TBL_JUAL] PRIMARY KEY CLUSTERED 
(
	[NoJual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_KASIR]    Script Date: 5/19/2025 3:45:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KASIR](
	[KodeKasir] [nchar](6) NOT NULL,
	[NamaKasir] [nchar](150) NULL,
	[PasswordKasir] [nchar](50) NULL,
	[LevelKasir] [nchar](50) NULL,
 CONSTRAINT [PK_TBL_KASIR] PRIMARY KEY CLUSTERED 
(
	[KodeKasir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TBL_BARANG] ([KodeBarang], [NamaBarang], [HargaJual], [HargaBeli], [JumlahBarang], [SatuanBarang]) VALUES (N'BRG002', N'KOPI KAPAL API 100gr                                                                                                                                  ', CAST(3000 AS Numeric(18, 0)), CAST(2000 AS Numeric(18, 0)), CAST(110 AS Numeric(18, 0)), N'PCS                                               ')
GO
INSERT [dbo].[TBL_BARANG] ([KodeBarang], [NamaBarang], [HargaJual], [HargaBeli], [JumlahBarang], [SatuanBarang]) VALUES (N'BRG003', N'GULA PASIR 1KG                                                                                                                                        ', CAST(6000 AS Numeric(18, 0)), CAST(5000 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), N'KILO                                              ')
GO
INSERT [dbo].[TBL_BARANG] ([KodeBarang], [NamaBarang], [HargaJual], [HargaBeli], [JumlahBarang], [SatuanBarang]) VALUES (N'BRG004', N'SUSU KENTAL MANIS                                                                                                                                     ', CAST(2500 AS Numeric(18, 0)), CAST(2000 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)), N'PCS                                               ')
GO
INSERT [dbo].[TBL_BARANG] ([KodeBarang], [NamaBarang], [HargaJual], [HargaBeli], [JumlahBarang], [SatuanBarang]) VALUES (N'BRG005', N'AQUA 1L                                                                                                                                               ', CAST(6000 AS Numeric(18, 0)), CAST(5000 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'BOTOL                                             ')
GO
INSERT [dbo].[TBL_KASIR] ([KodeKasir], [NamaKasir], [PasswordKasir], [LevelKasir]) VALUES (N'ADM001', N'ADMIN                                                                                                                                                 ', N'ADMIN                                             ', N'ADMIN                                             ')
GO
INSERT [dbo].[TBL_KASIR] ([KodeKasir], [NamaKasir], [PasswordKasir], [LevelKasir]) VALUES (N'KSR001', N'KASIR                                                                                                                                                 ', N'KASIR                                             ', N'KASIR                                             ')
GO
