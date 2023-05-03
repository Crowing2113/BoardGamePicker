CREATE TABLE IF NOT EXISTS BoardGameType(
    bgTitle TEXT,
    tName TEXT,
    FOREIGN KEY (tName) REFERENCES Types(Name)
);