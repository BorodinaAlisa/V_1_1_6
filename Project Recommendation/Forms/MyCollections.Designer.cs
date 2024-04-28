namespace design
{
    partial class MyCollections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCollections));
            MyListsButton = new Button();
            BlackListButton = new Button();
            FavButton = new Button();
            ProfileButton = new Button();
            Picture7 = new PictureBox();
            AddCollectionButton = new Button();
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
            // AddCollectionButton
            // 
            resources.ApplyResources(AddCollectionButton, "AddCollectionButton");
            AddCollectionButton.BackColor = Color.FloralWhite;
            AddCollectionButton.ForeColor = Color.DimGray;
            AddCollectionButton.Name = "AddCollectionButton";
            AddCollectionButton.UseVisualStyleBackColor = false;
            AddCollectionButton.Click += AddCollectionButton_Click;
            // 
            // MyCollections
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddCollectionButton);
            Controls.Add(MyListsButton);
            Controls.Add(BlackListButton);
            Controls.Add(FavButton);
            Controls.Add(ProfileButton);
            Controls.Add(Picture7);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MyCollections";
            ((System.ComponentModel.ISupportInitialize)Picture7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button MyListsButton;
        private System.Windows.Forms.Button BlackListButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Button AddCollectionButton;
    }
}