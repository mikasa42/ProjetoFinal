USE [BancoEstagio]
GO

/****** Object:  Table [dbo].[Disponibilidade]    Script Date: 26/11/2018 10:07:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Disponibilidade](
	[IdDisciplina] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [int] NOT NULL,
	[DiaDaSemana] [date] NOT NULL,
	[HorarioInicio] [time](7) NOT NULL,
	[HorarioFim] [time](7) NOT NULL,
 CONSTRAINT [PK_Disponibilidade] PRIMARY KEY CLUSTERED 
(
	[IdDisciplina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

