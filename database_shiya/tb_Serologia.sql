USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_Serologia]    Script Date: 09/05/2014 15:23:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_Serologia](
	[id] [int] NOT NULL,
	[Cod_paciente] [int] NOT NULL,
	[IGE] [varchar](50) NULL,
	[IGG] [varchar](50) NULL,
	[VDRL] [varchar](50) NULL,
	[F_Reumatoide] [varchar](50) NULL,
	[P_C_R] [varchar](50) NULL,
	[Toxoplasmosis] [varchar](50) NULL,
	[IGG_2] [varchar](50) NULL,
	[IGM] [varchar](50) NULL,
	[A_S_O] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

