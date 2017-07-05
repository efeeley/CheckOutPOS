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
 *            All computer parts and prices found on Newegg.com
 *            Donald Assited with calculation bug and fixing the drop down style on the combo boxes
 * ***********************************/

namespace ASSN10_EKF
{
    public partial class XMainForm : Form
    {
        //declairing all of the variables for the entire form
        double motherboard, processor, harddrive, graphicscard, ram, total, subtotal, tax;

        public XMainForm()
        {
            InitializeComponent();

            Thread t1 = new Thread(new ThreadStart(SplashForm));
            t1.Start();
            Thread.Sleep(5000);
            t1.Abort();
            Thread.Sleep(1000);
        }//end public

        private void SplashForm()
        {
            Form2 SplashForm = new Form2();
            SplashForm.ShowDialog();
            SplashForm.Dispose();
        }//end private void SplashForm

        //This is the Check button, it will check to make sure that the user selected one of the options in the box
        //Since all the parts I will pick are already compatible with one another the button wont serve much other purpose.
        private void XCheckButton_Click(object sender, EventArgs e)
        {
            if (XMotherboardComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XMotherboardComboBox.Focus(); 
            }//end motherboard check

            else if (XProccessorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XProccessorComboBox.Focus();
            }//end processor check

            else if (XHardDriveComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XHardDriveComboBox.Focus();
            }//end hard drive check

            else if (XGraphicsCardComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XGraphicsCardComboBox.Focus();
            }//end graphics card check

            else if (XRamComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XRamComboBox.Focus();
            }//end ram check

            else if (XMotherboardComboBox.SelectedItem != null && XProccessorComboBox.SelectedItem != null &&
                XHardDriveComboBox.SelectedItem != null && XGraphicsCardComboBox.SelectedItem != null && XRamComboBox.SelectedItem != null)
            {
                MessageBox.Show("Everything is Okay", "Results", MessageBoxButtons.OK);
            }//end everything is okay if

        }//end private void XCheckButton_Click

        //This button is the Clear button, it will reset all of the user choices back to the original state.
        //This is so that the user has the option to completely start over without exiting the program.
        private void XClearButton_Click(object sender, EventArgs e)
        {
            XMotherboardComboBox.Text = null;
            XProccessorComboBox.Text = null;
            XHardDriveComboBox.Text = null;
            XGraphicsCardComboBox.Text = null;
            XRamComboBox.Text = null;
        }//end private void XClearButton_Click

        //This procceeds to a check out form which will give the user their total.
        private void XCheckOutButton_Click(object sender, EventArgs e)
        {
            if (XMotherboardComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XMotherboardComboBox.Focus();
            }//end motherboard check

            else if (XProccessorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XProccessorComboBox.Focus();
            }//end processor check

            else if (XHardDriveComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XHardDriveComboBox.Focus();
            }//end hard drive check

            else if (XGraphicsCardComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XGraphicsCardComboBox.Focus();
            }//end graphics card check

            else if (XRamComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.XRamComboBox.Focus();
            }//end ram check

            else if (XMotherboardComboBox.SelectedItem != null && XProccessorComboBox.SelectedItem != null &&
                XHardDriveComboBox.SelectedItem != null && XGraphicsCardComboBox.SelectedItem != null && XRamComboBox.SelectedItem != null)
            {
                Totals();
                CheckOut();
                //runs the two methods to make the check out form work
            }       
        }//end private void Xcheckoutbutton_click

