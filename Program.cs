using System;

namespace application
{
    class Program
    {
       
        static void Main(string[] args)
       {
        
           try
           {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Input the First Number");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Input the Second Number");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Input the operation type");                
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine("The final result is  {0}", result);

           }
           catch (Exception ex)
           {
                Console.WriteLine(ex.Message);
            //    throw;
           }
           
        }
    }
}
