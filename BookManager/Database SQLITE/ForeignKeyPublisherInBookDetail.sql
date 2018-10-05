PRAGMA foreign_keys=off;

BEGIN TRANSACTION;

ALTER TABLE BookDetails RENAME TO _BookDetails_old;

CREATE TABLE BookDetails
( BookDetails_ID INTEGER PRIMARY KEY AUTOINCREMENT,
  Publisher_ID INTEGER,
  Author_ID INTEGER,
  
  
  CONSTRAINT fk_Publisher_ID
    FOREIGN KEY (Publisher_ID)
    REFERENCES Publisher(Publisher_ID)
    
    
   CONSTRAINT fk_Author_ID
    FOREIGN KEY (Author_ID)
    REFERENCES Author(Author_ID)
);

INSERT INTO BookDetails SELECT * FROM _BookDetails_old;

COMMIT;

PRAGMA foreign_keys=on;