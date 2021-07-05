using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    public class Stack
    {

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        public static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            /*Frågor:
             * 1. ...Varför är det inte så smart att använda en stack i det här fallet?
             *      På grund av att det blir bakvänt med hur man förväntar sig att en kö ska fungera; att den som ställer sig sist blir först betjänad.
             */

            //Prompt input from user
            Console.WriteLine("Enter input for the stack.\n" +
                "Start with '+' to push and just '-' to pop.\n" +
                "Start with '<' to start ReverseText().\n" +
                "Enter '0' to exit");

            //Creates the stack, and the bool used to quite the while loop
            Stack<string> stack = new Stack<string>();
            bool exit = false;

            while (exit == false)
            {
                string input = Console.ReadLine();

                switch (input[0])
                {
                    case '+':
                        stack.Push(input[1..]); //Push 'value' to list
                        WriteStack(stack);
                        break;

                    case '-':
                        stack.Pop(); //Pop the newest element from list
                        WriteStack(stack);
                        break;
                    case '<':
                        ReverseText(input[1..]);
                        break;

                    case '0': //Exits back to Main()
                        exit = true;
                        break;

                    default: //Handles incorrect input
                        Console.WriteLine("Please start the string with either '+' or '-', or use '0' to exit");
                        break;
                }
            }
        }
        private static void ReverseText(string value)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char character in value)
            {
                stack.Push(character);
            }
            Console.WriteLine(String.Join("", stack.ToArray()));
            Console.WriteLine("Give new input with '+', '-' or '<', or '0' to exit");
        }


        private static void WriteStack(Stack<string> stack)
        {
            //This code provides the output for ExamineStack()
            Console.WriteLine("\tThe Queue contains:");
            Console.WriteLine("\t" + String.Join(", ", stack.ToArray()));
            Console.WriteLine("Give new input starting with '+', '-' or '<', or '0' to exit");
        }
    }
}