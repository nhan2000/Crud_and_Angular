USE [Nawab]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/4/2021 12:39:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[f_name] [nvarchar](100) NULL,
	[m_name] [nvarchar](100) NULL,
	[l_name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[birthDate] [nvarchar](100) NULL,
	[score] [nvarchar](100) NULL,
	[dep_id] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [f_name], [m_name], [l_name], [address], [birthDate], [score], [dep_id]) VALUES (2, N'Day', N'la', N'toi', N'Quang Ngai', N'10/02/2000', N'7', NULL)
INSERT [dbo].[Student] ([Id], [f_name], [m_name], [l_name], [address], [birthDate], [score], [dep_id]) VALUES (3, N'Nguyen', N'nhan', N'hao', N'Binh Dinh', N'2/02/2000', N'8', NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
