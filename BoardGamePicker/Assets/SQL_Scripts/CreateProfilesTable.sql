CREATE TABLE IF NOT EXISTS Profiles
(P_ID INTEGER PRIMARY KEY AUTOINCREMENT,
 Name TEXT,
 playCount INT DEFAULT 0,
 UNIQUE (P_ID, Name));