USE [SisEvaluacion]
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 12/11/2019 11:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[Id_Item] [int] IDENTITY(1,1) NOT NULL,
	[Proveedor] [varchar](max) NULL,
	[Activo] [bit] NULL,
	[ISO_9001] [bit] NULL,
	[ISO_14000] [bit] NULL,
	[No_Expirado] [bit] NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[Id_Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemEvaluacion]    Script Date: 12/11/2019 11:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemEvaluacion](
	[Id_Item] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Precio] [int] NOT NULL,
	[Lote] [nvarchar](max) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Creado] [date] NOT NULL,
	[Fecha_Expiración] [date] NOT NULL,
 CONSTRAINT [PK__ItemEval__F325AAC4A4EB90F0] PRIMARY KEY CLUSTERED 
(
	[Id_Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Evaluacion] ON 

INSERT [dbo].[Evaluacion] ([Id_Item], [Proveedor], [Activo], [ISO_9001], [ISO_14000], [No_Expirado]) VALUES (1, N'Juan', 1, 0, 0, 0)
INSERT [dbo].[Evaluacion] ([Id_Item], [Proveedor], [Activo], [ISO_9001], [ISO_14000], [No_Expirado]) VALUES (2, N'Pedro', 1, 0, 0, 0)
INSERT [dbo].[Evaluacion] ([Id_Item], [Proveedor], [Activo], [ISO_9001], [ISO_14000], [No_Expirado]) VALUES (3, N'Maria', 1, 0, 0, 0)
INSERT [dbo].[Evaluacion] ([Id_Item], [Proveedor], [Activo], [ISO_9001], [ISO_14000], [No_Expirado]) VALUES (4, N'Jose', 1, 0, 0, 0)
INSERT [dbo].[Evaluacion] ([Id_Item], [Proveedor], [Activo], [ISO_9001], [ISO_14000], [No_Expirado]) VALUES (5, N'Papo', 1, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Evaluacion] OFF
SET IDENTITY_INSERT [dbo].[ItemEvaluacion] ON 

INSERT [dbo].[ItemEvaluacion] ([Id_Item], [Descripcion], [Precio], [Lote], [Activo], [Fecha_Creado], [Fecha_Expiración]) VALUES (1, N'Lata Habichuela', 70, N'001', 1, CAST(0x81340B00 AS Date), CAST(0xB44F0B00 AS Date))
INSERT [dbo].[ItemEvaluacion] ([Id_Item], [Descripcion], [Precio], [Lote], [Activo], [Fecha_Creado], [Fecha_Expiración]) VALUES (2, N'Lata Sopa Tomate', 58, N'002', 1, CAST(0x81340B00 AS Date), CAST(0x57430B00 AS Date))
INSERT [dbo].[ItemEvaluacion] ([Id_Item], [Descripcion], [Precio], [Lote], [Activo], [Fecha_Creado], [Fecha_Expiración]) VALUES (3, N'Lata Maiz', 60, N'003', 1, CAST(0x81340B00 AS Date), CAST(0x57430B00 AS Date))
INSERT [dbo].[ItemEvaluacion] ([Id_Item], [Descripcion], [Precio], [Lote], [Activo], [Fecha_Creado], [Fecha_Expiración]) VALUES (4, N'Lata Gandules', 35, N'004', 1, CAST(0x81340B00 AS Date), CAST(0x57430B00 AS Date))
INSERT [dbo].[ItemEvaluacion] ([Id_Item], [Descripcion], [Precio], [Lote], [Activo], [Fecha_Creado], [Fecha_Expiración]) VALUES (5, N'Lata Salchicha', 40, N'005', 1, CAST(0x81340B00 AS Date), CAST(0xAC410B00 AS Date))
SET IDENTITY_INSERT [dbo].[ItemEvaluacion] OFF
