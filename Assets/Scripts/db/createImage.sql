use diplom;

drop table if exists Image;

Create table Image(
	imageId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    image varchar(255)
);