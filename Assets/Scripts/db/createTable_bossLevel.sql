CREATE TABLE bosslevel (
	idbosslevel INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    mingrade INT NOT NULL,
    idlevel INT UNIQUE NOT NULL
);