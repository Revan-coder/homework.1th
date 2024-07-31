namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = 4500;
            long num2 = 3789;
            long sum = Add(num1, num2);

            Console.WriteLine(sum);


        }
        
            static long Add(long firstNumber, long secondNumber)
        {
            long result = 0;
            result = firstNumber * secondNumber;
            return result;

        }

        
    }
}
