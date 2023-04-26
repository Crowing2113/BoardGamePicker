namespace BoardGamePicker
{
    public partial class CollectionScreen : Form
    {
        public static List<BoardGame> _collectionList = new List<BoardGame>();
        BoardGame selGame = null;
        public CollectionScreen()
        {
            InitializeComponent();
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
                csRemoveBtn .Enabled = false;
            }
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
            if(selGame == null)
            {
                MessageBox.Show("No game selected to remove", "", MessageBoxButtons.OK);
                return;
            }
            //Confirm whether user wants to remove game
            DialogResult dr = MessageBox.Show("Are you sure you wish to delete the game "+selGame.GetName()+" from your collection?", "CAUTION", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                DatabaseHandler.RemoveGame(selGame);
                LoadCollection();
                FormsProvider.GamePicker.LoadGamesList();
            }
            //Remove selected game from list
        }

        private void csBoardGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(BoardGame bg in _collectionList)
            {
                if(bg.GetName() == csBoardGameList.SelectedItem)
                {
                    selGame = bg;
                    break;
                }
            }
        }
    }
}