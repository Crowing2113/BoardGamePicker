using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace bgpicker2
{
    public partial class CollectionScreen : Form
    {
        public static List<BoardGame> _collectionList = new List<BoardGame>();
        BoardGame selGame = null;
        public CollectionScreen()
        {
            InitializeComponent();
            ClearGameInfo();
            LoadCollection();
        }

        public void LoadCollection()
        {

            selGame = null;
            csBoardGameList.Items.Clear();
            _collectionList = DatabaseHandler.GetBoardGames();
            foreach (BoardGame boardGame in _collectionList)
                csBoardGameList.Items.Add(boardGame.GetName());

            if (_collectionList.Count > 0)
            {
                csBoardGameList.SelectedIndex = 0;
                csRemoveBtn.Enabled = true;
            }
            else
            {
                csRemoveBtn.Enabled = false;
            }
            csBoardGameList.Sorted = true;
        }

        private void csCancelBtn_Click(object sender, EventArgs e)
        {

            FormsProvider.CollectionScrn.Hide();

            FormsProvider.GamePicker.Show();
        }

        private void csAddBtn_Click(object sender, EventArgs e)
        {
            //Open add screen
            AddBoardGame abgScrn = new AddBoardGame();
            abgScrn.ShowDialog();
            LoadCollection();
        }
        //----Remove Button----
        private void csRemoveBtn_Click(object sender, EventArgs e)
        {
            if (selGame == null)
            {
                MessageBox.Show("No game selected to remove", "", MessageBoxButtons.OK);
                return;
            }
            //Confirm whether user wants to remove game
            DialogResult dr = MessageBox.Show("Are you sure you wish to delete the game " + selGame.GetName() + " from your collection?", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DatabaseHandler.RemoveGame(selGame);
                LoadCollection();
                FormsProvider.GamePicker.LoadGamesList();
            }
            //Remove selected game from list
            if (csBoardGameList.Items.Count <= 0)
            {
                ClearGameInfo();
            }
        }
        //Clear the game info panel's information
        void ClearGameInfo()
        {
            //name
            csSelGameTitle.Text = "";
            //Number of players
            csSelGamePlayers.Text = "";
            //Play Time
            csSelGameTime.Text = "";
            //Types
            csSelGameTypesList.Items.Clear();
            //Mechanics
            csSelGameMechanicsList.Items.Clear();
        }

        private void csBoardGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (BoardGame bg in _collectionList)
            {
                if (bg.GetName() == csBoardGameList.SelectedItem)
                {
                    selGame = bg;
                    break;
                }
            }
            Vector2 players = selGame.GetPlayerNum();
            Vector2 time = selGame.GetPlayTime();
            //----Set Game Info----
            //name
            csSelGameTitle.Text = selGame.GetName();
            //Number of players
            if (players.X == players.Y)
                csSelGamePlayers.Text = players.X.ToString();
            else
                csSelGamePlayers.Text = players.X + " to " + players.Y;
            //Play Time
            if (time.X == time.Y)
                csSelGameTime.Text = time.X + " Minutes";
            else
                csSelGameTime.Text = time.X + " to " + time.Y + " Minutes";
            //Types
            csSelGameTypesList.Items.Clear();
            foreach (string type in selGame.GetTypes())
                csSelGameTypesList.Items.Add(type);

            //Mechanics
            csSelGameMechanicsList.Items.Clear();
            foreach (string mechanics in selGame.GetMechanics())

                csSelGameMechanicsList.Items.Add(mechanics);

        }
    }
}