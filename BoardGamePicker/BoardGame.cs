using System;
using System.Numerics;
using System.Xml.Linq;

namespace BoardGamePicker
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
        public BoardGame(string title, int playersMin, int playersMax, int timeMin, int timeMax, List<string> _types, List<string> _mechanics)
        {
            gameTitle = title;
            playerNum = new Vector2(playersMin,playersMax);
            playTime = new Vector2(timeMin,timeMax);
            types = _types;
            mechanics = _mechanics;
        }
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
