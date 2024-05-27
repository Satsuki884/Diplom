use diplom;

drop table if exists Exercise;

Create table Exercise(
	ExerciseId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    imageId INT,
    text VARCHAR(255) not null,
    point int not null,
    answer VARCHAR(255) not null,
    FOREIGN KEY (imageId) REFERENCES Image(imageId),
    LevelId int not null,
    foreign key (LevelId) references Level(LevelId)
);