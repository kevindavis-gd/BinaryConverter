using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //store the input as a string
            string textBoxText = "";
            textBoxText += binaryInput.Text;

            if (textBoxText == "")
                textBoxText = "0";
            
            //check if all characters are 1 or 0, if not throw error
            if (!isbinary(textBoxText))
            {
                MessageBox.Show("Insert Binary Numbers Only", "Error");
                return;
            }
            //check the number of digits to be processed
            int repeat = textBoxText.Length;
            //convert string to int
            int binaryNum = Int32.Parse(textBoxText);
            int remainder = 0;
            int decimalNum = 0;
            //keep tract of base of the right most number (128, 64, 32, 16, 8, 4, 2, 1)
            int baseVal = 1;

            //perform this operating for every digit
            for (int x = 0; x < repeat; x++)
            {   //store the right most number
                remainder = binaryNum % 10;
                // remove the right most number from the binary number
                binaryNum = binaryNum / 10;
                // multiply the binary number by the base and add it to the devimal value
                decimalNum = decimalNum + remainder * baseVal;
                // multiply the base value by 2 to get the correct value
                baseVal = baseVal * 2;
            }
            // print output to invisible lable
            Output.Text += " \n\n The Binary Number is : " + textBoxText;
            Output.Text += "\n Its Decimal Equivalent is : " + decimalNum;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear the screen
            Output.Text = "";
        }

        static bool isbinary(string s)
        {
            //loop through every character
            foreach (var c in s)
                //if the character isnt 0 or 1 return false
                if (c != '0' && c != '1')
                    return false;
            return true;
        }
    }
}
