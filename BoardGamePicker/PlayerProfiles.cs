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

        public void LoadProfiles()
        {
            pp_playerListBox.Items.Clear();
            _allProfiles = DatabaseHandler.GetInfo();
            foreach (Profile p in _allProfiles)
                pp_playerListBox.Items.Add(p.name);

            if (_allProfiles.Count > 0)
                pp_playerListBox.SelectedIndex = 0;

        }

        private void ppCancelBtn_Click(object sender, EventArgs e)
        {
            FormsProvider.PlayerProfiles.Hide();
            FormsProvider.OriginWindow.Show();
        }

        private void ppAddBtn_Click(object sender, EventArgs e)
        {
            //check if a player is selected, if none then let the user know and exit out of function
            if(selPlayer ==  null)
            {
                MessageBox.Show("No player selected", "", MessageBoxButtons.OK);
                return;
            }

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
            GamePicker._activePlayers.Add(selPlayer);
            //add player to active list in main screen
            FormsProvider.GamePicker.Show();
            FormsProvider.PlayerProfiles.Hide();
        }

        private void ppCreateBtn_Click(object sender, EventArgs e)
        {

            CreateProfile cpScrn = new CreateProfile();
            cpScrn.ShowDialog();
            LoadProfiles();
        }

        private void ppViewBtn_Click(object sender, EventArgs e)
        {
            //View selected players profile
            ViewProfile viewProfile = new ViewProfile(selPlayer);
            viewProfile.ShowDialog();
        }

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

        private void ppDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to delete the user " + selPlayer.name + "?", "CAUTION", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DatabaseHandler.DeleteProfiles(selPlayer);
                LoadProfiles();
            }
        }
    }
}
