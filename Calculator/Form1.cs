using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        /* TODO
         * Improve visuals
         *      - Icon
         *      - Shading?
         *      - Bezels?
         */

        double rememberedCharacters;
        
        public Calculator()
        {
            InitializeComponent();
            // Select a button so buttons are in focus of app - otherwise keyboard shortcuts do not work initially
            buttonEqual.Select();
        }

        // Enumerator to determine what operation should be done when equals is pressed. Starts as null.
        enum OperationEnum
        {
            Null = ' ',
            Add = '+', 
            Subtract = '-', 
            Multiply = '*', 
            Divide = '/', 
            Equals = '=',
        }
        OperationEnum operationEnum = OperationEnum.Null;

        private void ClearBottomText()
        {
            if (textBoxBottom.Text.Length != 0)
            {
                rememberedCharacters = Convert.ToDouble(textBoxBottom.Text);
                textBoxBottom.Text = "";
            }
        }

        // Backspace shortcut key needs to be implemented seperately - mnemonic does not work with backspace character
        private void CalculatorKeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    buttonDelete_Click(sender, e);
                    break;
                case Keys.D5:
                    if (ModifierKeys == Keys.Shift)
                    {
                        buttonPercent_Click(sender, e);
                    }
                    break;
            }
        }

        // Add a number character to the end of the bottom text box.
        private void AddCharacter(double character)
        {
            if (textBoxBottom.Text.Length < 18)
            {
                if (operationEnum != OperationEnum.Equals)
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
                    operationEnum = OperationEnum.Null;
                }
            }
            buttonEqual.Focus();
        }
        
        // Delete most recent number from bottom text box.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text.Length != 0)
            {
                textBoxBottom.Text = textBoxBottom.Text.Remove(textBoxBottom.Text.Length - 1);
            }
        }

        // Functions called on number button click
        private void button0_Click(object sender, EventArgs e)
        {
            AddCharacter(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddCharacter(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddCharacter(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddCharacter(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddCharacter(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AddCharacter(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AddCharacter(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {   
            AddCharacter(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AddCharacter(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AddCharacter(9);
        }

        // Add a dot to end of string, or set string as 0. if no numbers already there.
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBoxBottom.Text.Contains(".") && operationEnum != OperationEnum.Equals) {
                if (textBoxBottom.Text == "")
                {
                    textBoxBottom.Text = "0.";
                } 
                else
                {
                    textBoxBottom.Text += ".";
                }
            }
            else if (operationEnum == OperationEnum.Equals)
            {
                AddCharacter(0);
                textBoxBottom.Text += ".";
            }
        }

        // Functions to prepare text box and set enum for basic operations.
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation(sender, e, OperationEnum.Divide);
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation(sender, e, OperationEnum.Multiply);
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation(sender, e, OperationEnum.Subtract);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation(sender, e, OperationEnum.Add);
        }

        // New enum needs to be set before adjusting the text boxes but after button_equal_function has been called if needed.
        private void PerformOperation(object sender, EventArgs e, OperationEnum newEnum)
        {
            textBoxBottom.Text = textBoxBottom.Text.TrimEnd('.');
            if (textBoxBottom.Text != "")
            {
                if (textBoxTop.Text != "")
                {
                    if (textBoxTop.Text.Split(' ').Length > 1)
                    {
                        ButtonEqualFunction(sender, e, false);
                        operationEnum = newEnum;
                        textBoxTop.Text = textBoxBottom.Text + " " + (char)operationEnum + " ";
                    }
                }
                else
                {
                    operationEnum = newEnum;
                    textBoxTop.Text = textBoxBottom.Text + " " + (char)operationEnum + " ";
                }
            }
            else
            {
                operationEnum = newEnum;
                StringBuilder sb = new StringBuilder(textBoxTop.Text);
                sb[sb.Length - 2] = (char)operationEnum;
                textBoxTop.Text = sb.ToString();
            }
            ClearBottomText();
        }


        // Functions for other included math operations
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "") {
                // "G10" is number of significant figures used when the number has an 'E'
                textBoxBottom.Text = Math.Pow((double)double.Parse(textBoxBottom.Text), 2).ToString("G10");
                operationEnum = OperationEnum.Equals;
            }
        }
        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "")
            {
                textBoxBottom.Text = Math.Sqrt((double)double.Parse(textBoxBottom.Text)).ToString("G10");
                operationEnum = OperationEnum.Equals;
            }
        }
        private void buttonAddSlashMinus_Click(object sender, EventArgs e)
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
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "")
            {
                if (rememberedCharacters != 0)
                {
                    textBoxBottom.Text = (rememberedCharacters * (double.Parse(textBoxBottom.Text) / 100)).ToString("G10");
                }
                else
                {
                    textBoxBottom.Text = "0";
                }
            }
        }
        private void buttonOneOver_Click(object sender, EventArgs e)
        {
            if (textBoxBottom.Text != "")
            {
                if (double.Parse(textBoxBottom.Text) != 0)
                {
                    textBoxBottom.Text = (1 / double.Parse(textBoxBottom.Text)).ToString("G10");
                    operationEnum = OperationEnum.Equals;
                }
                else
                {
                    textBoxBottom.Text = "Cannot divide by zero";
                }
            }
        }

        // Call equals function
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            ButtonEqualFunction(sender, e, true);
        }

        // Called from button_equal_Click so function can be called by other functions.
        // Performs the calculations and handles when equals button is pressed repeatedly.
        private void ButtonEqualFunction(object sender, EventArgs e, bool equalButtonClicked = true)
        {
            if (textBoxBottom.Text != "")
            {
                textBoxBottom.Text = textBoxBottom.Text.TrimEnd('.');
                double toOperate = double.Parse(textBoxBottom.Text);

                if (!textBoxTop.Text.Contains('=') && equalButtonClicked)
                {
                    textBoxTop.Text += textBoxBottom.Text + " = ";
                }

                switch (operationEnum)
                {
                    case OperationEnum.Add:
                        textBoxBottom.Text = (toOperate + rememberedCharacters).ToString("G10");
                        break;
                    case OperationEnum.Subtract:
                        textBoxBottom.Text = textBoxBottom.Text = (rememberedCharacters - toOperate).ToString("G10");
                        break;
                    case OperationEnum.Multiply:
                        textBoxBottom.Text = (toOperate * rememberedCharacters).ToString("G10");
                        break;
                    case OperationEnum.Divide:
                        textBoxBottom.Text = (rememberedCharacters / toOperate).ToString("G10");
                        break;
                    // This case is to repeat the previous operation on the result of the calculation
                    case OperationEnum.Equals:
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
                        break;
                }
                if (equalButtonClicked) {
                    operationEnum = OperationEnum.Equals;
                }
            }
        }

        // Functions for clearing the text boxes and resetting the operation enum.
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxBottom.Text = "0";
            textBoxTop.Text = "";
            rememberedCharacters = 0;
            operationEnum = OperationEnum.Null;
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxBottom.Text = "0";
            operationEnum = OperationEnum.Null;
        }
    }
}
