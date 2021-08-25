using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneNumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsValidFormat(string str)
        {
            //Declare variables
            const int VALID_LENGTH = 11;
            bool isValid;

            //Check for length and '-' char
            if (str.Length == VALID_LENGTH && str[3] == '-')
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            //Remove '-' char and check if remaining chars are alphanumeric
            str = str.Remove(3, 1);
            
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetterOrDigit(str[i]))
                    isValid = false;
            }

            return isValid;
        }

        private void ConvertToNumeric(ref string str)
        {
            //Convert any lowercase letters to uppercase
            str = str.ToUpper();
            
            //Convert any alpha char to its int value
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'B' || str[i] == 'C')
                {
                    str = str.Remove(i,1);
                    str = str.Insert(i, "2");
                }
                else if (str[i] == 'D' || str[i] == 'E' || str[i] == 'F')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, "3");
                }
                else if (str[i] == 'G' || str[i] == 'H' || str[i] == 'I')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, "4");
                }
                else if (str[i] == 'J' || str[i] == 'K' || str[i] == 'L')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, "5");
                }
                else if (str[i] == 'M' || str[i] == 'N' || str[i] == 'O')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, "6");
                }
                else if (str[i] == 'P' || str[i] == 'Q' || str[i] == 'R' || str[i] == 'S')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, "7");
                }
                else if (str[i] == 'T' || str[i] == 'U' || str[i] == 'V')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, "8");
                }
                else if (str[i] == 'W' || str[i] == 'X' || str[i] == 'Y' || str[i] == 'Z')
                {
                    str = str.Remove(i, 1);
                    str = str.Insert(i, "9");
                }
            }
        }
        
        private void convertButton_Click(object sender, EventArgs e)
        {            
            //Get and trim user input
            string input = alphaNumTextBox.Text.Trim();

            //Validate, convert, and display user input
            if (IsValidFormat(input))
            {
                ConvertToNumeric(ref input);
                convNumLabel.Text = input;
            }
            else
            {
                //Display error message if invalid entry
                MessageBox.Show("Invalid Entry: The number you enter may only contain numbers, letters, " +
                    "and one hyphen in this format: XXX-XXXXXXXX (e.g. 800-FLOWERS)");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the application
            this.Close();
        }
    }
}
