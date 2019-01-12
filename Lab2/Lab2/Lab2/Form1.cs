//Lab1
//CIS 199-02
//Due: 2/05/2017
//By: B2707
//This program sets different formats for displaying names.
//The user inserts their name details: Preferred title, First Name
//Middle Name, Last Name
//Format one displays Preferred title, First Name, Middle Name, Last Name
//Format two displays First name, Middle Name, Last Name
//Format three displays First Name, Last Name
//Format four display Last name, First Name Middle Name, preferred title
//Format five displays last name, First Name Middle Name
//Format 6 displays Last Name, First Name

using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void format1Button_Click(object sender, EventArgs e)
        {
            //Declare a string variable to hold the full name in Format 1
            //Preferredtitle, First name, Middle name, Last Name
            string fullNameFormat1;

            //Declare the full names, with spaces between each name.
            //Assign the results to the fullNameFormat1 variable.
            fullNameFormat1 = prefTitleTextbox.Text + " " + firstNameTextbox.Text + " " + middleNameTextbox.Text + " " + lastNameTextbox.Text;

            //Display the fullNameFormat1 variable in the fullNameLabel control.
            fullNameLabel.Text = fullNameFormat1;
        }

        private void format2Button_Click(object sender, EventArgs e)
        {
            //Declare a string variable to hold the full name in Format 2
            //First name, Middle name, Last name
            string fullNameFormat2;

            //Declare the full name, with spaces between each name.
            //Assign the results to the fullNameFormat2 variable.
            fullNameFormat2 = firstNameTextbox.Text + " " + middleNameTextbox.Text + " " + lastNameTextbox.Text;

            //Display the fullNameFormat2 variable in the fullNameLabel control.
            fullNameLabel.Text = fullNameFormat2;
        }

        private void format3Button_Click(object sender, EventArgs e)
        {
            //Declare a string variable to hold the full name in Format 3
            //First name, Last name
            string fullNameFormat3;

            //Declare the full name, with spaces between each name.
            //Assign the results to the fullNameFormat3 variable.
            fullNameFormat3 = firstNameTextbox.Text + " " + lastNameTextbox.Text;

            //Display the fullNameFormat3 variable in the fullNameLabel control
            fullNameLabel.Text = fullNameFormat3;

        }

        private void format4Button_Click(object sender, EventArgs e)
        {
            //Declare a string variable to hold the full name in Format 4
            //Last name, First name-Middle name, Preferred title

            string fullNameFormat4;

            //Declare the full name, with spaces between each name.
            //Assign the reults to fullNameFormat4 variable.
            fullNameFormat4 = lastNameTextbox.Text + ", " + firstNameTextbox.Text + " " + middleNameTextbox.Text + ", " + prefTitleTextbox.Text;

            //Display the fullNameFormat4 variable in the fullNameLabel control
            fullNameLabel.Text = fullNameFormat4;

        }

        private void format5Button_Click(object sender, EventArgs e)
        {
            //Declare a string variable to hold the full name in Format 5
            //Last name, First name-Middle name

            string fullNameFormat5;

            //Declare the full name, with spaces between each name.
            //Assign the reults to fullNameFormat5 variable.
            fullNameFormat5 = lastNameTextbox.Text + ", " + firstNameTextbox.Text + " " + middleNameTextbox.Text;

            //Display the fullNameFormat5 variable in the fullNameLabel control.
            fullNameLabel.Text = fullNameFormat5;
        }

        private void format6Button_Click(object sender, EventArgs e)
        {
            //Declare a string variable to hold the full name in Format 5
            //Last name, First name   

            string fullNameFormat6;

            //Declare the full name, with spaces between each name.
            //Assign the reults to fullNameFormat6 variable.
            fullNameFormat6 = lastNameTextbox.Text + ", " + firstNameTextbox.Text;

            //Display the fullNameFormat6 variable in the fullNameLabel control.
            fullNameLabel.Text = fullNameFormat6;
        }
    }
}
