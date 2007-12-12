using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.NET
{
    /*
     * Calculations - Perform claculations.
     * @author: Kesara Nanayakkara Rathnayake < kesara@bcs.org >
     * Copyright (C) 2007 Kesara Nanayakkara Rathnayake
     */
    class Calculations
    {
        public double addition(double x, double y)
        {
            return x + y;
        }
        
        public double subtraction(double x, double y)
        {
            return x - y;
        }
        
        public double multiplication(double x, double y)
        {
            return x * y;
        }
        
        public double division(double x, double y)
        {
            return x / y;
        }

        public double power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        private double calculateFactorial(double x)
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

        public double factorial(double x)
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

        public double plusMinus(double x)
        {
            return multiplication(x, -1);
        }

        public double squareRoot(double x)
        {
            return power(x, 0.5);
        }

        public double square(double x)
        {
            return power(x, 2);
        }

        public double cube(double x)
        {
            return power(x, 3);
        }
    }
}
