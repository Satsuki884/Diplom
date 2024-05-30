use diplom;


-- drop table if exists ExImage;
-- drop table if exists ExAnswer;
drop table if exists Exercise;

Create table Exercise(
	ExerciseId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    text VARCHAR(255) not null,
    point int not null,
    LevelId int not null,
    foreign key (LevelId) references Level(LevelId)
);