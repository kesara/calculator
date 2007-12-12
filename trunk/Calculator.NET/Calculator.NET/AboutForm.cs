using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Calculator.NET
{
    /*
     * AboutForm - The about form
     * @author: Kesara Nanayakkara Rathnayake < kesara@bcs.org >
     * Copyright (C) 2007 Kesara Nanayakkara Rathnayake
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

        private void linkLabelHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String url = @"http://calculator.googlecode.com/";
            System.Diagnostics.Process.Start(url);
        }
    }
}
