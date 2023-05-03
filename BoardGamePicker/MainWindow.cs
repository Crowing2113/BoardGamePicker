using System.Diagnostics;
using System.Numerics;

namespace BoardGamePicker
{
    public partial class GamePicker : Form
    {
        enum Sorting
        {
            TITLE,
            PLAYERS,
            TIME
        }
        enum Filter
        {
            ALL,
            PLAYED,
            UNPLAYED
        }
        Profile selPlayer = new Profile();
        BoardGame selGame = new BoardGame();
        public static List<Profile> _activePlayers = new List<Profile>();
        List<BoardGame> viewableGames = new List<BoardGame>();
        Filter filter = Filter.ALL;
        Sorting sorting = Sorting.TITLE;

        public GamePicker()
        {
            InitializeComponent();
            GameList.Items.Clear();
            LoadActivePlayers();
            LoadGamesList();
        }

        #region Menu Items
        #region File
        //Quit button in Profiles Menu
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Profiles
        //----Create Profile----
        private void menuItem_profilesCreate_Click(object sender, EventArgs e)
        {
            CreateProfile cpScrn = new CreateProfile();
            cpScrn.ShowDialog();
        }
        //----View Profiles----
        private void menuItem_profilesView_Click(object sender, EventArgs e)
        {
            addPlayerBtn_Click(sender, e);
        }
        #endregion

        #region Games

        //----Add Board Game Button----
        private void addBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Add Board Game screen here
            AddBoardGame abgScrn = new AddBoardGame();
            abgScrn.ShowDialog();
            LoadGamesList();
        }
        //----View Collection----
        private void viewCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsProvider.CollectionScrn.ShowDialog();
        }
        #endregion

        #region View

        #endregion
        #endregion

        #region Profile Side
        //----Add Button----
        //Opens the profiles window to add a player to the active list
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            FormsProvider.PlayerProfiles.ShowDialog();
            LoadActivePlayers();
        }
        //----Remove Button----
        //removes the currently selected player from active player list
        private void removePlayerBtn_Click(object sender, EventArgs e)
        {
            _activePlayers.Remove(selPlayer);
            LoadActivePlayers();
        }
        //----View Button----
        private void viewPlayerBtn_Click(object sender, EventArgs e)
        {
            if (selPlayer == null)
            {
                MessageBox.Show("Please select a player", "", MessageBoxButtons.OK);
                return;
            }
            ViewProfile viewProfile = new ViewProfile(selPlayer);
            viewProfile.ShowDialog();
        }
        //----Active Player List----
        private void LoadActivePlayers()
        {
            activePlayerList.Items.Clear();
            foreach (Profile p in _activePlayers)
                activePlayerList.Items.Add(p.name);

            if (activePlayerList.Items.Count > 0)
            {

                activePlayerList.SelectedIndex = 0;
                removePlayerBtn.Enabled = true;
                viewPlayerBtn.Enabled = true;
            }
            else
            {
                selPlayer = null;
                removePlayerBtn.Enabled = false;
                viewPlayerBtn.Enabled = false;
            }

            playerCount.Text = _activePlayers.Count.ToString();
        }
        //gets selected item from list and sets selPlayer to that profile
        private void activePlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Profile p in _activePlayers)
            {
                if (p.name == activePlayerList.SelectedItem)
                {
                    selPlayer = p;
                    break;
                }
            }
        }
        #endregion


        #region Board Game Side
        //load the game list
        public void LoadGamesList()
        {
            GameList.Items.Clear();
            FormsProvider.CollectionScrn.LoadCollection();
            FilterByPlayers();

            //populate the game list
            foreach (BoardGame bg in viewableGames)
            {
                if (!GameList.Items.Contains(bg.GetName()))
                    GameList.Items.Add(bg.GetName());
            }
            GameList.Sorted = true;

            if (GameList.Items.Count > 0)
            {
                GameList.SelectedIndex = 0;
                playGameBtn.Enabled = true;
            }
            else
            {
                selGame = null;
                playGameBtn.Enabled = false;
            }

        }
        //Filter the game list by number of active players
        void FilterByPlayers()
        {
            viewableGames.Clear();
            int players = int.Parse(playerCount.Text);
            if (players == 0)
            {
                foreach (BoardGame bg in CollectionScreen._collectionList)
                {
                    if (!viewableGames.Contains(bg))
                        viewableGames.Add(bg);


                    //GameList.Items.Add(bg.GetName());
                }
            }
            else
            {
                foreach (BoardGame bg in CollectionScreen._collectionList)
                {
                    Vector2 pSize = bg.GetPlayerNum();
                    if (pSize.X <= players && players <= pSize.Y)
                    {
                        viewableGames.Add(bg);
                        //GameList.Items.Add(bg.GetName());
                    }
                }
            }
        }

        void FilterListByPlayed()
        {
            switch (filter)
            {
                case Filter.ALL:
                    foreach (BoardGame bg in CollectionScreen._collectionList)
                        GameList.Items.Add(bg.GetName());
                    break;
                case Filter.UNPLAYED:
                    break;
                case Filter.PLAYED:
                    break;
            }
        }
        //when selected game changes
        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //player amount
            string pAmount;
            //playtime
            string tAmount;
            //go through the collection list and set selGame to the currently selected item in the GameList listBox
            foreach (BoardGame bg in CollectionScreen._collectionList)
            {
                if (bg.GetName() == GameList.SelectedItem)
                {
                    selGame = bg;
                    break;
                }
            }
            //check if a game selected
            if (selGame == null)
            {
                //if not set pAmount and tAmount to empty
                pAmount = string.Empty;
                tAmount = string.Empty;
            }
            else
            {
                //otherwise get the selected games player amount and playtime and the created vectors
                Vector2 playNum = selGame.GetPlayerNum();
                Vector2 playTime = selGame.GetPlayTime();
                //set the games title
                selGameTitle.Text = selGame.GetName();

                //check whether the player min and max are the same or not and display accordingly
                if (playNum.X == playNum.Y)
                    pAmount = playNum.X.ToString();
                else
                    pAmount = playNum.X + " to " + playNum.Y;
                //check whether the playtime min and max are the same or not and display accordingly
                if (playTime.X == playTime.Y)
                    tAmount = playTime.X + " Minutes";
                else
                    tAmount = playTime.X + " to " + playTime.Y + " Minutes";
            }
            //set the game info panel text
            selGamePlayers.Text = pAmount;
            selGameTime.Text = tAmount;
        }
        #endregion

        private void playGameBtn_Click(object sender, EventArgs e)
        {

            //WebTest.FindGame(DELETE_LATER_TXT.Text);
        }

        private void playerCount_TextChanged(object sender, EventArgs e)
        {
            LoadGamesList();
        }
    }
}