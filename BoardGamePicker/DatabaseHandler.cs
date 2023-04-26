using System.Data.SQLite;
using System.Security.AccessControl;

namespace BoardGamePicker
{
    public class DatabaseHandler
    {
        static SQLiteConnection database;
        static SQLiteCommand sqlComm;
        static string dbFileLocation = "./asset/gamePicker.db";

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
            database = new SQLiteConnection("Data Source = " + dbFileLocation);
            database.Open();
            sqlComm = new SQLiteCommand(database);
        }
        #endregion
        #region Profiles

        //Creates the Profile table if it does not already exist
        public static void CreateProfileTable()
        {
            sqlComm.CommandText = "CREATE TABLE IF NOT EXISTS Profiles (name TEXT PRIMARY KEY, playCount INT, UNIQUE (name));";
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
                sqlComm.CommandText = "INSERT INTO Profiles VALUES ('" + name + "',0);";
                sqlComm.ExecuteNonQuery();
            }
        }
        //deletes the selected profile
        public static void DeleteProfiles(Profile selected)
        {
            sqlComm.CommandText = "DELETE FROM Profiles WHERE name = '" + selected.name + "';";
            sqlComm.ExecuteNonQuery();
        }

        //pull all the info from the profiles table
        public static List<Profile> GetInfo()
        {
            List<Profile> result = new List<Profile>();
            sqlComm.CommandText = "SELECT * FROM Profiles;";
            SQLiteDataReader reader = sqlComm.ExecuteReader();
            while (reader.Read())
            {
                Profile p = new Profile();
                //store current row in list
                p.name = reader.GetString(0);
                p.playedGames = reader.GetInt32(1);
                result.Add(p);
            }
            reader.Close();
            return result;
        }

        void UpdateProfile()
        {

        }
        #endregion
        #region Board Games
        //Board Games
        void BoardGameDB()
        {

        }
        public static void CreateGamesTable()
        {

        }
        #endregion
        #region Mechanics

        static void CreateMechanicsTable()
        {

        }
        #endregion
        #region Types
        static void CreateTypesTable()
        {
            sqlComm.CommandText = File.ReadAllText("./asset/test.sql");
            sqlComm.ExecuteNonQuery();

        }
        #endregion
        #region Test

        #endregion
    }
}
