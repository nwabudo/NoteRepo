using System;

namespace application
{

    public class InputConverter

    {
         public double ConvertInputToNumeric(string TextInput)
         {
             double convertedNumber;
             bool isConverted = double.TryParse(TextInput, out convertedNumber);
             if (!isConverted) throw new ArgumentException("Expected a Numeric Value");
             return convertedNumber;
         }
    }
}