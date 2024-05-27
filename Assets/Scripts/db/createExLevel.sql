use diplom;

drop table if exists ExLevel;


CREATE TABLE ExLevel (
    ExLevelId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    LevelId INT UNIQUE NOT NULL,
    ExerciseId INT UNIQUE NOT NULL,
    FOREIGN KEY (LevelId) REFERENCES Level(LevelId),
    FOREIGN KEY (ExerciseId) REFERENCES Exercise(ExerciseId)
);