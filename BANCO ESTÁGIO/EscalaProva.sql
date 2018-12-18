USE [BancoEstagio]
GO

/****** Object:  Table [dbo].[EscalaProva]    Script Date: 26/11/2018 10:07:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EscalaProva](
	[IdProva] [int] IDENTITY(1,1) NOT NULL,
	[NomeProfessor] [nvarchar](50) NOT NULL,
	[CPFProfessor] [nchar](14) NOT NULL,
	[HorarioInicio] [time](5) NOT NULL,
	[HorarioFim] [time](5) NOT NULL,
	[Data] [datetime] NOT NULL,
 CONSTRAINT [PK_EscalaProva] PRIMARY KEY CLUSTERED 
(
	[IdProva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

