using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmCalculator.Core.Calculators;

namespace MvvmCalculatorTests.Core.Calculators
{
    [TestClass()]
    public class ExpressionCalculatorTests
    {
        [TestMethod()]
        public void ShouldCalculate()
        {
            var expression = "2+2";
            var calculator = new ExpressionCalculator();
            var value = calculator.Calculate(expression);
            Assert.AreEqual(4, value);
        }
    }
}