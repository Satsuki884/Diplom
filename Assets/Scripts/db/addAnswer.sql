use diplom;

drop table if exists Answer;


CREATE TABLE Answer (
    AnswerId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    value varchar(256) not null
);