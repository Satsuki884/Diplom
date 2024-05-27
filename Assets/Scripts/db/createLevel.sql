use diplom;

drop table if exists Level;

Create table Level(
	LevelId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    imageId INT,
    name VARCHAR(255) not null,
    max_rate int not null,
    grade int not null default 0,
    isBoss bool not null default 0,
    isCompleted bool not null default 0,
    isAvailable bool not null default 0,
    FOREIGN KEY (imageId) REFERENCES Image(imageId),
    stoneId int not null default 0,
    foreign key (stoneId) references Stone(StoneId)
);