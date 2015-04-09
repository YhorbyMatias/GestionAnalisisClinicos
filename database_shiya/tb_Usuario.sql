USE [BD_Laboratorio]
GO

/****** Object:  Table [dbo].[TB_Usuario]    Script Date: 09/05/2014 15:24:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TB_Usuario](
	[Cod_Usuario] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

