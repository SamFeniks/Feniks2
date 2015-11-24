//for anyone looking at this script like wtf is dis; just testing github
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace
namespace Samscoolcode
{
    // Class (contains functionality)
    class Program
    {
        // Function (entry point)
        static void Main(string[] args)
        {
            PrintFooToScreen100Times();

            Console.WriteLine("Type a number, any number?");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == 'a')
            {
                Console.WriteLine("That is not a number, you idiot");
            }
            else
            {
                Console.WriteLine("Did you type {0}", keyInfo.KeyChar.ToString());
            }
        }

        /// <summary>
        /// All this function does is print Foo to the screen
        /// </summary>
        static void PrintFooToScreen()
        {
            Console.WriteLine("Foo");
        }

        static void PrintFooToScreen100Times()
        {
            for(int counter=0; counter <= 100; counter++)
            {
                PrintFooToScreen();
            }
        }
    }
}
