namespace BoardGamePicker
{
    partial class CreateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfile));
            nameLabel = new Label();
            cpInputNameBox = new TextBox();
            cpSaveBtn = new Button();
            cpCancelBtn = new Button();
            cpToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(22, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            cpToolTip.SetToolTip(nameLabel, "Enter a Name");
            // 
            // cpInputNameBox
            // 
            cpInputNameBox.Location = new Point(70, 17);
            cpInputNameBox.Name = "cpInputNameBox";
            cpInputNameBox.PlaceholderText = "Enter a Name...";
            cpInputNameBox.Size = new Size(203, 23);
            cpInputNameBox.TabIndex = 1;
            cpInputNameBox.KeyDown += cpInputNameBox_KeyDown;
            // 
            // cpSaveBtn
            // 
            cpSaveBtn.Location = new Point(70, 46);
            cpSaveBtn.Name = "cpSaveBtn";
            cpSaveBtn.Size = new Size(75, 23);
            cpSaveBtn.TabIndex = 2;
            cpSaveBtn.Text = "Save";
            cpSaveBtn.UseVisualStyleBackColor = true;
            cpSaveBtn.Click += SaveNewPlayer;
            // 
            // cpCancelBtn
            // 
            cpCancelBtn.Location = new Point(198, 46);
            cpCancelBtn.Name = "cpCancelBtn";
            cpCancelBtn.Size = new Size(75, 23);
            cpCancelBtn.TabIndex = 3;
            cpCancelBtn.Text = "Cancel";
            cpCancelBtn.UseVisualStyleBackColor = true;
            cpCancelBtn.Click += cpCancelBtn_Click;
            // 
            // CreateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 74);
            Controls.Add(cpCancelBtn);
            Controls.Add(cpSaveBtn);
            Controls.Add(cpInputNameBox);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox cpInputNameBox;
        private Button cpSaveBtn;
        private Button cpCancelBtn;
        private ToolTip cpToolTip;
    }
}