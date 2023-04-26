namespace BoardGamePicker
{
    public partial class CollectionScreen : Form
    {
        public static List<BoardGame> _collectionList = new List<BoardGame>();
        public CollectionScreen()
        {
            InitializeComponent();
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
        }

        private void csRemoveBtn_Click(object sender, EventArgs e)
        {
            //Remove selected game from list
        }

    }
}