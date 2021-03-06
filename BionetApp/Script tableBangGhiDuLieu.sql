USE [Bio]
GO
/****** Object:  Table [dbo].[BangGhiDuLieu]    Script Date: 11/01/2017 10:17:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGhiDuLieu](
	[MaDuLieu] [nvarchar](10) NOT NULL,
	[DuLieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangGhiDuLieu] PRIMARY KEY CLUSTERED 
(
	[MaDuLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BangGhiDuLieu] ([MaDuLieu], [DuLieu]) VALUES (N'MAXN1701', N'17010000')
