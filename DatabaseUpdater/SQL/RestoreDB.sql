/*
USE [master]
GO
DBCC SHRINKDATABASE (prs92, 5)
*/

DECLARE @dataName AS varchar(20)
DECLARE @logName  AS varchar(20)

CREATE TABLE #restoreTemp
(
	 LogicalName nvarchar(128)
	,Old_PhysicalName nvarchar(128)
	,[Type] char(1)
	,FileGroupName nvarchar(128)
	,[Size] numeric(20,0)
	,[MaxSize] numeric(20,0)
	,FileID bigint
	,CreateLSN numeric(25,0)
	,DropLSN numeric(25,0) NULL
	,UniqueID uniqueidentifier
	,ReadOnlyLSN numeric(25,0)
	,ReadWriteLSN numeric(25,0)
	,BackupSizeInByte bigint
	,SourceBlockSize int
	,FilegroupID int
	,LogGroupGUID uniqueidentifier NULL
	,DifferentialBaseLSN numeric(25,0)
	,DifferentialbaseGUID uniqueidentifier
	,IsReadOnly bit
	,IsPresent bit
)
INSERT #restoreTemp EXEC('RESTORE FILELISTONLY FROM DISK = ''{0}''')
SELECT @dataName = LogicalName FROM #restoreTemp WHERE [Type] = 'D'
SELECT @logName  = LogicalName FROM #restoreTemp WHERE [Type] = 'L'

RESTORE DATABASE [{1}]
   FROM DISK = '{0}'
   WITH MOVE @dataName TO N'{2}\{1}.mdf',
        MOVE @logName  TO N'{2}\{1}.ldf'

