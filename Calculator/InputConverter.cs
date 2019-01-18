namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            bool isConverted = double.TryParse(argTextInput, out double convertedValue);
            if (!isConverted)
            {
                throw new System.ArgumentException("Expected a numeric value");
            }

            return convertedValue;
        }
    }
}