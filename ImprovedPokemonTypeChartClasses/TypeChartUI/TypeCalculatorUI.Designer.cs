namespace TypeChartUI
{
    partial class TypeCalculatorUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeCalculatorUI));
            SecondaryTypesComboBox = new ComboBox();
            PrimaryTypesComboBox = new ComboBox();
            CalculateButton = new Button();
            StrengthsAndWeaknessesRichTextBox = new RichTextBox();
            ResetButton = new Button();
            pictureBoxBackgroundGif = new PictureBox();
            pictureBox1 = new PictureBox();
            lblSecondaryType = new Label();
            lblPrimaryType = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SecondaryTypesComboBox
            // 
            SecondaryTypesComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            SecondaryTypesComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SecondaryTypesComboBox.BackColor = Color.DarkSlateBlue;
            SecondaryTypesComboBox.DropDownHeight = 150;
            SecondaryTypesComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SecondaryTypesComboBox.ForeColor = Color.WhiteSmoke;
            SecondaryTypesComboBox.FormattingEnabled = true;
            SecondaryTypesComboBox.IntegralHeight = false;
            SecondaryTypesComboBox.Location = new Point(591, 76);
            SecondaryTypesComboBox.Margin = new Padding(4, 3, 4, 3);
            SecondaryTypesComboBox.Name = "SecondaryTypesComboBox";
            SecondaryTypesComboBox.Size = new Size(254, 38);
            SecondaryTypesComboBox.TabIndex = 7;
            SecondaryTypesComboBox.Text = "Select Secondary Type:";
            // 
            // PrimaryTypesComboBox
            // 
            PrimaryTypesComboBox.BackColor = Color.DarkSlateBlue;
            PrimaryTypesComboBox.DropDownHeight = 150;
            PrimaryTypesComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PrimaryTypesComboBox.ForeColor = Color.WhiteSmoke;
            PrimaryTypesComboBox.FormattingEnabled = true;
            PrimaryTypesComboBox.IntegralHeight = false;
            PrimaryTypesComboBox.ItemHeight = 30;
            PrimaryTypesComboBox.Location = new Point(302, 76);
            PrimaryTypesComboBox.Margin = new Padding(4, 3, 4, 3);
            PrimaryTypesComboBox.Name = "PrimaryTypesComboBox";
            PrimaryTypesComboBox.Size = new Size(254, 38);
            PrimaryTypesComboBox.TabIndex = 6;
            PrimaryTypesComboBox.Text = "Select Primary Type:";
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.Teal;
            CalculateButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(450, 148);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(205, 47);
            CalculateButton.TabIndex = 10;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // StrengthsAndWeaknessesRichTextBox
            // 
            StrengthsAndWeaknessesRichTextBox.BackColor = Color.WhiteSmoke;
            StrengthsAndWeaknessesRichTextBox.Location = new Point(12, 305);
            StrengthsAndWeaknessesRichTextBox.Name = "StrengthsAndWeaknessesRichTextBox";
            StrengthsAndWeaknessesRichTextBox.Size = new Size(1117, 311);
            StrengthsAndWeaknessesRichTextBox.TabIndex = 11;
            StrengthsAndWeaknessesRichTextBox.Text = "";
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.IndianRed;
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(504, 221);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(101, 36);
            ResetButton.TabIndex = 12;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // pictureBoxBackgroundGif
            // 
            pictureBoxBackgroundGif.BackColor = Color.WhiteSmoke;
            pictureBoxBackgroundGif.Image = (Image)resources.GetObject("pictureBoxBackgroundGif.Image");
            pictureBoxBackgroundGif.Location = new Point(-52, -1);
            pictureBoxBackgroundGif.Name = "pictureBoxBackgroundGif";
            pictureBoxBackgroundGif.Size = new Size(400, 300);
            pictureBoxBackgroundGif.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxBackgroundGif.TabIndex = 13;
            pictureBoxBackgroundGif.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(760, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblSecondaryType
            // 
            lblSecondaryType.AutoSize = true;
            lblSecondaryType.BackColor = Color.Transparent;
            lblSecondaryType.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondaryType.ForeColor = Color.DarkSlateBlue;
            lblSecondaryType.Location = new Point(591, 41);
            lblSecondaryType.Margin = new Padding(4, 0, 4, 0);
            lblSecondaryType.Name = "lblSecondaryType";
            lblSecondaryType.Size = new Size(276, 32);
            lblSecondaryType.TabIndex = 9;
            lblSecondaryType.Text = "Enter Secondary Type: ";
            // 
            // lblPrimaryType
            // 
            lblPrimaryType.AutoSize = true;
            lblPrimaryType.BackColor = Color.Transparent;
            lblPrimaryType.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimaryType.ForeColor = Color.DarkSlateBlue;
            lblPrimaryType.Location = new Point(302, 41);
            lblPrimaryType.Margin = new Padding(4, 0, 4, 0);
            lblPrimaryType.Name = "lblPrimaryType";
            lblPrimaryType.Size = new Size(240, 32);
            lblPrimaryType.TabIndex = 8;
            lblPrimaryType.Text = "Enter Primary Type:";
            // 
            // TypeCalculatorUI
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 100, 240);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1141, 628);
            Controls.Add(lblPrimaryType);
            Controls.Add(ResetButton);
            Controls.Add(StrengthsAndWeaknessesRichTextBox);
            Controls.Add(CalculateButton);
            Controls.Add(lblSecondaryType);
            Controls.Add(SecondaryTypesComboBox);
            Controls.Add(PrimaryTypesComboBox);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxBackgroundGif);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(47, 54, 64);
            Margin = new Padding(4);
            Name = "TypeCalculatorUI";
            Text = "Pokemon Type Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox SecondaryTypesComboBox;
        private ComboBox PrimaryTypesComboBox;
        private Button CalculateButton;
        private RichTextBox StrengthsAndWeaknessesRichTextBox;
        private Button ResetButton;
        private PictureBox pictureBoxBackgroundGif;
        private PictureBox pictureBox1;
        private Label lblSecondaryType;
        private Label lblPrimaryType;
    }
}