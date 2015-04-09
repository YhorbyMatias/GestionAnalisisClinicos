USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_Coprologico]    Script Date: 09/05/2014 15:22:33 by Yhorby Matias ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_Coprologico](
	[id] [int] (20) NOT NULL,
	[Cod_paciente] [varchar] (50) NOT NULL,
	[Color] [varchar](50) NULL,
	[Consistencia] [varchar](50) NULL,
	[Huevos] [varchar](50) NULL,
	[Quistes] [varchar](50) NULL,
	[Larvas] [varchar](50) NULL,
	[Bacterias] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

