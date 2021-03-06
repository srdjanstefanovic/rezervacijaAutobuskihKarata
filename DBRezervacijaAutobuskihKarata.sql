USE [master]
GO
/****** Object:  Database [RezervacijaAutobuskihKarata]    Script Date: 12-Feb-20 7:19:20 PM ******/
CREATE DATABASE [RezervacijaAutobuskihKarata]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RezervacijaAutobuskihKarata', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RezervacijaAutobuskihKarata.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RezervacijaAutobuskihKarata_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RezervacijaAutobuskihKarata_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RezervacijaAutobuskihKarata].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET ARITHABORT OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET  MULTI_USER 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET QUERY_STORE = OFF
GO
USE [RezervacijaAutobuskihKarata]
GO
/****** Object:  Table [dbo].[Linija]    Script Date: 12-Feb-20 7:19:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Linija](
	[LinijaID] [int] NOT NULL,
	[NazivPrevoznika] [varchar](50) NULL,
	[VremePolaska] [datetime] NULL,
	[VremeDolaska] [datetime] NULL,
	[TrajanjePuta] [time](7) NULL,
	[RaspoloziviBrojMesta] [int] NULL,
	[StanicaIDPocetna] [int] NULL,
	[StanicaIDKrajnja] [int] NULL,
 CONSTRAINT [PK_Linija] PRIMARY KEY CLUSTERED 
(
	[LinijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Putnik]    Script Date: 12-Feb-20 7:19:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Putnik](
	[PutnikID] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[Pol] [int] NULL,
	[JMBG] [varchar](13) NULL,
	[DatumRodjenja] [date] NULL,
	[KontaktTelefon] [varchar](50) NULL,
 CONSTRAINT [PK_Putnik] PRIMARY KEY CLUSTERED 
(
	[PutnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 12-Feb-20 7:19:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[RezervacijaID] [int] NOT NULL,
	[DatumRezervacije] [date] NULL,
	[UkupanIznos] [numeric](10, 2) NULL,
	[Valuta] [int] NULL,
	[ZaposleniID] [int] NULL,
	[PutnikID] [int] NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stanica]    Script Date: 12-Feb-20 7:19:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stanica](
	[StanicaID] [int] NOT NULL,
	[Grad] [varchar](50) NULL,
	[Adresa] [varchar](50) NULL,
 CONSTRAINT [PK_Stanica] PRIMARY KEY CLUSTERED 
(
	[StanicaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaRezervacije]    Script Date: 12-Feb-20 7:19:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaRezervacije](
	[RezervacijaID] [int] NOT NULL,
	[RedniBroj] [int] NOT NULL,
	[Cena] [numeric](18, 2) NULL,
	[LinijaID] [int] NULL,
 CONSTRAINT [PK_StavkaRezervacije] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC,
	[RedniBroj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaposleni]    Script Date: 12-Feb-20 7:19:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaposleni](
	[ZaposleniID] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[KorisnickoIme] [varchar](50) NULL,
	[KorisnickaLozinka] [varchar](50) NULL,
 CONSTRAINT [PK_Zaposleni] PRIMARY KEY CLUSTERED 
(
	[ZaposleniID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Linija] ([LinijaID], [NazivPrevoznika], [VremePolaska], [VremeDolaska], [TrajanjePuta], [RaspoloziviBrojMesta], [StanicaIDPocetna], [StanicaIDKrajnja]) VALUES (1, N'Raketa AB', CAST(N'2020-01-25T07:00:00.000' AS DateTime), CAST(N'2020-01-25T09:30:00.000' AS DateTime), CAST(N'02:30:00' AS Time), 76, 1, 2)
INSERT [dbo].[Linija] ([LinijaID], [NazivPrevoznika], [VremePolaska], [VremeDolaska], [TrajanjePuta], [RaspoloziviBrojMesta], [StanicaIDPocetna], [StanicaIDKrajnja]) VALUES (2, N'Raketa AB', CAST(N'2020-01-25T08:00:00.000' AS DateTime), CAST(N'2020-01-25T10:45:00.000' AS DateTime), CAST(N'02:45:00' AS Time), 50, 1, 7)
INSERT [dbo].[Linija] ([LinijaID], [NazivPrevoznika], [VremePolaska], [VremeDolaska], [TrajanjePuta], [RaspoloziviBrojMesta], [StanicaIDPocetna], [StanicaIDKrajnja]) VALUES (3, N'Lastra Lazarevac', CAST(N'2020-01-26T10:00:00.000' AS DateTime), CAST(N'2020-01-26T11:45:00.000' AS DateTime), CAST(N'01:45:00' AS Time), 89, 1, 3)
INSERT [dbo].[Linija] ([LinijaID], [NazivPrevoznika], [VremePolaska], [VremeDolaska], [TrajanjePuta], [RaspoloziviBrojMesta], [StanicaIDPocetna], [StanicaIDKrajnja]) VALUES (4, N'Ariva', CAST(N'2020-01-26T07:00:00.000' AS DateTime), CAST(N'2020-01-26T10:00:00.000' AS DateTime), CAST(N'03:00:00' AS Time), 45, 1, 4)
INSERT [dbo].[Linija] ([LinijaID], [NazivPrevoznika], [VremePolaska], [VremeDolaska], [TrajanjePuta], [RaspoloziviBrojMesta], [StanicaIDPocetna], [StanicaIDKrajnja]) VALUES (5, N'Lastra Lazarevac', CAST(N'2020-01-25T12:00:00.000' AS DateTime), CAST(N'2020-01-25T15:00:00.000' AS DateTime), CAST(N'03:00:00' AS Time), 67, 2, 3)
INSERT [dbo].[Linija] ([LinijaID], [NazivPrevoznika], [VremePolaska], [VremeDolaska], [TrajanjePuta], [RaspoloziviBrojMesta], [StanicaIDPocetna], [StanicaIDKrajnja]) VALUES (6, N'Duga', CAST(N'2020-01-27T14:00:00.000' AS DateTime), CAST(N'2020-01-27T15:15:00.000' AS DateTime), CAST(N'01:15:00' AS Time), 37, 2, 6)
INSERT [dbo].[Linija] ([LinijaID], [NazivPrevoznika], [VremePolaska], [VremeDolaska], [TrajanjePuta], [RaspoloziviBrojMesta], [StanicaIDPocetna], [StanicaIDKrajnja]) VALUES (7, N'Duga', CAST(N'2020-02-26T06:30:00.000' AS DateTime), CAST(N'2020-02-26T09:35:00.000' AS DateTime), CAST(N'03:05:00' AS Time), 52, 1, 5)
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (2, N'Marijana', N'Milosevic', 2, N'1234567891234', CAST(N'1994-10-10' AS Date), N'062252242')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (4, N'Milos', N'Mirkovic', 1, N'1235558889563', CAST(N'1963-11-05' AS Date), N'0651118885')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (5, N'Petra', N'Petrovic', 2, N'1111115556542', CAST(N'1995-12-14' AS Date), N'0602529999')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (6, N'Pera', N'Peric', 1, N'1510998362123', CAST(N'1995-05-15' AS Date), N'0623537891')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (8, N'Ivana', N'Ivanovic', 2, N'0935558889563', CAST(N'1984-04-12' AS Date), N'0643249017')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (9, N'Nikolina', N'Nikolic', 2, N'0935668889563', CAST(N'1973-11-11' AS Date), N'0622316854')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (10, N'Nikola', N'Nikolic', 1, N'2335668779563', CAST(N'1999-05-06' AS Date), N'0691456238')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (11, N'Sara', N'Stefanovic', 2, N'2221115556542', CAST(N'1989-05-15' AS Date), N'0694546563')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (13, N'Nenad', N'Nikolic', 1, N'1935666689563', CAST(N'2000-02-12' AS Date), N'0619895656')
INSERT [dbo].[Putnik] ([PutnikID], [Ime], [Prezime], [Pol], [JMBG], [DatumRodjenja], [KontaktTelefon]) VALUES (14, N'Marina', N'Peric', 2, N'2221335556542', CAST(N'1965-12-12' AS Date), N'0625258889')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumRezervacije], [UkupanIznos], [Valuta], [ZaposleniID], [PutnikID]) VALUES (1, CAST(N'2020-01-21' AS Date), CAST(1310.00 AS Numeric(10, 2)), 1, 1, 2)
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumRezervacije], [UkupanIznos], [Valuta], [ZaposleniID], [PutnikID]) VALUES (4, CAST(N'2020-01-21' AS Date), CAST(390.00 AS Numeric(10, 2)), 1, 1, 6)
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumRezervacije], [UkupanIznos], [Valuta], [ZaposleniID], [PutnikID]) VALUES (6, CAST(N'2020-01-22' AS Date), CAST(1500.00 AS Numeric(10, 2)), 1, 1, 4)
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumRezervacije], [UkupanIznos], [Valuta], [ZaposleniID], [PutnikID]) VALUES (7, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumRezervacije], [UkupanIznos], [Valuta], [ZaposleniID], [PutnikID]) VALUES (8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Stanica] ([StanicaID], [Grad], [Adresa]) VALUES (1, N'Beograd', N'Železnicka 4')
INSERT [dbo].[Stanica] ([StanicaID], [Grad], [Adresa]) VALUES (2, N'Loznica', N'Georgija Jakšic´a 7')
INSERT [dbo].[Stanica] ([StanicaID], [Grad], [Adresa]) VALUES (3, N'Novi Sad', N'Bulevar Jaše Tomica 6')
INSERT [dbo].[Stanica] ([StanicaID], [Grad], [Adresa]) VALUES (4, N'Niš', N'Bulevar 12. Februar. bb.')
INSERT [dbo].[Stanica] ([StanicaID], [Grad], [Adresa]) VALUES (5, N'Subotica', N'Segedinski put 84')
INSERT [dbo].[Stanica] ([StanicaID], [Grad], [Adresa]) VALUES (6, N'Šabac', N'Kralja Milutina 3a')
INSERT [dbo].[Stanica] ([StanicaID], [Grad], [Adresa]) VALUES (7, N'Kragujevac', N'Šumadijska 8')
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LinijaID]) VALUES (1, 1, CAST(620.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LinijaID]) VALUES (1, 2, CAST(690.00 AS Numeric(18, 2)), 5)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LinijaID]) VALUES (4, 1, CAST(390.00 AS Numeric(18, 2)), 6)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LinijaID]) VALUES (6, 1, CAST(750.00 AS Numeric(18, 2)), 3)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LinijaID]) VALUES (6, 2, CAST(750.00 AS Numeric(18, 2)), 5)
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaLozinka]) VALUES (1, N'Srdjan', N'Stefanovic', N'srdjan', N'srdjan')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaLozinka]) VALUES (2, N'Pera', N'Peric', N'pera', N'pera')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaLozinka]) VALUES (3, N'Ana', N'Novakovic', N'ana', N'ana')
ALTER TABLE [dbo].[Linija]  WITH CHECK ADD  CONSTRAINT [FK_Linija_Stanica] FOREIGN KEY([StanicaIDPocetna])
REFERENCES [dbo].[Stanica] ([StanicaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Linija] CHECK CONSTRAINT [FK_Linija_Stanica]
GO
ALTER TABLE [dbo].[Linija]  WITH CHECK ADD  CONSTRAINT [FK_Linija_Stanica1] FOREIGN KEY([StanicaIDKrajnja])
REFERENCES [dbo].[Stanica] ([StanicaID])
GO
ALTER TABLE [dbo].[Linija] CHECK CONSTRAINT [FK_Linija_Stanica1]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Putnik] FOREIGN KEY([PutnikID])
REFERENCES [dbo].[Putnik] ([PutnikID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Putnik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Zaposleni] FOREIGN KEY([ZaposleniID])
REFERENCES [dbo].[Zaposleni] ([ZaposleniID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Zaposleni]
GO
ALTER TABLE [dbo].[StavkaRezervacije]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRezervacije_Linija] FOREIGN KEY([LinijaID])
REFERENCES [dbo].[Linija] ([LinijaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StavkaRezervacije] CHECK CONSTRAINT [FK_StavkaRezervacije_Linija]
GO
ALTER TABLE [dbo].[StavkaRezervacije]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRezervacije_Rezervacija] FOREIGN KEY([RezervacijaID])
REFERENCES [dbo].[Rezervacija] ([RezervacijaID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaRezervacije] CHECK CONSTRAINT [FK_StavkaRezervacije_Rezervacija]
GO
USE [master]
GO
ALTER DATABASE [RezervacijaAutobuskihKarata] SET  READ_WRITE 
GO
