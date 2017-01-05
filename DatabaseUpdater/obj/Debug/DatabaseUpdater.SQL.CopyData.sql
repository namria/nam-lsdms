

-- CadSurvey
ALTER TABLE [PRS92].[dbo].[CadSurvey] NOCHECK CONSTRAINT ALL

INSERT INTO [PRS92].[dbo].[CadSurvey]
           ([CadSurveyNo]
           ,[Island]
           ,[RegionPsgc]
           ,[ProvincePsgc]
           ,[CoordinateSystem]
           ,[SurveySymbolNo]
           ,[PreviousSurveyNo]
           ,[ApprovedTotalMunicipality]
           ,[ApprovedTotalCity]
           ,[ApprovedTotalBarangay]
           ,[ApprovedTotalLot]
           ,[ApprovedTotalAreaHectares]
           ,[ApprovalRemarks])
SELECT 
			[CadSurveyNo]
           ,[Island]
           ,[RegionPsgc]
           ,[ProvincePsgc]
           ,[CoordinateSystem]
           ,[SurveySymbolNo]
           ,[PreviousSurveyNo]
           ,[ApprovedTotalMunicipality]
           ,[ApprovedTotalCity]
           ,[ApprovedTotalBarangay]
           ,[ApprovedTotalLot]
           ,[ApprovedTotalAreaHectares]
           ,[ApprovalRemarks]
FROM [{0}].[dbo].[CadSurvey]

ALTER TABLE [PRS92].[dbo].[CadSurvey] CHECK CONSTRAINT ALL


-- Municipality
ALTER TABLE [PRS92].[dbo].[Municipality] NOCHECK CONSTRAINT ALL

INSERT INTO [PRS92].[dbo].[Municipality]
           ([CadSurveyNo]
           ,[MunicipalityPsgc])
SELECT 
			[CadSurveyNo]
           ,[MunicipalityPsgc]
FROM [{0}].[dbo].[Municipality]

ALTER TABLE [PRS92].[dbo].[Municipality] CHECK CONSTRAINT ALL

-- Case
ALTER TABLE [PRS92].[dbo].[Case] NOCHECK CONSTRAINT ALL

