using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator.NET
{
    /*
     * MainForm - The main GUI.s
     * @author: Kesara Nanayakkara Rathnayake < kesara@bcs.org >
     * Copyright (C) 2007 Kesara Nanayakkara Rathnayake
     */
    public partial class MainForm : Form
    {

        private double x;                       // First number
        private double y;                       // Second number
        private double m;                       // Number in memory
        private double result;                  // Result
        private string operation;               // Activated operation
        private bool withInCalculation;         // True if two prameter operation is activated.
        private bool operationPressed;          // True if operater has been pressed.
        private bool singleParameterOperation;  // True if operation is a single parameter operation.
        private Calculations calculation;       // Instance of Calculation Class

        /*
         * MainForm - MainForm Constructor
         * Intialize GUI Components and calculator variables.
         */
        public MainForm()
        {
            InitializeComponent();

            /* Variable Intialization */
            x = 0;
            y = 0;
            m = 0;
            result = 0;
            operation = "";
            withInCalculation = false;
            operationPressed = true;            // So the display clears every thing when number pressed.
            singleParameterOperation = false;
            calculation = new Calculations();
        }

        /* 
         * operationClick - Handles activated operations
         * Invoked when any operater is pressed.
         */
        private void operationClick(object sender, EventArgs e)
        {
            String currentOperation = sender.ToString().Substring(35);

            if (withInCalculation)
            {
                y = Double.Parse(textBoxDisplay.Text);
                toolStripDropDownNumbers.DropDown.Items.Add(y.ToString());

                switch (operation)
                {
                    case "+" :
                        result = calculation.addition(x, y);
                        break;
                    case "-" :
                        result = calculation.subtraction(x, y);
                        break;
                    case "×" :
                        result = calculation.multiplication(x, y);
                        break;
                    case "÷" :
                        result = calculation.division(x, y);
                        break;
                    case "xⁿ":
                        result = calculation.power(x, y);
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
                case "x!" :
                    result = calculation.factorial(x);
                    singleParameterOperation = true;
                    break;
                case "√" :
                    result = calculation.squareRoot(x);
                    singleParameterOperation = true;
                    break;
                case "x²":
                    result = calculation.square(x);
                    singleParameterOperation = true;
                    break;
                case "x³":
                    result = calculation.cube(x);
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
         * numberPress - Handles user's number input
         * Inovocked when a number, period or plus-minus is pressed.
         */
        private void numberPress(object sender, EventArgs e)
        {
            String number = sender.ToString().Substring(35);

            if (number == "±")
            {
                textBoxDisplay.Text = calculation.plusMinus(Double.Parse(textBoxDisplay.Text)).ToString();
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
            m = calculation.addition(m, Double.Parse(textBoxDisplay.Text));
            memoryStatus.Text = "M = " + m.ToString();
            updatePad(m);
            operationPressed = true;
        }

        private void buttonMemorySubtraction_Click(object sender, EventArgs e)
        {
            m = calculation.subtraction(m, Double.Parse(textBoxDisplay.Text));
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
            String url = @"http://calculator.googlecode.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String url = @"http://code.google.com/p/calculator/wiki/OnlineHelp";
            System.Diagnostics.Process.Start(url);
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

        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}