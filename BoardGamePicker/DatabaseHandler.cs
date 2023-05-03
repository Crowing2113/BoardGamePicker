using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Numerics;
using System.Security.AccessControl;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using System.Configuration.Internal;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Resources;

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
        const string resxFile = @".\Resources.resx";

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
            CreateRelationshipTables();
            CreateLogTable();
        }

        private static void CreateLogTable()
        {
            sqlComm.CommandText = Properties.Resources.CreateGamesPlayedLog;
            sqlComm.ExecuteNonQuery();
        }

        private static void CreateRelationshipTables()
        {
            string s = Properties.Resources.CreateBG_MechRelationship;

            sqlComm.CommandText = Properties.Resources.CreateBG_MechRelationship;
            sqlComm.ExecuteNonQuery();
            sqlComm.CommandText = Properties.Resources.CreateBG_TypesRelationship;
            sqlComm.ExecuteNonQuery();
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

            sqlComm.CommandText = Properties.Resources.CreateProfilesTable;
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
        //create the games table if it doesn't exist
        public static void CreateGamesTable()
        {
            sqlComm.CommandText = Properties.Resources.CreateBoardGamesTable;
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
            //if the game exists then show an error popup and exit the function
            if (exists)
            {
                MessageBox.Show("Game already exists in collection", "", MessageBoxButtons.OK);
                return;
            }
            //create the board game
            BoardGame game = new BoardGame(title,players,playTime,_types,_mechanics);
            //add it to the database
            sqlComm.CommandText = "INSERT INTO BoardGames (GameTitle, PlayersMin, PlayersMax, TimeMin, TimeMax) VALUES('" + title + "'," + players.X + "," + players.Y + "," + playTime.X + "," + playTime.Y + ");";
            //add entries to the BoardGameMechanics table
            foreach(string mechanic in _mechanics)
            {
            sqlComm.CommandText += "INSERT INTO BoardGameMechanic VALUES(( SELECT GameTitle FROM BoardGames WHERE BoardGames.GameTitle = '" + title + "'), (SELECT Name FROM Mechanics WHERE Mechanics.Name = '"  + mechanic + "') ) EXCEPT SELECT* FROM BoardGameMechanic;";
            }
            //add entries to the BoardGameType table
            foreach(string type in _types)
            {
                sqlComm.CommandText += "INSERT INTO BoardGameType VALUES(( SELECT GameTitle FROM BoardGames WHERE BoardGames.GameTitle = '" + title + "'),(SELECT Name FROM Types WHERE Types.Name = '" + type + "')) EXCEPT SELECT * FROM BoardGameType;";
            }
            sqlComm.ExecuteNonQuery();
            CollectionScreen._collectionList.Add(game);
        }
        //Remove selected board game from colleciton
        public static void RemoveGame(BoardGame selected)
        {
            sqlComm.CommandText = "DELETE FROM BoardGames WHERE GameTitle = '" + selected.GetName() + "';";
            sqlComm.ExecuteNonQuery();
        }
        //get the list of board games
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
            foreach(BoardGame bg in result)
            {
                //select all rows that have the title as bg from the BoardGameType relationship Database
                sqlComm.CommandText = "SELECT * FROM BoardGameType WHERE bgTitle = \"" + bg.GetName() + "\";";
                reader = sqlComm.ExecuteReader();
                List<string> typesList = new List<string>();
                List<string> mechanicsList = new List<string>();
                //read through all rows and add them to the typesList
                while (reader.Read())
                {
                    string type = reader.GetString(1);
                    typesList.Add(type);
                }
                reader.Close();
                //select all rows that have the title as bg form the BoardGameMechanics relationship Database
                sqlComm.CommandText = "SELECT * FROM BoardGameMechanic WHERE bgTitle = \"" + bg.GetName() + "\";";
                reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    string mechanics = reader.GetString(1);
                    mechanicsList.Add(mechanics);
                }
                reader.Close();
                //set the created temp lists for mechanics and types
                bg.SetTypes(typesList);
                bg.SetMechanics(mechanicsList);
            }
            return result;
        }
        #endregion
        #region Mechanics
        //create and populate the mechanics table
        static void CreateMechanicsTable()
        {
            if (state == DATABASE_STATE.NEW)
            {
                sqlComm.CommandText = Properties.Resources.CreateMechanicsTable;
                sqlComm.ExecuteNonQuery();
                sqlComm.CommandText = Properties.Resources.PopulateMechanics;
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
                sqlComm.CommandText = Properties.Resources.CreateTypesTable;
                sqlComm.ExecuteNonQuery();
                sqlComm.CommandText = Properties.Resources.PopulateTypes;
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
