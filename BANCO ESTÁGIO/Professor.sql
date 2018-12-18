USE [BancoEstagio]
GO

/****** Object:  Table [dbo].[Professor]    Script Date: 26/11/2018 10:07:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professor](
	[IdProfessor] [int] IDENTITY(1,1) NOT NULL,
	[NomeProfessor] [nvarchar](50) NOT NULL,
	[CPFProfessor] [nvarchar](50) NOT NULL,
	[TempoDeAtuacao] [int] NOT NULL,
	[CargoProfessor] [nvarchar](50) NOT NULL,
	[DisciplinaProfessor] [nvarchar](50) NOT NULL,
	[DisponibilidadeProfessor] [int] NOT NULL,
	[TipoDeContrato] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[IdProfessor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

