-- Script Date: 05/10/2018 7:41 PM  - ErikEJ.SqlCeScripting version 3.5.2.75
PRAGMA foreign_keys=off;

BEGIN TRANSACTION;

CREATE TABLE [Books] (
  [Book_ID] INTEGER NOT NULL
, [BookDetails_ID] INTEGER NOT NULL
, [Book_Title] TEXT NOT NULL
, [Book_Version] TEXT NOT NULL
, [Book_CopyRightYear] TEXT NOT NULL
, [Book_ISBN] INTEGER NOT NULL
, CONSTRAINT [PK_Books] PRIMARY KEY ([Book_ID])
,

CONSTRAINT fk_BookDetails_ID
    FOREIGN KEY (BookDetails_ID)
    REFERENCES BookDetails(BookDetails_ID)
);

COMMIT;

PRAGMA foreign_keys=on;
