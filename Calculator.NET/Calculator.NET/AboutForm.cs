using System;
using System.Linq;
using System.Reflection;
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
    partial class AboutForm : Form
    {
        /*
         * AboutForm - AboutForm Constructor
         */
        public AboutForm()
        {
            InitializeComponent();
            labelProgramVersion.Text = String.Format("Version {0}", AssemblyVersion);
        }

        /*
         * buttonOk_Click - Handles Ok button click
         */
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Identifies the version of the program */
        #region Assembly Attribute Accessors
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        #endregion

        /*
         * linkLabelHomePage_LinkClicked - Directs to official home page.
         */
        private void linkLabelHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.openURL("http://calculator.googlecode.com/");
        }
    }
}
