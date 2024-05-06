-- DROP TRIGGER tr_level_is_completed 
DELIMITER 
CREATE TRIGGER tr_level_is_completed
BEFORE UPDATE
ON level
FOR EACH ROW 
BEGIN
   IF new.grade > old.grade THEN
        SET new.isCompleted = 1;
		UPDATE stonelevel
			SET idstone = (SELECT idstone FROM stone WHERE value = FLOOR(new.grade / CEIL(new.maxRate/4)))
			WHERE idlevel = NEW.idlevel;
		UPDATE `user`
			SET `grade` = `grade` - OLD.grade + NEW.grade
			WHERE iduser = 1;
    END IF;
END;

UPDATE level SET grade = 7 WHERE level.idlevel = 2