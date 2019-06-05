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
        ButtonZero buttonZero = new ButtonZero();
        ButtonOne buttonOne = new ButtonOne();
        ButtonTwo buttonTwo = new ButtonTwo();
        ButtonThree buttonThree = new ButtonThree();
        ButtonFour buttonFour = new ButtonFour();
        ButtonFive buttonFive = new ButtonFive();
        ButtonSix buttonSix = new ButtonSix();
        ButtonSeven buttonSeven = new ButtonSeven();
        ButtonEight buttonEight = new ButtonEight();
        ButtonNine buttonNine = new ButtonNine();
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
            UserUnputText.ResetText();
            CalculationResultText.Text = "Enter an equation and press enter";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            UserUnputText.ResetText();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (UserUnputText.Text.Length > 0)
            {
                UserUnputText.Text = UserUnputText.Text.Substring(0, UserUnputText.Text.Length - 1);
            }
        }
        #endregion

        #region Operator Methods
        /// <summary>
        /// Default operator functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            char functionOperator = '*';
            if (!ConsecutiveOperatorCatch(functionOperator))
            {
                OrderOfOperations(sender, e);
                PreviousResultCheck();
                UserUnputText.AppendText(functionOperator.ToString());
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            char functionOperator = '/';
            if (!ConsecutiveOperatorCatch(functionOperator))
            {
                OrderOfOperations(sender, e);
                PreviousResultCheck();
                UserUnputText.AppendText(functionOperator.ToString());
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            char functionOperator = '-';
            if (!ConsecutiveOperatorCatch(functionOperator))
            {
                OrderOfOperations(sender, e);
                PreviousResultCheck();
                UserUnputText.AppendText(functionOperator.ToString());
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            char functionOperator = '+';
            if (!ConsecutiveOperatorCatch(functionOperator))
            {
                OrderOfOperations(sender, e);
                PreviousResultCheck();
                UserUnputText.AppendText(functionOperator.ToString());
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            decimal currentResult = 0;

            for (int i = 0; i < UserUnputText.Text.Length; i++)
            {
                if (UserUnputText.Text[i] == '+')
                {
                    string[] valueArray = UserUnputText.Text.Split('+');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = addition.Calculate(result, input);
                }
                if (UserUnputText.Text[i] == '-' && i != 0)
                {
                    string[] valueArray = UserUnputText.Text.Split('-');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = subtraction.Calculate(result, input);
                }
                if (UserUnputText.Text[i] == '*')
                {
                    string[] valueArray = UserUnputText.Text.Split('*');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = multiplication.Calculate(result, input);
                }
                if (UserUnputText.Text[i] == '/')
                {
                    string[] valueArray = UserUnputText.Text.Split('/');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = division.Calculate(result, input);
                }
            }

            CalculationResultText.Text = currentResult.ToString();
        }

        private void OrderOfOperations(object sender, EventArgs e)
        {
            if (UserUnputText.Text.Contains('+') || UserUnputText.Text.Contains('-') || UserUnputText.Text.Contains('*') || UserUnputText.Text.Contains('/'))
            {
                EqualsButton_Click(sender, e);
            }
        }

        private void PreviousResultCheck ()
        {
            if (CalculationResultText.Text.ToString() != "Enter an equation and press enter")
            {
                UserUnputText.Text = CalculationResultText.Text.ToString();
            }
        }

        private bool ConsecutiveOperatorCatch (char currentOperator)
        {
            int unicodeRangeMin = 48;
            int unicodeRangeMax = 57;
            if (UserUnputText.Text.Length == 0)
            {
                return true;
            }
            else if (UserUnputText.Text[UserUnputText.Text.Length - 1] >= unicodeRangeMin && UserUnputText.Text[UserUnputText.Text.Length - 1] <= unicodeRangeMax)
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
        private void SevenButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonSeven.ButtonValue.ToString());
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonEight.ButtonValue.ToString());
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonNine.ButtonValue.ToString());
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonFour.ButtonValue.ToString());
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonFive.ButtonValue.ToString());
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonSix.ButtonValue.ToString());
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonOne.ButtonValue.ToString());
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonTwo.ButtonValue.ToString());
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonThree.ButtonValue.ToString());
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonZero.ButtonValue.ToString());
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            UserUnputText.AppendText(buttonDecimal.ButtonValue.ToString());
        }
        #endregion
    }
}
