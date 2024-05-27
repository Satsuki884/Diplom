use diplom;

drop table if exists Stone;

Create table Stone(
	StoneId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    imageId INT,
    value Enum('0', '1', '2', '3') not null,
    FOREIGN KEY (imageId) REFERENCES Image(imageId)
);