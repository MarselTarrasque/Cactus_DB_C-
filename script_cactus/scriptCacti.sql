USE [Collection_of_rare_cacti]
GO
/****** Object:  Table [dbo].[Cactus]    Script Date: 21.09.2024 8:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cactus](
	[ID_Cactus] [int] IDENTITY(1,1) NOT NULL,
	[Name_Cactus] [nvarchar](50) NULL,
	[Type_of_cactus] [nvarchar](50) NULL,
	[Age_cactus] [int] NULL,
	[Origins_cactus] [nvarchar](50) NULL,
	[Cost_cactus] [int] NULL,
	[Manuals_cactus] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cactus] PRIMARY KEY CLUSTERED 
(
	[ID_Cactus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contestant]    Script Date: 21.09.2024 8:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contestant](
	[ID_Cactus] [int] NOT NULL,
	[ID_Exibition] [int] NULL,
	[ID_Constestant] [int] NOT NULL,
 CONSTRAINT [PK_Contestant] PRIMARY KEY CLUSTERED 
(
	[ID_Constestant] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exibitions]    Script Date: 21.09.2024 8:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exibitions](
	[ID_Exibition] [int] IDENTITY(1,1) NOT NULL,
	[Name_Exibition] [nvarchar](50) NULL,
	[Date_Exibition] [date] NULL,
	[Place_Exibition] [nvarchar](50) NULL,
	[Rewards_Exibition] [nvarchar](50) NULL,
	[Commentaries] [nvarchar](50) NULL,
 CONSTRAINT [PK_Exibitions] PRIMARY KEY CLUSTERED 
(
	[ID_Exibition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rewarded_Cactuses]    Script Date: 21.09.2024 8:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rewarded_Cactuses](
	[ID_RewardCactuses] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cactus] [int] NULL,
	[ID_Exibition] [int] NULL,
 CONSTRAINT [PK_Rewarded_Cactuses] PRIMARY KEY CLUSTERED 
(
	[ID_RewardCactuses] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cactus] ON 

INSERT [dbo].[Cactus] ([ID_Cactus], [Name_Cactus], [Type_of_cactus], [Age_cactus], [Origins_cactus], [Cost_cactus], [Manuals_cactus]) VALUES (1023, N'dsadаывавы', N'Цереус', 32, N'авыаыв', 432432, N'авыавыавы')
INSERT [dbo].[Cactus] ([ID_Cactus], [Name_Cactus], [Type_of_cactus], [Age_cactus], [Origins_cactus], [Cost_cactus], [Manuals_cactus]) VALUES (2026, N'fsdfsdf', N'Нотокактус', 4332, N'fdsfsdfsd', 432432, N'fdsfsd')
INSERT [dbo].[Cactus] ([ID_Cactus], [Name_Cactus], [Type_of_cactus], [Age_cactus], [Origins_cactus], [Cost_cactus], [Manuals_cactus]) VALUES (2027, N'fsdfds', N'Нотокактус', 432, N'fsdfs', 432423, N'fsdfds')
SET IDENTITY_INSERT [dbo].[Cactus] OFF
GO
SET IDENTITY_INSERT [dbo].[Exibitions] ON 

INSERT [dbo].[Exibitions] ([ID_Exibition], [Name_Exibition], [Date_Exibition], [Place_Exibition], [Rewards_Exibition], [Commentaries]) VALUES (1002, N'fdsfsdfsd', CAST(N'2024-09-27' AS Date), N'Москва', N'Удобрения', N'КОММ')
SET IDENTITY_INSERT [dbo].[Exibitions] OFF
GO
ALTER TABLE [dbo].[Contestant]  WITH CHECK ADD  CONSTRAINT [FK_Contestant_Cactus] FOREIGN KEY([ID_Cactus])
REFERENCES [dbo].[Cactus] ([ID_Cactus])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contestant] CHECK CONSTRAINT [FK_Contestant_Cactus]
GO
ALTER TABLE [dbo].[Contestant]  WITH CHECK ADD  CONSTRAINT [FK_Contestant_Exibitions] FOREIGN KEY([ID_Exibition])
REFERENCES [dbo].[Exibitions] ([ID_Exibition])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contestant] CHECK CONSTRAINT [FK_Contestant_Exibitions]
GO
ALTER TABLE [dbo].[Rewarded_Cactuses]  WITH CHECK ADD  CONSTRAINT [FK_Rewarded_Cactuses_Cactus] FOREIGN KEY([ID_Cactus])
REFERENCES [dbo].[Cactus] ([ID_Cactus])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Rewarded_Cactuses] CHECK CONSTRAINT [FK_Rewarded_Cactuses_Cactus]
GO
ALTER TABLE [dbo].[Rewarded_Cactuses]  WITH CHECK ADD  CONSTRAINT [FK_Rewarded_Cactuses_Exibitions] FOREIGN KEY([ID_Exibition])
REFERENCES [dbo].[Exibitions] ([ID_Exibition])
GO
ALTER TABLE [dbo].[Rewarded_Cactuses] CHECK CONSTRAINT [FK_Rewarded_Cactuses_Exibitions]
GO
