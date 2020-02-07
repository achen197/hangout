CREATE TABLE Organiser (
    Id uniqueidentifier NOT NULL UNIQUE,
	Name nvarchar(500) NOT NULL,
	EventName nvarchar(500) NOT NULL,
	DatesAvailable DateTime NOT NULL
	
	CONSTRAINT PK_Organiser PRIMARY KEY clustered (Id)
)