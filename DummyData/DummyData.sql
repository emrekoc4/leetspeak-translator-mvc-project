USE [master]
GO
/****** Object:  Database [LeetSpeakDatabase]    Script Date: 23.05.2022 10:10:50 ******/
CREATE DATABASE [LeetSpeakDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LeetSpeakDatabase', FILENAME = N'D:\KURULUMLAR\MSSQL15.SQLEXPRESS\MSSQL\DATA\LeetSpeakDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LeetSpeakDatabase_log', FILENAME = N'D:\KURULUMLAR\MSSQL15.SQLEXPRESS\MSSQL\DATA\LeetSpeakDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LeetSpeakDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LeetSpeakDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LeetSpeakDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LeetSpeakDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LeetSpeakDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LeetSpeakDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LeetSpeakDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LeetSpeakDatabase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LeetSpeakDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LeetSpeakDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [LeetSpeakDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LeetSpeakDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LeetSpeakDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LeetSpeakDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LeetSpeakDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LeetSpeakDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LeetSpeakDatabase] SET QUERY_STORE = OFF
GO
USE [LeetSpeakDatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Photo] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contents]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[translated] [nvarchar](max) NULL,
	[text] [nvarchar](max) NULL,
	[translation] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserContentsDtos]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserContentsDtos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[ContentsId] [int] NULL,
 CONSTRAINT [PK_UserContentsDtos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220519122106_createdb', N'5.0.17')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1a9eea2e-c93c-409e-a4a1-a7059d57162e', N'User', N'USER', N'0418a333-75aa-4536-a088-d44505ddad3c')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4c13e7e3-97af-4389-80ff-565d6b34e9ef', N'Admin', N'ADMIN', N'c016c189-10cf-4a81-995e-76b2bd14f486')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'21b960f3-4da6-4558-adad-f0bda02cbcd6', N'1a9eea2e-c93c-409e-a4a1-a7059d57162e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2659523d-df8b-4b01-bafd-859cf22371b5', N'1a9eea2e-c93c-409e-a4a1-a7059d57162e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'89535645-1849-40ab-a979-052d996acc18', N'1a9eea2e-c93c-409e-a4a1-a7059d57162e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9aa2c9f6-508c-45ff-ad55-53578a3bafc7', N'1a9eea2e-c93c-409e-a4a1-a7059d57162e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'21b960f3-4da6-4558-adad-f0bda02cbcd6', N'4c13e7e3-97af-4389-80ff-565d6b34e9ef')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4d6c1191-4de1-4769-b8de-bfc7bde3cdc7', N'4c13e7e3-97af-4389-80ff-565d6b34e9ef')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Password], [Photo], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0403a485-23bc-4bcd-bc00-3f36fc029d9a', N'James', N'Doe', N'123456', NULL, N'james.doe', N'JAMES.DOE', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEPvbss3mp6DB5kaWhHQla1gWMH1Etbah21Io6uu98pepLfdgGAf3Kv5C0v4piaFmPA==', N'FDYHPCC4RTALXTC246G4I4QC6G33GEPI', N'668c4fb3-3376-4d3c-bb10-25ff23b9de6f', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Password], [Photo], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'21b960f3-4da6-4558-adad-f0bda02cbcd6', N'admin', N'admin', N'123456', N'8ae34bb6-4262-4663-87fa-2e7263277a49-cv pp.jpg', N'admin', N'ADMIN', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEE1rxx5eWez2xSHMXM6ITFS2/fYeWBs0g6xA73sSi+Ijwe5ImUxdyOOTipIB99GRrg==', N'NJ4TTJSOGPNRY53AU5Y4WP7K32NNI6BS', N'7af82271-8104-4a26-977e-a0e91751e28f', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Password], [Photo], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2659523d-df8b-4b01-bafd-859cf22371b5', N'Advanced', N'Solutions', N'123456', N'c1079604-926e-428a-8d21-c914d4541da0-afslogo.jpg', N'afs', N'AFS', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEGzOWw9hHHwU1q2MhMdsmEQRoA3ZjFnezeBBk4tst4WXglfeBk0MUHcTzbqUnrj4rw==', N'74K7MZMA2OP4QVO7NXW3LUA4R73AG2D2', N'082882ff-ac9a-4cc3-a602-a190c35ee50c', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Password], [Photo], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2c039327-adee-4cd8-89eb-8c7f1c40ee57', N'John ', N'Doe', N'1234', NULL, N'john.doe', N'JOHN.DOE', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEBA7wYvnTixmm/+1PxO867ZZBMf2/gkvQNkBmTh4JBjI7YlGqhX/kpbKPcU4EpL4ww==', N'JYSPJXKMUQ4XGSAZADSUWWCMJMODVIZY', N'6cf6e9d8-d0d5-4d5e-bb35-5c286ee76dfd', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Password], [Photo], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4d6c1191-4de1-4769-b8de-bfc7bde3cdc7', N'Emre', N'Koc', N'1234', NULL, N'emrekoc', N'EMREKOC', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEIblFMW4CzOWG5TL6tnvaztjLf7nahRvRIGFsRusCR9+uMKaFP1ENz5rDDpzW3db3A==', N'NZH25IYZM2IH6JEOCREBQZA5JK4JSGZI', N'94c35488-d5d8-4bb3-bcd9-df1b5548553d', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Password], [Photo], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'89535645-1849-40ab-a979-052d996acc18', N'Toi', N'Story', N'123456', N'49fc4956-62b5-4246-a556-7ee1b90a76e9-ipfs___QmTvYnw5bSF4qUWKxSr6TGSk27dtMgG55maGG8hPwqYeDT.jfif', N'toi.story', N'TOI.STORY', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEN+i9lMzW7+ztSO5tzqfP+fkViVfE9Uk4yit41GTFO4sw3R0wWtrrTe2ZT7R/c9nvw==', N'LYWIYZ52EFRRYHHKE3Y62SZ6PFA3MMJL', N'b7b92309-cf73-415d-9af0-ca94df59b9bc', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Password], [Photo], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9aa2c9f6-508c-45ff-ad55-53578a3bafc7', N'Michael', N'Doe', N'123456', NULL, N'michael.doe', N'MICHAEL.DOE', NULL, NULL, 0, N'AQAAAAEAACcQAAAAECkUfFsJ+Qv3yZf5C4EmMbHq4breGpDoFDMInJiU/0GnQO16MOOaWk3mHl+SXeQJEQ==', N'BPAAQNTQVR27HFLOGXEYR7JQO6AFVK74', N'714f0b3a-e3a1-4d0d-9b12-25c2d06d627b', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Contents] ON 

INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (3, N'WH47 d03S 1YF3 m3an?', N'What does life mean?', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (4, N'\/\/h4T |)03S @dvanCed f131D so1Ut!onz d0?', N'What does Advanced Field Solutions do?', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (5, N'wh@T d03s 7hIs AP! d0?', N'What does this API do?', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (6, N'Y7''S FR|D@y.', N'It''s Friday.', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (7, N'!s 1T fR1dAy?', N'Is it Friday?', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (8, N'dYd j00 w@Tc]-[ 4]\[Y 0f tOY Z7oRy m0v135?', N'Did you watch any of Toy Story Movies?', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (9, N'1 ha\/E w47kh3D d4 EnT!R3 Z3rI35', N'I have watched the entire series', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (10, N'dO35 a T0y EV3r t41k??', N'Does a toy ever talk??', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (11, N'd035 uNi7 7eSt FA1l?', N'Does unit test fail?', N'leetspeak')
INSERT [dbo].[Contents] ([Id], [translated], [text], [translation]) VALUES (12, N'Wh4t D()Ez A|)v4|\|c3D FIE1d Z0lUTY0]\[Z d0?', N'What does Advanced Field Solutions do?', N'leetspeak')
SET IDENTITY_INSERT [dbo].[Contents] OFF
GO
SET IDENTITY_INSERT [dbo].[UserContentsDtos] ON 

INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (3, N'9aa2c9f6-508c-45ff-ad55-53578a3bafc7', 3)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (4, N'9aa2c9f6-508c-45ff-ad55-53578a3bafc7', 4)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (5, N'9aa2c9f6-508c-45ff-ad55-53578a3bafc7', 5)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (6, N'9aa2c9f6-508c-45ff-ad55-53578a3bafc7', 6)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (7, N'9aa2c9f6-508c-45ff-ad55-53578a3bafc7', 7)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (8, N'89535645-1849-40ab-a979-052d996acc18', 8)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (9, N'89535645-1849-40ab-a979-052d996acc18', 9)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (10, N'89535645-1849-40ab-a979-052d996acc18', 10)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (11, N'4d6c1191-4de1-4769-b8de-bfc7bde3cdc7', 11)
INSERT [dbo].[UserContentsDtos] ([Id], [UserId], [ContentsId]) VALUES (12, N'2659523d-df8b-4b01-bafd-859cf22371b5', 12)
SET IDENTITY_INSERT [dbo].[UserContentsDtos] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 23.05.2022 10:10:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 23.05.2022 10:10:50 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 23.05.2022 10:10:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 23.05.2022 10:10:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 23.05.2022 10:10:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 23.05.2022 10:10:50 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 23.05.2022 10:10:50 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserContentsDtos_ContentsId]    Script Date: 23.05.2022 10:10:50 ******/
CREATE NONCLUSTERED INDEX [IX_UserContentsDtos_ContentsId] ON [dbo].[UserContentsDtos]
(
	[ContentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserContentsDtos_UserId]    Script Date: 23.05.2022 10:10:50 ******/
CREATE NONCLUSTERED INDEX [IX_UserContentsDtos_UserId] ON [dbo].[UserContentsDtos]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[UserContentsDtos]  WITH CHECK ADD  CONSTRAINT [FK_UserContentsDtos_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[UserContentsDtos] CHECK CONSTRAINT [FK_UserContentsDtos_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[UserContentsDtos]  WITH CHECK ADD  CONSTRAINT [FK_UserContentsDtos_Contents_ContentsId] FOREIGN KEY([ContentsId])
REFERENCES [dbo].[Contents] ([Id])
GO
ALTER TABLE [dbo].[UserContentsDtos] CHECK CONSTRAINT [FK_UserContentsDtos_Contents_ContentsId]
GO
/****** Object:  StoredProcedure [dbo].[GetContentByContentId]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetContentByContentId](@ContentId int, @Translated nvarchar(MAX) output, @Text nvarchar(MAX) output, @Translation nvarchar(MAX) output)
AS
BEGIN
SELECT @Translated = translated, @Text = text, @Translation = Translation FROM Contents where @ContentId = Id  
END
GO
/****** Object:  StoredProcedure [dbo].[GetUsers]    Script Date: 23.05.2022 10:10:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetUsers](@UserName nvarchar(MAX) output, @FirstName nvarchar(MAX) output, @LastName nvarchar(MAX) output, @ContentId int output, 
@Translated nvarchar(MAX) output, @Text nvarchar(MAX) output, @Translation nvarchar(MAX) output, @Photo nvarchar(MAX) output)  --@adet, geri değer döndüren parametre
AS
BEGIN
SELECT @UserName = u.UserName, @FirstName = u.FirstName, @LastName = u.LastName, @ContentId = c.Id, @Translated = c.translated,
@Text = c.text, @Translation = c.Translation, @Photo = u.Photo FROM AspNetUsers u 
join UserContentsDtos ud on u.Id = ud.UserId
join Contents c on c.Id = ud.ContentsId
END
GO
USE [master]
GO
ALTER DATABASE [LeetSpeakDatabase] SET  READ_WRITE 
GO
