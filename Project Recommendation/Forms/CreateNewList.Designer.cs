namespace design
{
    partial class CreateNewList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewList));
            Picture5 = new PictureBox();
            Text1 = new Label();
            Text2 = new Label();
            CreateCollectionButton = new Button();
            CollectionNameText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Picture5).BeginInit();
            SuspendLayout();
            // 
            // Picture5
            // 
            resources.ApplyResources(Picture5, "Picture5");
            Picture5.Name = "Picture5";
            Picture5.TabStop = false;
            // 
            // Text1
            // 
            Text1.BackColor = Color.Transparent;
            resources.ApplyResources(Text1, "Text1");
            Text1.ForeColor = SystemColors.ButtonHighlight;
            Text1.Name = "Text1";
            // 
            // Text2
            // 
            Text2.BackColor = Color.Transparent;
            resources.ApplyResources(Text2, "Text2");
            Text2.ForeColor = SystemColors.ButtonHighlight;
            Text2.Name = "Text2";
            // 
            // CreateCollectionButton
            // 
            CreateCollectionButton.BackColor = Color.FloralWhite;
            resources.ApplyResources(CreateCollectionButton, "CreateCollectionButton");
            CreateCollectionButton.ForeColor = Color.DimGray;
            CreateCollectionButton.Name = "CreateCollectionButton";
            CreateCollectionButton.UseVisualStyleBackColor = false;
            // 
            // CollectionNameText
            // 
            resources.ApplyResources(CollectionNameText, "CollectionNameText");
            CollectionNameText.Name = "CollectionNameText";
            // 
            // CreateNewList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CollectionNameText);
            Controls.Add(CreateCollectionButton);
            Controls.Add(Text2);
            Controls.Add(Text1);
            Controls.Add(Picture5);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "CreateNewList";
            ((System.ComponentModel.ISupportInitialize)Picture5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture5;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Button CreateCollectionButton;
        private System.Windows.Forms.TextBox CollectionNameText;
    }
}