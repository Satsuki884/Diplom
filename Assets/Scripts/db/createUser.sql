use diplom;

drop table if exists User;

Create table User(
	UserId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    imageId INT,
    name VARCHAR(255) not null,
    sex enum('male', 'female') not null,
    isSword bool not null default 0,
    isBoots bool not null default 0,
    isFlashlight bool not null default 0,
    isArmor bool not null default 0,
    isAmulet bool not null default 0,
    isAura bool not null default 0,
    FOREIGN KEY (imageId) REFERENCES Image(imageId)
    
);