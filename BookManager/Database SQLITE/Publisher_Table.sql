-- Script Date: 05/10/2018 6:38 PM  - ErikEJ.SqlCeScripting version 3.5.2.75
CREATE TABLE [Publisher ] (
  [Publisher_ID] INTEGER NOT NULL
, [Publisher_Name] TEXT NOT NULL
, [Publisher_Location] TEXT NULL
, [Publisher_Address] TEXT NOT NULL
, CONSTRAINT [PK_Publisher ] PRIMARY KEY ([Publisher_ID])
);
