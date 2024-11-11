namespace bgpicker2
{
    partial class SearchResultWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultWindow));
            gamesResultList = new ListBox();
            button1 = new Button();
            searchTextBox = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            selGameInfo = new RichTextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gamesResultList
            // 
            gamesResultList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gamesResultList.FormattingEnabled = true;
            gamesResultList.HorizontalScrollbar = true;
            gamesResultList.ItemHeight = 15;
            gamesResultList.Location = new Point(6, 22);
            gamesResultList.Name = "gamesResultList";
            gamesResultList.Size = new Size(488, 244);
            gamesResultList.TabIndex = 0;
            gamesResultList.SelectedIndexChanged += gamesResultList_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(431, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 11);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(115, 23);
            searchTextBox.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(133, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SearchBtnClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selGameInfo);
            groupBox1.Location = new Point(6, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 116);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Game";
            // 
            // selGameInfo
            // 
            selGameInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selGameInfo.BackColor = SystemColors.Control;
            selGameInfo.Location = new Point(7, 16);
            selGameInfo.Name = "selGameInfo";
            selGameInfo.ReadOnly = true;
            selGameInfo.Size = new Size(487, 94);
            selGameInfo.TabIndex = 0;
            selGameInfo.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gamesResultList);
            groupBox2.Location = new Point(6, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 280);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Results";
            // 
            // SearchResultWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(searchTextBox);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SearchResultWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search for Board Game";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox gamesResultList;
        private Button button1;
        private TextBox searchTextBox;
        private Button button2;
        private GroupBox groupBox1;
        private RichTextBox selGameInfo;
        private GroupBox groupBox2;
    }
}