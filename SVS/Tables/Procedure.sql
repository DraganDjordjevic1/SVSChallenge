CREATE TABLE [dbo].[Procedure]
(
	[ProcedureID] INT NOT NULL,
	[Description] nvarchar(250) NOT NULL,
	[ProcedurePrice] MONEY NOT NULL,
	CONSTRAINT PK_Procedure PRIMARY KEY (ProcedureID)
)
