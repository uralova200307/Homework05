namespace Homework05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int Sum = 0;

            Console.Write(" Enter number: ");
            int.TryParse(Console.ReadLine(), out number);

            while (number > 0)
            {
                Sum += number % 10;
                number = number / 10;
            }

            Console.WriteLine(Sum);
        }
    }
}