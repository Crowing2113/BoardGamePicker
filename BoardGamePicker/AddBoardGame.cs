using System.Collections.Generic;
using System.Numerics;

namespace BoardGamePicker
{
    public partial class AddBoardGame : Form
    {
        public AddBoardGame()
        {
            InitializeComponent();
            LoadTypeList();
            LoadMechanicList();
        }

        private void LoadMechanicList()
        {
            abgMechanicsListBox.Items.Clear();
            List<string> list = DatabaseHandler.GetMechanics();
            foreach (string mechanic in list)
                abgMechanicsListBox.Items.Add(mechanic);
        }

        private void LoadTypeList()
        {
            abgTypeListBox.Items.Clear();
            List<string> list = DatabaseHandler.GetTypesList();
            foreach (string type in list)
                abgTypeListBox.Items.Add(type);
        }

        private void abgCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormsProvider.OriginWindow.Show();
        }

        private void SaveNewGame(object sender, EventArgs e)
        {
            //Write to database first
            string gameTitle = abgNameTextBox.Text;
            Vector2 players = new Vector2(int.Parse(abgPlayerMin.Text), int.Parse(abgPlayerMax.Text));
            Vector2 playTime = new Vector2(int.Parse(abgTimeMin.Text), int.Parse(abgTimeMax.Text));
            List<string> tList = abgTypeListBox.SelectedItems.Cast<string>().ToList();
            List<string> mList = abgMechanicsListBox.SelectedItems.Cast<string>().ToList();

            DatabaseHandler.AddBoardGame(gameTitle, players, playTime, tList, mList);
            this.Close();
        }

        private void abgNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveNewGame(sender, e);
        }
    }
}
