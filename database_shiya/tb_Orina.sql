USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_Orina]    Script Date: 09/05/2014 15:23:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_Orina](
	[id] [int] NOT NULL,
	[Cod_paciente] [int] NOT NULL
	[Color] [varchar](50) NULL,
	[Aspecto] [varchar](50) NULL,
	[PH] [varchar](50) NULL,
	[Densidad] [varchar](50) NULL,
	[Proteinas] [varchar](50) NULL,
	[Glucosa] [varchar](50) NULL,
	[Acetona] [varchar](50) NULL,
	[Urobilinogeno] [varchar](50) NULL,
	[Bilirrubina] [varchar](50) NULL,
	[Nitritos] [varchar](50) NULL,
	[Sangre_O] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

