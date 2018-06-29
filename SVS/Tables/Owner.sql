CREATE TABLE [dbo].[Owner]
(
	[OwnerID] INT NOT NULL,
	[GivenName] nvarchar(25) NOT NULL,
	[Surname] nvarchar(50) NOT NULL,
	[Phone] INT NOT NULL,

	CONSTRAINT PK_Owner PRIMARY KEY (OwnerID)
)
