namespace design
{
    partial class AddList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddList));
            Picture4 = new PictureBox();
            Text1 = new Label();
            AddFavButton = new RadioButton();
            ChooseButton = new RadioButton();
            CollectionsCombo = new ComboBox();
            CreateCollectionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture4).BeginInit();
            SuspendLayout();
            // 
            // Picture4
            // 
            resources.ApplyResources(Picture4, "Picture4");
            Picture4.Name = "Picture4";
            Picture4.TabStop = false;
            // 
            // Text1
            // 
            resources.ApplyResources(Text1, "Text1");
            Text1.BackColor = Color.Transparent;
            Text1.ForeColor = SystemColors.ButtonHighlight;
            Text1.Name = "Text1";
            // 
            // AddFavButton
            // 
            resources.ApplyResources(AddFavButton, "AddFavButton");
            AddFavButton.ForeColor = SystemColors.ButtonHighlight;
            AddFavButton.Name = "AddFavButton";
            AddFavButton.TabStop = true;
            AddFavButton.UseVisualStyleBackColor = true;
            // 
            // ChooseButton
            // 
            resources.ApplyResources(ChooseButton, "ChooseButton");
            ChooseButton.ForeColor = SystemColors.ButtonHighlight;
            ChooseButton.Name = "ChooseButton";
            ChooseButton.TabStop = true;
            ChooseButton.UseVisualStyleBackColor = true;
            // 
            // CollectionsCombo
            // 
            resources.ApplyResources(CollectionsCombo, "CollectionsCombo");
            CollectionsCombo.ForeColor = Color.DimGray;
            CollectionsCombo.FormattingEnabled = true;
            CollectionsCombo.Name = "CollectionsCombo";
            // 
            // CreateCollectionButton
            // 
            resources.ApplyResources(CreateCollectionButton, "CreateCollectionButton");
            CreateCollectionButton.BackColor = Color.FloralWhite;
            CreateCollectionButton.ForeColor = Color.DimGray;
            CreateCollectionButton.Name = "CreateCollectionButton";
            CreateCollectionButton.UseVisualStyleBackColor = false;
            CreateCollectionButton.Click += CreateCollectionButton_Click;
            // 
            // AddList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(CreateCollectionButton);
            Controls.Add(CollectionsCombo);
            Controls.Add(ChooseButton);
            Controls.Add(AddFavButton);
            Controls.Add(Text1);
            Controls.Add(Picture4);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddList";
            ((System.ComponentModel.ISupportInitialize)Picture4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture4;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.RadioButton AddFavButton;
        private System.Windows.Forms.RadioButton ChooseButton;
        private System.Windows.Forms.ComboBox CollectionsCombo;
        private System.Windows.Forms.Button CreateCollectionButton;
    }
}