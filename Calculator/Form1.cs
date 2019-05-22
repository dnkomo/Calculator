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
            decimal currentResult = 0.0m;

            for (int i = 0; i < UserUnputText.Text.Length; i++)
            {
                if (UserUnputText.Text[i] == '+')
                {
                    string[] valueArray = UserUnputText.Text.Split('+');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = Addition(result, input);
                }
                if (UserUnputText.Text[i] == '-' && i != 0)
                {
                    string[] valueArray = UserUnputText.Text.Split('-');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = Subtraction(result, input);
                }
                if (UserUnputText.Text[i] == '*')
                {
                    string[] valueArray = UserUnputText.Text.Split('*');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = Multiply(result, input);
                }
                if (UserUnputText.Text[i] == '/')
                {
                    string[] valueArray = UserUnputText.Text.Split('/');
                    decimal result = Convert.ToDecimal(valueArray[0]);
                    decimal input = Convert.ToDecimal(valueArray[1]);

                    currentResult = Divide(result, input);
                }
            }

            CalculationResultText.Text = currentResult.ToString();
        }

        private decimal Addition (decimal currentResult, decimal input)
        {
            decimal result = currentResult + input;

            return result;
        }

        private decimal Subtraction(decimal currentResult, decimal input)
        {
            decimal result = currentResult - input;

            return result;
        }

        private decimal Multiply(decimal currentResult, decimal input)
        {
            decimal result = currentResult * input;

            return result;
        }

        private decimal Divide(decimal currentResult, decimal input)
        {
            decimal result = currentResult / input;

            return result;
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
            int number = 7;
            UserUnputText.AppendText(number.ToString());
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            int number = 8;
            UserUnputText.AppendText(number.ToString());
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            int number = 9;
            UserUnputText.AppendText(number.ToString());
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            int number = 4;
            UserUnputText.AppendText(number.ToString());
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            int number = 5;
            UserUnputText.AppendText(number.ToString());
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            int number = 6;
            UserUnputText.AppendText(number.ToString());
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            int number = 1;
            UserUnputText.AppendText(number.ToString());
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            int number = 2;
            UserUnputText.AppendText(number.ToString());
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            int number = 3;
            UserUnputText.AppendText(number.ToString());
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            UserUnputText.AppendText(number.ToString());
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            char number = '.';
            UserUnputText.AppendText(number.ToString());
        }
        #endregion
    }
}
