USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_QSanguinea]    Script Date: 09/05/2014 15:23:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_QSanguinea](
	[id] [int] NOT NULL,
	[Cod_paciente] [varchar] NOT NULL,
	[Glicemia] [varchar](50) NULL,
	[Urea] [varchar](50) NULL,
	[Creatinina] [varchar](50) NULL,
	[Colesterol] [varchar](50) NULL,
	[HDL] [varchar](50) NULL,
	[LDL] [varchar](50) NULL,
	[Triglicerido] [varchar](50) NULL,
	[Ac_Urico] [varchar](50) NULL,
	[Proteina_Tles] [varchar](50) NULL,
	[Bilirrubina_T] [varchar](50) NULL,
	[Bilirrubina_D] [varchar](50) NULL,
	[T_G_P] [varchar](50) NULL,
	[Bilirrubina_I] [varchar](50) NULL,
	[T_G_O] [varchar](50) NULL,
	[Fost_Alcalina] [varchar](50) NULL,
	[Fost_Acida] [varchar](50) NULL,
	[L_D_H] [varchar](50) NULL,
	[Amilasa] [varchar](50) NULL,
	[Cloruros] [varchar](50) NULL,
	[Fosforo] [varchar](50) NULL,
	[Potasio] [varchar](50) NULL,
	[Calcio] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

