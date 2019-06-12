using Calculator.Classes.Buttons;
using Calculator.Classes.Input;
using Calculator.Classes.Operators;
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
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region ButtonInitialization
        ButtonDecimal buttonDecimal = new ButtonDecimal();
        InputTextField inputTextField = new InputTextField();
        Addition addition = new Addition();
        Subtraction subtraction = new Subtraction();
        Multiplication multiplication = new Multiplication();
        Division division = new Division();
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Clearing Methods
        private void CEButton_Click(object sender, EventArgs e)
        {
            UserInputText.ResetText();
            CalculationResultText.Text = "Enter an equation and press enter";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            UserInputText.ResetText();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (UserInputText.Text.Length > 0)
            {
                UserInputText.Text = UserInputText.Text.Substring(0, UserInputText.Text.Length - 1);
            }
        }
        #endregion

        #region Operator Methods
        /// <summary>
        /// Default operator functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ButtonOperator_Click (object sender, EventArgs e)
        {
            ButtonOperator btn = (ButtonOperator)sender;
            if (!ConsecutiveOperatorCatch(btn.OperatorCharacter))
            {
                OrderOfOperations(sender, e);
                PreviousResultCheck();
                UserInputText.AppendText(btn.OperatorCharacter.ToString());
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!ConsecutiveOperatorCatch(UserInputText.Text[UserInputText.Text.Length - 1]))
            {
                decimal currentResult = 0;

                for (int i = 0; i < UserInputText.Text.Length; i++)
                {
                    if (UserInputText.Text[i] == '+')
                    {
                        string[] valueArray = UserInputText.Text.Split('+');
                        decimal result = Convert.ToDecimal(valueArray[0]);
                        decimal input = Convert.ToDecimal(valueArray[1]);

                        currentResult = addition.Calculate(result, input);
                    }
                    if (UserInputText.Text[i] == '-' && i != 0 && UserInputText.Text[0] == '-')
                    {
                        string tempString = UserInputText.Text.Substring(1);
                        string[] valueArray = tempString.Split('-');
                        decimal result = Convert.ToDecimal(valueArray[0]) * -1;
                        decimal input = Convert.ToDecimal(valueArray[1]);

                        currentResult = subtraction.Calculate(result, input);
                    }
                    else if (UserInputText.Text[i] == '-' && i != 0)
                    {
                        string[] valueArray = UserInputText.Text.Split('-');
                        decimal result = Convert.ToDecimal(valueArray[0]);
                        decimal input = Convert.ToDecimal(valueArray[1]);

                        currentResult = subtraction.Calculate(result, input);
                    }
                    if (UserInputText.Text[i] == '*')
                    {
                        string[] valueArray = UserInputText.Text.Split('*');
                        decimal result = Convert.ToDecimal(valueArray[0]);
                        decimal input = Convert.ToDecimal(valueArray[1]);

                        currentResult = multiplication.Calculate(result, input);
                    }
                    if (UserInputText.Text[i] == '/')
                    {
                        string[] valueArray = UserInputText.Text.Split('/');
                        decimal result = Convert.ToDecimal(valueArray[0]);
                        decimal input = Convert.ToDecimal(valueArray[1]);

                        currentResult = division.Calculate(result, input);
                    }
                }

                CalculationResultText.Text = currentResult.ToString();
            }
        }

        private void ButtonStateToggle_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderOfOperations(object sender, EventArgs e)
        {
            if (UserInputText.Text.Contains('+') || UserInputText.Text.Contains('-') || UserInputText.Text.Contains('*') || UserInputText.Text.Contains('/'))
            {
                EqualsButton_Click(sender, e);
            }
        }

        private void PreviousResultCheck ()
        {
            if (CalculationResultText.Text.ToString() != "Enter an equation and press enter")
            {
                UserInputText.Text = CalculationResultText.Text.ToString();
            }
        }

        private bool ConsecutiveOperatorCatch (char currentOperator)
        {
            int unicodeRangeMin = 48;
            int unicodeRangeMax = 57;
            if (UserInputText.Text.Length == 0)
            {
                return true;
            }
            else if (UserInputText.Text[UserInputText.Text.Length - 1] >= unicodeRangeMin && UserInputText.Text[UserInputText.Text.Length - 1] <= unicodeRangeMax)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Number Methods
        /// <summary>
        /// Default number functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            UserInputText.AppendText(buttonDecimal.ButtonValue.ToString());
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            ButtonNumber btn = (ButtonNumber)sender;
            UserInputText.AppendText(btn.ButtonValue.ToString());
        }
        #endregion
    }
}
