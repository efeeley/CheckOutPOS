namespace ASSN10_EKF
{
    partial class XMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMainForm));
            this.XComputerBuilderLabel = new System.Windows.Forms.Label();
            this.XMotherBoardLabel = new System.Windows.Forms.Label();
            this.XProccessorLabel = new System.Windows.Forms.Label();
            this.XGraphicsCardLabel = new System.Windows.Forms.Label();
            this.XHardDriveLabel = new System.Windows.Forms.Label();
            this.XRamLabel = new System.Windows.Forms.Label();
            this.XMotherboardComboBox = new System.Windows.Forms.ComboBox();
            this.XProccessorComboBox = new System.Windows.Forms.ComboBox();
            this.XHardDriveComboBox = new System.Windows.Forms.ComboBox();
            this.XGraphicsCardComboBox = new System.Windows.Forms.ComboBox();
            this.XRamComboBox = new System.Windows.Forms.ComboBox();
            this.XCheckButton = new System.Windows.Forms.Button();
            this.XClearButton = new System.Windows.Forms.Button();
            this.XCheckOutButton = new System.Windows.Forms.Button();
            this.XLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.XLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // XComputerBuilderLabel
            // 
            this.XComputerBuilderLabel.AutoSize = true;
            this.XComputerBuilderLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XComputerBuilderLabel.Location = new System.Drawing.Point(57, 13);
            this.XComputerBuilderLabel.Name = "XComputerBuilderLabel";
            this.XComputerBuilderLabel.Size = new System.Drawing.Size(170, 24);
            this.XComputerBuilderLabel.TabIndex = 0;
            this.XComputerBuilderLabel.Text = "Computer Builder";
            this.XComputerBuilderLabel.Click += new System.EventHandler(this.XComputerBuilderLabel_Click);
            // 
            // XMotherBoardLabel
            // 
            this.XMotherBoardLabel.AutoSize = true;
            this.XMotherBoardLabel.Location = new System.Drawing.Point(16, 53);
            this.XMotherBoardLabel.Name = "XMotherBoardLabel";
            this.XMotherBoardLabel.Size = new System.Drawing.Size(68, 13);
            this.XMotherBoardLabel.TabIndex = 1;
            this.XMotherBoardLabel.Text = "MotherBoard";
            // 
            // XProccessorLabel
            // 
            this.XProccessorLabel.AutoSize = true;
            this.XProccessorLabel.Location = new System.Drawing.Point(16, 88);
            this.XProccessorLabel.Name = "XProccessorLabel";
            this.XProccessorLabel.Size = new System.Drawing.Size(54, 13);
            this.XProccessorLabel.TabIndex = 2;
            this.XProccessorLabel.Text = "Processor";
            // 
            // XGraphicsCardLabel
            // 
            this.XGraphicsCardLabel.AutoSize = true;
            this.XGraphicsCardLabel.Location = new System.Drawing.Point(16, 158);
            this.XGraphicsCardLabel.Name = "XGraphicsCardLabel";
            this.XGraphicsCardLabel.Size = new System.Drawing.Size(74, 13);
            this.XGraphicsCardLabel.TabIndex = 3;
            this.XGraphicsCardLabel.Text = "Graphics Card";
            // 
            // XHardDriveLabel
            // 
            this.XHardDriveLabel.AutoSize = true;
            this.XHardDriveLabel.Location = new System.Drawing.Point(16, 123);
            this.XHardDriveLabel.Name = "XHardDriveLabel";
            this.XHardDriveLabel.Size = new System.Drawing.Size(58, 13);
            this.XHardDriveLabel.TabIndex = 4;
            this.XHardDriveLabel.Text = "Hard Drive";
            // 
            // XRamLabel
            // 
            this.XRamLabel.AutoSize = true;
            this.XRamLabel.Location = new System.Drawing.Point(16, 193);
            this.XRamLabel.Name = "XRamLabel";
            this.XRamLabel.Size = new System.Drawing.Size(31, 13);
            this.XRamLabel.TabIndex = 5;
            this.XRamLabel.Text = "RAM";
            // 
            // XMotherboardComboBox
            // 
            this.XMotherboardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XMotherboardComboBox.FormattingEnabled = true;
            this.XMotherboardComboBox.Items.AddRange(new object[] {
            "ASUS M5A99X EVO",
            "ASRock 970 EXTREME4",
            "GIGABYTE GA-Z68XP-UD3",
            "MSI P67A-G45 (B3) LGA"});
            this.XMotherboardComboBox.Location = new System.Drawing.Point(120, 53);
            this.XMotherboardComboBox.Name = "XMotherboardComboBox";
            this.XMotherboardComboBox.Size = new System.Drawing.Size(149, 21);
            this.XMotherboardComboBox.TabIndex = 6;
            // 
            // XProccessorComboBox
            // 
            this.XProccessorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XProccessorComboBox.FormattingEnabled = true;
            this.XProccessorComboBox.Items.AddRange(new object[] {
            "AMD FX-8120 Zambezi 3.1GHz",
            "Intel Core i7-2600K 3.4GHz",
            "AMD A8-3870K Unlocked Llano 3.0GHz",
            "Intel Core i5-2500K 3.3GHz"});
            this.XProccessorComboBox.Location = new System.Drawing.Point(120, 86);
            this.XProccessorComboBox.Name = "XProccessorComboBox";
            this.XProccessorComboBox.Size = new System.Drawing.Size(149, 21);
            this.XProccessorComboBox.TabIndex = 7;
            // 
            // XHardDriveComboBox
            // 
            this.XHardDriveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XHardDriveComboBox.FormattingEnabled = true;
            this.XHardDriveComboBox.Items.AddRange(new object[] {
            "Seagate Barracuda 1TB",
            "Western Digital Caviar Black 1TB",
            "Seagate Barracuda Green 2TB",
            "Western Digital Caviar Blue 500GB"});
            this.XHardDriveComboBox.Location = new System.Drawing.Point(120, 119);
            this.XHardDriveComboBox.Name = "XHardDriveComboBox";
            this.XHardDriveComboBox.Size = new System.Drawing.Size(149, 21);
            this.XHardDriveComboBox.TabIndex = 8;
            // 
            // XGraphicsCardComboBox
            // 
            this.XGraphicsCardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XGraphicsCardComboBox.FormattingEnabled = true;
            this.XGraphicsCardComboBox.Items.AddRange(new object[] {
            "EVGA 01G-P3-1556-KR GeForce GTX",
            "EVGA 01G-P3-1561-AR GeForce",
            "SAPPHIRE 100314-3L Radeon HD",
            "SAPPHIRE 100315L Radeon HD"});
            this.XGraphicsCardComboBox.Location = new System.Drawing.Point(120, 152);
            this.XGraphicsCardComboBox.Name = "XGraphicsCardComboBox";
            this.XGraphicsCardComboBox.Size = new System.Drawing.Size(149, 21);
            this.XGraphicsCardComboBox.TabIndex = 9;
            // 
            // XRamComboBox
            // 
            this.XRamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XRamComboBox.FormattingEnabled = true;
            this.XRamComboBox.Items.AddRange(new object[] {
            "CORSAIR Vengeance 16GB (4 x 4GB)",
            "G.SKILL Ripjaws X Series 8GB (2 x 4GB)",
            "G.SKILL Ripjaws Series 16GB (4 x 4GB)",
            "G.SKILL Sniper Series 8GB (2 x 4GB)"});
            this.XRamComboBox.Location = new System.Drawing.Point(120, 185);
            this.XRamComboBox.Name = "XRamComboBox";
            this.XRamComboBox.Size = new System.Drawing.Size(149, 21);
            this.XRamComboBox.TabIndex = 10;
            // 
            // XCheckButton
            // 
            this.XCheckButton.Image = ((System.Drawing.Image)(resources.GetObject("XCheckButton.Image")));
            this.XCheckButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XCheckButton.Location = new System.Drawing.Point(12, 220);
            this.XCheckButton.Name = "XCheckButton";
            this.XCheckButton.Size = new System.Drawing.Size(75, 41);
            this.XCheckButton.TabIndex = 11;
            this.XCheckButton.Text = "Check";
            this.XCheckButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XCheckButton.UseVisualStyleBackColor = true;
            this.XCheckButton.Click += new System.EventHandler(this.XCheckButton_Click);
            // 
            // XClearButton
            // 
            this.XClearButton.Image = ((System.Drawing.Image)(resources.GetObject("XClearButton.Image")));
            this.XClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XClearButton.Location = new System.Drawing.Point(103, 220);
            this.XClearButton.Name = "XClearButton";
            this.XClearButton.Size = new System.Drawing.Size(75, 41);
            this.XClearButton.TabIndex = 12;
            this.XClearButton.Text = "Clear";
            this.XClearButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XClearButton.UseVisualStyleBackColor = true;
            this.XClearButton.Click += new System.EventHandler(this.XClearButton_Click);
            // 
            // XCheckOutButton
            // 
            this.XCheckOutButton.Image = ((System.Drawing.Image)(resources.GetObject("XCheckOutButton.Image")));
            this.XCheckOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XCheckOutButton.Location = new System.Drawing.Point(194, 220);
            this.XCheckOutButton.Name = "XCheckOutButton";
            this.XCheckOutButton.Size = new System.Drawing.Size(75, 41);
            this.XCheckOutButton.TabIndex = 13;
            this.XCheckOutButton.Text = "Check Out";
            this.XCheckOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XCheckOutButton.UseVisualStyleBackColor = true;
            this.XCheckOutButton.Click += new System.EventHandler(this.XCheckOutButton_Click);
            // 
            // XLogoPictureBox
            // 
            this.XLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("XLogoPictureBox.Image")));
            this.XLogoPictureBox.ImageLocation = "";
            this.XLogoPictureBox.Location = new System.Drawing.Point(8, 0);
            this.XLogoPictureBox.Name = "XLogoPictureBox";
            this.XLogoPictureBox.Size = new System.Drawing.Size(39, 37);
            this.XLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.XLogoPictureBox.TabIndex = 14;
            this.XLogoPictureBox.TabStop = false;
            this.XLogoPictureBox.Click += new System.EventHandler(this.XLogoPictureBox_Click);
            // 
            // XMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.XLogoPictureBox);
            this.Controls.Add(this.XCheckOutButton);
            this.Controls.Add(this.XClearButton);
            this.Controls.Add(this.XCheckButton);
            this.Controls.Add(this.XRamComboBox);
            this.Controls.Add(this.XGraphicsCardComboBox);
            this.Controls.Add(this.XHardDriveComboBox);
            this.Controls.Add(this.XProccessorComboBox);
            this.Controls.Add(this.XMotherboardComboBox);
            this.Controls.Add(this.XRamLabel);
            this.Controls.Add(this.XHardDriveLabel);
            this.Controls.Add(this.XGraphicsCardLabel);
            this.Controls.Add(this.XProccessorLabel);
            this.Controls.Add(this.XMotherBoardLabel);
            this.Controls.Add(this.XComputerBuilderLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Builder";
            ((System.ComponentModel.ISupportInitialize)(this.XLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XComputerBuilderLabel;
        private System.Windows.Forms.Label XMotherBoardLabel;
        private System.Windows.Forms.Label XProccessorLabel;
        private System.Windows.Forms.Label XGraphicsCardLabel;
        private System.Windows.Forms.Label XHardDriveLabel;
        private System.Windows.Forms.Label XRamLabel;
        private System.Windows.Forms.ComboBox XMotherboardComboBox;
        private System.Windows.Forms.ComboBox XProccessorComboBox;
        private System.Windows.Forms.ComboBox XHardDriveComboBox;
        private System.Windows.Forms.ComboBox XGraphicsCardComboBox;
        private System.Windows.Forms.ComboBox XRamComboBox;
        private System.Windows.Forms.Button XCheckButton;
        private System.Windows.Forms.Button XClearButton;
        private System.Windows.Forms.Button XCheckOutButton;
        private System.Windows.Forms.PictureBox XLogoPictureBox;
    }
}

