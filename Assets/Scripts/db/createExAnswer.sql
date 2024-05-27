use diplom;

drop table if exists ExAnswer;


CREATE TABLE ExAnswer (
    ExAnswerId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    ExerciseId INT UNIQUE NOT NULL,
    AnswerId INT UNIQUE NOT NULL,
    FOREIGN KEY (ExerciseId) REFERENCES Exercise(ExerciseId),
    FOREIGN KEY (AnswerId) REFERENCES Answer(AnswerId)
);