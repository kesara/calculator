using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator.NET
{
    /*
     * MainForm - The main GUI.
     * @author: Kesara Nanayakkara Rathnayake < kesara@bcs.org >
     * Copyright (C) 2007, 2008 Kesara Nanayakkara Rathnayake
     * 
     * This file is part of Calculator.NET.
     * 
     * Calculator.NET is free software: you can redistribute it and/or modify
     * it under the terms of the GNU General Public License as published by
     * the Free Software Foundation, either version 3 of the License.
     * 
     * Calculator.NET is distributed in the hope that it will be useful,
     * but WITHOUT ANY WARRANTY; without even the implied warranty of
     * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
     * GNU General Public License for more details.
     * 
     * You should have received a copy of the GNU General Public License
     * along with Calculator.NET.  If not, see <http://www.gnu.org/licenses/>.
     * 
     */
    public partial class MainForm : Form
    {
        #region Variables
        private double x;                       // First number
        private double y;                       // Second number
        private double m;                       // Number in memory
        private double result;                  // Result
        private string operation;               // Activated operation
        private bool withInCalculation;         // True if two prameter operation is activated.
        private bool operationPressed;          // True if operater has been pressed.
        private bool singleParameterOperation;  // True if operation is a single parameter operation.
        #endregion

        /*
         * MainForm - MainForm Constructor
         * Intialize GUI Components and calculator variables.
         */
        public MainForm()
        {
            InitializeComponent();

            #region Variable Intialization
            x = 0;
            y = 0;
            m = 0;
            result = 0;
            operation = "";
            withInCalculation = false;
            operationPressed = true;            // So the display clears every thing when number pressed.
            singleParameterOperation = false;
            #endregion
        }

        /*************************
         * Calculator Operations *
         *************************/

        /* 
         * enterOperation - Handles activated operations
         */
        private void enterOperation(String currentOperation)
        {

            if (withInCalculation)
            {
                y = Double.Parse(textBoxDisplay.Text);
                toolStripDropDownNumbers.DropDown.Items.Add(y.ToString());

                switch (operation)
                {
                    case "+":
                        result = Calculations.addition(x, y);
                        break;
                    case "-":
                        result = Calculations.subtraction(x, y);
                        break;
                    case "×":
                        result = Calculations.multiplication(x, y);
                        break;
                    case "÷":
                        result = Calculations.division(x, y);
                        break;
                    case "xⁿ":
                        result = Calculations.power(x, y);
                        break;
                }

                updatePad(operation, x, y, result);
                x = result;
                y = 0;
                textBoxDisplay.Text = result.ToString();

                toolStripDropDownNumbers.DropDown.Items.Add(result.ToString());
                operation = currentOperation;
                withInCalculation = true;
                operationPressed = true;
            }
            else
            {
                x = Double.Parse(textBoxDisplay.Text);
                toolStripDropDownNumbers.DropDown.Items.Add(x.ToString());
                operation = currentOperation;
                withInCalculation = true;
                operationPressed = true;
            }

            if (currentOperation != "=")
            {
                operationLabel.Text = operation;
            }
            else
            {
                operationLabel.Text = "";
                operation = "";
                withInCalculation = false;
            }

            switch (operation)
            {
                case "x!":
                    result = Calculations.factorial(x);
                    singleParameterOperation = true;
                    break;
                case "√":
                    result = Calculations.squareRoot(x);
                    singleParameterOperation = true;
                    break;
                case "x²":
                    result = Calculations.square(x);
                    singleParameterOperation = true;
                    break;
                case "x³":
                    result = Calculations.cube(x);
                    singleParameterOperation = true;
                    break;
            }

            if (singleParameterOperation)
            {
                updatePad(operation, x, result);
                x = result;
                y = 0;
                textBoxDisplay.Text = result.ToString();
                toolStripDropDownNumbers.DropDown.Items.Add(result.ToString());
                operationLabel.Text = "";
                withInCalculation = false;
                operationPressed = true;
                singleParameterOperation = false;
            }
        }

        /**********************
         * Display Operations *
         **********************/

        /*
         * enterNumber - Handles display and storing of numbers and values.
         * Inovocked when a number, period or plus-minus is pressed.
         */
        private void enterNumber(String number)
        {
            if (number == "±")
            {
                textBoxDisplay.Text = Calculations.plusMinus(Double.Parse(textBoxDisplay.Text)).ToString();
                return;
            }

            if (operationPressed)
            {
                textBoxDisplay.Text = "";
                operationPressed = false;
            }

            if (number == ".")
            {
                if (textBoxDisplay.Text.Contains('.') == false)
                {
                    if (textBoxDisplay.Text == "")
                    {
                        textBoxDisplay.Text = textBoxDisplay.Text + "0" + number;
                    }
                    else
                    {
                        textBoxDisplay.Text = textBoxDisplay.Text + number;
                    }
                }
            }
            else if (number == "0")
            {
                if (textBoxDisplay.Text != "0")
                {
                    textBoxDisplay.Text = textBoxDisplay.Text + number;
                }
            }
            else if (number == "Backspace")
            {
                if (textBoxDisplay.Text.Length > 0)
                {
                    textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);
                }

                if (textBoxDisplay.Text.Length <= 0)
                {
                    operationPressed = true;
                    textBoxDisplay.Text = "0";
                }
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + number;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            operationPressed = true;
        }

        private void buttonAllCancel_Click(object sender, EventArgs e)
        {
            /* Variable Reset */
            x = 0;
            y = 0;
            result = 0;
            operation = "";
            withInCalculation = false;
            operationPressed = true;
            singleParameterOperation = false;

            /* Control Reset */
            textBoxDisplay.Text = "0";
            operationLabel.Text = "";
        }

        /********************
         * Memory Operation *
         ********************/
        private void buttonMemoryAddition_Click(object sender, EventArgs e)
        {
            m = Calculations.addition(m, Double.Parse(textBoxDisplay.Text));
            memoryStatus.Text = "M = " + m.ToString();
            updatePad(m);
            operationPressed = true;
        }

        private void buttonMemorySubtraction_Click(object sender, EventArgs e)
        {
            m = Calculations.subtraction(m, Double.Parse(textBoxDisplay.Text));
            memoryStatus.Text = "M = " + m.ToString();
            updatePad(m);
            operationPressed = true;
        }

        private void buttonMemoryRecall_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = m.ToString();
            operationPressed = true;
        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            m = 0;
            memoryStatus.Text = "";
            updatePad(m);
            operationPressed = true;
        }

        /**************
         * User Input *
         **************/

        /* 
         * operationButtonClick - Handles user's input via buttons
         */
        private void operationButtonClick(object sender, EventArgs e)
        {
            enterOperation(sender.ToString().Substring(35));
        }

        /* 
         * numberButtonClick - Handles user's number input via buttons
         */
        private void numberButtonClick(object sender, EventArgs e)
        {
            enterNumber(sender.ToString().Substring(35));
        }

        /*
         * keyBoardInput - Handles user's input via keyboard.
         */
        private void keyBoardInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                enterNumber(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '.')
            {
                enterNumber(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '\b')
            {
                enterNumber("Backspace");
            }
            else if (e.KeyChar == '=' || e.KeyChar == '+' || e.KeyChar == '-')
            {
                enterOperation(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '/')
            {
                enterOperation("÷");
            }
            else if (e.KeyChar == '*')
            {
                enterOperation("×");
            }
        }


        /*************************
         * textBoxPad Operations *
         *************************/

        private void buttonSeperator_Click(object sender, EventArgs e)
        {
            textBoxPad.Text = textBoxPad.Text + "=========================" + Environment.NewLine;
        }

        private void clearPad(object sender, EventArgs e)
        {
            textBoxPad.Text = "";
        }

        private void savePad(object sender, EventArgs e)
        {
            if (saveFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialogBox.FileName, false, System.Text.Encoding.UTF8);
                sw.Write(textBoxPad.Text);
                sw.Flush();
                sw.Close();
            }
        }

        /* 
         * updatePad - Updateds the textBoxPad for two parameter operations
         * @param operation, 1st number, 2nd number, result
         */
        private void updatePad(String operation, double x, double y, double result)
        {
            String line;

            if (operation == "xⁿ")
            {
                line = x.ToString() + " ^ " + y.ToString() + " = " + result.ToString();
            }
            else
            {
                line = x.ToString() + " " + operation + " " + y.ToString() + " = " + result.ToString();
            }

            textBoxPad.Text = textBoxPad.Text + line + Environment.NewLine;
        }

        /*
         * updatePad - Updateds the textBoxPad for single parameter operations
         * @param operation, number, result
         */
        private void updatePad(String operation, double x, double result)
        {
            String line;

            if (operation.Length == 2)
            {
                line = x.ToString() + operation.Substring(1) + " = " + result.ToString();
            }
            else if (operation == "√")
            {
                line = "sqrt(" + x.ToString() + ") = " + result.ToString();
            }
            else
            {
                line = operation + x.ToString() + " = " + result.ToString();
            }

            textBoxPad.Text = textBoxPad.Text + line + Environment.NewLine;
        }

        /*
         * updatePad - Updateds the textBoxPad for memory operations
         * @param operation, number
         */
        private void updatePad(double m)
        {
            textBoxPad.Text = textBoxPad.Text + "M = " + m.ToString() + Environment.NewLine;
        }

        /*************************
         * Status Bar Operations *
         *************************/

        private void toolStripDropDownNumbers_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBoxDisplay.Text = e.ClickedItem.Text;
            operationPressed = true;
        }
        
        /***********************
         * Menu Bar Operations *
         ***********************/

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.openURL("http://calculator.googlecode.com/");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilities.openURL("http://code.google.com/p/calculator/wiki/OnlineHelp");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void copToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBoxDisplay.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String value = (String)Clipboard.GetDataObject().GetData(DataFormats.Text);
            double temp;                        // For TryParse
            if (Double.TryParse(value, out temp))
            {
                textBoxDisplay.Text = value;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            operationPressed = true;
        }
    }
}