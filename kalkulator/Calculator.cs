﻿

public class Calculator

{

    public double Add(double a, double b) => a + b;

    public double Divide(double a, double b)

    {

        if (b == 0)

            throw new DivideByZeroException();

        return a / b;

    }





} 

