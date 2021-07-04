using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    internal class List
    {
        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        public void ExamineList()
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

            /* Frågor
             * 2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
             *      När listan överskrider sin gamla kapicitet.
             * 3. Med hur mycket ökar kapaciteten?
             *      Den dubbleras
             * 4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
             *      Troligen mer tidskrävande process, så den försöks köras mera sällan.
             * 5. Minskar kapaciteten när element tas bort ur listan?
             *      Nej.
             * 6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
             *      När man på förhand vet storleken den ska ha eller att man kan på bestämma storleken innan skapandet.
             */


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
            //This method provides the output for ExamineList()
            Console.WriteLine("\tThe List contains:");
            Console.WriteLine("\t" + String.Join(", ", theList.ToArray()));
            Console.WriteLine($"\tThe number of elements in the list is: {theList.Count}");
            Console.WriteLine($"\tThe capacity of the list is: {theList.Capacity}");
            Console.WriteLine("Give new input with '+' or '-', or '0' to exit");
        }

    }
}