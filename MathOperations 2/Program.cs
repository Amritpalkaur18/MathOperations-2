
using System;

namespace MathOperationApp
{
   
    public class MathOperations
    {
       
        public void PerformOperation(int firstNumber, int secondNumber)
        {
           
            int result = firstNumber * 2;

           
            Console.WriteLine($"The result of the math operation on {firstNumber} is {result}");
            Console.WriteLine($"The second integer is {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            MathOperations mathOps = new MathOperations();

           
            mathOps.PerformOperation(5, 10);

           
            mathOps.PerformOperation(firstNumber: 8, secondNumber: 15);

            
            Console.ReadLine();
        }
    }
}
