-- Script Date: 05/10/2018 6:45 PM  - ErikEJ.SqlCeScripting version 3.5.2.75

PRAGMA foreign_keys=off;

BEGIN TRANSACTION;

CREATE TABLE [BookStore] (
  [BookStore_ID] INTEGER NOT NULL
, [Book_ID] INTEGER NOT NULL
, [Store_ID] INTEGER NOT NULL
, CONSTRAINT [PK_BookStore] PRIMARY KEY ([BookStore_ID])
,

 CONSTRAINT fk_Book_ID
    FOREIGN KEY (Book_ID)
    REFERENCES Books(Book_ID)
    
    
   CONSTRAINT fk_Store_ID
    FOREIGN KEY (Store_ID)
    REFERENCES Author(Store_ID)

);


COMMIT;

PRAGMA foreign_keys=on;