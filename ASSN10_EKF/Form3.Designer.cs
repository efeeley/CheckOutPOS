namespace ASSN10_EKF
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.XReturnButton = new System.Windows.Forms.Button();
            this.XExitButton = new System.Windows.Forms.Button();
            this.XCheckOutTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // XReturnButton
            // 
            this.XReturnButton.Location = new System.Drawing.Point(318, 27);
            this.XReturnButton.Name = "XReturnButton";
            this.XReturnButton.Size = new System.Drawing.Size(75, 77);
            this.XReturnButton.TabIndex = 1;
            this.XReturnButton.Text = "Return to Make Changes";
            this.XReturnButton.UseVisualStyleBackColor = true;
            this.XReturnButton.Click += new System.EventHandler(this.XReturnButton_Click);
            // 
            // XExitButton
            // 
            this.XExitButton.Location = new System.Drawing.Point(318, 158);
            this.XExitButton.Name = "XExitButton";
            this.XExitButton.Size = new System.Drawing.Size(75, 77);
            this.XExitButton.TabIndex = 2;
            this.XExitButton.Text = "Save and Exit";
            this.XExitButton.UseVisualStyleBackColor = true;
            this.XExitButton.Click += new System.EventHandler(this.XExitButton_Click);
            // 
            // XCheckOutTextBox
            // 
            this.XCheckOutTextBox.Location = new System.Drawing.Point(13, 13);
            this.XCheckOutTextBox.Multiline = true;
            this.XCheckOutTextBox.Name = "XCheckOutTextBox";
            this.XCheckOutTextBox.ReadOnly = true;
            this.XCheckOutTextBox.Size = new System.Drawing.Size(299, 237);
            this.XCheckOutTextBox.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 262);
            this.ControlBox = false;
            this.Controls.Add(this.XCheckOutTextBox);
            this.Controls.Add(this.XExitButton);
            this.Controls.Add(this.XReturnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XReturnButton;
        private System.Windows.Forms.Button XExitButton;
        private System.Windows.Forms.TextBox XCheckOutTextBox;
    }
}