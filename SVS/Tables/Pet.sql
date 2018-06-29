CREATE TABLE [dbo].[Pet]
(
	[PetName] nvarchar(25) NOT NULL,
	[Type] nvarchar(15) NOT NULL,
	[OwnerID] INT NOT NULL,

	CONSTRAINT PK_PetOwner PRIMARY KEY (OwnerID, PetName),
	CONSTRAINT FK_PetOwner FOREIGN KEY (OwnerID) REFERENCES [Owner](OwnerID)
)
