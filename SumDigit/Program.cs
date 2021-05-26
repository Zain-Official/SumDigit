using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number: ");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(num % 10 + num / 10);

            Console.WriteLine("\n************2nd Method******************\n");

            int sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);


            



        }
    }
}
