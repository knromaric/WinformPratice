namespace Calculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result; 
            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "-":
                case "soustraction":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "*":
                case "multiplication":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "/":
                case "division":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new System.InvalidOperationException("Specified operation is not recognized");

            }

            return result; 
        }
    }
}