        //This is to calculate the totals to be used for output to put into the Check out form
        private void Totals()
        {
            //The if statement for motherboard
            if (XMotherboardComboBox.SelectedItem.Equals("ASUS M5A99X EVO"))
            {
                motherboard = 149.99;
                
            }
            else if (XMotherboardComboBox.Text == "ASRock 970 EXTREME4")
            {
                motherboard = 109.99;
            }
            else if (XMotherboardComboBox.Text == "GIGABYTE GA-Z68XP-UD3")
            {
                motherboard = 139.99;
            }
            else if (XMotherboardComboBox.Text == "MSI P67A-G45 (B3) LGA")
            {
                motherboard = 132.99;
            }

            //The if statement for Processor
            if (XProccessorComboBox.Text == "AMD FX-8120 Zambezi 3.1GHz")
            {
                processor = 194.99;
            }
            else if (XProccessorComboBox.Text == "Intel Core i7-2600K 3.4GHz")
            {
                processor = 324.99;
            }
            else if (XProccessorComboBox.Text == "AMD A8-3870K Unlocked Llano 3.0GHz")
            {
                processor = 139.99;
            }
            else if (XProccessorComboBox.Text == "Intel Core i5-2500K 3.3GHz")
            {
                processor = 224.99;
            }

            //The if statement for hard drive
            if (XHardDriveComboBox.Text == "Seagate Barracuda 1TB")
            {
                harddrive = 139.99;
            }
            else if (XHardDriveComboBox.Text == "Western Digital Caviar Black 1TB")
            {
                harddrive = 139.99;
            }
            else if (XHardDriveComboBox.Text == "Seagate Barracuda Green 2TB")
            {
                harddrive = 119.99;
            }
            else if (XHardDriveComboBox.Text == "Western Digital Caviar Blue 500GB")
            {
                harddrive = 89.99;
            }

            //The if statement for graphics card
            if (XGraphicsCardComboBox.Text == "EVGA 01G-P3-1556-KR GeForce GTX")
            {
                graphicscard = 139.99;
            }
            else if (XGraphicsCardComboBox.Text == "EVGA 01G-P3-1561-AR GeForce")
            {
                graphicscard = 249.99;
            }
            else if (XGraphicsCardComboBox.Text == "SAPPHIRE 100314-3L Radeon HD")
            {
                graphicscard = 169.99;
            }
            else if (XGraphicsCardComboBox.Text == "SAPPHIRE 100315L Radeon HD")
            {
                graphicscard = 149.99;
            }

            //The if statement for RAM
            if (XRamComboBox.Text == "CORSAIR Vengeance 16GB (4 x 4GB)")
            {
                ram = 89.99;
            }
            else if (XRamComboBox.Text == "G.SKILL Ripjaws X Series 8GB (2 x 4GB)")
            {
                ram = 41.99;
            }
            else if (XRamComboBox.Text == "G.SKILL Ripjaws Series 16GB (4 x 4GB)")
            {
                ram = 59.99;
            }
            else if (XRamComboBox.Text == "G.SKILL Sniper Series 8GB (2 x 4GB)")
            {
                ram = 91.99;
            }

            //Total Calculations
            subtotal = motherboard + processor + harddrive + graphicscard + ram;
            tax = subtotal * .06;
            total = subtotal + tax;

        }//end private void Totals

        //This is the method to open Form3 which will procceed to a checkout.
        private void CheckOut()
        {
            string output;

            Form3 CheckOut = new Form3();

            output = "Motherboard: " + XMotherboardComboBox.Text + " $" + motherboard.ToString() + Environment.NewLine +
                "Processor: " + XProccessorComboBox.Text + " $" + processor + Environment.NewLine +
                "Hard Drive: " + XHardDriveComboBox.Text + " $" + harddrive + Environment.NewLine +
                "Graphics Card: " + XGraphicsCardComboBox.Text + " $" + graphicscard + Environment.NewLine +
                "RAM: " + XRamComboBox.Text + " $" + ram + Environment.NewLine + Environment.NewLine +
                "SubTotal: $" + subtotal + Environment.NewLine +
                "Tax: $" + tax + Environment.NewLine + Environment.NewLine +
                "Total: $" + total ;

            CheckOut.CheckOutTotal(output);
            
            CheckOut.Show();
        }//end private void check out

        //This is the method to make the picture box move from corner to corner on clicking
        private void XLogoPictureBox_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(8,0);
            Point p2 = new Point(233,0);
            if (XLogoPictureBox.Location == p2)
            {
                XLogoPictureBox.Location = new Point(8, 0);
            }
            else if (XLogoPictureBox.Location == p1)
            {
                XLogoPictureBox.Location = new Point(233,0);
            }
        }

        private void XComputerBuilderLabel_Click(object sender, EventArgs e)
        {

        }//end private void XLogoPictureBox
    }//end public partial class
}//end namespace
