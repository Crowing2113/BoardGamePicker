CREATE TABLE IF NOT EXISTS gamesLog(
    GameID INTEGER PRIMARY KEY AUTOINCREMENT,
    GameTitle TEXT,
    Players TEXT,
    FOREIGN KEY(GameTitle) REFERENCES BoardGames(GameTitle)
    FOREIGN KEY(Players) REFERENCES Profiles(Name)
);