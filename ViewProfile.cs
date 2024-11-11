namespace bgpicker2
{
    public partial class ViewProfile : Form
    {
        Profile viewedPlayer;
        public ViewProfile()
        {
            InitializeComponent();
        }
        //alternate constructor - maybe gonna use this to display profiles better. Create a window instance from that profile
        public ViewProfile(Profile p)
        {
            InitializeComponent();
            viewedPlayer = p;
            vpNameDispLabel.Text = p.name;
            vpGamesPlayedDisp.Text = p.playedGames.ToString();
        }

        void PopulateGames()
        {
            vpLikedGamesList.Items.Clear();
            foreach (BoardGame bg in viewedPlayer.likedGames)
            {
                vpLikedGamesList.Items.Add(bg.GetName());
            }
        }
        void PopulateMechanics()
        {
            vpLikedMechanicsList.Items.Clear();
        }

        void PopulateType()
        {
            vpLikedTypeList.Items.Clear();
        }

        private void vpCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
