﻿CREATE TABLE [dbo].[Cogs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [ProgramCodes] VARCHAR(200) NULL
)
