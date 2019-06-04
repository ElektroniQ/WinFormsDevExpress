CREATE TABLE [dbo].[ExportHistory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NULL, 
    [DateTime] DATETIME NULL, 
    [User] NCHAR(50) NULL, 
    [Place] NCHAR(50) NULL
)
