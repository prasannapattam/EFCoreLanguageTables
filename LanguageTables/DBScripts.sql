/****** Object:  Table [dbo].[Employee]    Script Date: 24-Jun-18 1:49:07 PM ******/
CREATE TABLE [dbo].[Employee](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_ar]    Script Date: 24-Jun-18 1:49:08 PM ******/
CREATE TABLE [dbo].[Employee_ar](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_ar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_en]    Script Date: 24-Jun-18 1:49:08 PM ******/
CREATE TABLE [dbo].[Employee_en](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_en] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_te]    Script Date: 24-Jun-18 1:49:08 PM ******/
CREATE TABLE [dbo].[Employee_te](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_te] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([Id], [Name]) VALUES (1, N'Ram - from default table')
GO
INSERT [dbo].[Employee] ([Id], [Name]) VALUES (2, N'Robert')
GO
INSERT [dbo].[Employee] ([Id], [Name]) VALUES (3, N'Rahim')
GO
INSERT [dbo].[Employee_ar] ([Id], [Name]) VALUES (1, N'Ram - from ar table')
GO
INSERT [dbo].[Employee_ar] ([Id], [Name]) VALUES (2, N'Robert')
GO
INSERT [dbo].[Employee_ar] ([Id], [Name]) VALUES (3, N'Rahim')
GO
INSERT [dbo].[Employee_en] ([Id], [Name]) VALUES (1, N'Ram - from en table')
GO
INSERT [dbo].[Employee_en] ([Id], [Name]) VALUES (2, N'Robert')
GO
INSERT [dbo].[Employee_en] ([Id], [Name]) VALUES (3, N'Rahim')
GO
INSERT [dbo].[Employee_te] ([Id], [Name]) VALUES (1, N'Ram - from te table')
GO
INSERT [dbo].[Employee_te] ([Id], [Name]) VALUES (2, N'Robert')
GO
INSERT [dbo].[Employee_te] ([Id], [Name]) VALUES (3, N'Rahim')
GO
