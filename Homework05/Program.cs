namespace Homework05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write(" Enter number: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write(" Enter number: ");
            int.TryParse(Console.ReadLine(), out b);

            for (int i = a; i < b; i++)
            {
                if(i % 2 != 0 && i % i == 0)
                {
                    Console.Write($" " + i);
                }
            }
        }
    }
}