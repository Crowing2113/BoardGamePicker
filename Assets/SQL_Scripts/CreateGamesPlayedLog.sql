CREATE TABLE IF NOT EXISTS gamesLog(
    GameID TEXT PRIMARY KEY,
    GameTitle TEXT,
    Players TEXT,
    FOREIGN KEY(GameTitle) REFERENCES BoardGames(GameTitle)
    FOREIGN KEY(Players) REFERENCES Profiles(Name)
);