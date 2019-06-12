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
            CButton_Click(sender, e);
            CalculationResultText.Text = "Enter an equation and press enter";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = "0";
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

        private void InputIndexToggle()
        {

        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {
            ButtonOperator btn = (ButtonOperator)sender;

            if (!ConsecutiveOperatorCatch(UserInputText.Text[0]) && UserInputText.Text.Length <= 1)
            {
            }
            else if (CalculationResultText.Text.ToString() == "Enter an equation and press enter" || CalculationResultText.Text.ToString().Length == 0)
            {
                CalculationResultText.Text = UserInputText.Text.ToString();
                UserInputText.Text = btn.OperatorCharacter.ToString();
                math.Result = Convert.ToDecimal(CalculationResultText.Text.ToString());
            }
            else if (btn.OperatorCharacter == '=' && UserInputText.Text.Length != 0)
            {
                math.Input = Convert.ToDecimal(UserInputText.Text.Substring(1));
                math.Result = math.Evaluate(math.Result, math.Input, UserInputText, CalculationResultText);
                CalculationResultText.Text = math.Result.ToString();
                CButton_Click(sender, e);
            }
            else
            {
                math.Input = Convert.ToDecimal(UserInputText.Text.Substring(1));
                math.Result = math.Evaluate(math.Result, math.Input, UserInputText, CalculationResultText);
                CalculationResultText.Text = math.Result.ToString();
                UserInputText.Text = btn.OperatorCharacter.ToString();
            }
        }

        private void ButtonStateToggle_Click(object sender, EventArgs e)
        {
            string tempString = string.Empty;
            char operatorHolder = '+';

            if (!ConsecutiveOperatorCatch(UserInputText.Text[1])) //negative to positive
            {
                operatorHolder = UserInputText.Text[0];
                tempString = UserInputText.Text.Substring(2);
                UserInputText.Text = operatorHolder + tempString;
            }
            else //positive to negative
            {
                operatorHolder = UserInputText.Text[0];
                tempString = UserInputText.Text.Substring(1);
                UserInputText.Text = operatorHolder.ToString();
                UserInputText.Text += '-';
                UserInputText.Text += tempString;
            }
        }

        private bool ConsecutiveOperatorCatch (char currentOperator)
        {
            int unicodeRangeMin = 48;
            int unicodeRangeMax = 57;
            if (currentOperator >= unicodeRangeMin && currentOperator <= unicodeRangeMax)
            {
                return true;
            }
            else
            {
                return false;
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
            UserInputText.Text += '.';
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            ButtonNumber btn = (ButtonNumber)sender;
            if (UserInputText.Text == "0")
            {
                UserInputText.Text = string.Empty;
            }
            UserInputText.Text += btn.ButtonValue.ToString();
        }
        #endregion
    }
}
