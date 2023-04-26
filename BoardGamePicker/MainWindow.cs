using System.Diagnostics;

namespace BoardGamePicker
{
    public partial class GamePicker : Form
    {
        Profile selPlayer = null;
        public static List<Profile> _activePlayers = new List<Profile>();

        public GamePicker()
        {
            InitializeComponent();
            LoadActivePlayers();
        }
        //Quit button in Profiles Menu
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void addBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Add Board Game screen here
            AddBoardGame abgScrn = new AddBoardGame();
            abgScrn.ShowDialog();

        }

        private void viewCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsProvider.CollectionScrn.Show();
            FormsProvider.GamePicker.Hide();
        }

        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            FormsProvider.PlayerProfiles.ShowDialog();
            if(selPlayer = )
            LoadActivePlayers();
        }

        private void LoadActivePlayers()
        {
            activePlayerList.Items.Clear();
            foreach (Profile p in _activePlayers)
                activePlayerList.Items.Add(p.name);

            if (activePlayerList.Items.Count > 0)
                activePlayerList.SelectedIndex = 0;
            else
                selPlayer = null;

            playerCount.Text = _activePlayers.Count.ToString();
        }

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

        private void menuItem_profilesCreate_Click(object sender, EventArgs e)
        {
            CreateProfile cpScrn = new CreateProfile();
            cpScrn.ShowDialog();
        }

        //gets selected item from list and sets selPlayer to that profile
        private void activePlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Profile p in _activePlayers)
            {
                if (p.name == activePlayerList.SelectedItem)
                {
                    selPlayer = p;
                    Debug.WriteLine("selected played = " + selPlayer.name);
                    break;
                }
            }
        }
        //removes player from active player list
        private void removePlayerBtn_Click(object sender, EventArgs e)
        {
            _activePlayers.Remove(selPlayer);
            LoadActivePlayers();
        }
    }
}