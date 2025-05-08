CREATE DATABASE DB_KASIR

USE DB_KASIR
GO
/****** Object:  Table [dbo].[TBL_BARANG]    Script Date: 5/8/2025 7:22:11 PM ******/
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
/****** Object:  Table [dbo].[TBL_KASIR]    Script Date: 5/8/2025 7:22:11 PM ******/
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
INSERT [dbo].[TBL_KASIR] ([KodeKasir], [NamaKasir], [PasswordKasir], [LevelKasir]) VALUES (N'ADM001', N'ADMIN                                                                                                                                                 ', N'ADMIN                                             ', N'ADMIN                                             ')
GO
INSERT [dbo].[TBL_KASIR] ([KodeKasir], [NamaKasir], [PasswordKasir], [LevelKasir]) VALUES (N'KSR001', N'KASIR                                                                                                                                                 ', N'KASIR                                             ', N'KASIR                                             ')
GO
