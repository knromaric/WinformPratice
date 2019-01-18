using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            try
            {
                Console.Write("Enter the first number: ");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Enter the Second number: ");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Enter The operator: ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine($"The result is {result}");
            }
            catch (Exception ex)
            {
                //TODO: Start logging exception.
                Console.WriteLine(ex.Message); ;
            }
           
        }
    }
}
