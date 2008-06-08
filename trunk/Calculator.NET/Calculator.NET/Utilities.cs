using System;
using System.Threading;

namespace Calculator.NET
{
    /*
     * Calculations - Perform claculations.
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

    class Utilities
    {
        /*
         * openURL - Get the url, and creats browser thread.
         */
        public static void openURL(string url)
        {
            Thread urlTread = new Thread(new ParameterizedThreadStart(openBrowser));
            urlTread.Start(url);
        }

        /*
         * openBrowser - Open the default web browser.
         */
        private static void openBrowser(object url)
        {
            System.Diagnostics.Process.Start((string)url);
        }
    }
}
