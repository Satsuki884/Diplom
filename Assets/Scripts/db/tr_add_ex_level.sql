-- DROP TRIGGER `tr_add_ex_level`;
DELIMITER 
CREATE TRIGGER tr_add_ex_level
AFTER INSERT
ON ExerciseLevel
FOR EACH ROW 
BEGIN
   UPDATE `level` 
   SET maxRate = maxRate + (SELECT point FROM exercise WHERE idexercise = NEW.idexercise) 
   WHERE idlevel = NEW.idlevel;
END;

