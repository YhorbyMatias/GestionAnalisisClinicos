USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_Paciente]    Script Date: 09/05/2014 15:23:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_Paciente](
	[Cod_Paciente] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Edad] [varchar](50) NULL,
	[C_tipo] [varchar] (50) NULL,
	[Sexo] [varchar] (50) NULL,
	[Record_no] [varchar] (50) NULL,
	[fecha_ing] [Date]  NULL,
	[Fecha_Ent] [Date] NULL, 
	[Indicaciones] [varchar](50) NULL,
	[atendido] [varchar] (50) NULL,
	[entregado] [numeric] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

