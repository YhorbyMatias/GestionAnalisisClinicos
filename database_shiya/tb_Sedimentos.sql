USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_Sedimentos]    Script Date: 09/05/2014 15:23:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_Sedimentos](
	[id] [int] NOT NULL,
	[Cod_paciente] [varchar] NOT NULL,
	[Leucocitos] [varchar](50) NULL,
	[Hematies] [varchar](50) NULL,
	[Epitelios] [varchar](50) NULL,
	[Bacterias] [varchar](50) NULL,
	[F_Mucosa] [varchar](50) NULL,
	[Cilindro] [varchar](50) NULL,
	[Cristales] [varchar](50) NULL,
	[T_Vaginales] [varchar](50) NULL,
	[Monilias] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

