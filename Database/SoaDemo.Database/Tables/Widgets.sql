﻿CREATE TABLE [dbo].[Widgets]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [LastUpdatedDate] DATETIME NULL DEFAULT getdate()
)
