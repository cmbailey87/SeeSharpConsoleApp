// A Exercise! Time! program in C#.
//using system...this is the namespace for the part of program
// using system instead of typing system.consol.write.
using System;
namespace ExperciseProgram
{
    class Program
    {
        static void Main()
        {
            //read input from user line for time
            //prompt for first and last name
            //userName
            string userName;
            Console.Write("what is your Name: ");            
            userName = Console.ReadLine();   
            //lastname
            //Console.Write("what is your Last Name: ");
            //string lastName = Console.ReadLine();
            //initiallize the variable


            //starting at zero
            double runningTotal = 0;

            //boolean condition for while loop.
            //set to true to keep running
            //will set to false when user is done running.

            bool keepRunning = true;

            while (keepRunning)
            {
                // prompt for minute exercies
                Console.Write("Enter how many minutes you have exercised or type \"quit\" to exit: ");
                // add minutes to total
                //convert string for entry Time to and In
                string entryTime = Console.ReadLine();

                

                //if statement for the string entryTime to detect if user typed quit.
                if (entryTime.ToLower() == "quit" )
                {
                    keepRunning = false;
                }
                else
                {
                    //used try to catch any input that didnt match the double minutes when parsing entryTime
                    try
                    {
                        double minutes = double.Parse(entryTime);


                        //adding new minute of eexercise to the running total
                        runningTotal = runningTotal + minutes;

                        // display minutes to screen
                        // repeat until quit


                        //creates a string literal 
                        if (minutes <= 0)
                        {
                            Console.WriteLine("invalid input fool....try again");
                            continue;
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing eh?");
                        }
                        else if (minutes <= 25)
                        {
                            Console.WriteLine("Not Bad Champ...Not Bad");
                        }
                        else if (minutes <= 45)
                        {
                            Console.WriteLine("You tryna make me break a sweat???");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You bestin home...");
                        }
                        else
                        {
                            Console.WriteLine("I guess you are going...Super Saiyan...");
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("What you typed in was hog wash BISH!! Try again");
                        continue;
                    }
                        
                }

            }

            Console.WriteLine("Good job " + userName +  ", You have worked out for " + runningTotal + " minutes !!!" );

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}


