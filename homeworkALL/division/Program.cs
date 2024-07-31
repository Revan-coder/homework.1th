namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 4.5m;
            decimal num2 = 1.5m;
            decimal sum = Add(num1, num2);

            Console.WriteLine(sum);

        }
            static decimal Add(decimal firstNumber, decimal secondNumber)
        {
            decimal result = 0;
            result = firstNumber / secondNumber;
            return result;
        }
        
    }
}
