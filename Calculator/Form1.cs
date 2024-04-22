using System;
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
         * Add comments - explain functions etc in this file
         * Result shouldn't need to be scrolled to see full result - eg when E+05 - Too many sf can lead to E+ part being cut off
         * Resize textbox when window resized?
         * Tidy code if needed- group functions etc
         * Fix tab index
         * Have two rows of calculations
         *  - First row is remembered_characters
         *  - Second row is as is
         * Pressing '=' should mean that next time numbers are inputted, they replace prev calcs.
         * Set to zero when resetting
         * Unit Tests?
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
            if (operation_enum != Operation_Enum.Equals) {
                textBox1.Text += character;
            } 
            else
            {
                textBox1.Text = "";
                textBox1.Text += character;
                operation_enum = Operation_Enum.Null;
            }
        }

        private void clear_characters()
        {
            if (textBox1.Text.Length != 0)
            {
                remembered_characters = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
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
            textBox1.Text += ".";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Divide;
            clear_characters();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Multiply;
            clear_characters();
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Subtract;
            clear_characters();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            operation_enum = Operation_Enum.Add;
            clear_characters();
        }
        private void button_square_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
        }

        private void button_square_root_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            double ToOperate = double.Parse(textBox1.Text);
            if (operation_enum == Operation_Enum.Add)
            {
                textBox1.Text = (ToOperate + remembered_characters).ToString();
            } 
            else if (operation_enum == Operation_Enum.Subtract)
            {
                textBox1.Text = (remembered_characters - ToOperate).ToString();
            }
            else if (operation_enum == Operation_Enum.Multiply)
            {
                textBox1.Text = (ToOperate * remembered_characters).ToString();
            }
            else if (operation_enum == Operation_Enum.Divide)
            {
                textBox1.Text = (remembered_characters / ToOperate).ToString();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0) {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            remembered_characters = 0;
            operation_enum = Operation_Enum.Null;
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operation_enum = Operation_Enum.Null;
        }

        private void button_Add_Slash_Minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == char.Parse("-"))
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button_Percent_Click(object sender, EventArgs e)
        {
            if (remembered_characters != 0)
            {
                textBox1.Text = (remembered_characters * (double.Parse(textBox1.Text)/100)).ToString();
            } 
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button_One_Over_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) != 0) {
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
            } else
            {
                textBox1.Text = "Cannot divide by zero";
            }
        }
    }
}
