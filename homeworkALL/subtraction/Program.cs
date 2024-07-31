namespace subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 7.8f;
            float num2 = 5.2f;
            float sum = Add(num1, num2);

            Console.WriteLine(sum);



        }

        
            static float Add(float firstNumber , float secondNumber)
            {
                float result = 0;
                result = firstNumber - secondNumber;
                return result;

            }
        
    }
}
