﻿namespace BoardGamePicker
{
    partial class CollectionScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionScreen));
            csBoardGameList = new ListBox();
            csAddBtn = new Button();
            csRemoveBtn = new Button();
            csCancelBtn = new Button();
            gameInfoGroupPanel = new GroupBox();
            csSelGameMechanics = new Label();
            GIgameMechanics = new Label();
            csSelGameType = new Label();
            csSelGameTime = new Label();
            csSelGameAge = new Label();
            csSelGamePlayers = new Label();
            GIgameType = new Label();
            GIgameAge = new Label();
            GIgameTime = new Label();
            GIgamePlayers = new Label();
            csSelGameTitle = new Label();
            csGameTitle = new Label();
            csToolTip = new ToolTip(components);
            gameInfoGroupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // csBoardGameList
            // 
            csBoardGameList.FormattingEnabled = true;
            csBoardGameList.ItemHeight = 15;
            csBoardGameList.Location = new Point(12, 12);
            csBoardGameList.Name = "csBoardGameList";
            csBoardGameList.Size = new Size(411, 409);
            csBoardGameList.TabIndex = 0;
            // 
            // csAddBtn
            // 
            csAddBtn.Location = new Point(429, 12);
            csAddBtn.Name = "csAddBtn";
            csAddBtn.Size = new Size(75, 23);
            csAddBtn.TabIndex = 1;
            csAddBtn.Text = "Add";
            csToolTip.SetToolTip(csAddBtn, "Add a new game to the collection");
            csAddBtn.UseVisualStyleBackColor = true;
            csAddBtn.Click += csAddBtn_Click;
            // 
            // csRemoveBtn
            // 
            csRemoveBtn.Location = new Point(429, 41);
            csRemoveBtn.Name = "csRemoveBtn";
            csRemoveBtn.Size = new Size(75, 23);
            csRemoveBtn.TabIndex = 2;
            csRemoveBtn.Text = "Remove";
            csToolTip.SetToolTip(csRemoveBtn, "Remove selected game from collection");
            csRemoveBtn.UseVisualStyleBackColor = true;
            csRemoveBtn.Click += csRemoveBtn_Click;
            // 
            // csCancelBtn
            // 
            csCancelBtn.Location = new Point(429, 70);
            csCancelBtn.Name = "csCancelBtn";
            csCancelBtn.Size = new Size(75, 23);
            csCancelBtn.TabIndex = 3;
            csCancelBtn.Text = "Cancel";
            csToolTip.SetToolTip(csCancelBtn, "Close the window");
            csCancelBtn.UseVisualStyleBackColor = true;
            csCancelBtn.Click += csCancelBtn_Click;
            // 
            // gameInfoGroupPanel
            // 
            gameInfoGroupPanel.Controls.Add(csSelGameMechanics);
            gameInfoGroupPanel.Controls.Add(GIgameMechanics);
            gameInfoGroupPanel.Controls.Add(csSelGameType);
            gameInfoGroupPanel.Controls.Add(csSelGameTime);
            gameInfoGroupPanel.Controls.Add(csSelGameAge);
            gameInfoGroupPanel.Controls.Add(csSelGamePlayers);
            gameInfoGroupPanel.Controls.Add(GIgameType);
            gameInfoGroupPanel.Controls.Add(GIgameAge);
            gameInfoGroupPanel.Controls.Add(GIgameTime);
            gameInfoGroupPanel.Controls.Add(GIgamePlayers);
            gameInfoGroupPanel.Controls.Add(csSelGameTitle);
            gameInfoGroupPanel.Controls.Add(csGameTitle);
            gameInfoGroupPanel.Location = new Point(12, 431);
            gameInfoGroupPanel.Name = "gameInfoGroupPanel";
            gameInfoGroupPanel.Size = new Size(492, 179);
            gameInfoGroupPanel.TabIndex = 4;
            gameInfoGroupPanel.TabStop = false;
            gameInfoGroupPanel.Text = "Game Info";
            // 
            // csSelGameMechanics
            // 
            csSelGameMechanics.AutoSize = true;
            csSelGameMechanics.Location = new Point(88, 109);
            csSelGameMechanics.Name = "csSelGameMechanics";
            csSelGameMechanics.Size = new Size(113, 15);
            csSelGameMechanics.TabIndex = 11;
            csSelGameMechanics.Text = "- game mechanics -";
            // 
            // GIgameMechanics
            // 
            GIgameMechanics.AutoSize = true;
            GIgameMechanics.Location = new Point(15, 109);
            GIgameMechanics.Name = "GIgameMechanics";
            GIgameMechanics.Size = new Size(67, 15);
            GIgameMechanics.TabIndex = 10;
            GIgameMechanics.Text = "Mechanics:";
            // 
            // csSelGameType
            // 
            csSelGameType.AutoSize = true;
            csSelGameType.Location = new Point(87, 94);
            csSelGameType.Name = "csSelGameType";
            csSelGameType.Size = new Size(79, 15);
            csSelGameType.TabIndex = 9;
            csSelGameType.Text = "- game type -";
            // 
            // csSelGameTime
            // 
            csSelGameTime.AutoSize = true;
            csSelGameTime.Location = new Point(87, 79);
            csSelGameTime.Name = "csSelGameTime";
            csSelGameTime.Size = new Size(80, 15);
            csSelGameTime.TabIndex = 8;
            csSelGameTime.Text = "- game time -";
            // 
            // csSelGameAge
            // 
            csSelGameAge.AutoSize = true;
            csSelGameAge.Location = new Point(87, 64);
            csSelGameAge.Name = "csSelGameAge";
            csSelGameAge.Size = new Size(75, 15);
            csSelGameAge.TabIndex = 7;
            csSelGameAge.Text = "- game age -";
            // 
            // csSelGamePlayers
            // 
            csSelGamePlayers.AutoSize = true;
            csSelGamePlayers.Location = new Point(87, 49);
            csSelGamePlayers.Name = "csSelGamePlayers";
            csSelGamePlayers.Size = new Size(93, 15);
            csSelGamePlayers.TabIndex = 6;
            csSelGamePlayers.Text = "- game players -";
            // 
            // GIgameType
            // 
            GIgameType.AutoSize = true;
            GIgameType.Location = new Point(15, 94);
            GIgameType.Name = "GIgameType";
            GIgameType.Size = new Size(34, 15);
            GIgameType.TabIndex = 5;
            GIgameType.Text = "Type:";
            // 
            // GIgameAge
            // 
            GIgameAge.AutoSize = true;
            GIgameAge.Location = new Point(15, 64);
            GIgameAge.Name = "GIgameAge";
            GIgameAge.Size = new Size(31, 15);
            GIgameAge.TabIndex = 4;
            GIgameAge.Text = "Age:";
            // 
            // GIgameTime
            // 
            GIgameTime.AutoSize = true;
            GIgameTime.Location = new Point(15, 79);
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
            // csSelGameTitle
            // 
            csSelGameTitle.AutoSize = true;
            csSelGameTitle.Location = new Point(87, 34);
            csSelGameTitle.Name = "csSelGameTitle";
            csSelGameTitle.Size = new Size(76, 15);
            csSelGameTitle.TabIndex = 1;
            csSelGameTitle.Text = "- game title -";
            // 
            // csGameTitle
            // 
            csGameTitle.AutoSize = true;
            csGameTitle.Location = new Point(15, 34);
            csGameTitle.Name = "csGameTitle";
            csGameTitle.Size = new Size(66, 15);
            csGameTitle.TabIndex = 0;
            csGameTitle.Text = "Game Title:";
            // 
            // CollectionScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 622);
            Controls.Add(gameInfoGroupPanel);
            Controls.Add(csCancelBtn);
            Controls.Add(csRemoveBtn);
            Controls.Add(csAddBtn);
            Controls.Add(csBoardGameList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CollectionScreen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Collection";
            gameInfoGroupPanel.ResumeLayout(false);
            gameInfoGroupPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox csBoardGameList;
        private Button csAddBtn;
        private Button csRemoveBtn;
        private Button csCancelBtn;
        private GroupBox gameInfoGroupPanel;
        private Label csSelGameMechanics;
        private Label GIgameMechanics;
        private Label csSelGameType;
        private Label csSelGameTime;
        private Label csSelGameAge;
        private Label csSelGamePlayers;
        private Label GIgameType;
        private Label GIgameAge;
        private Label GIgameTime;
        private Label GIgamePlayers;
        private Label csSelGameTitle;
        private Label csGameTitle;
        private ToolTip csToolTip;
    }
}