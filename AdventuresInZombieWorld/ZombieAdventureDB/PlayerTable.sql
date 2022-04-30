CREATE TABLE [dbo].[PlayerTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(MAX) NULL, 
    [Password] NVARCHAR(MAX) NULL, 
    [PlayerType] NVARCHAR(50) NULL, 
    [PlayerStat] NVARCHAR(50) NULL
)
