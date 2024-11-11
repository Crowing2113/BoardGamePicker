CREATE TABLE IF NOT EXISTS BoardGameMechanic(
    bgTitle TEXT,
    mName TEXT,
    FOREIGN KEY (mName) REFERENCES Mechanics(Name)
);