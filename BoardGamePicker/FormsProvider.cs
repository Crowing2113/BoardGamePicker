namespace BoardGamePicker
{
    public partial class FormsProvider
    {
        //main screen
        public static GamePicker GamePicker
        {
            get
            {
                if (_gamePicker == null)
                {
                    _gamePicker = new GamePicker();
                }
                return _gamePicker;
            }

        }
        //Collection screen
        public static CollectionScreen CollectionScrn
        {
            get
            {
                if (_collScrn == null)
                {
                    _collScrn = new CollectionScreen();
                }
                return _collScrn;
            }
        }
        //Origin window - if goign to a form that has multiple paths then keep track where you came from (i.e going to AddBoardGame screen from collection or main)
        public static Form OriginWindow
        {
            get
            {
                if (_originWindow == null)
                {
                    _originWindow = _gamePicker;
                }
                return _originWindow;
            }
        }
        //player profiles screen
        public static PlayerProfiles PlayerProfiles
        {
            get
            {
                if (_playerProfiles == null)
                {
                    _playerProfiles = new PlayerProfiles();
                }

                _playerProfiles.LoadProfiles();
                return _playerProfiles;
            }
        }
        //change which screen you cam from, usually just input this
        public static void ChangePrevious(Form prevForm)
        {
            _originWindow = prevForm;
        }

        //main screen singleton
        private static GamePicker _gamePicker;
        //collection screen singleton
        private static CollectionScreen _collScrn;
        //player profiles screen singleton
        private static PlayerProfiles _playerProfiles;

        private static Form _originWindow = _gamePicker;
    }
}
