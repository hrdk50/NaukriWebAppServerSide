USE [master]
GO
/****** Object:  Database [NaukriDb]    Script Date: 24-03-2020 15:46:38 ******/
CREATE DATABASE [NaukriDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NaukriDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NaukriDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NaukriDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NaukriDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NaukriDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NaukriDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NaukriDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NaukriDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NaukriDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NaukriDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NaukriDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [NaukriDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NaukriDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NaukriDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NaukriDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NaukriDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NaukriDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NaukriDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NaukriDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NaukriDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NaukriDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NaukriDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NaukriDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NaukriDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NaukriDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NaukriDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NaukriDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NaukriDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NaukriDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NaukriDb] SET  MULTI_USER 
GO
ALTER DATABASE [NaukriDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NaukriDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NaukriDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NaukriDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NaukriDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NaukriDb] SET QUERY_STORE = OFF
GO
USE [NaukriDb]
GO
/****** Object:  Table [dbo].[EducationDetails]    Script Date: 24-03-2020 15:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationDetails](
	[EducationId] [bigint] IDENTITY(1,1) NOT NULL,
	[Qualification] [varchar](50) NOT NULL,
	[Course] [varchar](50) NOT NULL,
	[Specialization] [varchar](50) NOT NULL,
	[CollegeName] [varchar](50) NOT NULL,
	[CourseType] [varchar](20) NOT NULL,
	[PassingYear] [int] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_EducationDetails] PRIMARY KEY CLUSTERED 
(
	[EducationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmploymentDetails]    Script Date: 24-03-2020 15:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmploymentDetails](
	[EmploymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[JobTitle] [varchar](50) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Lakhs] [int] NOT NULL,
	[Thousands] [int] NOT NULL,
	[JoinYear] [int] NOT NULL,
	[JoinMonth] [varchar](20) NOT NULL,
	[PresentYear] [int] NOT NULL,
	[PresentMonth] [varchar](20) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[NoticePeriod] [varchar](30) NOT NULL,
	[Industry] [varchar](50) NULL,
	[FuctionalArea] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_EmploymentDetails] PRIMARY KEY CLUSTERED 
(
	[EmploymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalDetails]    Script Date: 24-03-2020 15:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalDetails](
	[PersonalId] [bigint] IDENTITY(1,1) NOT NULL,
	[MobileNumber] [varchar](15) NOT NULL,
	[Resume] [bit] NULL,
	[UserId] [bigint] NOT NULL,
	[YearExperience] [int] NOT NULL,
	[MonthExperience] [int] NOT NULL,
 CONSTRAINT [PK_PersonalDetails] PRIMARY KEY CLUSTERED 
(
	[PersonalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 24-03-2020 15:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[SkillId] [int] IDENTITY(1,1) NOT NULL,
	[SkillName] [varchar](50) NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[SkillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24-03-2020 15:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[UserType] [bit] NOT NULL,
	[UserTypeName] [varchar](20) NOT NULL,
	[EmailId] [varchar](50) NOT NULL,
	[Password] [varchar](16) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EducationDetails]  WITH CHECK ADD  CONSTRAINT [FK_EducationDetails_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[EducationDetails] CHECK CONSTRAINT [FK_EducationDetails_Users]
GO
ALTER TABLE [dbo].[EmploymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_EmploymentDetails_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[EmploymentDetails] CHECK CONSTRAINT [FK_EmploymentDetails_Users]
GO
ALTER TABLE [dbo].[PersonalDetails]  WITH CHECK ADD  CONSTRAINT [FK_PersonalDetails_Users1] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[PersonalDetails] CHECK CONSTRAINT [FK_PersonalDetails_Users1]
GO
ALTER TABLE [dbo].[Skills]  WITH CHECK ADD  CONSTRAINT [FK_Skills_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Skills] CHECK CONSTRAINT [FK_Skills_Users]
GO
USE [master]
GO
ALTER DATABASE [NaukriDb] SET  READ_WRITE 
GO
