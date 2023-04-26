using System.Diagnostics;

namespace BoardGamePicker
{
    public partial class PlayerProfiles : Form
    {
        Profile selPlayer = new Profile();
        public static List<Profile> _allProfiles = new List<Profile>();
        public PlayerProfiles()
        {
            InitializeComponent();
            LoadProfiles();
        }
        //----Load Profiles----
        /// <summary>
        /// Load profiles from the database.
        /// </summary>
        public void LoadProfiles()
        {
            selPlayer = null;
            pp_playerListBox.Items.Clear();
            _allProfiles = DatabaseHandler.GetProfileInfo();
            foreach (Profile p in _allProfiles)
                pp_playerListBox.Items.Add(p.name);

            if (_allProfiles.Count > 0)
            {
                pp_playerListBox.SelectedIndex = 0;
                ppAddBtn.Enabled = true;
                ppViewBtn.Enabled = true;
                ppDeleteBtn.Enabled = true;
            }
            else
            {
                ppAddBtn.Enabled = false;
                ppViewBtn.Enabled = false;
                ppDeleteBtn.Enabled = false;
            }
        }

        //----Add Button----
        private void ppAddBtn_Click(object sender, EventArgs e)
        {
            //check if a player is selected, if none then let the user know and exit out of function
            if (selPlayer == null)
            {
                MessageBox.Show("No player selected", "", MessageBoxButtons.OK);
                return;
            }

            //check if the player is already in the active player list
            bool exists = false;
            foreach (Profile p in GamePicker._activePlayers)
            {
                if (p.name == selPlayer.name)
                {
                    exists = true;
                    break;
                }
            }
            if (exists)
            {
                MessageBox.Show("Player is already participating", "", MessageBoxButtons.OK);
                return;
            }

            //add player to active list in main screen
            GamePicker._activePlayers.Add(selPlayer);
            FormsProvider.GamePicker.Show();
            FormsProvider.PlayerProfiles.Hide();
        }

        //----Create Button----
        private void ppCreateBtn_Click(object sender, EventArgs e)
        {

            CreateProfile cpScrn = new CreateProfile();
            cpScrn.ShowDialog();
            LoadProfiles();
        }

        //----View Button----
        private void ppViewBtn_Click(object sender, EventArgs e)
        {
            if (selPlayer == null)
            {
                MessageBox.Show("No profile selected to view", "", MessageBoxButtons.OK);
                return;
            }
            //View selected players profile
            ViewProfile viewProfile = new ViewProfile(selPlayer);
            viewProfile.ShowDialog();
        }

        //----Delete Button----
        private void ppDeleteBtn_Click(object sender, EventArgs e)
        {
            //check if a player is selected
            if (selPlayer == null)
            {
                MessageBox.Show("No profile selected to delete", "", MessageBoxButtons.OK);
                return;
            }
            //Confirm whether user wants to delete profile
            DialogResult dr = MessageBox.Show("Are you sure you wish to delete the user " + selPlayer.name + "?", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DatabaseHandler.DeleteProfiles(selPlayer);
                LoadProfiles();
            }
        }

        //----Cancel Button----
        private void ppCancelBtn_Click(object sender, EventArgs e)
        {
            FormsProvider.PlayerProfiles.Hide();
            FormsProvider.OriginWindow.Show();
        }

        //----ListBox selection change----
        private void pp_playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Profile p in _allProfiles)
            {
                if (p.name == pp_playerListBox.SelectedItem)
                {
                    selPlayer = p;
                    Debug.WriteLine("selected played = " + selPlayer.name);
                    break;
                }
            }
        }
    }
}