INSERT INTO [PRS92].[dbo].[Case]
           ([CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[ModuleNo])
SELECT 
			[CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[ModuleNo]
FROM [{0}].[dbo].[Case]

ALTER TABLE [PRS92].[dbo].[Case] CHECK CONSTRAINT ALL

-- Barangay
ALTER TABLE [PRS92].[dbo].[Barangay] NOCHECK CONSTRAINT ALL

INSERT INTO [PRS92].[dbo].[Barangay] 
		   ([CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc])
SELECT 
		   [CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
FROM [{0}].[dbo].[Barangay]

ALTER TABLE [PRS92].[dbo].[Barangay] CHECK CONSTRAINT ALL


-- Quadrangle
ALTER TABLE [PRS92].[dbo].[Quadrangle] NOCHECK CONSTRAINT ALL

INSERT INTO [PRS92].[dbo].[Quadrangle]
           ([CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle])
SELECT 
           [CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle]
FROM [{0}].[dbo].[Quadrangle]

ALTER TABLE [PRS92].[dbo].[Quadrangle] CHECK CONSTRAINT ALL


-- Section
ALTER TABLE [PRS92].[dbo].[Section] NOCHECK CONSTRAINT ALL

INSERT INTO [PRS92].[dbo].[Section] 
		   ([CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle]
           ,[SectionId]
           ,[Scale])
SELECT 
			[CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle]
           ,[SectionId]
           ,[Scale]
FROM [{0}].[dbo].[Section]

ALTER TABLE [PRS92].[dbo].[Section] CHECK CONSTRAINT ALL


-- Lot
ALTER TABLE [PRS92].[dbo].[Lot] NOCHECK CONSTRAINT ALL
INSERT INTO [PRS92].[dbo].[Lot]
           ([CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle]
           ,[SectionId]
           ,[LotNo]
           ,[ClaimantName]
           ,[ClaimantAddress]
           ,[DeclaredArea]
           ,[ComputedArea]
           ,[ReferencePoint]
           ,[TieLineNS]
           ,[TieLineEW]
           ,[TieLineDegree]
           ,[TieLineMinute]
           ,[TieLineDistance]
           ,[OriginalCheckedBy]
           ,[OriginalCheckedDate]
           ,[OriginalCompletedBy]
           ,[OriginalCompletedDate]
           ,[DuplicateCheckedBy]
           ,[DuplicateCheckedDate]
           ,[FinalVerifiedBy]
           ,[FinalCheckedBy1]
           ,[FinalCheckedBy2]
           ,[Remarks]
           ,[LRCNo]
		   ,[GEName])
SELECT 
			[CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle]
           ,[SectionId]
           ,[LotNo]
           ,[ClaimantName]
           ,[ClaimantAddress]
           ,[DeclaredArea]
           ,[ComputedArea]
           ,[ReferencePoint]
           ,[TieLineNS]
           ,[TieLineEW]
           ,[TieLineDegree]
           ,[TieLineMinute]
           ,[TieLineDistance]
           ,[OriginalCheckedBy]
           ,[OriginalCheckedDate]
           ,[OriginalCompletedBy]
           ,[OriginalCompletedDate]
           ,[DuplicateCheckedBy]
           ,[DuplicateCheckedDate]
           ,[FinalVerifiedBy]
           ,[FinalCheckedBy1]
           ,[FinalCheckedBy2]
           ,[Remarks]
           ,[LRCNo]
           ,(SELECT GEName FROM [{0}].[dbo].[Case] WHERE [Case].CadSurveyNo = Lot.CadSurveyNo AND [Case].MunicipalityPsgc = Lot.MunicipalityPsgc AND [Case].CadCaseNo = Lot.CadCaseNo) AS [GEName] 
FROM [{0}].[dbo].[Lot]

ALTER TABLE [PRS92].[dbo].[Lot] CHECK CONSTRAINT ALL


-- LotData
ALTER TABLE [PRS92].[dbo].[LotData] NOCHECK CONSTRAINT ALL
INSERT INTO [PRS92].[dbo].[LotData]
           ([CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle]
           ,[SectionId]
           ,[LotNo]
           ,[Sequence]
           ,[LocalX]
           ,[LocalY]
           ,[PtmX]
           ,[PtmY]
           ,[WgsX]
           ,[WgsY]
           ,[PrsX]
           ,[PrsY])
SELECT 
		   [CadSurveyNo]
		  ,[MunicipalityPsgc]
		  ,[CadCaseNo]
		  ,[BarangayPsgc]
		  ,[Quadrangle]
		  ,[SectionId]
		  ,[LotNo]
		  ,[Sequence]
		  ,[LocalX]
		  ,[LocalY]
		  ,[PtmX]
		  ,[PtmY]
		  ,[WgsX]
		  ,[WgsY]
		  ,[PrsX]
		  ,[PrsY]
FROM [{0}].[dbo].[LotData]

ALTER TABLE [PRS92].[dbo].[LotData] CHECK CONSTRAINT ALL



-- TechDesc
ALTER TABLE [PRS92].[dbo].[TechDesc] NOCHECK CONSTRAINT ALL

INSERT INTO [PRS92].[dbo].[TechDesc]
           ([CadSurveyNo]
           ,[MunicipalityPsgc]
           ,[CadCaseNo]
           ,[BarangayPsgc]
           ,[Quadrangle]
           ,[SectionId]
           ,[LotNo]
           ,[FromCorner]
           ,[ToCorner]
           ,[Distance]
           ,[NS]
           ,[Degree]
           ,[Minute]
           ,[EW])
SELECT 
		   [CadSurveyNo]
		  ,[MunicipalityPsgc]
		  ,[CadCaseNo]
		  ,[BarangayPsgc]
		  ,[Quadrangle]
		  ,[SectionId]
		  ,[LotNo]
		  ,[FromCorner]
		  ,[ToCorner]
		  ,[Distance]
		  ,[NS]
		  ,[Degree]
		  ,[Minute]
		  ,[EW]
FROM [{0}].[dbo].[TechDesc]

ALTER TABLE [PRS92].[dbo].[TechDesc] CHECK CONSTRAINT ALL




-- geoprov
DELETE FROM [PRS92].[dbo].[geoprov]
ALTER TABLE [PRS92].[dbo].[geoprov] NOCHECK CONSTRAINT ALL
INSERT INTO [PRS92].[dbo].[geoprov]
           ([stat_name]
           ,[stat_new]
           ,[region]
           ,[province]
           ,[municipal]
           ,[barangay]
           ,[date_est]
           ,[date_las_r]
           ,[island]
           ,[d_lat]
           ,[m_lat]
           ,[s_lat]
           ,[d_long]
           ,[m_long]
           ,[s_long]
           ,[h_coords_s]
           ,[h_date_ety]
           ,[h_datum]
           ,[h_ref]
           ,[e_h_datum]
           ,[hor_authty]
           ,[h_order]
           ,[h_date_com]
           ,[h_fix]
           ,[elevation]
           ,[ell_hgt]
           ,[e_date_ety]
           ,[e_datum]
           ,[e_e_datum]
           ,[elv_authty]
           ,[e_order]
           ,[e_date_com]
           ,[e_fix]
           ,[mark_stat]
           ,[mark_type]
           ,[mark_const]
           ,[authority]
           ,[wgs84ND]
           ,[wgs84NM]
           ,[wgs84NS]
           ,[wgs84ED]
           ,[wgs84EM]
           ,[wgs84ES]
           ,[latitude]
           ,[longitude]
           ,[ellipz]
           ,[image]
           ,[inscription]
           ,[description]
           ,[encoder])
SELECT		
			[stat_name]
           ,[stat_new]
           ,[region]
           ,[province]
           ,[municipal]
           ,[barangay]
           ,[date_est]
           ,[date_las_r]
           ,[island]
           ,[d_lat]
           ,[m_lat]
           ,[s_lat]
           ,[d_long]
           ,[m_long]
           ,[s_long]
           ,[h_coords_s]
           ,[h_date_ety]
           ,[h_datum]
           ,[h_ref]
           ,[e_h_datum]
           ,[hor_authty]
           ,[h_order]
           ,[h_date_com]
           ,[h_fix]
           ,[elevation]
           ,[ell_hgt]
           ,[e_date_ety]
           ,[e_datum]
           ,[e_e_datum]
           ,[elv_authty]
           ,[e_order]
           ,[e_date_com]
           ,[e_fix]
           ,[mark_stat]
           ,[mark_type]
           ,[mark_const]
           ,[authority]
           ,[wgs84ND]
           ,[wgs84NM]
           ,[wgs84NS]
           ,[wgs84ED]
           ,[wgs84EM]
           ,[wgs84ES]
           ,NULL
           ,NULL
           ,[ellipz]
           ,NULL
           ,[inscription]
           ,[description]
           ,NULL
FROM [{0}].[dbo].[geoprov]
ALTER TABLE [PRS92].[dbo].[geoprov] CHECK CONSTRAINT ALL


-- gnis_users
DELETE FROM [PRS92].[dbo].[gnis_users]
INSERT INTO [PRS92].[dbo].[gnis_users] SELECT * FROM [{0}].[dbo].[gnis_users]

--IF  NOT EXISTS (SELECT * FROM [PRS92].[dbo].[gnis_users])
--	INSERT INTO [PRS92].[dbo].[gnis_users]
--			   ([Username]
--			   ,[Password]
--			   ,[Access]
--			   ,[Picture])
--	VALUES ('administrator','admin',1,1)


-- horfixme
DELETE FROM [PRS92].[dbo].[horfixme]
INSERT INTO [PRS92].[dbo].[horfixme]
           ([HCode]
           ,[HDesc])
SELECT [HCode]
      ,[HDesc]
FROM [{0}].[dbo].[horfixme]

-- markpur
DELETE FROM [PRS92].[dbo].[markpur]
INSERT INTO [PRS92].[dbo].[markpur]
           ([MCode]
           ,[MDesc])
SELECT [MCode]
      ,[MDesc]
FROM [{0}].[dbo].[markpur]


-- markstatus
DELETE FROM [PRS92].[dbo].[markstatus]
INSERT INTO [PRS92].[dbo].[markstatus]
           ([MSCode]
           ,[MSDesc])
SELECT [MSCode]
      ,[MSDesc]
FROM [{0}].[dbo].[markstatus]


-- marktype
DELETE FROM [PRS92].[dbo].[marktype]
INSERT INTO [PRS92].[dbo].[marktype]
           ([MTCode]
           ,[MTDesc])
SELECT [MTCode]
      ,[MTDesc]
FROM [{0}].[dbo].[marktype]


-- order_lib
DELETE FROM [PRS92].[dbo].[order_lib]
INSERT INTO [PRS92].[dbo].[order_lib]
           ([h_order]
           ,[description])
SELECT [h_order]
      ,[description]
FROM [{0}].[dbo].[order_lib]

-- projects
DELETE FROM [PRS92].[dbo].[projects]
INSERT INTO [PRS92].[dbo].[projects] SELECT * FROM [{0}].[dbo].[projects]

-- ref_type_lib
DELETE FROM [PRS92].[dbo].[ref_type_lib]
INSERT INTO [PRS92].[dbo].[ref_type_lib]
           ([Code]
           ,[Ref_Type]
           ,[Description])
SELECT [Code]
      ,[Ref_Type]
      ,[Description]
FROM [{0}].[dbo].[ref_type_lib]           

-- ref_type_table
INSERT INTO [PRS92].[dbo].[ref_type_table]
           ([Ref_Type]
           ,[Ref_Type_No]
           ,[Project_No]
           ,[False_Northing]
           ,[False_Easting]
           ,[True_Northing]
           ,[True_Easting]
           ,[PTM_PRS92_Northing]
           ,[PTM_PRS92_Easting]
           ,[Latitude]
           ,[Longitude]
           ,[PRSLong]
           ,[PRSLat]
           ,[PRSEllipsoidalHt]
           ,[WGSLong]
           ,[WGSLat]
           ,[WGSEllipsoidalHt]
           ,[Sketch]
           ,[Description]
           ,[Remarks]
           ,[Status])
SELECT 
			[Ref_Type]
           ,[Ref_Type_No]
           ,[Project_No]
           ,[False_Northing]
           ,[False_Easting]
           ,[True_Northing]
           ,[True_Easting]
           ,[PTM_PRS92_Northing]
           ,[PTM_PRS92_Easting]
           ,[Latitude]
           ,[Longitude]
           ,[PRSLong]
           ,[PRSLat]
           ,[PRSEllipsoidalHt]
           ,[WGSLong]
           ,[WGSLat]
           ,[WGSEllipsoidalHt]
           ,NULL
           ,[Description]
           ,[Remarks]
           ,[Status]
FROM [{0}].[dbo].[ref_type_table]


