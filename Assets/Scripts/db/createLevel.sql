use diplom;

 drop table if exists ExImage;
 drop table if exists ExAnswer;
drop table if exists Exercise;
drop table if exists Level;

Create table Level(
	LevelId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    name VARCHAR(255) not null,
    max_rate int not null,
    grade int not null default 0,
    isBoss bool not null default 0,
    isCompleted bool not null default 0,
    isAvailable bool not null default 0,
    stoneId int not null default 0,
    foreign key (stoneId) references Stone(StoneId)
);