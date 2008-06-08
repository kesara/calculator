using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator.NET
{
    /*
     * AboutForm - The about form
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
