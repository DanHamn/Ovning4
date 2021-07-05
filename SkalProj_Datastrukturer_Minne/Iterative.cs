using System;

namespace SkalProj_Datastrukturer_Minne
{
    internal class Iterative
    {
        internal static void CheckIterative()
        {
            /*
             * Utgå ifrån era nyvunna kunskaper om iteration, rekursion och minneshantering. Vilken av ovanstående funktioner är mest minnesvänlig och varför?
             *      Iteration är nog den mest minnesvänliga metoden då rekursion stackar flera instanser av sig själv innan den börjar lösa problemet. Iteration gör flera loopar men bara en instans av loopen är igång vid varje givet tillfälle.
             */
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("'1': Iterative method that finds the n:te even number.");
                Console.WriteLine("'0': Exit to main.");
                char input = Console.ReadLine()[0];
                switch (input)
                {
                    case '1':
                        Console.WriteLine("Input a integer number");
                        int.TryParse(Console.ReadLine(), out int num);
                        int result = IterativeEven(num);
                        Console.WriteLine(result);
                        break;
                    case '0':
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }


        private static int IterativeEven(int n)
        {
            if (n == 2)
            {
                return 2;
            }
            int result = 2;
            for (int i = 1; i < n; i++)
            {
                result += 2;
            }
            return result;
        }
    }
}