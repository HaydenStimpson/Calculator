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
         * 5. Percent button
         * 6. Square button
         * 7. Square root button
         * 9. Dont allow size to be changed
         *      - Or allow app to stretch 
         *      - Enable/Disable window buttons accordingly
         * 10. Put 0 instead of null?
         * 13. Add comments
         * 14. Can't press equals multiple times - press multiple times to repeat equation
         * 15. Should show remembered_characters above (like windows calculator)
         * 16. Result shouldn't need to be scrolled to see full result - eg when E+05
         * 17. Work out backspace shortcut
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
            Equals
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
            operation_enum = Operation_Enum.Equals;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (operation_enum != Operation_Enum.Equals && textBox1.Text.Length != 0) {
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
    }
}
