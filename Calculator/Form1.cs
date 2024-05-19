using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        /* TODO
         * Tidy code if needed - group functions etc, rename vars, combine repeated code if it exists
         * Make sure everything follows coding conventions - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
         * Improve visuals
         *      - Icon
         *      - Shading?
         *      - Bezels?
         */

        double remembered_characters;
        
        public Calculator()
        {
            InitializeComponent();
            // Select a button so buttons are in focus of app - otherwise keyboard shortcuts do not work initially
            button_equal.Select();
        }

        // Enumerator to determine what operation should be done when equals is pressed. Starts as null.
        enum Operation_Enum
        {
            Null = ' ',
            Add = '+', 
            Subtract = '-', 
            Multiply = '*', 
            Divide = '/', 
            Equals = '=',
        }
        Operation_Enum operation_enum = Operation_Enum.Null;

        private void clear_bottom_text()
        {
            if (textBoxBottom.Text.Length != 0)
            {
                remembered_characters = Convert.ToDouble(textBoxBottom.Text);
                textBoxBottom.Text = "";
            }
        }

        // Backspace shortcut key needs to be implemented seperately - mnemonic does not work with backspace character
        private void Calculator_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                button_delete_Click(sender, e);
            }
        }

        // Add a number character to the end of the bottom text box.
        private void add_character(double character)
        {
            if (textBoxBottom.Text.Length < 18)
            {
                if (operation_enum != Operation_Enum.Equals)
                {
                    if (textBoxBottom.Text == "0")
                    {
                        textBoxBottom.Text = "";
                    }
                    textBoxBottom.Text += character;
                }
                else
                {
                    textBoxTop.Text = "";
                    textBoxBottom.Text = "";
                    textBoxBottom.Text += character;
                    operation_enum = Operation_Enum.Null;
                }
            }
            button_equal.Focus();
        }
        
        // Delete most recent number from bottom text box.
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text.Length != 0)
            {
                textBoxBottom.Text = textBoxBottom.Text.Remove(textBoxBottom.Text.Length - 1);
            }
        }

        // Functions called on number button click
        private void button_0_Click(object sender, EventArgs e)
        {
            add_character(0);
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            add_character(1);
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            add_character(2);
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            add_character(3);
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            add_character(4);
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            add_character(5);
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            add_character(6);
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            add_character(7);
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            add_character(8);
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            add_character(9);
        }

        // Add a dot to end of string, or set string as 0. if no numbers already there.
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!textBoxBottom.Text.Contains(".") && operation_enum != Operation_Enum.Equals) {
                if (textBoxBottom.Text == "")
                {
                    textBoxBottom.Text = "0.";
                } 
                else
                {
                    textBoxBottom.Text += ".";
                }
            }
        }

        // Functions to prepare text box and set enum for basic operations.
        private void button_divide_Click(object sender, EventArgs e)
        {
            perform_Operation(sender, e, Operation_Enum.Divide);
        }
        private void button_multiply_Click(object sender, EventArgs e)
        {
            perform_Operation(sender, e, Operation_Enum.Multiply);
        }
        private void button_subtract_Click(object sender, EventArgs e)
        {
            perform_Operation(sender, e, Operation_Enum.Subtract);
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            perform_Operation(sender, e, Operation_Enum.Add);
        }

        // New enum needs to be set before adjusting the text boxes but after button_equal_function has been called if needed.
        private void perform_Operation(object sender, EventArgs e, Operation_Enum newEnum)
        {
            textBoxBottom.Text = textBoxBottom.Text.TrimEnd('.');
            if (textBoxBottom.Text != "")
            {
                if (textBoxTop.Text != "")
                {
                    if (textBoxTop.Text.Split(' ').Length > 1)
                    {
                        button_equal_function(sender, e, false);
                        operation_enum = newEnum;
                        textBoxTop.Text = textBoxBottom.Text + " " + (char)operation_enum + " ";
                    }
                }
                else
                {
                    operation_enum = newEnum;
                    textBoxTop.Text = textBoxBottom.Text + " " + (char)operation_enum + " ";
                }
            }
            else
            {
                operation_enum = newEnum;
                StringBuilder sb = new StringBuilder(textBoxTop.Text);
                sb[sb.Length - 2] = (char)operation_enum;
                textBoxTop.Text = sb.ToString();
            }
            clear_bottom_text();
        }


        // Functions for other included math operations
        private void button_square_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "") {
                // "G10" is number of significant figures used when the number has an 'E'
                textBoxBottom.Text = Math.Pow((double)double.Parse(textBoxBottom.Text), 2).ToString("G10");
            }
        }
        private void button_square_root_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "")
            {
                textBoxBottom.Text = Math.Sqrt((double)double.Parse(textBoxBottom.Text)).ToString("G10");
            }
        }
        private void button_Add_Slash_Minus_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "")
            {
                if (textBoxBottom.Text[0] == char.Parse("-"))
                {
                    textBoxBottom.Text = textBoxBottom.Text.Substring(1);
                }
                else
                {
                    textBoxBottom.Text = "-" + textBoxBottom.Text;
                }
            }
        }
        private void button_Percent_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "")
            {
                if (remembered_characters != 0)
                {
                    textBoxBottom.Text = (remembered_characters * (double.Parse(textBoxBottom.Text) / 100)).ToString("G10");
                }
                else
                {
                    textBoxBottom.Text = "0";
                }
            }
        }
        private void button_One_Over_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "")
            {
                if (double.Parse(textBoxBottom.Text) != 0)
                {
                    textBoxBottom.Text = (1 / double.Parse(textBoxBottom.Text)).ToString("G10");
                }
                else
                {
                    textBoxBottom.Text = "Cannot divide by zero";
                }
            }
        }

        // Call equals function
        private void button_equal_Click(object sender, EventArgs e)
        {
            button_equal_function(sender, e, true);
        }

        // Called from button_equal_Click so function can be called by other functions.
        // Performs the calculations and handles when equals button is pressed repeatedly.
        private void button_equal_function(object sender, EventArgs e, bool equalButtonClicked = true)
        {
            if (textBoxBottom.Text != "")
            {
                textBoxBottom.Text = textBoxBottom.Text.TrimEnd('.');
                double ToOperate = double.Parse(textBoxBottom.Text);

                if (!textBoxTop.Text.Contains('=') && equalButtonClicked)
                {
                    textBoxTop.Text += textBoxBottom.Text + " = ";
                }

                // TODO: Convert to switch statement
                if (operation_enum == Operation_Enum.Add)
                {
                    textBoxBottom.Text = (ToOperate + remembered_characters).ToString("G10");
                }
                else if (operation_enum == Operation_Enum.Subtract)
                {
                    textBoxBottom.Text = (remembered_characters - ToOperate).ToString("G10");
                }
                else if (operation_enum == Operation_Enum.Multiply)
                {
                    textBoxBottom.Text = (ToOperate * remembered_characters).ToString("G10");
                }
                else if (operation_enum == Operation_Enum.Divide)
                {
                    textBoxBottom.Text = (remembered_characters / ToOperate).ToString("G10");
                }
                else if (operation_enum == Operation_Enum.Equals)
                {
                    // Repeat previous eqaution
                    // Fix top text box
                    string[] textBoxTopSplit = textBoxTop.Text.Split(' ');
                    string finalOperateNumber = textBoxTopSplit[textBoxTopSplit.Length - 3];
                    string finalOperator = textBoxTopSplit[textBoxTopSplit.Length - 4];
                    string originalResult = textBoxBottom.Text;

                    textBoxTop.Text = originalResult + " " + finalOperator + " " + finalOperateNumber + " = ";


                    // Calculate new result
                    switch (finalOperator)
                    {
                        case "+":
                            textBoxBottom.Text = (Convert.ToDouble(originalResult) + Convert.ToDouble(finalOperateNumber)).ToString("G10");
                            break;
                        case "-":
                            textBoxBottom.Text = (Convert.ToDouble(originalResult) - Convert.ToDouble(finalOperateNumber)).ToString("G10");
                            break;
                        case "*":
                            textBoxBottom.Text = (Convert.ToDouble(originalResult) * Convert.ToDouble(finalOperateNumber)).ToString("G10");
                            break;
                        case "/":
                            textBoxBottom.Text = (Convert.ToDouble(originalResult) / Convert.ToDouble(finalOperateNumber)).ToString("G10");
                            break;
                    }
                }
                if (equalButtonClicked) {
                    operation_enum = Operation_Enum.Equals;
                }
            }
        }

        // Functions for clearing the text boxes and resetting the operation enum.
        private void button_C_Click(object sender, EventArgs e)
        {
            textBoxBottom.Text = "0";
            textBoxTop.Text = "";
            remembered_characters = 0;
            operation_enum = Operation_Enum.Null;
        }
        private void button_CE_Click(object sender, EventArgs e)
        {
            textBoxBottom.Text = "0";
            operation_enum = Operation_Enum.Null;
        }
    }
}
