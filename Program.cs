/*
 * Author: Jessica Beckford
 * Date 1/26/2021
*/ 
using System;

namespace Deliverable2_JBeckford
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for grade expected
            Console.WriteLine("What grade do you expect to get in this course? (ISM4300). Please input a numerical value.");

            try
            {
                // Gather user input 
                string input = Console.ReadLine();
                int grade = int.Parse(input);

              

                if((grade >= 98) && (grade <= 100))
                {
                    Console.WriteLine("You've got an A+!");
                    Console.ReadKey(true);
                }
                else if((grade >= 92 ) && (grade <= 97))
                {
                    Console.WriteLine("You've got an A!");
                    Console.ReadKey(true);
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("You've got an A-!");
                    Console.ReadKey(true);
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("You've got a B+");
                    Console.ReadKey(true);
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("You've got a B");
                    Console.ReadKey(true);
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("You've got a B-");
                    Console.ReadKey(true);
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("You've got a C+");
                    Console.ReadKey(true);
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("You've got a C");
                    Console.ReadKey(true);
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("You've got a C-");
                    Console.ReadKey(true);
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("You've got a D+");
                    Console.ReadKey(true);
                }
                else if ((grade > 62) && (grade < 67))
                {
                    Console.WriteLine("You've got a D");
                    Console.ReadKey(true);
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    Console.WriteLine("You've got a D-");
                    Console.ReadKey(true);
                }
                else if (grade < 60) 
                {
                    Console.WriteLine("You've got a F");
                    Console.ReadKey(true);
                }

            }// end of try
            catch
            {
                Console.WriteLine("Please use an integer data type to determine your grade");
                Console.ReadKey(true);
            }//end of catch 
        }
    }
}
