using System;

namespace InClass_1_22_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // taking user input
            Console.WriteLine("Please enter an integer value between 1 and 20");

            // exceptional handling with try catch block
            try
            {
                // reading user input from the console
                string input = Console.ReadLine();
                int variable = int.Parse(input); // parsing user input

                // validating a condition that user input is between 0 and 5
                if (variable > 0 && variable <= 5)
                {
                    Console.WriteLine("\nExecuting the For loop!");
                    Console.WriteLine("\nThe for loop executes " + variable + " times");

                    // For loop begins
                    for (int i = 0; i <= variable; i++)
                    {
                        // Displaying the value of i till it reaches variable
                        Console.WriteLine("The value of i is " + i);
                    } // end of for loop

                } // end of if (variable > 0 && variable <= 5)

                //  else if block if variable is between 6 and 10
                else if (variable > 5 && variable <= 10)
                {
                    // while j is greater than 0 execute this while loop
                    int j = variable;
                    while ( j > 0)
                    {
                        // displaying the ouput to console
                        Console.WriteLine("The value of j is: " + j);
                        j = j - 1; // decrementing the value of j

                    } // end of while loop
                    
                } // end of else if (variable > 5 && variable <= 10)

                // else statement if the variable is between 10 and 20
                else if (variable > 10 && variable <= 20)
                {
                    // executing the do while loop
                    int k = variable;
                    do
                    {
                        // displaying the ouput to console
                        Console.WriteLine("The value of k is " + k);
                        k = k - 1; // decrementing the value of k
                    } while (k > 0); // testing the condition after 1 execution of do block
                    // end of do while

                } // end of else if (variable > 10 && variable <= 20)

                // else statement
                else
                {
                    // valid integer message
                    Console.WriteLine("Please enter an interger between 0 and 20 next time");
                    
                } // end of else                

                //taking user input to exit the program
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } // end of try

            // This block is executed in case there is any issue within the try block, else this block is not executed
            catch
            {
                Console.WriteLine("Please enter valid input next time");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } // end of catch
            
        } // end of main
    } // end of class
} // end of namespace
