using System;
using System.Text;

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
    class Calculations
    {
        public static double addition(double x, double y)
        {
            return x + y;
        }
        
        public static double subtraction(double x, double y)
        {
            return x - y;
        }
        
        public static double multiplication(double x, double y)
        {
            return x * y;
        }
        
        public static double division(double x, double y)
        {
            return x / y;
        }

        public static double power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        private static double calculateFactorial(double x)
        {
            if (x == 1 || x == 0)
            {
                return 1;
            }
            else
            {
                return x * calculateFactorial(x - 1);
            }
        }

        public static double factorial(double x)
        {
            if (x < 0 || Double.IsNaN(x))
            {
                return Double.NaN;
            }
            else if (x <= 170)
            {
                return calculateFactorial(x);
            }
            else
            {
                return Double.PositiveInfinity;
            }
        }

        public static double plusMinus(double x)
        {
            return multiplication(x, -1);
        }

        public static double squareRoot(double x)
        {
            return power(x, 0.5);
        }

        public static double square(double x)
        {
            return power(x, 2);
        }

        public static double cube(double x)
        {
            return power(x, 3);
        }
    }
}
