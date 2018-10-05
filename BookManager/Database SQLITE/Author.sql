-- Script Date: 05/10/2018 6:40 PM  - ErikEJ.SqlCeScripting version 3.5.2.75
CREATE TABLE [Author] (
  [Author_ID] INTEGER NOT NULL
, [Author_Name] TEXT NOT NULL
, [Author_Contact] INTEGER NOT NULL
, [Author_Address] TEXT NOT NULL
, CONSTRAINT [PK_Author] PRIMARY KEY ([Author_ID])
);
