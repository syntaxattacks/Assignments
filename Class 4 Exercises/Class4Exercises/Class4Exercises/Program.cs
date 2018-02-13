using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 99;

            if (age < 16)
            {
                Console.WriteLine("You can't drive!");
            }

            else if (age > 15 && age < 18)
            {
                Console.WriteLine("You can drive but not vote");
            }

            else if (age > 17 && age < 25)
            {
                Console.WriteLine("You can vote but not rent a car");
            }

            else if (age == 40)
            {
                Console.WriteLine("You're over the hill!");
            }

            else if (age > 79)
            {
                Console.WriteLine("You can't eat solid food anymore!");
            }

            else
            {
                Console.WriteLine("You can do whatever you like");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.Read();

        }

        public getAge(int age)
        {
            
        }

    }
}
