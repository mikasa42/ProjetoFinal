USE [BancoEstagio]
GO

/****** Object:  Table [dbo].[Turma]    Script Date: 26/11/2018 10:08:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Turma](
	[idTurma] [int] NOT NULL,
	[QtdTempos] [int] NULL,
	[Disciplinas] [nvarchar](50) NULL,
	[Tecnico] [nchar](3) NULL,
 CONSTRAINT [PK_Turma] PRIMARY KEY CLUSTERED 
(
	[idTurma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

