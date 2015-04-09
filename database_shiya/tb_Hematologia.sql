USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_Hematologia]    Script Date: 09/05/2014 15:22:50 by Yhorby Matias ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_Hematologia](
	[id] [int] NOT NULL,
	[Cod_paciente] [varchar] (50) NOT NULL,
	[Hematocrito] [varchar](50) NULL,
	[Hemoglobina] [varchar](50) NULL,
	[Leucocitos] [varchar](50) NULL,
	[Eritrocitos] [varchar](50) NULL,
	[Neutrófilos] [varchar](50) NULL,
	[Linfocitos] [varchar](50) NULL,
	[Eosinófilos] [varchar](50) NULL,
	[Basófilos] [varchar](50) NULL,
	[Monocitos] [varchar](50) NULL,
	[C_Falciformes] [varchar](50) NULL,
	[C_Plaquetas] [varchar](50) NULL,
	[Eritrosed] [varchar](50) NULL,
	[T_Protrombina] [varchar](50) NULL,
	[T_Coagulación] [varchar](50) NULL,
	[TT_Sangría] [varchar](50) NULL,
	[Filaria] [varchar](50) NULL,
	[Hemotozoarios] [varchar](50) NULL,
	[Falcemia] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

