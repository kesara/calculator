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
    public partial class UnitConversionForm : Form
    {
        private double number;

        public UnitConversionForm(double number)
        {
            this.number = number;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
