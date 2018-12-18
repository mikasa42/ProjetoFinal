USE [BancoEstagio]
GO

/****** Object:  Table [dbo].[Admin]    Script Date: 26/11/2018 10:07:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Admin](
	[idUsuario] [int] NOT NULL,
	[Login] [nvarchar](20) NULL,
	[Senha] [nvarchar](16) NULL,
	[Matricula] [nvarchar](50) NULL,
	[NomeUsuario] [nvarchar](50) NULL,
	[Foto] [image] NULL,
	[Email] [nvarchar](30) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

