USE [master]
GO
/****** Object:  Database [DeveloperTest]    Script Date: 05/05/2019 22:37:36 ******/
CREATE DATABASE [DeveloperTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeveloperTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DeveloperTest.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DeveloperTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DeveloperTest_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DeveloperTest] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeveloperTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DeveloperTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DeveloperTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DeveloperTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DeveloperTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DeveloperTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [DeveloperTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DeveloperTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DeveloperTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DeveloperTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DeveloperTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DeveloperTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DeveloperTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DeveloperTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DeveloperTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DeveloperTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DeveloperTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DeveloperTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DeveloperTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DeveloperTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DeveloperTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DeveloperTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DeveloperTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DeveloperTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DeveloperTest] SET  MULTI_USER 
GO
ALTER DATABASE [DeveloperTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DeveloperTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DeveloperTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DeveloperTest] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DeveloperTest] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DeveloperTest]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 05/05/2019 22:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Test](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TestName] [varchar](50) NULL,
	[TestType] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_TblTest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TestDetails]    Script Date: 05/05/2019 22:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TestDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TestId] [bigint] NULL,
	[UserId] [int] NULL,
	[Distance] [decimal](18, 3) NULL,
	[FitnessRating] [varchar](20) NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_TblTestDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 05/05/2019 22:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[UserType] [varchar](20) NULL,
 CONSTRAINT [PK_TblUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Test] ON 

GO
INSERT [dbo].[Test] ([Id], [TestName], [TestType], [Description]) VALUES (1, N'Coopertest', N'Coopertest', N'How many meters can you run in 12 minuttes')
GO
INSERT [dbo].[Test] ([Id], [TestName], [TestType], [Description]) VALUES (2, N'Sprinttest', N'Sprinttest', N'How many seconds to run 100 meters')
GO
SET IDENTITY_INSERT [dbo].[Test] OFF
GO
SET IDENTITY_INSERT [dbo].[TestDetails] ON 

GO
INSERT [dbo].[TestDetails] ([Id], [TestId], [UserId], [Distance], [FitnessRating], [Date]) VALUES (1, 1, 2, CAST(4.500 AS Decimal(18, 3)), N'Below Average', CAST(N'2019-04-10' AS Date))
GO
INSERT [dbo].[TestDetails] ([Id], [TestId], [UserId], [Distance], [FitnessRating], [Date]) VALUES (2, 1, 3, CAST(6.500 AS Decimal(18, 3)), N'Average', CAST(N'2019-04-10' AS Date))
GO
INSERT [dbo].[TestDetails] ([Id], [TestId], [UserId], [Distance], [FitnessRating], [Date]) VALUES (3, 2, 5, CAST(7.000 AS Decimal(18, 3)), N'Good', CAST(N'2019-04-11' AS Date))
GO
INSERT [dbo].[TestDetails] ([Id], [TestId], [UserId], [Distance], [FitnessRating], [Date]) VALUES (4, 1, 6, CAST(6.000 AS Decimal(18, 3)), N'Average', CAST(N'2019-05-03' AS Date))
GO
INSERT [dbo].[TestDetails] ([Id], [TestId], [UserId], [Distance], [FitnessRating], [Date]) VALUES (5, 1, 4, CAST(8.000 AS Decimal(18, 3)), N'Good', CAST(N'2019-04-10' AS Date))
GO
SET IDENTITY_INSERT [dbo].[TestDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (1, N'Mitchel Fausto', N'123456', N'Coach')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (2, N'Queen Jacobi', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (3, N'Magen Faye', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (4, N'Delicia Ledonne', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (5, N'Camille Grantham', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (6, N'Marc Voth', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (7, N'Randy Rondon', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (8, N'Delora Saville', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (9, N'Rosario Reuben', N'123456', N'Athlete')
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType]) VALUES (10, N'Lula Uhlman', N'123456', N'Athlete')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_TestDetail]    Script Date: 05/05/2019 22:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TestDetail]
	
AS
BEGIN
	Select ROW_NUMBER() OVER(ORDER BY Td.Id desc) AS SerialNumber,[User].UserName as Ranking,Td.Distance,
  Td.FitnessRating,[Test].TestName,[Test].Id as Testid,
     [Date] as Testdate
from
      TestDetails Td
	 inner join [User] on [User].Id=Td.Id 
	 inner join [Test] on [Test].Id=td.TestId
	 --where TestId=@TestId and [Date]='2019-04-10'
group by
   [Date],[User].UserName,Td.Id,Td.Distance,Td.FitnessRating,[Test].TestName,[Test].Id
	 order by Td.Distance desc
END

GO
/****** Object:  StoredProcedure [dbo].[spTotalParticipants]    Script Date: 05/05/2019 22:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTotalParticipants]

AS
BEGIN
	Select
     ROW_NUMBER() OVER(ORDER BY [Date] asc) AS SerialNumber,[Date] as Testdate,count([Date]) as Testcount,[Test].TestType
     
from
     TestDetails td
	 inner join [Test] on td.TestId=[Test].Id
group by
     [Date],[Test].TestType
END

GO
USE [master]
GO
ALTER DATABASE [DeveloperTest] SET  READ_WRITE 
GO
