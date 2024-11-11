namespace bgpicker2
{
    partial class ImportCollectionPrompt
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
            icpImportBtn = new Button();
            label = new Label();
            icpImportLink = new TextBox();
            icpCancelBtn = new Button();
            SuspendLayout();
            // 
            // icpImportBtn
            // 
            icpImportBtn.Location = new Point(141, 5);
            icpImportBtn.Name = "icpImportBtn";
            icpImportBtn.Size = new Size(75, 23);
            icpImportBtn.TabIndex = 0;
            icpImportBtn.Text = "Import";
            icpImportBtn.UseVisualStyleBackColor = true;
            icpImportBtn.Click += icpImportBtn_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(112, 15);
            label.TabIndex = 1;
            label.Text = "BGG Collection Link";
            // 
            // icpImportLink
            // 
            icpImportLink.Location = new Point(12, 33);
            icpImportLink.Name = "icpImportLink";
            icpImportLink.PlaceholderText = "Input Board Game Geek Account Collection here";
            icpImportLink.Size = new Size(285, 23);
            icpImportLink.TabIndex = 2;
            // 
            // icpCancelBtn
            // 
            icpCancelBtn.Location = new Point(222, 5);
            icpCancelBtn.Name = "icpCancelBtn";
            icpCancelBtn.Size = new Size(75, 23);
            icpCancelBtn.TabIndex = 3;
            icpCancelBtn.Text = "Cancel";
            icpCancelBtn.UseVisualStyleBackColor = true;
            icpCancelBtn.Click += icpCancelBtn_Click;
            // 
            // ImportCollectionPrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 67);
            Controls.Add(icpCancelBtn);
            Controls.Add(icpImportLink);
            Controls.Add(label);
            Controls.Add(icpImportBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImportCollectionPrompt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ImportCollectionPrompt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button icpImportBtn;
        private Label label;
        private TextBox icpImportLink;
        private Button icpCancelBtn;
    }
}