namespace design
{
    partial class TestFirstWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFirstWindow));
            Picture7 = new PictureBox();
            label1 = new Label();
            Town = new Label();
            TypeOfRealty = new Label();
            Purpose = new Label();
            TownCombo = new ComboBox();
            RealtyCombo = new ComboBox();
            PurposeCombo = new ComboBox();
            NextButtonButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture7).BeginInit();
            SuspendLayout();
            // 
            // Picture7
            // 
            resources.ApplyResources(Picture7, "Picture7");
            Picture7.Name = "Picture7";
            Picture7.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // Town
            // 
            resources.ApplyResources(Town, "Town");
            Town.BackColor = Color.Transparent;
            Town.ForeColor = SystemColors.ButtonHighlight;
            Town.Name = "Town";
            // 
            // TypeOfRealty
            // 
            resources.ApplyResources(TypeOfRealty, "TypeOfRealty");
            TypeOfRealty.BackColor = Color.Transparent;
            TypeOfRealty.ForeColor = SystemColors.ButtonHighlight;
            TypeOfRealty.Name = "TypeOfRealty";
            // 
            // Purpose
            // 
            resources.ApplyResources(Purpose, "Purpose");
            Purpose.BackColor = Color.Transparent;
            Purpose.ForeColor = SystemColors.ButtonHighlight;
            Purpose.Name = "Purpose";
            // 
            // TownCombo
            // 
            resources.ApplyResources(TownCombo, "TownCombo");
            TownCombo.ForeColor = Color.DimGray;
            TownCombo.FormattingEnabled = true;
            TownCombo.Items.AddRange(new object[] { resources.GetString("TownCombo.Items"), resources.GetString("TownCombo.Items1") });
            TownCombo.Name = "TownCombo";
            // 
            // RealtyCombo
            // 
            resources.ApplyResources(RealtyCombo, "RealtyCombo");
            RealtyCombo.ForeColor = Color.DimGray;
            RealtyCombo.FormattingEnabled = true;
            RealtyCombo.Items.AddRange(new object[] { resources.GetString("RealtyCombo.Items"), resources.GetString("RealtyCombo.Items1"), resources.GetString("RealtyCombo.Items2") });
            RealtyCombo.Name = "RealtyCombo";
            // 
            // PurposeCombo
            // 
            resources.ApplyResources(PurposeCombo, "PurposeCombo");
            PurposeCombo.ForeColor = Color.DimGray;
            PurposeCombo.FormattingEnabled = true;
            PurposeCombo.Items.AddRange(new object[] { resources.GetString("PurposeCombo.Items"), resources.GetString("PurposeCombo.Items1"), resources.GetString("PurposeCombo.Items2") });
            PurposeCombo.Name = "PurposeCombo";
            // 
            // NextButtonButton
            // 
            resources.ApplyResources(NextButtonButton, "NextButtonButton");
            NextButtonButton.BackColor = Color.FloralWhite;
            NextButtonButton.ForeColor = Color.DimGray;
            NextButtonButton.Name = "NextButtonButton";
            NextButtonButton.UseVisualStyleBackColor = false;
            NextButtonButton.Click += NextButtonButton_Click;
            // 
            // TestFirstWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NextButtonButton);
            Controls.Add(PurposeCombo);
            Controls.Add(RealtyCombo);
            Controls.Add(TownCombo);
            Controls.Add(Purpose);
            Controls.Add(TypeOfRealty);
            Controls.Add(Town);
            Controls.Add(label1);
            Controls.Add(Picture7);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "TestFirstWindow";
            ((System.ComponentModel.ISupportInitialize)Picture7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.Label TypeOfRealty;
        private System.Windows.Forms.Label Purpose;
        private System.Windows.Forms.ComboBox TownCombo;
        private System.Windows.Forms.ComboBox RealtyCombo;
        private System.Windows.Forms.ComboBox PurposeCombo;
        private System.Windows.Forms.Button NextButtonButton;
    }
}