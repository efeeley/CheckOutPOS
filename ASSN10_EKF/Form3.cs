using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 3/7/2012
 * Assignment: ASSN10_EKF
 * Resources:http://msdn.microsoft.com/en-us/library/6ka1wd3w.aspx
 * ***********************************/

namespace ASSN10_EKF
{
    public partial class Form3 : Form
    {
        List<string> checkout = new List<string>();
        string results;

        public Form3()
        {
            InitializeComponent();
        }//end public Form3

        //Hides this form so that you can go back to the main form to make changes to your order.
        private void XReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//end private void XReturnButton_Click

        //Takes the output from the main form and puts it in this form
        public void CheckOutTotal(string output)
        {
            XCheckOutTextBox.Text = output;
            results = Convert.ToString(output);
        }//nd public void CheckOutTotal

        //Saves the results of the check out to a text file and exits the application
        private void XExitButton_Click(object sender, EventArgs e)
        {
            string MyDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //save the contents to a txt file
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(MyDocPath + @"\CheckOutResults.txt"))
            {
                    file.WriteLine(results);
                    file.Close();
            }

            MessageBox.Show("Your check out results have been stored to a text file in My Documents.", "Application Closing", MessageBoxButtons.OK);
            

            //exit the application
            Application.Exit();
        }//end private void XExitButton_Click
    }//end public partial class
}//end namespace
