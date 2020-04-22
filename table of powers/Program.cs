using System;

namespace table_of_powers
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine($"Learn your squares and cubes! \n");
            
            bool goOn = true;
            while (goOn == true)
            {
                int userNumber = ReadIntergers("Please enter a number:");
                               
                
                Console.WriteLine("Number \t Squared \t Cubed");
                Console.WriteLine("===== \t ======= \t =====");

                for (int i = 1; i <= userNumber; i++)
                {
                    int numSquared = i * i;
                    int numCubed = i * i * i;
                    Console.WriteLine($"{i} \t {numSquared} \t\t {numCubed}");
                }
                bool keepAsking = true;
                while (keepAsking)
                {
                    Console.WriteLine("Do you want to continue? y or n");
                    string decision = Console.ReadLine().ToLower();
                    if (decision == "y")
                    {
                        goOn = true;
                        keepAsking = false;
                        continue;
                    }
                    else if(decision == "n")
                    {
                        goOn = false;
                        keepAsking = false;
                        Console.WriteLine("Exiting");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again!");
                    }
                }


            }
        }

        public static int ReadIntergers(string message)
        {
            int value;
            while (true)
            {
                Console.WriteLine(message);
               
                bool worked = int.TryParse(Console.ReadLine(), out value);
                if (worked != true)
                {
                    Console.WriteLine("Not a valid input");
                }
                else
                {
                    break;
                }
                
            }
            return value;
        }
    }
}
