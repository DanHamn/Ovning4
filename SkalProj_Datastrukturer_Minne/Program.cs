using System;
using System.Collections.Generic;

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

            //Prompt input from user
            Console.WriteLine("Enter input for the list.\n" +
                "Start with '+' to add and '-' to remove.\n" +
                "Enter '0' to exit");

            //Creates the list and the bool used to quite the while loop
            List<string> theList = new List<string>();
            bool exit = false;

            while (exit == false)
            {
                string input = Console.ReadLine();
                //Puts the first character into 'nav' to be used in the switch
                char nav = input[0];
                //Puts the input except for the fist character into 'value' as a string
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        //Adds 'value' to list
                        theList.Add(value);
                        WriteList(theList);
                        break;

                    case '-':
                        //Remove 'value' from list
                        theList.Remove(value);
                        WriteList(theList);
                        break;

                    case '0':
                        //Exits back to Main()
                        exit = true;
                        break;

                    default:
                        //Handles incorrect input 
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
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

