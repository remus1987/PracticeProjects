USE master
go

DROP Database if exists Zoo
go

CREATE Database Zoo
go

USE Zoo
go

DROP TABLE IF exists Sarcina
DROP TABLE IF exists Ingrijitor
DROP TABLE IF exists Categorie
go

CREATE TABLE Categorie(
	CategorieId INT NOT NULL IDENTITY PRIMARY KEY,
	NumeCategorie VARCHAR(50) NULL
	)

CREATE TABLE Ingrijitor(
	IngrijitorId INT NOT NULL IDENTITY PRIMARY KEY,
	NumeIngrijitor VARCHAR(50) NULL,
	Telefon INT NULL
	)

CREATE TABLE Sarcina(
	SarcinaId INT NOT NULL IDENTITY PRIMARY KEY,
	NumeSarcina VARCHAR(50) NULL,
	Indeplinita BIT NULL,
	CategorieId INT NULL,
	IngrijitorId INT NULL,
	FOREIGN KEY (CategorieId) REFERENCES Categorie (CategorieId),
	FOREIGN KEY (IngrijitorId) REFERENCES Ingrijitor (IngrijitorId)
	)

INSERT INTO Ingrijitor VALUES ('Ion',0741)
INSERT INTO Ingrijitor VALUES ('Gheorghe',0743)
INSERT INTO Ingrijitor VALUES ('Vasile',0745)

INSERT INTO Categorie VALUES ('Mamifer')
INSERT INTO Categorie VALUES ('Peste')
INSERT INTO Categorie VALUES ('Pasare')
INSERT INTO Categorie VALUES ('Reptila')

INSERT INTO Sarcina VALUES ('Hranit', NULL, 1, 1)
INSERT INTO Sarcina VALUES ('Spalat', 0, 1, 2)
INSERT INTO Sarcina VALUES ('Doctoricit', 1, 2, 2)
INSERT INTO Sarcina VALUES ('Tuns', NULL, 3, 1)

SELECT * FROM Ingrijitor