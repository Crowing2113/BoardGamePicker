namespace BoardGamePicker
{
    partial class ViewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProfile));
            vpNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            vpNameDispLabel = new Label();
            vpGamesPlayedDisp = new Label();
            vpLikedGamesList = new ListBox();
            label5 = new Label();
            vpLikedMechanicsList = new ListBox();
            label6 = new Label();
            vpLikedTypeList = new ListBox();
            vpCancelBtn = new Button();
            vpToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // vpNameLabel
            // 
            vpNameLabel.AutoSize = true;
            vpNameLabel.Location = new Point(28, 23);
            vpNameLabel.Name = "vpNameLabel";
            vpNameLabel.Size = new Size(42, 15);
            vpNameLabel.TabIndex = 0;
            vpNameLabel.Text = "Name:";
            vpToolTip.SetToolTip(vpNameLabel, "Name of profile");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Games Played:";
            vpToolTip.SetToolTip(label1, "Number of games this profile has participated in");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Liked Games:";
            vpToolTip.SetToolTip(label2, "Displays liked games");
            // 
            // vpNameDispLabel
            // 
            vpNameDispLabel.AutoSize = true;
            vpNameDispLabel.Location = new Point(132, 23);
            vpNameDispLabel.Name = "vpNameDispLabel";
            vpNameDispLabel.Size = new Size(96, 15);
            vpNameDispLabel.TabIndex = 3;
            vpNameDispLabel.Text = "- Display Name -";
            // 
            // vpGamesPlayedDisp
            // 
            vpGamesPlayedDisp.AutoSize = true;
            vpGamesPlayedDisp.Location = new Point(132, 58);
            vpGamesPlayedDisp.Name = "vpGamesPlayedDisp";
            vpGamesPlayedDisp.Size = new Size(199, 15);
            vpGamesPlayedDisp.TabIndex = 4;
            vpGamesPlayedDisp.Text = "- Display Amount of Games Played -";
            // 
            // vpLikedGamesList
            // 
            vpLikedGamesList.FormattingEnabled = true;
            vpLikedGamesList.ItemHeight = 15;
            vpLikedGamesList.Location = new Point(30, 107);
            vpLikedGamesList.Name = "vpLikedGamesList";
            vpLikedGamesList.Size = new Size(406, 94);
            vpLikedGamesList.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 209);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 6;
            label5.Text = "Most Liked Mechanics:";
            vpToolTip.SetToolTip(label5, "Most common mechanics amongst liked games");
            // 
            // vpLikedMechanicsList
            // 
            vpLikedMechanicsList.FormattingEnabled = true;
            vpLikedMechanicsList.ItemHeight = 15;
            vpLikedMechanicsList.Location = new Point(30, 227);
            vpLikedMechanicsList.Name = "vpLikedMechanicsList";
            vpLikedMechanicsList.Size = new Size(406, 94);
            vpLikedMechanicsList.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 337);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 8;
            label6.Text = "Most Liked Type:";
            vpToolTip.SetToolTip(label6, "Most common type amongst liked games");
            // 
            // vpLikedTypeList
            // 
            vpLikedTypeList.FormattingEnabled = true;
            vpLikedTypeList.ItemHeight = 15;
            vpLikedTypeList.Location = new Point(28, 355);
            vpLikedTypeList.Name = "vpLikedTypeList";
            vpLikedTypeList.Size = new Size(408, 94);
            vpLikedTypeList.TabIndex = 9;
            // 
            // vpCancelBtn
            // 
            vpCancelBtn.Location = new Point(197, 455);
            vpCancelBtn.Name = "vpCancelBtn";
            vpCancelBtn.Size = new Size(75, 23);
            vpCancelBtn.TabIndex = 10;
            vpCancelBtn.Text = "Cancel";
            vpCancelBtn.UseVisualStyleBackColor = true;
            vpCancelBtn.Click += vpCancelBtn_Click;
            // 
            // ViewProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 491);
            Controls.Add(vpCancelBtn);
            Controls.Add(vpLikedTypeList);
            Controls.Add(label6);
            Controls.Add(vpLikedMechanicsList);
            Controls.Add(label5);
            Controls.Add(vpLikedGamesList);
            Controls.Add(vpGamesPlayedDisp);
            Controls.Add(vpNameDispLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vpNameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vpNameLabel;
        private Label label1;
        private Label label2;
        private Label vpNameDispLabel;
        private Label vpGamesPlayedDisp;
        private ListBox vpLikedGamesList;
        private Label label5;
        private ListBox vpLikedMechanicsList;
        private Label label6;
        private ListBox vpLikedTypeList;
        private Button vpCancelBtn;
        private ToolTip vpToolTip;
    }
}