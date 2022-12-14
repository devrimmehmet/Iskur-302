USE [School]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 10.11.2022 23:50:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Surname] [nvarchar](30) NULL,
	[StudentNumber] [nvarchar](20) NULL,
	[Phone] [nvarchar](15) NULL,
	[State] [nvarchar](20) NULL,
	[PhotoUrl] [nvarchar](200) NULL,
	[RegistrationDate] [datetime] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Surname], [StudentNumber], [Phone], [State], [PhotoUrl], [RegistrationDate]) VALUES (10, N'Devrim Mehmet', N'Pattabanoğlu', N'201213112050', N'(543) 819-4976', N'DONDURULMUŞ KAYIT', N'C:\Yedek\YedekKisisel\Cv\devrimmehmet.jpg', CAST(N'2022-11-08T17:23:02.000' AS DateTime))
INSERT [dbo].[Students] ([Id], [Name], [Surname], [StudentNumber], [Phone], [State], [PhotoUrl], [RegistrationDate]) VALUES (20, N'Devrim Mehmet', N'Pattabanoğlu', N'201213112051', N'(543) 819-4976', N'MEZUN', N'C:\Yedek\YedekKisisel\profil.jpg', CAST(N'2022-11-10T23:44:44.057' AS DateTime))
INSERT [dbo].[Students] ([Id], [Name], [Surname], [StudentNumber], [Phone], [State], [PhotoUrl], [RegistrationDate]) VALUES (21, N'Mısra', N'Yılmaz', N'202213502050', N'(543) 819-4976', N'ÖĞRENCİ', N'C:\Users\DevrimMehmet\Documents\GitHub\library-automation\Kutuphane-Yonetim-Paneli\Photo\41-BGQaEFbL._AC_SY1000_.jpg', CAST(N'2022-11-10T23:47:04.960' AS DateTime))
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_State]  DEFAULT (N'ÖĞRENCİ') FOR [State]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_RegistrationDate]  DEFAULT (getdate()) FOR [RegistrationDate]
GO
