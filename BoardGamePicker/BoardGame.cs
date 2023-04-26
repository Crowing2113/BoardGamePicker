using System.Numerics;

namespace BoardGamePicker
{
    public class BoardGame
    {
        string name;
        Vector2 playerNum;
        Vector2 playTime;
        List<object> mechanics;
        List<object> Type;


        public string GetName()
        {
            return name;
        }

        public Vector2 GetPlayerNum()
        {
            return playerNum;
        }
        public Vector2 GetPlayTime()
        {
            return playTime;
        }

    }
}
