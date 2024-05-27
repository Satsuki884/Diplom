use diplom;

drop table if exists ExImage;


CREATE TABLE ExImage (
    ExImageId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    ExerciseId INT UNIQUE NOT NULL,
    imageId INT UNIQUE NOT NULL,
    FOREIGN KEY (ExerciseId) REFERENCES Exercise(ExerciseId),
    FOREIGN KEY (imageId) REFERENCES image(imageId)
);