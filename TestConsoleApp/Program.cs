using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myVariable = "Hello World!";
            string myStringVariable;
            myStringVariable = "Steve";

            int myIntVariable;
            myIntVariable = 123456789;

            decimal myDecimalVariable;
            myDecimalVariable = 123456789.123m;

            bool myBool = false;

            if (myBool)
            {
                Console.WriteLine("We'll never hitthis code.");
            }

            switch (myIntVariable)
            {
                case 1:
                    Console.WriteLine("We'll never hitthis code.");
                    break;
                case 2:
                    Console.WriteLine("We'll possibly hitthis code.");
                    break;
                default:
                    Console.WriteLine("We'll never hitthis code.");
                    break;
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"we're on iteration {i}");
            }



            DateTime myDateTime = new DateTime();

            var myThing = new { Stuff = "Steve" };

            List<string> myStrings = new List<string>();
            myStrings.Add("1");
            myStrings.Add("2");
            myStrings.Insert(1, "blirg");
            myStrings.Add("3");
            myStrings.Remove("3");
            myStrings.RemoveAt(1);

            foreach (var myString in myStrings)
            {
                Console.WriteLine(myString);
            }

            Console.WriteLine(myStringVariable, myStrings);
        }
    }
}
