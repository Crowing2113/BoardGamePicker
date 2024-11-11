CREATE TABLE IF NOT EXISTS LikedGames(
    ProfileName TEXT,
    GameTitle TEXT,
    FOREIGN KEY ProfileName REFERENCES Profiles(Name),
    FOREIGN KEY GameTitle REFERENCES BoardGames(GameTitle)
);