CREATE TABLE Organiser (
    Id uniqueidentifier NOT NULL UNIQUE,
	Name nvarchar(500) NOT NULL,
	Event nvarchar(500) NOT NULL,
	FreeDates DateTime NOT NULL
	
	CONSTRAINT PK_Organiser PRIMARY KEY clustered (Id)
)

CREATE TABLE Attendees (
    Id uniqueidentifier NOT NULL UNIQUE,
    OrganiserId uniqueidentifier NOT NULL,
    Name nvarchar(500) NOT NULL,
	FreeDates DateTime NOT NULL
	
	CONSTRAINT PK_Attendees PRIMARY KEY clustered (Id)
	CONSTRAINT FK_Attendees_Organiser FOREIGN KEY (OrganiserId) REFERENCES Organiser (Id)
)