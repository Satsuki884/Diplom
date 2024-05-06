
DELIMITER 
CREATE TRIGGER tr_remove_exlevel
AFTER DELETE
ON ExerciseLevel
FOR EACH ROW 
BEGIN
   UPDATE `level` 
   SET maxRate = maxRate - (SELECT point FROM exercise WHERE idexercise = OLD.idexercise) 
   WHERE idlevel = OLD.idlevel;
END;
