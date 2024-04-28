namespace design
{
    partial class OpenWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenWindow));
            pictureBox1 = new PictureBox();
            LoginTextAutho = new TextBox();
            PasswordTextAutho = new TextBox();
            RegistrationButton = new Button();
            LogInButton = new Button();
            label1 = new Label();
            label2 = new Label();
            LanguageComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // LoginTextAutho
            // 
            resources.ApplyResources(LoginTextAutho, "LoginTextAutho");
            LoginTextAutho.BackColor = Color.FloralWhite;
            LoginTextAutho.ForeColor = Color.DimGray;
            LoginTextAutho.Name = "LoginTextAutho";
            LoginTextAutho.Click += LoginText_Click;
            LoginTextAutho.KeyPress += LoginTextAutho_KeyPress;
            // 
            // PasswordTextAutho
            // 
            resources.ApplyResources(PasswordTextAutho, "PasswordTextAutho");
            PasswordTextAutho.BackColor = Color.FloralWhite;
            PasswordTextAutho.ForeColor = Color.DimGray;
            PasswordTextAutho.Name = "PasswordTextAutho";
            PasswordTextAutho.Click += PasswordText_Click;
            PasswordTextAutho.KeyPress += PasswordTextAutho_KeyPress;
            PasswordTextAutho.MouseEnter += PasswordTextAutho_Enter;
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
            // LogInButton
            // 
            resources.ApplyResources(LogInButton, "LogInButton");
            LogInButton.BackColor = Color.FloralWhite;
            LogInButton.ForeColor = Color.DimGray;
            LogInButton.Name = "LogInButton";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Transparent;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // LanguageComboBox
            // 
            resources.ApplyResources(LanguageComboBox, "LanguageComboBox");
            LanguageComboBox.ForeColor = Color.DimGray;
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Items.AddRange(new object[] { resources.GetString("LanguageComboBox.Items"), resources.GetString("LanguageComboBox.Items1") });
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.SelectedIndexChanged += LanguageComboBox_SelectedIndexChanged;
            // 
            // OpenWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LanguageComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegistrationButton);
            Controls.Add(LogInButton);
            Controls.Add(PasswordTextAutho);
            Controls.Add(LoginTextAutho);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "OpenWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginTextAutho;
        private System.Windows.Forms.TextBox PasswordTextAutho;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComboBox LanguageComboBox;
    }
}

