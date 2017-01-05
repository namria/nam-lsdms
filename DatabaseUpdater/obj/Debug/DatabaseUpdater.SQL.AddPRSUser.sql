USE [prs92]

IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'prs92')
CREATE LOGIN [prs92] WITH PASSWORD=N'prs92', DEFAULT_DATABASE=[prs92], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'prs92')
DROP USER [prs92]
CREATE USER [prs92] FOR LOGIN [prs92] WITH DEFAULT_SCHEMA=[dbo]
EXEC sp_addrolemember N'db_owner', N'prs92'
