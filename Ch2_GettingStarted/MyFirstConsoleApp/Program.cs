using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    OperatorExamples();
            //}

            //private static void OperatorExamples()
            //{
            //    // This statement declares a variable and sets it to 3
            //    int width = 3;
            //    // The ++ operator increments a variable (adds 1 to it)
            //    width++;

            //    // Declare two more int variables to hold numbers and
            //    // use the + and * operators to add and multiply values
            //    int height = 2 + 4;
            //    int area = width * height;
            //    Console.WriteLine(area);



            //    while (area < 20)
            //    {
            //        height++;
            //        area = width * height;
            //    }

            //    do
            //    {
            //        width--;
            //        area = width * height;
            //    } while (area > 25);



            //    // The next two statements declare string variables
            //    // and use + to concatenate them (join them together)
            //    string result = "The area";
            //    result = result + " is " + area;
            //    Console.WriteLine(result);

            //    // A Boolean variable is either true or false
            //    bool truthValue = true;
            //    Console.WriteLine(truthValue);



            //    //Need to add this code to keep console window open
            //    //     from https://stackoverflow.com/questions/73369665/visual-studio-2022-console-closes-after-running-debugging-code
            //    // Wait for the user to press a key before exiting
            //    Console.WriteLine("Press any key to exit...");
            //    Console.ReadKey();


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //// Loops Exercise from page 65
            //int p = 2;
            //int whileCount = 0;
            //int forCount = 0;
            //for (int q = 2; q < 32; q = q * 2)
            //{
            //    while (p < q)
            //    {
            //        p = p * 2;
            //        whileCount++;
            //    }
            //    q = p - q;
            //    forCount++;
            //}

            //int j = 2;
            //int whileCount = 0;
            //int forCount = 0;
            //for (int i = 1; i < 100; i = i * 2)
            //{
            //    j = j - 1;
            //    while (j < 25)
            //    {
            //        j = j + 5;
            //        whileCount++;
            //    }
            //    forCount++;



            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //// Loops Exercise from page 68
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobby Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn't 10");
            }
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            Console.WriteLine("The answer is " + count);
        }
    }
}
