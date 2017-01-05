USE [prs92_old]

/*
RESTORE DATABASE [prs92_old] 
   FROM DISK = 'H:\regional training\Installer\Blank Database\prs92.bak'
   WITH MOVE 'lsdms'      TO N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92_old.mdf',
        MOVE 'lsdms_log'  TO N'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\prs92_old.ldf'
GO
*/


/* ALTER Section.Quadrangle to varchar(50) */
ALTER TABLE  dbo.Section ALTER COLUMN Quadrangle varchar(50)


/* ALTER Lot.ClaimantName to varchar(200) */
ALTER TABLE  dbo.Lot ALTER COLUMN ClaimantName varchar(200)


/* ADD Lot.LRCNo varchar(50) */
ALTER TABLE  dbo.Lot ADD LRCNo varchar(50)


/* ALTER Case.GEName to varchar(200) */
ALTER TABLE dbo.[Case] ALTER COLUMN GEName varchar(200)


/* ALTER SectionId to varchar(20) */
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Section
	DROP CONSTRAINT FK_CadSurveyMunicipalityCaseBarangaySection_CadSurveyMunicipalityCaseBarangay
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Section
	(
	CadSurveyNo varchar(20) NOT NULL,
	MunicipalityPsgc nchar(9) NOT NULL,
	CadCaseNo varchar(20) NOT NULL,
	BarangayPsgc nchar(9) NOT NULL,
	SectionId varchar(20) NOT NULL,
	Quadrangle varchar(20) NULL,
	Scale int NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.Section)
	 EXEC('INSERT INTO dbo.Tmp_Section (CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, SectionId, Quadrangle, Scale)
		SELECT CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, CONVERT(varchar(20), SectionId), Quadrangle, Scale FROM dbo.Section WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.Lot
	DROP CONSTRAINT FK_CadLot_CadSurveyMunicipalityCaseBarangaySection
GO
DROP TABLE dbo.Section
GO
EXECUTE sp_rename N'dbo.Tmp_Section', N'Section', 'OBJECT' 
GO
ALTER TABLE dbo.Section ADD CONSTRAINT
	PK_CadSurveyMunicipalityCaseBarangaySection PRIMARY KEY CLUSTERED 
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Section ADD CONSTRAINT
	FK_CadSurveyMunicipalityCaseBarangaySection_CadSurveyMunicipalityCaseBarangay FOREIGN KEY
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc
	) REFERENCES dbo.Barangay
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Lot
	(
	CadSurveyNo varchar(20) NOT NULL,
	MunicipalityPsgc nchar(9) NOT NULL,
	CadCaseNo varchar(20) NOT NULL,
	BarangayPsgc nchar(9) NOT NULL,
	SectionId varchar(20) NOT NULL,
	LotNo varchar(10) NOT NULL,
	ClaimantName varchar(50) NULL,
	ClaimantAddress varchar(200) NULL,
	DeclaredArea decimal(10, 2) NULL,
	ComputedArea decimal(10, 2) NULL,
	ReferencePoint nvarchar(20) NULL,
	TieLineNS char(1) NULL,
	TieLineEW char(1) NULL,
	TieLineDegree int NULL,
	TieLineMinute int NULL,
	TieLineDistance decimal(10, 2) NULL,
	OriginalCheckedBy varchar(50) NULL,
	OriginalCheckedDate varchar(20) NULL,
	OriginalCompletedBy varchar(50) NULL,
	OriginalCompletedDate varchar(20) NULL,
	DuplicateCheckedBy varchar(50) NULL,
	DuplicateCheckedDate varchar(20) NULL,
	FinalVerifiedBy varchar(50) NULL,
	FinalCheckedBy1 varchar(50) NULL,
	FinalCheckedBy2 varchar(50) NULL,
	Remarks varchar(500) NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.Lot)
	 EXEC('INSERT INTO dbo.Tmp_Lot (CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, SectionId, LotNo, ClaimantName, ClaimantAddress, DeclaredArea, ComputedArea, ReferencePoint, TieLineNS, TieLineEW, TieLineDegree, TieLineMinute, TieLineDistance, OriginalCheckedBy, OriginalCheckedDate, OriginalCompletedBy, OriginalCompletedDate, DuplicateCheckedBy, DuplicateCheckedDate, FinalVerifiedBy, FinalCheckedBy1, FinalCheckedBy2, Remarks)
		SELECT CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, CONVERT(varchar(20), SectionId), LotNo, ClaimantName, ClaimantAddress, DeclaredArea, ComputedArea, ReferencePoint, TieLineNS, TieLineEW, TieLineDegree, TieLineMinute, TieLineDistance, OriginalCheckedBy, OriginalCheckedDate, OriginalCompletedBy, OriginalCompletedDate, DuplicateCheckedBy, DuplicateCheckedDate, FinalVerifiedBy, FinalCheckedBy1, FinalCheckedBy2, Remarks FROM dbo.Lot WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.TechDesc
	DROP CONSTRAINT FK_TechnicalDescriptionParcel_CadSurveyMunicipalityCaseBarangaySectionLot
GO
ALTER TABLE dbo.LotData
	DROP CONSTRAINT FK_LotDataParcel_CadSurveyMunicipalityCaseBarangaySectionLot
GO
DROP TABLE dbo.Lot
GO
EXECUTE sp_rename N'dbo.Tmp_Lot', N'Lot', 'OBJECT' 
GO
ALTER TABLE dbo.Lot ADD CONSTRAINT
	PK_CadLot PRIMARY KEY CLUSTERED 
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Lot ADD CONSTRAINT
	FK_CadLot_CadSurveyMunicipalityCaseBarangaySection FOREIGN KEY
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId
	) REFERENCES dbo.Section
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LotData
	(
	CadSurveyNo varchar(20) NOT NULL,
	MunicipalityPsgc nchar(9) NOT NULL,
	CadCaseNo varchar(20) NOT NULL,
	BarangayPsgc nchar(9) NOT NULL,
	SectionId varchar(20) NOT NULL,
	LotNo varchar(10) NOT NULL,
	Sequence smallint NOT NULL,
	LocalX decimal(7, 2) NULL,
	LocalY decimal(7, 2) NULL,
	PtmX decimal(14, 7) NULL,
	PtmY decimal(14, 7) NULL,
	WgsX decimal(11, 5) NULL,
	WgsY decimal(11, 5) NULL,
	PrsX decimal(11, 5) NULL,
	PrsY decimal(11, 5) NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.LotData)
	 EXEC('INSERT INTO dbo.Tmp_LotData (CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, SectionId, LotNo, Sequence, LocalX, LocalY, PtmX, PtmY, WgsX, WgsY, PrsX, PrsY)
		SELECT CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, CONVERT(varchar(20), SectionId), LotNo, Sequence, LocalX, LocalY, PtmX, PtmY, WgsX, WgsY, PrsX, PrsY FROM dbo.LotData WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.LotData
GO
EXECUTE sp_rename N'dbo.Tmp_LotData', N'LotData', 'OBJECT' 
GO
ALTER TABLE dbo.LotData ADD CONSTRAINT
	PK_LotDataParcel PRIMARY KEY CLUSTERED 
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo,
	Sequence
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LotData ADD CONSTRAINT
	FK_LotDataParcel_CadSurveyMunicipalityCaseBarangaySectionLot FOREIGN KEY
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo
	) REFERENCES dbo.Lot
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_TechDesc
	(
	CadSurveyNo varchar(20) NOT NULL,
	MunicipalityPsgc nchar(9) NOT NULL,
	CadCaseNo varchar(20) NOT NULL,
	BarangayPsgc nchar(9) NOT NULL,
	SectionId varchar(20) NOT NULL,
	LotNo varchar(10) NOT NULL,
	FromCorner smallint NOT NULL,
	ToCorner smallint NULL,
	Distance decimal(18, 4) NULL,
	NS char(2) NULL,
	Degree int NULL,
	Minute int NULL,
	EW char(2) NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.TechDesc)
	 EXEC('INSERT INTO dbo.Tmp_TechDesc (CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, SectionId, LotNo, FromCorner, ToCorner, Distance, NS, Degree, Minute, EW)
		SELECT CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, CONVERT(varchar(20), SectionId), LotNo, FromCorner, ToCorner, Distance, NS, Degree, Minute, EW FROM dbo.TechDesc WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.TechDesc
GO
EXECUTE sp_rename N'dbo.Tmp_TechDesc', N'TechDesc', 'OBJECT' 
GO
ALTER TABLE dbo.TechDesc ADD CONSTRAINT
	PK_TechnicalDescriptionParcel PRIMARY KEY CLUSTERED 
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo,
	FromCorner
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TechDesc ADD CONSTRAINT
	FK_TechnicalDescriptionParcel_CadSurveyMunicipalityCaseBarangaySectionLot FOREIGN KEY
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo
	) REFERENCES dbo.Lot
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT



/* Drop Municipality and Psgc constraint */
ALTER TABLE dbo.Municipality
	DROP CONSTRAINT FK_Municipality_psgc


/* Update LotData and Lot tables constraint name */

ALTER TABLE dbo.LotData
	DROP CONSTRAINT FK_LotDataParcel_CadSurveyMunicipalityCaseBarangaySectionLot

ALTER TABLE dbo.LotData ADD CONSTRAINT
	FK_LotData_Lot FOREIGN KEY
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo
	) REFERENCES dbo.Lot
	(
	CadSurveyNo,
	MunicipalityPsgc,
	CadCaseNo,
	BarangayPsgc,
	SectionId,
	LotNo
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
