-- BACKUP PRS92 with DAta
BACKUP DATABASE [PRS92] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\prs92_withdata.bak' WITH NOFORMAT, INIT,  NAME = N'PRS92-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO

-- DROP PRS92 Database with Data
EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'PRS92'
GO
USE [master]
GO
/****** Object:  Database [PRS92]    Script Date: 07/16/2008 10:47:06 ******/
DROP DATABASE [PRS92]
GO


-- RESTORE BLANK PRS92 Database
RESTORE DATABASE [PRS92] FROM  DISK = N'C:\Documents and Settings\ghelo\Desktop\LSDMS v1.5\DatabaseUpdater\SQL\prs92_blank.bak' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10
GO


-- RESTORE PRS92 Database with Data
RESTORE DATABASE [PRS92] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\prs92_withdata.bak' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10
GO



-- RESTORE PRS92 with OLD STRUCTURE and DATA
RESTORE DATABASE [prs92] FROM  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\prs92 [09192007][1324].bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 10
GO
