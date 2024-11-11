using System;
using System.Numerics;
using System.Xml.Linq;

namespace bgpicker2
{
    public class BoardGame
    {
        string gameTitle;
        Vector2 playerNum;
        Vector2 playTime;
        List<string> mechanics;
        List<string> types;

        public BoardGame()
        {

        }
        /// <summary>
        /// Board Game object Alternate constructor not using vectors
        /// </summary>
        /// <param name="title">Title of the board game</param>
        /// <param name="playersMin">Minimum player amount</param>
        /// <param name="playersMax">Maximum player amount, if the player amount is a constant make this the same as playersMin (eg.: PLayers - 4, playersMin: 4,playersMax: 4</param>
        /// <param name="timeMin">Minimum playtime</param>
        /// <param name="timeMax">maximum playtime, if time is an average estimate then make htis the same as timeMin (eg.: time = 30, timeMin: 30, timeMax: 30</param>
        /// <param name="_types">List of Board Game's types, will be grabbed when adding a game to collection</param>
        /// <param name="_mechanics">List of Board Game's Mechanics, will be grabbed whne adding a game to the collection</param>
        public BoardGame(string title, int playersMin, int playersMax, int timeMin, int timeMax, List<string> _types, List<string> _mechanics)
        {
            gameTitle = title;
            playerNum = new Vector2(playersMin,playersMax);
            playTime = new Vector2(timeMin,timeMax);
            types = _types;
            mechanics = _mechanics;
        }
        /// <summary>
        /// Board Game object alternate constructor using Vectors
        /// </summary>
        /// <param name="title">Title of the board game</param>
        /// <param name="players">player amount, if the player amount is a constant the ninput 2 equal numbers (eg.: Players = 4, new Vector2(4, 4)</param>
        /// <param name="_playTime">playtime, if time is an average estimate then input 2 equal numbers (eg.: time = 30,new Vector2(30, 30)</param>
        /// <param name="_types">List of Board Game's types, will be grabbed when adding a game to collection</param>
        /// <param name="_mechanics">List of Board Game's Mechanics, will be grabbed whne adding a game to the collection</param>
        public BoardGame(string title, Vector2 players, Vector2 _playTime,  List<string> _types, List<string> _mechanics)
        {
            gameTitle = title;
            playerNum = players;
            playTime = _playTime;
            types = _types;
            mechanics = _mechanics;
        }

        public string GetName()
        {
            return gameTitle;
        }
        public void SetName(string name)
        {
            gameTitle = name;
        }
        public Vector2 GetPlayerNum()
        {
            return playerNum;
        }
        public void SetPlayerSize(Vector2 playerSize)
        {
            playerNum = playerSize;
        }
        public void SetPlayerSize(int min, int max)
        {
            SetPlayerSize(new Vector2(min, max));
        }
        public Vector2 GetPlayTime()
        {
            return playTime;
        }

        public void SetPlayTime(Vector2 time)
        {
            playTime = time;
        }

        public void SetPlayTime(int min,int max)
        {
            SetPlayerSize(new Vector2(min, max));
        }

        public void SetMechanics(List<string> _mechanics)
        {
            mechanics = _mechanics;
        }

        public List<string> GetMechanics()
        {
            return mechanics;
        }
        public void SetTypes(List<string> _types)
        {
            types = _types;
        }

        public List<string> GetTypes()
        {
            return types;
        }
    }
}
