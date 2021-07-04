using System;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Pharanthesis
    {
        public void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //Prompt input from user
            Console.WriteLine("Enter input with some paranthesises to check if it is well-shaped.");
            bool exit = false;
            while (exit == false)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        exit = true;
                        break;
                    default:
                        (bool check, Stack<char> stack, char character) = Check(input);
                        WriteParanthesisCheck(input, check, stack, character);
                        break;
                }

            }
        }
        private static (bool, Stack<char>, char character) Check(string input)
        {
            Dictionary<char, char> paranthisDict = new Dictionary<char, char>
            { { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            Stack<char> stackParanthis = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];
                if (character == '(' || character == '[' || character == '{')
                {
                    stackParanthis.Push(character);
                }
                else if (character == ')' || character == ']' || character == '}')
                {
                    if (stackParanthis.Pop() != paranthisDict[character])
                    {
                        return (false, stackParanthis, character);

                    }
                }
            }
            if (stackParanthis.Any())
            {
                return (false, stackParanthis, ' ');
            }
            else
            {
                return (true, stackParanthis, ' ');

            }
        }
        private static void WriteParanthesisCheck(string input, bool check, Stack<char> stack, char character)
        {
            if (check)
            {
                Console.WriteLine($"The \"{input}\" string was well-formed");
            }
            else
            {
                if (character != ' ')
                {
                    Console.WriteLine($"The \"{input}\" string was not well-formed. There was a {character} missplaced or a missing paranthis needed to ckose the string.");
                }
                else
                {
                    Console.WriteLine($"The \"{input}\" string was not well-formed. There was some additional {String.Join(", ", stack.ToArray())}");
                }

            }
        }

    }
}
