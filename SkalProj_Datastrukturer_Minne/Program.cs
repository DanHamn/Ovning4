using System;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            /* Frågor:
            * 1.Hur fungerar stacken och heapen ? Förklara gärna med exempel eller skiss på dess grundläggande funktion
            *       Heapen har direkt tillgång till allt som ligger på den. Det gör saker lättillgängliga, men kräver mycket mera minneplats och den saknar exekveringsordningen.
            *       Stacken å andra sidan har full koll på exekveringsordningen och kaserar metoderna allteftersom dem körs.
            * 2.Vad är Value Types repsektive Reference Types och vad skiljer dem åt?
            *       Value Types är variabler som innehåller värdet som dem är anskriva, medan Reference Types är variabler som innehåller en referens till en specifik del av minnet.
            * 3.Följande metoder(se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?
            *       Det är på grund av att dem är olika sortes Types.
            *       I första fallet så jobbar vi med Value Types: X skapas och värdet sätts till 3. Sedan skapas y och och värdet på y sätts till samma som x. Därefter ändrar vi värdet på y, men x är en separat variabel och behåller sitt värde på 3.
            *       I andra fallet så jobbar vi med Reference Types: Vi skapar X och säger att MyValue delen är lika med 3. Sedan kopierar vi X i Y, så att de två referens typerna pekar på samma minnesplats. Nu när vi skriver y.MyValue så pekar vi på samma ställe som x.MyValue, och värdet ändras till en 4.
                */

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        List.ExamineList();
                        break;
                    case '2':
                        Queue.ExamineQueue();
                        break;
                    case '3':
                        Stack.ExamineStack();
                        break;
                    case '4':
                        Pharanthesis.CheckParanthesis();
                        break;
                    case '5':
                        Recursive.CheckRecursive();
                        break;
                    /*
                 * Extend the menu to include the recursive 
                 * and iterative exercises.
                 */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

    }


}

