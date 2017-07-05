using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 3/5/2012
 * Assignment: Final
 * Resources: http://forum.junowebdesign.com/net-programming/29928-how-create-splash-screen-c.html
 * ***********************************/

namespace ASSN10_EKF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }//end public Form2()

        private void XSplashScreenTimer_Tick(object sender, EventArgs e)
        {
            XSplashScreenProgressBar.Increment(1);
            if (XSplashScreenProgressBar.Value == 100)
            {
                XSplashScreenTimer.Stop();
            }//end if that stops the timer when progress bar reaches 100%
        }//end private void for timer_tick
    }//end public partial class Form2
}//end namespace
