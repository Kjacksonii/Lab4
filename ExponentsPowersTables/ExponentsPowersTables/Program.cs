using System;

namespace ExponentsPowersTables
{
    class Program
    {
        static void Main(string[] args)
        {
            int foo;
            bool userContinues = false;

            Console.WriteLine("Enter an integer: ");
            foo = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= foo; i++)
            {

                Console.WriteLine(i + "\t" + i * i + "\t" + i * i * i);


            }
            Console.WriteLine("would you like to continue? y/n");
            string userResponse = Console.ReadLine();
            
            if (userResponse == "y")
            {
                userContinues = true;
                while (userContinues)
                {
                    Console.WriteLine("Enter an integer: ");
                    foo = Convert.ToInt32(Console.ReadLine());


                    for (int i = 1; i <= foo; i++)
                    {

                        Console.WriteLine(i + "\t" + i * i + "\t" + i * i * i);


                    }

                    Console.WriteLine("would you like to continue? y/n");
                    userResponse = Console.ReadLine();
                    if (userResponse == "n")
                    {
                        userContinues = false;
                    }
                }
            }

        }
    }
}



