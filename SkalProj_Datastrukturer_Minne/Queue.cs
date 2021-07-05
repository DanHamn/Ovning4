using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    public class Queue
    {
        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        public static void ExamineQueue()
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
    }
}