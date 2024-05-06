CREATE TABLE nextlevel (
    id INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    idnextlevel INT UNIQUE NOT NULL,
    idlevel INT UNIQUE NOT NULL,
    FOREIGN KEY (idnextlevel) REFERENCES level(idlevel),
    FOREIGN KEY (idlevel) REFERENCES level(idlevel)
);

DELIMITER 
CREATE TRIGGER tr_check_idlevel_idnextlevel
BEFORE INSERT ON nextlevel
FOR EACH ROW
BEGIN
    IF NEW.idlevel = NEW.idnextlevel THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'idlevel and idnextlevel cannot be the same';
    END IF;
END;