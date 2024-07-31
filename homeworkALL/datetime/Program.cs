namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            DateTime newDateTimeValue = dateTime.AddYears(5);

            Console.WriteLine();
        }
    }
}
