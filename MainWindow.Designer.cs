namespace bgpicker2
{
    partial class GamePicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePicker));
            MenuController = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            profilesMenuItem = new ToolStripMenuItem();
            menuItem_profilesCreate = new ToolStripMenuItem();
            menuItem_profilesView = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            gamesToolStripMenuItem = new ToolStripMenuItem();
            addBoardGameToolStripMenuItem = new ToolStripMenuItem();
            viewCollectionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            importFromBGGTestToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            sortByToolStripMenuItem = new ToolStripMenuItem();
            alphabeticToolStripMenuItem = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            timeToolStripMenuItem = new ToolStripMenuItem();
            filterByToolStripMenuItem = new ToolStripMenuItem();
            allToolStripMenuItem = new ToolStripMenuItem();
            playedToolStripMenuItem = new ToolStripMenuItem();
            unplayedToolStripMenuItem = new ToolStripMenuItem();
            MainToolTipController = new ToolTip(components);
            playGameBtn = new Button();
            addPlayerBtn = new Button();
            removePlayerBtn = new Button();
            viewPlayerBtn = new Button();
            groupBox1 = new GroupBox();
            playerCount = new Label();
            activePlayerList = new ListBox();
            databaseHandlerBindingSource = new BindingSource(components);
            boardGameListGroup = new GroupBox();
            GameList = new ListBox();
            gameInfoGroupPanel = new GroupBox();
            selGameTime = new Label();
            selGamePlayers = new Label();
            GIgameTime = new Label();
            GIgamePlayers = new Label();
            selGameTitle = new Label();
            GIgameTitle = new Label();
            MenuController.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseHandlerBindingSource).BeginInit();
            boardGameListGroup.SuspendLayout();
            gameInfoGroupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuController
            // 
            MenuController.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, profilesMenuItem, gamesToolStripMenuItem, viewToolStripMenuItem });
            MenuController.Location = new Point(0, 0);
            MenuController.Name = "MenuController";
            MenuController.Size = new Size(613, 24);
            MenuController.TabIndex = 0;
            MenuController.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(97, 22);
            toolStripMenuItem1.Text = "Quit";
            toolStripMenuItem1.ToolTipText = "Quit the Application";
            toolStripMenuItem1.Click += quitToolStripMenuItem_Click;
            // 
            // profilesMenuItem
            // 
            profilesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItem_profilesCreate, menuItem_profilesView, toolStripSeparator1 });
            profilesMenuItem.Name = "profilesMenuItem";
            profilesMenuItem.Size = new Size(58, 20);
            profilesMenuItem.Text = "Profiles";
            // 
            // menuItem_profilesCreate
            // 
            menuItem_profilesCreate.Name = "menuItem_profilesCreate";
            menuItem_profilesCreate.Size = new Size(145, 22);
            menuItem_profilesCreate.Text = "Create Profile";
            menuItem_profilesCreate.ToolTipText = "Create a new Profile";
            menuItem_profilesCreate.Click += menuItem_profilesCreate_Click;
            // 
            // menuItem_profilesView
            // 
            menuItem_profilesView.Name = "menuItem_profilesView";
            menuItem_profilesView.Size = new Size(145, 22);
            menuItem_profilesView.Text = "View Profiles";
            menuItem_profilesView.Click += menuItem_profilesView_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(142, 6);
            // 
            // gamesToolStripMenuItem
            // 
            gamesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBoardGameToolStripMenuItem, viewCollectionToolStripMenuItem, toolStripSeparator2, importFromBGGTestToolStripMenuItem });
            gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            gamesToolStripMenuItem.Size = new Size(55, 20);
            gamesToolStripMenuItem.Text = "Games";
            // 
            // addBoardGameToolStripMenuItem
            // 
            addBoardGameToolStripMenuItem.Name = "addBoardGameToolStripMenuItem";
            addBoardGameToolStripMenuItem.Size = new Size(198, 22);
            addBoardGameToolStripMenuItem.Text = "Add Board Game";
            addBoardGameToolStripMenuItem.Click += addBoardGameToolStripMenuItem_Click;
            // 
            // viewCollectionToolStripMenuItem
            // 
            viewCollectionToolStripMenuItem.Name = "viewCollectionToolStripMenuItem";
            viewCollectionToolStripMenuItem.Size = new Size(198, 22);
            viewCollectionToolStripMenuItem.Text = "View Collection";
            viewCollectionToolStripMenuItem.Click += viewCollectionToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(195, 6);
            // 
            // importFromBGGTestToolStripMenuItem
            // 
            importFromBGGTestToolStripMenuItem.Enabled = false;
            importFromBGGTestToolStripMenuItem.Name = "importFromBGGTestToolStripMenuItem";
            importFromBGGTestToolStripMenuItem.Size = new Size(198, 22);
            importFromBGGTestToolStripMenuItem.Text = "Import From BGG (Test)";
            importFromBGGTestToolStripMenuItem.ToolTipText = "Not Yet Implemented";
            importFromBGGTestToolStripMenuItem.Click += importFromBGGTestToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sortByToolStripMenuItem, filterByToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // sortByToolStripMenuItem
            // 
            sortByToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alphabeticToolStripMenuItem, playersToolStripMenuItem, timeToolStripMenuItem });
            sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            sortByToolStripMenuItem.Size = new Size(180, 22);
            sortByToolStripMenuItem.Text = "Sort By";
            // 
            // alphabeticToolStripMenuItem
            // 
            alphabeticToolStripMenuItem.Name = "alphabeticToolStripMenuItem";
            alphabeticToolStripMenuItem.Size = new Size(111, 22);
            alphabeticToolStripMenuItem.Text = "Title";
            alphabeticToolStripMenuItem.ToolTipText = "Sort by Title (Click to switch asc/desc)";
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new Size(111, 22);
            playersToolStripMenuItem.Text = "Players";
            playersToolStripMenuItem.ToolTipText = "Sort by Players (Click to switch asc/desc)";
            // 
            // timeToolStripMenuItem
            // 
            timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            timeToolStripMenuItem.Size = new Size(111, 22);
            timeToolStripMenuItem.Text = "Time";
            timeToolStripMenuItem.ToolTipText = "Sort by Play Time";
            // 
            // filterByToolStripMenuItem
            // 
            filterByToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allToolStripMenuItem, playedToolStripMenuItem, unplayedToolStripMenuItem });
            filterByToolStripMenuItem.Name = "filterByToolStripMenuItem";
            filterByToolStripMenuItem.Size = new Size(180, 22);
            filterByToolStripMenuItem.Text = "Filter By";
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(124, 22);
            allToolStripMenuItem.Text = "All";
            allToolStripMenuItem.ToolTipText = "Display all games";
            // 
            // playedToolStripMenuItem
            // 
            playedToolStripMenuItem.Name = "playedToolStripMenuItem";
            playedToolStripMenuItem.Size = new Size(124, 22);
            playedToolStripMenuItem.Text = "Played";
            playedToolStripMenuItem.ToolTipText = "Display games most players have played";
            // 
            // unplayedToolStripMenuItem
            // 
            unplayedToolStripMenuItem.Name = "unplayedToolStripMenuItem";
            unplayedToolStripMenuItem.Size = new Size(124, 22);
            unplayedToolStripMenuItem.Text = "Unplayed";
            unplayedToolStripMenuItem.ToolTipText = "Display games most players have not played";
            // 
            // playGameBtn
            // 
            playGameBtn.Location = new Point(6, 22);
            playGameBtn.Name = "playGameBtn";
            playGameBtn.Size = new Size(75, 23);
            playGameBtn.TabIndex = 3;
            playGameBtn.Text = "Play";
            MainToolTipController.SetToolTip(playGameBtn, "Play the selected board game");
            playGameBtn.UseVisualStyleBackColor = true;
            playGameBtn.Click += playGameBtn_Click;
            // 
            // addPlayerBtn
            // 
            addPlayerBtn.Location = new Point(9, 359);
            addPlayerBtn.Name = "addPlayerBtn";
            addPlayerBtn.Size = new Size(53, 57);
            addPlayerBtn.TabIndex = 1;
            addPlayerBtn.Text = "+";
            MainToolTipController.SetToolTip(addPlayerBtn, "Add a player to the list");
            addPlayerBtn.UseVisualStyleBackColor = true;
            addPlayerBtn.Click += addPlayerBtn_Click;
            // 
            // removePlayerBtn
            // 
            removePlayerBtn.Location = new Point(68, 359);
            removePlayerBtn.Name = "removePlayerBtn";
            removePlayerBtn.Size = new Size(53, 57);
            removePlayerBtn.TabIndex = 2;
            removePlayerBtn.Text = "-";
            MainToolTipController.SetToolTip(removePlayerBtn, "Remove selected player from list");
            removePlayerBtn.UseVisualStyleBackColor = true;
            removePlayerBtn.Click += removePlayerBtn_Click;
            // 
            // viewPlayerBtn
            // 
            viewPlayerBtn.Location = new Point(126, 359);
            viewPlayerBtn.Name = "viewPlayerBtn";
            viewPlayerBtn.Size = new Size(53, 57);
            viewPlayerBtn.TabIndex = 4;
            viewPlayerBtn.Text = "View";
            MainToolTipController.SetToolTip(viewPlayerBtn, "View the selected Player's profile");
            viewPlayerBtn.UseVisualStyleBackColor = true;
            viewPlayerBtn.Click += viewPlayerBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(playerCount);
            groupBox1.Controls.Add(viewPlayerBtn);
            groupBox1.Controls.Add(removePlayerBtn);
            groupBox1.Controls.Add(addPlayerBtn);
            groupBox1.Controls.Add(activePlayerList);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 421);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Players";
            // 
            // playerCount
            // 
            playerCount.AutoSize = true;
            playerCount.Location = new Point(166, 0);
            playerCount.Name = "playerCount";
            playerCount.Size = new Size(13, 15);
            playerCount.TabIndex = 6;
            playerCount.Text = "0";
            playerCount.TextChanged += playerCount_TextChanged;
            // 
            // activePlayerList
            // 
            activePlayerList.FormattingEnabled = true;
            activePlayerList.ItemHeight = 15;
            activePlayerList.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0" });
            activePlayerList.Location = new Point(9, 22);
            activePlayerList.Name = "activePlayerList";
            activePlayerList.Size = new Size(170, 319);
            activePlayerList.TabIndex = 0;
            activePlayerList.SelectedIndexChanged += activePlayerList_SelectedIndexChanged;
            // 
            // databaseHandlerBindingSource
            // 
            databaseHandlerBindingSource.DataSource = typeof(DatabaseHandler);
            // 
            // boardGameListGroup
            // 
            boardGameListGroup.Controls.Add(GameList);
            boardGameListGroup.Controls.Add(playGameBtn);
            boardGameListGroup.Location = new Point(203, 27);
            boardGameListGroup.Name = "boardGameListGroup";
            boardGameListGroup.Size = new Size(389, 421);
            boardGameListGroup.TabIndex = 2;
            boardGameListGroup.TabStop = false;
            boardGameListGroup.Text = "Board Game List";
            // 
            // GameList
            // 
            GameList.FormattingEnabled = true;
            GameList.ItemHeight = 15;
            GameList.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0" });
            GameList.Location = new Point(6, 52);
            GameList.Name = "GameList";
            GameList.Size = new Size(377, 364);
            GameList.TabIndex = 4;
            GameList.SelectedIndexChanged += GameList_SelectedIndexChanged;
            // 
            // gameInfoGroupPanel
            // 
            gameInfoGroupPanel.Controls.Add(selGameTime);
            gameInfoGroupPanel.Controls.Add(selGamePlayers);
            gameInfoGroupPanel.Controls.Add(GIgameTime);
            gameInfoGroupPanel.Controls.Add(GIgamePlayers);
            gameInfoGroupPanel.Controls.Add(selGameTitle);
            gameInfoGroupPanel.Controls.Add(GIgameTitle);
            gameInfoGroupPanel.Location = new Point(203, 454);
            gameInfoGroupPanel.Name = "gameInfoGroupPanel";
            gameInfoGroupPanel.Size = new Size(398, 93);
            gameInfoGroupPanel.TabIndex = 3;
            gameInfoGroupPanel.TabStop = false;
            gameInfoGroupPanel.Text = "Game Info";
            // 
            // selGameTime
            // 
            selGameTime.AutoSize = true;
            selGameTime.Location = new Point(87, 64);
            selGameTime.Name = "selGameTime";
            selGameTime.Size = new Size(80, 15);
            selGameTime.TabIndex = 8;
            selGameTime.Text = "- game time -";
            // 
            // selGamePlayers
            // 
            selGamePlayers.AutoSize = true;
            selGamePlayers.Location = new Point(87, 49);
            selGamePlayers.Name = "selGamePlayers";
            selGamePlayers.Size = new Size(93, 15);
            selGamePlayers.TabIndex = 6;
            selGamePlayers.Text = "- game players -";
            // 
            // GIgameTime
            // 
            GIgameTime.AutoSize = true;
            GIgameTime.Location = new Point(15, 64);
            GIgameTime.Name = "GIgameTime";
            GIgameTime.Size = new Size(36, 15);
            GIgameTime.TabIndex = 3;
            GIgameTime.Text = "Time:";
            // 
            // GIgamePlayers
            // 
            GIgamePlayers.AutoSize = true;
            GIgamePlayers.Location = new Point(15, 49);
            GIgamePlayers.Name = "GIgamePlayers";
            GIgamePlayers.Size = new Size(47, 15);
            GIgamePlayers.TabIndex = 2;
            GIgamePlayers.Text = "Players:";
            // 
            // selGameTitle
            // 
            selGameTitle.AutoSize = true;
            selGameTitle.Location = new Point(87, 34);
            selGameTitle.Name = "selGameTitle";
            selGameTitle.Size = new Size(76, 15);
            selGameTitle.TabIndex = 1;
            selGameTitle.Text = "- game title -";
            // 
            // GIgameTitle
            // 
            GIgameTitle.AutoSize = true;
            GIgameTitle.Location = new Point(15, 34);
            GIgameTitle.Name = "GIgameTitle";
            GIgameTitle.Size = new Size(66, 15);
            GIgameTitle.TabIndex = 0;
            GIgameTitle.Text = "Game Title:";
            // 
            // GamePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 559);
            Controls.Add(gameInfoGroupPanel);
            Controls.Add(boardGameListGroup);
            Controls.Add(groupBox1);
            Controls.Add(MenuController);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuController;
            Name = "GamePicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Picker";
            MenuController.ResumeLayout(false);
            MenuController.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databaseHandlerBindingSource).EndInit();
            boardGameListGroup.ResumeLayout(false);
            gameInfoGroupPanel.ResumeLayout(false);
            gameInfoGroupPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuController;
        private ToolStripMenuItem profilesMenuItem;
        private ToolStripMenuItem menuItem_profilesCreate;
        private ToolStripMenuItem menuItem_profilesView;
        private ToolTip MainToolTipController;
        private ToolStripMenuItem gamesToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem addBoardGameToolStripMenuItem;
        private ToolStripMenuItem viewCollectionToolStripMenuItem;
        private ToolStripMenuItem sortByToolStripMenuItem;
        private ToolStripMenuItem alphabeticToolStripMenuItem;
        private ToolStripMenuItem filterByToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem playedToolStripMenuItem;
        private ToolStripMenuItem unplayedToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private GroupBox groupBox1;
        private GroupBox boardGameListGroup;
        private Button playGameBtn;
        private ListBox activePlayerList;
        private ListBox GameList;
        private GroupBox gameInfoGroupPanel;
        private Button removePlayerBtn;
        private Button addPlayerBtn;
        private Label selGameTime;
        private Label selGamePlayers;
        private Label GIgameTime;
        private Label GIgamePlayers;
        private Label selGameTitle;
        private Label GIgameTitle;
        private Button viewPlayerBtn;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private BindingSource databaseHandlerBindingSource;
        private Label playerCount;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem importFromBGGTestToolStripMenuItem;
    }
}