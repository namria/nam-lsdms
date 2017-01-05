USE [master]
GO
DECLARE @DatabaseName nvarchar(50)
DECLARE @SQL varchar(10)

SET @DatabaseName = N'prs92'
DECLARE my_cursor CURSOR FAST_FORWARD FOR SELECT 'KILL ' + CAST(SPId AS varchar(10)) FROM MASTER..SysProcesses WHERE DBId = DB_ID(@DatabaseName) AND SPId <> @@SPId
OPEN my_cursor

FETCH NEXT FROM my_cursor INTO @SQL
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC(@SQL)
		PRINT(@SQL)
		FETCH NEXT FROM my_cursor INTO @SQL
	END
CLOSE my_cursor
DEALLOCATE my_cursor

DROP DATABASE [prs92]
