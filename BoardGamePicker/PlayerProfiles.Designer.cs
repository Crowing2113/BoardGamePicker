namespace BoardGamePicker
{
    partial class PlayerProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerProfiles));
            pp_playerListBox = new ListBox();
            ppAddBtn = new Button();
            ppCreateBtn = new Button();
            ppViewBtn = new Button();
            ppDeleteBtn = new Button();
            ppCancelBtn = new Button();
            ppToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // pp_playerListBox
            // 
            pp_playerListBox.FormattingEnabled = true;
            pp_playerListBox.ItemHeight = 15;
            pp_playerListBox.Items.AddRange(new object[] { "gfh", "gfh", "hgf", "fgh", "fghgdfh", "gfdh", "htr", "rthgfh", "fgghf" });
            pp_playerListBox.Location = new Point(12, 12);
            pp_playerListBox.Name = "pp_playerListBox";
            pp_playerListBox.Size = new Size(215, 529);
            pp_playerListBox.TabIndex = 0;
            pp_playerListBox.SelectedIndexChanged += pp_playerListBox_SelectedIndexChanged;
            // 
            // ppAddBtn
            // 
            ppAddBtn.Location = new Point(233, 12);
            ppAddBtn.Name = "ppAddBtn";
            ppAddBtn.Size = new Size(75, 23);
            ppAddBtn.TabIndex = 1;
            ppAddBtn.Text = "Add";
            ppToolTip.SetToolTip(ppAddBtn, "Add selected player to play list");
            ppAddBtn.UseVisualStyleBackColor = true;
            ppAddBtn.Click += ppAddBtn_Click;
            // 
            // ppCreateBtn
            // 
            ppCreateBtn.Location = new Point(233, 41);
            ppCreateBtn.Name = "ppCreateBtn";
            ppCreateBtn.Size = new Size(75, 23);
            ppCreateBtn.TabIndex = 2;
            ppCreateBtn.Text = "Create";
            ppToolTip.SetToolTip(ppCreateBtn, "Create a new Profile");
            ppCreateBtn.UseVisualStyleBackColor = true;
            ppCreateBtn.Click += ppCreateBtn_Click;
            // 
            // ppViewBtn
            // 
            ppViewBtn.Location = new Point(233, 70);
            ppViewBtn.Name = "ppViewBtn";
            ppViewBtn.Size = new Size(75, 23);
            ppViewBtn.TabIndex = 3;
            ppViewBtn.Text = "View";
            ppToolTip.SetToolTip(ppViewBtn, "View selected player's profile");
            ppViewBtn.UseVisualStyleBackColor = true;
            ppViewBtn.Click += ppViewBtn_Click;
            // 
            // ppDeleteBtn
            // 
            ppDeleteBtn.Location = new Point(233, 99);
            ppDeleteBtn.Name = "ppDeleteBtn";
            ppDeleteBtn.Size = new Size(75, 23);
            ppDeleteBtn.TabIndex = 4;
            ppDeleteBtn.Text = "Delete";
            ppToolTip.SetToolTip(ppDeleteBtn, "Delete selected player's profile");
            ppDeleteBtn.UseVisualStyleBackColor = true;
            ppDeleteBtn.Click += ppDeleteBtn_Click;
            // 
            // ppCancelBtn
            // 
            ppCancelBtn.Location = new Point(233, 128);
            ppCancelBtn.Name = "ppCancelBtn";
            ppCancelBtn.Size = new Size(75, 23);
            ppCancelBtn.TabIndex = 5;
            ppCancelBtn.Text = "Cancel";
            ppCancelBtn.UseVisualStyleBackColor = true;
            ppCancelBtn.Click += ppCancelBtn_Click;
            // 
            // PlayerProfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 559);
            Controls.Add(ppCancelBtn);
            Controls.Add(ppDeleteBtn);
            Controls.Add(ppViewBtn);
            Controls.Add(ppCreateBtn);
            Controls.Add(ppAddBtn);
            Controls.Add(pp_playerListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlayerProfiles";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Player Profiles";
            ResumeLayout(false);
        }

        #endregion

        private ListBox pp_playerListBox;
        private Button ppAddBtn;
        private Button ppCreateBtn;
        private Button ppViewBtn;
        private Button ppDeleteBtn;
        private Button ppCancelBtn;
        private ToolTip ppToolTip;
    }
}