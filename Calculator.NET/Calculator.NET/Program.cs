using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator.NET
{
    /*
     * Program - The main class
     * @author: Kesara Nanayakkara Rathnayake < kesara@bcs.org >
     * Copyright (C) 2007 Kesara Nanayakkara Rathnayake
     */
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
