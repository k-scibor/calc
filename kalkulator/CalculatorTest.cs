using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



[TestClass]

public class CalculatorTest

{

    [TestMethod]

    public void Add_ReturnsCorrectResult()

    {

        var calculator = new Calculator();

        double result = calculator.Add(2, 3);

        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(5, result);

    }



    [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]

    public void Divide_ByZero_ThrowsException()

    {

        var calculator = new Calculator();

        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(5, 0));

    }

} 

