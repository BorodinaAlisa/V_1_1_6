namespace design
{
    partial class RegistrationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            RegistrationButton = new Button();
            NameRegText = new TextBox();
            LoginRegText = new TextBox();
            PasswordRegText = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            NameLabel = new Label();
            EmailLabel = new Label();
            PasswordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // RegistrationButton
            // 
            resources.ApplyResources(RegistrationButton, "RegistrationButton");
            RegistrationButton.BackColor = Color.FloralWhite;
            RegistrationButton.ForeColor = Color.DimGray;
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // NameRegText
            // 
            resources.ApplyResources(NameRegText, "NameRegText");
            NameRegText.BackColor = Color.FloralWhite;
            NameRegText.ForeColor = Color.DimGray;
            NameRegText.Name = "NameRegText";
            // 
            // LoginRegText
            // 
            resources.ApplyResources(LoginRegText, "LoginRegText");
            LoginRegText.BackColor = Color.FloralWhite;
            LoginRegText.ForeColor = Color.DimGray;
            LoginRegText.Name = "LoginRegText";
            // 
            // PasswordRegText
            // 
            resources.ApplyResources(PasswordRegText, "PasswordRegText");
            PasswordRegText.BackColor = Color.FloralWhite;
            PasswordRegText.ForeColor = Color.DimGray;
            PasswordRegText.Name = "PasswordRegText";
            PasswordRegText.KeyPress += PasswordRegText_KeyPress;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // NameLabel
            // 
            resources.ApplyResources(NameLabel, "NameLabel");
            NameLabel.BackColor = Color.Transparent;
            NameLabel.ForeColor = SystemColors.ButtonHighlight;
            NameLabel.Name = "NameLabel";
            // 
            // EmailLabel
            // 
            resources.ApplyResources(EmailLabel, "EmailLabel");
            EmailLabel.BackColor = Color.Transparent;
            EmailLabel.ForeColor = SystemColors.ButtonHighlight;
            EmailLabel.Name = "EmailLabel";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(PasswordLabel, "PasswordLabel");
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.ForeColor = SystemColors.ButtonHighlight;
            PasswordLabel.Name = "PasswordLabel";
            // 
            // RegistrationWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(label1);
            Controls.Add(PasswordRegText);
            Controls.Add(LoginRegText);
            Controls.Add(NameRegText);
            Controls.Add(RegistrationButton);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "RegistrationWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox NameRegText;
        private System.Windows.Forms.TextBox LoginRegText;
        private System.Windows.Forms.TextBox PasswordRegText;
        private Label label1;
        private PictureBox pictureBox2;
        private Label NameLabel;
        private Label EmailLabel;
        private Label PasswordLabel;
    }
}