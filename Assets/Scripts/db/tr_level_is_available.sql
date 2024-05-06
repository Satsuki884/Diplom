-- DROP TRIGGER tr_level_is_available
DELIMITER 
CREATE TRIGGER tr_level_is_available
BEFORE UPDATE
ON level
FOR EACH ROW 
BEGIN
   IF NEW.isCompleted = 1 THEN
        -- Если уровень является боссом
        IF NEW.isBoss = 1 THEN
        
       
            -- Проверяем соответствие условию по минимальной оценке для босса
            IF (SELECT sum(grade) FROM level) >= (SELECT mingrade FROM bosslevel WHERE idlevel = NEW.idlevel) THEN
                -- Обновляем статус isAvailable для следующих уровней
                UPDATE nextlevel
                SET isAvailable = 1
                WHERE idlevel = NEW.idlevel;
            END IF;
        ELSE
            -- Обновляем статус isAvailable для следующих уровней
            UPDATE nextlevel
            SET isAvailable = 1
            WHERE idlevel = NEW.idlevel;
        END IF;
    END IF;
END;

UPDATE level SET grade = 2 WHERE level.idlevel = 3