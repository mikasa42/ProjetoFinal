USE [BancoEstagio]
GO

/****** Object:  Table [dbo].[GradeHoraria]    Script Date: 26/11/2018 10:07:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GradeHoraria](
	[Matricula_Professor] [nvarchar](50) NULL,
	[IdTurma] [int] NULL,
	[DiaDaSemana] [nvarchar](20) NULL,
	[Horario] [time](5) NULL
) ON [PRIMARY]
GO

