using System;
using System.Collections.Generic;

namespace PROGCRAFT_Demo
{
    class Utility
    {
        //public static method that can be used in other classes
        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        //public string ConvertLowerCase(string message)
        //{
        //    return message.ToLower();
        //}
        public static string ShowAllItemsInList(List<Item> items)
        {
            string output = "";

            foreach(Item i in items)
            {
                output += $"{i.Name} ({i.Quantity}) {Environment.NewLine}";
            }

            return output;
        }
        public string ConvertLowerCase(string message) => message.ToLower();
    }
}
