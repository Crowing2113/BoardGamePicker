namespace BoardGamePicker
{
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
        }

        private void cpCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveNewPlayer(object sender, EventArgs e)
        {
            //save profile
            string pName = cpInputNameBox.Text;
            //check if the entered name is not blank
            if (pName == "")
            {
                MessageBox.Show("Name must not be blank", "", MessageBoxButtons.OK);
                return;
            }
            DatabaseHandler.CreateProfile(pName);
            this.Close();
        }

        private void cpInputNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                SaveNewPlayer(sender,e);
        }
    }
}
