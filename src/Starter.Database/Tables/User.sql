﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL,
	[Email] NVARCHAR(200) NOT NULL,
	[DisplayName] NVARCHAR(200) NOT NULL,

	CONSTRAINT [PK_User_Id] PRIMARY KEY ([Id]),
	CONSTRAINT [UQ_User_Email] UNIQUE ([Email])
)