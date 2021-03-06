USE [master]
GO
/****** Object:  Database [BancoEstagio]    Script Date: 17/12/2018 16:13:50 ******/
CREATE DATABASE [BancoEstagio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BancoEstagio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BancoEstagio.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BancoEstagio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BancoEstagio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BancoEstagio] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BancoEstagio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BancoEstagio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BancoEstagio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BancoEstagio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BancoEstagio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BancoEstagio] SET ARITHABORT OFF 
GO
ALTER DATABASE [BancoEstagio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BancoEstagio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BancoEstagio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BancoEstagio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BancoEstagio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BancoEstagio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BancoEstagio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BancoEstagio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BancoEstagio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BancoEstagio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BancoEstagio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BancoEstagio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BancoEstagio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BancoEstagio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BancoEstagio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BancoEstagio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BancoEstagio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BancoEstagio] SET RECOVERY FULL 
GO
ALTER DATABASE [BancoEstagio] SET  MULTI_USER 
GO
ALTER DATABASE [BancoEstagio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BancoEstagio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BancoEstagio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BancoEstagio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BancoEstagio] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BancoEstagio', N'ON'
GO
USE [BancoEstagio]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 17/12/2018 16:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](20) NOT NULL,
	[Senha] [nvarchar](16) NOT NULL,
	[Matricula] [nvarchar](50) NOT NULL,
	[NomeUsuario] [nvarchar](50) NOT NULL,
	[Foto] [image] NULL,
	[Email] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 17/12/2018 16:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[idDisciplina] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](20) NULL,
	[Turma] [nvarchar](20) NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[idDisciplina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisciplinaProfessor]    Script Date: 17/12/2018 16:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisciplinaProfessor](
	[idDisciplinaProfessor] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[idProfessor] [int] NOT NULL,
 CONSTRAINT [PK_DisciplinaProfessor_1] PRIMARY KEY CLUSTERED 
(
	[idDisciplinaProfessor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disponibilidade]    Script Date: 17/12/2018 16:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponibilidade](
	[IdDisponibilidade] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [int] NOT NULL,
	[DiaDaSemana] [int] NOT NULL,
	[Turno] [int] NOT NULL,
	[HorarioInicio] [time](7) NOT NULL,
	[HorarioFim] [time](7) NOT NULL,
 CONSTRAINT [PK_Disponibilidade] PRIMARY KEY CLUSTERED 
(
	[IdDisponibilidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EscalaProva]    Script Date: 17/12/2018 16:13:50 ******/
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
/****** Object:  Table [dbo].[GradeHoraria]    Script Date: 17/12/2018 16:13:50 ******/
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
/****** Object:  Table [dbo].[Professor]    Script Date: 17/12/2018 16:13:50 ******/
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
	[idDisciplina] [int] NOT NULL,
	[DisponibilidadeProfessor] [int] NULL,
	[TipoDeContrato] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[IdProfessor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turma]    Script Date: 17/12/2018 16:13:50 ******/
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
/****** Object:  Table [dbo].[TurmaDisciplina]    Script Date: 17/12/2018 16:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurmaDisciplina](
	[idTurmaDisciplina] [int] NOT NULL,
	[idDisciplina] [int] NULL,
	[idTurma] [int] NOT NULL,
 CONSTRAINT [PK_TurmaDisciplina] PRIMARY KEY CLUSTERED 
(
	[idTurmaDisciplina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [BancoEstagio] SET  READ_WRITE 
GO
