using System.ComponentModel;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
            // Collection
         {                            
             double num1 = 4.5;
             double num2 = 7.5;
             double sum = Add(num1, num2);

             Console.WriteLine(sum);
         }

         static double Add(double firstNumber, double secondNumber)
         {
             double result = 0;
             result = firstNumber + secondNumber;
             return result;


         }
        
     }

}
