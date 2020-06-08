

CREATE DATABASE StefDb;
GO

USE StefDb;
GO

CREATE TABLE Task(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(30) NOT NULL,
Description VARCHAR(150),
Is_Active BIT NOT NULL,
Date_Created DATETIME NOT NULL,
Date_Updated DATETIME NOT NULL
);
GO
CREATE TABLE Profile_Type(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR (30) NOT NULL,
Is_Active BIT NOT NULL,
Date_Created DATETIME NOT NULL,
Date_Updated DATETIME NOT NULL
);
GO
CREATE TABLE Profile_Type_Task(
Id INT PRIMARY KEY IDENTITY(1,1),
Task_Id INT NOT NULL,
Profile_Type_Id INT NOT NULL
);
GO

ALTER TABLE Profile_Type_Task ADD CONSTRAINT Profile_Type_TaskFk FOREIGN KEY (Task_Id) REFERENCES Task(Id);
GO
ALTER TABLE Profile_Type_Task ADD CONSTRAINT Profile_Type_Profile_TypeFk FOREIGN KEY (Profile_Type_Id) REFERENCES Profile_Type(Id);
GO

CREATE TABLE User_System(
Id INT PRIMARY KEY IDENTITY(1,1),
User_Name VARCHAR(30) NOT NULL,
Password VARCHAR(30) NOT NULL,
Profile_Type_Id INT NOT NULL,
Is_Active BIT NOT NULL,
Date_Created DATETIME NOT NULL,
Date_Updated DATETIME NOT NULL
);
GO

ALTER TABLE User_System ADD CONSTRAINT User_System_Profile_TypeFk FOREIGN KEY (Profile_Type_Id) REFERENCES Profile_Type(Id);
GO


