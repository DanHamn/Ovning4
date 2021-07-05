using System;

namespace SkalProj_Datastrukturer_Minne
{
    internal class Recursive
    {
        internal static void CheckRecursive()
        {
            bool exit = false;
            while (exit==false)
            {
            Console.WriteLine("'1': Recursive method that finds the n:te even number.");
            Console.WriteLine("'2': Calculates numbers in the fibonaccifrekvens.");
            Console.WriteLine("'0': Exit to main.");
            char input = Console.ReadLine()[0];
                switch (input)
                {
                    case '1':
                        Console.WriteLine("Input a integer number");
                        int.TryParse(Console.ReadLine(),out int num);
                        int result = RecursiveEven(num);
                        Console.WriteLine(result);
                        break;
                    case '2':
                        Console.WriteLine("Input a integer number");
                        int.TryParse(Console.ReadLine(), out int num2);
                        int result2 = FibonacciNumber(num2);
                        Console.WriteLine(result2);
                        break;
                    case '0':
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private static int FibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;
            }
            return FibonacciNumber(n - 1) + FibonacciNumber(n-2);
        }

        private static int RecursiveEven(int n)
        {
            if (n==0)
            {
                return 0;
            }
            return RecursiveEven(n - 1) + 2;
        }
    }
}