USE [master]
GO


/****** Object:  Database [prs92_temp]    Script Date: 05/29/2008 09:30:16 ******/
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'prs92_temp')
DROP DATABASE [prs92_temp]
GO

CREATE DATABASE [prs92_temp] ON  PRIMARY 
( NAME = N'prs92Data', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92_temp.mdf', SIZE = 32000KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
  LOG ON 
( NAME = N'prs92Log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92_temp.ldf', SIZE = 6272KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO






EXEC dbo.sp_dbcmptlevel @dbname=N'prs92_temp', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [prs92_temp].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [prs92_temp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [prs92_temp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [prs92_temp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [prs92_temp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [prs92_temp] SET ARITHABORT OFF 
GO
ALTER DATABASE [prs92_temp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [prs92_temp] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [prs92_temp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [prs92_temp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [prs92_temp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [prs92_temp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [prs92_temp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [prs92_temp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [prs92_temp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [prs92_temp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [prs92_temp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [prs92_temp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [prs92_temp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [prs92_temp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [prs92_temp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [prs92_temp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [prs92_temp] SET  READ_WRITE 
GO
ALTER DATABASE [prs92_temp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [prs92_temp] SET  MULTI_USER 
GO
ALTER DATABASE [prs92_temp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [prs92_temp] SET DB_CHAINING OFF 


/****** Object:  Login [prs92]    Script Date: 05/29/2008 09:30:18 ******/
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [prs92]    Script Date: 05/29/2008 09:30:17 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'prs92')
CREATE LOGIN [prs92] WITH PASSWORD=N'prs92', DEFAULT_DATABASE=[prs92], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
--ALTER LOGIN [prs92] DISABLE
--GO


/****** Object:  Login [BUILTIN\Administrators]    Script Date: 05/29/2008 09:30:18 ******/
/****** Object:  Login [BUILTIN\Administrators]    Script Date: 05/29/2008 09:30:18 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'BUILTIN\Administrators')
CREATE LOGIN [BUILTIN\Administrators] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
USE [prs92_temp]
GO


/****** Object:  User [prs92]    Script Date: 05/29/2008 09:30:18 ******/
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'prs92')
CREATE USER [prs92] FOR LOGIN [prs92] WITH DEFAULT_SCHEMA=[dbo]
GO


/****** Object:  Table [dbo].[horfixme]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[horfixme]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[horfixme](
	[HCode] [int] NULL,
	[HDesc] [nvarchar](30) NULL,
	[ucode] [int] NOT NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[markstatus]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[markstatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[markstatus](
	[MSCode] [smallint] NULL,
	[MSDesc] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[projects]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[projects]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[projects](
	[Project_No] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[Municipality] [nvarchar](50) NULL,
	[Ref_Type] [nvarchar](50) NULL,
	[Latitude] [nvarchar](50) NULL,
	[Longitude] [nvarchar](50) NULL,
	[Encoder] [nvarchar](50) NULL,
	[Date_Last_Updated] [datetime] NULL,
	[Validation_Status] [varchar](50) NULL,
	[Validated_By] [varchar](50) NULL,
	[Validation_Date] [datetime] NULL,
 CONSTRAINT [PK_projects] PRIMARY KEY CLUSTERED 
(
	[Project_No] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[geoprov]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[geoprov]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[geoprov](
	[stat_name] [nvarchar](50) NOT NULL,
	[stat_new] [int] NULL,
	[region] [nvarchar](50) NULL,
	[province] [nvarchar](50) NULL,
	[municipal] [nvarchar](50) NULL,
	[barangay] [nvarchar](50) NULL,
	[date_est] [datetime] NULL,
	[date_las_r] [datetime] NULL,
	[island] [nvarchar](50) NULL,
	[d_lat] [int] NULL,
	[m_lat] [int] NULL,
	[s_lat] [float] NULL,
	[d_long] [int] NULL,
	[m_long] [int] NULL,
	[s_long] [float] NULL,
	[h_coords_s] [nvarchar](50) NULL,
	[h_date_ety] [datetime] NULL,
	[h_datum] [int] NULL,
	[h_ref] [nvarchar](50) NULL,
	[e_h_datum] [nvarchar](50) NULL,
	[hor_authty] [nvarchar](50) NULL,
	[h_order] [int] NULL,
	[h_date_com] [datetime] NULL,
	[h_fix] [int] NULL,
	[elevation] [float] NULL,
	[ell_hgt] [float] NULL,
	[e_date_ety] [datetime] NULL,
	[e_datum] [int] NULL,
	[e_e_datum] [nvarchar](50) NULL,
	[elv_authty] [nvarchar](50) NULL,
	[e_order] [int] NULL,
	[e_date_com] [datetime] NULL,
	[e_fix] [int] NULL,
	[mark_stat] [smallint] NULL,
	[mark_type] [int] NULL,
	[mark_const] [int] NULL,
	[authority] [nvarchar](50) NULL,
	[wgs84ND] [int] NULL,
	[wgs84NM] [int] NULL,
	[wgs84NS] [float] NULL,
	[wgs84ED] [int] NULL,
	[wgs84EM] [int] NULL,
	[wgs84ES] [float] NULL,
	[ellipz] [float] NULL,
	[image] [nvarchar](200) NULL,
	[inscription] [nvarchar](200) NULL,
	[description] [ntext] NULL,
	[log] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[gnis_users]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gnis_users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gnis_users](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Access] [int] NULL,
	[Picture] [int] NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[markpur]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[markpur]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[markpur](
	[MCode] [int] NULL,
	[MDesc] [nvarchar](30) NULL,
	[ucode] [int] NOT NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[marktype]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[marktype]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[marktype](
	[MTCode] [int] NULL,
	[MTDesc] [nvarchar](30) NULL,
	[ucode] [int] NOT NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[order_lib]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[order_lib]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[order_lib](
	[h_order] [int] NULL,
	[description] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[ref_type_lib]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ref_type_lib]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ref_type_lib](
	[Code] [int] NULL,
	[Ref_Type] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[ref_type_table]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ref_type_table]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ref_type_table](
	[Ref_Type] [nvarchar](10) NULL,
	[Ref_Type_No] [int] NULL,
	[Project_No] [nvarchar](50) NULL,
	[False_Northing] [float] NULL,
	[False_Easting] [float] NULL,
	[True_Northing] [float] NULL,
	[True_Easting] [float] NULL,
	[PTM_PRS92_Northing] [decimal](18, 5) NULL,
	[PTM_PRS92_Easting] [decimal](18, 5) NULL,
	[Latitude] [nvarchar](50) NULL,
	[Longitude] [nvarchar](50) NULL,
	[PRSLong] [nvarchar](50) NULL,
	[PRSLat] [nvarchar](50) NULL,
	[PRSEllipsoidalHt] [float] NULL,
	[WGSLong] [nvarchar](50) NULL,
	[WGSLat] [nvarchar](50) NULL,
	[WGSEllipsoidalHt] [float] NULL,
	[Inscription] [nvarchar](250) NULL,
	[Sketch] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[Remarks] [nvarchar](255) NULL,
	[Status] [nchar](20) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[psgc]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[psgc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[psgc](
	[psgc_cd] [nchar](9) NOT NULL,
	[name] [nvarchar](60) NULL,
	[reg] [nvarchar](2) NULL,
	[prov] [nvarchar](2) NULL,
	[mun] [nvarchar](2) NULL,
	[brgy] [nvarchar](3) NULL,
	[class] [nvarchar](1) NULL,
 CONSTRAINT [PK_psgc] PRIMARY KEY CLUSTERED 
(
	[psgc_cd] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[lsdms_users]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lsdms_users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[lsdms_users](
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[CadSurvey]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CadSurvey]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CadSurvey](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[CadSurveyName] [varchar](50) NULL,
	[SurveyDateFrom] [varchar](50) NULL,
	[SurveyDateTo] [varchar](50) NULL,
	[Island] [varchar](20) NULL,
	[RegionPsgc] [nchar](9) NULL,
	[ProvincePsgc] [nchar](9) NULL,
	[CoordinateSystem] [varchar](10) NULL,
	[SurveySymbolNo] [int] NULL,
	[PreviousSurveyNo] [varchar](20) NULL,
	[ApprovedTotalMunicipality] [int] NULL,
	[ApprovedTotalCity] [int] NULL,
	[ApprovedTotalBarangay] [int] NULL,
	[ApprovedTotalLot] [int] NULL,
	[ApprovedTotalAreaHectares] [decimal](8, 2) NULL,
	[ApprovalRemarks] [text] NULL,
 CONSTRAINT [PK_CadSurvey] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[Municipality]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Municipality]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Municipality](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[MunicipalityPsgc] [nchar](9) NOT NULL,
 CONSTRAINT [PK_CadSurveyMunicipality] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC,
	[MunicipalityPsgc] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[Case]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Case]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Case](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[MunicipalityPsgc] [nchar](9) NOT NULL,
	[CadCaseNo] [varchar](20) NOT NULL,
	[GEName] [varchar](200) NULL,
	[ModuleNo] [int] NULL,
 CONSTRAINT [PK_CadSurveyCase] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC,
	[MunicipalityPsgc] ASC,
	[CadCaseNo] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[Barangay]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Barangay]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Barangay](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[MunicipalityPsgc] [nchar](9) NOT NULL,
	[CadCaseNo] [varchar](20) NOT NULL,
	[BarangayPsgc] [nchar](9) NOT NULL,
 CONSTRAINT [PK_CadSurveyMunicipalityCaseBarangay] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC,
	[MunicipalityPsgc] ASC,
	[CadCaseNo] ASC,
	[BarangayPsgc] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[Section]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Section]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Section](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[MunicipalityPsgc] [nchar](9) NOT NULL,
	[CadCaseNo] [varchar](20) NOT NULL,
	[BarangayPsgc] [nchar](9) NOT NULL,
	[SectionId] [varchar](20) NOT NULL,
	[Quadrangle] [varchar](200) NULL,
	[Scale] [int] NULL,
 CONSTRAINT [PK_CadSurveyMunicipalityCaseBarangaySection] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC,
	[MunicipalityPsgc] ASC,
	[CadCaseNo] ASC,
	[BarangayPsgc] ASC,
	[SectionId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[Lot]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lot]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Lot](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[MunicipalityPsgc] [nchar](9) NOT NULL,
	[CadCaseNo] [varchar](20) NOT NULL,
	[BarangayPsgc] [nchar](9) NOT NULL,
	[SectionId] [varchar](20) NOT NULL,
	[LotNo] [varchar](10) NOT NULL,
	[ClaimantName] [varchar](200) NULL,
	[ClaimantAddress] [varchar](200) NULL,
	[DeclaredArea] [decimal](10, 2) NULL,
	[ComputedArea] [decimal](10, 2) NULL,
	[ReferencePoint] [nvarchar](20) NULL,
	[TieLineNS] [char](1) NULL,
	[TieLineEW] [char](1) NULL,
	[TieLineDegree] [int] NULL,
	[TieLineMinute] [int] NULL,
	[TieLineDistance] [decimal](10, 2) NULL,
	[OriginalCheckedBy] [varchar](50) NULL,
	[OriginalCheckedDate] [varchar](20) NULL,
	[OriginalCompletedBy] [varchar](50) NULL,
	[OriginalCompletedDate] [varchar](20) NULL,
	[DuplicateCheckedBy] [varchar](50) NULL,
	[DuplicateCheckedDate] [varchar](20) NULL,
	[FinalVerifiedBy] [varchar](50) NULL,
	[FinalCheckedBy1] [varchar](50) NULL,
	[FinalCheckedBy2] [varchar](50) NULL,
	[Remarks] [varchar](500) NULL,
	[LRCNo] [varchar](50) NULL,
 CONSTRAINT [PK_CadLot] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC,
	[MunicipalityPsgc] ASC,
	[CadCaseNo] ASC,
	[BarangayPsgc] ASC,
	[SectionId] ASC,
	[LotNo] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[LotData]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LotData]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LotData](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[MunicipalityPsgc] [nchar](9) NOT NULL,
	[CadCaseNo] [varchar](20) NOT NULL,
	[BarangayPsgc] [nchar](9) NOT NULL,
	[SectionId] [varchar](20) NOT NULL,
	[LotNo] [varchar](10) NOT NULL,
	[Sequence] [smallint] NOT NULL,
	[LocalX] [decimal](7, 2) NULL,
	[LocalY] [decimal](7, 2) NULL,
	[PtmX] [decimal](14, 7) NULL,
	[PtmY] [decimal](14, 7) NULL,
	[WgsX] [decimal](11, 5) NULL,
	[WgsY] [decimal](11, 5) NULL,
	[PrsX] [decimal](11, 5) NULL,
	[PrsY] [decimal](11, 5) NULL,
 CONSTRAINT [PK_LotDataParcel] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC,
	[MunicipalityPsgc] ASC,
	[CadCaseNo] ASC,
	[BarangayPsgc] ASC,
	[SectionId] ASC,
	[LotNo] ASC,
	[Sequence] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO


/****** Object:  Table [dbo].[TechDesc]    Script Date: 05/29/2008 09:30:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TechDesc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TechDesc](
	[CadSurveyNo] [varchar](20) NOT NULL,
	[MunicipalityPsgc] [nchar](9) NOT NULL,
	[CadCaseNo] [varchar](20) NOT NULL,
	[BarangayPsgc] [nchar](9) NOT NULL,
	[SectionId] [varchar](20) NOT NULL,
	[LotNo] [varchar](10) NOT NULL,
	[FromCorner] [smallint] NOT NULL,
	[ToCorner] [smallint] NULL,
	[Distance] [decimal](18, 4) NULL,
	[NS] [char](2) NULL,
	[Degree] [int] NULL,
	[Minute] [int] NULL,
	[EW] [char](2) NULL,
 CONSTRAINT [PK_TechnicalDescriptionParcel] PRIMARY KEY CLUSTERED 
(
	[CadSurveyNo] ASC,
	[MunicipalityPsgc] ASC,
	[CadCaseNo] ASC,
	[BarangayPsgc] ASC,
	[SectionId] ASC,
	[LotNo] ASC,
	[FromCorner] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CadSurveyMunicipality_CadSurvey]') AND parent_object_id = OBJECT_ID(N'[dbo].[Municipality]'))
ALTER TABLE [dbo].[Municipality]  WITH NOCHECK ADD  CONSTRAINT [FK_CadSurveyMunicipality_CadSurvey] FOREIGN KEY([CadSurveyNo])
REFERENCES [dbo].[CadSurvey] ([CadSurveyNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Municipality] CHECK CONSTRAINT [FK_CadSurveyMunicipality_CadSurvey]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CadSurveyMunicipalityCase_CadSurveyMunicipality]') AND parent_object_id = OBJECT_ID(N'[dbo].[Case]'))
ALTER TABLE [dbo].[Case]  WITH CHECK ADD  CONSTRAINT [FK_CadSurveyMunicipalityCase_CadSurveyMunicipality] FOREIGN KEY([CadSurveyNo], [MunicipalityPsgc])
REFERENCES [dbo].[Municipality] ([CadSurveyNo], [MunicipalityPsgc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CadSurveyMunicipalityCaseBarangay_CadSurveyMunicipalityCase]') AND parent_object_id = OBJECT_ID(N'[dbo].[Barangay]'))
ALTER TABLE [dbo].[Barangay]  WITH CHECK ADD  CONSTRAINT [FK_CadSurveyMunicipalityCaseBarangay_CadSurveyMunicipalityCase] FOREIGN KEY([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo])
REFERENCES [dbo].[Case] ([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CadSurveyMunicipalityCaseBarangaySection_CadSurveyMunicipalityCaseBarangay]') AND parent_object_id = OBJECT_ID(N'[dbo].[Section]'))
ALTER TABLE [dbo].[Section]  WITH CHECK ADD  CONSTRAINT [FK_CadSurveyMunicipalityCaseBarangaySection_CadSurveyMunicipalityCaseBarangay] FOREIGN KEY([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc])
REFERENCES [dbo].[Barangay] ([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CadLot_CadSurveyMunicipalityCaseBarangaySection]') AND parent_object_id = OBJECT_ID(N'[dbo].[Lot]'))
ALTER TABLE [dbo].[Lot]  WITH CHECK ADD  CONSTRAINT [FK_CadLot_CadSurveyMunicipalityCaseBarangaySection] FOREIGN KEY([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc], [SectionId])
REFERENCES [dbo].[Section] ([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc], [SectionId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LotData_Lot]') AND parent_object_id = OBJECT_ID(N'[dbo].[LotData]'))
ALTER TABLE [dbo].[LotData]  WITH CHECK ADD  CONSTRAINT [FK_LotData_Lot] FOREIGN KEY([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc], [SectionId], [LotNo])
REFERENCES [dbo].[Lot] ([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc], [SectionId], [LotNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TechnicalDescriptionParcel_CadSurveyMunicipalityCaseBarangaySectionLot]') AND parent_object_id = OBJECT_ID(N'[dbo].[TechDesc]'))
ALTER TABLE [dbo].[TechDesc]  WITH CHECK ADD  CONSTRAINT [FK_TechnicalDescriptionParcel_CadSurveyMunicipalityCaseBarangaySectionLot] FOREIGN KEY([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc], [SectionId], [LotNo])
REFERENCES [dbo].[Lot] ([CadSurveyNo], [MunicipalityPsgc], [CadCaseNo], [BarangayPsgc], [SectionId], [LotNo])
ON UPDATE CASCADE
ON DELETE CASCADE



/****** Action:  Copy [prs92] to [prs92_temp]    Script Date: 05/29/2008 09:30:18 ******/
USE [prs92_temp]

/*** Copy existing data ***/

-- PSGC
INSERT INTO [prs92_temp].[dbo].[psgc] SELECT * FROM [prs92].[dbo].[psgc]

-- CadSurvey
INSERT INTO [prs92_temp].[dbo].[CadSurvey] SELECT * FROM [prs92].[dbo].[CadSurvey]
-- Municipality
INSERT INTO [prs92_temp].[dbo].[Municipality] SELECT * FROM [prs92].[dbo].[Municipality]
-- Case
INSERT INTO [prs92_temp].[dbo].[Case] SELECT * FROM [prs92].[dbo].[Case]
-- Barangay
INSERT INTO [prs92_temp].[dbo].[Barangay] SELECT * FROM [prs92].[dbo].[Barangay]
-- Section
INSERT INTO [prs92_temp].[dbo].[Section] SELECT * FROM [prs92].[dbo].[Section]
-- Lot
INSERT INTO [prs92_temp].[dbo].[Lot] SELECT * FROM [prs92].[dbo].[Lot]
-- LotData
INSERT INTO [prs92_temp].[dbo].[LotData] SELECT * FROM [prs92].[dbo].[LotData]
-- TechDesc
INSERT INTO [prs92_temp].[dbo].[TechDesc] SELECT * FROM [prs92].[dbo].[TechDesc]
-- lsdms_users
INSERT INTO [prs92_temp].[dbo].[lsdms_users] SELECT * FROM [prs92].[dbo].[lsdms_users]


-- geoprov
INSERT INTO [prs92_temp].[dbo].[geoprov] SELECT * FROM [prs92].[dbo].[geoprov]
-- gnis_users
INSERT INTO [prs92_temp].[dbo].[gnis_users] SELECT * FROM [prs92].[dbo].[gnis_users]
-- horfixme
INSERT INTO [prs92_temp].[dbo].[horfixme] SELECT * FROM [prs92].[dbo].[horfixme]
-- markpur
INSERT INTO [prs92_temp].[dbo].[markpur] SELECT * FROM [prs92].[dbo].[markpur]
-- markstatus
INSERT INTO [prs92_temp].[dbo].[markstatus] SELECT * FROM [prs92].[dbo].[markstatus]
-- marktype
INSERT INTO [prs92_temp].[dbo].[marktype] SELECT * FROM [prs92].[dbo].[marktype]
-- order_lib
INSERT INTO [prs92_temp].[dbo].[order_lib] SELECT * FROM [prs92].[dbo].[order_lib]
-- projects
INSERT INTO [prs92_temp].[dbo].[projects] SELECT * FROM [prs92].[dbo].[projects]
-- ref_type_lib
INSERT INTO [prs92_temp].[dbo].[ref_type_lib] SELECT * FROM [prs92].[dbo].[ref_type_lib]
-- ref_type_table
INSERT INTO [prs92_temp].[dbo].[ref_type_table] SELECT * FROM [prs92].[dbo].[ref_type_table]


/*** Create a backup of [prs92] and [prs92_temp] database ***/
DECLARE @backup_name varchar(50)
SET @backup_name = 'prs92 [' + CAST(MONTH(GETDATE()) AS varchar(2)) + '-' + CAST(DAY(GETDATE()) AS varchar(2)) + '-' + CAST(YEAR(GETDATE()) AS varchar(4)) + '][' + CAST(DATEPART(HOUR,GETDATE()) AS varchar(2)) + CAST(DATEPART(MINUTE,GETDATE()) AS varchar(2)) + '].bak'
BACKUP DATABASE [prs92] TO DISK=@backup_name WITH FORMAT
SET @backup_name = 'prs92_temp.bak'
BACKUP DATABASE [prs92] TO DISK=@backup_name WITH FORMAT
GO


/*** Drop both [prs92] and [prs92_temp] database ***/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'prs92')
DROP DATABASE [prs92]
GO
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'prs92_temp')
DROP DATABASE [prs92_temp]
GO


/*** Restore [prs92_temp] as [prs92]***/
RESTORE DATABASE [prs92] 
   FROM DISK = 'prs92_temp.bak'
   WITH MOVE 'prs92Data' TO N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92.mdf',
   MOVE 'prs92Log' TO N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92.ldf'
GO





-- END --














-- RESTORE FILELISTONLY FROM DISK='prs92.bak'

  
-- ALTER DATABASE [prs92] MODIFY FILE(NAME='prs92_d',FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92_d.mdf')  
-- ALTER DATABASE [prs92] MODIFY FILE(NAME='prs92_l',FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92_l.mdf')  
  
-- %ProgramFiles%\Microsoft SQL Server\MSSQL.1\MSSQL\Data





