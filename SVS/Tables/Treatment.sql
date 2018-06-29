CREATE TABLE [dbo].[Treatment]
(
	[PetName] nvarchar(25) NOT NULL,
	[OwnerID] INT NOT NULL,
	[ProcedureID] INT NOT NULL,
	[TreatmentDate] DATETIME NOT NULL,
	[Notes] nvarchar(250) NOT NULL,
	[TreatmentPrice] MONEY NOT NULL,
	
	CONSTRAINT PK_TreatmentID PRIMARY KEY (OwnerID, PetName, ProcedureID, TreatmentDate),
	CONSTRAINT FK_TreatmentIDs FOREIGN KEY (OwnerID, PetName) REFERENCES [Pet](OwnerID, PetName),
	CONSTRAINT FK_TreatmentProcID FOREIGN KEY (ProcedureID) REFERENCES [Procedure](ProcedureID)
	
)
