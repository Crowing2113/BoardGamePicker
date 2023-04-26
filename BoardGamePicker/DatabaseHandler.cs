using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Numerics;
using System.Security.AccessControl;

namespace BoardGamePicker
{
    enum DATABASE_STATE
    {
        NEW,
        LOADED
    }

    public class DatabaseHandler
    {
        static DATABASE_STATE state = 0;

        static SQLiteConnection database;
        static SQLiteCommand sqlComm;
        static string dbFileLocation = "./assets/Database/gamePicker.db";

        static List<string> _mechanicsList = new List<string>();
        static List<string> _typesList = new List<string>();
        

        #region Database
        public static void InitDB()
        {

            LoadDB();
            InitTables();
        }

        private static void InitTables()
        {
            CreateProfileTable();
            CreateGamesTable();
            CreateMechanicsTable();
            CreateTypesTable();

        }

        //Create Database
        public static void LoadDB()
        {
            bool e = File.Exists(dbFileLocation);
            if (e)
                state = DATABASE_STATE.LOADED;
            else
                state = DATABASE_STATE.NEW;

            database = new SQLiteConnection("Data Source = " + dbFileLocation);
            database.Open();
            sqlComm = new SQLiteCommand(database);
        }
        #endregion
        #region Profiles

        //Creates the Profile table if it does not already exist
        public static void CreateProfileTable()
        {
            sqlComm.CommandText = File.ReadAllText("./assets/SQL_Scripts/CreateProfilesTable.sql");
            sqlComm.ExecuteNonQuery();
        }

        //creates a new profile and adds it to the table
        public static void CreateProfile(string name)
        {

            //check if name already exists
            bool exists = false;

            foreach (Profile p in PlayerProfiles._allProfiles)
            {
                if (p.name == name)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                MessageBox.Show("Profile already exists", "", MessageBoxButtons.OK);
            }
            else
            {
                sqlComm.CommandText = "INSERT INTO Profiles(Name)  VALUES ('" + name + "');";
                sqlComm.ExecuteNonQuery();
            }
        }

        //deletes the selected profile
        public static void DeleteProfiles(Profile selected)
        {
            sqlComm.CommandText = "DELETE FROM Profiles WHERE Name = '" + selected.name + "';";
            sqlComm.ExecuteNonQuery();
        }

        //pull all the info from the profiles table
        public static List<Profile> GetProfileInfo()
        {
            List<Profile> result = new List<Profile>();
            sqlComm.CommandText = "SELECT * FROM Profiles;";
            SQLiteDataReader reader = sqlComm.ExecuteReader();
            while (reader.Read())
            {
                Profile p = new Profile();
                //store current row in list
                p.name = reader.GetString(1);
                p.playedGames = reader.GetInt32(2);
                result.Add(p);
            }
            reader.Close();
            return result;
        }
        #endregion
        #region Board Games
        //Board Games
        public static void CreateGamesTable()
        {
            sqlComm.CommandText = File.ReadAllText("./assets/SQL_Scripts/CreateBoardGamesTable.sql");
            sqlComm.ExecuteNonQuery();
        }
        //Add board game to the database
        public static void AddBoardGame(string title,Vector2 players, Vector2 playTime,List<string> _types,List<string> _mechanics)
        {
            //check if game already exists
            bool exists = false;

            foreach(BoardGame bg in CollectionScreen._collectionList)
            {
                if(bg.GetName() == title)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                MessageBox.Show("Game already exists in collection", "", MessageBoxButtons.OK);
                return;
            }

            BoardGame game = new BoardGame(title,players,playTime,_types,_mechanics);
            sqlComm.CommandText = "INSERT INTO BoardGames (GameTitle, PlayersMin, PlayersMax, TimeMin, TimeMax) VALUES('" + title + "'," + players.X + "," + players.Y + "," + playTime.X + "," + playTime.Y + ");";
            sqlComm.ExecuteNonQuery();
            CollectionScreen._collectionList.Add(game);
        }

        public static void RemoveGame(BoardGame selected)
        {
            sqlComm.CommandText = "DELETE FROM BoardGames WHERE GameTitle = '" + selected.GetName() + "';";
            sqlComm.ExecuteNonQuery();
        }
        public static List<BoardGame> GetBoardGames()
        {
            List<BoardGame> result = new List<BoardGame>();
            sqlComm.CommandText = "SELECT * FROM BoardGames;";
            SQLiteDataReader reader = sqlComm.ExecuteReader();
            while (reader.Read())
            {
                string title = reader.GetString(1);
                Vector2 playerSize = new Vector2(reader.GetInt32(2),reader.GetInt32(3));
                Vector2 playTime = new Vector2(reader.GetInt32(4),reader.GetInt32(5));

                BoardGame bg = new BoardGame();
                bg.SetName(title);
                bg.SetPlayerSize(playerSize);
                bg.SetPlayTime(playTime);
                result.Add(bg);
            }
            reader.Close();
            //for starting purposes mechanics and types will be added here seperate until i figure out how to do it gooder
            return result;
        }
        #endregion
        #region Mechanics
        //create and populate the mechanics table
        static void CreateMechanicsTable()
        {
            if (state == DATABASE_STATE.NEW)
            {
                sqlComm.CommandText = File.ReadAllText("./assets/SQL_Scripts/CreateMechanicsTable.sql");
                sqlComm.ExecuteNonQuery();
                sqlComm.CommandText = File.ReadAllText("./assets/SQL_Scripts/PopulateMechanics.sql");
                sqlComm.ExecuteNonQuery();
            }

            sqlComm.CommandText = "SELECT * FROM Mechanics;";
            SQLiteDataReader reader = sqlComm.ExecuteReader();
            while (reader.Read())
                _mechanicsList.Add(reader.GetString(1));
            reader.Close();
        }
        //return the _mechanicsList list
        public static List<string> GetMechanics()
        {
            return _mechanicsList;
        }
        #endregion
        #region Types
        //---Create and populate the types table
        static void CreateTypesTable()
        {
            if (state == DATABASE_STATE.NEW)
            {
                sqlComm.CommandText = File.ReadAllText("./assets/SQL_Scripts/CreateTypesTable.sql");
                sqlComm.ExecuteNonQuery();
                sqlComm.CommandText = File.ReadAllText("./assets/SQL_Scripts/PopulateTypes.sql");
                sqlComm.ExecuteNonQuery();
            }

            sqlComm.CommandText = "SELECT * FROM Types";
            SQLiteDataReader reader = sqlComm.ExecuteReader();
            while (reader.Read())
                _typesList.Add(reader.GetString(1));
            reader.Close();
        }
        //return the _typesList list
        public static List<string> GetTypesList()
        {
            return _typesList;
        }
        #endregion
    }
}
