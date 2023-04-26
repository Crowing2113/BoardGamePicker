namespace BoardGamePicker
{
    public partial class AddBoardGame : Form
    {
        public AddBoardGame()
        {
            InitializeComponent();
        }

        private void abgCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormsProvider.OriginWindow.Show();
        }

        private void SaveNewGame(object sender, EventArgs e)
        {
            //Write to database first

            this.Close();

        }

        private void abgNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveNewGame(sender, e);
        }
    }
}
