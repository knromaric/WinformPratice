using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";

            double result = _inputConverter.ConvertInputToNumeric(inputNumber);

            Assert.AreEqual(5, result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidInputIntoDouble()
        {
            string inputNumber = "djd";
            double result = _inputConverter.ConvertInputToNumeric(inputNumber);
        }
    }
}
