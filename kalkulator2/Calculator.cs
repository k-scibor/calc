﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator2
{
    public class Calculator

    {

        public double Add(double a, double b) => a + b;
        public double Substract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)

        {

            if (b == 0)

                throw new DivideByZeroException();

            return a / b;

        }





    }
}
