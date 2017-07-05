namespace ASSN10_EKF
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.XSplashScreenProgressBar = new System.Windows.Forms.ProgressBar();
            this.XSplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // XSplashScreenProgressBar
            // 
            this.XSplashScreenProgressBar.Location = new System.Drawing.Point(35, 246);
            this.XSplashScreenProgressBar.Name = "XSplashScreenProgressBar";
            this.XSplashScreenProgressBar.Size = new System.Drawing.Size(169, 23);
            this.XSplashScreenProgressBar.TabIndex = 0;
            // 
            // XSplashScreenTimer
            // 
            this.XSplashScreenTimer.Enabled = true;
            this.XSplashScreenTimer.Interval = 32;
            this.XSplashScreenTimer.Tick += new System.EventHandler(this.XSplashScreenTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 283);
            this.Controls.Add(this.XSplashScreenProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar XSplashScreenProgressBar;
        private System.Windows.Forms.Timer XSplashScreenTimer;

    }
}