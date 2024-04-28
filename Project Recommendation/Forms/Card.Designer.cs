namespace design
{
    partial class Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            Children = new Label();
            Animals = new Label();
            Address = new Label();
            label1 = new Label();
            AddressText = new Label();
            SquareText = new Label();
            PriceText = new Label();
            FloorText = new Label();
            SuspendLayout();
            // 
            // Children
            // 
            resources.ApplyResources(Children, "Children");
            Children.BackColor = Color.Transparent;
            Children.ForeColor = Color.DimGray;
            Children.Name = "Children";
            // 
            // Animals
            // 
            resources.ApplyResources(Animals, "Animals");
            Animals.BackColor = Color.Transparent;
            Animals.ForeColor = Color.DimGray;
            Animals.Name = "Animals";
            // 
            // Address
            // 
            resources.ApplyResources(Address, "Address");
            Address.BackColor = Color.Transparent;
            Address.ForeColor = Color.DimGray;
            Address.Name = "Address";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.DimGray;
            label1.Name = "label1";
            // 
            // AddressText
            // 
            resources.ApplyResources(AddressText, "AddressText");
            AddressText.BackColor = Color.Transparent;
            AddressText.ForeColor = Color.DimGray;
            AddressText.Name = "AddressText";
            // 
            // SquareText
            // 
            resources.ApplyResources(SquareText, "SquareText");
            SquareText.BackColor = Color.Transparent;
            SquareText.ForeColor = Color.DimGray;
            SquareText.Name = "SquareText";
            // 
            // PriceText
            // 
            resources.ApplyResources(PriceText, "PriceText");
            PriceText.BackColor = Color.Transparent;
            PriceText.ForeColor = Color.DimGray;
            PriceText.Name = "PriceText";
            // 
            // FloorText
            // 
            resources.ApplyResources(FloorText, "FloorText");
            FloorText.BackColor = Color.Transparent;
            FloorText.ForeColor = Color.DimGray;
            FloorText.Name = "FloorText";
            // 
            // Card
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            Controls.Add(FloorText);
            Controls.Add(PriceText);
            Controls.Add(SquareText);
            Controls.Add(AddressText);
            Controls.Add(label1);
            Controls.Add(Address);
            Controls.Add(Animals);
            Controls.Add(Children);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Card";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label Children;
        private System.Windows.Forms.Label Animals;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Label SquareText;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Label FloorText;
    }
}