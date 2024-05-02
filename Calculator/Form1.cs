using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        /* TODO
         * Add readme file
         * Add comments - explain functions etc in this file
         * Tidy code if needed - group functions etc, rename vars
         * eg 3 + =, results in crash
         * Convert calculating functions to read from boxes instead of using 'remembered_characters'
         */


        double remembered_characters;
        
        public Calculator()
        {
            InitializeComponent();
            // Select a button so buttons are in focus of app - otherwise keyboard shortcuts do not work initially
            button_equal.Select();
        }

        enum Operation_Enum
        {
            Null,
            Add, 
            Subtract, 
            Multiply, 
            Divide, 
            Equals,
        }

        Operation_Enum operation_enum = Operation_Enum.Null;



        private void add_character(double character)
        {
            if (textBoxBottom.Text.Length < 18) {
                if (operation_enum != Operation_Enum.Equals) {
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

        private void clear_bottom_text()
        {
            if (textBoxBottom.Text.Length != 0)
            {
                remembered_characters = Convert.ToDouble(textBoxBottom.Text);
                textBoxBottom.Text = "";
            }
        }








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

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!textBoxBottom.Text.Contains(".")) {
                textBoxBottom.Text += ".";
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Divide;
            if (textBoxTop.Text != "")
            {
                textBoxTop.Text = textBoxTop.Text + textBoxBottom.Text + " / ";
            }
            else
            {
                textBoxTop.Text = textBoxBottom.Text + " / ";
            }
            clear_bottom_text();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Multiply;
            if (textBoxTop.Text != "")
            {
                textBoxTop.Text = textBoxTop.Text + textBoxBottom.Text + " * ";
            }
            else
            {
                textBoxTop.Text = textBoxBottom.Text + " * ";
            }
            clear_bottom_text();
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Subtract;
            if (textBoxTop.Text != "")
            {
                textBoxTop.Text = textBoxTop.Text + textBoxBottom.Text + " - ";
            }
            else
            {
                textBoxTop.Text = textBoxBottom.Text + " - ";
            }
            clear_bottom_text();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Add;
            if (textBoxTop.Text != "")
            {
                textBoxTop.Text = textBoxTop.Text + textBoxBottom.Text + " + ";
            }
            else
            {
                textBoxTop.Text = textBoxBottom.Text + " + ";
            }
            clear_bottom_text();
        }
        private void button_square_Click(object sender, EventArgs e)
        {
            // "G10" is number of significant figures used when the number has an 'E'
            textBoxBottom.Text = Math.Pow((double)double.Parse(textBoxBottom.Text), 2).ToString("G10");
        }

        private void button_square_root_Click(object sender, EventArgs e)
        {
            textBoxBottom.Text = Math.Sqrt((double)double.Parse(textBoxBottom.Text)).ToString("G10");
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            double ToOperate = double.Parse(textBoxBottom.Text);

            if (!textBoxTop.Text.Contains('=')) {
                textBoxTop.Text += textBoxBottom.Text + " = ";
            } 



            // Convert to switch statement
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
                switch(finalOperator)
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
            operation_enum = Operation_Enum.Equals;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text.Length != 0) {
                textBoxBottom.Text = textBoxBottom.Text.Remove(textBoxBottom.Text.Length - 1);
            }
        }

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

        private void button_Add_Slash_Minus_Click(object sender, EventArgs e)
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

        private void button_Percent_Click(object sender, EventArgs e)
        {
            if (remembered_characters != 0)
            {
                textBoxBottom.Text = (remembered_characters * (double.Parse(textBoxBottom.Text)/100)).ToString("G10");
            } 
            else
            {
                textBoxBottom.Text = "0";
            }
        }

        private void button_One_Over_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBoxBottom.Text) != 0) {
                textBoxBottom.Text = (1 / double.Parse(textBoxBottom.Text)).ToString("G10");
            } else
            {
                textBoxBottom.Text = "Cannot divide by zero";
            }
        }
    }
}
