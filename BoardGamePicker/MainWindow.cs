using System.Diagnostics;
using System.Numerics;

namespace BoardGamePicker
{
    public partial class GamePicker : Form
    {
        Profile selPlayer = null;
        BoardGame selGame = null;
        public static List<Profile> _activePlayers = new List<Profile>();

        public GamePicker()
        {
            InitializeComponent();
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
            FormsProvider.CollectionScrn.LoadCollection();
            GameList.Items.Clear();
            foreach (BoardGame bg in CollectionScreen._collectionList)
                GameList.Items.Add(bg.GetName());

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

        //when selected game changes
        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pAmount;
            string tAmount;
            foreach (BoardGame bg in CollectionScreen._collectionList)
            {
                if (bg.GetName() == GameList.SelectedItem)
                {
                    selGame = bg;
                    break;
                }
            }
            if (selGame == null)
            {
                pAmount = string.Empty;
                tAmount = string.Empty;
            }
            else
            {
                Vector2 playNum = selGame.GetPlayerNum();
                Vector2 playTime = selGame.GetPlayTime();
                selGameTitle.Text = selGame.GetName();

                if (playNum.X == playNum.Y)
                    pAmount = playNum.X.ToString();
                else
                    pAmount = playNum.X + " to " + playNum.Y;

                if (playTime.X == playTime.Y)
                    tAmount = playTime.X + " Minutes";
                else
                    tAmount = playTime.X + " to " + playTime.Y+" Minutes";
            }
            selGamePlayers.Text = pAmount;
            selGameTime.Text = tAmount;
        }
        #endregion

    }
}