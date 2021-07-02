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
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
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

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //Todo: Add answeres to questions


            //Prompt input from user
            Console.WriteLine("Enter input for the list.\n" +
                "Start with '+' to add and '-' to remove.\n" +
                "Enter '0' to exit");

            List<string> theList = new List<string>(); //Creates the list
            bool exit = false; //Creates the bool for stopping the while loop

            while (exit == false)
            {
                string input = Console.ReadLine();

                switch (input[0]) //Uses the first char in input for the switch
                {
                    case '+':
                        theList.Add(input[1..]); //Adds the input except for the fist character to the list
                        WriteList(theList);
                        break;

                    case '-':
                        theList.Remove(input[1..]); //Removes the input except for the fist character from the list
                        WriteList(theList);
                        break;

                    case '0':

                        exit = true; //Exits back to Main()
                        break;

                    default: //Handles incorrect input
                        Console.WriteLine("Please start the string with either '+' or '-', or use '0' to exit");
                        break;
                }
            }
        }

        private static void WriteList(List<string> theList)
        {
            //This code provides the output for ExamineList()
            Console.WriteLine("\tThe List contains:");
            Console.WriteLine("\t" + String.Join(", ", theList.ToArray()));
            Console.WriteLine($"\tThe number of elements in the list is: {theList.Count}");
            Console.WriteLine($"\tThe capacity of the list is: {theList.Capacity}");
            Console.WriteLine("Give new input with '+' or '-', or '0' to exit");
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            //Prompt input from user
            Console.WriteLine("Enter input for the queue.\n" +
                "Start with '+' to Enqueue and just '-' to Dequeue.\n" +
                "Enter '0' to exit");

            //Creates the queue and the bool used to quite the while loop
            Queue<string> queue = new Queue<string>();
            bool exit = false;

            while (exit == false)
            {
                string input = Console.ReadLine();
                //Puts the first character into 'nav' to be used in the switch
                //Puts the input except for the fist character into 'value' as a string

                switch (input[0]) //Uses the first char in input for the switch
                {
                    case '+':
                        queue.Enqueue(input[1..]); //Enqueues the input except for the fist character to the queue
                        WriteQueue(queue);
                        break;

                    case '-':
                        queue.Dequeue(); //Dequeues the oldest element enqueued to the queue
                        WriteQueue(queue);
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

        private static void WriteQueue(Queue<string> queue)
        {
            //This code provides the output for ExamineQueue()
            Console.WriteLine("\tThe Queue contains:");
            Console.WriteLine("\t" + String.Join(", ", queue.ToArray()));
            Console.WriteLine("Give new input with '+' or '-', or '0' to exit");
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
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


        private static void WriteStack(Stack<string> stack)
        {
            //This code provides the output for ExamineStack()
            Console.WriteLine("\tThe Queue contains:");
            Console.WriteLine("\t" + String.Join(", ", stack.ToArray()));
            Console.WriteLine("Give new input starting with '+', '-' or '<', or '0' to exit");
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


        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //Prompt input from user
            Console.WriteLine("Enter input with some paranthesises to check if it is well-shaped.");
            string input = Console.ReadLine();
            (bool check, Stack<char> stack, char character) = Check(input);

            if (check)
            {
                Console.WriteLine("The string was well-formed");
            }
            else
            {
                if (character !=' ')
                {
                    Console.WriteLine($"The string was not well-formed. There was a {character} missplaced");
                }
                else
                {
                    Console.WriteLine($"The string was not well-formed. There was some additional {String.Join(", ", stack.ToArray())}");
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
    }
}

