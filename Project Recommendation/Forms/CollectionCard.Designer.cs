namespace design
{
    partial class CollectionCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionCard));
            MyListsButton = new Button();
            BlackListButton = new Button();
            FavButton = new Button();
            ProfileButton = new Button();
            Picture7 = new PictureBox();
            EditButton = new Button();
            SaveButton = new Button();
            Name = new Label();
            NameText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Picture7).BeginInit();
            SuspendLayout();
            // 
            // MyListsButton
            // 
            resources.ApplyResources(MyListsButton, "MyListsButton");
            MyListsButton.Name = "MyListsButton";
            MyListsButton.UseVisualStyleBackColor = true;
            // 
            // BlackListButton
            // 
            resources.ApplyResources(BlackListButton, "BlackListButton");
            BlackListButton.Name = "BlackListButton";
            BlackListButton.UseVisualStyleBackColor = true;
            // 
            // FavButton
            // 
            resources.ApplyResources(FavButton, "FavButton");
            FavButton.Name = "FavButton";
            FavButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            resources.ApplyResources(ProfileButton, "ProfileButton");
            ProfileButton.Name = "ProfileButton";
            ProfileButton.UseVisualStyleBackColor = true;
            // 
            // Picture7
            // 
            resources.ApplyResources(Picture7, "Picture7");
            Picture7.Name = "Picture7";
            Picture7.TabStop = false;
            // 
            // EditButton
            // 
            resources.ApplyResources(EditButton, "EditButton");
            EditButton.BackColor = Color.FloralWhite;
            EditButton.ForeColor = Color.DimGray;
            EditButton.Name = "EditButton";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            resources.ApplyResources(SaveButton, "SaveButton");
            SaveButton.BackColor = Color.FloralWhite;
            SaveButton.ForeColor = Color.DimGray;
            SaveButton.Name = "SaveButton";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // Name
            // 
            resources.ApplyResources(Name, "Name");
            Name.BackColor = Color.Transparent;
            Name.ForeColor = SystemColors.ButtonHighlight;
            Name.Name = "Name";
            // 
            // NameText
            // 
            resources.ApplyResources(NameText, "NameText");
            NameText.BackColor = Color.FloralWhite;
            NameText.BorderStyle = BorderStyle.None;
            NameText.ForeColor = Color.DimGray;
            NameText.Name = "NameText";
            // 
            // CollectionCard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NameText);
            Controls.Add(Name);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(MyListsButton);
            Controls.Add(BlackListButton);
            Controls.Add(FavButton);
            Controls.Add(ProfileButton);
            Controls.Add(Picture7);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            NameText.Name = "CollectionCard";
            ((System.ComponentModel.ISupportInitialize)Picture7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button MyListsButton;
        private System.Windows.Forms.Button BlackListButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        new private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameText;
    }
}