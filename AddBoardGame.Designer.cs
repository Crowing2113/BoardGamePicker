namespace bgpicker2
{
    partial class AddBoardGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBoardGame));
            abgNameLabel = new Label();
            abgNameTextBox = new TextBox();
            abgPlayerMin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            abgType = new Label();
            abgPlayerMax = new TextBox();
            label4 = new Label();
            label5 = new Label();
            abgTimeMax = new TextBox();
            abgTimeMin = new TextBox();
            abgSaveBtn = new Button();
            abgCancelBtn = new Button();
            label3 = new Label();
            abgToolTip = new ToolTip(components);
            abgTypeListBox = new ListBox();
            abgMechanicsListBox = new ListBox();
            SearchBtn = new Button();
            SuspendLayout();
            // 
            // abgNameLabel
            // 
            abgNameLabel.AutoSize = true;
            abgNameLabel.Location = new Point(21, 25);
            abgNameLabel.Name = "abgNameLabel";
            abgNameLabel.Size = new Size(32, 15);
            abgNameLabel.TabIndex = 0;
            abgNameLabel.Text = "Title:";
            abgToolTip.SetToolTip(abgNameLabel, "Title of the Board Game");
            // 
            // abgNameTextBox
            // 
            abgNameTextBox.Location = new Point(112, 22);
            abgNameTextBox.Name = "abgNameTextBox";
            abgNameTextBox.PlaceholderText = "Enter name of game";
            abgNameTextBox.Size = new Size(134, 23);
            abgNameTextBox.TabIndex = 1;
            abgNameTextBox.KeyDown += abgNameTextBox_KeyDown;
            // 
            // abgPlayerMin
            // 
            abgPlayerMin.Location = new Point(112, 66);
            abgPlayerMin.Name = "abgPlayerMin";
            abgPlayerMin.Size = new Size(29, 23);
            abgPlayerMin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 69);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Players:";
            abgToolTip.SetToolTip(label1, "Minimum to Maximum. Enter the same if player size is set (i.e. 4 = min 4, max 4)");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 114);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Time:";
            abgToolTip.SetToolTip(label2, " Minimum to Maximum. Enter the same if Time is average (i.e. 60 = min 60, max 60)");
            // 
            // abgType
            // 
            abgType.AutoSize = true;
            abgType.Location = new Point(21, 158);
            abgType.Name = "abgType";
            abgType.Size = new Size(34, 15);
            abgType.TabIndex = 6;
            abgType.Text = "Type:";
            abgToolTip.SetToolTip(abgType, "The game type, such as Strategy, Adventure etc...");
            // 
            // abgPlayerMax
            // 
            abgPlayerMax.Location = new Point(217, 66);
            abgPlayerMax.Name = "abgPlayerMax";
            abgPlayerMax.Size = new Size(29, 23);
            abgPlayerMax.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 69);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 9;
            label4.Text = "to";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 114);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 12;
            label5.Text = "to";
            // 
            // abgTimeMax
            // 
            abgTimeMax.Location = new Point(217, 111);
            abgTimeMax.Name = "abgTimeMax";
            abgTimeMax.Size = new Size(29, 23);
            abgTimeMax.TabIndex = 11;
            // 
            // abgTimeMin
            // 
            abgTimeMin.Location = new Point(112, 111);
            abgTimeMin.Name = "abgTimeMin";
            abgTimeMin.Size = new Size(29, 23);
            abgTimeMin.TabIndex = 10;
            // 
            // abgSaveBtn
            // 
            abgSaveBtn.Location = new Point(419, 22);
            abgSaveBtn.Name = "abgSaveBtn";
            abgSaveBtn.Size = new Size(75, 23);
            abgSaveBtn.TabIndex = 13;
            abgSaveBtn.Text = "Save";
            abgSaveBtn.UseVisualStyleBackColor = true;
            abgSaveBtn.Click += SaveNewGame;
            // 
            // abgCancelBtn
            // 
            abgCancelBtn.Location = new Point(419, 66);
            abgCancelBtn.Name = "abgCancelBtn";
            abgCancelBtn.Size = new Size(75, 23);
            abgCancelBtn.TabIndex = 14;
            abgCancelBtn.Text = "Cancel";
            abgCancelBtn.UseVisualStyleBackColor = true;
            abgCancelBtn.Click += abgCancelBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 258);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 16;
            label3.Text = "Mechanics:";
            abgToolTip.SetToolTip(label3, "Main mechanics of games such as Dice Rolling, Resource Management etc...");
            // 
            // abgTypeListBox
            // 
            abgTypeListBox.FormattingEnabled = true;
            abgTypeListBox.ItemHeight = 15;
            abgTypeListBox.Location = new Point(112, 158);
            abgTypeListBox.Name = "abgTypeListBox";
            abgTypeListBox.SelectionMode = SelectionMode.MultiSimple;
            abgTypeListBox.Size = new Size(382, 94);
            abgTypeListBox.TabIndex = 18;
            // 
            // abgMechanicsListBox
            // 
            abgMechanicsListBox.FormattingEnabled = true;
            abgMechanicsListBox.ItemHeight = 15;
            abgMechanicsListBox.Location = new Point(112, 261);
            abgMechanicsListBox.Name = "abgMechanicsListBox";
            abgMechanicsListBox.SelectionMode = SelectionMode.MultiSimple;
            abgMechanicsListBox.Size = new Size(382, 94);
            abgMechanicsListBox.TabIndex = 19;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(261, 22);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 20;
            SearchBtn.Text = "Search";
            abgToolTip.SetToolTip(SearchBtn, "Not available yet");
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += Search;
            // 
            // AddBoardGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 367);
            Controls.Add(SearchBtn);
            Controls.Add(abgMechanicsListBox);
            Controls.Add(abgTypeListBox);
            Controls.Add(label3);
            Controls.Add(abgCancelBtn);
            Controls.Add(abgSaveBtn);
            Controls.Add(label5);
            Controls.Add(abgTimeMax);
            Controls.Add(abgTimeMin);
            Controls.Add(label4);
            Controls.Add(abgPlayerMax);
            Controls.Add(abgType);
            Controls.Add(label2);
            Controls.Add(abgPlayerMin);
            Controls.Add(label1);
            Controls.Add(abgNameTextBox);
            Controls.Add(abgNameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBoardGame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddBoardGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label abgNameLabel;
        private TextBox abgNameTextBox;
        private TextBox abgPlayerMin;
        private Label label1;
        private Label label2;
        private Label abgType;
        private TextBox abgPlayerMax;
        private Label label4;
        private Label label5;
        private TextBox abgTimeMax;
        private TextBox abgTimeMin;
        private Button abgSaveBtn;
        private Button abgCancelBtn;
        private Label label3;
        private ToolTip abgToolTip;
        private ListBox abgTypeListBox;
        private ListBox abgMechanicsListBox;
        private Button SearchBtn;
    }
}